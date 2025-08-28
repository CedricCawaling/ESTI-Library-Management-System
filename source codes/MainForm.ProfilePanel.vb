Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Partial Class MainForm
    ' ========== PROFILE MANAGEMENT ==========
    ' Includes: LoadProfilePanel, SaveProfile, fullname/contact filters, photo upload

    Private Function GetProfileImagePath(fileName As String) As String
        Return Path.Combine(ProfileFolder, fileName)
    End Function

    Private Function ResizeImage(original As Image, size As Size) As Image
        Dim resized = New Bitmap(size.Width, size.Height)
        Using g = Graphics.FromImage(resized)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(original, New Rectangle(Point.Empty, size))
        End Using
        Return resized
    End Function

    ' Load profile into panel
    Private Sub LoadProfilePanel()
        txtUsername.Text = LoggedInUsername
        txtFullname.Text = LoggedInFullname
        txtContact.Text = LoggedInContact

        ' Load profile picture filename from database if not already present
        Dim profileImageFile = GetProfilePictureFileFromDB(LoggedInUsername)
        lblFilePath.Text = profileImageFile
        currentProfileImagePath = GetProfileImagePath(profileImageFile)

        ' Load the actual image
        If File.Exists(currentProfileImagePath) Then
            Using fs = New FileStream(currentProfileImagePath, FileMode.Open, FileAccess.Read)
                picProfile.Image = Image.FromStream(fs)
            End Using
        Else
            picProfile.Image = My.Resources.DefaultProfile
        End If
    End Sub
    Private Function GetProfilePictureFileFromDB(username As String) As String
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ProfilePicturePath FROM Admin WHERE AdminUsername = @username", con)
            cmd.Parameters.AddWithValue("@username", username)
            con.Open()
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, result.ToString(), "")
        End Using
    End Function


    ' Upload new profile picture
    Private Sub btnChoosePhoto_Click(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            ofd.Title = "Select a Profile Picture"

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim sourcePath = ofd.FileName
                Dim fileName = Path.GetFileNameWithoutExtension(sourcePath) & "_" & Guid.NewGuid().ToString("N").Substring(0, 6) & ".jpg"
                Dim targetPath = GetProfileImagePath(fileName)

                If Not Directory.Exists(ProfileFolder) Then Directory.CreateDirectory(ProfileFolder)

                ' Resize before saving
                Dim original = Image.FromFile(sourcePath)
                Dim resized = ResizeImage(original, New Size(150, 150))
                resized.Save(targetPath, ImageFormat.Jpeg)

                currentProfileImagePath = targetPath
                lblFilePath.Text = fileName

                picProfile.Image = resized
            End If
        End Using
    End Sub

    ' Save updated profile info
    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        If String.IsNullOrWhiteSpace(txtFullname.Text) OrElse String.IsNullOrWhiteSpace(txtContact.Text) Then
            MessageBox.Show("Full Name and Contact Info cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Save changes to your profile?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Admin SET AdminFullname = @fullname, ContactInfo = @contact, ProfilePicturePath = @photo WHERE AdminUsername = @username", con)
            cmd.Parameters.AddWithValue("@fullname", txtFullname.Text.Trim())
            cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
            cmd.Parameters.AddWithValue("@photo", lblFilePath.Text.Trim())
            cmd.Parameters.AddWithValue("@username", LoggedInUsername)

            con.Open()
            Dim rows = cmd.ExecuteNonQuery()

            If rows > 0 Then
                LoggedInFullname = txtFullname.Text.Trim()
                LoggedInContact = txtContact.Text.Trim()
                currentProfileImagePath = GetProfileImagePath(lblFilePath.Text.Trim())

                lblName.Text = LoggedInFullname

                Using fs = New FileStream(currentProfileImagePath, FileMode.Open, FileAccess.Read)
                    picProfile.Image = Image.FromStream(fs)
                End Using

                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub

    ' Undo changes
    Private Sub btnResetProfile_Click(sender As Object, e As EventArgs) Handles btnResetProfile.Click
        LoadProfilePanel()
    End Sub

    ' Drag-and-drop photo upload support
    Private Sub picProfile_DragEnter(sender As Object, e As DragEventArgs) Handles picProfile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub picProfile_DragDrop(sender As Object, e As DragEventArgs) Handles picProfile.DragDrop
        Dim files = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 Then
            Dim filePath = files(0)
            If File.Exists(filePath) Then
                Dim ext = Path.GetExtension(filePath).ToLower()
                If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".bmp" Then
                    Dim fileName = Path.GetFileNameWithoutExtension(filePath) & "_" & Guid.NewGuid().ToString("N").Substring(0, 6) & ".jpg"
                    Dim targetPath = GetProfileImagePath(fileName)
                    If Not Directory.Exists(ProfileFolder) Then Directory.CreateDirectory(ProfileFolder)

                    Dim original = Image.FromFile(filePath)
                    Dim resized = ResizeImage(original, New Size(150, 150))
                    resized.Save(targetPath, ImageFormat.Jpeg)

                    currentProfileImagePath = targetPath
                    lblFilePath.Text = fileName
                    picProfile.Image = resized
                End If
            End If
        End If
    End Sub

    ' Input filters
    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged
        Dim original = txtFullname.Text
        Dim filtered = System.Text.RegularExpressions.Regex.Replace(original, "[^a-zA-Z\s]", "")
        If original <> filtered Then
            Dim cursor = txtFullname.SelectionStart - 1
            txtFullname.Text = filtered
            txtFullname.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only letters and spaces are allowed.", txtFullname, 2000)
        End If
    End Sub
    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Dim filtered = FormUtils.FilterContact(txtContact.Text)
        If txtContact.Text <> filtered Then
            Dim cursor = txtContact.SelectionStart - 1
            txtContact.Text = filtered
            txtContact.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only numbers are allowed in the contact field.", txtContact, 2000)
        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Configuration


Public Class Login

    Private isExitingToMain As Boolean = False

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        txtAdminPW.PasswordChar = "●"c
        chkShowPassword.Checked = False

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtAdminUN.Text) OrElse String.IsNullOrWhiteSpace(txtAdminPW.Text) Then
            MessageBox.Show("Please enter both username and password.", "Missing Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim inputPassword As String = txtAdminPW.Text.Trim()
        Dim hashedPassword As String = (New AdminManager()).HashPassword(inputPassword)
        Dim defaultHashedPassword As String = (New AdminManager()).HashPassword("@password123")

        Dim connectionString As String = FormUtils.GetConnectionString()
        Try
            Using con As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand("SELECT TOP 1 * FROM Admin WHERE AdminUsername = @username AND Password = @password", con)
                cmd.Parameters.AddWithValue("@username", txtAdminUN.Text.Trim())
                cmd.Parameters.AddWithValue("@password", hashedPassword)

                con.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows AndAlso reader.Read() Then
                        ' ✅ Assign to MainForm
                        MainForm.LoggedInAdminID = reader("AdminID").ToString()
                        MainForm.LoggedInUsername = reader("AdminUsername").ToString()
                        MainForm.LoggedInFullname = reader("AdminFullname").ToString()
                        MainForm.LoggedInContact = reader("ContactInfo").ToString()
                        MainForm.LoggedInRole = reader("Role").ToString()

                        If Not IsDBNull(reader("ProfilePicturePath")) Then
                            Dim profileFilename = reader("ProfilePicturePath").ToString()
                            MainForm.currentProfileImagePath = Path.Combine(Application.StartupPath, "ProfilePics", profileFilename)
                        Else
                            MainForm.currentProfileImagePath = ""
                        End If
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using
            End Using

            ' ✅ Force password change if using default
            If hashedPassword = defaultHashedPassword Then
                Dim result = MessageBox.Show(
                "You are currently using the default password. For security reasons, you must change your password before proceeding." & vbCrLf & vbCrLf &
                "Would you like to change it now?",
                "Password Change Required",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            )

                If result = DialogResult.OK Then
                    Dim setPWForm As New SetPassword()
                    setPWForm.LoggedInUsername = MainForm.LoggedInUsername
                    setPWForm.ShowDialog()

                    If Not setPWForm.PasswordUpdated Then
                        MessageBox.Show("You must change your password before accessing the system.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Else
                    MessageBox.Show("Access denied. Please change your password to continue.", "Login Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End If

            ' ✅ Login successful
            txtAdminUN.Clear()
            txtAdminPW.Clear()
            MainForm.IsLoggingOut = False

            Dim main As New MainForm()
            isExitingToMain = True
            main.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isExitingToMain Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtAdminPW.PasswordChar = ControlChars.NullChar ' Unmask password
        Else
            txtAdminPW.PasswordChar = "●"c ' Mask password again
        End If
    End Sub
    ' ========== LIBRARY ACCESS RECORD ==========
    Private Sub LibraryAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.AddRange(New String() {"Student", "Teacher", "Visitor"})

        cmbPurpose.Items.Clear()
        cmbPurpose.Items.AddRange(New String() {"Reading", "Borrowing Books", "Returning Books", "Research", "Printing", "Others"})
        txtMiddleInitial.MaxLength = 9 ' 5 letters + 4 periods like A.B.C.D.E.
        ToolTip1.SetToolTip(txtMiddleInitial, "Enter up to 5 initials. Letters only. Auto-formats like A.B.C.")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. Validate required fields
        If String.IsNullOrWhiteSpace(txtLastname.Text) OrElse
       String.IsNullOrWhiteSpace(txtFirstname.Text) OrElse
       cmbRole.SelectedIndex = -1 OrElse
       cmbPurpose.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Assemble full name: "LASTNAME, FIRSTNAME M."
        Dim lastName As String = txtLastname.Text.Trim().ToUpper()
        Dim firstName As String = txtFirstname.Text.Trim().ToUpper()
        Dim middleInitial As String = txtMiddleInitial.Text.Trim().ToUpper()
        Dim fullName As String = $"{lastName}, {firstName} {middleInitial}".Trim()

        ' 3. Get role and purpose
        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim purpose As String = cmbPurpose.SelectedItem.ToString()

        ' 4. Prepare connection string from app.config
        Dim conStr As String = FormUtils.GetConnectionString()

        ' 5. If purpose is Borrowing or Returning, check for duplicates
        If purpose = "Borrowing Books" OrElse purpose = "Returning Books" Then
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM LibraryLogEntry WHERE FullName = @FullName AND Purpose = @Purpose AND DateLogged = CAST(GETDATE() AS DATE)", con)
                checkCmd.Parameters.AddWithValue("@FullName", fullName)
                checkCmd.Parameters.AddWithValue("@Purpose", purpose)

                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("This user has already logged in today for the same purpose.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using
        End If
        ' 6. Save the log entry
        Try
            Using con As New SqlConnection(conStr)
                con.Open()
                Dim insertCmd As New SqlCommand("INSERT INTO LibraryLogEntry (FullName, Role, Purpose, DateLogged, TimeIn) VALUES (@FullName, @Role, @Purpose, @DateLogged, @TimeIn)", con)
                insertCmd.Parameters.AddWithValue("@FullName", fullName)
                insertCmd.Parameters.AddWithValue("@Role", role)
                insertCmd.Parameters.AddWithValue("@Purpose", purpose)
                insertCmd.Parameters.AddWithValue("@DateLogged", Date.Now.Date)
                insertCmd.Parameters.AddWithValue("@TimeIn", Date.Now)
                insertCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Log Entry successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearLogEntryFields()

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the record." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtMiddleInitial_Leave(sender As Object, e As EventArgs) Handles txtMiddleInitial.Leave
        ' Remove non-letters
        Dim rawText As String = New String(txtMiddleInitial.Text.Where(Function(c) Char.IsLetter(c)).ToArray())

        ' Limit to 5
        If rawText.Length > 5 Then rawText = rawText.Substring(0, 5)

        ' Format to A.B.C. style
        Dim formatted As String = ""
        For Each c As Char In rawText.ToUpper()
            formatted += c & "."
        Next

        txtMiddleInitial.Text = formatted
    End Sub

    Private Sub txtMiddleInitial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleInitial.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True ' Block non-letters
        End If
    End Sub
    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub
    Private Sub FormatNameTextbox(txtBox As TextBox)
        Dim input As String = txtBox.Text

        ' Allow only letters, apostrophes, hyphens, and spaces
        input = New String(input.Where(Function(c) Char.IsLetter(c) Or c = " "c Or c = "-"c Or c = "'"c).ToArray())

        ' Capitalize each word
        Dim words = input.Split({" "c}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next

        ' Join back with single space
        Dim formatted = String.Join(" ", words)

        ' Update textbox
        If txtBox.Text <> formatted Then
            txtBox.Text = formatted
        End If
    End Sub
    Private Sub txtFirstname_Leave(sender As Object, e As EventArgs) Handles txtFirstname.Leave
        FormatNameTextbox(txtFirstname)
    End Sub

    Private Sub txtLastname_Leave(sender As Object, e As EventArgs) Handles txtLastname.Leave
        FormatNameTextbox(txtLastname)
    End Sub


    Private Sub ClearLogEntryFields()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMiddleInitial.Clear()
        cmbRole.SelectedIndex = -1
        cmbPurpose.SelectedIndex = -1
    End Sub

    '========== Log-In Input Behaviour ==========
    Private Sub txtAdminUN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdminUN.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtAdminPW)
    End Sub
    Private Sub txtAdminPW_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdminPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    '========== Log Entry Input Behaviour ==========
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearLogEntryFields()
    End Sub
    Private Sub txtFirstname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstname.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtLastname)
    End Sub
    Private Sub txtLastname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLastname.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtMiddleInitial)
    End Sub
    Private Sub txtFullname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMiddleInitial.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, cmbRole)
    End Sub
    Private Sub cmbRole_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbRole.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, cmbPurpose)
    End Sub

End Class

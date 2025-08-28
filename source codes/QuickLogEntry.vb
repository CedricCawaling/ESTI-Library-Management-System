Imports System.Data.SqlClient
Imports System.Configuration

Public Class QuickLogEntry

    Private Sub QuickLogEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.AddRange({"Student", "Faculty", "Guest"})
        cmbPurpose.Items.AddRange({"Borrowing", "Returning", "Reading", "Research", "Internet", "Others"})

        cmbRole.SelectedIndex = -1
        cmbPurpose.SelectedIndex = -1
    End Sub
    Private Function AlreadyLoggedToday(fullName As String, purpose As String) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT COUNT(*) 
                FROM LibraryLogEntry 
                WHERE FullName = @FullName 
                  AND Purpose = @Purpose 
                  AND CAST(DateLogged AS DATE) = CAST(GETDATE() AS DATE)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FullName", fullName)
                cmd.Parameters.AddWithValue("@Purpose", purpose)

                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
    Private Sub LibraryAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
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
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearLogEntryFields()
    End Sub
    '========== Log Entry Input Behaviour ==========

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

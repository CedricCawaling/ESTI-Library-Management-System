Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class CreateAdmin

    Private Sub CreateAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Librarian")
        cmbRole.SelectedIndex = 0

        txtSetPassword.PasswordChar = "●"c
        chkShowPW.Checked = False
        lblPasswordStrength.Text = ""
        btnClear.Text = "Cancel"
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Magenta
        Me.TransparencyKey = Color.Magenta
        Me.AllowTransparency = True
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        If AreFieldsEmpty() OrElse cmbRole.SelectedIndex = -1 Then
            MessageBox.Show("All fields are required, including password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim password As String = txtSetPassword.Text.Trim()
        Dim pattern As String = "^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?:{}|<>]).{8,}$"
        If Not Regex.IsMatch(password, pattern) Then
            MessageBox.Show("Password must be at least 8 characters and include an uppercase letter, a number, and a special character.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If IsUsernameExists(txtUsername.Text.Trim()) Then
            MessageBox.Show("Username already exists. Please use a different one.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hashedPassword As String = (New AdminManager()).HashPassword(password)

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)

            Try
                Using cmd As New SqlCommand("INSERT INTO Admin (AdminUsername, AdminFullname, ContactInfo, Role, Password) VALUES (@u, @f, @c, @r, @p)", con)
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@f", txtFullname.Text.Trim())
                    cmd.Parameters.AddWithValue("@c", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@r", cmbRole.Text)
                    cmd.Parameters.AddWithValue("@p", hashedPassword)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to create admin. Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

        End Using

        MessageBox.Show("Admin account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ✅ Get the admin ID safely
        Dim adminID = GetAdminID(txtUsername.Text.Trim())
        If adminID = -1 Then
            MessageBox.Show("Admin account creation failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        MainForm.LoggedInAdminID = adminID
        MainForm.LoggedInUsername = txtUsername.Text.Trim()
        MainForm.LoggedInFullname = txtFullname.Text.Trim()
        MainForm.LoggedInContact = txtContact.Text.Trim()
        MainForm.LoggedInRole = cmbRole.Text
        MainForm.currentProfileImagePath = ""

        MainForm.Show()
        Me.Close()

    End Sub

    Private Function GetAdminID(username As String) As Integer
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT AdminID FROM Admin WHERE AdminUsername = @username", con)
                cmd.Parameters.AddWithValue("@username", username)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                Return If(result IsNot Nothing, Convert.ToInt32(result), -1)
            End Using
        End Using
    End Function

    Private Function AreFieldsEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(txtUsername.Text) AndAlso
               String.IsNullOrWhiteSpace(txtFullname.Text) AndAlso
               String.IsNullOrWhiteSpace(txtContact.Text) AndAlso
               String.IsNullOrWhiteSpace(txtSetPassword.Text)
    End Function

    Private Sub UpdateClearButtonText()
        btnClear.Text = If(AreFieldsEmpty(), "Cancel", "Clear")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If AreFieldsEmpty() Then
            If MessageBox.Show("Setup is not complete. Exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        Else
            txtUsername.Clear()
            txtFullname.Clear()
            txtContact.Clear()
            txtSetPassword.Clear()
            lblPasswordStrength.Text = ""
            cmbRole.SelectedIndex = 0
            btnAddAdmin.Enabled = False
            btnClear.Text = "Cancel"
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        Dim filtered = FormUtils.FilterUsername(txtUsername.Text)
        If txtUsername.Text <> filtered Then
            Dim cursor = txtUsername.SelectionStart - 1
            txtUsername.Text = filtered
            txtUsername.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Spaces are not allowed in the username.", txtUsername, 2000)
        End If
        UpdateClearButtonText()
    End Sub

    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged
        Dim filtered = FormUtils.FilterFullname(txtFullname.Text)
        If txtFullname.Text <> filtered Then
            Dim cursor = txtFullname.SelectionStart - 1
            txtFullname.Text = filtered
            txtFullname.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only letters and spaces are allowed.", txtFullname, 2000)
        End If
        UpdateClearButtonText()
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Dim filtered = FormUtils.FilterContact(txtContact.Text)
        If txtContact.Text <> filtered Then
            Dim cursor = txtContact.SelectionStart - 1
            txtContact.Text = filtered
            txtContact.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only numbers are allowed in the contact field.", txtContact, 2000)
        End If
        UpdateClearButtonText()
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        UpdateClearButtonText()
    End Sub

    Private Function IsUsernameExists(username As String) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM Admin WHERE AdminUsername COLLATE SQL_Latin1_General_CP1_CS_AS = @username", con)
                cmd.Parameters.AddWithValue("@username", username)
                con.Open()
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Private Sub chkShowPW_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPW.CheckedChanged
        txtSetPassword.PasswordChar = If(chkShowPW.Checked, ControlChars.NullChar, "●"c)
    End Sub

    Private Sub txtSetPassword_TextChanged(sender As Object, e As EventArgs) Handles txtSetPassword.TextChanged
        Dim password = txtSetPassword.Text.Trim()
        lblPasswordStrength.Text = ""
        btnAddAdmin.Enabled = False

        If password = "" Then
            UpdateClearButtonText()
            Return
        End If

        Select Case PasswordUtils.GetPasswordStrength(password)
            Case "Weak"
                lblPasswordStrength.Text = "Weak password"
                lblPasswordStrength.ForeColor = Color.Red
            Case "Medium"
                lblPasswordStrength.Text = "Medium strength"
                lblPasswordStrength.ForeColor = Color.Orange
            Case "Strong"
                lblPasswordStrength.Text = "Strong password"
                lblPasswordStrength.ForeColor = Color.YellowGreen
                btnAddAdmin.Enabled = True
        End Select

        UpdateClearButtonText()


    End Sub
    '========== Create Admin Textbox behaviour ==========
    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtFullname)
    End Sub
    Private Sub txtFullname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullname.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtContact)
    End Sub

    Private Sub txtContact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContact.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, cmbRole)
    End Sub
    Private Sub cmbRole_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbRole.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtSetPassword)
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        ' Prevent app from staying open or becoming blank if admin not created
        If Not MainForm.Visible Then
            Application.Exit()
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            Return True ' Block ESC
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function


End Class

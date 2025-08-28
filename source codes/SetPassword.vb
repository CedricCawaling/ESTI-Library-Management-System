Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports OtpNet
Imports QRCoder
Imports System.Drawing

Public Class SetPassword
    Public LoggedInUsername As String
    Public PasswordUpdated As Boolean = False

    ' 🔹 On form load: initialize UI state
    Private Sub SetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        txtSetPassword.PasswordChar = "●"c
        chkShowPW.Checked = False
        lblPasswordStrength.Text = ""
        btnSavePW.Enabled = False
        ToolTip1.AutoPopDelay = 15000
        ToolTip1.InitialDelay = 100
        ToolTip1.ReshowDelay = 100
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipTitle = "Password Requirements"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    ' 🔹 Password text changed: check strength and enable Save if valid
    Private Sub txtSetPassword_TextChanged(sender As Object, e As EventArgs) Handles txtSetPassword.TextChanged
        Dim password = txtSetPassword.Text.Trim()
        Dim strength As String = PasswordUtils.GetPasswordStrength(txtSetPassword.Text.Trim())


        If password = "" Then
            lblPasswordStrength.Text = ""
            Return
        End If
        Select Case strength
            Case "Weak"
                lblPasswordStrength.Text = "Weak password"
                lblPasswordStrength.ForeColor = Color.Red
                btnSavePW.Enabled = False
            Case "Medium"
                lblPasswordStrength.Text = "Medium strength"
                lblPasswordStrength.ForeColor = Color.Orange
                btnSavePW.Enabled = False
            Case "Strong"
                lblPasswordStrength.Text = "Strong password"
                lblPasswordStrength.ForeColor = Color.YellowGreen
                btnSavePW.Enabled = True
            Case Else
                lblPasswordStrength.Text = ""
                btnSavePW.Enabled = False
        End Select
    End Sub

    ' 🔹 Save password button
    Private Sub btnSavePW_Click(sender As Object, e As EventArgs) Handles btnSavePW.Click
        Dim newPassword As String = txtSetPassword.Text.Trim()

        If String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter a new password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPassword = "@password123" Then
            MessageBox.Show("You cannot use the default password. Please choose a different one.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 🔐 Double-check regex pattern for safety
        Dim pattern As String = "^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?:{}|<>]).{8,}$"
        If Not Regex.IsMatch(newPassword, pattern) Then
            MessageBox.Show("Password must be at least 8 characters and include an uppercase letter, number, and symbol.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hashedPassword As String = (New AdminManager()).HashPassword(newPassword)

        Try
            Dim connectionString As String = FormUtils.GetConnectionString()
            Using con As New SqlConnection(connectionString)

                Dim cmd As New SqlCommand("UPDATE Admin SET Password = @Password WHERE AdminUsername = @Username", con)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Username", LoggedInUsername)

                con.Open()
                cmd.ExecuteNonQuery()
            End Using

            PasswordUpdated = True
            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🔹 Show/hide password
    Private Sub chkShowPW_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPW.CheckedChanged
        If chkShowPW.Checked Then
            txtSetPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            txtSetPassword.PasswordChar = "●"c ' Hide password
        End If
    End Sub

    Private Sub txtSetPassword_GotFocus(sender As Object, e As EventArgs) Handles txtSetPassword.GotFocus
        FormUtils.ShowPasswordTooltip(txtSetPassword)
    End Sub


End Class

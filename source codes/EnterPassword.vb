Public Class EnterPassword
    ' Property to store entered password
    Public Property EnteredPassword As String = ""

    ' On form load: hide password by default
    Private Sub EnterPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        chkShowPassword.Checked = False
        SetPasswordVisibility(False)
        txtPassword.Focus()
    End Sub

    ' Toggle password visibility
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        SetPasswordVisibility(chkShowPassword.Checked)
    End Sub

    ' Helper to show/hide password
    Private Sub SetPasswordVisibility(show As Boolean)
        txtPassword.PasswordChar = If(show, ControlChars.NullChar, "●"c)
    End Sub

    ' Confirm entered password
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter your password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        EnteredPassword = txtPassword.Text.Trim()
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnter.PerformClick()
        End If
    End Sub

End Class
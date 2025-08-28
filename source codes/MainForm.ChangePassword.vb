Partial Class MainForm
    ' ========== Password Management ==========

    Private Sub TogglePasswordVisibility(txtBox As TextBox, btn As Button, ByRef flag As Boolean)
        flag = Not flag
        txtBox.UseSystemPasswordChar = Not flag
        btn.Image = If(flag, My.Resources.EyeSlash, My.Resources.Eye)
    End Sub

    Private Sub btnViewCurrent_Click(sender As Object, e As EventArgs) Handles btnViewCurrent.Click
        TogglePasswordVisibility(txtCurrentPassword, btnViewCurrent, showCurrent)
    End Sub

    Private Sub btnViewNew_Click(sender As Object, e As EventArgs) Handles btnViewNew.Click
        TogglePasswordVisibility(txtNewPassword, btnViewNew, showNew)
    End Sub

    Private Sub btnViewConfirm_Click(sender As Object, e As EventArgs) Handles btnViewConfirm.Click
        TogglePasswordVisibility(txtConfirmPassword, btnViewConfirm, showConfirm)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "Retry" Then
            btnSave.Enabled = False
            btnSave.Text = "Save"
            GenerateQRCode()
            ShowBalloon(txtCode, "Enter the 6-digit code from your authenticator app to verify.")
            Return
        End If

        Dim parent = CType(Me.TopLevelControl, MainForm)
        Dim username = parent.LoggedInUsername
        Dim manager As New AdminManager()

        If String.IsNullOrWhiteSpace(txtCurrentPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Please fill in all password fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("New password and confirmation do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text = txtCurrentPassword.Text Then
            MessageBox.Show("New password cannot be the same as the current password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not manager.ValidatePassword(username, txtCurrentPassword.Text) Then
            MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        btnSave.Enabled = False
        GenerateQRCode()
        ShowBalloon(txtCode, "Enter the 6-digit code from your authenticator app to verify.")
    End Sub

    Private Sub GenerateQRCode()
        Dim parent = CType(Me.TopLevelControl, MainForm)
        Dim username = parent.LoggedInUsername
        Dim manager As New AdminManager()

        Dim secret = manager.GetOTPSecret(username)
        If String.IsNullOrEmpty(secret) Then
            Dim bytes = OtpNet.KeyGeneration.GenerateRandomKey(20)
            secret = OtpNet.Base32Encoding.ToString(bytes)
            manager.SetOTPSecret(username, secret)
        End If

        Dim otpUrl = $"otpauth://totp/LMSSystem:{username}?secret={secret}&issuer=LMSSystem"
        Dim qrGen As New QRCoder.QRCodeGenerator()
        Dim qrData = qrGen.CreateQrCode(otpUrl, QRCoder.QRCodeGenerator.ECCLevel.Q)
        Dim qr = New QRCoder.QRCode(qrData)
        picQRCode.Image = qr.GetGraphic(5)

        otpTimeLeft = 90
        otpActive = True
        btnVerify.Enabled = True
        otpTimer.Interval = 1000
        otpTimer.Start()
    End Sub

    Private Sub otpTimer_Tick(sender As Object, e As EventArgs) Handles otpTimer.Tick
        otpTimeLeft -= 1
        If otpTimeLeft <= 0 Then
            otpTimer.Stop()
            otpActive = False

            btnVerify.Enabled = False
            btnSave.Enabled = True
            btnSave.Text = "Retry" ' ← Change text to Retry

            txtCode.Clear()
            picQRCode.Image = Nothing

            MessageBox.Show("OTP code expired. Click Retry to generate a new one.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim parent = CType(Me.TopLevelControl, MainForm)
        Dim username = parent.LoggedInUsername
        Dim manager As New AdminManager()

        Dim secret = manager.GetOTPSecret(username)
        If String.IsNullOrEmpty(secret) Then
            MessageBox.Show("No OTP secret found. Try clicking Save again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim totp = New OtpNet.Totp(OtpNet.Base32Encoding.ToBytes(secret))
            If totp.VerifyTotp(txtCode.Text.Trim(), Nothing, OtpNet.VerificationWindow.RfcSpecifiedNetworkDelay) Then
                otpTimer.Stop()
                otpActive = False
                picQRCode.Image = Nothing
                txtCode.Clear()

                If manager.UpdatePassword(username, txtNewPassword.Text) Then
                    MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCurrentPassword.Clear()
                    txtNewPassword.Clear()
                    txtConfirmPassword.Clear()
                    btnSave.Text = "Save"
                    btnSave.Enabled = False
                Else
                    MessageBox.Show("Something went wrong saving your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid OTP code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error verifying OTP: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowBalloon(ctrl As Control, message As String)
        Dim tip As New ToolTip With {
            .IsBalloon = True,
            .ToolTipIcon = ToolTipIcon.Info,
            .ToolTipTitle = "2FA Verification",
            .AutoPopDelay = 12000,
            .InitialDelay = 100,
            .ReshowDelay = 100
        }
        tip.SetToolTip(ctrl, message)
        tip.Show(message, ctrl, 0, ctrl.Height + 5, 12000)
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        Dim password = txtNewPassword.Text.Trim()

        If password = "" Then
            lblPasswordStrength.Text = ""
            btnSave.Enabled = False
            Return
        End If

        Dim strength As String = PasswordUtils.GetPasswordStrength(txtNewPassword.Text.Trim())


        Select Case strength
            Case "Weak"
                lblPasswordStrength.Text = "Weak password"
                lblPasswordStrength.ForeColor = Color.Red
                btnSave.Enabled = False
            Case "Medium"
                lblPasswordStrength.Text = "Medium strength"
                lblPasswordStrength.ForeColor = Color.Orange
                btnSave.Enabled = False
            Case "Strong"
                lblPasswordStrength.Text = "Strong password"
                lblPasswordStrength.ForeColor = Color.YellowGreen
                btnSave.Enabled = True
            Case Else
                lblPasswordStrength.Text = ""
                btnSave.Enabled = False
        End Select
    End Sub
    Private Sub txtNewPassword_GotFocus(sender As Object, e As EventArgs) Handles txtNewPassword.GotFocus
        FormUtils.ShowPasswordTooltip(txtNewPassword)
    End Sub

End Class
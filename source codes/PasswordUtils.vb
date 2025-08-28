Public Class PasswordUtils
    Public Shared Function GetPasswordStrength(password As String) As String
        Dim score As Integer = 0
        If password.Length >= 8 Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d") Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[!@#$%^&*(),.?:{}|<>]") Then score += 1

        Select Case score
            Case <= 1 : Return "Weak"
            Case 2 To 3 : Return "Medium"
            Case >= 4 : Return "Strong"
            Case Else : Return ""
        End Select
    End Function
End Class

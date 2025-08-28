Imports System.Configuration

Public Class FormUtils
    ' Shared property to access the safe fallback font
    Public Shared ReadOnly Property SafeFont As Font
        Get
            Static _font As Font = GetBestAvailableFont(10)
            Return _font
        End Get
    End Property

    ' Returns the best available font from the preferred list
    Public Shared Function GetBestAvailableFont(size As Single, Optional style As FontStyle = FontStyle.Regular) As Font
        Dim preferredFonts As String() = {"Bahnschrift", "Segoe UI", "Georgia", "Arial"}
        For Each fontName In preferredFonts
            Try
                Return New Font(fontName, size, style)
            Catch
            End Try
        Next
        Return SystemFonts.DefaultFont
    End Function

    ' Recursively applies the given font to all controls in the form
    Public Shared Sub ApplyFontToAllControls(parent As Control, font As Font)
    End Sub
    Public Shared Function FilterFullname(input As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(input, "[^a-zA-Z\s]", "")
    End Function
    Public Shared Function FilterContact(input As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")
    End Function

    Public Shared Function FilterUsername(input As String) As String
        Return input.Replace(" ", "")
    End Function
    Private Shared shownPasswordTooltips As New HashSet(Of Control)

    Public Shared Sub ShowPasswordTooltip(ctrl As Control)
        If shownPasswordTooltips.Contains(ctrl) Then Exit Sub

        Dim tip As New ToolTip With {
            .IsBalloon = True,
            .ToolTipIcon = ToolTipIcon.Info,
            .ToolTipTitle = "Password Requirements",
            .AutoPopDelay = 10000,
            .InitialDelay = 100,
            .ReshowDelay = 100
        }

        tip.SetToolTip(ctrl, "Password must be at least 8 characters and include:" & vbCrLf &
                            "• 1 uppercase letter" & vbCrLf &
                            "• 1 number" & vbCrLf &
                            "• 1 special character (e.g. !@#$%)")

        tip.Show(tip.GetToolTip(ctrl), ctrl, 0, ctrl.Height - 150, 12000)

        shownPasswordTooltips.Add(ctrl)
    End Sub
    ' 🔽 ADD THESE TWO METHODS 🔽

    ' Option 1: Focus a specific control
    Public Shared Sub HandleEnterKeyMoveFocus(e As KeyEventArgs, nextControl As Control)
        If e.KeyCode = Keys.Enter Then
            nextControl.Focus()
            ' Special case for ComboBox
            If TypeOf nextControl Is ComboBox Then
                CType(nextControl, ComboBox).DroppedDown = True
            End If
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Option 2: Automatically move to next control based on tab order
    Public Shared Sub FocusNextControlOnEnter(form As Form, sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            form.SelectNextControl(CType(sender, Control), True, True, True, True)
            e.SuppressKeyPress = True
        End If
    End Sub
    Public Shared Function GetConnectionString() As String
        Dim conn = ConfigurationManager.ConnectionStrings("LMS.My.MySettings.LMSConnectionString")?.ConnectionString
        If String.IsNullOrEmpty(conn) Then
            MessageBox.Show("Connection string not found. Please configure your database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return conn
    End Function

End Class

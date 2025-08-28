Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Public Class RoundedPanel
    Inherits Panel

    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                               ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
                                               ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 25, 25))
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 25, 25))
    End Sub
End Class

Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundPictureBox
    Inherits PictureBox

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)

        ' Create a circular path
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)
        Me.Region = New Region(path)

        ' Optional: Draw border
        Dim borderColor As Color = Color.White  ' Change to your preferred border color
        Dim borderWidth As Integer = 3  ' Change to your preferred border width

        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pe.Graphics.DrawEllipse(New Pen(borderColor, borderWidth), 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub
End Class
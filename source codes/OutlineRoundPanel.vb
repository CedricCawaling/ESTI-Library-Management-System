Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class OutlineRoundPanel
    Inherits Panel

    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer,
                                               ByVal nRightRect As Integer, ByVal nBottomRect As Integer,
                                               ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    ' Property for the border color
    Private _borderColor As Color = Color.DarkGreen
    Public Property BorderColor() As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate() ' Redraw the panel
        End Set
    End Property

    ' Property for the border width
    Private _borderWidth As Integer = 3
    Public Property BorderWidth() As Integer
        Get
            Return _borderWidth
        End Get
        Set(value As Integer)
            _borderWidth = value
            Me.Invalidate() ' Redraw the panel
        End Set
    End Property

    ' Set rounded corners on creation
    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 25, 25))
    End Sub

    ' Adjust rounded corners on resize
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 25, 25))
    End Sub

    ' Draw the border (outline)
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graphics As Graphics = e.Graphics
        Dim cornerRadius As Integer = 25 ' Adjust for rounded corners

        ' Smooth the edges
        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Create a rounded rectangle path for the border
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90) ' Top-left
            path.AddArc(Me.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90) ' Top-right
            path.AddArc(Me.Width - cornerRadius - 1, Me.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90) ' Bottom-right
            path.AddArc(0, Me.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90) ' Bottom-left
            path.CloseFigure()

            ' Draw the rounded border
            Using pen As New Pen(_borderColor, _borderWidth)
                graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

End Class

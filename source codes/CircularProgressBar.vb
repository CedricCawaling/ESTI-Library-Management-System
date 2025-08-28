Imports System.Drawing.Drawing2D

Public Class CircularProgressBar
    Inherits UserControl

    Private _progressValue As Integer = 0
    Private _maxValue As Integer = 100
    Private _progressColor As Color = Color.FromArgb(54, 115, 13)
    Private _backgroundColor As Color = Color.LightGray

    ' Properties
    Public Property ProgressValue As Integer
        Get
            Return _progressValue
        End Get
        Set(value As Integer)
            _progressValue = Math.Min(Math.Max(value, 0), _maxValue)
            Me.Invalidate()
        End Set
    End Property

    Public Property MaxValue As Integer
        Get
            Return _maxValue
        End Get
        Set(value As Integer)
            _maxValue = Math.Max(1, value)
            Me.Invalidate()
        End Set
    End Property

    Public Property ProgressColor As Color
        Get
            Return _progressColor
        End Get
        Set(value As Color)
            _progressColor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BackgroundColor As Color
        Get
            Return _backgroundColor
        End Get
        Set(value As Color)
            _backgroundColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Draw the background circle
        Using bgBrush As New SolidBrush(_backgroundColor)
            g.FillEllipse(bgBrush, 0, 0, Width - 1, Height - 1)
        End Using

        ' Draw the progress arc
        Dim sweepAngle As Single = 360.0F * (_progressValue / _maxValue)
        Using progressPen As New Pen(_progressColor, 15) ' Adjust thickness here
            g.DrawArc(progressPen, 10, 10, Width - 20, Height - 20, -90, sweepAngle)
        End Using

        ' Draw the percentage text
        Dim font As New Font("Arial", 16, FontStyle.Bold)
        Dim text As String = _progressValue.ToString() & "%"
        Dim textSize As SizeF = g.MeasureString(text, font)
        Dim textX As Single = (Width - textSize.Width) / 2
        Dim textY As Single = (Height - textSize.Height) / 2
        Using textBrush As New SolidBrush(Color.Black)
            g.DrawString(text, font, textBrush, textX, textY)
        End Using
    End Sub
End Class

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class CustomBarChart
    Inherits UserControl

    Private _dataPoints As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer))()

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DataPoints As List(Of KeyValuePair(Of String, Integer))
        Get
            Return _dataPoints
        End Get
        Set(value As List(Of KeyValuePair(Of String, Integer)))
            _dataPoints = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BarColor As Color = Color.FromArgb(54, 115, 13)
    Public Property AxisColor As Color = Color.Black

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        If DataPoints.Count = 0 Then Exit Sub

        Dim marginLeft As Integer = 130
        Dim marginTop As Integer = 20
        Dim chartWidth As Integer = Me.Width - marginLeft - 30
        Dim chartHeight As Integer = Me.Height - 2 * marginTop

        Dim barHeight As Integer = CInt(chartHeight / DataPoints.Count * 0.6) + 5
        Dim spacing As Integer = CInt(chartHeight / DataPoints.Count)
        Dim trueMax As Integer = DataPoints.Max(Function(p) p.Value)
        Dim maxValue As Integer = If(trueMax <= 100, 100, trueMax)
        If maxValue = 0 Then maxValue = 1

        Dim barColors As Color() = {
            Color.SeaGreen, Color.SteelBlue, Color.Orange,
            Color.MediumPurple, Color.Crimson, Color.Goldenrod,
            Color.Teal, Color.DarkSlateBlue, Color.DarkOrange
        }

        Dim i As Integer = 0
        For Each point In DataPoints
            Dim barWidth As Single = (point.Value / maxValue) * chartWidth
            Dim x = marginLeft
            Dim y = marginTop + i * spacing

            ' Bar
            Dim colorIndex As Integer = i Mod barColors.Length
            Using barBrush As New SolidBrush(barColors(colorIndex))
                g.FillRectangle(barBrush, CSng(x), CSng(y), CSng(barWidth), CSng(barHeight))
            End Using

            ' Label (left)
            Dim labelRect As New RectangleF(0, y, marginLeft - 10, barHeight)
            Dim sfLabel As New StringFormat()
            sfLabel.Alignment = StringAlignment.Far ' Align right
            sfLabel.LineAlignment = StringAlignment.Center

            g.DrawString(point.Key, Me.Font, Brushes.Black, labelRect, sfLabel)

            ' Value (right of bar)
            Dim valueText = point.Value.ToString()
            Dim textSize = g.MeasureString(valueText, Me.Font)
            g.DrawString(valueText, Me.Font, Brushes.Black, CSng(x + barWidth + 5), CSng(y + (barHeight - textSize.Height) / 2))

            i += 1
        Next
    End Sub
    Public Sub New()
        Me.DoubleBuffered = True
        Me.ResizeRedraw = True
    End Sub

End Class

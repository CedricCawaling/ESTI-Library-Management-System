Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Collections.Generic

Public Class CustomLineChart
    Inherits UserControl

    ' Backing field for data
    Private _dataPoints As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer))()

    ' Prevent Designer from serializing this property
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DataPoints As List(Of KeyValuePair(Of String, Integer))
        Get
            Return _dataPoints
        End Get
        Set(value As List(Of KeyValuePair(Of String, Integer)))
            _dataPoints = value
            Me.Invalidate() ' Redraw the chart
        End Set
    End Property

    ' Chart customization options
    Public Property LineColor As Color = Color.SeaGreen
    Public Property AxisColor As Color = Color.Black

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.Clear(Me.BackColor)

        If DataPoints.Count < 2 Then Exit Sub

        ' Layout
        Dim margin As Integer = 40
        Dim chartWidth As Integer = Me.Width - 2 * margin
        Dim chartHeight As Integer = Me.Height - 2 * margin

        Dim maxY As Integer = DataPoints.Max(Function(p) p.Value)
        If maxY = 0 Then maxY = 1 ' Avoid divide by zero

        ' Draw axes
        Using axisPen As New Pen(AxisColor, 1)
            g.DrawLine(axisPen, margin, margin, margin, margin + chartHeight) ' Y-axis
            g.DrawLine(axisPen, margin, margin + chartHeight, margin + chartWidth, margin + chartHeight) ' X-axis
        End Using

        ' Draw data points
        Dim spacing As Single = chartWidth / (DataPoints.Count - 1)
        Dim points As New List(Of PointF)

        For i = 0 To DataPoints.Count - 1
            Dim x = margin + i * spacing
            Dim y = margin + chartHeight - (DataPoints(i).Value / maxY) * chartHeight
            points.Add(New PointF(x, y))

            ' X-axis label
            Dim lbl = DataPoints(i).Key
            Dim textSize = g.MeasureString(lbl, Me.Font)
            g.DrawString(lbl, Me.Font, Brushes.Black, x - textSize.Width / 2, margin + chartHeight + 5)
        Next

        ' Draw Y-axis ticks (min, mid, max)
        For i = 0 To 2
            Dim yVal = maxY * (i / 2.0)
            Dim yPos = margin + chartHeight - (yVal / maxY) * chartHeight
            g.DrawLine(Pens.Gray, margin - 5, CInt(yPos), margin, CInt(yPos))
            g.DrawString(CInt(yVal).ToString(), Me.Font, Brushes.Black, 0, yPos - 10)
        Next

        ' Draw the line
        Using linePen As New Pen(LineColor, 2)
            g.DrawLines(linePen, points.ToArray())
        End Using

        ' Draw dots on points
        For Each pt In points
            g.FillEllipse(Brushes.White, pt.X - 3, pt.Y - 3, 6, 6)
            g.DrawEllipse(New Pen(LineColor, 1), pt.X - 3, pt.Y - 3, 6, 6)
        Next
    End Sub
End Class

Imports System.Data.SqlClient

Partial Class MainForm
    '============ STATISTICS =================
    Private Sub LoadCustomLineChart()
        lcLogEnrtries.DataPoints = New List(Of KeyValuePair(Of String, Integer)) From {
            New KeyValuePair(Of String, Integer)("Mon", 10),
            New KeyValuePair(Of String, Integer)("Tue", 20),
            New KeyValuePair(Of String, Integer)("Wed", 35),
            New KeyValuePair(Of String, Integer)("Thu", 18),
            New KeyValuePair(Of String, Integer)("Fri", 5),
            New KeyValuePair(Of String, Integer)("Sat", 12),
            New KeyValuePair(Of String, Integer)("Sun", 28)
        }
        lcLogEnrtries.Invalidate() ' Redraw
    End Sub

    Private Sub rdoWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoWeekly.CheckedChanged
        If rdoWeekly.Checked Then LoadLogChart("Weekly")
    End Sub

    Private Sub rdoMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMonthly.CheckedChanged
        If rdoMonthly.Checked Then LoadLogChart("Monthly")
    End Sub

    Private Sub rdoAnnual_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAnnual.CheckedChanged
        If rdoAnnual.Checked Then LoadLogChart("Annual")
    End Sub

    Private Sub LoadLogChart(viewType As String)
        Dim dataPoints As New List(Of KeyValuePair(Of String, Integer))
        Dim connectionString As String = FormUtils.GetConnectionString()

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query As String = ""

            Select Case viewType
                Case "Weekly"
                    query = "
                        SELECT DATENAME(WEEKDAY, DateLogged) AS Label, COUNT(*) AS Total
                        FROM LibraryLogEntry
                        WHERE DateLogged >= DATEADD(DAY, -6, CAST(GETDATE() AS date))
                        GROUP BY DATENAME(WEEKDAY, DateLogged), DATEPART(WEEKDAY, DateLogged)
                        ORDER BY DATEPART(WEEKDAY, DateLogged)"

                Case "Monthly"
                    query = "
                        SELECT FORMAT(DateLogged, 'MMM') AS Label, COUNT(*) AS Total
                        FROM LibraryLogEntry
                        WHERE DateLogged >= DATEADD(MONTH, -11, GETDATE())
                        GROUP BY FORMAT(DateLogged, 'MMM'), MONTH(DateLogged)
                        ORDER BY MONTH(DateLogged)"

                Case "Annual"
                    query = "
                        SELECT CAST(YEAR(DateLogged) AS VARCHAR) AS Label, COUNT(*) AS Total
                        FROM LibraryLogEntry
                        GROUP BY YEAR(DateLogged)
                        ORDER BY Label"
            End Select

            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim label = reader("Label").ToString()
                        Dim count = Convert.ToInt32(reader("Total"))
                        dataPoints.Add(New KeyValuePair(Of String, Integer)(label, count))
                    End While
                End Using
            End Using
        End Using

        lcLogEnrtries.DataPoints = dataPoints
        lcLogEnrtries.Invalidate()
    End Sub
    Private Sub LoadBookCategoryBarChart()
        Dim points As New List(Of KeyValuePair(Of String, Integer))
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim query = "
            SELECT MaterialType, COUNT(*) AS TotalBooks
            FROM Accession
            GROUP BY MaterialType
            ORDER BY MaterialType"

            Using cmd As New SqlCommand(query, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim category = reader("MaterialType").ToString()
                        Dim count = Convert.ToInt32(reader("TotalBooks"))
                        points.Add(New KeyValuePair(Of String, Integer)(category, count))
                    End While
                End Using
            End Using
        End Using

        CustomBarChart1.DataPoints = points
        CustomBarChart1.Invalidate()
    End Sub
    Private Sub LoadStatistics()
        lblTotalBooks.Text = GetScalarValue("SELECT COUNT(*) FROM Accession").ToString()
        lblTotalBorrowed.Text = GetScalarValue("SELECT COUNT(*) FROM Transactions WHERE ReturnDate IS NULL").ToString()
        lblTotalReturned.Text = GetScalarValue("SELECT COUNT(*) FROM Transactions WHERE ReturnDate IS NOT NULL").ToString()
        lblTotalOverdue.Text = GetScalarValue("SELECT COUNT(*) FROM Transactions WHERE ReturnDate IS NULL AND DueDate < GETDATE()").ToString()
        lblTotalLogs.Text = GetScalarValue("SELECT COUNT(*) FROM LibraryLogEntry WHERE DateLogged >= DATEADD(DAY, -7, GETDATE())").ToString()
    End Sub
    Private statisticsLoaded As Boolean = False

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Not statisticsLoaded Then
            LoadStatistics()
            statisticsLoaded = True
        End If
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        statisticsLoaded = False ' Reset when leaving the form
    End Sub

    Private Function GetScalarValue(query As String) As Integer
        Try
            Dim connectionString As String = FormUtils.GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading statistics: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

End Class

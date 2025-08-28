Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class LogEntry
    Private Sub LogEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        dptTo.Value = Date.Today
        dptFrom.Value = Date.Today.AddMonths(-1)

        LoadLogEntries()
    End Sub

    Private Sub LoadLogEntries()
        Dim conStr As String = FormUtils.GetConnectionString()
        Dim dt As New DataTable()

        Using con As New SqlConnection(conStr)
            con.Open()
            Dim query As String = "SELECT LogID, FullName, Role, Purpose, DateLogged, TimeIn 
                               FROM LibraryLogEntry 
                               WHERE DateLogged BETWEEN @DateFrom AND @DateTo
                               ORDER BY DateLogged DESC, TimeIn DESC"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@DateFrom", dptFrom.Value.Date)
                cmd.Parameters.AddWithValue("@DateTo", dptTo.Value.Date)

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvLogEntries.Columns.Clear()
        dgvLogEntries.AutoGenerateColumns = False

        ' (Re-add your columns here if not already done once)
        ' -- or create them only once if better for performance --

        dgvLogEntries.DataSource = dt
        dgvLogEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLogEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLogEntries.AllowUserToAddRows = False

        ' Manually define columns
        dgvLogEntries.Columns.Clear()
        dgvLogEntries.AutoGenerateColumns = False

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colLogID",
        .HeaderText = "Log ID",
        .DataPropertyName = "LogID",
        .ReadOnly = True
    })

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colFullName",
        .HeaderText = "Full Name",
        .DataPropertyName = "FullName",
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colRole",
        .HeaderText = "Role",
        .DataPropertyName = "Role",
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colPurpose",
        .HeaderText = "Purpose",
        .DataPropertyName = "Purpose",
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colDateLogged",
        .HeaderText = "Date",
        .DataPropertyName = "DateLogged",
        .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "yyyy-MM-dd"},
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvLogEntries.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colTimeIn",
        .HeaderText = "Time In",
        .DataPropertyName = "TimeIn",
        .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "hh:mm tt"},
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        ' ========== Add History Button ==========
        Dim btnHistory As New DataGridViewButtonColumn()
        With btnHistory
            .Name = "colHistory"
            .HeaderText = ""
            .Text = "History"
            .UseColumnTextForButtonValue = True
            .Width = 70
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
        dgvLogEntries.Columns.Add(btnHistory)

        ' Optional formatting
        With dgvLogEntries
            .DataSource = dt
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
        End With
    End Sub
    Private Sub dptFrom_ValueChanged(sender As Object, e As EventArgs) Handles dptFrom.ValueChanged
        If dptFrom.Value <= dptTo.Value Then
            LoadLogEntries()
        Else
            MessageBox.Show("The 'From' date must be earlier than or equal to the 'To' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dptTo_ValueChanged(sender As Object, e As EventArgs) Handles dptTo.ValueChanged
        If dptFrom.Value <= dptTo.Value Then
            LoadLogEntries()
        Else
            MessageBox.Show("The 'To' date must be later than or equal to the 'From' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvLogEntries_HistoryButtonClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogEntries.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim selectedRow As DataGridViewRow = dgvLogEntries.Rows(e.RowIndex)

        ' Only handle History button
        If dgvLogEntries.Columns(e.ColumnIndex).Name = "colHistory" Then
            Dim fullName As String = selectedRow.Cells("colFullName").Value.ToString()

            Dim historyForm As New LogHistory()
            historyForm.SelectedFullName = fullName
            historyForm.ShowDialog()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub

    '========== Generate Entry LogEntry Report ==============
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ExportLogsToPDF()
    End Sub

    Private Sub ExportLogsToPDF()
        If dptFrom.Value > dptTo.Value Then
            MessageBox.Show("Start date must be before end date.")
            Return
        End If

        ' Format filename using the selected date range
        Dim dateFromStr As String = dptFrom.Value.ToString("yyyyMMdd")
        Dim dateToStr As String = dptTo.Value.ToString("yyyyMMdd")
        Dim fileName As String = $"EntryLogs-{dateFromStr}-to-{dateToStr}.pdf"

        Dim saveFileDialog As New SaveFileDialog With {
        .Filter = "PDF files (*.pdf)|*.pdf",
        .FileName = fileName
    }

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            ' Fonts
            Dim subtitleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL)
            Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)
            Dim headerFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)
            Dim rowFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL)

            ' Page setup
            Dim pageSize As New iTextSharp.text.Rectangle(612.0F, 936.0F)
            Dim doc As New Document(pageSize, 40, 40, 60, 40)
            PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            doc.Open()

            ' === Header Table with Logo and School Info ===
            Dim headerTable As New PdfPTable(2)
            headerTable.WidthPercentage = 100
            headerTable.SetWidths({1, 4})

            ' === Logo from Resources ===
            Dim logoBitmap As Bitmap = My.Resources.ESTI_Logo
            Using ms As New MemoryStream()
                logoBitmap.Save(ms, Imaging.ImageFormat.Png)
                ms.Position = 0
                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms)
                logo.ScaleAbsolute(60, 60)

                Dim logoCell As New PdfPCell(logo)
                logoCell.Border = Rectangle.NO_BORDER
                logoCell.HorizontalAlignment = Element.ALIGN_LEFT
                logoCell.VerticalAlignment = Element.ALIGN_MIDDLE
                logoCell.PaddingRight = 0
                headerTable.AddCell(logoCell)
            End Using

            ' === School Info ===
            Dim schoolInfo As String = "ERHARD SYSTEMS TECHNOLOGICAL INSTITUTE" & vbCrLf &
                                   "ODIONGAN, ROMBLON" & vbCrLf &
                                   "(042)567-6264"
            Dim infoPara As New Paragraph(schoolInfo, subtitleFont)
            infoPara.Alignment = Element.ALIGN_LEFT

            Dim textCell As New PdfPCell(infoPara)
            textCell.Border = Rectangle.NO_BORDER
            textCell.HorizontalAlignment = Element.ALIGN_LEFT
            textCell.VerticalAlignment = Element.ALIGN_MIDDLE
            textCell.PaddingLeft = -50
            headerTable.AddCell(textCell)

            doc.Add(headerTable)
            doc.Add(New Paragraph(" "))

            ' === Title ===
            Dim titlePara As New Paragraph("Library Entry Logs", titleFont)
            titlePara.Alignment = Element.ALIGN_CENTER
            doc.Add(titlePara)

            ' === Show Date Range Subtitle ===
            Dim subtitlePara As New Paragraph($"From: {dptFrom.Value:MMMM dd, yyyy}    To: {dptTo.Value:MMMM dd, yyyy}", subtitleFont)
            subtitlePara.Alignment = Element.ALIGN_CENTER
            doc.Add(subtitlePara)
            doc.Add(New Paragraph(" "))

            ' === Fetch Data ===
            Dim dt As New DataTable()
            Dim connStr As String = FormUtils.GetConnectionString()
            Dim query As String = "SELECT LogID, FullName, Role, Purpose, DateLogged FROM LibraryLogEntry WHERE DateLogged BETWEEN @From AND @To"

            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@From", dptFrom.Value.Date)
                    cmd.Parameters.AddWithValue("@To", dptTo.Value.Date.AddDays(1).AddTicks(-1))
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            ' === Table Header ===
            Dim table As New PdfPTable(5)
            table.WidthPercentage = 100
            table.SetWidths({10, 30, 15, 15, 30})

            Dim headers = {"Log ID", "Full Name", "Role", "Purpose", "Date & Time In"}
            For Each headerText In headers
                Dim cell = New PdfPCell(New Phrase(headerText, headerFont)) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER
            }
                table.AddCell(cell)
            Next

            ' === Table Rows ===
            For Each row As DataRow In dt.Rows
                table.AddCell(New Phrase(row("LogID").ToString(), rowFont))
                table.AddCell(New Phrase(row("FullName").ToString(), rowFont))
                table.AddCell(New Phrase(row("Role").ToString(), rowFont))
                table.AddCell(New Phrase(row("Purpose").ToString(), rowFont))
                table.AddCell(New Phrase(Convert.ToDateTime(row("DateLogged")).ToString("yyyy-MM-dd hh:mm tt"), rowFont))
            Next

            doc.Add(table)
            doc.Close()

            Process.Start(saveFileDialog.FileName)
            MessageBox.Show("Entry log report created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating log report: " & ex.Message, "PDF Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LogEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

End Class
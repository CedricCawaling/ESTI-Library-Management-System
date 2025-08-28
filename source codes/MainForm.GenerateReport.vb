Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class MainForm
    Private selectedMaterialTypes As New List(Of String)

    '======================== Generate Button ========================
    Private Sub btnGenerateList_Click(sender As Object, e As EventArgs) Handles btnGenerateList.Click
        selectedMaterialTypes.Clear()

        If chkGeneralCirculation.Checked Then selectedMaterialTypes.Add("General Circulation Books")
        If chkReferenceBooks.Checked Then selectedMaterialTypes.Add("Reference Books")
        If chkNonFictionBooks.Checked Then selectedMaterialTypes.Add("Non-Fiction Books")
        If chkMagazines.Checked Then selectedMaterialTypes.Add("Magazine")
        If chkFilipinianaBooks.Checked Then selectedMaterialTypes.Add("Filipiniana Books")
        If chkComputerScienceBooks.Checked Then selectedMaterialTypes.Add("Computer Science Books")
        If chkCriminologyBooks.Checked Then selectedMaterialTypes.Add("Criminology Books")
        If chkTourismBooks.Checked Then selectedMaterialTypes.Add("Tourism Books")
        If chkHighSchoolBooks.Checked Then selectedMaterialTypes.Add("High School Books")

        If selectedMaterialTypes.Any() Then
            ExportBooksToPDF_ByMaterialType()
        Else
            MessageBox.Show("Please select at least one material type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    '======================== Export PDF Function ========================
    Private Sub ExportBooksToPDF_ByMaterialType()
        Dim saveFileDialog As New SaveFileDialog With {
        .Filter = "PDF files (*.pdf)|*.pdf",
        .FileName = "BookListReport.pdf"
    }

        If saveFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            'subtitleFont    School name, address under logo	
            'titleFont   The “List of Books” title	
            'headerFont  The column headers (Book ID, Title, etc.)	
            'rowFont The table contents (data rows)	
            ' Fonts
            Dim subtitleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL)
            Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD)
            Dim headerFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)
            Dim rowFont As iTextSharp.text.Font = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL)

            ' Page setup for 8.5 x 13 inches (long bond)
            Dim pageSize As New iTextSharp.text.Rectangle(612.0F, 936.0F)
            Dim doc As New Document(pageSize, 40, 40, 60, 40)
            PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            doc.Open()

            ' === Header Table with Logo and School Info ===
            Dim headerTable As New PdfPTable(2)
            headerTable.WidthPercentage = 100
            headerTable.SetWidths({1, 4})

            ' === Load Logo from Resources ===
            Dim logoBitmap As Bitmap = My.Resources.ESTI_Logo
            Using ms As New MemoryStream()
                logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                ms.Position = 0

                Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(ms)
                logo.ScaleAbsolute(60, 60)

                Dim logoCell As New PdfPCell(logo)
                logoCell.Border = Rectangle.NO_BORDER
                logoCell.HorizontalAlignment = Element.ALIGN_LEFT
                logoCell.VerticalAlignment = Element.ALIGN_MIDDLE
                logoCell.PaddingRight = 0 ' Try values like 0, 5, or -5 depending on the spacing you want

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
            headerTable.AddCell(textCell)
            textCell.PaddingLeft = -50 ' Try -10 or adjust as needed



            doc.Add(headerTable)
            doc.Add(New Paragraph(" "))

            ' === Title ===
            Dim titlePara As New Paragraph("List of Books", titleFont)
            titlePara.Alignment = Element.ALIGN_CENTER
            doc.Add(titlePara)
            doc.Add(New Paragraph(" "))

            ' Query Setup
            Dim connStr As String = FormUtils.GetConnectionString()
            Dim query As String = "SELECT BookID, MaterialType, BookTitle, Author FROM Accession"

            If selectedMaterialTypes.Any() Then
                Dim placeholders = String.Join(",", selectedMaterialTypes.Select(Function(item, i) "@MaterialType" & i))
                query &= " WHERE MaterialType IN (" & placeholders & ")"
            End If

            ' Fetch Data
            Dim dt As New DataTable()
            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    For i = 0 To selectedMaterialTypes.Count - 1
                        cmd.Parameters.AddWithValue("@MaterialType" & i, selectedMaterialTypes(i))
                    Next
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            ' Table
            Dim table As New PdfPTable(5)
            table.WidthPercentage = 100
            table.SetWidths({10, 15, 20, 35, 20})

            Dim headers = {"Book ID", "Acc. No.", "Material Type", "Title", "Author"}
            For Each headerText In headers
                Dim cell = New PdfPCell(New Phrase(headerText, headerFont)) With {
                .BackgroundColor = BaseColor.LIGHT_GRAY,
                .HorizontalAlignment = Element.ALIGN_CENTER
            }
                table.AddCell(cell)
            Next

            ' Rows
            For Each row As DataRow In dt.Rows
                Dim bookID As Integer = CInt(row("BookID"))
                Dim formattedBookID As String = "B" & bookID.ToString("D4")
                Dim formattedAccessionNo As String = bookID.ToString()

                table.AddCell(New Phrase(formattedBookID, rowFont))
                table.AddCell(New Phrase(formattedAccessionNo, rowFont))
                table.AddCell(New Phrase(row("MaterialType").ToString(), rowFont))
                table.AddCell(New Phrase(row("BookTitle").ToString(), rowFont))
                table.AddCell(New Phrase(row("Author").ToString(), rowFont))
            Next

            doc.Add(table)
            doc.Close()

            Process.Start(saveFileDialog.FileName)
            MessageBox.Show("PDF report created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "PDF Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '======================== CheckBox Style Behavior ========================
    Private Sub chkMaterialType_CheckedChanged(sender As Object, e As EventArgs) _
    Handles chkGeneralCirculation.CheckedChanged,
            chkReferenceBooks.CheckedChanged,
            chkNonFictionBooks.CheckedChanged,
            chkMagazines.CheckedChanged,
            chkFilipinianaBooks.CheckedChanged,
            chkComputerScienceBooks.CheckedChanged,
            chkCriminologyBooks.CheckedChanged,
            chkTourismBooks.CheckedChanged,
            chkHighSchoolBooks.CheckedChanged

        Dim chk As CheckBox = DirectCast(sender, CheckBox)

        If chk.Checked Then
            Select Case chk.Name
                Case "chkComputerScienceBooks" : chk.BackColor = Color.SeaGreen
                Case "chkCriminologyBooks" : chk.BackColor = Color.SteelBlue
                Case "chkFilipinianaBooks" : chk.BackColor = Color.Orange
                Case "chkGeneralCirculation" : chk.BackColor = Color.MediumPurple
                Case "chkHighSchoolBooks" : chk.BackColor = Color.Crimson
                Case "chkMagazines" : chk.BackColor = Color.Goldenrod
                Case "chkNonFictionBooks" : chk.BackColor = Color.Teal
                Case "chkReferenceBooks" : chk.BackColor = Color.DarkSlateBlue
                Case "chkTourismBooks" : chk.BackColor = Color.DarkOrange
            End Select
            chk.ForeColor = Color.White
            chk.Font = New System.Drawing.Font(chk.Font, FontStyle.Bold)
        Else
            chk.BackColor = Color.White
            chk.ForeColor = Color.Black
            chk.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiCondensed", 12, FontStyle.Regular)
        End If

        UpdateGenerateButtonState()
    End Sub


    Private Sub UpdateGenerateButtonState()
        btnGenerateList.Enabled =
        chkGeneralCirculation.Checked OrElse
        chkReferenceBooks.Checked OrElse
        chkNonFictionBooks.Checked OrElse
        chkMagazines.Checked OrElse
        chkFilipinianaBooks.Checked OrElse
        chkComputerScienceBooks.Checked OrElse
        chkCriminologyBooks.Checked OrElse
        chkTourismBooks.Checked OrElse
        chkHighSchoolBooks.Checked
    End Sub
    Private Sub btnGenerateAll_Click(sender As Object, e As EventArgs) Handles btnGenerateAll.Click
        selectedMaterialTypes.Clear()
        selectedMaterialTypes.AddRange(New String() {
        "General Circulation Books",
        "Reference Books",
        "Non-Fiction Books",
        "Magazine",
        "Filipiniana Books",
        "Computer Science Books",
        "Criminology Books",
        "Tourism Books",
        "High School Books"
    })

        ExportBooksToPDF_ByMaterialType()
    End Sub

End Class

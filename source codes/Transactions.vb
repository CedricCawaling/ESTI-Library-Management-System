Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports ClosedXML.Excel
Public Class Transactions
    Private adapter As New LMSDataSetTableAdapters.TransactionsTableAdapter()
    Private transactionsTable As New LMSDataSet.TransactionsDataTable()

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        adapter.Fill(transactionsTable)
        dgvTransactions.DataSource = transactionsTable
        For Each col As DataGridViewColumn In dgvTransactions.Columns
            Select Case col.Name
                Case "BookTitle"
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    col.FillWeight = 200 ' Make it wider
                Case "BorrowerName"
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    col.FillWeight = 150
                Case "btnView"
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Case Else
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    col.FillWeight = 100
            End Select
        Next

        ' Appearance
        dgvTransactions.EnableHeadersVisualStyles = False
        dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        dgvTransactions.RowHeadersVisible = False
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        ' Hide TransactionID
        If dgvTransactions.Columns.Contains("TransactionID") Then
            dgvTransactions.Columns("TransactionID").Visible = False
        End If

        ' Rename headers
        dgvTransactions.Columns("BookID").HeaderText = "Book ID"
        dgvTransactions.Columns("BookTitle").HeaderText = "Book Title"
        dgvTransactions.Columns("BorrowerName").HeaderText = "Borrower"
        dgvTransactions.Columns("BorrowDate").HeaderText = "Borrow Date"
        dgvTransactions.Columns("DueDate").HeaderText = "Due Date"
        dgvTransactions.Columns("ReturnDate").HeaderText = "Return Date"

        ' Add View button
        If Not dgvTransactions.Columns.Contains("btnView") Then
            Dim viewBtnCol As New DataGridViewButtonColumn()
            viewBtnCol.Name = "btnView"
            viewBtnCol.HeaderText = ""
            viewBtnCol.Text = "View"
            viewBtnCol.UseColumnTextForButtonValue = True
            viewBtnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvTransactions.Columns.Add(viewBtnCol)
        End If

        ' Add Return button
        If Not dgvTransactions.Columns.Contains("btnReturn") Then
            Dim returnBtnCol As New DataGridViewButtonColumn()
            returnBtnCol.Name = "btnReturn"
            returnBtnCol.HeaderText = ""
            returnBtnCol.Text = "Return"
            returnBtnCol.UseColumnTextForButtonValue = True
            returnBtnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvTransactions.Columns.Add(returnBtnCol)
        End If
        cmbFilter.Items.Clear()
        cmbFilter.Items.AddRange(New String() {
    "All",
    "Book Title",
    "Borrower Name"
})
        cmbFilter.SelectedIndex = 0
        UpdateReturnButtons()
    End Sub
    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        ' Skip if header clicked
        If e.RowIndex < 0 Then Exit Sub

        Dim selectedRow As DataGridViewRow = dgvTransactions.Rows(e.RowIndex)

        If dgvTransactions.Columns(e.ColumnIndex).Name = "btnView" Then
            Dim borrowDateValue = selectedRow.Cells("BorrowDate").Value
            Dim dueDateValue = selectedRow.Cells("DueDate").Value
            Dim returnDateValue = selectedRow.Cells("ReturnDate").Value

            Dim frmView As New TransactionDetails With {
            .BookTitle = selectedRow.Cells("BookTitle").Value.ToString(),
            .BorrowerName = selectedRow.Cells("BorrowerName").Value.ToString(),
            .BorrowDate = If(IsDBNull(borrowDateValue), Date.MinValue, CDate(borrowDateValue)),
            .DueDate = If(IsDBNull(dueDateValue), Date.MinValue, CDate(dueDateValue)),
            .ReturnDate = If(IsDBNull(returnDateValue), Nothing, CType(returnDateValue, Date?))
        }

            frmView.ShowDialog()

        ElseIf dgvTransactions.Columns(e.ColumnIndex).Name = "btnReturn" Then
            ' Check if already returned
            If Not IsDBNull(selectedRow.Cells("ReturnDate").Value) Then
                MessageBox.Show("This book has already been returned.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Proceed to mark as returned and update status
            Dim transactionID As Integer = CInt(selectedRow.Cells("TransactionID").Value)
            Dim returnDate As DateTime = DateTime.Now
            Dim connStr As String = FormUtils.GetConnectionString()

            Using conn As New SqlConnection(connStr)
                Dim query As String = "
                UPDATE Transactions 
                SET ReturnDate = @ReturnDate,
                    Status = 'Returned'
                WHERE TransactionID = @TransactionID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate)
                    cmd.Parameters.AddWithValue("@TransactionID", transactionID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book marked as returned and status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            adapter.Fill(transactionsTable) ' Refresh the grid
        End If
    End Sub

    Private Function GetColumnName(displayName As String) As String
        Select Case displayName
            Case "Book Title" : Return "BookTitle"
            Case "Borrower Name" : Return "BorrowerName"
            Case "Due Date" : Return "DueDate"
            Case Else : Return "" ' For "All"
        End Select
    End Function

    Private Sub HighlightOverdueRows()
        For Each row As DataGridViewRow In dgvTransactions.Rows
            If row.Cells("ReturnDate").Value Is DBNull.Value AndAlso
           CDate(row.Cells("DueDate").Value) < Date.Today Then
                row.Cells("DueDate").Style.ForeColor = Color.DarkOrange
                row.Cells("DueDate").Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            Else
                row.Cells("DueDate").Style.ForeColor = Color.Black
            End If
        Next
    End Sub
    Private Sub UpdateReturnButtons()
        For Each row As DataGridViewRow In dgvTransactions.Rows
            If Not IsDBNull(row.Cells("ReturnDate").Value) Then
                Dim btnCell As DataGridViewButtonCell = CType(row.Cells("btnReturn"), DataGridViewButtonCell)
                btnCell.Value = "Returned"
                btnCell.Style.ForeColor = Color.Gray
                btnCell.FlatStyle = FlatStyle.Flat
                btnCell.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dt As New DataTable()
        Dim connectionString As String = FormUtils.GetConnectionString()

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Transactions"
            Using adapter As New SqlDataAdapter(query, conn)
                adapter.Fill(dt)
            End Using
        End Using

        Dim dv As New DataView(dt)
        Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

        If Not String.IsNullOrWhiteSpace(searchText) Then
            dv.RowFilter = $"BookTitle LIKE '%{searchText}%' OR BorrowerName LIKE '%{searchText}%'"
        Else
            dv.RowFilter = "" ' Show all if search is empty
        End If

        dgvTransactions.DataSource = dv
    End Sub


    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        If dgvTransactions.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Workbook|*.xlsx"
            sfd.Title = "Save Excel File"
            sfd.FileName = "TransactionsExport_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
                        Dim ws = workbook.Worksheets.Add("Transactions")

                        ' Add headers
                        Dim colIndex As Integer = 1
                        For Each col As DataGridViewColumn In dgvTransactions.Columns
                            If col.Visible AndAlso Not TypeOf col Is DataGridViewButtonColumn Then
                                ws.Cell(1, colIndex).Value = col.HeaderText
                                ws.Cell(1, colIndex).Style.Font.Bold = True
                                colIndex += 1
                            End If
                        Next

                        ' Add data
                        Dim rowIndex As Integer = 2
                        For Each row As DataGridViewRow In dgvTransactions.Rows
                            colIndex = 1
                            For Each col As DataGridViewColumn In dgvTransactions.Columns
                                If col.Visible AndAlso Not TypeOf col Is DataGridViewButtonColumn Then
                                    ws.Cell(rowIndex, colIndex).Value = If(IsDBNull(row.Cells(col.Name).Value), "", row.Cells(col.Name).Value.ToString())
                                    colIndex += 1
                                End If
                            Next
                            rowIndex += 1
                        Next

                        workbook.SaveAs(sfd.FileName)
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error exporting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
    Private Sub Transactions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

End Class
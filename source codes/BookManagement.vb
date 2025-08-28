' === BookManagement.vb ===
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class BookManagement
    Private hasCheckedInitialData As Boolean = False

    Private Sub AddBookColumns()
        dgvBooks.Columns.AddRange({
           New DataGridViewTextBoxColumn With {.Name = "BookID", .HeaderText = "Book ID", .DataPropertyName = "BookID", .Visible = True, .Width = 60, .ReadOnly = True},
        New DataGridViewTextBoxColumn With {.Name = "DateReceived", .HeaderText = "Date Received", .DataPropertyName = "DateReceived", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "MaterialType", .HeaderText = "Material", .DataPropertyName = "MaterialType", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Author", .HeaderText = "Author", .DataPropertyName = "Author", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "BookTitle", .HeaderText = "Title", .DataPropertyName = "BookTitle", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Edition", .HeaderText = "Edition", .DataPropertyName = "Edition", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Volume", .HeaderText = "Volume", .DataPropertyName = "Volume", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Pages", .HeaderText = "Pages", .DataPropertyName = "Pages", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "CostPrice", .HeaderText = "Cost", .DataPropertyName = "CostPrice", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Publisher", .HeaderText = "Publisher", .DataPropertyName = "Publisher", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Year", .HeaderText = "Year", .DataPropertyName = "Year", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "Remarks", .HeaderText = "Remarks", .DataPropertyName = "Remarks", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewTextBoxColumn With {.Name = "PhotoPath", .HeaderText = "PhotoPath", .DataPropertyName = "PhotoPath", .Visible = False},
        New DataGridViewButtonColumn With {.Name = "btnEdit", .HeaderText = "", .Text = "Edit", .UseColumnTextForButtonValue = True, .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        New DataGridViewButtonColumn With {.Name = "btnDelete", .HeaderText = "", .Text = "Delete", .UseColumnTextForButtonValue = True, .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}
        })
    End Sub

    Private Sub BookManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        FileHelper.EnsureDirectories()


        dgvBooks.Columns.Clear()
        AddBookColumns()
        dgvBooks.RowHeadersVisible = False
        If dgvBooks.Columns.Contains("PhotoPath") Then
            dgvBooks.Columns("PhotoPath").Visible = False
        End If
        dgvBooks.DataSource = LoadAccessionToDGV()
        cmbFilter.Items.Clear()
        cmbFilter.Items.AddRange(New String() {
    "Book Title", "Author", "Publisher", "Year", "Material", "Remarks"
})
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All")
        cmbFilter.Items.AddRange(New String() {
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
        cmbFilter.SelectedIndex = 0 ' Default to "All"

    End Sub

    Private Function LoadAccessionToDGV() As DataTable
        Dim query As String = "SELECT BookID, BookTitle, DateReceived, Author, MaterialType, Edition, Volume, Year, Pages, CostPrice, Publisher, Remarks, PhotoPath FROM dbo.Accession"

        Dim dt As New DataTable()

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, conn)
                Try
                    adapter.Fill(dt)

                    ' Format BookID after loading
                    dt.Columns.Add("FormattedBookID", GetType(String))
                    For Each row As DataRow In dt.Rows
                        Dim rawId As Integer = If(IsDBNull(row("BookID")), 0, Convert.ToInt32(row("BookID")))
                        row("FormattedBookID") = "B" & rawId.ToString("D4")
                    Next

                    ' Replace BookID column display with formatted one
                    dt.Columns.Remove("BookID")
                    dt.Columns("FormattedBookID").ColumnName = "BookID"
                Catch ex As Exception
                    MessageBox.Show("Failed to load books: " & ex.Message)
                End Try
            End Using
        End Using

        Return dt
    End Function
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim selectedMaterial As String = cmbFilter.SelectedItem.ToString()

        Dim dt As DataTable = LoadAccessionToDGV()
        Dim dv As New DataView(dt)

        If selectedMaterial <> "All" Then
            dv.RowFilter = $"MaterialType = '{selectedMaterial.Replace("'", "''")}'"
        End If

        dgvBooks.DataSource = dv

        If dgvBooks.Columns.Contains("PhotoPath") Then
            dgvBooks.Columns("PhotoPath").Visible = False
        End If
    End Sub

    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)

            If dgvBooks.Columns(e.ColumnIndex).Name = "btnEdit" Then
                Dim editForm As New EditAccession()
                editForm.LoadBookData(row)
                editForm.ShowDialog()
                dgvBooks.DataSource = LoadAccessionToDGV()
                If dgvBooks.Columns.Contains("PhotoPath") Then
                    dgvBooks.Columns("PhotoPath").Visible = False
                End If


            ElseIf dgvBooks.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo)
                If confirm = DialogResult.Yes Then
                    Dim bookIDStr As String = row.Cells("BookID").Value.ToString().Replace("B", "").Trim()
                    Dim bookID As Integer = If(String.IsNullOrWhiteSpace(bookIDStr), 0, Convert.ToInt32(bookIDStr))
                    DeleteBookByID(bookID)
                    dgvBooks.DataSource = LoadAccessionToDGV()
                    If dgvBooks.Columns.Contains("PhotoPath") Then
                        dgvBooks.Columns("PhotoPath").Visible = False
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub DeleteBookByID(bookID As Integer)
        Dim query As String = "DELETE FROM dbo.Accession WHERE BookID = @BookID"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnAddBooks_Click(sender As Object, e As EventArgs) Handles btnAddBooks.Click
        Dim addForm As New EditAccession()
        addForm.ShowDialog()
        dgvBooks.DataSource = LoadAccessionToDGV()
        If dgvBooks.Columns.Contains("PhotoPath") Then
            dgvBooks.Columns("PhotoPath").Visible = False
        End If

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()
        Dim selectedMaterialType As String = cmbFilter.SelectedItem.ToString()

        ' Load the full dataset
        Dim dt As DataTable = LoadAccessionToDGV()
        Dim dv As New DataView(dt)

        ' Build the search and filter condition
        Dim filters As New List(Of String)

        ' Apply MaterialType condition only if not "All"
        If selectedMaterialType <> "All" Then
            filters.Add($"MaterialType = '{selectedMaterialType.Replace("'", "''")}'")
        End If

        ' Apply keyword search across common columns (e.g., BookTitle, Author, Publisher, Remarks)
        If Not String.IsNullOrWhiteSpace(searchText) Then
            Dim keyword As String = searchText.Replace("'", "''")
            filters.Add($"(BookTitle LIKE '%{keyword}%' OR Author LIKE '%{keyword}%' OR Publisher LIKE '%{keyword}%' OR Remarks LIKE '%{keyword}%')")
        End If

        ' Apply combined filter
        dv.RowFilter = String.Join(" AND ", filters)

        ' Display filtered result
        dgvBooks.DataSource = dv

        If dgvBooks.Columns.Contains("PhotoPath") Then
            dgvBooks.Columns("PhotoPath").Visible = False
        End If

        ' Highlight matched keyword rows
        HighlightSearchResults(searchText)
    End Sub


    Private Function GetColumnName(displayName As String) As String
        Select Case displayName
            Case "Book Title" : Return "BookTitle"
            Case "Author" : Return "Author"
            Case "Publisher" : Return "Publisher"
            Case "Year" : Return "Year"
            Case "Material" : Return "MaterialType"
            Case "Remarks" : Return "Remarks"
            Case Else : Return ""
        End Select
    End Function
    Private Sub HighlightSearchResults(searchText As String)
        If String.IsNullOrWhiteSpace(searchText) Then Exit Sub

        For Each row As DataGridViewRow In dgvBooks.Rows
            row.DefaultCellStyle.BackColor = Color.White ' Reset first
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText.ToLower()) Then
                    row.DefaultCellStyle.BackColor = Color.LightYellow
                    Exit For
                End If
            Next
        Next
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            dgvBooks.DataSource = LoadAccessionToDGV()
            If dgvBooks.Columns.Contains("PhotoPath") Then
                dgvBooks.Columns("PhotoPath").Visible = False
            End If

        End If
    End Sub
    Private Sub EnsureDirectories()
        Dim baseDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyLMSApp")
        Dim folder = Path.Combine(baseDir, "BookThumbnails")

        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub
    Private Sub BookManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

End Class

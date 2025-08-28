Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class OPAC


    Private Sub OPAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        AddOPACColumns()
        LoadOPACData()

        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("All") ' Default option
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Dim query = "SELECT DISTINCT MaterialType FROM dbo.Accession ORDER BY MaterialType"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbFilter.Items.Add(reader("MaterialType").ToString())
                    End While
                End Using
            End Using
        End Using

        cmbFilter.SelectedIndex = 0
    End Sub

    Private Sub AddOPACColumns()
        dgvOPAC.Columns.Clear()

        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "colCover"
        imgCol.HeaderText = "Cover"
        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        imgCol.Width = 105
        imgCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOPAC.RowTemplate.Height = 105
        dgvOPAC.Columns.Add(imgCol)

        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colBookID",
            .HeaderText = "BookID",
            .Visible = False,
            .DataPropertyName = "BookID"
        })
        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colTitle",
            .HeaderText = "Title",
            .DataPropertyName = "BookTitle",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })
        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colAuthor",
            .HeaderText = "Author",
            .DataPropertyName = "Author",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })
        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colMaterial",
            .HeaderText = "Material",
            .DataPropertyName = "MaterialType",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })
        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colYear",
            .HeaderText = "Year",
            .DataPropertyName = "Year",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })
        dgvOPAC.Columns.Add(New DataGridViewTextBoxColumn With {
            .Name = "colStatus",
            .HeaderText = "Status",
            .DataPropertyName = "Status",
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        })

        Dim viewBtn As New DataGridViewButtonColumn()
        viewBtn.Name = "colView"
        viewBtn.HeaderText = ""
        viewBtn.Text = "View"
        viewBtn.UseColumnTextForButtonValue = True
        viewBtn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvOPAC.Columns.Add(viewBtn)

        dgvOPAC.EnableHeadersVisualStyles = False
        dgvOPAC.RowHeadersVisible = False
    End Sub

    Private Sub LoadOPACData()
        dgvOPAC.Rows.Clear()

        Dim query As String = "SELECT BookID, BookTitle, Author, MaterialType, Year, PhotoPath FROM dbo.Accession"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim imgPath = reader("PhotoPath").ToString()
                        Dim fullPath = Path.Combine(Application.StartupPath, imgPath)
                        Dim coverImage As Image = My.Resources.DefaultBookThumb

                        If File.Exists(fullPath) Then
                            Try
                                Using fs = New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                                    Using tempImg = Image.FromStream(fs)
                                        coverImage = New Bitmap(tempImg) ' Clone to avoid file lock
                                    End Using
                                End Using
                            Catch ex As Exception
                                ' fallback used
                            End Try
                        End If



                        Dim bookID As Integer = Convert.ToInt32(reader("BookID"))
                        Dim status = GetBookStatus(bookID)

                        dgvOPAC.Rows.Add(
                         coverImage,
                         reader("BookID"),
                         reader("BookTitle").ToString(),
                         reader("Author").ToString(),
                         reader("MaterialType").ToString(),
                         reader("Year").ToString(),
                         status,
                         "View"
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Function GetBookStatus(bookID As Integer) As String
        Dim query As String = "
        SELECT TOP 1 Status 
        FROM dbo.Transactions 
        WHERE BookID = @BookID 
        ORDER BY BorrowDate DESC"

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                Dim status As String = If(result IsNot Nothing, result.ToString(), "").Trim().ToLower()

                If status = "borrowed" Then
                    Return "Borrowed"
                Else
                    Return "Available"
                End If
            End Using
        End Using
    End Function


    Private Sub dgvOPAC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOPAC.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvOPAC.Columns(e.ColumnIndex).Name = "colView" Then
            Try
                Dim bookID As Integer = CInt(dgvOPAC.Rows(e.RowIndex).Cells("colBookID").Value)
                Dim detailsForm As New BookDetails()
                detailsForm.LoadBookDetailsByID(bookID)
                detailsForm.ShowDialog()
                ApplyOPACFilter()
            Catch ex As Exception
                MessageBox.Show("Unable to open book details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ApplyOPACFilter()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        ApplyOPACFilter()
    End Sub

    Private Sub ApplyOPACFilter()
        dgvOPAC.Rows.Clear()

        Dim selectedType As String = cmbFilter.SelectedItem?.ToString()
        Dim keyword As String = txtSearch.Text.Trim()

        Dim query As String = "SELECT * FROM vw_OPACBooks WHERE 1=1"
        Dim parameters As New List(Of SqlParameter)

        If selectedType IsNot Nothing AndAlso selectedType <> "All" Then
            query &= " AND MaterialType = @MaterialType"
            parameters.Add(New SqlParameter("@MaterialType", selectedType))
        End If

        If Not String.IsNullOrWhiteSpace(keyword) Then
            query &= " AND (BookTitle LIKE @Keyword OR Author LIKE @Keyword)"
            parameters.Add(New SqlParameter("@Keyword", "%" & keyword & "%"))
        End If



        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim imgPath = reader("PhotoPath").ToString()
                        Dim fullPath = Path.Combine(Application.StartupPath, imgPath)
                        Dim coverImage As Image = My.Resources.DefaultBookThumb

                        If File.Exists(fullPath) Then
                            Try
                                Using fs = New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                                    Using tempImg = Image.FromStream(fs)
                                        coverImage = New Bitmap(tempImg) ' Clone to avoid file lock
                                    End Using
                                End Using
                            Catch ex As Exception
                                ' fallback used
                            End Try
                        End If



                        Dim bookID As Integer = Convert.ToInt32(reader("BookID"))
                        Dim status = GetBookStatus(bookID)

                        dgvOPAC.Rows.Add(
                            coverImage,
                            reader("BookID"),
                            reader("BookTitle").ToString(),
                            reader("Author").ToString(),
                            reader("MaterialType").ToString(),
                            reader("Year").ToString(),
                            status,
                            "View"
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub OPAC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainForm.Show()
    End Sub

End Class

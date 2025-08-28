Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO

Public Class BookDetails
    Private Sub BookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
    End Sub

    Private currentBookID As Integer
    Private currentTitle As String

    Public Sub LoadBookDetailsByID(bookID As Integer)
        currentBookID = bookID ' 🔧 FIX: assign the actual bookID


        Dim query As String = "SELECT * FROM dbo.Accession WHERE BookID = @BookID"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookID", bookID)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Assign all fields including title
                        currentTitle = reader("BookTitle").ToString()
                        lblBookTitle.Text = currentTitle
                        lblAuthor.Text = reader("Author").ToString()
                        lblMaterialType.Text = reader("MaterialType").ToString()
                        lblEdition.Text = reader("Edition").ToString()
                        lblVolume.Text = reader("Volume").ToString()
                        lblYear.Text = reader("Year").ToString()
                        lblPublisher.Text = reader("Publisher").ToString()
                        lblPages.Text = reader("Pages").ToString()

                        Dim photoPath As String = reader("PhotoPath").ToString()
                        If Not String.IsNullOrWhiteSpace(photoPath) Then
                            Dim fullPath As String = Path.Combine(Application.StartupPath, photoPath)
                            If File.Exists(fullPath) Then
                                Try
                                    Using fs As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                                        picCover.Image = Image.FromStream(fs)
                                    End Using
                                Catch ex As Exception
                                    picCover.Image = My.Resources.DefaultBookThumb
                                End Try
                            Else
                                picCover.Image = My.Resources.DefaultBookThumb
                            End If

                        Else
                            picCover.Image = My.Resources.DefaultBookThumb
                        End If
                    End If
                End Using
            End Using
        End Using

        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Magenta
        Me.TransparencyKey = Color.Magenta
        Me.AllowTransparency = True


        LoadLastBorrower()
        UpdateStatusAndButtons()
    End Sub

    Private Sub LoadLastBorrower()
        Dim query As String = "
            SELECT TOP 1 BorrowerName 
            FROM dbo.Transactions 
            WHERE BookID = @BookID 
            ORDER BY BorrowDate DESC"

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookID", currentBookID)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                lblLastBorrower.Text = If(result IsNot Nothing, result.ToString(), "None")
            End Using
        End Using
    End Sub

    Private Sub UpdateStatusAndButtons()
        Dim query As String = "
            SELECT TOP 1 ReturnDate 
            FROM dbo.Transactions 
            WHERE BookID = @BookID 
            ORDER BY BorrowDate DESC"

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@BookID", currentBookID)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        If IsDBNull(reader("ReturnDate")) Then
                            lblStatus.Text = "Borrowed"
                            btnBorrow.Enabled = False
                            btnReturn.Enabled = True
                        Else
                            lblStatus.Text = "Available"
                            btnBorrow.Enabled = True
                            btnReturn.Enabled = False
                        End If
                    Else
                        lblStatus.Text = "Available"
                        btnBorrow.Enabled = True
                        btnReturn.Enabled = False
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        ' Select borrower and due date
        Dim borrowerForm As New SelectBorrowerPopup()
        If borrowerForm.ShowDialog() <> DialogResult.OK Then Exit Sub

        Dim borrowerName As String = borrowerForm.SelectedName
        Dim borrowDate As DateTime = DateTime.Now
        Dim dueDate As Object = borrowerForm.SelectedDueDate

        ' Save transaction
        Dim insertQuery As String = "
INSERT INTO dbo.Transactions 
(BookID, BookTitle, BorrowerName, BorrowDate, DueDate, Status)
VALUES (@BookID, @BookTitle, @BorrowerName, @BorrowDate, @DueDate, 'Borrowed')"

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@BookID", currentBookID)
                cmd.Parameters.AddWithValue("@BookTitle", currentTitle)
                cmd.Parameters.AddWithValue("@BorrowerName", borrowerName)
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate)
                cmd.Parameters.AddWithValue("@DueDate", dueDate)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Borrowing transaction saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadLastBorrower()
        UpdateStatusAndButtons()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnDate = DateTime.Now

        Dim updateQuery As String = "
UPDATE dbo.Transactions 
SET ReturnDate = @ReturnDate, Status = 'Returned'
WHERE BookID = @BookID AND ReturnDate IS NULL"

        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@BookID", currentBookID)
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Book returned successfully.", "Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadLastBorrower()
        UpdateStatusAndButtons()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

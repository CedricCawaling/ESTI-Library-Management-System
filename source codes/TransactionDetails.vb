Public Class TransactionDetails

    ' Public properties for data passing
    Public Property BookTitle As String
    Public Property BorrowerName As String
    Public Property BorrowDate As Date
    Public Property DueDate As Date
    Public Property ReturnDate As Date?

    Private Sub TransactionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        ' Set values to fields
        txtBookTitle.Text = BookTitle
        txtBorrower.Text = BorrowerName

        ' Format and show Borrow Date
        txtBorrowDate.Text = If(BorrowDate > DateTimePicker.MinimumDateTime,
                                BorrowDate.ToString("MMMM d, yyyy"),
                                "N/A")

        ' Format and show Due Date
        txtDueDate.Text = If(DueDate > DateTimePicker.MinimumDateTime,
                             DueDate.ToString("MMMM d, yyyy"),
                             "N/A")

        ' Format and show Return Date
        If ReturnDate.HasValue Then
            txtReturnDate.Text = ReturnDate.Value.ToString("MMMM d, yyyy")
            lblStatus.Text = "Returned"
        ElseIf DueDate < Date.Today Then
            txtReturnDate.Text = ""
            lblStatus.Text = "Overdue"
            lblStatus.ForeColor = Color.DarkOrange
        Else
            txtReturnDate.Text = ""
            lblStatus.Text = "Borrowed"
            lblStatus.ForeColor = Color.Black
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class

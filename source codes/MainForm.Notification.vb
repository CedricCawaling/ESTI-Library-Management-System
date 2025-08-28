Imports System.Data.SqlClient
Imports System.Text

Partial Class MainForm

    ' ========= NOTIFICATIONS =========

    Private Sub SetupNotificationsListView()
        With dgvNotifications
            .Items.Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .HeaderStyle = ColumnHeaderStyle.Clickable

            .Columns.Clear()
            .Columns.Add("Date", 100, HorizontalAlignment.Left)
            .Columns.Add("Message", 350, HorizontalAlignment.Left)
            .Columns.Add("Sender", 120, HorizontalAlignment.Left)
        End With
    End Sub
    Private Sub LoadNotifications()
        dgvNotifications.Items.Clear()

        Dim query As String = "SELECT NotificationID, Message, Sender, DateCreated, IsRead FROM Notifications WHERE IsDeleted = 0 ORDER BY DateCreated DESC"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(Convert.ToDateTime(reader("DateCreated")).ToShortDateString())
                        item.SubItems.Add(reader("Message").ToString())
                        item.SubItems.Add(reader("Sender").ToString())
                        item.Tag = reader("NotificationID") ' Store ID for reference

                        If Not Convert.ToBoolean(reader("IsRead")) Then
                            item.BackColor = Color.LightSalmon
                        Else
                            item.BackColor = Color.WhiteSmoke
                        End If

                        dgvNotifications.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub InsertOverdueToNotifications()
        Dim overdueQuery As String = "
        SELECT TransactionID, BookTitle, BorrowerName
        FROM Transactions
        WHERE ReturnDate IS NULL AND DueDate < GETDATE()"

        Dim overdueList As New List(Of (Integer, String, String))
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Get overdue records
            Using cmd As New SqlCommand(overdueQuery, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim transID As Integer = CInt(reader("TransactionID"))
                        Dim bookTitle As String = reader("BookTitle").ToString()
                        Dim borrower As String = reader("BorrowerName").ToString()
                        overdueList.Add((transID, bookTitle, borrower))
                    End While
                End Using
            End Using

            ' Insert only if not already notified
            For Each item In overdueList
                If Not NotificationExists(conn, item.Item1) Then
                    Dim message = $"Overdue: {item.Item2} - {item.Item3}"
                    Dim insertQuery = "
                    INSERT INTO Notifications (Type, Message, Sender, RelatedID, DateCreated, IsRead, IsDeleted)
                    VALUES ('Overdue', @Message, 'System', @TransID, GETDATE(), 0, 0)"

                    Using insertCmd As New SqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@Message", message)
                        insertCmd.Parameters.AddWithValue("@TransID", item.Item1)
                        insertCmd.ExecuteNonQuery()
                    End Using
                End If
            Next
        End Using
    End Sub
    ' ========= FILTER =========
    Private Sub btnApplyFilter_Click(sender As Object, e As EventArgs) Handles btnApplyFilter.Click
        LoadFilteredNotifications()
    End Sub
    Private Sub LoadFilteredNotifications()
        dgvNotifications.Items.Clear()

        Dim selectedType = cmbType.SelectedItem?.ToString()
        Dim selectedStatus = cmbStatus.SelectedItem?.ToString()

        Dim query As New StringBuilder("SELECT NotificationID, Message, Sender, DateCreated, IsRead FROM Notifications WHERE IsDeleted = 0")

        ' Apply Type filter
        If selectedType IsNot Nothing AndAlso selectedType <> "All" Then
            query.Append(" AND Type = @Type")
        End If

        ' Apply Status filter
        If selectedStatus = "Read" Then
            query.Append(" AND IsRead = 1")
        ElseIf selectedStatus = "Unread" Then
            query.Append(" AND IsRead = 0")
        End If

        query.Append(" ORDER BY DateCreated DESC")
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query.ToString(), conn)
                If selectedType IsNot Nothing AndAlso selectedType <> "All" Then
                    cmd.Parameters.AddWithValue("@Type", selectedType)
                End If

                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(Convert.ToDateTime(reader("DateCreated")).ToShortDateString())
                        item.SubItems.Add(reader("Message").ToString())
                        item.SubItems.Add(reader("Sender").ToString())
                        item.Tag = reader("NotificationID")

                        item.BackColor = If(Convert.ToBoolean(reader("IsRead")), Color.WhiteSmoke, Color.LightSalmon)
                        dgvNotifications.Items.Add(item)
                    End While
                End Using
            End Using
        End Using
    End Sub


    ' ========= NOTIFICATION INTERACTIONS =========

    Private sortColumn As Integer = -1
    Private sortOrder As SortOrder = SortOrder.Ascending

    Private Sub dgvNotifications_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles dgvNotifications.ColumnClick
        If e.Column = sortColumn Then
            sortOrder = If(sortOrder = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
        Else
            sortColumn = e.Column
            sortOrder = SortOrder.Ascending
        End If

        dgvNotifications.ListViewItemSorter = New ListViewItemComparer(e.Column, sortOrder)
        dgvNotifications.Sort()
    End Sub

    Public Class ListViewItemComparer
        Implements IComparer

        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, sortOrder As SortOrder)
            col = column
            Me.order = sortOrder
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim returnVal As Integer = String.Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
            Return If(order = SortOrder.Descending, -returnVal, returnVal)
        End Function
    End Class

    Private Sub btnMarkAsRead_Click(sender As Object, e As EventArgs) Handles btnMarkAsRead.Click
        If dgvNotifications.SelectedItems.Count > 0 Then
            Dim item = dgvNotifications.SelectedItems(0)
            Dim notifID = CInt(item.Tag)

            Dim query = "UPDATE Notifications SET IsRead = 1 WHERE NotificationID = @ID"
            Dim connectionString As String = FormUtils.GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", notifID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadNotifications()
        End If
    End Sub
    Private Function NotificationExists(conn As SqlConnection, transID As Integer) As Boolean
        Dim query = "SELECT COUNT(*) FROM Notifications WHERE RelatedID = @TransID AND Type = 'Overdue' AND IsDeleted = 0"

        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@TransID", transID)
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Private Sub btnDeleteNotification_Click(sender As Object, e As EventArgs) Handles btnDeleteNotification.Click
        If dgvNotifications.SelectedItems.Count > 0 Then
            Dim item = dgvNotifications.SelectedItems(0)
            Dim notifID = CInt(item.Tag)

            Dim result = MessageBox.Show("Delete this notification?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim query = "UPDATE Notifications SET IsDeleted = 1 WHERE NotificationID = @ID"
                Dim connectionString As String = FormUtils.GetConnectionString()
                Using conn As New SqlConnection(connectionString)
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", notifID)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                dgvNotifications.Items.Remove(item)
                LoadNotifications()
            End If
        End If

    End Sub

End Class

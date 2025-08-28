Imports System.Configuration
Imports System.Data.SqlClient

Partial Class MainForm
    Private Sub btnBookMngmt_Click(sender As Object, e As EventArgs) Handles btnBookMngmt.Click
        Dim connStr As String = FormUtils.GetConnectionString()
        Dim recordCount As Integer = 0

        ' Check if there are any records
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM dbo.Accession", conn)
                conn.Open()
                recordCount = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using

        ' If no records found, prompt to add
        If recordCount = 0 Then
            Dim confirmResult As DialogResult = MessageBox.Show(
            "No books found. Please input book data before proceeding.",
            "Info",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information
        )

            If confirmResult = DialogResult.OK Then
                Dim editForm As New EditAccession()
                Dim result As DialogResult = editForm.ShowDialog()

                ' Recheck after user input
                Using conn As New SqlConnection(connStr)
                    Using cmd As New SqlCommand("SELECT COUNT(*) FROM dbo.Accession", conn)
                        conn.Open()
                        recordCount = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                End Using

                If result = DialogResult.OK AndAlso recordCount > 0 Then
                    bookManagementInstance = New BookManagement()
                    bookManagementInstance.Show()
                    Me.Hide()
                End If
            End If

            Return
        End If

        ' If books already exist, open directly
        If bookManagementInstance Is Nothing OrElse bookManagementInstance.IsDisposed Then
            bookManagementInstance = New BookManagement()
        End If

        bookManagementInstance.Show()
        Me.Hide()
    End Sub


    Private Function HasBookRecords() As Boolean
        Dim connStr As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand("SELECT COUNT(*) FROM dbo.Accession", conn)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Public Shared Sub ReturnToMain(currentForm As Form)
        MainForm.Show()
        currentForm.Close()
    End Sub
End Class

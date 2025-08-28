Imports System.Data.SqlClient
Imports System.Configuration

Public Class SelectBorrowerPopup
    Public SelectedName As String = ""



    Private Sub SelectBorrowerPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        cmbBorrower.Items.Clear()
        Dim connectionString As String = FormUtils.GetConnectionString()

        Using conn As New SqlConnection(connectionString)
            Dim query = "SELECT DISTINCT FullName FROM dbo.LibraryLogEntry ORDER BY FullName"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbBorrower.Items.Add(reader("FullName").ToString())
                    End While
                End Using
            End Using
        End Using
        dtpDueDate.Value = DateTime.Now.AddDays(7)

        If cmbBorrower.Items.Count > 0 Then cmbBorrower.SelectedIndex = 0
    End Sub
    Public ReadOnly Property SelectedDueDate As DateTime
        Get
            Return dtpDueDate.Value
        End Get
    End Property

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cmbBorrower.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a borrower.")
            Exit Sub
        End If

        SelectedName = cmbBorrower.SelectedItem.ToString()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class

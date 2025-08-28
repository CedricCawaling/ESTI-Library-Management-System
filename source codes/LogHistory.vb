Imports System.Configuration
Imports System.Data.SqlClient

Public Class LogHistory
    Public Property SelectedFullName As String
    Private Sub LogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        lblLogName.Text = "Logged History of " & SelectedFullName

        Dim conStr As String = FormUtils.GetConnectionString()
        Dim dt As New DataTable()

        Using con As New SqlConnection(conStr)
            con.Open()
            Dim query As String = "SELECT DateLogged, TimeIn, Role, Purpose FROM LibraryLogEntry WHERE FullName = @FullName ORDER BY DateLogged DESC, TimeIn DESC"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FullName", SelectedFullName)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvHistory.Columns.Clear()
        dgvHistory.AutoGenerateColumns = False

        dgvHistory.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colDate",
        .HeaderText = "Date Logged",
        .DataPropertyName = "DateLogged",
        .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "yyyy-MM-dd"},
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvHistory.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colTimeIn",
        .HeaderText = "Time In",
        .DataPropertyName = "TimeIn",
        .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "hh:mm tt"},
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvHistory.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colRole",
        .HeaderText = "Role",
        .DataPropertyName = "Role",
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvHistory.Columns.Add(New DataGridViewTextBoxColumn With {
        .Name = "colPurpose",
        .HeaderText = "Purpose",
        .DataPropertyName = "Purpose",
        .ReadOnly = True,
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    })

        dgvHistory.DataSource = dt
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.AllowUserToAddRows = False
    End Sub

End Class
Imports System.Configuration
Imports System.Data.SqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class LoadScreen


    Private Sub LoadScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatus.Value = 0
        Timer1.Interval = 300 ' Delay between steps (300ms for example)
        Timer1.Start()
    End Sub

    Private stage As Integer = 0 ' Stage tracker
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case stage
            Case 0
                LoadStatus.Value = 30
                lblStatus.Text = "Connecting to database..."
                stage += 1

            Case 1
                If Not CanConnectToDatabase() Then
                    Timer1.Stop()
                    MessageBox.Show("Failed to connect to the LMS database. Please check your connection settings or contact your system administrator.",
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                    Return
                End If
                LoadStatus.Value = 70
                lblStatus.Text = "Checking for admin account..."
                stage += 1

            Case 2
                If Not AdminExists() Then
                    Timer1.Stop()
                    LoadStatus.Value = 100
                    lblStatus.Text = "Launching setup..."
                    Me.Hide()
                    CreateAdmin.Show()
                Else
                    Timer1.Stop()
                    LoadStatus.Value = 100
                    lblStatus.Text = "Launching login..."
                    Me.Hide()
                    Login.Show()
                End If
        End Select
    End Sub


    Private Function CanConnectToDatabase() As Boolean
        Try
            Using conn As New SqlConnection(FormUtils.GetConnectionString())
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function AdminExists() As Boolean
        Try
            Using conn As New SqlConnection(FormUtils.GetConnectionString())
                Dim query As String = "SELECT COUNT(*) FROM Admin"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking admin data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function GetBestAvailableFont(size As Single, Optional style As FontStyle = FontStyle.Regular) As Font
        Dim preferredFonts As String() = {"Bahnschrift", "Segoe UI", "Arial"}
        For Each fontName In preferredFonts
            Try
                Return New Font(fontName, size, style)
            Catch
                ' Try next font
            End Try
        Next
        Return SystemFonts.DefaultFont
    End Function
    Private Sub ApplyFontToAllControls(parent As Control, font As Font)
        For Each ctrl As Control In parent.Controls
            Try
                ctrl.Font = font
            Catch
            End Try
            If ctrl.HasChildren Then
                ApplyFontToAllControls(ctrl, font)
            End If
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoadStatus_Click()

    End Sub
End Class

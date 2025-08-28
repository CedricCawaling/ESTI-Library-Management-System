Imports System.Configuration
Imports System.IO
Imports System.Runtime.InteropServices

Public Class MainForm

    ' ========= STATE =========
    Private showCurrent As Boolean = False
    Private showNew As Boolean = False
    Private showConfirm As Boolean = False

    ' ========= OTP =========
    Private WithEvents otpTimer As New Timer()
    Private otpTimeLeft As Integer = 90
    Private otpActive As Boolean = False
    Private totpSecret As Byte()
    Private base32Secret As String

    ' ========= ADMIN =========
    Private adminManager As New AdminManager()
    Private selectedAdminID As Integer = -1
    Private Const DefaultPasswordText As String = "@password123"

    ' ========= USER SESSION =========
    Public Shared LoggedInAdminID As String
    Public Shared LoggedInUsername As String
    Public Shared LoggedInFullname As String
    Public Shared LoggedInRole As String
    Public Shared LoggedInContact As String
    Public Shared currentProfileImagePath As String = ""
    Public Shared IsLoggingOut As Boolean = False

    ' ========= NAVIGATION INSTANCES =========
    Private Shared bookManagementInstance As BookManagement
    Private Shared transactionsInstance As Transactions
    Private Shared logEntryInstance As LogEntry
    Private Shared opacInstance As OPAC

    ' ========= PATHS & CONNECTION =========
    Private ReadOnly ProfileFolder As String = FileHelper.GetProfilePhotoFolderPath()


    ' ========= MAIN LOAD =========
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        ' Create profile picture directory if it doesn't exist
        Dim profilePicsPath = Path.Combine(Application.StartupPath, "ProfilePics")
        If Not Directory.Exists(profilePicsPath) Then Directory.CreateDirectory(profilePicsPath)

        ' Setup Admin DataGridView
        dgvAdmins.AutoGenerateColumns = False
        dgvAdmins.Columns.Clear()
        AddAdminColumns()

        ' Filter Admin list to exclude the current user
        Dim originalTable As New LMSDataSet.AdminDataTable()
        Me.AdminTableAdapter.Fill(originalTable)
        Dim view As New DataView(originalTable)
        view.RowFilter = $"AdminUsername <> '{LoggedInUsername.Replace("'", "''")}'"
        dgvAdmins.DataSource = view

        ' Start UI elements
        Timer1.Start()
        lblName.Text = LoggedInFullname
        lblRole.Text = LoggedInRole

        ' Permissions
        If LoggedInRole = "Library Clerk" Then
            AddAdmin.Enabled = False
            dgvAdmins.Enabled = False
        End If

        ' Profile image
        If Not String.IsNullOrWhiteSpace(currentProfileImagePath) AndAlso File.Exists(currentProfileImagePath) Then
            picProfile.Image = Image.FromFile(currentProfileImagePath)
        Else
            picProfile.Image = My.Resources.DefaultProfile
        End If

        ' Password fields
        txtCurrentPassword.UseSystemPasswordChar = True
        txtNewPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

        ' Eye icons
        btnViewCurrent.Image = My.Resources.Eye
        btnViewNew.Image = My.Resources.Eye
        btnViewConfirm.Image = My.Resources.Eye

        ' Buttons
        btnSave.Enabled = True
        btnVerify.Enabled = False
        btnGenerateList.Enabled = False

        ' Notifications filters
        cmbType.Items.AddRange(New String() {"All", "Overdue", "System Alerts", "General"})
        cmbType.SelectedIndex = 0

        cmbStatus.Items.AddRange(New String() {"All", "Read", "Unread"})
        cmbStatus.SelectedIndex = 0

        ' Initialize features
        LoadProfilePanel()
        InsertOverdueToNotifications()
        SetupNotificationsListView()
        LoadNotifications()

        ' Statistics
        LoadLogChart("Weekly") ' ← Replace LoadCustomLineChart()
        LoadBookCategoryBarChart()
        LoadStatistics()
        rdoWeekly.Checked = True

        ' Justify About content and highlight Home
        JustifyRichText(RichTextBox1)
        SetActiveButton(btnHome, My.Resources.actHomepage)
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not IsLoggingOut Then
            ' User clicked X → exit app
            Application.Exit()
        End If
    End Sub


End Class

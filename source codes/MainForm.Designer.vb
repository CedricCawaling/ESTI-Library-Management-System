<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Header = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel44 = New System.Windows.Forms.TableLayoutPanel()
        Me.picLMS = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picESTI = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New LMS.RoundedButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AboutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RoundedPanel6 = New LMS.RoundedPanel()
        Me.TableLayoutPanel45 = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Navigation = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.picProfile = New LMS.RoundPictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New LMS.RoundedButton()
        Me.btnNotif = New LMS.RoundedButton()
        Me.btnStatistics = New LMS.RoundedButton()
        Me.btnSettings = New LMS.RoundedButton()
        Me.btnHome = New LMS.RoundedButton()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Settings = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel24 = New System.Windows.Forms.TableLayoutPanel()
        Me.ChangePW = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel26 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblChangePW = New System.Windows.Forms.Label()
        Me.TableLayoutPanel27 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel28 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnViewConfirm = New LMS.RoundedButton()
        Me.btnViewNew = New LMS.RoundedButton()
        Me.txtConfirmPassword = New LMS.RoundedTextbox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.btnViewCurrent = New LMS.RoundedButton()
        Me.txtCurrentPassword = New LMS.RoundedTextbox()
        Me.txtNewPassword = New LMS.RoundedTextbox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblPasswordStrength = New System.Windows.Forms.Label()
        Me.TableLayoutPanel29 = New System.Windows.Forms.TableLayoutPanel()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel31 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New LMS.RoundedButton()
        Me.TableLayoutPanel30 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnVerify = New LMS.RoundedButton()
        Me.txtCode = New LMS.RoundedTextbox()
        Me.ProfileMngmt = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel32 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel33 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUsername = New LMS.RoundedTextbox()
        Me.lblProfilePicture = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtFullname = New LMS.RoundedTextbox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New LMS.RoundedTextbox()
        Me.TableLayoutPanel34 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnChoosePhoto = New LMS.RoundedButton()
        Me.lblProfileMngmt = New System.Windows.Forms.Label()
        Me.TableLayoutPanel36 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnResetProfile = New LMS.RoundedButton()
        Me.btnSaveProfile = New LMS.RoundedButton()
        Me.TableLayoutPanel25 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvAdmins = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddAdmin = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel35 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel37 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAddFirstname = New System.Windows.Forms.Label()
        Me.lblAddLastname = New System.Windows.Forms.Label()
        Me.txtAddAdminUsername = New LMS.RoundedTextbox()
        Me.cmbChooseRole = New System.Windows.Forms.ComboBox()
        Me.txtAddContact = New LMS.RoundedTextbox()
        Me.txtAddAdminFullname = New LMS.RoundedTextbox()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.lblAddRole = New System.Windows.Forms.Label()
        Me.TableLayoutPanel38 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New LMS.RoundedButton()
        Me.btnAddAdmin = New LMS.RoundedButton()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMSDataSet = New LMS.LMSDataSet()
        Me.Notifications = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlNotifications = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel42 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNotifications = New System.Windows.Forms.Label()
        Me.grpFiltersNotif = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnApplyFilter = New LMS.RoundedButton()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.dgvNotifications = New System.Windows.Forms.ListView()
        Me.TableLayoutPanel43 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDeleteNotification = New LMS.RoundedButton()
        Me.btnMarkAsRead = New LMS.RoundedButton()
        Me.Statistics = New System.Windows.Forms.TableLayoutPanel()
        Me.StatsGeneral = New System.Windows.Forms.TableLayoutPanel()
        Me.BookStats = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomBarChart1 = New LMS.CustomBarChart()
        Me.LogEntryStats = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.rdoAnnual = New System.Windows.Forms.RadioButton()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lcLogEnrtries = New LMS.CustomLineChart()
        Me.OutlineRoundPanel1 = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkHighSchoolBooks = New System.Windows.Forms.CheckBox()
        Me.chkComputerScienceBooks = New System.Windows.Forms.CheckBox()
        Me.chkNonFictionBooks = New System.Windows.Forms.CheckBox()
        Me.chkTourismBooks = New System.Windows.Forms.CheckBox()
        Me.chkFilipinianaBooks = New System.Windows.Forms.CheckBox()
        Me.chkReferenceBooks = New System.Windows.Forms.CheckBox()
        Me.chkCriminologyBooks = New System.Windows.Forms.CheckBox()
        Me.chkMagazines = New System.Windows.Forms.CheckBox()
        Me.chkGeneralCirculation = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGenerateAll = New LMS.RoundedButton()
        Me.btnGenerateList = New LMS.RoundedButton()
        Me.AdminTableAdapter = New LMS.LMSDataSetTableAdapters.AdminTableAdapter()
        Me.LMSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Homepage = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.QuickAccessOutline = New LMS.OutlineRoundPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel41 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnQuickReport = New LMS.RoundedButton()
        Me.btnQuickLog = New LMS.RoundedButton()
        Me.btnQuickBookAdd = New LMS.RoundedButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel40 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAccession = New System.Windows.Forms.Label()
        Me.lblOPAC = New System.Windows.Forms.Label()
        Me.lblEntryLogs = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.btnTransactions = New LMS.RoundedButton()
        Me.btnOPAC = New LMS.RoundedButton()
        Me.btnBookMngmt = New LMS.RoundedButton()
        Me.btnEntryLogs = New LMS.RoundedButton()
        Me.RoundedPanel1 = New LMS.RoundedPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.RoundedPanel5 = New LMS.RoundedPanel()
        Me.TableLayoutPanel39 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalLogs = New System.Windows.Forms.Label()
        Me.RoundedPanel4 = New LMS.RoundedPanel()
        Me.TableLayoutPanel23 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalOverdue = New System.Windows.Forms.Label()
        Me.RoundedPanel3 = New LMS.RoundedPanel()
        Me.TableLayoutPanel22 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalReturned = New System.Windows.Forms.Label()
        Me.RoundedPanel2 = New LMS.RoundedPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalBorrowed = New System.Windows.Forms.Label()
        Me.displayTotalBooks = New LMS.RoundedPanel()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalBooks = New System.Windows.Forms.Label()
        Me.lblTotalBook = New System.Windows.Forms.Label()
        Me.lblRecentLogs = New System.Windows.Forms.Label()
        Me.lblReturned = New System.Windows.Forms.Label()
        Me.lblOverdue = New System.Windows.Forms.Label()
        Me.lblBorrowed = New System.Windows.Forms.Label()
        Me.Header.SuspendLayout()
        Me.TableLayoutPanel44.SuspendLayout()
        CType(Me.picLMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picESTI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AboutPanel.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel6.SuspendLayout()
        Me.TableLayoutPanel45.SuspendLayout()
        Me.Navigation.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.TableLayoutPanel19.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel20.SuspendLayout()
        Me.TableLayoutPanel21.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel24.SuspendLayout()
        Me.ChangePW.SuspendLayout()
        Me.TableLayoutPanel26.SuspendLayout()
        Me.TableLayoutPanel27.SuspendLayout()
        Me.TableLayoutPanel28.SuspendLayout()
        Me.TableLayoutPanel29.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel31.SuspendLayout()
        Me.TableLayoutPanel30.SuspendLayout()
        Me.ProfileMngmt.SuspendLayout()
        Me.TableLayoutPanel32.SuspendLayout()
        Me.TableLayoutPanel33.SuspendLayout()
        Me.TableLayoutPanel34.SuspendLayout()
        Me.TableLayoutPanel36.SuspendLayout()
        Me.TableLayoutPanel25.SuspendLayout()
        CType(Me.dgvAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddAdmin.SuspendLayout()
        Me.TableLayoutPanel35.SuspendLayout()
        Me.TableLayoutPanel37.SuspendLayout()
        Me.TableLayoutPanel38.SuspendLayout()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Notifications.SuspendLayout()
        Me.pnlNotifications.SuspendLayout()
        Me.TableLayoutPanel42.SuspendLayout()
        Me.grpFiltersNotif.SuspendLayout()
        Me.TableLayoutPanel43.SuspendLayout()
        Me.Statistics.SuspendLayout()
        Me.StatsGeneral.SuspendLayout()
        Me.BookStats.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.LogEntryStats.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.OutlineRoundPanel1.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel17.SuspendLayout()
        CType(Me.LMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Homepage.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.QuickAccessOutline.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel41.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel40.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.RoundedPanel5.SuspendLayout()
        Me.TableLayoutPanel39.SuspendLayout()
        Me.RoundedPanel4.SuspendLayout()
        Me.TableLayoutPanel23.SuspendLayout()
        Me.RoundedPanel3.SuspendLayout()
        Me.TableLayoutPanel22.SuspendLayout()
        Me.RoundedPanel2.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.displayTotalBooks.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Controls.Add(Me.TableLayoutPanel44)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1370, 110)
        Me.Header.TabIndex = 0
        '
        'TableLayoutPanel44
        '
        Me.TableLayoutPanel44.ColumnCount = 4
        Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.114035!))
        Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.76608!))
        Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.04678!))
        Me.TableLayoutPanel44.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel44.Controls.Add(Me.picLMS, 1, 0)
        Me.TableLayoutPanel44.Controls.Add(Me.picLogo, 0, 0)
        Me.TableLayoutPanel44.Controls.Add(Me.picESTI, 1, 0)
        Me.TableLayoutPanel44.Controls.Add(Me.btnAbout, 3, 0)
        Me.TableLayoutPanel44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel44.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel44.Name = "TableLayoutPanel44"
        Me.TableLayoutPanel44.RowCount = 1
        Me.TableLayoutPanel44.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel44.Size = New System.Drawing.Size(1368, 108)
        Me.TableLayoutPanel44.TabIndex = 0
        '
        'picLMS
        '
        Me.picLMS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picLMS.Image = CType(resources.GetObject("picLMS.Image"), System.Drawing.Image)
        Me.picLMS.Location = New System.Drawing.Point(316, 15)
        Me.picLMS.Name = "picLMS"
        Me.picLMS.Size = New System.Drawing.Size(283, 78)
        Me.picLMS.TabIndex = 6
        Me.picLMS.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(14, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(94, 90)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'picESTI
        '
        Me.picESTI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.picESTI.Image = CType(resources.GetObject("picESTI.Image"), System.Drawing.Image)
        Me.picESTI.Location = New System.Drawing.Point(114, 15)
        Me.picESTI.Name = "picESTI"
        Me.picESTI.Size = New System.Drawing.Size(196, 78)
        Me.picESTI.TabIndex = 5
        Me.picESTI.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Image = Global.LMS.My.Resources.Resources.about
        Me.btnAbout.Location = New System.Drawing.Point(1308, 27)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(57, 54)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'AboutPanel
        '
        Me.AboutPanel.BackColor = System.Drawing.Color.White
        Me.AboutPanel.ColumnCount = 1
        Me.AboutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.AboutPanel.Controls.Add(Me.PictureBox7, 0, 0)
        Me.AboutPanel.Controls.Add(Me.PictureBox8, 0, 1)
        Me.AboutPanel.Controls.Add(Me.RoundedPanel6, 0, 2)
        Me.AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AboutPanel.Location = New System.Drawing.Point(238, 110)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.RowCount = 3
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323.0!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.79109!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.20892!))
        Me.AboutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.AboutPanel.Size = New System.Drawing.Size(1132, 639)
        Me.AboutPanel.TabIndex = 3
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(300, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(531, 317)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(343, 326)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(445, 72)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'RoundedPanel6
        '
        Me.RoundedPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedPanel6.Controls.Add(Me.TableLayoutPanel45)
        Me.RoundedPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel6.Location = New System.Drawing.Point(3, 404)
        Me.RoundedPanel6.Name = "RoundedPanel6"
        Me.RoundedPanel6.Size = New System.Drawing.Size(1126, 232)
        Me.RoundedPanel6.TabIndex = 3
        '
        'TableLayoutPanel45
        '
        Me.TableLayoutPanel45.ColumnCount = 1
        Me.TableLayoutPanel45.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1126.0!))
        Me.TableLayoutPanel45.Controls.Add(Me.RichTextBox1, 0, 0)
        Me.TableLayoutPanel45.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel45.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel45.Name = "TableLayoutPanel45"
        Me.TableLayoutPanel45.RowCount = 1
        Me.TableLayoutPanel45.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel45.Size = New System.Drawing.Size(1126, 232)
        Me.TableLayoutPanel45.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(29, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(1068, 207)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Navigation
        '
        Me.Navigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Navigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Navigation.Controls.Add(Me.TableLayoutPanel1)
        Me.Navigation.Dock = System.Windows.Forms.DockStyle.Left
        Me.Navigation.Location = New System.Drawing.Point(0, 110)
        Me.Navigation.Name = "Navigation"
        Me.Navigation.Size = New System.Drawing.Size(238, 639)
        Me.Navigation.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel18, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel20, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.14757!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.85243!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(236, 637)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.ColumnCount = 3
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel18.Controls.Add(Me.TableLayoutPanel19, 1, 1)
        Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 3
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(230, 237)
        Me.TableLayoutPanel18.TabIndex = 1
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 3
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213.0!))
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.lblRole, 1, 3)
        Me.TableLayoutPanel19.Controls.Add(Me.picProfile, 1, 1)
        Me.TableLayoutPanel19.Controls.Add(Me.lblName, 1, 2)
        Me.TableLayoutPanel19.Controls.Add(Me.lblPosition, 1, 0)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 5
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(224, 230)
        Me.TableLayoutPanel19.TabIndex = 0
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRole.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(8, 189)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(207, 19)
        Me.lblRole.TabIndex = 17
        Me.lblRole.Text = "Librarian"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picProfile
        '
        Me.picProfile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picProfile.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picProfile.Location = New System.Drawing.Point(61, 48)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(100, 95)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 14
        Me.picProfile.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(8, 155)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(207, 34)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPosition.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblPosition.Location = New System.Drawing.Point(8, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(207, 36)
        Me.lblPosition.TabIndex = 14
        Me.lblPosition.Text = "Administrator"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.ColumnCount = 1
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.btnLogout, 0, 4)
        Me.TableLayoutPanel20.Controls.Add(Me.btnNotif, 0, 2)
        Me.TableLayoutPanel20.Controls.Add(Me.btnStatistics, 0, 3)
        Me.TableLayoutPanel20.Controls.Add(Me.btnSettings, 0, 1)
        Me.TableLayoutPanel20.Controls.Add(Me.btnHome, 0, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.TableLayoutPanel21, 0, 5)
        Me.TableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(3, 246)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 6
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(230, 388)
        Me.TableLayoutPanel20.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.LMS.My.Resources.Resources.Slogout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(9, 203)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(212, 44)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "  Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnNotif
        '
        Me.btnNotif.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNotif.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotif.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotif.ForeColor = System.Drawing.Color.White
        Me.btnNotif.Image = Global.LMS.My.Resources.Resources.Snotif
        Me.btnNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotif.Location = New System.Drawing.Point(9, 103)
        Me.btnNotif.Name = "btnNotif"
        Me.btnNotif.Size = New System.Drawing.Size(212, 44)
        Me.btnNotif.TabIndex = 17
        Me.btnNotif.Text = "  Notifications"
        Me.btnNotif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotif.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStatistics.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Image = Global.LMS.My.Resources.Resources.StatsA
        Me.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistics.Location = New System.Drawing.Point(9, 153)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(212, 44)
        Me.btnStatistics.TabIndex = 15
        Me.btnStatistics.Text = "   Statistics"
        Me.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = Global.LMS.My.Resources.Resources.Ssettings
        Me.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSettings.Location = New System.Drawing.Point(9, 53)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(212, 44)
        Me.btnSettings.TabIndex = 18
        Me.btnSettings.Text = "  Settings"
        Me.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Font = New System.Drawing.Font("Bahnschrift SemiLight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.LMS.My.Resources.Resources.homepageS
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(9, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(212, 44)
        Me.btnHome.TabIndex = 14
        Me.btnHome.Text = "  Homepage"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel21
        '
        Me.TableLayoutPanel21.ColumnCount = 1
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel21.Controls.Add(Me.lblTime, 0, 0)
        Me.TableLayoutPanel21.Controls.Add(Me.lblDate, 0, 1)
        Me.TableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel21.Location = New System.Drawing.Point(3, 253)
        Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
        Me.TableLayoutPanel21.RowCount = 3
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel21.Size = New System.Drawing.Size(224, 132)
        Me.TableLayoutPanel21.TabIndex = 19
        '
        'lblTime
        '
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTime.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTime.Location = New System.Drawing.Point(3, 36)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(218, 50)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "12 am"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDate
        '
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("HoloLens MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(3, 86)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(218, 37)
        Me.lblDate.TabIndex = 27
        Me.lblDate.Text = "july"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.White
        Me.Settings.Controls.Add(Me.TableLayoutPanel8)
        Me.Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings.Location = New System.Drawing.Point(238, 110)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(1132, 639)
        Me.Settings.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel24, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel25, 0, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.07042!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.92958!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1132, 639)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'TableLayoutPanel24
        '
        Me.TableLayoutPanel24.ColumnCount = 2
        Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.09591!))
        Me.TableLayoutPanel24.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.90409!))
        Me.TableLayoutPanel24.Controls.Add(Me.ChangePW, 1, 0)
        Me.TableLayoutPanel24.Controls.Add(Me.ProfileMngmt, 0, 0)
        Me.TableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel24.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel24.Name = "TableLayoutPanel24"
        Me.TableLayoutPanel24.RowCount = 1
        Me.TableLayoutPanel24.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel24.Size = New System.Drawing.Size(1126, 281)
        Me.TableLayoutPanel24.TabIndex = 0
        '
        'ChangePW
        '
        Me.ChangePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ChangePW.BorderColor = System.Drawing.Color.Black
        Me.ChangePW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePW.BorderWidth = 6
        Me.ChangePW.Controls.Add(Me.TableLayoutPanel26)
        Me.ChangePW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePW.Location = New System.Drawing.Point(476, 3)
        Me.ChangePW.Name = "ChangePW"
        Me.ChangePW.Size = New System.Drawing.Size(647, 275)
        Me.ChangePW.TabIndex = 19
        '
        'TableLayoutPanel26
        '
        Me.TableLayoutPanel26.ColumnCount = 1
        Me.TableLayoutPanel26.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel26.Controls.Add(Me.lblChangePW, 0, 0)
        Me.TableLayoutPanel26.Controls.Add(Me.TableLayoutPanel27, 0, 1)
        Me.TableLayoutPanel26.Controls.Add(Me.TableLayoutPanel31, 0, 2)
        Me.TableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel26.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel26.Name = "TableLayoutPanel26"
        Me.TableLayoutPanel26.RowCount = 3
        Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel26.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel26.Size = New System.Drawing.Size(645, 273)
        Me.TableLayoutPanel26.TabIndex = 0
        '
        'lblChangePW
        '
        Me.lblChangePW.AutoSize = True
        Me.lblChangePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblChangePW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblChangePW.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePW.ForeColor = System.Drawing.Color.White
        Me.lblChangePW.Location = New System.Drawing.Point(3, 0)
        Me.lblChangePW.Name = "lblChangePW"
        Me.lblChangePW.Size = New System.Drawing.Size(639, 43)
        Me.lblChangePW.TabIndex = 17
        Me.lblChangePW.Text = "Change Password"
        Me.lblChangePW.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel27
        '
        Me.TableLayoutPanel27.ColumnCount = 2
        Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.00146!))
        Me.TableLayoutPanel27.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.99854!))
        Me.TableLayoutPanel27.Controls.Add(Me.TableLayoutPanel28, 0, 0)
        Me.TableLayoutPanel27.Controls.Add(Me.TableLayoutPanel29, 1, 0)
        Me.TableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel27.Location = New System.Drawing.Point(3, 46)
        Me.TableLayoutPanel27.Name = "TableLayoutPanel27"
        Me.TableLayoutPanel27.RowCount = 1
        Me.TableLayoutPanel27.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel27.Size = New System.Drawing.Size(639, 166)
        Me.TableLayoutPanel27.TabIndex = 0
        '
        'TableLayoutPanel28
        '
        Me.TableLayoutPanel28.ColumnCount = 3
        Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.62551!))
        Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.32099!))
        Me.TableLayoutPanel28.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.259259!))
        Me.TableLayoutPanel28.Controls.Add(Me.btnViewConfirm, 2, 3)
        Me.TableLayoutPanel28.Controls.Add(Me.btnViewNew, 2, 1)
        Me.TableLayoutPanel28.Controls.Add(Me.txtConfirmPassword, 1, 3)
        Me.TableLayoutPanel28.Controls.Add(Me.lblConfirmPassword, 0, 3)
        Me.TableLayoutPanel28.Controls.Add(Me.lblCurrentPassword, 0, 0)
        Me.TableLayoutPanel28.Controls.Add(Me.btnViewCurrent, 2, 0)
        Me.TableLayoutPanel28.Controls.Add(Me.txtCurrentPassword, 1, 0)
        Me.TableLayoutPanel28.Controls.Add(Me.txtNewPassword, 1, 1)
        Me.TableLayoutPanel28.Controls.Add(Me.lblNewPassword, 0, 1)
        Me.TableLayoutPanel28.Controls.Add(Me.lblPasswordStrength, 1, 2)
        Me.TableLayoutPanel28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel28.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel28.Name = "TableLayoutPanel28"
        Me.TableLayoutPanel28.RowCount = 5
        Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel28.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel28.Size = New System.Drawing.Size(486, 160)
        Me.TableLayoutPanel28.TabIndex = 0
        '
        'btnViewConfirm
        '
        Me.btnViewConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnViewConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnViewConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewConfirm.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewConfirm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnViewConfirm.Image = Global.LMS.My.Resources.Resources.EyeSlash
        Me.btnViewConfirm.Location = New System.Drawing.Point(443, 112)
        Me.btnViewConfirm.Name = "btnViewConfirm"
        Me.btnViewConfirm.Size = New System.Drawing.Size(40, 21)
        Me.btnViewConfirm.TabIndex = 50
        Me.btnViewConfirm.UseVisualStyleBackColor = False
        '
        'btnViewNew
        '
        Me.btnViewNew.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnViewNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnViewNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewNew.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnViewNew.Image = Global.LMS.My.Resources.Resources.EyeSlash
        Me.btnViewNew.Location = New System.Drawing.Point(443, 44)
        Me.btnViewNew.Name = "btnViewNew"
        Me.btnViewNew.Size = New System.Drawing.Size(40, 25)
        Me.btnViewNew.TabIndex = 40
        Me.btnViewNew.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(181, 109)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtConfirmPassword.TabIndex = 50
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(3, 93)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(171, 59)
        Me.lblConfirmPassword.TabIndex = 51
        Me.lblConfirmPassword.Text = "Confirm New Password"
        Me.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrentPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCurrentPassword.Location = New System.Drawing.Point(3, 0)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(171, 38)
        Me.lblCurrentPassword.TabIndex = 28
        Me.lblCurrentPassword.Text = "Current Password"
        Me.lblCurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewCurrent
        '
        Me.btnViewCurrent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnViewCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnViewCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewCurrent.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnViewCurrent.Image = Global.LMS.My.Resources.Resources.EyeSlash
        Me.btnViewCurrent.Location = New System.Drawing.Point(443, 6)
        Me.btnViewCurrent.Name = "btnViewCurrent"
        Me.btnViewCurrent.Size = New System.Drawing.Size(40, 25)
        Me.btnViewCurrent.TabIndex = 33
        Me.btnViewCurrent.UseVisualStyleBackColor = False
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(181, 5)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtCurrentPassword.TabIndex = 29
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(181, 43)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(254, 27)
        Me.txtNewPassword.TabIndex = 45
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNewPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblNewPassword.Location = New System.Drawing.Point(3, 38)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(171, 38)
        Me.lblNewPassword.TabIndex = 44
        Me.lblNewPassword.Text = "New Password"
        Me.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPasswordStrength
        '
        Me.lblPasswordStrength.AutoSize = True
        Me.lblPasswordStrength.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPasswordStrength.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStrength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblPasswordStrength.Location = New System.Drawing.Point(180, 76)
        Me.lblPasswordStrength.Name = "lblPasswordStrength"
        Me.lblPasswordStrength.Size = New System.Drawing.Size(257, 17)
        Me.lblPasswordStrength.TabIndex = 33
        Me.lblPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel29
        '
        Me.TableLayoutPanel29.ColumnCount = 1
        Me.TableLayoutPanel29.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel29.Controls.Add(Me.picQRCode, 0, 0)
        Me.TableLayoutPanel29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel29.Location = New System.Drawing.Point(495, 3)
        Me.TableLayoutPanel29.Name = "TableLayoutPanel29"
        Me.TableLayoutPanel29.RowCount = 1
        Me.TableLayoutPanel29.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel29.Size = New System.Drawing.Size(141, 160)
        Me.TableLayoutPanel29.TabIndex = 1
        '
        'picQRCode
        '
        Me.picQRCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picQRCode.BackColor = System.Drawing.Color.White
        Me.picQRCode.Location = New System.Drawing.Point(10, 24)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(120, 112)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQRCode.TabIndex = 23
        Me.picQRCode.TabStop = False
        '
        'TableLayoutPanel31
        '
        Me.TableLayoutPanel31.ColumnCount = 3
        Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342.0!))
        Me.TableLayoutPanel31.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel31.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel31.Controls.Add(Me.TableLayoutPanel30, 2, 0)
        Me.TableLayoutPanel31.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel31.Location = New System.Drawing.Point(3, 218)
        Me.TableLayoutPanel31.Name = "TableLayoutPanel31"
        Me.TableLayoutPanel31.RowCount = 1
        Me.TableLayoutPanel31.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel31.Size = New System.Drawing.Size(639, 52)
        Me.TableLayoutPanel31.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(251, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 27)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel30
        '
        Me.TableLayoutPanel30.ColumnCount = 2
        Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438!))
        Me.TableLayoutPanel30.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562!))
        Me.TableLayoutPanel30.Controls.Add(Me.btnVerify, 1, 0)
        Me.TableLayoutPanel30.Controls.Add(Me.txtCode, 0, 0)
        Me.TableLayoutPanel30.Location = New System.Drawing.Point(493, 3)
        Me.TableLayoutPanel30.Name = "TableLayoutPanel30"
        Me.TableLayoutPanel30.RowCount = 1
        Me.TableLayoutPanel30.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel30.Size = New System.Drawing.Size(143, 32)
        Me.TableLayoutPanel30.TabIndex = 0
        '
        'btnVerify
        '
        Me.btnVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnVerify.Location = New System.Drawing.Point(83, 3)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(51, 25)
        Me.btnVerify.TabIndex = 26
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCode.Location = New System.Drawing.Point(9, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(68, 23)
        Me.txtCode.TabIndex = 25
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProfileMngmt
        '
        Me.ProfileMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.ProfileMngmt.BorderColor = System.Drawing.Color.Black
        Me.ProfileMngmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfileMngmt.BorderWidth = 6
        Me.ProfileMngmt.Controls.Add(Me.TableLayoutPanel32)
        Me.ProfileMngmt.Location = New System.Drawing.Point(3, 3)
        Me.ProfileMngmt.Name = "ProfileMngmt"
        Me.ProfileMngmt.Size = New System.Drawing.Size(458, 275)
        Me.ProfileMngmt.TabIndex = 20
        '
        'TableLayoutPanel32
        '
        Me.TableLayoutPanel32.ColumnCount = 1
        Me.TableLayoutPanel32.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel32.Controls.Add(Me.TableLayoutPanel33, 0, 1)
        Me.TableLayoutPanel32.Controls.Add(Me.lblProfileMngmt, 0, 0)
        Me.TableLayoutPanel32.Controls.Add(Me.TableLayoutPanel36, 0, 2)
        Me.TableLayoutPanel32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel32.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel32.Name = "TableLayoutPanel32"
        Me.TableLayoutPanel32.RowCount = 3
        Me.TableLayoutPanel32.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel32.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel32.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.89189!))
        Me.TableLayoutPanel32.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel32.Size = New System.Drawing.Size(456, 273)
        Me.TableLayoutPanel32.TabIndex = 0
        '
        'TableLayoutPanel33
        '
        Me.TableLayoutPanel33.ColumnCount = 2
        Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.88889!))
        Me.TableLayoutPanel33.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.11111!))
        Me.TableLayoutPanel33.Controls.Add(Me.txtUsername, 1, 0)
        Me.TableLayoutPanel33.Controls.Add(Me.lblProfilePicture, 0, 3)
        Me.TableLayoutPanel33.Controls.Add(Me.lblUsername, 0, 0)
        Me.TableLayoutPanel33.Controls.Add(Me.lblLastname, 0, 1)
        Me.TableLayoutPanel33.Controls.Add(Me.txtFullname, 1, 1)
        Me.TableLayoutPanel33.Controls.Add(Me.lblContact, 0, 2)
        Me.TableLayoutPanel33.Controls.Add(Me.txtContact, 1, 2)
        Me.TableLayoutPanel33.Controls.Add(Me.TableLayoutPanel34, 1, 3)
        Me.TableLayoutPanel33.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel33.Location = New System.Drawing.Point(3, 55)
        Me.TableLayoutPanel33.Name = "TableLayoutPanel33"
        Me.TableLayoutPanel33.RowCount = 4
        Me.TableLayoutPanel33.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel33.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel33.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel33.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel33.Size = New System.Drawing.Size(450, 158)
        Me.TableLayoutPanel33.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(131, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(300, 27)
        Me.txtUsername.TabIndex = 35
        '
        'lblProfilePicture
        '
        Me.lblProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProfilePicture.AutoSize = True
        Me.lblProfilePicture.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfilePicture.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblProfilePicture.Location = New System.Drawing.Point(7, 126)
        Me.lblProfilePicture.Name = "lblProfilePicture"
        Me.lblProfilePicture.Size = New System.Drawing.Size(102, 19)
        Me.lblProfilePicture.TabIndex = 40
        Me.lblProfilePicture.Text = "Profile Picture:"
        Me.lblProfilePicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(33, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(76, 19)
        Me.lblUsername.TabIndex = 34
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblLastname.Location = New System.Drawing.Point(34, 46)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 19)
        Me.lblLastname.TabIndex = 44
        Me.lblLastname.Text = "Full Name:"
        Me.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFullname
        '
        Me.txtFullname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(131, 42)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(300, 27)
        Me.txtFullname.TabIndex = 45
        '
        'lblContact
        '
        Me.lblContact.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(21, 84)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(88, 19)
        Me.lblContact.TabIndex = 46
        Me.lblContact.Text = "Contact Info:"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContact
        '
        Me.txtContact.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(131, 80)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(300, 27)
        Me.txtContact.TabIndex = 47
        '
        'TableLayoutPanel34
        '
        Me.TableLayoutPanel34.ColumnCount = 2
        Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel34.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel34.Controls.Add(Me.lblFilePath, 1, 0)
        Me.TableLayoutPanel34.Controls.Add(Me.btnChoosePhoto, 0, 0)
        Me.TableLayoutPanel34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel34.Location = New System.Drawing.Point(115, 116)
        Me.TableLayoutPanel34.Name = "TableLayoutPanel34"
        Me.TableLayoutPanel34.RowCount = 1
        Me.TableLayoutPanel34.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel34.Size = New System.Drawing.Size(332, 39)
        Me.TableLayoutPanel34.TabIndex = 48
        '
        'lblFilePath
        '
        Me.lblFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblFilePath.Location = New System.Drawing.Point(169, 11)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(95, 16)
        Me.lblFilePath.TabIndex = 43
        Me.lblFilePath.Text = "*Image Location*"
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChoosePhoto.BackColor = System.Drawing.Color.LightGray
        Me.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePhoto.Location = New System.Drawing.Point(17, 6)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(131, 27)
        Me.btnChoosePhoto.TabIndex = 41
        Me.btnChoosePhoto.Text = "Choose Photo"
        Me.btnChoosePhoto.UseVisualStyleBackColor = False
        '
        'lblProfileMngmt
        '
        Me.lblProfileMngmt.AutoSize = True
        Me.lblProfileMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblProfileMngmt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProfileMngmt.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileMngmt.ForeColor = System.Drawing.Color.White
        Me.lblProfileMngmt.Location = New System.Drawing.Point(3, 0)
        Me.lblProfileMngmt.Name = "lblProfileMngmt"
        Me.lblProfileMngmt.Size = New System.Drawing.Size(450, 52)
        Me.lblProfileMngmt.TabIndex = 33
        Me.lblProfileMngmt.Text = "Profile Management"
        Me.lblProfileMngmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel36
        '
        Me.TableLayoutPanel36.ColumnCount = 2
        Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel36.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel36.Controls.Add(Me.btnResetProfile, 0, 0)
        Me.TableLayoutPanel36.Controls.Add(Me.btnSaveProfile, 0, 0)
        Me.TableLayoutPanel36.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel36.Location = New System.Drawing.Point(3, 219)
        Me.TableLayoutPanel36.Name = "TableLayoutPanel36"
        Me.TableLayoutPanel36.RowCount = 1
        Me.TableLayoutPanel36.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel36.Size = New System.Drawing.Size(450, 51)
        Me.TableLayoutPanel36.TabIndex = 34
        '
        'btnResetProfile
        '
        Me.btnResetProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnResetProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetProfile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnResetProfile.Location = New System.Drawing.Point(228, 3)
        Me.btnResetProfile.Name = "btnResetProfile"
        Me.btnResetProfile.Size = New System.Drawing.Size(136, 27)
        Me.btnResetProfile.TabIndex = 46
        Me.btnResetProfile.Text = "Reset"
        Me.btnResetProfile.UseVisualStyleBackColor = False
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSaveProfile.Location = New System.Drawing.Point(86, 3)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(136, 27)
        Me.btnSaveProfile.TabIndex = 45
        Me.btnSaveProfile.Text = "Save"
        Me.btnSaveProfile.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel25
        '
        Me.TableLayoutPanel25.ColumnCount = 2
        Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.3659!))
        Me.TableLayoutPanel25.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.6341!))
        Me.TableLayoutPanel25.Controls.Add(Me.dgvAdmins, 0, 0)
        Me.TableLayoutPanel25.Controls.Add(Me.AddAdmin, 0, 0)
        Me.TableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel25.Location = New System.Drawing.Point(3, 290)
        Me.TableLayoutPanel25.Name = "TableLayoutPanel25"
        Me.TableLayoutPanel25.RowCount = 1
        Me.TableLayoutPanel25.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.166667!))
        Me.TableLayoutPanel25.Size = New System.Drawing.Size(1126, 346)
        Me.TableLayoutPanel25.TabIndex = 1
        '
        'dgvAdmins
        '
        Me.dgvAdmins.AllowUserToAddRows = False
        Me.dgvAdmins.AllowUserToDeleteRows = False
        Me.dgvAdmins.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dgvAdmins.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnEdit, Me.btnDelete})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAdmins.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAdmins.Location = New System.Drawing.Point(444, 72)
        Me.dgvAdmins.Name = "dgvAdmins"
        Me.dgvAdmins.ReadOnly = True
        Me.dgvAdmins.Size = New System.Drawing.Size(669, 271)
        Me.dgvAdmins.TabIndex = 30
        '
        'btnEdit
        '
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.btnEdit.HeaderText = ""
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ReadOnly = True
        Me.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseColumnTextForButtonValue = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'AddAdmin
        '
        Me.AddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.AddAdmin.BorderColor = System.Drawing.Color.Black
        Me.AddAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddAdmin.BorderWidth = 6
        Me.AddAdmin.Controls.Add(Me.TableLayoutPanel35)
        Me.AddAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddAdmin.Location = New System.Drawing.Point(3, 72)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(426, 271)
        Me.AddAdmin.TabIndex = 29
        '
        'TableLayoutPanel35
        '
        Me.TableLayoutPanel35.ColumnCount = 1
        Me.TableLayoutPanel35.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel35.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel35.Controls.Add(Me.TableLayoutPanel37, 0, 1)
        Me.TableLayoutPanel35.Controls.Add(Me.TableLayoutPanel38, 0, 2)
        Me.TableLayoutPanel35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel35.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel35.Name = "TableLayoutPanel35"
        Me.TableLayoutPanel35.RowCount = 3
        Me.TableLayoutPanel35.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel35.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel35.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.39326!))
        Me.TableLayoutPanel35.Size = New System.Drawing.Size(424, 269)
        Me.TableLayoutPanel35.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(418, 55)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Admin Management"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TableLayoutPanel37
        '
        Me.TableLayoutPanel37.ColumnCount = 2
        Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel37.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.93023!))
        Me.TableLayoutPanel37.Controls.Add(Me.lblAddFirstname, 0, 0)
        Me.TableLayoutPanel37.Controls.Add(Me.lblAddLastname, 0, 1)
        Me.TableLayoutPanel37.Controls.Add(Me.txtAddAdminUsername, 1, 0)
        Me.TableLayoutPanel37.Controls.Add(Me.cmbChooseRole, 1, 3)
        Me.TableLayoutPanel37.Controls.Add(Me.txtAddContact, 1, 2)
        Me.TableLayoutPanel37.Controls.Add(Me.txtAddAdminFullname, 1, 1)
        Me.TableLayoutPanel37.Controls.Add(Me.lblAddContact, 0, 2)
        Me.TableLayoutPanel37.Controls.Add(Me.lblAddRole, 0, 3)
        Me.TableLayoutPanel37.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel37.Location = New System.Drawing.Point(3, 58)
        Me.TableLayoutPanel37.Name = "TableLayoutPanel37"
        Me.TableLayoutPanel37.RowCount = 4
        Me.TableLayoutPanel37.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel37.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel37.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel37.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel37.Size = New System.Drawing.Size(418, 154)
        Me.TableLayoutPanel37.TabIndex = 7
        '
        'lblAddFirstname
        '
        Me.lblAddFirstname.AutoSize = True
        Me.lblAddFirstname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddFirstname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddFirstname.Location = New System.Drawing.Point(3, 0)
        Me.lblAddFirstname.Name = "lblAddFirstname"
        Me.lblAddFirstname.Size = New System.Drawing.Size(111, 37)
        Me.lblAddFirstname.TabIndex = 6
        Me.lblAddFirstname.Text = "Username:"
        Me.lblAddFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddLastname
        '
        Me.lblAddLastname.AutoSize = True
        Me.lblAddLastname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddLastname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddLastname.Location = New System.Drawing.Point(3, 37)
        Me.lblAddLastname.Name = "lblAddLastname"
        Me.lblAddLastname.Size = New System.Drawing.Size(111, 39)
        Me.lblAddLastname.TabIndex = 8
        Me.lblAddLastname.Text = "Full Name:"
        Me.lblAddLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddAdminUsername
        '
        Me.txtAddAdminUsername.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAddAdminUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddAdminUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddAdminUsername.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddAdminUsername.Location = New System.Drawing.Point(120, 5)
        Me.txtAddAdminUsername.Name = "txtAddAdminUsername"
        Me.txtAddAdminUsername.Size = New System.Drawing.Size(269, 27)
        Me.txtAddAdminUsername.TabIndex = 7
        '
        'cmbChooseRole
        '
        Me.cmbChooseRole.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbChooseRole.BackColor = System.Drawing.Color.White
        Me.cmbChooseRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChooseRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbChooseRole.FormattingEnabled = True
        Me.cmbChooseRole.Items.AddRange(New Object() {"Librarian", "Assistant Librarian", "Library Clerk"})
        Me.cmbChooseRole.Location = New System.Drawing.Point(120, 123)
        Me.cmbChooseRole.Name = "cmbChooseRole"
        Me.cmbChooseRole.Size = New System.Drawing.Size(210, 21)
        Me.cmbChooseRole.TabIndex = 16
        '
        'txtAddContact
        '
        Me.txtAddContact.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAddContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddContact.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddContact.Location = New System.Drawing.Point(120, 81)
        Me.txtAddContact.Name = "txtAddContact"
        Me.txtAddContact.Size = New System.Drawing.Size(269, 27)
        Me.txtAddContact.TabIndex = 11
        '
        'txtAddAdminFullname
        '
        Me.txtAddAdminFullname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAddAdminFullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAddAdminFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddAdminFullname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddAdminFullname.Location = New System.Drawing.Point(120, 43)
        Me.txtAddAdminFullname.Name = "txtAddAdminFullname"
        Me.txtAddAdminFullname.Size = New System.Drawing.Size(269, 27)
        Me.txtAddAdminFullname.TabIndex = 9
        '
        'lblAddContact
        '
        Me.lblAddContact.AutoSize = True
        Me.lblAddContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddContact.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddContact.Location = New System.Drawing.Point(3, 76)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(111, 38)
        Me.lblAddContact.TabIndex = 10
        Me.lblAddContact.Text = "Contact Info:"
        Me.lblAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddRole
        '
        Me.lblAddRole.AutoSize = True
        Me.lblAddRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAddRole.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddRole.Location = New System.Drawing.Point(3, 114)
        Me.lblAddRole.Name = "lblAddRole"
        Me.lblAddRole.Size = New System.Drawing.Size(111, 40)
        Me.lblAddRole.TabIndex = 12
        Me.lblAddRole.Text = "Role:"
        Me.lblAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel38
        '
        Me.TableLayoutPanel38.ColumnCount = 2
        Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel38.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel38.Controls.Add(Me.btnClear, 1, 0)
        Me.TableLayoutPanel38.Controls.Add(Me.btnAddAdmin, 0, 0)
        Me.TableLayoutPanel38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel38.Location = New System.Drawing.Point(3, 218)
        Me.TableLayoutPanel38.Name = "TableLayoutPanel38"
        Me.TableLayoutPanel38.RowCount = 1
        Me.TableLayoutPanel38.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel38.Size = New System.Drawing.Size(418, 48)
        Me.TableLayoutPanel38.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(212, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 27)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddAdmin.Location = New System.Drawing.Point(70, 3)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(136, 27)
        Me.btnAddAdmin.TabIndex = 14
        Me.btnAddAdmin.Text = "Add"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.LMSDataSet
        '
        'LMSDataSet
        '
        Me.LMSDataSet.DataSetName = "LMSDataSet"
        Me.LMSDataSet.Namespace = "http://tempuri.org/LMSDataSet.xsd"
        Me.LMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Notifications
        '
        Me.Notifications.BackColor = System.Drawing.Color.White
        Me.Notifications.ColumnCount = 1
        Me.Notifications.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75!))
        Me.Notifications.Controls.Add(Me.pnlNotifications, 0, 0)
        Me.Notifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notifications.Location = New System.Drawing.Point(238, 110)
        Me.Notifications.Name = "Notifications"
        Me.Notifications.RowCount = 1
        Me.Notifications.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Notifications.Size = New System.Drawing.Size(1132, 639)
        Me.Notifications.TabIndex = 16
        '
        'pnlNotifications
        '
        Me.pnlNotifications.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.pnlNotifications.BorderColor = System.Drawing.Color.DarkGreen
        Me.pnlNotifications.BorderWidth = 6
        Me.pnlNotifications.Controls.Add(Me.TableLayoutPanel42)
        Me.pnlNotifications.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNotifications.Location = New System.Drawing.Point(215, 57)
        Me.pnlNotifications.Name = "pnlNotifications"
        Me.pnlNotifications.Size = New System.Drawing.Size(701, 525)
        Me.pnlNotifications.TabIndex = 1
        '
        'TableLayoutPanel42
        '
        Me.TableLayoutPanel42.ColumnCount = 1
        Me.TableLayoutPanel42.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel42.Controls.Add(Me.lblNotifications, 0, 0)
        Me.TableLayoutPanel42.Controls.Add(Me.grpFiltersNotif, 0, 1)
        Me.TableLayoutPanel42.Controls.Add(Me.dgvNotifications, 0, 2)
        Me.TableLayoutPanel42.Controls.Add(Me.TableLayoutPanel43, 0, 3)
        Me.TableLayoutPanel42.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel42.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel42.Name = "TableLayoutPanel42"
        Me.TableLayoutPanel42.RowCount = 4
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 332.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel42.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel42.Size = New System.Drawing.Size(701, 525)
        Me.TableLayoutPanel42.TabIndex = 0
        '
        'lblNotifications
        '
        Me.lblNotifications.AutoSize = True
        Me.lblNotifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotifications.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotifications.ForeColor = System.Drawing.Color.White
        Me.lblNotifications.Location = New System.Drawing.Point(3, 0)
        Me.lblNotifications.Name = "lblNotifications"
        Me.lblNotifications.Size = New System.Drawing.Size(695, 61)
        Me.lblNotifications.TabIndex = 7
        Me.lblNotifications.Text = "Notifications"
        Me.lblNotifications.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grpFiltersNotif
        '
        Me.grpFiltersNotif.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpFiltersNotif.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltersNotif.Controls.Add(Me.cmbStatus)
        Me.grpFiltersNotif.Controls.Add(Me.btnApplyFilter)
        Me.grpFiltersNotif.Controls.Add(Me.cmbType)
        Me.grpFiltersNotif.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFiltersNotif.ForeColor = System.Drawing.Color.White
        Me.grpFiltersNotif.Location = New System.Drawing.Point(120, 69)
        Me.grpFiltersNotif.Name = "grpFiltersNotif"
        Me.grpFiltersNotif.Size = New System.Drawing.Size(461, 64)
        Me.grpFiltersNotif.TabIndex = 8
        Me.grpFiltersNotif.TabStop = False
        Me.grpFiltersNotif.Text = "Filter Notifications"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(183, 25)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(137, 26)
        Me.cmbStatus.TabIndex = 3
        '
        'btnApplyFilter
        '
        Me.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApplyFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnApplyFilter.Location = New System.Drawing.Point(340, 24)
        Me.btnApplyFilter.Name = "btnApplyFilter"
        Me.btnApplyFilter.Size = New System.Drawing.Size(90, 27)
        Me.btnApplyFilter.TabIndex = 2
        Me.btnApplyFilter.Text = "Apply"
        Me.btnApplyFilter.UseVisualStyleBackColor = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(31, 25)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(137, 26)
        Me.cmbType.TabIndex = 0
        '
        'dgvNotifications
        '
        Me.dgvNotifications.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvNotifications.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvNotifications.FullRowSelect = True
        Me.dgvNotifications.GridLines = True
        Me.dgvNotifications.HideSelection = False
        Me.dgvNotifications.Location = New System.Drawing.Point(48, 154)
        Me.dgvNotifications.MultiSelect = False
        Me.dgvNotifications.Name = "dgvNotifications"
        Me.dgvNotifications.Size = New System.Drawing.Size(604, 305)
        Me.dgvNotifications.TabIndex = 11
        Me.dgvNotifications.UseCompatibleStateImageBehavior = False
        Me.dgvNotifications.View = System.Windows.Forms.View.Details
        '
        'TableLayoutPanel43
        '
        Me.TableLayoutPanel43.ColumnCount = 2
        Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel43.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel43.Controls.Add(Me.btnDeleteNotification, 0, 0)
        Me.TableLayoutPanel43.Controls.Add(Me.btnMarkAsRead, 0, 0)
        Me.TableLayoutPanel43.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel43.Location = New System.Drawing.Point(3, 476)
        Me.TableLayoutPanel43.Name = "TableLayoutPanel43"
        Me.TableLayoutPanel43.RowCount = 1
        Me.TableLayoutPanel43.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel43.Size = New System.Drawing.Size(695, 46)
        Me.TableLayoutPanel43.TabIndex = 12
        '
        'btnDeleteNotification
        '
        Me.btnDeleteNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnDeleteNotification.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteNotification.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnDeleteNotification.Location = New System.Drawing.Point(350, 3)
        Me.btnDeleteNotification.Name = "btnDeleteNotification"
        Me.btnDeleteNotification.Size = New System.Drawing.Size(136, 27)
        Me.btnDeleteNotification.TabIndex = 11
        Me.btnDeleteNotification.Text = "Delete"
        Me.btnDeleteNotification.UseVisualStyleBackColor = False
        '
        'btnMarkAsRead
        '
        Me.btnMarkAsRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAsRead.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnMarkAsRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarkAsRead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnMarkAsRead.Location = New System.Drawing.Point(208, 3)
        Me.btnMarkAsRead.Name = "btnMarkAsRead"
        Me.btnMarkAsRead.Size = New System.Drawing.Size(136, 27)
        Me.btnMarkAsRead.TabIndex = 10
        Me.btnMarkAsRead.Text = "Mark as Read"
        Me.btnMarkAsRead.UseVisualStyleBackColor = False
        '
        'Statistics
        '
        Me.Statistics.BackColor = System.Drawing.Color.White
        Me.Statistics.ColumnCount = 1
        Me.Statistics.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02827!))
        Me.Statistics.Controls.Add(Me.StatsGeneral, 0, 0)
        Me.Statistics.Controls.Add(Me.OutlineRoundPanel1, 0, 2)
        Me.Statistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Statistics.Location = New System.Drawing.Point(238, 110)
        Me.Statistics.Name = "Statistics"
        Me.Statistics.RowCount = 3
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.35802!))
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.641975!))
        Me.Statistics.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 314.0!))
        Me.Statistics.Size = New System.Drawing.Size(1132, 639)
        Me.Statistics.TabIndex = 1
        '
        'StatsGeneral
        '
        Me.StatsGeneral.ColumnCount = 2
        Me.StatsGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.16874!))
        Me.StatsGeneral.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.83126!))
        Me.StatsGeneral.Controls.Add(Me.BookStats, 0, 0)
        Me.StatsGeneral.Controls.Add(Me.LogEntryStats, 0, 0)
        Me.StatsGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatsGeneral.Location = New System.Drawing.Point(3, 3)
        Me.StatsGeneral.Name = "StatsGeneral"
        Me.StatsGeneral.RowCount = 1
        Me.StatsGeneral.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.StatsGeneral.Size = New System.Drawing.Size(1126, 290)
        Me.StatsGeneral.TabIndex = 0
        '
        'BookStats
        '
        Me.BookStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.BookStats.BorderColor = System.Drawing.Color.Black
        Me.BookStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BookStats.BorderWidth = 6
        Me.BookStats.Controls.Add(Me.TableLayoutPanel5)
        Me.BookStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookStats.Location = New System.Drawing.Point(399, 3)
        Me.BookStats.Name = "BookStats"
        Me.BookStats.Size = New System.Drawing.Size(724, 284)
        Me.BookStats.TabIndex = 4
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24549!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.75451!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(722, 282)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(716, 45)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Library Books Statistics"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.140002!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.71999!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.140002!))
        Me.TableLayoutPanel6.Controls.Add(Me.CustomBarChart1, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 48)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(716, 231)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'CustomBarChart1
        '
        Me.CustomBarChart1.AxisColor = System.Drawing.Color.Black
        Me.CustomBarChart1.BackColor = System.Drawing.Color.White
        Me.CustomBarChart1.BarColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.CustomBarChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomBarChart1.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomBarChart1.Location = New System.Drawing.Point(25, 3)
        Me.CustomBarChart1.Name = "CustomBarChart1"
        Me.CustomBarChart1.Size = New System.Drawing.Size(665, 225)
        Me.CustomBarChart1.TabIndex = 1
        '
        'LogEntryStats
        '
        Me.LogEntryStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LogEntryStats.BorderColor = System.Drawing.Color.Black
        Me.LogEntryStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogEntryStats.BorderWidth = 6
        Me.LogEntryStats.Controls.Add(Me.TableLayoutPanel2)
        Me.LogEntryStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogEntryStats.Location = New System.Drawing.Point(3, 3)
        Me.LogEntryStats.Name = "LogEntryStats"
        Me.LogEntryStats.Size = New System.Drawing.Size(390, 284)
        Me.LogEntryStats.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lcLogEnrtries, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.62816!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.37184!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(388, 282)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(382, 102)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.rdoAnnual, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rdoWeekly, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rdoMonthly, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 52)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(376, 47)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'rdoAnnual
        '
        Me.rdoAnnual.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoAnnual.AutoSize = True
        Me.rdoAnnual.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoAnnual.ForeColor = System.Drawing.Color.White
        Me.rdoAnnual.Location = New System.Drawing.Point(277, 12)
        Me.rdoAnnual.Name = "rdoAnnual"
        Me.rdoAnnual.Size = New System.Drawing.Size(72, 23)
        Me.rdoAnnual.TabIndex = 6
        Me.rdoAnnual.Text = "Annual"
        Me.rdoAnnual.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Checked = True
        Me.rdoWeekly.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoWeekly.ForeColor = System.Drawing.Color.White
        Me.rdoWeekly.Location = New System.Drawing.Point(28, 12)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(69, 23)
        Me.rdoWeekly.TabIndex = 4
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoMonthly.ForeColor = System.Drawing.Color.White
        Me.rdoMonthly.Location = New System.Drawing.Point(149, 12)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(77, 23)
        Me.rdoMonthly.TabIndex = 5
        Me.rdoMonthly.Text = "Monthly"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Log Entry Statistics"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lcLogEnrtries
        '
        Me.lcLogEnrtries.AxisColor = System.Drawing.Color.Black
        Me.lcLogEnrtries.BackColor = System.Drawing.Color.White
        Me.lcLogEnrtries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lcLogEnrtries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lcLogEnrtries.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcLogEnrtries.ForeColor = System.Drawing.Color.White
        Me.lcLogEnrtries.LineColor = System.Drawing.Color.SeaGreen
        Me.lcLogEnrtries.Location = New System.Drawing.Point(4, 112)
        Me.lcLogEnrtries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lcLogEnrtries.Name = "lcLogEnrtries"
        Me.lcLogEnrtries.Size = New System.Drawing.Size(380, 166)
        Me.lcLogEnrtries.TabIndex = 0
        '
        'OutlineRoundPanel1
        '
        Me.OutlineRoundPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.OutlineRoundPanel1.BorderColor = System.Drawing.Color.Black
        Me.OutlineRoundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineRoundPanel1.BorderWidth = 6
        Me.OutlineRoundPanel1.Controls.Add(Me.TableLayoutPanel12)
        Me.OutlineRoundPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutlineRoundPanel1.Location = New System.Drawing.Point(3, 327)
        Me.OutlineRoundPanel1.Name = "OutlineRoundPanel1"
        Me.OutlineRoundPanel1.Size = New System.Drawing.Size(1126, 309)
        Me.OutlineRoundPanel1.TabIndex = 7
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel13, 0, 1)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24549!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.75451!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(1124, 307)
        Me.TableLayoutPanel12.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1118, 49)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Generate Books List"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 3
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.140002!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.71999!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.140002!))
        Me.TableLayoutPanel13.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 52)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(1118, 252)
        Me.TableLayoutPanel13.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(38, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 246)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.1268!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.8732!))
        Me.TableLayoutPanel14.Controls.Add(Me.TableLayoutPanel15, 0, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.TableLayoutPanel16, 1, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(1041, 246)
        Me.TableLayoutPanel14.TabIndex = 0
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 5
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel15.Controls.Add(Me.chkHighSchoolBooks, 3, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.chkComputerScienceBooks, 2, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.chkNonFictionBooks, 1, 2)
        Me.TableLayoutPanel15.Controls.Add(Me.chkTourismBooks, 3, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.chkFilipinianaBooks, 2, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.chkReferenceBooks, 1, 1)
        Me.TableLayoutPanel15.Controls.Add(Me.chkCriminologyBooks, 3, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.chkMagazines, 2, 0)
        Me.TableLayoutPanel15.Controls.Add(Me.chkGeneralCirculation, 1, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 3
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(494, 240)
        Me.TableLayoutPanel15.TabIndex = 1
        '
        'chkHighSchoolBooks
        '
        Me.chkHighSchoolBooks.AutoSize = True
        Me.chkHighSchoolBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkHighSchoolBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHighSchoolBooks.Location = New System.Drawing.Point(331, 163)
        Me.chkHighSchoolBooks.Name = "chkHighSchoolBooks"
        Me.chkHighSchoolBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkHighSchoolBooks.TabIndex = 13
        Me.chkHighSchoolBooks.Text = "High School Books"
        Me.chkHighSchoolBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkHighSchoolBooks.UseVisualStyleBackColor = True
        '
        'chkComputerScienceBooks
        '
        Me.chkComputerScienceBooks.AutoSize = True
        Me.chkComputerScienceBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkComputerScienceBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComputerScienceBooks.Location = New System.Drawing.Point(167, 163)
        Me.chkComputerScienceBooks.Name = "chkComputerScienceBooks"
        Me.chkComputerScienceBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkComputerScienceBooks.TabIndex = 12
        Me.chkComputerScienceBooks.Text = "Computer Science Books"
        Me.chkComputerScienceBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkComputerScienceBooks.UseVisualStyleBackColor = True
        '
        'chkNonFictionBooks
        '
        Me.chkNonFictionBooks.AutoSize = True
        Me.chkNonFictionBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkNonFictionBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonFictionBooks.Location = New System.Drawing.Point(3, 163)
        Me.chkNonFictionBooks.Name = "chkNonFictionBooks"
        Me.chkNonFictionBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkNonFictionBooks.TabIndex = 11
        Me.chkNonFictionBooks.Text = "Non-Fiction Books"
        Me.chkNonFictionBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkNonFictionBooks.UseVisualStyleBackColor = True
        '
        'chkTourismBooks
        '
        Me.chkTourismBooks.AutoSize = True
        Me.chkTourismBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkTourismBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTourismBooks.Location = New System.Drawing.Point(331, 83)
        Me.chkTourismBooks.Name = "chkTourismBooks"
        Me.chkTourismBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkTourismBooks.TabIndex = 8
        Me.chkTourismBooks.Text = "Tourism Books"
        Me.chkTourismBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTourismBooks.UseVisualStyleBackColor = True
        '
        'chkFilipinianaBooks
        '
        Me.chkFilipinianaBooks.AutoSize = True
        Me.chkFilipinianaBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkFilipinianaBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFilipinianaBooks.Location = New System.Drawing.Point(167, 83)
        Me.chkFilipinianaBooks.Name = "chkFilipinianaBooks"
        Me.chkFilipinianaBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkFilipinianaBooks.TabIndex = 7
        Me.chkFilipinianaBooks.Text = "Filipiniana Books"
        Me.chkFilipinianaBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFilipinianaBooks.UseVisualStyleBackColor = True
        '
        'chkReferenceBooks
        '
        Me.chkReferenceBooks.AutoSize = True
        Me.chkReferenceBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkReferenceBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReferenceBooks.Location = New System.Drawing.Point(3, 83)
        Me.chkReferenceBooks.Name = "chkReferenceBooks"
        Me.chkReferenceBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkReferenceBooks.TabIndex = 6
        Me.chkReferenceBooks.Text = "Reference Books"
        Me.chkReferenceBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkReferenceBooks.UseVisualStyleBackColor = True
        '
        'chkCriminologyBooks
        '
        Me.chkCriminologyBooks.AutoSize = True
        Me.chkCriminologyBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCriminologyBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCriminologyBooks.Location = New System.Drawing.Point(331, 3)
        Me.chkCriminologyBooks.Name = "chkCriminologyBooks"
        Me.chkCriminologyBooks.Size = New System.Drawing.Size(158, 74)
        Me.chkCriminologyBooks.TabIndex = 3
        Me.chkCriminologyBooks.Text = "Criminology Books"
        Me.chkCriminologyBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCriminologyBooks.UseVisualStyleBackColor = True
        '
        'chkMagazines
        '
        Me.chkMagazines.AutoSize = True
        Me.chkMagazines.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkMagazines.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMagazines.Location = New System.Drawing.Point(167, 3)
        Me.chkMagazines.Name = "chkMagazines"
        Me.chkMagazines.Size = New System.Drawing.Size(158, 74)
        Me.chkMagazines.TabIndex = 2
        Me.chkMagazines.Text = "Magazine"
        Me.chkMagazines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkMagazines.UseVisualStyleBackColor = True
        '
        'chkGeneralCirculation
        '
        Me.chkGeneralCirculation.AutoSize = True
        Me.chkGeneralCirculation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkGeneralCirculation.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGeneralCirculation.Location = New System.Drawing.Point(3, 3)
        Me.chkGeneralCirculation.Name = "chkGeneralCirculation"
        Me.chkGeneralCirculation.Size = New System.Drawing.Size(158, 74)
        Me.chkGeneralCirculation.TabIndex = 0
        Me.chkGeneralCirculation.Text = "General Circulation Books"
        Me.chkGeneralCirculation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkGeneralCirculation.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel17, 0, 1)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(503, 3)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(535, 240)
        Me.TableLayoutPanel16.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.LMS.My.Resources.Resources.pdf1
        Me.PictureBox1.Location = New System.Drawing.Point(226, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 2
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.btnGenerateAll, 0, 0)
        Me.TableLayoutPanel17.Controls.Add(Me.btnGenerateList, 0, 0)
        Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 171)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(529, 66)
        Me.TableLayoutPanel17.TabIndex = 0
        '
        'btnGenerateAll
        '
        Me.btnGenerateAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGenerateAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnGenerateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateAll.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnGenerateAll.Location = New System.Drawing.Point(320, 14)
        Me.btnGenerateAll.Name = "btnGenerateAll"
        Me.btnGenerateAll.Size = New System.Drawing.Size(153, 38)
        Me.btnGenerateAll.TabIndex = 22
        Me.btnGenerateAll.Text = "Generate All"
        Me.btnGenerateAll.UseVisualStyleBackColor = False
        '
        'btnGenerateList
        '
        Me.btnGenerateList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGenerateList.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnGenerateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateList.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnGenerateList.Location = New System.Drawing.Point(55, 14)
        Me.btnGenerateList.Name = "btnGenerateList"
        Me.btnGenerateList.Size = New System.Drawing.Size(153, 38)
        Me.btnGenerateList.TabIndex = 21
        Me.btnGenerateList.Text = "Generate"
        Me.btnGenerateList.UseVisualStyleBackColor = False
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'LMSDataSetBindingSource
        '
        Me.LMSDataSetBindingSource.DataSource = Me.LMSDataSet
        Me.LMSDataSetBindingSource.Position = 0
        '
        'Homepage
        '
        Me.Homepage.BackColor = System.Drawing.Color.White
        Me.Homepage.ColumnCount = 1
        Me.Homepage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Homepage.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.Homepage.Controls.Add(Me.RoundedPanel1, 0, 1)
        Me.Homepage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Homepage.Location = New System.Drawing.Point(238, 110)
        Me.Homepage.Name = "Homepage"
        Me.Homepage.RowCount = 2
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.Homepage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364.0!))
        Me.Homepage.Size = New System.Drawing.Size(1132, 639)
        Me.Homepage.TabIndex = 8
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.17584!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.82416!))
        Me.TableLayoutPanel7.Controls.Add(Me.QuickAccessOutline, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1126, 230)
        Me.TableLayoutPanel7.TabIndex = 0
        '
        'QuickAccessOutline
        '
        Me.QuickAccessOutline.BorderColor = System.Drawing.Color.Black
        Me.QuickAccessOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuickAccessOutline.BorderWidth = 6
        Me.QuickAccessOutline.Controls.Add(Me.GroupBox2)
        Me.QuickAccessOutline.Location = New System.Drawing.Point(871, 3)
        Me.QuickAccessOutline.Name = "QuickAccessOutline"
        Me.QuickAccessOutline.Size = New System.Drawing.Size(252, 222)
        Me.QuickAccessOutline.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel41)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 220)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quick Access"
        '
        'TableLayoutPanel41
        '
        Me.TableLayoutPanel41.ColumnCount = 1
        Me.TableLayoutPanel41.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel41.Controls.Add(Me.btnQuickReport, 0, 2)
        Me.TableLayoutPanel41.Controls.Add(Me.btnQuickLog, 0, 0)
        Me.TableLayoutPanel41.Controls.Add(Me.btnQuickBookAdd, 0, 1)
        Me.TableLayoutPanel41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel41.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel41.Name = "TableLayoutPanel41"
        Me.TableLayoutPanel41.RowCount = 3
        Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel41.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel41.Size = New System.Drawing.Size(244, 181)
        Me.TableLayoutPanel41.TabIndex = 0
        '
        'btnQuickReport
        '
        Me.btnQuickReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnQuickReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnQuickReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuickReport.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickReport.ForeColor = System.Drawing.Color.White
        Me.btnQuickReport.Location = New System.Drawing.Point(28, 123)
        Me.btnQuickReport.Name = "btnQuickReport"
        Me.btnQuickReport.Size = New System.Drawing.Size(188, 33)
        Me.btnQuickReport.TabIndex = 32
        Me.btnQuickReport.Text = "Generate All Books List"
        Me.btnQuickReport.UseVisualStyleBackColor = False
        '
        'btnQuickLog
        '
        Me.btnQuickLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuickLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnQuickLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuickLog.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickLog.ForeColor = System.Drawing.Color.White
        Me.btnQuickLog.Location = New System.Drawing.Point(28, 24)
        Me.btnQuickLog.Name = "btnQuickLog"
        Me.btnQuickLog.Size = New System.Drawing.Size(188, 33)
        Me.btnQuickLog.TabIndex = 30
        Me.btnQuickLog.Text = "Log Entry"
        Me.btnQuickLog.UseVisualStyleBackColor = False
        '
        'btnQuickBookAdd
        '
        Me.btnQuickBookAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnQuickBookAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnQuickBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuickBookAdd.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickBookAdd.ForeColor = System.Drawing.Color.White
        Me.btnQuickBookAdd.Location = New System.Drawing.Point(28, 73)
        Me.btnQuickBookAdd.Name = "btnQuickBookAdd"
        Me.btnQuickBookAdd.Size = New System.Drawing.Size(188, 33)
        Me.btnQuickBookAdd.TabIndex = 31
        Me.btnQuickBookAdd.Text = "Add Books"
        Me.btnQuickBookAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 224)
        Me.Panel2.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel40)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(860, 222)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Management Tools"
        '
        'TableLayoutPanel40
        '
        Me.TableLayoutPanel40.ColumnCount = 4
        Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel40.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel40.Controls.Add(Me.lblAccession, 0, 1)
        Me.TableLayoutPanel40.Controls.Add(Me.lblOPAC, 3, 1)
        Me.TableLayoutPanel40.Controls.Add(Me.lblEntryLogs, 2, 1)
        Me.TableLayoutPanel40.Controls.Add(Me.lblTransactions, 1, 1)
        Me.TableLayoutPanel40.Controls.Add(Me.btnTransactions, 1, 0)
        Me.TableLayoutPanel40.Controls.Add(Me.btnOPAC, 3, 0)
        Me.TableLayoutPanel40.Controls.Add(Me.btnBookMngmt, 0, 0)
        Me.TableLayoutPanel40.Controls.Add(Me.btnEntryLogs, 2, 0)
        Me.TableLayoutPanel40.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel40.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel40.Name = "TableLayoutPanel40"
        Me.TableLayoutPanel40.RowCount = 2
        Me.TableLayoutPanel40.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.31532!))
        Me.TableLayoutPanel40.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.68468!))
        Me.TableLayoutPanel40.Size = New System.Drawing.Size(854, 183)
        Me.TableLayoutPanel40.TabIndex = 1
        '
        'lblAccession
        '
        Me.lblAccession.AutoSize = True
        Me.lblAccession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccession.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccession.Location = New System.Drawing.Point(3, 119)
        Me.lblAccession.Name = "lblAccession"
        Me.lblAccession.Size = New System.Drawing.Size(207, 64)
        Me.lblAccession.TabIndex = 26
        Me.lblAccession.Text = "Accession Record"
        Me.lblAccession.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOPAC
        '
        Me.lblOPAC.AutoSize = True
        Me.lblOPAC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOPAC.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPAC.Location = New System.Drawing.Point(642, 119)
        Me.lblOPAC.Name = "lblOPAC"
        Me.lblOPAC.Size = New System.Drawing.Size(209, 64)
        Me.lblOPAC.TabIndex = 29
        Me.lblOPAC.Text = "Online Public Access " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Catalog " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(OPAC)"
        Me.lblOPAC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEntryLogs
        '
        Me.lblEntryLogs.AutoSize = True
        Me.lblEntryLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEntryLogs.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntryLogs.Location = New System.Drawing.Point(429, 119)
        Me.lblEntryLogs.Name = "lblEntryLogs"
        Me.lblEntryLogs.Size = New System.Drawing.Size(207, 64)
        Me.lblEntryLogs.TabIndex = 28
        Me.lblEntryLogs.Text = "Entry Logs"
        Me.lblEntryLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTransactions.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.Location = New System.Drawing.Point(216, 119)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(207, 64)
        Me.lblTransactions.TabIndex = 27
        Me.lblTransactions.Text = "Transactions"
        Me.lblTransactions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnTransactions
        '
        Me.btnTransactions.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTransactions.BackColor = System.Drawing.Color.ForestGreen
        Me.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransactions.Image = Global.LMS.My.Resources.Resources.circulation
        Me.btnTransactions.Location = New System.Drawing.Point(280, 27)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(79, 89)
        Me.btnTransactions.TabIndex = 23
        Me.btnTransactions.UseVisualStyleBackColor = False
        '
        'btnOPAC
        '
        Me.btnOPAC.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOPAC.BackColor = System.Drawing.Color.Teal
        Me.btnOPAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOPAC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOPAC.Image = Global.LMS.My.Resources.Resources.OPAC
        Me.btnOPAC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOPAC.Location = New System.Drawing.Point(707, 27)
        Me.btnOPAC.Name = "btnOPAC"
        Me.btnOPAC.Size = New System.Drawing.Size(79, 89)
        Me.btnOPAC.TabIndex = 25
        Me.btnOPAC.UseVisualStyleBackColor = False
        '
        'btnBookMngmt
        '
        Me.btnBookMngmt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBookMngmt.BackColor = System.Drawing.Color.Indigo
        Me.btnBookMngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookMngmt.Image = Global.LMS.My.Resources.Resources.book_management
        Me.btnBookMngmt.Location = New System.Drawing.Point(67, 27)
        Me.btnBookMngmt.Name = "btnBookMngmt"
        Me.btnBookMngmt.Size = New System.Drawing.Size(79, 89)
        Me.btnBookMngmt.TabIndex = 22
        Me.btnBookMngmt.UseVisualStyleBackColor = False
        '
        'btnEntryLogs
        '
        Me.btnEntryLogs.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntryLogs.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEntryLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntryLogs.Image = Global.LMS.My.Resources.Resources.Logbook
        Me.btnEntryLogs.Location = New System.Drawing.Point(493, 27)
        Me.btnEntryLogs.Name = "btnEntryLogs"
        Me.btnEntryLogs.Size = New System.Drawing.Size(79, 89)
        Me.btnEntryLogs.TabIndex = 24
        Me.btnEntryLogs.UseVisualStyleBackColor = False
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedPanel1.Controls.Add(Me.GroupBox1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoundedPanel1.Location = New System.Drawing.Point(3, 239)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(1126, 205)
        Me.RoundedPanel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1126, 205)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dashboard"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 5
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.RoundedPanel5, 4, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RoundedPanel4, 3, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RoundedPanel3, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.RoundedPanel2, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.displayTotalBooks, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lblTotalBook, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lblRecentLogs, 4, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lblReturned, 2, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lblOverdue, 3, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.lblBorrowed, 1, 1)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1120, 166)
        Me.TableLayoutPanel9.TabIndex = 0
        '
        'RoundedPanel5
        '
        Me.RoundedPanel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RoundedPanel5.BackColor = System.Drawing.Color.Gainsboro
        Me.RoundedPanel5.Controls.Add(Me.TableLayoutPanel39)
        Me.RoundedPanel5.Location = New System.Drawing.Point(950, 34)
        Me.RoundedPanel5.Name = "RoundedPanel5"
        Me.RoundedPanel5.Size = New System.Drawing.Size(115, 85)
        Me.RoundedPanel5.TabIndex = 22
        '
        'TableLayoutPanel39
        '
        Me.TableLayoutPanel39.ColumnCount = 3
        Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel39.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel39.Controls.Add(Me.lblTotalLogs, 1, 0)
        Me.TableLayoutPanel39.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel39.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel39.Name = "TableLayoutPanel39"
        Me.TableLayoutPanel39.RowCount = 1
        Me.TableLayoutPanel39.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel39.Size = New System.Drawing.Size(115, 85)
        Me.TableLayoutPanel39.TabIndex = 2
        '
        'lblTotalLogs
        '
        Me.lblTotalLogs.AutoSize = True
        Me.lblTotalLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalLogs.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLogs.ForeColor = System.Drawing.Color.Black
        Me.lblTotalLogs.Location = New System.Drawing.Point(23, 0)
        Me.lblTotalLogs.Name = "lblTotalLogs"
        Me.lblTotalLogs.Size = New System.Drawing.Size(69, 85)
        Me.lblTotalLogs.TabIndex = 0
        Me.lblTotalLogs.Text = "22"
        Me.lblTotalLogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedPanel4
        '
        Me.RoundedPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RoundedPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.RoundedPanel4.Controls.Add(Me.TableLayoutPanel23)
        Me.RoundedPanel4.Location = New System.Drawing.Point(726, 34)
        Me.RoundedPanel4.Name = "RoundedPanel4"
        Me.RoundedPanel4.Size = New System.Drawing.Size(115, 85)
        Me.RoundedPanel4.TabIndex = 22
        '
        'TableLayoutPanel23
        '
        Me.TableLayoutPanel23.ColumnCount = 3
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel23.Controls.Add(Me.lblTotalOverdue, 1, 0)
        Me.TableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel23.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel23.Name = "TableLayoutPanel23"
        Me.TableLayoutPanel23.RowCount = 1
        Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel23.Size = New System.Drawing.Size(115, 85)
        Me.TableLayoutPanel23.TabIndex = 2
        '
        'lblTotalOverdue
        '
        Me.lblTotalOverdue.AutoSize = True
        Me.lblTotalOverdue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalOverdue.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOverdue.ForeColor = System.Drawing.Color.Black
        Me.lblTotalOverdue.Location = New System.Drawing.Point(23, 0)
        Me.lblTotalOverdue.Name = "lblTotalOverdue"
        Me.lblTotalOverdue.Size = New System.Drawing.Size(69, 85)
        Me.lblTotalOverdue.TabIndex = 0
        Me.lblTotalOverdue.Text = "22"
        Me.lblTotalOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedPanel3
        '
        Me.RoundedPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RoundedPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.RoundedPanel3.Controls.Add(Me.TableLayoutPanel22)
        Me.RoundedPanel3.Location = New System.Drawing.Point(502, 34)
        Me.RoundedPanel3.Name = "RoundedPanel3"
        Me.RoundedPanel3.Size = New System.Drawing.Size(115, 85)
        Me.RoundedPanel3.TabIndex = 22
        '
        'TableLayoutPanel22
        '
        Me.TableLayoutPanel22.ColumnCount = 3
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel22.Controls.Add(Me.lblTotalReturned, 1, 0)
        Me.TableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel22.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel22.Name = "TableLayoutPanel22"
        Me.TableLayoutPanel22.RowCount = 1
        Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel22.Size = New System.Drawing.Size(115, 85)
        Me.TableLayoutPanel22.TabIndex = 2
        '
        'lblTotalReturned
        '
        Me.lblTotalReturned.AutoSize = True
        Me.lblTotalReturned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalReturned.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReturned.ForeColor = System.Drawing.Color.Black
        Me.lblTotalReturned.Location = New System.Drawing.Point(23, 0)
        Me.lblTotalReturned.Name = "lblTotalReturned"
        Me.lblTotalReturned.Size = New System.Drawing.Size(69, 85)
        Me.lblTotalReturned.TabIndex = 0
        Me.lblTotalReturned.Text = "22"
        Me.lblTotalReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RoundedPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.RoundedPanel2.Controls.Add(Me.TableLayoutPanel11)
        Me.RoundedPanel2.Location = New System.Drawing.Point(278, 34)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Size = New System.Drawing.Size(115, 85)
        Me.RoundedPanel2.TabIndex = 22
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 3
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.lblTotalBorrowed, 1, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(115, 85)
        Me.TableLayoutPanel11.TabIndex = 2
        '
        'lblTotalBorrowed
        '
        Me.lblTotalBorrowed.AutoSize = True
        Me.lblTotalBorrowed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalBorrowed.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBorrowed.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBorrowed.Location = New System.Drawing.Point(23, 0)
        Me.lblTotalBorrowed.Name = "lblTotalBorrowed"
        Me.lblTotalBorrowed.Size = New System.Drawing.Size(69, 85)
        Me.lblTotalBorrowed.TabIndex = 0
        Me.lblTotalBorrowed.Text = "22"
        Me.lblTotalBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayTotalBooks
        '
        Me.displayTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.displayTotalBooks.BackColor = System.Drawing.Color.Gainsboro
        Me.displayTotalBooks.Controls.Add(Me.TableLayoutPanel10)
        Me.displayTotalBooks.Location = New System.Drawing.Point(54, 34)
        Me.displayTotalBooks.Name = "displayTotalBooks"
        Me.displayTotalBooks.Size = New System.Drawing.Size(115, 85)
        Me.displayTotalBooks.TabIndex = 21
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 3
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.lblTotalBooks, 1, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(115, 85)
        Me.TableLayoutPanel10.TabIndex = 1
        '
        'lblTotalBooks
        '
        Me.lblTotalBooks.AutoSize = True
        Me.lblTotalBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalBooks.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBooks.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBooks.Location = New System.Drawing.Point(23, 0)
        Me.lblTotalBooks.Name = "lblTotalBooks"
        Me.lblTotalBooks.Size = New System.Drawing.Size(69, 85)
        Me.lblTotalBooks.TabIndex = 0
        Me.lblTotalBooks.Text = "22"
        Me.lblTotalBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBook
        '
        Me.lblTotalBook.AutoSize = True
        Me.lblTotalBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalBook.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBook.ForeColor = System.Drawing.Color.White
        Me.lblTotalBook.Location = New System.Drawing.Point(3, 122)
        Me.lblTotalBook.Name = "lblTotalBook"
        Me.lblTotalBook.Size = New System.Drawing.Size(218, 44)
        Me.lblTotalBook.TabIndex = 19
        Me.lblTotalBook.Text = "Total Books"
        Me.lblTotalBook.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRecentLogs
        '
        Me.lblRecentLogs.AutoSize = True
        Me.lblRecentLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRecentLogs.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecentLogs.ForeColor = System.Drawing.Color.White
        Me.lblRecentLogs.Location = New System.Drawing.Point(899, 122)
        Me.lblRecentLogs.Name = "lblRecentLogs"
        Me.lblRecentLogs.Size = New System.Drawing.Size(218, 44)
        Me.lblRecentLogs.TabIndex = 29
        Me.lblRecentLogs.Text = "Recent Log Entries"
        Me.lblRecentLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblReturned
        '
        Me.lblReturned.AutoSize = True
        Me.lblReturned.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturned.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturned.ForeColor = System.Drawing.Color.White
        Me.lblReturned.Location = New System.Drawing.Point(451, 122)
        Me.lblReturned.Name = "lblReturned"
        Me.lblReturned.Size = New System.Drawing.Size(218, 44)
        Me.lblReturned.TabIndex = 28
        Me.lblReturned.Text = "Books Returned"
        Me.lblReturned.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOverdue
        '
        Me.lblOverdue.AutoSize = True
        Me.lblOverdue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOverdue.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdue.ForeColor = System.Drawing.Color.White
        Me.lblOverdue.Location = New System.Drawing.Point(675, 122)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(218, 44)
        Me.lblOverdue.TabIndex = 27
        Me.lblOverdue.Text = "Overdue Books"
        Me.lblOverdue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBorrowed
        '
        Me.lblBorrowed.AutoSize = True
        Me.lblBorrowed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBorrowed.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowed.ForeColor = System.Drawing.Color.White
        Me.lblBorrowed.Location = New System.Drawing.Point(227, 122)
        Me.lblBorrowed.Name = "lblBorrowed"
        Me.lblBorrowed.Size = New System.Drawing.Size(218, 44)
        Me.lblBorrowed.TabIndex = 26
        Me.lblBorrowed.Text = "Books Borrowed"
        Me.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Homepage)
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.Statistics)
        Me.Controls.Add(Me.Notifications)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.Navigation)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = " Welcome to ESTI Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        Me.TableLayoutPanel44.ResumeLayout(False)
        CType(Me.picLMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picESTI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AboutPanel.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel6.ResumeLayout(False)
        Me.TableLayoutPanel45.ResumeLayout(False)
        Me.Navigation.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel19.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel20.ResumeLayout(False)
        Me.TableLayoutPanel21.ResumeLayout(False)
        Me.Settings.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel24.ResumeLayout(False)
        Me.ChangePW.ResumeLayout(False)
        Me.TableLayoutPanel26.ResumeLayout(False)
        Me.TableLayoutPanel26.PerformLayout()
        Me.TableLayoutPanel27.ResumeLayout(False)
        Me.TableLayoutPanel28.ResumeLayout(False)
        Me.TableLayoutPanel28.PerformLayout()
        Me.TableLayoutPanel29.ResumeLayout(False)
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel31.ResumeLayout(False)
        Me.TableLayoutPanel30.ResumeLayout(False)
        Me.TableLayoutPanel30.PerformLayout()
        Me.ProfileMngmt.ResumeLayout(False)
        Me.TableLayoutPanel32.ResumeLayout(False)
        Me.TableLayoutPanel32.PerformLayout()
        Me.TableLayoutPanel33.ResumeLayout(False)
        Me.TableLayoutPanel33.PerformLayout()
        Me.TableLayoutPanel34.ResumeLayout(False)
        Me.TableLayoutPanel34.PerformLayout()
        Me.TableLayoutPanel36.ResumeLayout(False)
        Me.TableLayoutPanel25.ResumeLayout(False)
        CType(Me.dgvAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddAdmin.ResumeLayout(False)
        Me.TableLayoutPanel35.ResumeLayout(False)
        Me.TableLayoutPanel35.PerformLayout()
        Me.TableLayoutPanel37.ResumeLayout(False)
        Me.TableLayoutPanel37.PerformLayout()
        Me.TableLayoutPanel38.ResumeLayout(False)
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Notifications.ResumeLayout(False)
        Me.pnlNotifications.ResumeLayout(False)
        Me.TableLayoutPanel42.ResumeLayout(False)
        Me.TableLayoutPanel42.PerformLayout()
        Me.grpFiltersNotif.ResumeLayout(False)
        Me.TableLayoutPanel43.ResumeLayout(False)
        Me.Statistics.ResumeLayout(False)
        Me.StatsGeneral.ResumeLayout(False)
        Me.BookStats.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.LogEntryStats.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.OutlineRoundPanel1.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel15.PerformLayout()
        Me.TableLayoutPanel16.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel17.ResumeLayout(False)
        CType(Me.LMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Homepage.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.QuickAccessOutline.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel41.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel40.ResumeLayout(False)
        Me.TableLayoutPanel40.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.RoundedPanel5.ResumeLayout(False)
        Me.TableLayoutPanel39.ResumeLayout(False)
        Me.TableLayoutPanel39.PerformLayout()
        Me.RoundedPanel4.ResumeLayout(False)
        Me.TableLayoutPanel23.ResumeLayout(False)
        Me.TableLayoutPanel23.PerformLayout()
        Me.RoundedPanel3.ResumeLayout(False)
        Me.TableLayoutPanel22.ResumeLayout(False)
        Me.TableLayoutPanel22.PerformLayout()
        Me.RoundedPanel2.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.displayTotalBooks.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents AboutPanel As TableLayoutPanel
    Friend WithEvents Navigation As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Settings As Panel
    Friend WithEvents Notifications As TableLayoutPanel
    Friend WithEvents Statistics As TableLayoutPanel
    Friend WithEvents StatsGeneral As TableLayoutPanel
    Friend WithEvents BookStats As OutlineRoundPanel
    Friend WithEvents chartStatistics As DataVisualization.Charting.Chart
    Friend WithEvents LogEntryStats As OutlineRoundPanel
    Friend WithEvents LMSDataSet As LMSDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As LMSDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents LMSDataSetBindingSource As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lcLogEnrtries As CustomLineChart
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents rdoAnnual As RadioButton
    Friend WithEvents rdoWeekly As RadioButton
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents CustomBarChart1 As CustomBarChart
    Friend WithEvents OutlineRoundPanel1 As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents btnGenerateAll As RoundedButton
    Friend WithEvents btnGenerateList As RoundedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkHighSchoolBooks As CheckBox
    Friend WithEvents chkComputerScienceBooks As CheckBox
    Friend WithEvents chkNonFictionBooks As CheckBox
    Friend WithEvents chkTourismBooks As CheckBox
    Friend WithEvents chkFilipinianaBooks As CheckBox
    Friend WithEvents chkReferenceBooks As CheckBox
    Friend WithEvents chkCriminologyBooks As CheckBox
    Friend WithEvents chkMagazines As CheckBox
    Friend WithEvents chkGeneralCirculation As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents lblRole As Label
    Friend WithEvents picProfile As RoundPictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents btnLogout As RoundedButton
    Friend WithEvents btnNotif As RoundedButton
    Friend WithEvents btnStatistics As RoundedButton
    Friend WithEvents btnSettings As RoundedButton
    Friend WithEvents btnHome As RoundedButton
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Homepage As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel24 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel25 As TableLayoutPanel
    Friend WithEvents ChangePW As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel26 As TableLayoutPanel
    Friend WithEvents lblChangePW As Label
    Friend WithEvents TableLayoutPanel27 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel28 As TableLayoutPanel
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents btnViewNew As RoundedButton
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents btnViewCurrent As RoundedButton
    Friend WithEvents txtCurrentPassword As RoundedTextbox
    Friend WithEvents txtNewPassword As RoundedTextbox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents TableLayoutPanel29 As TableLayoutPanel
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents TableLayoutPanel31 As TableLayoutPanel
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents TableLayoutPanel30 As TableLayoutPanel
    Friend WithEvents btnVerify As RoundedButton
    Friend WithEvents txtCode As RoundedTextbox
    Friend WithEvents btnViewConfirm As RoundedButton
    Friend WithEvents txtConfirmPassword As RoundedTextbox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents ProfileMngmt As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel32 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel33 As TableLayoutPanel
    Friend WithEvents txtUsername As RoundedTextbox
    Friend WithEvents lblProfilePicture As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents txtFullname As RoundedTextbox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As RoundedTextbox
    Friend WithEvents TableLayoutPanel34 As TableLayoutPanel
    Friend WithEvents lblFilePath As Label
    Friend WithEvents btnChoosePhoto As RoundedButton
    Friend WithEvents lblProfileMngmt As Label
    Friend WithEvents TableLayoutPanel36 As TableLayoutPanel
    Friend WithEvents btnResetProfile As RoundedButton
    Friend WithEvents btnSaveProfile As RoundedButton
    Friend WithEvents dgvAdmins As DataGridView
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents AddAdmin As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel35 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel37 As TableLayoutPanel
    Friend WithEvents lblAddFirstname As Label
    Friend WithEvents lblAddLastname As Label
    Friend WithEvents txtAddAdminUsername As RoundedTextbox
    Friend WithEvents cmbChooseRole As ComboBox
    Friend WithEvents txtAddContact As RoundedTextbox
    Friend WithEvents txtAddAdminFullname As RoundedTextbox
    Friend WithEvents lblAddContact As Label
    Friend WithEvents lblAddRole As Label
    Friend WithEvents TableLayoutPanel38 As TableLayoutPanel
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents btnAddAdmin As RoundedButton
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents RoundedPanel5 As RoundedPanel
    Friend WithEvents TableLayoutPanel39 As TableLayoutPanel
    Friend WithEvents lblTotalLogs As Label
    Friend WithEvents RoundedPanel4 As RoundedPanel
    Friend WithEvents TableLayoutPanel23 As TableLayoutPanel
    Friend WithEvents lblTotalOverdue As Label
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents TableLayoutPanel22 As TableLayoutPanel
    Friend WithEvents lblTotalReturned As Label
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents lblTotalBorrowed As Label
    Friend WithEvents displayTotalBooks As RoundedPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents lblTotalBooks As Label
    Friend WithEvents lblTotalBook As Label
    Friend WithEvents lblRecentLogs As Label
    Friend WithEvents lblReturned As Label
    Friend WithEvents lblOverdue As Label
    Friend WithEvents lblBorrowed As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents QuickAccessOutline As OutlineRoundPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableLayoutPanel40 As TableLayoutPanel
    Friend WithEvents lblAccession As Label
    Friend WithEvents btnOPAC As RoundedButton
    Friend WithEvents btnEntryLogs As RoundedButton
    Friend WithEvents lblOPAC As Label
    Friend WithEvents lblEntryLogs As Label
    Friend WithEvents lblTransactions As Label
    Friend WithEvents btnTransactions As RoundedButton
    Friend WithEvents btnBookMngmt As RoundedButton
    Friend WithEvents TableLayoutPanel41 As TableLayoutPanel
    Friend WithEvents btnQuickReport As RoundedButton
    Friend WithEvents btnQuickLog As RoundedButton
    Friend WithEvents btnQuickBookAdd As RoundedButton
    Friend WithEvents pnlNotifications As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel42 As TableLayoutPanel
    Friend WithEvents lblNotifications As Label
    Friend WithEvents grpFiltersNotif As GroupBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnApplyFilter As RoundedButton
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents dgvNotifications As ListView
    Friend WithEvents TableLayoutPanel43 As TableLayoutPanel
    Friend WithEvents btnDeleteNotification As RoundedButton
    Friend WithEvents btnMarkAsRead As RoundedButton
    Friend WithEvents TableLayoutPanel44 As TableLayoutPanel
    Friend WithEvents picLMS As PictureBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnAbout As RoundedButton
    Friend WithEvents picESTI As PictureBox
    Friend WithEvents RoundedPanel6 As RoundedPanel
    Friend WithEvents TableLayoutPanel45 As TableLayoutPanel
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

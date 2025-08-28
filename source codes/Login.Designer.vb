<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginTo = New System.Windows.Forms.Panel()
        Me.LoginAccess = New System.Windows.Forms.TableLayoutPanel()
        Me.LibraryAccess = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RoundedPanel1 = New LMS.RoundedPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbPurpose = New System.Windows.Forms.ComboBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblLogEntry = New System.Windows.Forms.Label()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New LMS.RoundedButton()
        Me.btnSave = New LMS.RoundedButton()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFirstname = New LMS.RoundedTextbox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtLastname = New LMS.RoundedTextbox()
        Me.txtMiddleInitial = New LMS.RoundedTextbox()
        Me.lblMiddleInitial = New System.Windows.Forms.Label()
        Me.AdminLogin = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LoginPanel = New LMS.RoundedPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogin = New LMS.RoundedButton()
        Me.btnCancel = New LMS.RoundedButton()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAdminUN = New LMS.RoundedTextbox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAdminPW = New LMS.RoundedTextbox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LoginTo.SuspendLayout()
        Me.LoginAccess.SuspendLayout()
        Me.LibraryAccess.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.AdminLogin.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.LoginPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginTo
        '
        Me.LoginTo.BackColor = System.Drawing.Color.White
        Me.LoginTo.Controls.Add(Me.LoginAccess)
        Me.LoginTo.Controls.Add(Me.Header)
        Me.LoginTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTo.Location = New System.Drawing.Point(0, 0)
        Me.LoginTo.Name = "LoginTo"
        Me.LoginTo.Size = New System.Drawing.Size(1370, 749)
        Me.LoginTo.TabIndex = 1
        '
        'LoginAccess
        '
        Me.LoginAccess.ColumnCount = 2
        Me.LoginAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoginAccess.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoginAccess.Controls.Add(Me.LibraryAccess, 0, 0)
        Me.LoginAccess.Controls.Add(Me.AdminLogin, 0, 0)
        Me.LoginAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginAccess.Location = New System.Drawing.Point(0, 110)
        Me.LoginAccess.Name = "LoginAccess"
        Me.LoginAccess.RowCount = 1
        Me.LoginAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LoginAccess.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 639.0!))
        Me.LoginAccess.Size = New System.Drawing.Size(1370, 639)
        Me.LoginAccess.TabIndex = 3
        '
        'LibraryAccess
        '
        Me.LibraryAccess.Controls.Add(Me.TableLayoutPanel7)
        Me.LibraryAccess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryAccess.Location = New System.Drawing.Point(688, 3)
        Me.LibraryAccess.Name = "LibraryAccess"
        Me.LibraryAccess.Size = New System.Drawing.Size(679, 633)
        Me.LibraryAccess.TabIndex = 15
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.RoundedPanel1, 1, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(679, 633)
        Me.TableLayoutPanel7.TabIndex = 1
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RoundedPanel1.Controls.Add(Me.TableLayoutPanel8)
        Me.RoundedPanel1.Location = New System.Drawing.Point(70, 118)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(537, 396)
        Me.RoundedPanel1.TabIndex = 15
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel9, 0, 5)
        Me.TableLayoutPanel8.Controls.Add(Me.lblLogEntry, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel12, 0, 4)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel13, 0, 6)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel11, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel10, 0, 3)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 8
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.3951!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.09061!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.99183!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.52544!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.47959!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9898!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.05102!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.14133!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(533, 392)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.18596!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.81404!))
        Me.TableLayoutPanel9.Controls.Add(Me.cmbPurpose, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lblPurpose, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 252)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(527, 41)
        Me.TableLayoutPanel9.TabIndex = 5
        '
        'cmbPurpose
        '
        Me.cmbPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPurpose.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurpose.FormattingEnabled = True
        Me.cmbPurpose.Location = New System.Drawing.Point(141, 7)
        Me.cmbPurpose.Name = "cmbPurpose"
        Me.cmbPurpose.Size = New System.Drawing.Size(186, 27)
        Me.cmbPurpose.TabIndex = 11
        '
        'lblPurpose
        '
        Me.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblPurpose.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.ForeColor = System.Drawing.Color.White
        Me.lblPurpose.Location = New System.Drawing.Point(50, 9)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(85, 23)
        Me.lblPurpose.TabIndex = 10
        Me.lblPurpose.Text = "Purpose:"
        '
        'lblLogEntry
        '
        Me.lblLogEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblLogEntry.AutoSize = True
        Me.lblLogEntry.BackColor = System.Drawing.Color.Transparent
        Me.lblLogEntry.Font = New System.Drawing.Font("Bahnschrift SemiBold", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogEntry.ForeColor = System.Drawing.Color.White
        Me.lblLogEntry.Location = New System.Drawing.Point(84, 33)
        Me.lblLogEntry.Name = "lblLogEntry"
        Me.lblLogEntry.Size = New System.Drawing.Size(364, 63)
        Me.lblLogEntry.TabIndex = 1
        Me.lblLogEntry.Text = "Library Access Record"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37571!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.62429!))
        Me.TableLayoutPanel12.Controls.Add(Me.lblRole, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.cmbRole, 1, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 207)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(527, 39)
        Me.TableLayoutPanel12.TabIndex = 6
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(83, 8)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(52, 23)
        Me.lblRole.TabIndex = 9
        Me.lblRole.Text = "Role:"
        '
        'cmbRole
        '
        Me.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(141, 6)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(186, 27)
        Me.cmbRole.TabIndex = 10
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 2
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.btnClear, 1, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 299)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(527, 53)
        Me.TableLayoutPanel13.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(266, 9)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 34)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(133, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70588!))
        Me.TableLayoutPanel11.Controls.Add(Me.txtFirstname, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.lblFirstname, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 99)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(527, 47)
        Me.TableLayoutPanel11.TabIndex = 2
        '
        'txtFirstname
        '
        Me.txtFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.Location = New System.Drawing.Point(134, 8)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(366, 30)
        Me.txtFirstname.TabIndex = 12
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstname
        '
        Me.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.ForeColor = System.Drawing.Color.White
        Me.lblFirstname.Location = New System.Drawing.Point(20, 12)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(108, 23)
        Me.lblFirstname.TabIndex = 11
        Me.lblFirstname.Text = "First Name:"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.lblLastname, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txtLastname, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txtMiddleInitial, 3, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lblMiddleInitial, 2, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 154)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(527, 47)
        Me.TableLayoutPanel10.TabIndex = 8
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.White
        Me.lblLastname.Location = New System.Drawing.Point(23, 12)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(105, 23)
        Me.lblLastname.TabIndex = 11
        Me.lblLastname.Text = "Last Name:"
        '
        'txtLastname
        '
        Me.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.Location = New System.Drawing.Point(134, 8)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(216, 30)
        Me.txtLastname.TabIndex = 13
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMiddleInitial.BackColor = System.Drawing.Color.White
        Me.txtMiddleInitial.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleInitial.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleInitial.Location = New System.Drawing.Point(416, 8)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(84, 30)
        Me.txtMiddleInitial.TabIndex = 10
        Me.txtMiddleInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleInitial.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleInitial.ForeColor = System.Drawing.Color.White
        Me.lblMiddleInitial.Location = New System.Drawing.Point(363, 12)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(47, 23)
        Me.lblMiddleInitial.TabIndex = 12
        Me.lblMiddleInitial.Text = "M. I.:"
        '
        'AdminLogin
        '
        Me.AdminLogin.Controls.Add(Me.TableLayoutPanel1)
        Me.AdminLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminLogin.Location = New System.Drawing.Point(3, 3)
        Me.AdminLogin.Name = "AdminLogin"
        Me.AdminLogin.Size = New System.Drawing.Size(679, 633)
        Me.AdminLogin.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LoginPanel, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(679, 633)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LoginPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.LoginPanel.Location = New System.Drawing.Point(70, 118)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(537, 396)
        Me.LoginPanel.TabIndex = 15
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblLogin, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.54321!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.66169!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.1791!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94527!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.03101!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.02067!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(533, 392)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnLogin, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 248)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(527, 81)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(133, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(127, 37)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(266, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 37)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(186, 60)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(160, 64)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.Text = "LOGIN"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.56546!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.43453!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtAdminUN, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblUsername, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 127)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(527, 45)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txtAdminUN
        '
        Me.txtAdminUN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAdminUN.BackColor = System.Drawing.Color.White
        Me.txtAdminUN.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminUN.ForeColor = System.Drawing.Color.Black
        Me.txtAdminUN.Location = New System.Drawing.Point(142, 7)
        Me.txtAdminUN.Name = "txtAdminUN"
        Me.txtAdminUN.Size = New System.Drawing.Size(325, 30)
        Me.txtAdminUN.TabIndex = 3
        Me.txtAdminUN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(35, 11)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(101, 23)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.18596!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.81404!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtAdminPW, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblPassword, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 178)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(527, 33)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'txtAdminPW
        '
        Me.txtAdminPW.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAdminPW.BackColor = System.Drawing.Color.White
        Me.txtAdminPW.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPW.ForeColor = System.Drawing.Color.Black
        Me.txtAdminPW.Location = New System.Drawing.Point(141, 3)
        Me.txtAdminPW.Name = "txtAdminPW"
        Me.txtAdminPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtAdminPW.Size = New System.Drawing.Size(325, 30)
        Me.txtAdminPW.TabIndex = 4
        Me.txtAdminPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(36, 5)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(99, 23)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37571!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.62429!))
        Me.TableLayoutPanel5.Controls.Add(Me.chkShowPassword, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 217)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(527, 25)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.White
        Me.chkShowPassword.Location = New System.Drawing.Point(141, 3)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(109, 19)
        Me.chkShowPassword.TabIndex = 12
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Header.Controls.Add(Me.PictureBox3)
        Me.Header.Controls.Add(Me.PictureBox2)
        Me.Header.Controls.Add(Me.PictureBox1)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1370, 110)
        Me.Header.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(309, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(283, 78)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(111, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 78)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LoginTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "ESTI Library Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.LoginTo.ResumeLayout(False)
        Me.LoginAccess.ResumeLayout(False)
        Me.LibraryAccess.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.RoundedPanel1.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.AdminLogin.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.LoginPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginTo As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginAccess As TableLayoutPanel
    Friend WithEvents LibraryAccess As Panel
    Friend WithEvents AdminLogin As Panel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents lblLogEntry As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LoginPanel As RoundedPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnLogin As RoundedButton
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents lblLogin As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtAdminUN As RoundedTextbox
    Friend WithEvents lblUsername As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtAdminPW As RoundedTextbox
    Friend WithEvents lblPassword As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents cmbPurpose As ComboBox
    Friend WithEvents lblPurpose As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtFirstname As RoundedTextbox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents lblLastname As Label
    Friend WithEvents txtLastname As RoundedTextbox
    Friend WithEvents txtMiddleInitial As RoundedTextbox
    Friend WithEvents lblMiddleInitial As Label
End Class

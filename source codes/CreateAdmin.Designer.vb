<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.AddAdmin = New LMS.OutlineRoundPanel()
        Me.lblPasswordStrength = New System.Windows.Forms.Label()
        Me.chkShowPW = New System.Windows.Forms.CheckBox()
        Me.txtSetPassword = New LMS.RoundedTextbox()
        Me.btnClear = New LMS.RoundedButton()
        Me.txtUsername = New LMS.RoundedTextbox()
        Me.txtFullname = New LMS.RoundedTextbox()
        Me.txtContact = New LMS.RoundedTextbox()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.lblAdminMngmt = New System.Windows.Forms.Label()
        Me.lblAddFirstname = New System.Windows.Forms.Label()
        Me.lblAddLastname = New System.Windows.Forms.Label()
        Me.lblAddContact = New System.Windows.Forms.Label()
        Me.lblAddRole = New System.Windows.Forms.Label()
        Me.lblSetPassword = New System.Windows.Forms.Label()
        Me.btnAddAdmin = New LMS.RoundedButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddAdmin
        '
        Me.AddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.AddAdmin.BorderColor = System.Drawing.Color.Black
        Me.AddAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddAdmin.BorderWidth = 6
        Me.AddAdmin.Controls.Add(Me.lblPasswordStrength)
        Me.AddAdmin.Controls.Add(Me.chkShowPW)
        Me.AddAdmin.Controls.Add(Me.txtSetPassword)
        Me.AddAdmin.Controls.Add(Me.btnClear)
        Me.AddAdmin.Controls.Add(Me.txtUsername)
        Me.AddAdmin.Controls.Add(Me.txtFullname)
        Me.AddAdmin.Controls.Add(Me.txtContact)
        Me.AddAdmin.Controls.Add(Me.cmbRole)
        Me.AddAdmin.Controls.Add(Me.lblAdminMngmt)
        Me.AddAdmin.Controls.Add(Me.lblAddFirstname)
        Me.AddAdmin.Controls.Add(Me.lblAddLastname)
        Me.AddAdmin.Controls.Add(Me.lblAddContact)
        Me.AddAdmin.Controls.Add(Me.lblAddRole)
        Me.AddAdmin.Controls.Add(Me.lblSetPassword)
        Me.AddAdmin.Controls.Add(Me.btnAddAdmin)
        Me.AddAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddAdmin.Location = New System.Drawing.Point(0, 0)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(479, 328)
        Me.AddAdmin.TabIndex = 8
        '
        'lblPasswordStrength
        '
        Me.lblPasswordStrength.AutoSize = True
        Me.lblPasswordStrength.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStrength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblPasswordStrength.Location = New System.Drawing.Point(347, 241)
        Me.lblPasswordStrength.Name = "lblPasswordStrength"
        Me.lblPasswordStrength.Size = New System.Drawing.Size(52, 16)
        Me.lblPasswordStrength.TabIndex = 32
        Me.lblPasswordStrength.Text = "Strength"
        Me.lblPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkShowPW
        '
        Me.chkShowPW.AutoSize = True
        Me.chkShowPW.ForeColor = System.Drawing.Color.White
        Me.chkShowPW.Location = New System.Drawing.Point(152, 241)
        Me.chkShowPW.Name = "chkShowPW"
        Me.chkShowPW.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPW.TabIndex = 29
        Me.chkShowPW.Text = "Show Password"
        Me.chkShowPW.UseVisualStyleBackColor = True
        '
        'txtSetPassword
        '
        Me.txtSetPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtSetPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSetPassword.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetPassword.Location = New System.Drawing.Point(149, 212)
        Me.txtSetPassword.Name = "txtSetPassword"
        Me.txtSetPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSetPassword.Size = New System.Drawing.Size(269, 27)
        Me.txtSetPassword.TabIndex = 28
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(247, 276)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 27)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(148, 76)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(269, 27)
        Me.txtUsername.TabIndex = 7
        '
        'txtFullname
        '
        Me.txtFullname.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullname.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullname.Location = New System.Drawing.Point(148, 110)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(269, 27)
        Me.txtFullname.TabIndex = 9
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(148, 144)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(269, 27)
        Me.txtContact.TabIndex = 11
        '
        'cmbRole
        '
        Me.cmbRole.BackColor = System.Drawing.Color.White
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Enabled = False
        Me.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRole.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Items.AddRange(New Object() {"Librarian", "Assistant Librarian", "Library Clerk"})
        Me.cmbRole.Location = New System.Drawing.Point(152, 181)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(210, 24)
        Me.cmbRole.TabIndex = 16
        '
        'lblAdminMngmt
        '
        Me.lblAdminMngmt.AutoSize = True
        Me.lblAdminMngmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblAdminMngmt.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminMngmt.ForeColor = System.Drawing.Color.White
        Me.lblAdminMngmt.Location = New System.Drawing.Point(152, 23)
        Me.lblAdminMngmt.Name = "lblAdminMngmt"
        Me.lblAdminMngmt.Size = New System.Drawing.Size(169, 27)
        Me.lblAdminMngmt.TabIndex = 5
        Me.lblAdminMngmt.Text = "Create New Admin"
        '
        'lblAddFirstname
        '
        Me.lblAddFirstname.AutoSize = True
        Me.lblAddFirstname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddFirstname.Location = New System.Drawing.Point(65, 79)
        Me.lblAddFirstname.Name = "lblAddFirstname"
        Me.lblAddFirstname.Size = New System.Drawing.Size(76, 19)
        Me.lblAddFirstname.TabIndex = 6
        Me.lblAddFirstname.Text = "Username:"
        Me.lblAddFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddLastname
        '
        Me.lblAddLastname.AutoSize = True
        Me.lblAddLastname.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddLastname.Location = New System.Drawing.Point(66, 114)
        Me.lblAddLastname.Name = "lblAddLastname"
        Me.lblAddLastname.Size = New System.Drawing.Size(75, 19)
        Me.lblAddLastname.TabIndex = 8
        Me.lblAddLastname.Text = "Full Name:"
        Me.lblAddLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddContact
        '
        Me.lblAddContact.AutoSize = True
        Me.lblAddContact.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddContact.Location = New System.Drawing.Point(52, 150)
        Me.lblAddContact.Name = "lblAddContact"
        Me.lblAddContact.Size = New System.Drawing.Size(88, 19)
        Me.lblAddContact.TabIndex = 10
        Me.lblAddContact.Text = "Contact Info:"
        Me.lblAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddRole
        '
        Me.lblAddRole.AutoSize = True
        Me.lblAddRole.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAddRole.Location = New System.Drawing.Point(101, 185)
        Me.lblAddRole.Name = "lblAddRole"
        Me.lblAddRole.Size = New System.Drawing.Size(39, 19)
        Me.lblAddRole.TabIndex = 12
        Me.lblAddRole.Text = "Role:"
        Me.lblAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSetPassword
        '
        Me.lblSetPassword.AutoSize = True
        Me.lblSetPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblSetPassword.Location = New System.Drawing.Point(43, 218)
        Me.lblSetPassword.Name = "lblSetPassword"
        Me.lblSetPassword.Size = New System.Drawing.Size(98, 19)
        Me.lblSetPassword.TabIndex = 27
        Me.lblSetPassword.Text = "Set Password:"
        Me.lblSetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddAdmin
        '
        Me.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAdmin.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddAdmin.Location = New System.Drawing.Point(91, 276)
        Me.btnAddAdmin.Name = "btnAddAdmin"
        Me.btnAddAdmin.Size = New System.Drawing.Size(136, 27)
        Me.btnAddAdmin.TabIndex = 14
        Me.btnAddAdmin.Text = "Add"
        Me.btnAddAdmin.UseVisualStyleBackColor = False
        '
        'CreateAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 328)
        Me.Controls.Add(Me.AddAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAdmin"
        Me.AddAdmin.ResumeLayout(False)
        Me.AddAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddAdmin As OutlineRoundPanel
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents txtUsername As RoundedTextbox
    Friend WithEvents txtFullname As RoundedTextbox
    Friend WithEvents txtContact As RoundedTextbox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblAdminMngmt As Label
    Friend WithEvents lblAddFirstname As Label
    Friend WithEvents lblAddLastname As Label
    Friend WithEvents lblAddContact As Label
    Friend WithEvents lblAddRole As Label
    Friend WithEvents btnAddAdmin As RoundedButton
    Friend WithEvents txtSetPassword As RoundedTextbox
    Friend WithEvents lblSetPassword As Label
    Friend WithEvents chkShowPW As CheckBox
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

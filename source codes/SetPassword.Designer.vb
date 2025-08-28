<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetPassword
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
        Me.txtSetPassword = New LMS.RoundedTextbox()
        Me.chkShowPW = New System.Windows.Forms.CheckBox()
        Me.lblSetPassword = New System.Windows.Forms.Label()
        Me.btnSavePW = New LMS.RoundedButton()
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
        Me.AddAdmin.Controls.Add(Me.txtSetPassword)
        Me.AddAdmin.Controls.Add(Me.chkShowPW)
        Me.AddAdmin.Controls.Add(Me.lblSetPassword)
        Me.AddAdmin.Controls.Add(Me.btnSavePW)
        Me.AddAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddAdmin.Location = New System.Drawing.Point(0, 0)
        Me.AddAdmin.Name = "AddAdmin"
        Me.AddAdmin.Size = New System.Drawing.Size(441, 139)
        Me.AddAdmin.TabIndex = 9
        '
        'lblPasswordStrength
        '
        Me.lblPasswordStrength.AutoSize = True
        Me.lblPasswordStrength.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordStrength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblPasswordStrength.Location = New System.Drawing.Point(331, 62)
        Me.lblPasswordStrength.Name = "lblPasswordStrength"
        Me.lblPasswordStrength.Size = New System.Drawing.Size(52, 16)
        Me.lblPasswordStrength.TabIndex = 31
        Me.lblPasswordStrength.Text = "Strength"
        Me.lblPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSetPassword
        '
        Me.txtSetPassword.BackColor = System.Drawing.Color.White
        Me.txtSetPassword.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSetPassword.ForeColor = System.Drawing.Color.Black
        Me.txtSetPassword.Location = New System.Drawing.Point(129, 29)
        Me.txtSetPassword.Name = "txtSetPassword"
        Me.txtSetPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtSetPassword.Size = New System.Drawing.Size(274, 30)
        Me.txtSetPassword.TabIndex = 30
        '
        'chkShowPW
        '
        Me.chkShowPW.AutoSize = True
        Me.chkShowPW.ForeColor = System.Drawing.Color.White
        Me.chkShowPW.Location = New System.Drawing.Point(138, 64)
        Me.chkShowPW.Name = "chkShowPW"
        Me.chkShowPW.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPW.TabIndex = 29
        Me.chkShowPW.Text = "Show Password"
        Me.chkShowPW.UseVisualStyleBackColor = True
        '
        'lblSetPassword
        '
        Me.lblSetPassword.AutoSize = True
        Me.lblSetPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblSetPassword.Location = New System.Drawing.Point(29, 34)
        Me.lblSetPassword.Name = "lblSetPassword"
        Me.lblSetPassword.Size = New System.Drawing.Size(98, 19)
        Me.lblSetPassword.TabIndex = 27
        Me.lblSetPassword.Text = "Set Password:"
        Me.lblSetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSavePW
        '
        Me.btnSavePW.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSavePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePW.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSavePW.Location = New System.Drawing.Point(151, 89)
        Me.btnSavePW.Name = "btnSavePW"
        Me.btnSavePW.Size = New System.Drawing.Size(136, 27)
        Me.btnSavePW.TabIndex = 14
        Me.btnSavePW.Text = "Save"
        Me.btnSavePW.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Password Requirement"
        '
        'SetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 139)
        Me.Controls.Add(Me.AddAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetPassword"
        Me.AddAdmin.ResumeLayout(False)
        Me.AddAdmin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddAdmin As OutlineRoundPanel
    Friend WithEvents chkShowPW As CheckBox
    Friend WithEvents txtSetPassword As RoundedTextbox
    Friend WithEvents lblSetPassword As Label
    Friend WithEvents btnSavePW As RoundedButton
    Friend WithEvents txtAdminPW As RoundedTextbox
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class

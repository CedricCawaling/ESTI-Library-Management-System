<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterPassword
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
        Me.OutlineRoundPanel1 = New LMS.OutlineRoundPanel()
        Me.txtPassword = New LMS.RoundedTextbox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblSetPassword = New System.Windows.Forms.Label()
        Me.btnEnter = New LMS.RoundedButton()
        Me.OutlineRoundPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OutlineRoundPanel1
        '
        Me.OutlineRoundPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.OutlineRoundPanel1.BorderColor = System.Drawing.Color.Black
        Me.OutlineRoundPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineRoundPanel1.BorderWidth = 6
        Me.OutlineRoundPanel1.Controls.Add(Me.txtPassword)
        Me.OutlineRoundPanel1.Controls.Add(Me.chkShowPassword)
        Me.OutlineRoundPanel1.Controls.Add(Me.lblSetPassword)
        Me.OutlineRoundPanel1.Controls.Add(Me.btnEnter)
        Me.OutlineRoundPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutlineRoundPanel1.Location = New System.Drawing.Point(0, 0)
        Me.OutlineRoundPanel1.Name = "OutlineRoundPanel1"
        Me.OutlineRoundPanel1.Size = New System.Drawing.Size(354, 185)
        Me.OutlineRoundPanel1.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(54, 68)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(247, 26)
        Me.txtPassword.TabIndex = 30
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.ForeColor = System.Drawing.Color.White
        Me.chkShowPassword.Location = New System.Drawing.Point(129, 103)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPassword.TabIndex = 29
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'lblSetPassword
        '
        Me.lblSetPassword.AutoSize = True
        Me.lblSetPassword.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblSetPassword.Location = New System.Drawing.Point(41, 25)
        Me.lblSetPassword.Name = "lblSetPassword"
        Me.lblSetPassword.Size = New System.Drawing.Size(279, 25)
        Me.lblSetPassword.TabIndex = 27
        Me.lblSetPassword.Text = "Enter your password to continue"
        Me.lblSetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnEnter.Location = New System.Drawing.Point(107, 126)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(136, 27)
        Me.btnEnter.TabIndex = 14
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'EnterPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 185)
        Me.Controls.Add(Me.OutlineRoundPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EnterPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Password"
        Me.OutlineRoundPanel1.ResumeLayout(False)
        Me.OutlineRoundPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutlineRoundPanel1 As OutlineRoundPanel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblSetPassword As Label
    Friend WithEvents btnEnter As RoundedButton
    Friend WithEvents txtPassword As RoundedTextbox
End Class

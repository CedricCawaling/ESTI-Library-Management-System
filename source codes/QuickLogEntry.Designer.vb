<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickLogEntry
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
        Me.RoundedPanel1 = New LMS.RoundedPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbPurpose = New System.Windows.Forms.ComboBox()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblLogEntry = New System.Windows.Forms.Label()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFirstname = New LMS.RoundedTextbox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New LMS.RoundedButton()
        Me.btnSave = New LMS.RoundedButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtLastname = New LMS.RoundedTextbox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblMiddleInitial = New System.Windows.Forms.Label()
        Me.txtMiddleInitial = New LMS.RoundedTextbox()
        Me.RoundedPanel1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RoundedPanel1.Controls.Add(Me.TableLayoutPanel8)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(577, 426)
        Me.RoundedPanel1.TabIndex = 16
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
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(573, 422)
        Me.TableLayoutPanel8.TabIndex = 13
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74956!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25044!))
        Me.TableLayoutPanel9.Controls.Add(Me.cmbPurpose, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.lblPurpose, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 270)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(567, 44)
        Me.TableLayoutPanel9.TabIndex = 5
        '
        'cmbPurpose
        '
        Me.cmbPurpose.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPurpose.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurpose.FormattingEnabled = True
        Me.cmbPurpose.Location = New System.Drawing.Point(149, 8)
        Me.cmbPurpose.Name = "cmbPurpose"
        Me.cmbPurpose.Size = New System.Drawing.Size(219, 27)
        Me.cmbPurpose.TabIndex = 11
        '
        'lblPurpose
        '
        Me.lblPurpose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.BackColor = System.Drawing.Color.Transparent
        Me.lblPurpose.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.ForeColor = System.Drawing.Color.White
        Me.lblPurpose.Location = New System.Drawing.Point(58, 10)
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
        Me.lblLogEntry.Location = New System.Drawing.Point(104, 35)
        Me.lblLogEntry.Name = "lblLogEntry"
        Me.lblLogEntry.Size = New System.Drawing.Size(364, 68)
        Me.lblLogEntry.TabIndex = 1
        Me.lblLogEntry.Text = "Library Access Record"
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74956!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25044!))
        Me.TableLayoutPanel11.Controls.Add(Me.txtFirstname, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.lblFirstname, 0, 0)
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 106)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(567, 51)
        Me.TableLayoutPanel11.TabIndex = 2
        '
        'txtFirstname
        '
        Me.txtFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.Location = New System.Drawing.Point(149, 10)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(363, 30)
        Me.txtFirstname.TabIndex = 10
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFirstname
        '
        Me.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.ForeColor = System.Drawing.Color.White
        Me.lblFirstname.Location = New System.Drawing.Point(35, 14)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(108, 23)
        Me.lblFirstname.TabIndex = 8
        Me.lblFirstname.Text = "First Name:"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.74956!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.25044!))
        Me.TableLayoutPanel12.Controls.Add(Me.lblRole, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.cmbRole, 1, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 222)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 1
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(567, 42)
        Me.TableLayoutPanel12.TabIndex = 6
        '
        'lblRole
        '
        Me.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblRole.AutoSize = True
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(91, 9)
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
        Me.cmbRole.Location = New System.Drawing.Point(149, 7)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(218, 27)
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
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 320)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(567, 57)
        Me.TableLayoutPanel13.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(286, 11)
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
        Me.btnSave.Location = New System.Drawing.Point(153, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 4
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.78202!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.21798!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.txtLastname, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lblLastname, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.lblMiddleInitial, 2, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txtMiddleInitial, 3, 0)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 165)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(567, 51)
        Me.TableLayoutPanel10.TabIndex = 8
        '
        'txtLastname
        '
        Me.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.Location = New System.Drawing.Point(149, 10)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(215, 30)
        Me.txtLastname.TabIndex = 9
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.ForeColor = System.Drawing.Color.White
        Me.lblLastname.Location = New System.Drawing.Point(38, 14)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(105, 23)
        Me.lblLastname.TabIndex = 7
        Me.lblLastname.Text = "Last Name:"
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleInitial.Font = New System.Drawing.Font("Bahnschrift", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleInitial.ForeColor = System.Drawing.Color.White
        Me.lblMiddleInitial.Location = New System.Drawing.Point(375, 14)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(47, 23)
        Me.lblMiddleInitial.TabIndex = 8
        Me.lblMiddleInitial.Text = "M. I.:"
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMiddleInitial.BackColor = System.Drawing.Color.White
        Me.txtMiddleInitial.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleInitial.ForeColor = System.Drawing.Color.Black
        Me.txtMiddleInitial.Location = New System.Drawing.Point(428, 10)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(84, 30)
        Me.txtMiddleInitial.TabIndex = 3
        Me.txtMiddleInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuickLogEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 426)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QuickLogEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Entry"
        Me.RoundedPanel1.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents cmbPurpose As ComboBox
    Friend WithEvents lblPurpose As Label
    Friend WithEvents lblLogEntry As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents txtFirstname As RoundedTextbox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents lblRole As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents txtLastname As RoundedTextbox
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblMiddleInitial As Label
    Friend WithEvents txtMiddleInitial As RoundedTextbox
End Class

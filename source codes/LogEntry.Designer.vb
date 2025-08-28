<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogEntry))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogEntryLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.LibraryLogEntries = New LMS.RoundedPanel()
        Me.Layout1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvLogEntries = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblLogEntries = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.dptFrom = New System.Windows.Forms.DateTimePicker()
        Me.dptTo = New System.Windows.Forms.DateTimePicker()
        Me.btnExport = New LMS.RoundedButton()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogEntryLayout.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.LibraryLogEntries.SuspendLayout()
        Me.Layout1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.SuspendLayout()
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
        'LogEntryLayout
        '
        Me.LogEntryLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LogEntryLayout.BackColor = System.Drawing.Color.White
        Me.LogEntryLayout.ColumnCount = 3
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LogEntryLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.LogEntryLayout.Controls.Add(Me.HolderPanel, 1, 1)
        Me.LogEntryLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogEntryLayout.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogEntryLayout.Location = New System.Drawing.Point(0, 110)
        Me.LogEntryLayout.Name = "LogEntryLayout"
        Me.LogEntryLayout.RowCount = 3
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LogEntryLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.LogEntryLayout.Size = New System.Drawing.Size(1370, 639)
        Me.LogEntryLayout.TabIndex = 3
        '
        'HolderPanel
        '
        Me.HolderPanel.Controls.Add(Me.LibraryLogEntries)
        Me.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolderPanel.Location = New System.Drawing.Point(3, 3)
        Me.HolderPanel.Name = "HolderPanel"
        Me.HolderPanel.Size = New System.Drawing.Size(1364, 633)
        Me.HolderPanel.TabIndex = 0
        '
        'LibraryLogEntries
        '
        Me.LibraryLogEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.LibraryLogEntries.Controls.Add(Me.Layout1)
        Me.LibraryLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibraryLogEntries.Location = New System.Drawing.Point(0, 0)
        Me.LibraryLogEntries.Name = "LibraryLogEntries"
        Me.LibraryLogEntries.Size = New System.Drawing.Size(1364, 633)
        Me.LibraryLogEntries.TabIndex = 25
        '
        'Layout1
        '
        Me.Layout1.ColumnCount = 1
        Me.Layout1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Layout1.Controls.Add(Me.Panel2, 0, 1)
        Me.Layout1.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.Layout1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Layout1.Location = New System.Drawing.Point(0, 0)
        Me.Layout1.Name = "Layout1"
        Me.Layout1.RowCount = 2
        Me.Layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.22433!))
        Me.Layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.77567!))
        Me.Layout1.Size = New System.Drawing.Size(1364, 633)
        Me.Layout1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1358, 461)
        Me.Panel2.TabIndex = 22
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1358, 461)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvLogEntries)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(43, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1272, 425)
        Me.Panel3.TabIndex = 22
        '
        'dgvLogEntries
        '
        Me.dgvLogEntries.AllowUserToAddRows = False
        Me.dgvLogEntries.AllowUserToDeleteRows = False
        Me.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogEntries.Location = New System.Drawing.Point(0, 0)
        Me.dgvLogEntries.Name = "dgvLogEntries"
        Me.dgvLogEntries.ReadOnly = True
        Me.dgvLogEntries.Size = New System.Drawing.Size(1272, 425)
        Me.dgvLogEntries.TabIndex = 19
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBack, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogEntries, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExport, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1358, 160)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Image = Global.LMS.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(1307, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 39)
        Me.btnBack.TabIndex = 18
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblLogEntries
        '
        Me.lblLogEntries.AutoSize = True
        Me.lblLogEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblLogEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogEntries.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogEntries.ForeColor = System.Drawing.Color.White
        Me.lblLogEntries.Location = New System.Drawing.Point(103, 0)
        Me.lblLogEntries.Name = "lblLogEntries"
        Me.lblLogEntries.Size = New System.Drawing.Size(1152, 65)
        Me.lblLogEntries.TabIndex = 30
        Me.lblLogEntries.Text = "Library Log Entries"
        Me.lblLogEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.grpFilter, 1, 0)
        Me.TableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(103, 98)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1152, 59)
        Me.TableLayoutPanel3.TabIndex = 26
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.grpFilter.Controls.Add(Me.lblDateFrom)
        Me.grpFilter.Controls.Add(Me.lblTo)
        Me.grpFilter.Controls.Add(Me.dptFrom)
        Me.grpFilter.Controls.Add(Me.dptTo)
        Me.grpFilter.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.ForeColor = System.Drawing.Color.White
        Me.grpFilter.Location = New System.Drawing.Point(253, 3)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(646, 48)
        Me.grpFilter.TabIndex = 22
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Filter"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(46, 20)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(75, 18)
        Me.lblDateFrom.TabIndex = 0
        Me.lblDateFrom.Text = "Date from"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(364, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(21, 18)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "to"
        '
        'dptFrom
        '
        Me.dptFrom.Location = New System.Drawing.Point(122, 16)
        Me.dptFrom.Name = "dptFrom"
        Me.dptFrom.Size = New System.Drawing.Size(236, 26)
        Me.dptFrom.TabIndex = 2
        Me.dptFrom.Value = New Date(2025, 5, 31, 0, 0, 0, 0)
        '
        'dptTo
        '
        Me.dptTo.Location = New System.Drawing.Point(391, 16)
        Me.dptTo.Name = "dptTo"
        Me.dptTo.Size = New System.Drawing.Size(236, 26)
        Me.dptTo.TabIndex = 4
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Image = Global.LMS.My.Resources.Resources.Export
        Me.btnExport.Location = New System.Drawing.Point(1261, 116)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(48, 41)
        Me.btnExport.TabIndex = 31
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'LogEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LogEntryLayout)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LogEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Log Entries"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogEntryLayout.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.LibraryLogEntries.ResumeLayout(False)
        Me.Layout1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvLogEntries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogEntryLayout As TableLayoutPanel
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents LibraryLogEntries As RoundedPanel
    Friend WithEvents Layout1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvLogEntries As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblLogEntries As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents dptFrom As DateTimePicker
    Friend WithEvents dptTo As DateTimePicker
    Friend WithEvents btnExport As RoundedButton
End Class

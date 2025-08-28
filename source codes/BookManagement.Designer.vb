<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookManagement))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AccessionRecords = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.Accession = New LMS.RoundedPanel()
        Me.Layout1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.LMSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddBooks = New LMS.RoundedButton()
        Me.grpFilter = New System.Windows.Forms.GroupBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New LMS.RoundedTextbox()
        Me.btnSearch = New LMS.RoundedButton()
        Me.btnBack = New LMS.RoundedButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccessionRecords.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.Accession.SuspendLayout()
        Me.Layout1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpFilter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.Header.TabIndex = 1
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
        'AccessionRecords
        '
        Me.AccessionRecords.BackColor = System.Drawing.Color.White
        Me.AccessionRecords.ColumnCount = 1
        Me.AccessionRecords.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.AccessionRecords.Controls.Add(Me.HolderPanel, 0, 0)
        Me.AccessionRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessionRecords.Location = New System.Drawing.Point(0, 110)
        Me.AccessionRecords.Name = "AccessionRecords"
        Me.AccessionRecords.RowCount = 1
        Me.AccessionRecords.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.AccessionRecords.Size = New System.Drawing.Size(1370, 639)
        Me.AccessionRecords.TabIndex = 2
        '
        'HolderPanel
        '
        Me.HolderPanel.Controls.Add(Me.Accession)
        Me.HolderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HolderPanel.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HolderPanel.Location = New System.Drawing.Point(3, 3)
        Me.HolderPanel.Name = "HolderPanel"
        Me.HolderPanel.Size = New System.Drawing.Size(1364, 633)
        Me.HolderPanel.TabIndex = 2
        '
        'Accession
        '
        Me.Accession.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Accession.Controls.Add(Me.Layout1)
        Me.Accession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Accession.Location = New System.Drawing.Point(0, 0)
        Me.Accession.Name = "Accession"
        Me.Accession.Size = New System.Drawing.Size(1364, 633)
        Me.Accession.TabIndex = 26
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
        Me.Layout1.TabIndex = 19
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
        Me.Panel3.Controls.Add(Me.dgvBooks)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(43, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1272, 425)
        Me.Panel3.TabIndex = 22
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.DataSource = Me.LMSDataSetBindingSource
        Me.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBooks.Location = New System.Drawing.Point(0, 0)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.Size = New System.Drawing.Size(1272, 425)
        Me.dgvBooks.TabIndex = 22
        '
        'LMSDataSetBindingSource
        '
        Me.LMSDataSetBindingSource.DataSource = GetType(LMS.LMSDataSet)
        Me.LMSDataSetBindingSource.Position = 0
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.LMSDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(103, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1152, 65)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Accession Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.19896!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.80104!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.grpFilter, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAddBooks, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(103, 68)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1152, 62)
        Me.TableLayoutPanel3.TabIndex = 26
        '
        'btnAddBooks
        '
        Me.btnAddBooks.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAddBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBooks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddBooks.Location = New System.Drawing.Point(132, 12)
        Me.btnAddBooks.Name = "btnAddBooks"
        Me.btnAddBooks.Size = New System.Drawing.Size(109, 32)
        Me.btnAddBooks.TabIndex = 38
        Me.btnAddBooks.Text = "Add Books+"
        Me.btnAddBooks.UseVisualStyleBackColor = False
        '
        'grpFilter
        '
        Me.grpFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.grpFilter.Controls.Add(Me.btnSearch)
        Me.grpFilter.Controls.Add(Me.txtSearch)
        Me.grpFilter.Controls.Add(Me.cmbFilter)
        Me.grpFilter.Controls.Add(Me.lblFilter)
        Me.grpFilter.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFilter.ForeColor = System.Drawing.Color.White
        Me.grpFilter.Location = New System.Drawing.Point(247, 3)
        Me.grpFilter.Name = "grpFilter"
        Me.grpFilter.Size = New System.Drawing.Size(742, 50)
        Me.grpFilter.TabIndex = 37
        Me.grpFilter.TabStop = False
        Me.grpFilter.Text = "Search"
        '
        'lblFilter
        '
        Me.lblFilter.Location = New System.Drawing.Point(60, 18)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(43, 18)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filter"
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"General Circulation Books"})
        Me.cmbFilter.Location = New System.Drawing.Point(107, 15)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFilter.Size = New System.Drawing.Size(203, 26)
        Me.cmbFilter.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(316, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(343, 26)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(661, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.AutoSize = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Image = Global.LMS.My.Resources.Resources.back
        Me.btnBack.Location = New System.Drawing.Point(1316, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(39, 41)
        Me.btnBack.TabIndex = 29
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBack, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1358, 160)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'BookManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.AccessionRecords)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accession Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccessionRecords.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.Accession.ResumeLayout(False)
        Me.Layout1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.grpFilter.ResumeLayout(False)
        Me.grpFilter.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AccessionRecords As TableLayoutPanel
    Friend WithEvents LMSDataSetBindingSource As BindingSource
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents Accession As RoundedPanel
    Friend WithEvents Layout1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents txtSearch As RoundedTextbox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents btnAddBooks As RoundedButton
    Friend WithEvents Label1 As Label
End Class

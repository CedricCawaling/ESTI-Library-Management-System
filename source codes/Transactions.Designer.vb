<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions))
        Me.Header = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransactionsLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HolderPanel = New System.Windows.Forms.Panel()
        Me.Accession = New LMS.RoundedPanel()
        Me.Layout1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExportToExcel = New LMS.RoundedButton()
        Me.btnBack = New LMS.RoundedButton()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New LMS.RoundedButton()
        Me.txtSearch = New LMS.RoundedTextbox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.Header.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionsLayout.SuspendLayout()
        Me.HolderPanel.SuspendLayout()
        Me.Accession.SuspendLayout()
        Me.Layout1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpSearch.SuspendLayout()
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
        'TransactionsLayout
        '
        Me.TransactionsLayout.BackColor = System.Drawing.Color.White
        Me.TransactionsLayout.ColumnCount = 1
        Me.TransactionsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TransactionsLayout.Controls.Add(Me.HolderPanel, 0, 0)
        Me.TransactionsLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsLayout.Location = New System.Drawing.Point(0, 110)
        Me.TransactionsLayout.Name = "TransactionsLayout"
        Me.TransactionsLayout.RowCount = 1
        Me.TransactionsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.291874!))
        Me.TransactionsLayout.Size = New System.Drawing.Size(1370, 639)
        Me.TransactionsLayout.TabIndex = 4
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
        Me.Layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.74724!))
        Me.Layout1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.25276!))
        Me.Layout1.Size = New System.Drawing.Size(1364, 633)
        Me.Layout1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1358, 502)
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
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1358, 502)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvTransactions)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(43, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1272, 477)
        Me.Panel3.TabIndex = 22
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransactions.Location = New System.Drawing.Point(0, 0)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.Size = New System.Drawing.Size(1272, 477)
        Me.dgvTransactions.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnExportToExcel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBack, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTransactions, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpSearch, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1358, 119)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportToExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportToExcel.Image = Global.LMS.My.Resources.Resources.Export
        Me.btnExportToExcel.Location = New System.Drawing.Point(1261, 74)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(39, 34)
        Me.btnExportToExcel.TabIndex = 34
        Me.btnExportToExcel.UseVisualStyleBackColor = False
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
        Me.btnBack.Size = New System.Drawing.Size(39, 34)
        Me.btnBack.TabIndex = 29
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTransactions.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.ForeColor = System.Drawing.Color.White
        Me.lblTransactions.Location = New System.Drawing.Point(103, 0)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(1152, 57)
        Me.lblTransactions.TabIndex = 30
        Me.lblTransactions.Text = "Transactions"
        Me.lblTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'grpSearch
        '
        Me.grpSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.cmbFilter)
        Me.grpSearch.Controls.Add(Me.lblFilter)
        Me.grpSearch.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.ForeColor = System.Drawing.Color.White
        Me.grpSearch.Location = New System.Drawing.Point(373, 62)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(611, 44)
        Me.grpSearch.TabIndex = 31
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(518, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(219, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(284, 26)
        Me.txtSearch.TabIndex = 2
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"All", "Borrowed", "Returned", "Overdue"})
        Me.cmbFilter.Location = New System.Drawing.Point(100, 13)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbFilter.Size = New System.Drawing.Size(113, 26)
        Me.cmbFilter.TabIndex = 1
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(53, 16)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(43, 18)
        Me.lblFilter.TabIndex = 0
        Me.lblFilter.Text = "Filter"
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TransactionsLayout)
        Me.Controls.Add(Me.Header)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Header.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionsLayout.ResumeLayout(False)
        Me.HolderPanel.ResumeLayout(False)
        Me.Accession.ResumeLayout(False)
        Me.Layout1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Header As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TransactionsLayout As TableLayoutPanel
    Friend WithEvents HolderPanel As Panel
    Friend WithEvents Accession As RoundedPanel
    Friend WithEvents Layout1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBack As RoundedButton
    Friend WithEvents lblTransactions As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents txtSearch As RoundedTextbox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents btnExportToExcel As RoundedButton
End Class

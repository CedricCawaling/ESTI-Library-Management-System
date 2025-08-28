<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccession
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
        Me.lblRemarks = New LMS.OutlineRoundPanel()
        Me.lblCostPrice = New System.Windows.Forms.Label()
        Me.txtCostPrice = New LMS.RoundedTextbox()
        Me.txtBookID = New LMS.RoundedTextbox()
        Me.txtTitle = New LMS.RoundedTextbox()
        Me.pickDateRecieved = New System.Windows.Forms.DateTimePicker()
        Me.txtAuthor = New LMS.RoundedTextbox()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.txtEdition = New LMS.RoundedTextbox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.updownPages = New System.Windows.Forms.NumericUpDown()
        Me.updownVolume = New System.Windows.Forms.NumericUpDown()
        Me.txtPublisher = New LMS.RoundedTextbox()
        Me.txtRemarks = New LMS.RoundedTextbox()
        Me.picThumbnail = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblPages = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.lblEdition = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDateRecieved = New System.Windows.Forms.Label()
        Me.lblBookID = New System.Windows.Forms.Label()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnCancel = New LMS.RoundedButton()
        Me.btnChoosePhoto = New LMS.RoundedButton()
        Me.btnAddBook = New LMS.RoundedButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRemarks.SuspendLayout()
        CType(Me.updownPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updownVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRemarks
        '
        Me.lblRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblRemarks.BorderColor = System.Drawing.Color.Black
        Me.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemarks.BorderWidth = 6
        Me.lblRemarks.Controls.Add(Me.lblCostPrice)
        Me.lblRemarks.Controls.Add(Me.txtCostPrice)
        Me.lblRemarks.Controls.Add(Me.txtBookID)
        Me.lblRemarks.Controls.Add(Me.txtTitle)
        Me.lblRemarks.Controls.Add(Me.pickDateRecieved)
        Me.lblRemarks.Controls.Add(Me.txtAuthor)
        Me.lblRemarks.Controls.Add(Me.cmbMaterial)
        Me.lblRemarks.Controls.Add(Me.txtEdition)
        Me.lblRemarks.Controls.Add(Me.cmbYear)
        Me.lblRemarks.Controls.Add(Me.updownPages)
        Me.lblRemarks.Controls.Add(Me.updownVolume)
        Me.lblRemarks.Controls.Add(Me.txtPublisher)
        Me.lblRemarks.Controls.Add(Me.txtRemarks)
        Me.lblRemarks.Controls.Add(Me.picThumbnail)
        Me.lblRemarks.Controls.Add(Me.Label2)
        Me.lblRemarks.Controls.Add(Me.lblYear)
        Me.lblRemarks.Controls.Add(Me.lblPublisher)
        Me.lblRemarks.Controls.Add(Me.lblPages)
        Me.lblRemarks.Controls.Add(Me.lblVolume)
        Me.lblRemarks.Controls.Add(Me.lblEdition)
        Me.lblRemarks.Controls.Add(Me.lblMaterial)
        Me.lblRemarks.Controls.Add(Me.lblAuthor)
        Me.lblRemarks.Controls.Add(Me.lblTitle)
        Me.lblRemarks.Controls.Add(Me.lblDateRecieved)
        Me.lblRemarks.Controls.Add(Me.lblBookID)
        Me.lblRemarks.Controls.Add(Me.lblFilePath)
        Me.lblRemarks.Controls.Add(Me.btnCancel)
        Me.lblRemarks.Controls.Add(Me.btnChoosePhoto)
        Me.lblRemarks.Controls.Add(Me.btnAddBook)
        Me.lblRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRemarks.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblRemarks.Location = New System.Drawing.Point(0, 0)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(926, 514)
        Me.lblRemarks.TabIndex = 9
        '
        'lblCostPrice
        '
        Me.lblCostPrice.AutoSize = True
        Me.lblCostPrice.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblCostPrice.Location = New System.Drawing.Point(784, 339)
        Me.lblCostPrice.Name = "lblCostPrice"
        Me.lblCostPrice.Size = New System.Drawing.Size(72, 19)
        Me.lblCostPrice.TabIndex = 53
        Me.lblCostPrice.Text = "Cost Price"
        Me.lblCostPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostPrice
        '
        Me.txtCostPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPrice.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtCostPrice.Location = New System.Drawing.Point(766, 310)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(114, 26)
        Me.txtCostPrice.TabIndex = 52
        '
        'txtBookID
        '
        Me.txtBookID.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookID.Enabled = False
        Me.txtBookID.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtBookID.Location = New System.Drawing.Point(603, 139)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.ReadOnly = True
        Me.txtBookID.Size = New System.Drawing.Size(77, 26)
        Me.txtBookID.TabIndex = 51
        Me.txtBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtTitle.Location = New System.Drawing.Point(151, 53)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(530, 72)
        Me.txtTitle.TabIndex = 7
        '
        'pickDateRecieved
        '
        Me.pickDateRecieved.Checked = False
        Me.pickDateRecieved.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.pickDateRecieved.Location = New System.Drawing.Point(154, 141)
        Me.pickDateRecieved.Name = "pickDateRecieved"
        Me.pickDateRecieved.Size = New System.Drawing.Size(246, 26)
        Me.pickDateRecieved.TabIndex = 30
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtAuthor.Location = New System.Drawing.Point(151, 183)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(530, 26)
        Me.txtAuthor.TabIndex = 9
        '
        'cmbMaterial
        '
        Me.cmbMaterial.BackColor = System.Drawing.Color.White
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMaterial.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(154, 229)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(197, 26)
        Me.cmbMaterial.TabIndex = 16
        '
        'txtEdition
        '
        Me.txtEdition.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtEdition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEdition.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtEdition.Location = New System.Drawing.Point(476, 226)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(205, 26)
        Me.txtEdition.TabIndex = 34
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.White
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(383, 272)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(77, 26)
        Me.cmbYear.TabIndex = 42
        '
        'updownPages
        '
        Me.updownPages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.updownPages.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.updownPages.Location = New System.Drawing.Point(622, 272)
        Me.updownPages.Name = "updownPages"
        Me.updownPages.Size = New System.Drawing.Size(54, 22)
        Me.updownPages.TabIndex = 38
        '
        'updownVolume
        '
        Me.updownVolume.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.updownVolume.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.updownVolume.Location = New System.Drawing.Point(154, 273)
        Me.updownVolume.Name = "updownVolume"
        Me.updownVolume.Size = New System.Drawing.Size(54, 22)
        Me.updownVolume.TabIndex = 36
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPublisher.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtPublisher.Location = New System.Drawing.Point(151, 314)
        Me.txtPublisher.Multiline = True
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(530, 44)
        Me.txtPublisher.TabIndex = 40
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!)
        Me.txtRemarks.Location = New System.Drawing.Point(151, 372)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(530, 99)
        Me.txtRemarks.TabIndex = 44
        '
        'picThumbnail
        '
        Me.picThumbnail.BackColor = System.Drawing.Color.White
        Me.picThumbnail.Location = New System.Drawing.Point(748, 56)
        Me.picThumbnail.Name = "picThumbnail"
        Me.picThumbnail.Size = New System.Drawing.Size(148, 171)
        Me.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThumbnail.TabIndex = 46
        Me.picThumbnail.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(75, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Remarks:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblYear.Location = New System.Drawing.Point(339, 274)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 19)
        Me.lblYear.TabIndex = 43
        Me.lblYear.Text = "Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblPublisher.Location = New System.Drawing.Point(72, 316)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(71, 19)
        Me.lblPublisher.TabIndex = 41
        Me.lblPublisher.Text = "Publisher:"
        Me.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPages
        '
        Me.lblPages.AutoSize = True
        Me.lblPages.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblPages.Location = New System.Drawing.Point(567, 274)
        Me.lblPages.Name = "lblPages"
        Me.lblPages.Size = New System.Drawing.Size(50, 19)
        Me.lblPages.TabIndex = 39
        Me.lblPages.Text = "Pages:"
        Me.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblVolume.Location = New System.Drawing.Point(87, 274)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(57, 19)
        Me.lblVolume.TabIndex = 37
        Me.lblVolume.Text = "Volume:"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEdition
        '
        Me.lblEdition.AutoSize = True
        Me.lblEdition.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblEdition.Location = New System.Drawing.Point(416, 231)
        Me.lblEdition.Name = "lblEdition"
        Me.lblEdition.Size = New System.Drawing.Size(56, 19)
        Me.lblEdition.TabIndex = 35
        Me.lblEdition.Text = "Edition:"
        Me.lblEdition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblMaterial.Location = New System.Drawing.Point(48, 231)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(97, 19)
        Me.lblMaterial.TabIndex = 33
        Me.lblMaterial.Text = "Material Type:"
        Me.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblAuthor.Location = New System.Drawing.Point(91, 190)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(54, 19)
        Me.lblAuthor.TabIndex = 32
        Me.lblAuthor.Text = "Author:"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(72, 57)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(73, 19)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Book Title:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDateRecieved
        '
        Me.lblDateRecieved.AutoSize = True
        Me.lblDateRecieved.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRecieved.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblDateRecieved.Location = New System.Drawing.Point(45, 142)
        Me.lblDateRecieved.Name = "lblDateRecieved"
        Me.lblDateRecieved.Size = New System.Drawing.Size(101, 19)
        Me.lblDateRecieved.TabIndex = 27
        Me.lblDateRecieved.Text = "Date Recieved:"
        Me.lblDateRecieved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblBookID.Location = New System.Drawing.Point(541, 144)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(59, 19)
        Me.lblBookID.TabIndex = 50
        Me.lblBookID.Text = "Book ID:"
        Me.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Bahnschrift Light SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.lblFilePath.Location = New System.Drawing.Point(748, 274)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(95, 16)
        Me.lblFilePath.TabIndex = 48
        Me.lblFilePath.Text = "*Image Location*"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(755, 428)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 37)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoosePhoto.Location = New System.Drawing.Point(748, 235)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(148, 27)
        Me.btnChoosePhoto.TabIndex = 47
        Me.btnChoosePhoto.Text = "Choose Photo"
        Me.btnChoosePhoto.UseVisualStyleBackColor = True
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAddBook.Location = New System.Drawing.Point(755, 378)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(136, 38)
        Me.btnAddBook.TabIndex = 14
        Me.btnAddBook.Text = "Save"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'EditAccession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 514)
        Me.Controls.Add(Me.lblRemarks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditAccession"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditAccession"
        Me.lblRemarks.ResumeLayout(False)
        Me.lblRemarks.PerformLayout()
        CType(Me.updownPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updownVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRemarks As OutlineRoundPanel
    Friend WithEvents lblDateRecieved As Label
    Friend WithEvents btnCancel As RoundedButton
    Friend WithEvents txtTitle As RoundedTextbox
    Friend WithEvents txtAuthor As RoundedTextbox
    Friend WithEvents cmbMaterial As ComboBox
    Friend WithEvents btnAddBook As RoundedButton
    Friend WithEvents pickDateRecieved As DateTimePicker
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMaterial As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblEdition As Label
    Friend WithEvents txtEdition As RoundedTextbox
    Friend WithEvents lblVolume As Label
    Friend WithEvents updownVolume As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemarks As RoundedTextbox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents lblPublisher As Label
    Friend WithEvents txtPublisher As RoundedTextbox
    Friend WithEvents lblPages As Label
    Friend WithEvents updownPages As NumericUpDown
    Friend WithEvents picThumbnail As PictureBox
    Friend WithEvents btnChoosePhoto As RoundedButton
    Friend WithEvents lblFilePath As Label
    Friend WithEvents lblBookID As Label
    Friend WithEvents txtBookID As RoundedTextbox
    Friend WithEvents lblCostPrice As Label
    Friend WithEvents txtCostPrice As RoundedTextbox
    Friend WithEvents ToolTip1 As ToolTip
End Class

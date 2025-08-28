<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDetails
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
        Me.BookDetailsPanel = New LMS.OutlineRoundPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookTitle = New LMS.RoundedTextbox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtBorrower = New LMS.RoundedTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New LMS.RoundedButton()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBorrowDate = New LMS.RoundedTextbox()
        Me.txtReturnDate = New LMS.RoundedTextbox()
        Me.txtDueDate = New LMS.RoundedTextbox()
        Me.BookDetailsPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookDetailsPanel
        '
        Me.BookDetailsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.BookDetailsPanel.BorderColor = System.Drawing.Color.Black
        Me.BookDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BookDetailsPanel.BorderWidth = 6
        Me.BookDetailsPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.BookDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookDetailsPanel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BookDetailsPanel.Location = New System.Drawing.Point(0, 0)
        Me.BookDetailsPanel.Name = "BookDetailsPanel"
        Me.BookDetailsPanel.Size = New System.Drawing.Size(624, 432)
        Me.BookDetailsPanel.TabIndex = 11
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.029601!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.9704!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.32748!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.67252!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(622, 430)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblStatus, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(9, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.68965!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.31034!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(589, 223)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStatus.Location = New System.Drawing.Point(3, 137)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(583, 28)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "STATUS"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(583, 14)
        Me.TableLayoutPanel5.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Beige
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(3, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(577, 1)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Title of the Book"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtBookTitle, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(583, 111)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 19)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TITLE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBookTitle.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(3, 28)
        Me.txtBookTitle.Multiline = True
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.ReadOnly = True
        Me.txtBookTitle.Size = New System.Drawing.Size(577, 80)
        Me.txtBookTitle.TabIndex = 4
        Me.txtBookTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.98456!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.01543!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtBorrower, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 168)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(583, 52)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'txtBorrower
        '
        Me.txtBorrower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBorrower.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.txtBorrower.Location = New System.Drawing.Point(137, 3)
        Me.txtBorrower.Multiline = True
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.ReadOnly = True
        Me.txtBorrower.Size = New System.Drawing.Size(443, 46)
        Me.txtBorrower.TabIndex = 9
        Me.txtBorrower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 52)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Borrowed by:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(227, 363)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(153, 38)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        AddHandler Me.btnClose.Click, AddressOf Me.btnClose_Click
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08998!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.91002!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txtBorrowDate, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtReturnDate, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txtDueDate, 1, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(9, 232)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(589, 121)
        Me.TableLayoutPanel6.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date Borrowed"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Due Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(3, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 41)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Returned Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBorrowDate
        '
        Me.txtBorrowDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBorrowDate.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.txtBorrowDate.Location = New System.Drawing.Point(138, 3)
        Me.txtBorrowDate.Multiline = True
        Me.txtBorrowDate.Name = "txtBorrowDate"
        Me.txtBorrowDate.ReadOnly = True
        Me.txtBorrowDate.Size = New System.Drawing.Size(448, 34)
        Me.txtBorrowDate.TabIndex = 10
        Me.txtBorrowDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReturnDate
        '
        Me.txtReturnDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReturnDate.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.txtReturnDate.Location = New System.Drawing.Point(138, 83)
        Me.txtReturnDate.Multiline = True
        Me.txtReturnDate.Name = "txtReturnDate"
        Me.txtReturnDate.ReadOnly = True
        Me.txtReturnDate.Size = New System.Drawing.Size(448, 35)
        Me.txtReturnDate.TabIndex = 11
        Me.txtReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDueDate
        '
        Me.txtDueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDueDate.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.txtDueDate.Location = New System.Drawing.Point(138, 43)
        Me.txtDueDate.Multiline = True
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.ReadOnly = True
        Me.txtDueDate.Size = New System.Drawing.Size(448, 34)
        Me.txtDueDate.TabIndex = 12
        Me.txtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TransactionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 432)
        Me.Controls.Add(Me.BookDetailsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TransactionDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Details"
        Me.BookDetailsPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookDetailsPanel As OutlineRoundPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnClose As RoundedButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookTitle As RoundedTextbox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtBorrower As RoundedTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBorrowDate As RoundedTextbox
    Friend WithEvents txtReturnDate As RoundedTextbox
    Friend WithEvents txtDueDate As RoundedTextbox
End Class

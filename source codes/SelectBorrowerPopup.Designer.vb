<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectBorrowerPopup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBorrower = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(444, 244)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbBorrower, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpDueDate, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19048!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.80952!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7619!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.23809!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(438, 238)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 189)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.96296!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.03704!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(432, 46)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'btnOK
        '
        Me.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOK.Location = New System.Drawing.Point(113, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(219, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 22)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Borrower's Name: "
        '
        'cmbBorrower
        '
        Me.cmbBorrower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbBorrower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBorrower.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBorrower.FormattingEnabled = True
        Me.cmbBorrower.Location = New System.Drawing.Point(26, 67)
        Me.cmbBorrower.Name = "cmbBorrower"
        Me.cmbBorrower.Size = New System.Drawing.Size(385, 26)
        Me.cmbBorrower.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Set Due Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpDueDate.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Location = New System.Drawing.Point(29, 149)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(379, 27)
        Me.dtpDueDate.TabIndex = 6
        '
        'SelectBorrowerPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 244)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectBorrowerPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SelectBorrowerPopup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cmbBorrower As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDueDate As DateTimePicker
End Class

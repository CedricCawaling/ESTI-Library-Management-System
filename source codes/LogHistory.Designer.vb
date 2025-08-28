<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogHistory
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
        Me.RoundedPanel1 = New LMS.RoundedPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.lblLogName = New System.Windows.Forms.Label()
        Me.RoundedPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.RoundedPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(800, 397)
        Me.RoundedPanel1.TabIndex = 24
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgvHistory, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogName, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.77778!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22222!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.777778!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 397)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.AllowUserToDeleteRows = False
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.Location = New System.Drawing.Point(23, 81)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.ReadOnly = True
        Me.dgvHistory.Size = New System.Drawing.Size(754, 289)
        Me.dgvHistory.TabIndex = 1
        '
        'lblLogName
        '
        Me.lblLogName.AutoSize = True
        Me.lblLogName.BackColor = System.Drawing.Color.Transparent
        Me.lblLogName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogName.Font = New System.Drawing.Font("Bahnschrift SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogName.ForeColor = System.Drawing.Color.White
        Me.lblLogName.Location = New System.Drawing.Point(23, 0)
        Me.lblLogName.Name = "lblLogName"
        Me.lblLogName.Size = New System.Drawing.Size(754, 78)
        Me.lblLogName.TabIndex = 2
        Me.lblLogName.Text = "Library Access Record"
        Me.lblLogName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LogHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 397)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LogHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log History"
        Me.RoundedPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents lblLogName As Label
End Class

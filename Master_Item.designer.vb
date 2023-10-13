<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Item
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
        Me.pnl_Item = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbb_kategori = New System.Windows.Forms.ComboBox()
        Me.dgv_barangItem = New System.Windows.Forms.DataGridView()
        Me.pnl_Item.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_barangItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_Item
        '
        Me.pnl_Item.Controls.Add(Me.GroupBox1)
        Me.pnl_Item.Location = New System.Drawing.Point(0, 13)
        Me.pnl_Item.Name = "pnl_Item"
        Me.pnl_Item.Size = New System.Drawing.Size(725, 410)
        Me.pnl_Item.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_kategori)
        Me.GroupBox1.Controls.Add(Me.dgv_barangItem)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 348)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'cbb_kategori
        '
        Me.cbb_kategori.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_kategori.FormattingEnabled = True
        Me.cbb_kategori.Location = New System.Drawing.Point(6, 29)
        Me.cbb_kategori.Name = "cbb_kategori"
        Me.cbb_kategori.Size = New System.Drawing.Size(201, 26)
        Me.cbb_kategori.TabIndex = 50
        '
        'dgv_barangItem
        '
        Me.dgv_barangItem.AllowUserToAddRows = False
        Me.dgv_barangItem.AllowUserToDeleteRows = False
        Me.dgv_barangItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_barangItem.BackgroundColor = System.Drawing.Color.White
        Me.dgv_barangItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barangItem.Location = New System.Drawing.Point(6, 64)
        Me.dgv_barangItem.Name = "dgv_barangItem"
        Me.dgv_barangItem.ReadOnly = True
        Me.dgv_barangItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_barangItem.Size = New System.Drawing.Size(700, 278)
        Me.dgv_barangItem.TabIndex = 38
        '
        'Master_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 423)
        Me.Controls.Add(Me.pnl_Item)
        Me.Name = "Master_Item"
        Me.Text = "Master_Edit"
        Me.pnl_Item.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_barangItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_Item As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgv_barangItem As System.Windows.Forms.DataGridView
    Friend WithEvents cbb_kategori As System.Windows.Forms.ComboBox
End Class

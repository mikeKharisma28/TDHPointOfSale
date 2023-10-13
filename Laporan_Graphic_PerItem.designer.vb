<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Graphic_PerItem
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
        Me.pnl_perItem = New System.Windows.Forms.Panel()
        Me.dgv_item = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picker_TglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.picker_TglAwal = New System.Windows.Forms.DateTimePicker()
        Me.pnl_perItem.SuspendLayout()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_perItem
        '
        Me.pnl_perItem.Controls.Add(Me.dgv_item)
        Me.pnl_perItem.Controls.Add(Me.Label3)
        Me.pnl_perItem.Controls.Add(Me.btn_ubah)
        Me.pnl_perItem.Controls.Add(Me.Label2)
        Me.pnl_perItem.Controls.Add(Me.Label1)
        Me.pnl_perItem.Controls.Add(Me.picker_TglAkhir)
        Me.pnl_perItem.Controls.Add(Me.picker_TglAwal)
        Me.pnl_perItem.Location = New System.Drawing.Point(5, 1)
        Me.pnl_perItem.Name = "pnl_perItem"
        Me.pnl_perItem.Size = New System.Drawing.Size(245, 384)
        Me.pnl_perItem.TabIndex = 1
        '
        'dgv_item
        '
        Me.dgv_item.AllowUserToAddRows = False
        Me.dgv_item.AllowUserToDeleteRows = False
        Me.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_item.Location = New System.Drawing.Point(7, 113)
        Me.dgv_item.MultiSelect = False
        Me.dgv_item.Name = "dgv_item"
        Me.dgv_item.ReadOnly = True
        Me.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_item.Size = New System.Drawing.Size(230, 204)
        Me.dgv_item.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(20, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Item :"
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.Orange
        Me.btn_ubah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ubah.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.Color.Purple
        Me.btn_ubah.Location = New System.Drawing.Point(162, 323)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 40)
        Me.btn_ubah.TabIndex = 50
        Me.btn_ubah.Text = "Refresh"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Akhir :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Awal :"
        '
        'picker_TglAkhir
        '
        Me.picker_TglAkhir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_TglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_TglAkhir.Location = New System.Drawing.Point(66, 43)
        Me.picker_TglAkhir.Name = "picker_TglAkhir"
        Me.picker_TglAkhir.Size = New System.Drawing.Size(100, 23)
        Me.picker_TglAkhir.TabIndex = 1
        '
        'picker_TglAwal
        '
        Me.picker_TglAwal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_TglAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_TglAwal.Location = New System.Drawing.Point(66, 14)
        Me.picker_TglAwal.Name = "picker_TglAwal"
        Me.picker_TglAwal.Size = New System.Drawing.Size(100, 23)
        Me.picker_TglAwal.TabIndex = 0
        '
        'Laporan_Graphic_PerItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 387)
        Me.Controls.Add(Me.pnl_perItem)
        Me.Name = "Laporan_Graphic_PerItem"
        Me.Text = "Laporan_Graphic_PerItem"
        Me.pnl_perItem.ResumeLayout(False)
        Me.pnl_perItem.PerformLayout()
        CType(Me.dgv_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_perItem As System.Windows.Forms.Panel
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picker_TglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents picker_TglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_item As System.Windows.Forms.DataGridView
End Class

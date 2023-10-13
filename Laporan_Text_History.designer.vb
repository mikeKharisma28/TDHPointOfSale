<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Text_History
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
        Me.pnl_history = New System.Windows.Forms.Panel()
        Me.dgv_transaksi = New System.Windows.Forms.DataGridView()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picker_Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.pnl_history.SuspendLayout()
        CType(Me.dgv_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_history
        '
        Me.pnl_history.Controls.Add(Me.dgv_transaksi)
        Me.pnl_history.Controls.Add(Me.btn_print)
        Me.pnl_history.Controls.Add(Me.Label3)
        Me.pnl_history.Controls.Add(Me.btn_ubah)
        Me.pnl_history.Controls.Add(Me.Label2)
        Me.pnl_history.Controls.Add(Me.Label1)
        Me.pnl_history.Controls.Add(Me.picker_Tanggal)
        Me.pnl_history.Location = New System.Drawing.Point(5, 1)
        Me.pnl_history.Name = "pnl_history"
        Me.pnl_history.Size = New System.Drawing.Size(245, 384)
        Me.pnl_history.TabIndex = 2
        '
        'dgv_transaksi
        '
        Me.dgv_transaksi.AllowUserToAddRows = False
        Me.dgv_transaksi.AllowUserToDeleteRows = False
        Me.dgv_transaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transaksi.Location = New System.Drawing.Point(7, 116)
        Me.dgv_transaksi.MultiSelect = False
        Me.dgv_transaksi.Name = "dgv_transaksi"
        Me.dgv_transaksi.ReadOnly = True
        Me.dgv_transaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_transaksi.Size = New System.Drawing.Size(230, 204)
        Me.dgv_transaksi.TabIndex = 54
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.Orange
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.Enabled = False
        Me.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Purple
        Me.btn_print.Location = New System.Drawing.Point(151, 335)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 40)
        Me.btn_print.TabIndex = 53
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(9, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "No. Transaksi :"
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.Color.Orange
        Me.btn_ubah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ubah.Enabled = False
        Me.btn_ubah.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ubah.ForeColor = System.Drawing.Color.Purple
        Me.btn_ubah.Location = New System.Drawing.Point(70, 335)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(75, 40)
        Me.btn_ubah.TabIndex = 50
        Me.btn_ubah.Text = "Preview"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(42, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(34, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pilih tanggal dan nomor transaksi yang diinginkan :"
        '
        'picker_Tanggal
        '
        Me.picker_Tanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_Tanggal.Location = New System.Drawing.Point(105, 55)
        Me.picker_Tanggal.Name = "picker_Tanggal"
        Me.picker_Tanggal.Size = New System.Drawing.Size(100, 23)
        Me.picker_Tanggal.TabIndex = 1
        '
        'Laporan_Text_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 388)
        Me.Controls.Add(Me.pnl_history)
        Me.Name = "Laporan_Text_History"
        Me.Text = "Laporan_Text_History"
        Me.pnl_history.ResumeLayout(False)
        Me.pnl_history.PerformLayout()
        CType(Me.dgv_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_history As System.Windows.Forms.Panel
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picker_Tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents dgv_transaksi As System.Windows.Forms.DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Text_PerHari
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
        Me.pnl_perhari = New System.Windows.Forms.Panel()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picker_Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.pnl_perhari.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_perhari
        '
        Me.pnl_perhari.Controls.Add(Me.btn_ubah)
        Me.pnl_perhari.Controls.Add(Me.Label2)
        Me.pnl_perhari.Controls.Add(Me.Label1)
        Me.pnl_perhari.Controls.Add(Me.picker_Tanggal)
        Me.pnl_perhari.Location = New System.Drawing.Point(5, 1)
        Me.pnl_perhari.Name = "pnl_perhari"
        Me.pnl_perhari.Size = New System.Drawing.Size(245, 384)
        Me.pnl_perhari.TabIndex = 1
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
        Me.btn_ubah.Location = New System.Drawing.Point(122, 217)
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
        Me.Label2.Location = New System.Drawing.Point(37, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(40, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pilih tanggal yang diinginkan :"
        '
        'picker_Tanggal
        '
        Me.picker_Tanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_Tanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_Tanggal.Location = New System.Drawing.Point(100, 174)
        Me.picker_Tanggal.Name = "picker_Tanggal"
        Me.picker_Tanggal.Size = New System.Drawing.Size(100, 23)
        Me.picker_Tanggal.TabIndex = 1
        '
        'Laporan_Text_PerHari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 389)
        Me.Controls.Add(Me.pnl_perhari)
        Me.Name = "Laporan_Text_PerHari"
        Me.Text = "Laporan_Text_PerHari"
        Me.pnl_perhari.ResumeLayout(False)
        Me.pnl_perhari.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_perhari As System.Windows.Forms.Panel
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picker_Tanggal As System.Windows.Forms.DateTimePicker
End Class

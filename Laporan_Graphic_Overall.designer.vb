<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Graphic_Overall
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
        Me.pnl_overall = New System.Windows.Forms.Panel()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picker_TglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.picker_TglAwal = New System.Windows.Forms.DateTimePicker()
        Me.pnl_overall.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_overall
        '
        Me.pnl_overall.Controls.Add(Me.btn_ubah)
        Me.pnl_overall.Controls.Add(Me.Label2)
        Me.pnl_overall.Controls.Add(Me.Label1)
        Me.pnl_overall.Controls.Add(Me.picker_TglAkhir)
        Me.pnl_overall.Controls.Add(Me.picker_TglAwal)
        Me.pnl_overall.Location = New System.Drawing.Point(5, 1)
        Me.pnl_overall.Name = "pnl_overall"
        Me.pnl_overall.Size = New System.Drawing.Size(245, 384)
        Me.pnl_overall.TabIndex = 0
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
        Me.Label2.Location = New System.Drawing.Point(47, 186)
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
        Me.Label1.Location = New System.Drawing.Point(50, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Awal :"
        '
        'picker_TglAkhir
        '
        Me.picker_TglAkhir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_TglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_TglAkhir.Location = New System.Drawing.Point(100, 181)
        Me.picker_TglAkhir.Name = "picker_TglAkhir"
        Me.picker_TglAkhir.Size = New System.Drawing.Size(100, 23)
        Me.picker_TglAkhir.TabIndex = 1
        '
        'picker_TglAwal
        '
        Me.picker_TglAwal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picker_TglAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.picker_TglAwal.Location = New System.Drawing.Point(100, 152)
        Me.picker_TglAwal.Name = "picker_TglAwal"
        Me.picker_TglAwal.Size = New System.Drawing.Size(100, 23)
        Me.picker_TglAwal.TabIndex = 0
        '
        'Laporan_Graphic_Overall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 386)
        Me.Controls.Add(Me.pnl_overall)
        Me.Name = "Laporan_Graphic_Overall"
        Me.Text = "Laporan_Graphic_Overall"
        Me.pnl_overall.ResumeLayout(False)
        Me.pnl_overall.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_overall As System.Windows.Forms.Panel
    Friend WithEvents picker_TglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents picker_TglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ubah As System.Windows.Forms.Button
End Class

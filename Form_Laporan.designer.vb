<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan
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
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_graphic = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_master = New System.Windows.Forms.Panel()
        Me.lbl_petunjuk1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnl_master.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_laporan
        '
        Me.btn_laporan.BackColor = System.Drawing.Color.Orange
        Me.btn_laporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_laporan.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_laporan.FlatAppearance.BorderSize = 0
        Me.btn_laporan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laporan.ForeColor = System.Drawing.Color.White
        Me.btn_laporan.Location = New System.Drawing.Point(674, 86)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(154, 52)
        Me.btn_laporan.TabIndex = 50
        Me.btn_laporan.Text = "Laporan Penjualan"
        Me.btn_laporan.UseVisualStyleBackColor = False
        '
        'btn_graphic
        '
        Me.btn_graphic.BackColor = System.Drawing.Color.Orange
        Me.btn_graphic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_graphic.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_graphic.FlatAppearance.BorderSize = 0
        Me.btn_graphic.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_graphic.ForeColor = System.Drawing.Color.White
        Me.btn_graphic.Location = New System.Drawing.Point(174, 86)
        Me.btn_graphic.Name = "btn_graphic"
        Me.btn_graphic.Size = New System.Drawing.Size(154, 52)
        Me.btn_graphic.TabIndex = 49
        Me.btn_graphic.Text = "Grafik Penjualan"
        Me.btn_graphic.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Orange
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 34)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Laporan"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'pnl_master
        '
        Me.pnl_master.Controls.Add(Me.lbl_petunjuk1)
        Me.pnl_master.Location = New System.Drawing.Point(2, 148)
        Me.pnl_master.Name = "pnl_master"
        Me.pnl_master.Size = New System.Drawing.Size(995, 455)
        Me.pnl_master.TabIndex = 51
        '
        'lbl_petunjuk1
        '
        Me.lbl_petunjuk1.AutoSize = True
        Me.lbl_petunjuk1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_petunjuk1.ForeColor = System.Drawing.Color.Orange
        Me.lbl_petunjuk1.Location = New System.Drawing.Point(398, 10)
        Me.lbl_petunjuk1.Name = "lbl_petunjuk1"
        Me.lbl_petunjuk1.Size = New System.Drawing.Size(200, 18)
        Me.lbl_petunjuk1.TabIndex = 83
        Me.lbl_petunjuk1.Text = "Klik salah satu tombol menu diatas."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 79)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        '
        'Form_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(999, 606)
        Me.Controls.Add(Me.btn_laporan)
        Me.Controls.Add(Me.btn_graphic)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnl_master)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        Me.pnl_master.ResumeLayout(False)
        Me.pnl_master.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_laporan As System.Windows.Forms.Button
    Friend WithEvents btn_graphic As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnl_master As System.Windows.Forms.Panel
    Friend WithEvents lbl_petunjuk1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

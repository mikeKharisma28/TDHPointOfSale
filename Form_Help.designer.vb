<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Help
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_petunjuk1 = New System.Windows.Forms.Label()
        Me.btn_Order = New System.Windows.Forms.Button()
        Me.btn_Master = New System.Windows.Forms.Button()
        Me.btn_Laporan = New System.Windows.Forms.Button()
        Me.btn_About = New System.Windows.Forms.Button()
        Me.pnl_master = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnl_master.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Orange
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(30, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 34)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Help Viewer"
        '
        'lbl_petunjuk1
        '
        Me.lbl_petunjuk1.AutoSize = True
        Me.lbl_petunjuk1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_petunjuk1.ForeColor = System.Drawing.Color.Orange
        Me.lbl_petunjuk1.Location = New System.Drawing.Point(3, 211)
        Me.lbl_petunjuk1.Name = "lbl_petunjuk1"
        Me.lbl_petunjuk1.Size = New System.Drawing.Size(193, 18)
        Me.lbl_petunjuk1.TabIndex = 83
        Me.lbl_petunjuk1.Text = "Klik salah satu tombol di samping."
        '
        'btn_Order
        '
        Me.btn_Order.BackColor = System.Drawing.Color.Purple
        Me.btn_Order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Order.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_Order.FlatAppearance.BorderSize = 0
        Me.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Order.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Order.ForeColor = System.Drawing.Color.White
        Me.btn_Order.Location = New System.Drawing.Point(18, 228)
        Me.btn_Order.Name = "btn_Order"
        Me.btn_Order.Size = New System.Drawing.Size(147, 52)
        Me.btn_Order.TabIndex = 85
        Me.btn_Order.Text = "Bantuan untuk Menu Order"
        Me.btn_Order.UseVisualStyleBackColor = False
        '
        'btn_Master
        '
        Me.btn_Master.BackColor = System.Drawing.Color.Purple
        Me.btn_Master.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Master.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_Master.FlatAppearance.BorderSize = 0
        Me.btn_Master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Master.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Master.ForeColor = System.Drawing.Color.White
        Me.btn_Master.Location = New System.Drawing.Point(18, 170)
        Me.btn_Master.Name = "btn_Master"
        Me.btn_Master.Size = New System.Drawing.Size(147, 52)
        Me.btn_Master.TabIndex = 84
        Me.btn_Master.Text = "Bantuan untuk Menu Master Data"
        Me.btn_Master.UseVisualStyleBackColor = False
        '
        'btn_Laporan
        '
        Me.btn_Laporan.BackColor = System.Drawing.Color.Purple
        Me.btn_Laporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Laporan.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_Laporan.FlatAppearance.BorderSize = 0
        Me.btn_Laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Laporan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Laporan.ForeColor = System.Drawing.Color.White
        Me.btn_Laporan.Location = New System.Drawing.Point(18, 286)
        Me.btn_Laporan.Name = "btn_Laporan"
        Me.btn_Laporan.Size = New System.Drawing.Size(147, 52)
        Me.btn_Laporan.TabIndex = 86
        Me.btn_Laporan.Text = "Bantuan untuk Menu Laporan"
        Me.btn_Laporan.UseVisualStyleBackColor = False
        '
        'btn_About
        '
        Me.btn_About.BackColor = System.Drawing.Color.Purple
        Me.btn_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_About.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_About.FlatAppearance.BorderSize = 0
        Me.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_About.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_About.ForeColor = System.Drawing.Color.White
        Me.btn_About.Location = New System.Drawing.Point(18, 344)
        Me.btn_About.Name = "btn_About"
        Me.btn_About.Size = New System.Drawing.Size(147, 52)
        Me.btn_About.TabIndex = 87
        Me.btn_About.Text = "Tentang Software"
        Me.btn_About.UseVisualStyleBackColor = False
        '
        'pnl_master
        '
        Me.pnl_master.Controls.Add(Me.lbl_petunjuk1)
        Me.pnl_master.Location = New System.Drawing.Point(172, 75)
        Me.pnl_master.Name = "pnl_master"
        Me.pnl_master.Size = New System.Drawing.Size(620, 415)
        Me.pnl_master.TabIndex = 88
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(-9, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 79)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Orange
        Me.GroupBox2.Location = New System.Drawing.Point(-10, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 452)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        '
        'Form_Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(799, 497)
        Me.Controls.Add(Me.btn_About)
        Me.Controls.Add(Me.btn_Laporan)
        Me.Controls.Add(Me.btn_Order)
        Me.Controls.Add(Me.btn_Master)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnl_master)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Help"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help Viewer"
        Me.pnl_master.ResumeLayout(False)
        Me.pnl_master.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_petunjuk1 As System.Windows.Forms.Label
    Friend WithEvents btn_Order As System.Windows.Forms.Button
    Friend WithEvents btn_Master As System.Windows.Forms.Button
    Friend WithEvents btn_Laporan As System.Windows.Forms.Button
    Friend WithEvents btn_About As System.Windows.Forms.Button
    Friend WithEvents pnl_master As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

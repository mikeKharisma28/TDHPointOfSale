<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Text
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
        Me.pnl_text = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnl_child = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbb_tipeLaporan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.lbl_petunjuk1 = New System.Windows.Forms.Label()
        Me.pnl_text.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_child.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_text
        '
        Me.pnl_text.Controls.Add(Me.GroupBox2)
        Me.pnl_text.Controls.Add(Me.GroupBox1)
        Me.pnl_text.Location = New System.Drawing.Point(0, 1)
        Me.pnl_text.Name = "pnl_text"
        Me.pnl_text.Size = New System.Drawing.Size(995, 455)
        Me.pnl_text.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pnl_child)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbb_tipeLaporan)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 451)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'pnl_child
        '
        Me.pnl_child.Controls.Add(Me.lbl_petunjuk1)
        Me.pnl_child.Location = New System.Drawing.Point(6, 61)
        Me.pnl_child.Name = "pnl_child"
        Me.pnl_child.Size = New System.Drawing.Size(245, 384)
        Me.pnl_child.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pilih Laporan:"
        '
        'cbb_tipeLaporan
        '
        Me.cbb_tipeLaporan.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_tipeLaporan.FormattingEnabled = True
        Me.cbb_tipeLaporan.Items.AddRange(New Object() {"Penjualan Per Hari", "History Penjualan"})
        Me.cbb_tipeLaporan.Location = New System.Drawing.Point(117, 19)
        Me.cbb_tipeLaporan.Name = "cbb_tipeLaporan"
        Me.cbb_tipeLaporan.Size = New System.Drawing.Size(134, 26)
        Me.cbb_tipeLaporan.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 451)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 16)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(722, 432)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'lbl_petunjuk1
        '
        Me.lbl_petunjuk1.AutoSize = True
        Me.lbl_petunjuk1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_petunjuk1.ForeColor = System.Drawing.Color.Orange
        Me.lbl_petunjuk1.Location = New System.Drawing.Point(51, 3)
        Me.lbl_petunjuk1.Name = "lbl_petunjuk1"
        Me.lbl_petunjuk1.Size = New System.Drawing.Size(188, 18)
        Me.lbl_petunjuk1.TabIndex = 85
        Me.lbl_petunjuk1.Text = "Pilih tipe laporan yang diinginkan"
        '
        'Laporan_Text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 466)
        Me.Controls.Add(Me.pnl_text)
        Me.Name = "Laporan_Text"
        Me.Text = "Laporan_Text"
        Me.pnl_text.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_child.ResumeLayout(False)
        Me.pnl_child.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_text As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pnl_child As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbb_tipeLaporan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lbl_petunjuk1 As System.Windows.Forms.Label
End Class

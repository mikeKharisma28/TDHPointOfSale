<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Master
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
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.btn_addData = New System.Windows.Forms.Button()
        Me.btn_editData = New System.Windows.Forms.Button()
        Me.pnl_master = New System.Windows.Forms.Panel()
        Me.lbl_petunjuk2 = New System.Windows.Forms.Label()
        Me.lbl_petunjuk1 = New System.Windows.Forms.Label()
        Me.btn_DataMeja = New System.Windows.Forms.Button()
        Me.btn_DataItem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnl_master.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.BackColor = System.Drawing.Color.Orange
        Me.lbl_judul.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_judul.ForeColor = System.Drawing.Color.White
        Me.lbl_judul.Location = New System.Drawing.Point(30, 16)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(155, 34)
        Me.lbl_judul.TabIndex = 44
        Me.lbl_judul.Text = "Master Data"
        '
        'btn_addData
        '
        Me.btn_addData.BackColor = System.Drawing.Color.Purple
        Me.btn_addData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addData.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_addData.FlatAppearance.BorderSize = 0
        Me.btn_addData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addData.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addData.ForeColor = System.Drawing.Color.White
        Me.btn_addData.Location = New System.Drawing.Point(15, 289)
        Me.btn_addData.Name = "btn_addData"
        Me.btn_addData.Size = New System.Drawing.Size(147, 52)
        Me.btn_addData.TabIndex = 45
        Me.btn_addData.Text = "Add Data"
        Me.btn_addData.UseVisualStyleBackColor = False
        Me.btn_addData.Visible = False
        '
        'btn_editData
        '
        Me.btn_editData.BackColor = System.Drawing.Color.Purple
        Me.btn_editData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editData.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.btn_editData.FlatAppearance.BorderSize = 0
        Me.btn_editData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editData.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editData.ForeColor = System.Drawing.Color.White
        Me.btn_editData.Location = New System.Drawing.Point(15, 379)
        Me.btn_editData.Name = "btn_editData"
        Me.btn_editData.Size = New System.Drawing.Size(147, 52)
        Me.btn_editData.TabIndex = 46
        Me.btn_editData.Text = "Edit Data"
        Me.btn_editData.UseVisualStyleBackColor = False
        Me.btn_editData.Visible = False
        '
        'pnl_master
        '
        Me.pnl_master.Controls.Add(Me.lbl_petunjuk2)
        Me.pnl_master.Controls.Add(Me.lbl_petunjuk1)
        Me.pnl_master.Location = New System.Drawing.Point(165, 159)
        Me.pnl_master.Name = "pnl_master"
        Me.pnl_master.Size = New System.Drawing.Size(725, 410)
        Me.pnl_master.TabIndex = 47
        '
        'lbl_petunjuk2
        '
        Me.lbl_petunjuk2.AutoSize = True
        Me.lbl_petunjuk2.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_petunjuk2.ForeColor = System.Drawing.Color.Orange
        Me.lbl_petunjuk2.Location = New System.Drawing.Point(3, 193)
        Me.lbl_petunjuk2.Name = "lbl_petunjuk2"
        Me.lbl_petunjuk2.Size = New System.Drawing.Size(242, 18)
        Me.lbl_petunjuk2.TabIndex = 83
        Me.lbl_petunjuk2.Text = "Step 2. Lalu klik salah satu menu disamping"
        '
        'lbl_petunjuk1
        '
        Me.lbl_petunjuk1.AutoSize = True
        Me.lbl_petunjuk1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_petunjuk1.ForeColor = System.Drawing.Color.Orange
        Me.lbl_petunjuk1.Location = New System.Drawing.Point(253, 8)
        Me.lbl_petunjuk1.Name = "lbl_petunjuk1"
        Me.lbl_petunjuk1.Size = New System.Drawing.Size(241, 18)
        Me.lbl_petunjuk1.TabIndex = 82
        Me.lbl_petunjuk1.Text = "Step 1. Klik salah satu tombol menu diatas."
        '
        'btn_DataMeja
        '
        Me.btn_DataMeja.BackColor = System.Drawing.Color.Orange
        Me.btn_DataMeja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DataMeja.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_DataMeja.FlatAppearance.BorderSize = 0
        Me.btn_DataMeja.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DataMeja.ForeColor = System.Drawing.Color.White
        Me.btn_DataMeja.Location = New System.Drawing.Point(622, 87)
        Me.btn_DataMeja.Name = "btn_DataMeja"
        Me.btn_DataMeja.Size = New System.Drawing.Size(147, 52)
        Me.btn_DataMeja.TabIndex = 48
        Me.btn_DataMeja.Tag = "2"
        Me.btn_DataMeja.Text = "Master Data Meja"
        Me.btn_DataMeja.UseVisualStyleBackColor = False
        '
        'btn_DataItem
        '
        Me.btn_DataItem.BackColor = System.Drawing.Color.Orange
        Me.btn_DataItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_DataItem.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_DataItem.FlatAppearance.BorderSize = 0
        Me.btn_DataItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DataItem.ForeColor = System.Drawing.Color.White
        Me.btn_DataItem.Location = New System.Drawing.Point(296, 87)
        Me.btn_DataItem.Name = "btn_DataItem"
        Me.btn_DataItem.Size = New System.Drawing.Size(147, 52)
        Me.btn_DataItem.TabIndex = 49
        Me.btn_DataItem.Tag = "1"
        Me.btn_DataItem.Text = "Master Data Item"
        Me.btn_DataItem.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Orange
        Me.GroupBox2.Location = New System.Drawing.Point(-7, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 516)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(897, 79)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'Form_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(889, 571)
        Me.Controls.Add(Me.btn_DataItem)
        Me.Controls.Add(Me.btn_DataMeja)
        Me.Controls.Add(Me.pnl_master)
        Me.Controls.Add(Me.btn_editData)
        Me.Controls.Add(Me.btn_addData)
        Me.Controls.Add(Me.lbl_judul)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data"
        Me.pnl_master.ResumeLayout(False)
        Me.pnl_master.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_judul As System.Windows.Forms.Label
    Friend WithEvents btn_addData As System.Windows.Forms.Button
    Friend WithEvents btn_editData As System.Windows.Forms.Button
    Friend WithEvents pnl_master As System.Windows.Forms.Panel
    Friend WithEvents btn_DataMeja As System.Windows.Forms.Button
    Friend WithEvents btn_DataItem As System.Windows.Forms.Button
    Friend WithEvents lbl_petunjuk1 As System.Windows.Forms.Label
    Friend WithEvents lbl_petunjuk2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

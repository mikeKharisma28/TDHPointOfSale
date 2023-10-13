<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama_Kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama_Kasir))
        Me.btn_laporan = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_signOut = New System.Windows.Forms.Button()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_master = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_jobTitle = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_laporan
        '
        Me.btn_laporan.BackColor = System.Drawing.Color.Orange
        Me.btn_laporan.FlatAppearance.BorderSize = 0
        Me.btn_laporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_laporan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_laporan.Image = CType(resources.GetObject("btn_laporan.Image"), System.Drawing.Image)
        Me.btn_laporan.Location = New System.Drawing.Point(503, 136)
        Me.btn_laporan.Name = "btn_laporan"
        Me.btn_laporan.Size = New System.Drawing.Size(128, 107)
        Me.btn_laporan.TabIndex = 4
        Me.btn_laporan.Text = "Laporan"
        Me.btn_laporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_laporan.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Orange
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Purple
        Me.btn_close.Location = New System.Drawing.Point(754, -2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(33, 23)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "X"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_signOut
        '
        Me.btn_signOut.BackColor = System.Drawing.Color.Orange
        Me.btn_signOut.FlatAppearance.BorderSize = 0
        Me.btn_signOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_signOut.Image = CType(resources.GetObject("btn_signOut.Image"), System.Drawing.Image)
        Me.btn_signOut.Location = New System.Drawing.Point(503, 281)
        Me.btn_signOut.Name = "btn_signOut"
        Me.btn_signOut.Size = New System.Drawing.Size(128, 107)
        Me.btn_signOut.TabIndex = 7
        Me.btn_signOut.Text = "Sign Out"
        Me.btn_signOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_signOut.UseVisualStyleBackColor = False
        '
        'btn_help
        '
        Me.btn_help.BackColor = System.Drawing.Color.Orange
        Me.btn_help.FlatAppearance.BorderSize = 0
        Me.btn_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_help.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_help.Image = CType(resources.GetObject("btn_help.Image"), System.Drawing.Image)
        Me.btn_help.Location = New System.Drawing.Point(327, 281)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(128, 107)
        Me.btn_help.TabIndex = 8
        Me.btn_help.Text = "Help"
        Me.btn_help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_help.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.Orange
        Me.btn_order.FlatAppearance.BorderSize = 0
        Me.btn_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_order.Image = CType(resources.GetObject("btn_order.Image"), System.Drawing.Image)
        Me.btn_order.Location = New System.Drawing.Point(327, 136)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(128, 107)
        Me.btn_order.TabIndex = 1
        Me.btn_order.Text = "Order"
        Me.btn_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_master
        '
        Me.btn_master.BackColor = System.Drawing.Color.Orange
        Me.btn_master.FlatAppearance.BorderSize = 0
        Me.btn_master.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_master.Image = CType(resources.GetObject("btn_master.Image"), System.Drawing.Image)
        Me.btn_master.Location = New System.Drawing.Point(155, 136)
        Me.btn_master.Name = "btn_master"
        Me.btn_master.Size = New System.Drawing.Size(128, 107)
        Me.btn_master.TabIndex = 0
        Me.btn_master.Text = "Master"
        Me.btn_master.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_master.UseVisualStyleBackColor = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Orange
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.Location = New System.Drawing.Point(-2, 419)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(788, 102)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(786, 574)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(121, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "TDH Point of Sale"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Orange
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(524, 421)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Welcome"
        '
        'lbl_jobTitle
        '
        Me.lbl_jobTitle.AutoSize = True
        Me.lbl_jobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jobTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_jobTitle.Location = New System.Drawing.Point(111, 81)
        Me.lbl_jobTitle.Name = "lbl_jobTitle"
        Me.lbl_jobTitle.Size = New System.Drawing.Size(14, 20)
        Me.lbl_jobTitle.TabIndex = 14
        Me.lbl_jobTitle.Text = "-"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_name.Location = New System.Drawing.Point(16, 56)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(14, 20)
        Me.lbl_name.TabIndex = 16
        Me.lbl_name.Text = "-"
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.Color.Orange
        Me.btn_settings.FlatAppearance.BorderSize = 0
        Me.btn_settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_settings.Image = CType(resources.GetObject("btn_settings.Image"), System.Drawing.Image)
        Me.btn_settings.Location = New System.Drawing.Point(155, 281)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(128, 107)
        Me.btn_settings.TabIndex = 17
        Me.btn_settings.Text = "Settings"
        Me.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Signed in as"
        '
        'Menu_Utama_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(786, 574)
        Me.Controls.Add(Me.btn_settings)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_jobTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_help)
        Me.Controls.Add(Me.btn_signOut)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_laporan)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_master)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Utama_Kasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_master As System.Windows.Forms.Button
    Friend WithEvents btn_order As System.Windows.Forms.Button
    Friend WithEvents btn_laporan As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_signOut As System.Windows.Forms.Button
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_jobTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents btn_settings As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
End Class

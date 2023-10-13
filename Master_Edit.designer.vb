<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Edit
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
        Me.pnl_editItem = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbb_kategori = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtb_deskripsi = New System.Windows.Forms.RichTextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.txt_namaAlias = New System.Windows.Forms.TextBox()
        Me.txt_namaAsli = New System.Windows.Forms.TextBox()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.pnl_editItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_editItem
        '
        Me.pnl_editItem.Controls.Add(Me.btn_cancel)
        Me.pnl_editItem.Controls.Add(Me.btn_save)
        Me.pnl_editItem.Controls.Add(Me.btn_edit)
        Me.pnl_editItem.Controls.Add(Me.GroupBox1)
        Me.pnl_editItem.Controls.Add(Me.GroupBox2)
        Me.pnl_editItem.Location = New System.Drawing.Point(0, 13)
        Me.pnl_editItem.Name = "pnl_editItem"
        Me.pnl_editItem.Size = New System.Drawing.Size(725, 410)
        Me.pnl_editItem.TabIndex = 0
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Orange
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Purple
        Me.btn_cancel.Location = New System.Drawing.Point(553, 359)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 33)
        Me.btn_cancel.TabIndex = 49
        Me.btn_cancel.Tag = "2"
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Orange
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Purple
        Me.btn_save.Location = New System.Drawing.Point(637, 359)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(78, 33)
        Me.btn_save.TabIndex = 48
        Me.btn_save.Tag = "1"
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        Me.btn_save.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.Orange
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Purple
        Me.btn_edit.Location = New System.Drawing.Point(637, 359)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(78, 33)
        Me.btn_edit.TabIndex = 45
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_barang)
        Me.GroupBox1.Controls.Add(Me.txt_search)
        Me.GroupBox1.Controls.Add(Me.cbb_kategori)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 348)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_search.Location = New System.Drawing.Point(6, 51)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(287, 21)
        Me.txt_search.TabIndex = 63
        Me.txt_search.Text = "Search item here..."
        '
        'cbb_kategori
        '
        Me.cbb_kategori.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_kategori.FormattingEnabled = True
        Me.cbb_kategori.Location = New System.Drawing.Point(6, 19)
        Me.cbb_kategori.Name = "cbb_kategori"
        Me.cbb_kategori.Size = New System.Drawing.Size(201, 26)
        Me.cbb_kategori.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtb_deskripsi)
        Me.GroupBox2.Controls.Add(Me.txt_harga)
        Me.GroupBox2.Controls.Add(Me.txt_namaAlias)
        Me.GroupBox2.Controls.Add(Me.txt_namaAsli)
        Me.GroupBox2.Controls.Add(Me.txt_kode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 348)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'rtb_deskripsi
        '
        Me.rtb_deskripsi.Enabled = False
        Me.rtb_deskripsi.Location = New System.Drawing.Point(111, 150)
        Me.rtb_deskripsi.Name = "rtb_deskripsi"
        Me.rtb_deskripsi.Size = New System.Drawing.Size(279, 78)
        Me.rtb_deskripsi.TabIndex = 77
        Me.rtb_deskripsi.Text = ""
        '
        'txt_harga
        '
        Me.txt_harga.Enabled = False
        Me.txt_harga.Location = New System.Drawing.Point(111, 240)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(221, 20)
        Me.txt_harga.TabIndex = 76
        '
        'txt_namaAlias
        '
        Me.txt_namaAlias.Enabled = False
        Me.txt_namaAlias.Location = New System.Drawing.Point(111, 119)
        Me.txt_namaAlias.Name = "txt_namaAlias"
        Me.txt_namaAlias.Size = New System.Drawing.Size(278, 20)
        Me.txt_namaAlias.TabIndex = 75
        '
        'txt_namaAsli
        '
        Me.txt_namaAsli.Enabled = False
        Me.txt_namaAsli.Location = New System.Drawing.Point(111, 86)
        Me.txt_namaAsli.Name = "txt_namaAsli"
        Me.txt_namaAsli.Size = New System.Drawing.Size(278, 20)
        Me.txt_namaAsli.TabIndex = 74
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Location = New System.Drawing.Point(111, 57)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(100, 20)
        Me.txt_kode.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(38, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Harga : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(2, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Nama Alias : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(19, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Deskripsi : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(10, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nama Asli : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(46, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Kode : "
        '
        'dgv_barang
        '
        Me.dgv_barang.AllowUserToAddRows = False
        Me.dgv_barang.AllowUserToDeleteRows = False
        Me.dgv_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_barang.BackgroundColor = System.Drawing.Color.White
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Location = New System.Drawing.Point(6, 78)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.ReadOnly = True
        Me.dgv_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_barang.Size = New System.Drawing.Size(288, 264)
        Me.dgv_barang.TabIndex = 64
        '
        'Master_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 423)
        Me.Controls.Add(Me.pnl_editItem)
        Me.Name = "Master_Edit"
        Me.Text = "Master_Edit"
        Me.pnl_editItem.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_editItem As System.Windows.Forms.Panel
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_deskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents txt_namaAlias As System.Windows.Forms.TextBox
    Friend WithEvents txt_namaAsli As System.Windows.Forms.TextBox
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents cbb_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dgv_barang As DataGridView
End Class

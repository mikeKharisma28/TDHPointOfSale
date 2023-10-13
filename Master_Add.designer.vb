<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Add
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
        Me.pnl_addItem = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtb_deskripsi = New System.Windows.Forms.RichTextBox()
        Me.btn_addCategory = New System.Windows.Forms.Button()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.cbb_kategori = New System.Windows.Forms.ComboBox()
        Me.txt_namaAlias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_namaAsli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnl_addItem.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_addItem
        '
        Me.pnl_addItem.Controls.Add(Me.btn_cancel)
        Me.pnl_addItem.Controls.Add(Me.btn_add)
        Me.pnl_addItem.Controls.Add(Me.GroupBox1)
        Me.pnl_addItem.Location = New System.Drawing.Point(1, 0)
        Me.pnl_addItem.Name = "pnl_addItem"
        Me.pnl_addItem.Size = New System.Drawing.Size(725, 410)
        Me.pnl_addItem.TabIndex = 0
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
        Me.btn_cancel.Location = New System.Drawing.Point(536, 359)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 33)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Orange
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Enabled = False
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Purple
        Me.btn_add.Location = New System.Drawing.Point(620, 359)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(78, 33)
        Me.btn_add.TabIndex = 56
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rtb_deskripsi)
        Me.GroupBox1.Controls.Add(Me.btn_addCategory)
        Me.GroupBox1.Controls.Add(Me.txt_harga)
        Me.GroupBox1.Controls.Add(Me.cbb_kategori)
        Me.GroupBox1.Controls.Add(Me.txt_namaAlias)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_namaAsli)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_kode)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 327)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(41, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Kategori : "
        '
        'rtb_deskripsi
        '
        Me.rtb_deskripsi.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_deskripsi.Location = New System.Drawing.Point(129, 163)
        Me.rtb_deskripsi.Name = "rtb_deskripsi"
        Me.rtb_deskripsi.Size = New System.Drawing.Size(500, 78)
        Me.rtb_deskripsi.TabIndex = 67
        Me.rtb_deskripsi.Text = ""
        '
        'btn_addCategory
        '
        Me.btn_addCategory.BackColor = System.Drawing.Color.Orange
        Me.btn_addCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addCategory.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_addCategory.FlatAppearance.BorderSize = 0
        Me.btn_addCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addCategory.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addCategory.ForeColor = System.Drawing.Color.Purple
        Me.btn_addCategory.Location = New System.Drawing.Point(256, 21)
        Me.btn_addCategory.Name = "btn_addCategory"
        Me.btn_addCategory.Size = New System.Drawing.Size(20, 26)
        Me.btn_addCategory.TabIndex = 49
        Me.btn_addCategory.Tag = "3"
        Me.btn_addCategory.Text = "+"
        Me.btn_addCategory.UseVisualStyleBackColor = False
        '
        'txt_harga
        '
        Me.txt_harga.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_harga.Location = New System.Drawing.Point(130, 258)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(157, 23)
        Me.txt_harga.TabIndex = 66
        '
        'cbb_kategori
        '
        Me.cbb_kategori.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_kategori.FormattingEnabled = True
        Me.cbb_kategori.Location = New System.Drawing.Point(129, 21)
        Me.cbb_kategori.Name = "cbb_kategori"
        Me.cbb_kategori.Size = New System.Drawing.Size(121, 26)
        Me.cbb_kategori.TabIndex = 48
        '
        'txt_namaAlias
        '
        Me.txt_namaAlias.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaAlias.Location = New System.Drawing.Point(130, 132)
        Me.txt_namaAlias.Name = "txt_namaAlias"
        Me.txt_namaAlias.Size = New System.Drawing.Size(499, 23)
        Me.txt_namaAlias.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(65, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Kode : "
        '
        'txt_namaAsli
        '
        Me.txt_namaAsli.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namaAsli.Location = New System.Drawing.Point(130, 99)
        Me.txt_namaAsli.Name = "txt_namaAsli"
        Me.txt_namaAsli.Size = New System.Drawing.Size(499, 23)
        Me.txt_namaAsli.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(29, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nama Asli : "
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode.Location = New System.Drawing.Point(130, 63)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(119, 23)
        Me.txt_kode.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(38, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 21)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Deskripsi : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(57, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Harga : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(21, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Nama Alias : "
        '
        'Master_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 409)
        Me.Controls.Add(Me.pnl_addItem)
        Me.Name = "Master_Add"
        Me.Text = "Master_Add"
        Me.pnl_addItem.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_addItem As System.Windows.Forms.Panel
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
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_addCategory As System.Windows.Forms.Button
    Friend WithEvents cbb_kategori As System.Windows.Forms.ComboBox
End Class

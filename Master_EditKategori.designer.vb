<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_EditKategori
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
        Me.txt_kategori = New System.Windows.Forms.TextBox()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_initial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbb_WithAlias = New System.Windows.Forms.ComboBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Purple
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(19, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 34)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Kategori"
        '
        'txt_kategori
        '
        Me.txt_kategori.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kategori.Location = New System.Drawing.Point(152, 115)
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.Size = New System.Drawing.Size(173, 23)
        Me.txt_kategori.TabIndex = 70
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode.Location = New System.Drawing.Point(152, 85)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(122, 23)
        Me.txt_kode.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(21, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 21)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Menggunakan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(58, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Kategori : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(82, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Kode : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(31, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Nama Alias?"
        '
        'txt_initial
        '
        Me.txt_initial.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_initial.Location = New System.Drawing.Point(152, 145)
        Me.txt_initial.Name = "txt_initial"
        Me.txt_initial.Size = New System.Drawing.Size(52, 23)
        Me.txt_initial.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(79, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Inisial : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orange
        Me.Label7.Location = New System.Drawing.Point(119, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 21)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = " : "
        '
        'cbb_WithAlias
        '
        Me.cbb_WithAlias.FormattingEnabled = True
        Me.cbb_WithAlias.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbb_WithAlias.Location = New System.Drawing.Point(152, 180)
        Me.cbb_WithAlias.Name = "cbb_WithAlias"
        Me.cbb_WithAlias.Size = New System.Drawing.Size(67, 21)
        Me.cbb_WithAlias.TabIndex = 76
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Orange
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(210, 253)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 33)
        Me.btn_cancel.TabIndex = 78
        Me.btn_cancel.Tag = "2"
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
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(294, 253)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(78, 33)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Tag = "1"
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Master_EditKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(384, 312)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.cbb_WithAlias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_initial)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_kategori)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Master_EditKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Kategori"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_kategori As System.Windows.Forms.TextBox
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_initial As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbb_WithAlias As System.Windows.Forms.ComboBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
End Class

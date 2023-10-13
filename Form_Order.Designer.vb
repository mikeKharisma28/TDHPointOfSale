<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Order
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
        Me.cbb_noMeja = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.cbb_kategori = New System.Windows.Forms.ComboBox()
        Me.dgv_barang = New System.Windows.Forms.DataGridView()
        Me.txt_kode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_lsvEdit = New System.Windows.Forms.TextBox()
        Me.btn_listOrder = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_tahanOrder = New System.Windows.Forms.Button()
        Me.lsv_order = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_freeStatus = New System.Windows.Forms.Label()
        Me.link_buyfree = New System.Windows.Forms.LinkLabel()
        Me.btn_transaksi = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_PPN = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_kembalian = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_nomor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_bayar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_item = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_subTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Orange
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 34)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Order"
        '
        'cbb_noMeja
        '
        Me.cbb_noMeja.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_noMeja.FormattingEnabled = True
        Me.cbb_noMeja.Location = New System.Drawing.Point(712, 64)
        Me.cbb_noMeja.Name = "cbb_noMeja"
        Me.cbb_noMeja.Size = New System.Drawing.Size(65, 24)
        Me.cbb_noMeja.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(517, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 14)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "No. Meja / Delivery Order :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(7, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "No. Order :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_search)
        Me.GroupBox2.Controls.Add(Me.cbb_kategori)
        Me.GroupBox2.Controls.Add(Me.dgv_barang)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(5, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 492)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txt_search.Location = New System.Drawing.Point(7, 44)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(287, 21)
        Me.txt_search.TabIndex = 62
        Me.txt_search.Text = "Search item here..."
        '
        'cbb_kategori
        '
        Me.cbb_kategori.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_kategori.FormattingEnabled = True
        Me.cbb_kategori.Location = New System.Drawing.Point(7, 13)
        Me.cbb_kategori.Name = "cbb_kategori"
        Me.cbb_kategori.Size = New System.Drawing.Size(201, 26)
        Me.cbb_kategori.TabIndex = 51
        '
        'dgv_barang
        '
        Me.dgv_barang.AllowUserToAddRows = False
        Me.dgv_barang.AllowUserToDeleteRows = False
        Me.dgv_barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_barang.BackgroundColor = System.Drawing.Color.White
        Me.dgv_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_barang.Location = New System.Drawing.Point(6, 71)
        Me.dgv_barang.Name = "dgv_barang"
        Me.dgv_barang.ReadOnly = True
        Me.dgv_barang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_barang.Size = New System.Drawing.Size(288, 402)
        Me.dgv_barang.TabIndex = 45
        '
        'txt_kode
        '
        Me.txt_kode.Enabled = False
        Me.txt_kode.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kode.Location = New System.Drawing.Point(94, 64)
        Me.txt_kode.Name = "txt_kode"
        Me.txt_kode.Size = New System.Drawing.Size(67, 21)
        Me.txt_kode.TabIndex = 58
        Me.txt_kode.Text = "O-000000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_lsvEdit)
        Me.GroupBox1.Controls.Add(Me.btn_listOrder)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_tahanOrder)
        Me.GroupBox1.Controls.Add(Me.lsv_order)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(311, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 492)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesanan"
        '
        'txt_lsvEdit
        '
        Me.txt_lsvEdit.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lsvEdit.Location = New System.Drawing.Point(127, 44)
        Me.txt_lsvEdit.Name = "txt_lsvEdit"
        Me.txt_lsvEdit.Size = New System.Drawing.Size(32, 21)
        Me.txt_lsvEdit.TabIndex = 53
        Me.txt_lsvEdit.Visible = False
        '
        'btn_listOrder
        '
        Me.btn_listOrder.BackColor = System.Drawing.Color.Orange
        Me.btn_listOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_listOrder.Enabled = False
        Me.btn_listOrder.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_listOrder.FlatAppearance.BorderSize = 0
        Me.btn_listOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_listOrder.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listOrder.ForeColor = System.Drawing.Color.Purple
        Me.btn_listOrder.Location = New System.Drawing.Point(90, 430)
        Me.btn_listOrder.Name = "btn_listOrder"
        Me.btn_listOrder.Size = New System.Drawing.Size(106, 43)
        Me.btn_listOrder.TabIndex = 51
        Me.btn_listOrder.Tag = "1"
        Me.btn_listOrder.Text = "List Tahan Order"
        Me.btn_listOrder.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Orange
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Purple
        Me.btn_delete.Location = New System.Drawing.Point(304, 430)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 33)
        Me.btn_delete.TabIndex = 45
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_tahanOrder
        '
        Me.btn_tahanOrder.BackColor = System.Drawing.Color.Orange
        Me.btn_tahanOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tahanOrder.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_tahanOrder.FlatAppearance.BorderSize = 0
        Me.btn_tahanOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tahanOrder.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tahanOrder.ForeColor = System.Drawing.Color.Purple
        Me.btn_tahanOrder.Location = New System.Drawing.Point(6, 430)
        Me.btn_tahanOrder.Name = "btn_tahanOrder"
        Me.btn_tahanOrder.Size = New System.Drawing.Size(78, 43)
        Me.btn_tahanOrder.TabIndex = 52
        Me.btn_tahanOrder.Tag = "2"
        Me.btn_tahanOrder.Text = "Tahan Order"
        Me.btn_tahanOrder.UseVisualStyleBackColor = False
        '
        'lsv_order
        '
        Me.lsv_order.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsv_order.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_order.FullRowSelect = True
        Me.lsv_order.Location = New System.Drawing.Point(6, 18)
        Me.lsv_order.Name = "lsv_order"
        Me.lsv_order.Size = New System.Drawing.Size(358, 406)
        Me.lsv_order.TabIndex = 54
        Me.lsv_order.UseCompatibleStateImageBehavior = False
        Me.lsv_order.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama"
        Me.ColumnHeader1.Width = 119
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Qty."
        Me.ColumnHeader2.Width = 35
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Harga"
        Me.ColumnHeader3.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Disc."
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Catatan"
        Me.ColumnHeader5.Width = 150
        '
        'lbl_freeStatus
        '
        Me.lbl_freeStatus.AutoSize = True
        Me.lbl_freeStatus.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_freeStatus.ForeColor = System.Drawing.Color.Orange
        Me.lbl_freeStatus.Location = New System.Drawing.Point(443, 609)
        Me.lbl_freeStatus.Name = "lbl_freeStatus"
        Me.lbl_freeStatus.Size = New System.Drawing.Size(12, 18)
        Me.lbl_freeStatus.TabIndex = 71
        Me.lbl_freeStatus.Text = "-"
        Me.lbl_freeStatus.Visible = False
        '
        'link_buyfree
        '
        Me.link_buyfree.AutoSize = True
        Me.link_buyfree.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_buyfree.LinkColor = System.Drawing.Color.Orange
        Me.link_buyfree.Location = New System.Drawing.Point(308, 600)
        Me.link_buyfree.Name = "link_buyfree"
        Me.link_buyfree.Size = New System.Drawing.Size(105, 18)
        Me.link_buyfree.TabIndex = 69
        Me.link_buyfree.TabStop = True
        Me.link_buyfree.Text = "Buy 1 Get 1 Free!"
        '
        'btn_transaksi
        '
        Me.btn_transaksi.BackColor = System.Drawing.Color.Orange
        Me.btn_transaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transaksi.Enabled = False
        Me.btn_transaksi.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_transaksi.FlatAppearance.BorderSize = 0
        Me.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transaksi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaksi.ForeColor = System.Drawing.Color.Purple
        Me.btn_transaksi.Location = New System.Drawing.Point(854, 593)
        Me.btn_transaksi.Name = "btn_transaksi"
        Me.btn_transaksi.Size = New System.Drawing.Size(92, 33)
        Me.btn_transaksi.TabIndex = 68
        Me.btn_transaksi.Tag = "1"
        Me.btn_transaksi.Text = "Transaksi"
        Me.btn_transaksi.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Orange
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.Purple
        Me.btn_next.Location = New System.Drawing.Point(571, 593)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(110, 47)
        Me.btn_next.TabIndex = 64
        Me.btn_next.Tag = ""
        Me.btn_next.Text = "Lanjut ke Transaksi"
        Me.btn_next.UseVisualStyleBackColor = False
        Me.btn_next.Visible = False
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
        Me.btn_cancel.Location = New System.Drawing.Point(770, 593)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(78, 33)
        Me.btn_cancel.TabIndex = 65
        Me.btn_cancel.Tag = "2"
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lbl_PPN)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lbl_kembalian)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_nomor)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_bayar)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lbl_item)
        Me.GroupBox3.Controls.Add(Me.lbl_total)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_disc)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_subTotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox3.Location = New System.Drawing.Point(685, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 492)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(233, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 14)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "%"
        '
        'lbl_PPN
        '
        Me.lbl_PPN.AutoSize = True
        Me.lbl_PPN.Location = New System.Drawing.Point(201, 146)
        Me.lbl_PPN.Name = "lbl_PPN"
        Me.lbl_PPN.Size = New System.Drawing.Size(25, 14)
        Me.lbl_PPN.TabIndex = 66
        Me.lbl_PPN.Text = "10"
        Me.lbl_PPN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 147)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "PPN :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(118, 368)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "IDR"
        '
        'lbl_kembalian
        '
        Me.lbl_kembalian.AutoSize = True
        Me.lbl_kembalian.Location = New System.Drawing.Point(160, 368)
        Me.lbl_kembalian.Name = "lbl_kembalian"
        Me.lbl_kembalian.Size = New System.Drawing.Size(13, 14)
        Me.lbl_kembalian.TabIndex = 63
        Me.lbl_kembalian.Text = "-"
        Me.lbl_kembalian.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Kembalian :"
        '
        'txt_nomor
        '
        Me.txt_nomor.Enabled = False
        Me.txt_nomor.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomor.Location = New System.Drawing.Point(118, 21)
        Me.txt_nomor.Name = "txt_nomor"
        Me.txt_nomor.Size = New System.Drawing.Size(111, 21)
        Me.txt_nomor.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Orange
        Me.Label11.Location = New System.Drawing.Point(6, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "No. Transaksi :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Bayar :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(118, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "IDR"
        '
        'txt_bayar
        '
        Me.txt_bayar.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bayar.Location = New System.Drawing.Point(157, 321)
        Me.txt_bayar.Name = "txt_bayar"
        Me.txt_bayar.Size = New System.Drawing.Size(72, 25)
        Me.txt_bayar.TabIndex = 56
        Me.txt_bayar.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Purple
        Me.Label8.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(42, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 30)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "IDR"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Purple
        Me.Label12.Font = New System.Drawing.Font("Gill Sans MT Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Orange
        Me.Label12.Location = New System.Drawing.Point(32, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 27)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "TOTAL :"
        '
        'lbl_item
        '
        Me.lbl_item.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item.ForeColor = System.Drawing.Color.Orange
        Me.lbl_item.Location = New System.Drawing.Point(200, 280)
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(39, 18)
        Me.lbl_item.TabIndex = 50
        Me.lbl_item.Text = "0 item"
        Me.lbl_item.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.BackColor = System.Drawing.Color.Purple
        Me.lbl_total.Font = New System.Drawing.Font("Gill Sans MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Orange
        Me.lbl_total.Location = New System.Drawing.Point(30, 222)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(225, 58)
        Me.lbl_total.TabIndex = 49
        Me.lbl_total.Text = "0"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "%"
        '
        'txt_disc
        '
        Me.txt_disc.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disc.Location = New System.Drawing.Point(156, 112)
        Me.txt_disc.Name = "txt_disc"
        Me.txt_disc.Size = New System.Drawing.Size(73, 21)
        Me.txt_disc.TabIndex = 5
        Me.txt_disc.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Diskon :"
        '
        'txt_subTotal
        '
        Me.txt_subTotal.Enabled = False
        Me.txt_subTotal.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subTotal.Location = New System.Drawing.Point(156, 79)
        Me.txt_subTotal.Name = "txt_subTotal"
        Me.txt_subTotal.Size = New System.Drawing.Size(73, 21)
        Me.txt_subTotal.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "IDR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sub Total :"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(255, 471)
        Me.ShapeContainer2.TabIndex = 59
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Orange
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 244
        Me.LineShape1.Y1 = 189
        Me.LineShape1.Y2 = 189
        '
        'btn_batal
        '
        Me.btn_batal.BackColor = System.Drawing.Color.Orange
        Me.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_batal.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_batal.FlatAppearance.BorderSize = 0
        Me.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_batal.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal.ForeColor = System.Drawing.Color.Purple
        Me.btn_batal.Location = New System.Drawing.Point(311, 600)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(60, 33)
        Me.btn_batal.TabIndex = 70
        Me.btn_batal.Tag = "2"
        Me.btn_batal.Text = "Cancel"
        Me.btn_batal.UseVisualStyleBackColor = False
        Me.btn_batal.Visible = False
        '
        'btn_done
        '
        Me.btn_done.BackColor = System.Drawing.Color.Orange
        Me.btn_done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_done.Enabled = False
        Me.btn_done.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.btn_done.FlatAppearance.BorderSize = 0
        Me.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_done.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.ForeColor = System.Drawing.Color.Purple
        Me.btn_done.Location = New System.Drawing.Point(377, 600)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(60, 33)
        Me.btn_done.TabIndex = 66
        Me.btn_done.Tag = "1"
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = False
        Me.btn_done.Visible = False
        '
        'txt_alamat
        '
        Me.txt_alamat.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_alamat.Location = New System.Drawing.Point(797, 66)
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(146, 21)
        Me.txt_alamat.TabIndex = 73
        Me.txt_alamat.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Orange
        Me.Label18.Location = New System.Drawing.Point(781, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 14)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "/"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Orange
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox4.Location = New System.Drawing.Point(-5, -9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(964, 67)
        Me.GroupBox4.TabIndex = 90
        Me.GroupBox4.TabStop = False
        '
        'Form_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(952, 656)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.lbl_freeStatus)
        Me.Controls.Add(Me.link_buyfree)
        Me.Controls.Add(Me.btn_transaksi)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_batal)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.cbb_noMeja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_kode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbb_noMeja As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_kategori As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_barang As System.Windows.Forms.DataGridView
    Friend WithEvents txt_kode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_lsvEdit As System.Windows.Forms.TextBox
    Friend WithEvents btn_listOrder As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_tahanOrder As System.Windows.Forms.Button
    Friend WithEvents lsv_order As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_freeStatus As System.Windows.Forms.Label
    Friend WithEvents link_buyfree As System.Windows.Forms.LinkLabel
    Friend WithEvents btn_transaksi As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_PPN As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_kembalian As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_nomor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_item As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_disc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_subTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_batal As System.Windows.Forms.Button
    Friend WithEvents btn_done As System.Windows.Forms.Button
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents txt_alamat As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
End Class

Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form_Order

#Region "Editable ListViewSubItems"
    Dim CurrentItem As ListViewItem
    Dim CurrentSB As ListViewItem.ListViewSubItem

    Private Sub lsv_order_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lsv_order.MouseDoubleClick
        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked

        CurrentItem = lsv_order.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub

        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked
        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 1, 3, 4

            Case Else
                MsgBox("This field is not editable!")
                Exit Sub
        End Select

        Dim lLeft = CurrentSB.Bounds.Left + 1
        Dim lWidth As Integer = CurrentSB.Bounds.Width - 1
        With txt_lsvEdit
            .SetBounds(lLeft + lsv_order.Left, CurrentSB.Bounds.Top + _
                       lsv_order.Top + 1, lWidth, CurrentSB.Bounds.Height - 1)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub lsv_order_KeyDown(sender As Object, e As KeyEventArgs) Handles lsv_order.KeyDown
        ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)
        Dim ee As New System.EventArgs
        If lsv_order.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lsv_order.SelectedItems(0), 2)
            Case Keys.Delete 'DEL key is pressed, initiate deleting the selected record
                e.Handled = True
                btn_delete_Click(sender, ee)
        End Select
        btn_next_Click(sender, ee)
    End Sub

    Private Sub BeginEditListItem(item As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = item.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, pt.X, pt.Y, 0)
        Call lsv_order_MouseDoubleClick(lsv_order, ee)
    End Sub

    Dim bCancelEdit As Boolean
    Private Sub txt_lsvEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lsvEdit.KeyPress
        ' This subroutine closes the text box

        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                txt_lsvEdit.Hide()
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                txt_lsvEdit.Hide()
        End Select
        btn_next_Click(sender, e)
    End Sub

    Private Sub txt_lsvEdit_LostFocus(sender As Object, e As EventArgs) Handles txt_lsvEdit.LostFocus
        txt_lsvEdit.Hide()
        If bCancelEdit = False Then
            ' update listviewitem
            CurrentSB.Text = txt_lsvEdit.Text
        Else
            ' Editing was cancelled by user
            bCancelEdit = False
        End If
        lsv_order.Focus()
        Call btn_next_Click(sender, e)
    End Sub
#End Region

#Region "Get Kategori Values"
    Private Function GetKategoriInitials()
        Dim Temp As String
        Dim CO_KATEGORI As New OleDbCommand
        Dim DR_KATEGORI As OleDbDataReader

        With CO_KATEGORI
            .Connection = CON_KASIR
            .CommandText = "SELECT Initials from tbKategori where ID = '" & Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & "'"
            .CommandType = CommandType.Text
        End With
        DR_KATEGORI = CO_KATEGORI.ExecuteReader
        DR_KATEGORI.Read()
        Temp = DR_KATEGORI.Item(0)
        DR_KATEGORI.Close()

        Return Temp
    End Function

    Private Function GetKategori()
        Dim Temp As String
        Dim CO_KATEGORI As New OleDbCommand
        Dim DR_KATEGORI As OleDbDataReader

        With CO_KATEGORI
            .Connection = CON_KASIR
            .CommandText = "SELECT Kategori from tbKategori where ID = '" & Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & "'"
            .CommandType = CommandType.Text
        End With
        DR_KATEGORI = CO_KATEGORI.ExecuteReader
        DR_KATEGORI.Read()
        Temp = DR_KATEGORI.Item(0)
        DR_KATEGORI.Close()

        Return Temp
    End Function

    Private Function GetKategoriKeterangan()
        Dim Temp As String
        Dim CO_KATEGORI As New OleDbCommand
        Dim DR_KATEGORI As OleDbDataReader

        With CO_KATEGORI
            .Connection = CON_KASIR
            .CommandText = "SELECT WithAlias from tbKategori where ID = '" & Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & "'"
            .CommandType = CommandType.Text
        End With
        DR_KATEGORI = CO_KATEGORI.ExecuteReader
        DR_KATEGORI.Read()
        Temp = DR_KATEGORI.Item(0)
        DR_KATEGORI.Close()

        Return Temp
    End Function
#End Region

#Region "Functions and Procedures"
    'PROCEDURES

    'Awal-awal program di load.
    'Menampilkan nomor meja didalam combo box meja
    Private Sub TampilNoMeja()
        Dim CO_SHOWMEJA As New OleDbCommand
        Dim DR_SHOWMEJA As OleDbDataReader
        With CO_SHOWMEJA
            .Connection = CON_KASIR
            .CommandText = "Select No_Meja from tbMeja where Kapasitas > 0"
            .CommandType = CommandType.Text
        End With
        DR_SHOWMEJA = CO_SHOWMEJA.ExecuteReader
        Do While DR_SHOWMEJA.Read()
            cbb_noMeja.Items.Add(DR_SHOWMEJA.Item(0))
        Loop
        DR_SHOWMEJA.Close()
    End Sub

    Private Sub Tampil_Data(temp As String)
        DS_BARANG.Clear()
        DA_BARANG = New OleDbDataAdapter("Select Kode_Barang as 'ID', " & _
                                         "Nama_Asli as 'Nama Asli', " & _
                                         "Nama_Alias as 'Nama Alias', " & _
                                         "Harga as 'Harga' from tbItem where Kode_Barang like '" & _
                                         temp & "-%' and Nama_Asli like '%'", CON_KASIR)
        DA_BARANG.Fill(DS_BARANG)
        DA_BARANG.Dispose()
        dgv_barang.DataSource = DS_BARANG.Tables(0)
    End Sub

    Private Sub Tampil_Data_Search(category As String, name As String)
        DS_BARANG.Clear()
        DA_BARANG = New OleDbDataAdapter("Select Kode_Barang as 'ID', " & _
                                         "Nama_Asli as 'Nama Asli', " & _
                                         "Nama_Alias as 'Nama Alias', " & _
                                         "Harga as 'Harga' from tbItem where Kode_Barang like '" & category & "-%' AND " & _
                                         "Nama_Asli like '%" & name & "%' OR Nama_Alias like '%" & name & "%'", CON_KASIR)
        DA_BARANG.Fill(DS_BARANG)
        DA_BARANG.Dispose()
        dgv_barang.DataSource = DS_BARANG.Tables(0)
    End Sub

    'Penomoran dipakai saat awal program dijalankan dan pada pengecekan. Menggunakan function luar CheckOrderOrTransaksi
    Private Sub Penomoran(tipe As Integer) 'Order = 0, Transaksi = 1
        Select Case tipe
            Case 0
                Dim NO As Integer = Val(Microsoft.VisualBasic.Right(CheckOrderOrTransaksi(0), 7)) + 1
                Dim Panjang As Integer = 7 - Trim(Str(NO)).Length
                Dim XNOMOR As String = NO
                For N As Integer = 1 To Panjang
                    XNOMOR = "0" & XNOMOR
                Next
                txt_kode.Text = "O-" & XNOMOR
            Case 1
                Dim NO As Integer = Val(Microsoft.VisualBasic.Right(CheckOrderOrTransaksi(1), 5)) + 1
                Dim Panjang As Integer = 5 - Trim(Str(NO)).Length
                Dim XNOMOR As String = NO
                Dim xkode As String() = Split(txt_nomor.Text, "-")
                For N As Integer = 1 To Panjang
                    XNOMOR = "0" & XNOMOR
                Next
                txt_nomor.Text = xkode(0) & "-" & XNOMOR
        End Select
    End Sub

    '========================================================================================================================
    'Procedures untuk form controls
    Sub Check_Pemesanan()
        If lsv_order.Items.Count = 0 Or txt_bayar.Text <= 0 Then
            btn_next.Enabled = False
            btn_transaksi.Enabled = False
        Else
            If (cbb_noMeja.Text = "-" Or cbb_noMeja.Text = "") And (txt_alamat.Text = "-" Or txt_alamat.Text = "") Then
                btn_next.Enabled = False
                btn_transaksi.Enabled = False
            Else
                btn_next.Enabled = True
                btn_transaksi.Enabled = True
            End If
        End If


    End Sub

    Private Sub CheckTahanList()
        Dim CO_TAHANORDER As New OleDbCommand
        Dim DR_TAHANORDER As OleDbDataReader

        With CO_TAHANORDER
            .Connection = CON_KASIR
            .CommandText = "Select No_Order from tbTahanOrder"
            .CommandType = CommandType.Text
        End With
        DR_TAHANORDER = CO_TAHANORDER.ExecuteReader
        DR_TAHANORDER.Read()
        If DR_TAHANORDER.HasRows Then
            btn_listOrder.Enabled = True
        Else
            btn_listOrder.Enabled = False
        End If
        DR_TAHANORDER.Close()
    End Sub 'procedure ini berhubungan dengan database

    Sub Clear_View()
        Tampil_Data("F")
        cbb_kategori.SelectedIndex = 0
        lsv_order.Items.Clear()
        txt_subTotal.Text = Nothing
        txt_disc.Text = 0
        txt_bayar.Text = 0
        cbb_noMeja.Text = Nothing
        txt_alamat.Text = "-"
        cbb_noMeja.Focus()
        lbl_kembalian.Text = "-"
        lbl_total.Text = "0"
        lbl_item.Text = "0 item"
    End Sub
    '========================================================================================================================

    'Procedures yang berhubungan dengan database
    Dim oldKode As String
    Private Sub Pemesanan()
        Try
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "UPDATE tbOrder set No_Meja = '" & cbb_noMeja.Text & " // " & txt_alamat.Text & _
                               "', Tgl_Order = '" & CStr(Date.Today) & _
                               " " & CStr(DateAndTime.TimeOfDay) & "' " & "where No_Order = '" & txt_kode.Text & "'"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()

            Dim i As Integer = 0
            While i <> lsv_order.Items.Count
                With CO_ORDER
                    .Connection = CON_KASIR
                    .CommandText = "INSERT into tbSubOrder values('" & txt_kode.Text & "', '" & CodePicker(lsv_order.Items(i).Text) & _
                                   "', " & lsv_order.Items(i).SubItems(1).Text & ", " & lsv_order.Items(i).SubItems(3).Text & ", '" & _
                                   lsv_order.Items(i).SubItems(4).Text & "')"
                    .CommandType = CommandType.Text
                End With
                DR_ORDER = CO_ORDER.ExecuteReader
                DR_ORDER.Close()
                i += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Pembaharuan no order
        Try
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "UPDATE tbOrder set No_Meja = '" & cbb_noMeja.Text & "', Tgl_Order = '" & CStr(Date.Today) & _
                               " " & CStr(DateAndTime.TimeOfDay) & "' " & "where No_Order = '" & txt_kode.Text & "'"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()

            Call DeleteRecordTahanOrder(txt_kode.Text)
            oldKode = txt_kode.Text

            Call Penomoran(0)
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "Insert into tbOrder (No_Order) values('" & txt_kode.Text & "')"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Transaksi()
        Try
            With CO_TRANSAKSI
                .Connection = CON_KASIR
                .CommandText = "UPDATE tbTransaksi set No_Order = '" & oldKode & "', Tgl_Transaksi = '" & CStr(Date.Today) & _
                               " " & CStr(DateAndTime.TimeOfDay) & "', Sub_Total = " & CDbl(txt_subTotal.Text) & _
                               ", Diskon = " & CDbl(txt_disc.Text) & ", Grand_Total = " & CDbl(lbl_total.Text) & _
                               " where ID = '" & tempID & "'"
                .CommandType = CommandType.Text
            End With
            DR_TRANSAKSI = CO_TRANSAKSI.ExecuteReader
            DR_TRANSAKSI.Close()
            oldKode = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Pembaharuan No. Transaksi
        Try
            Call Penomoran(1)
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "Insert into tbTransaksi (ID, No_Transaksi) values('" & IDGenerator() & "', '" & txt_nomor.Text & "')"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Call FormAnimateOut()
        Counter_Order = 0
        txt_kode.Text = UseOldKode()
        Call DeleteUnusedRecord()
        Call Clear_View()
        Call Check_Pemesanan()
        Call CheckTahanList()
    End Sub

    Private Sub TahanOrder()
        Try
            Dim i As Integer = 0
            While i <> lsv_order.Items.Count
                With CO_ORDER
                    .Connection = CON_KASIR
                    'Urutan TahanOrder database: No_Order, No_Meja, Kode_Barang, Nama_Barang, Jumlah_Barang, Diskon, Harga, Tgl_Order, Catatan
                    .CommandText = "INSERT into tbTahanOrder values('" & txt_kode.Text & "', '" & cbb_noMeja.Text & " // " & txt_alamat.Text & "', '" & _
                                   CodePicker(lsv_order.Items(i).Text) & "', '" & NamePicker(lsv_order.Items(i).Text) & _
                                   "', " & lsv_order.Items(i).SubItems(1).Text & ", " & lsv_order.Items(i).SubItems(3).Text & _
                                   ", " & lsv_order.Items(i).SubItems(2).Text & ", '" & CStr(Date.Today) & " " & CStr(DateAndTime.TimeOfDay) & _
                                   "', '" & lsv_order.Items(i).SubItems(4).Text & "')"
                    .CommandType = CommandType.Text
                End With
                DR_ORDER = CO_ORDER.ExecuteReader
                DR_ORDER.Close()
                i += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call Check_Pemesanan()
        Call CheckTahanList()
        Try
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "UPDATE tbOrder set No_Meja = '" & cbb_noMeja.Text & "', Tgl_Order = '" & CStr(Date.Today) & _
                               " " & CStr(DateAndTime.TimeOfDay) & "' " & "where No_Order = '" & txt_kode.Text & "'"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()

            Call Penomoran(0)
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "Insert into tbOrder (No_Order) values('" & txt_kode.Text & "')"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lsv_order.Items.Clear()
        Counter_Order = 0
        cbb_noMeja.Text = Nothing
        cbb_noMeja.Focus()

        Call CheckTahanList()
    End Sub

    Private Sub DeleteRecordTahanOrder(value As String)
        Dim CO_DELETERECORD As New OleDbCommand
        Dim DR_DELETERECORD As OleDbDataReader

        With CO_DELETERECORD
            .Connection = CON_KASIR
            .CommandText = "DELETE * FROM tbTahanOrder where No_Order = '" & value & "'"
            .CommandType = CommandType.Text
        End With
        DR_DELETERECORD = CO_DELETERECORD.ExecuteReader
        DR_DELETERECORD.Close()
    End Sub 'Penghapusan record-record TahanOrder yang sudah di bayar / dilakukan transaksi

    Private Sub DeleteUnusedRecord()
        Dim CO_DELETERECORD As New OleDbCommand
        Dim DR_DELETERECORD As OleDbDataReader

        With CO_DELETERECORD
            .Connection = CON_KASIR
            .CommandText = "DELETE * FROM tbOrder where No_Meja is NULL"
            .CommandType = CommandType.Text
        End With
        DR_DELETERECORD = CO_DELETERECORD.ExecuteReader
        DR_DELETERECORD.Close()

        With CO_DELETERECORD
            .Connection = CON_KASIR
            .CommandText = "Insert into tbOrder (No_Order) values('" & txt_kode.Text & "')"
            .CommandType = CommandType.Text
        End With
        DR_DELETERECORD = CO_DELETERECORD.ExecuteReader
        DR_DELETERECORD.Close()
    End Sub

    Private Sub PrintNotaDatabase()
        Dim CO_PRINTNOTA As New OleDbCommand
        Dim DR_PRINTNOTA As OleDbDataReader

        Dim i As Integer = 0
        While i <> lsv_order.Items.Count
            With CO_PRINTNOTA
                .Connection = CON_KASIR
                .CommandText = "INSERT into tbSubPrintNota values('" & tempID & "', '" & CodePicker(lsv_order.Items(i).Text) & _
                               "', '" & NamePicker(lsv_order.Items(i).Text) & _
                               "', " & lsv_order.Items(i).SubItems(1).Text & ", " & lsv_order.Items(i).SubItems(2).Text & _
                               ", " & lsv_order.Items(i).SubItems(3).Text & ")"
                .CommandType = CommandType.Text
            End With
            DR_PRINTNOTA = CO_PRINTNOTA.ExecuteReader
            DR_PRINTNOTA.Close()
            i += 1
        End While

        With CO_PRINTNOTA
            .Connection = CON_KASIR
            .CommandText = "INSERT into tbPrintNota values('" & tempID & "', '" & txt_nomor.Text & "', '" & cbb_noMeja.Text & " // " & txt_alamat.Text & _
                           "', '" & CStr(Date.Today) & " " & CStr(DateAndTime.TimeOfDay) & _
                           "', " & txt_disc.Text & ", " & txt_bayar.Text & ")"
            .CommandType = CommandType.Text
        End With
        DR_PRINTNOTA = CO_PRINTNOTA.ExecuteReader
        DR_PRINTNOTA.Close()
    End Sub

    Private Sub PrintNota(check As Boolean, value As String)
        Dim CrTables As Tables
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Try
            'reportdoc object
            Dim cryRpt As New ReportDocument

            'load report
            cryRpt.Load(Application.StartupPath & "\PrintNota.rpt")

            'parameters definition(if any)

            'provide connection info. This is important and you can change it as per your db location
            With crConnectionInfo
                .ServerName = Application.StartupPath & "\TDHDatabase.accdb"
            End With

            CrTables = cryRpt.Database.Tables
            For Each CrTable As Table In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            cryRpt.Refresh()
            cryRpt.SetParameterValue("No Transaksi", value)
            If check = False Then
                cryRpt.Refresh()
                cryRpt.SetParameterValue("No Transaksi", value)
            End If
            'FormForTest.CrystalReportViewer1.Refresh()
            'FormForTest.CrystalReportViewer1.ReportSource = cryRpt
            'cryRpt.ReportClientDocument.PrintOutputController.PrintReport()
            'FormForTest.ShowDialog()
            cryRpt.PrintToPrinter(1, False, 0, 0)

            cryRpt.Dispose()
            'CrTables.Dispose()
            'crtableLogoninfo = Nothing
            'crConnectionInfo = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '========================================================================================================================
    '========================================================================================================================
    'FUNCTIONS
    Private Function CheckPrintNota(value As String)
        Dim output As Boolean
        Dim CO_PRINTNOTA As New OleDbCommand
        Dim DR_PRINTNOTA As OleDbDataReader

        With CO_PRINTNOTA
            .Connection = CON_KASIR
            .CommandText = "SELECT * from tbSubPrintNota Where ID = '" & value & "'"
            .CommandType = CommandType.Text
        End With
        DR_PRINTNOTA = CO_PRINTNOTA.ExecuteReader
        If DR_PRINTNOTA.HasRows Then
            output = True
        Else
            output = False
        End If
        DR_PRINTNOTA.Close()
        Return output
    End Function

    Private Function CheckOrderOrTransaksi(tipe As Integer) 'Order = 0, Transaksi = 1
        Dim Output As String
        Dim CO_ORDERORTRANSAKSI As New OleDbCommand
        Dim DR_ORDERORTRANSAKSI As OleDbDataReader

        With CO_ORDERORTRANSAKSI
            .Connection = CON_KASIR
            Select Case tipe
                Case 0
                    .CommandText = "SELECT No_Order from tbOrder Where No_Order like 'O-%' order by No_Order desc"
                Case 1
                    .CommandText = "SELECT No_Transaksi from tbTransaksi Where No_Transaksi like '%-%' order by ID desc"
            End Select
            .CommandType = CommandType.Text
        End With
        DR_ORDERORTRANSAKSI = CO_ORDERORTRANSAKSI.ExecuteReader
        DR_ORDERORTRANSAKSI.Read()
        Output = DR_ORDERORTRANSAKSI.Item(0)
        DR_ORDERORTRANSAKSI.Close()

        Return Output
    End Function

    Private Function CheckTahanItem(value As String)
        Dim CO_TAHANORDER As New OleDbCommand
        Dim DR_TAHANORDER As OleDbDataReader
        Dim IsTrue As Boolean

        With CO_TAHANORDER
            .Connection = CON_KASIR
            .CommandText = "Select No_Order from tbTahanOrder where No_Order = '" & value & "'"
            .CommandType = CommandType.Text
        End With
        DR_TAHANORDER = CO_TAHANORDER.ExecuteReader
        DR_TAHANORDER.Read()

        If DR_TAHANORDER.HasRows Then
            IsTrue = True
        Else
            IsTrue = False
        End If
        DR_TAHANORDER.Close()

        Return IsTrue
    End Function

    'untuk menghitung sub total
    Private Function HitungSubTotal()
        Dim subTotal As Double
        For i As Integer = 0 To lsv_order.Items.Count - 1
            subTotal += (CDbl(lsv_order.Items(i).SubItems(1).Text) * CDbl(lsv_order.Items(i).SubItems(2).Text)) - _
                        ((CDbl(lsv_order.Items(i).SubItems(1).Text) * CDbl(lsv_order.Items(i).SubItems(2).Text)) * _
                        (CDbl(lsv_order.Items(i).SubItems(3).Text) / 100))
        Next
        Return subTotal
    End Function

    Private Function UseOldKode()
        Dim Output As String
        Dim CO_USEOLDKODE As New OleDbCommand
        Dim DR_USEOLDKODE As OleDbDataReader

        With CO_USEOLDKODE
            .Connection = CON_KASIR
            .CommandText = "SELECT No_Order from tbOrder Where No_Order like 'O-%' And No_Meja is NULL order by No_Order asc"
            .CommandType = CommandType.Text
        End With
        DR_USEOLDKODE = CO_USEOLDKODE.ExecuteReader
        DR_USEOLDKODE.Read()

        Output = DR_USEOLDKODE.Item(0)
        DR_USEOLDKODE.Close()

        Return Output
    End Function

    Private Function CodePicker(strings As String)
        Dim kode As String() = strings.Split(New String() {" - "}, StringSplitOptions.None)
        Return kode(0)
    End Function

    Private Function NamePicker(strings As String)
        Dim nama As String() = strings.Split(New String() {" - "}, StringSplitOptions.None)
        Return nama(1)
    End Function

#End Region

#Region "Events"
    Dim BRS As Integer
    Dim XKODE As String
    Dim XASLI As String
    Dim XALIAS As String
    Private Sub dgv_barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_barang.CellClick
        BRS = dgv_barang.SelectedRows(0).Index
        XKODE = dgv_barang.Rows(BRS).Cells(0).Value

        'Memasukkan barang ke dalam lsv_order
        Try
            With CO_BARANG
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbItem where Kode_Barang = '" & XKODE & "'"
                .CommandType = CommandType.Text
            End With
            DR_BARANG = CO_BARANG.ExecuteReader
            DR_BARANG.Read()
            With lsv_order
                If DR_BARANG.Item(3) = "-" Then
                    .Items.Add(XKODE & " - " & DR_BARANG.Item(2))
                    '.Items.Add(DR_BARANG.Item(2))
                Else
                    .Items.Add(XKODE & " - " & DR_BARANG.Item(3) & " (" & DR_BARANG.Item(2) & ")")
                    '.Items.Add(DR_BARANG.Item(3) & " (" & DR_BARANG.Item(2) & ")")
                End If
                .Items(Counter_Order).Group = .Groups(DR_BARANG.Item(1))
                .Items(Counter_Order).SubItems.Add(1)
                .Items(Counter_Order).SubItems.Add(DR_BARANG.Item(5))
                .Items(Counter_Order).SubItems.Add(0)
                .Items(Counter_Order).SubItems.Add("-")
            End With
            Counter_Order += 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DR_BARANG.Close()
        Call Check_Pemesanan()
        btn_next_Click(sender, e)
    End Sub

    Private Sub cbb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_kategori.SelectedIndexChanged
        Call Tampil_Data(GetKategoriInitials())
    End Sub

    'Event untuk txt_search
    '========================================================================================================================
    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        If e.KeyChar = Chr(13) Then
            If txt_search.Text = "" Then
                Tampil_Data(GetKategoriInitials())
            Else
                Tampil_Data_Search(GetKategoriInitials(), txt_search.Text)
            End If
        End If
    End Sub

    Private Sub txt_search_LostFocus(sender As Object, e As EventArgs) Handles txt_search.LostFocus
        If txt_search.Text = "" Then
            txt_search.Text = "Search item here..."
            txt_search.ForeColor = Color.Gray
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_search_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_search.MouseClick
        If txt_search.Text = "Search item here..." Then
            txt_search.Text = Nothing
        Else
            txt_search.SelectAll()
        End If
        txt_search.ForeColor = Color.Black
    End Sub

    'Event untuk txt_alamat
    '========================================================================================================================
    Private Sub txt_alamat_TextChanged(sender As Object, e As EventArgs) Handles txt_alamat.TextChanged
        Call Check_Pemesanan()
    End Sub

    Private Sub txt_alamat_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_alamat.MouseClick
        If txt_alamat.Text = "-" Then
            txt_alamat.Text = ""
        Else
            txt_alamat.SelectAll()
        End If
    End Sub

    Private Sub txt_alamat_LostFocus(sender As Object, e As EventArgs) Handles txt_alamat.LostFocus
        If txt_alamat.Text = "" Then
            txt_alamat.Text = "-"
        End If
        Call Check_Pemesanan()
    End Sub

    'btn_next tidak ditampilkan, namun dipanggil secara manual tanpa menggunakan mouse click
    Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        'Untuk menghitung subtotal dari item yang diambil / dipilih
        Try
            txt_subTotal.Text = CStr(HitungSubTotal())
            lbl_total.Text = CStr(CDbl(txt_subTotal.Text) + (CDbl(txt_subTotal.Text) * (CDbl(lbl_PPN.Text) / 100)))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Cek No. Transaksi
        Try
            With CO_TRANSAKSI
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbTransaksi where No_Transaksi like '%-%' order by ID desc"
                .CommandType = CommandType.Text
            End With
            DR_TRANSAKSI = CO_TRANSAKSI.ExecuteReader
            DR_TRANSAKSI.Read()
            If DR_TRANSAKSI.HasRows Then
                txt_nomor.Text = DR_TRANSAKSI.Item(1)
                DR_TRANSAKSI.Close()
            Else
                txt_nomor.Text = "T-0000000"
                DR_TRANSAKSI.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Menampilkan jumlah item
        Dim Tmp As Integer = 0
        For i As Integer = 0 To lsv_order.Items.Count - 1
            Tmp += CStr(lsv_order.Items(i).SubItems(1).Text)
        Next
        lbl_item.Text = Tmp & " item"
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        For Each i As ListViewItem In lsv_order.SelectedItems
            lsv_order.Items.Remove(i)
        Next

        Counter_Order = lsv_order.Items.Count
        Call Check_Pemesanan()
        btn_next_Click(sender, e)
    End Sub

    Private Sub btn_transaksi_Click(sender As Object, e As EventArgs) Handles btn_transaksi.Click
        Try
            tempID = GetID()
            Me.Cursor = Cursors.WaitCursor
            Select Case MsgBox("Transaksi akan dilakukan. Lanjut dengan print nota?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.Yes
                    Dim tempKodeOrder As String = txt_kode.Text
                    Call PrintNotaDatabase()
                    Call PrintNota(CheckPrintNota(tempID), tempID)

                    Call Pemesanan()
                    Call Transaksi()

                    lsv_order.Items.Clear()
                    Counter_Order = 0
                    cbb_noMeja.Text = Nothing
                    cbb_noMeja.Focus()

                    If btn_listOrder.Enabled = True Then
                        Call DeleteRecordTahanOrder(tempKodeOrder)
                    End If

                    tempKodeOrder = Nothing
                Case MsgBoxResult.No
                    Dim tempKodeOrder As String = txt_kode.Text
                    Call PrintNotaDatabase()

                    Call Pemesanan()
                    Call Transaksi()

                    lsv_order.Items.Clear()
                    Counter_Order = 0
                    cbb_noMeja.Text = Nothing
                    cbb_noMeja.Focus()

                    If btn_listOrder.Enabled = True Then
                        Call DeleteRecordTahanOrder(tempKodeOrder)
                    End If

                    tempKodeOrder = Nothing
                Case MsgBoxResult.Cancel
                    Me.Show()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_tahanOrder_Click(sender As Object, e As EventArgs) Handles btn_tahanOrder.Click
        If cbb_noMeja.Text = "" Or lsv_order.Items.Count = 0 Then
            If cbb_noMeja.Text = "" Then
                MsgBox("Isikan nomor meja terlebih dahulu.")
            Else
                MsgBox("Isikan item yang dipesan")
            End If
        ElseIf CheckTahanItem(txt_kode.Text) = False Then
            Call TahanOrder()
        ElseIf CheckTahanItem(txt_kode.Text) = True Then
            Call DeleteRecordTahanOrder(txt_kode.Text)
            Call TahanOrder()
        End If
        Call Clear_View()
        btn_next_Click(sender, e)
    End Sub

    Private Sub btn_listOrder_Click(sender As Object, e As EventArgs) Handles btn_listOrder.Click
        Order_TahanOrderList.ShowDialog()
    End Sub

    Private Sub txt_disc_TextChanged(sender As Object, e As EventArgs) Handles txt_disc.TextChanged
        If IsNumeric(txt_disc.Text) = True And txt_subTotal.Text <> "" Then
            Dim tempTotal As Double = CDbl(txt_subTotal.Text) - (CDbl(txt_subTotal.Text) * (CDbl(txt_disc.Text) / 100))
            lbl_total.Text = CStr(tempTotal + (CDbl(tempTotal) * (CDbl(lbl_PPN.Text) / 100)))
        ElseIf IsNumeric(txt_disc.Text) = True And txt_subTotal.Text = "" Then
            Exit Sub
        ElseIf txt_disc.Text = "" Then
            lbl_total.Text = CStr(CDbl(txt_subTotal.Text) + (CDbl(txt_subTotal.Text) * (CDbl(lbl_PPN.Text) / 100)))
            txt_disc.Text = "0"
        End If
    End Sub

    Private Sub txt_bayar_TextChanged(sender As Object, e As EventArgs) Handles txt_bayar.TextChanged
        If txt_bayar.Text = "" Then
            txt_bayar.Text = "0"
        End If
        Try
            lbl_kembalian.Text = CStr(CDbl(txt_bayar.Text - lbl_total.Text))
            If CDbl(lbl_kembalian.Text) >= 0 Then
                btn_transaksi.Enabled = True
                Check_Pemesanan()
            ElseIf CDbl(lbl_kembalian.Text) < 0 And txt_bayar.Text = "" Then
                btn_transaksi.Enabled = False
                Check_Pemesanan()
            End If
        Catch ex As Exception
            btn_transaksi.Enabled = False
        End Try
    End Sub

    Private Sub cbb_noMeja_LostFocus(sender As Object, e As EventArgs) Handles cbb_noMeja.LostFocus
        If cbb_noMeja.Text = "" Then
            cbb_noMeja.Text = "-"
        End If
        Call Check_Pemesanan()
    End Sub

    Private Sub cbb_noMeja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_noMeja.SelectedIndexChanged
        Call Check_Pemesanan()
    End Sub

    Private Sub cbb_noMeja_TextChanged(sender As Object, e As EventArgs) Handles cbb_noMeja.TextChanged
        Call Check_Pemesanan()
    End Sub

    Private Sub Form_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Call TampilNoMeja()
        'Kategori
        cbb_kategori.Items.Clear()
        Try
            Dim CO_KATEGORI As New OleDbCommand
            Dim DR_KATEGORI As OleDbDataReader

            With CO_KATEGORI
                .Connection = CON_KASIR
                .CommandText = "SELECT ID, Kategori from tbKategori where Kategori like '%' order by ID asc"
                .CommandType = CommandType.Text
            End With
            DR_KATEGORI = CO_KATEGORI.ExecuteReader
            Dim i As Integer = 0
            Do While DR_KATEGORI.Read()
                cbb_kategori.Items.Add("" & DR_KATEGORI.Item(0) & " - " & DR_KATEGORI.Item(1))
                i += 1
            Loop
            DR_KATEGORI.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        cbb_noMeja.Focus()
        cbb_kategori.SelectedIndex = 0
        Tampil_Data("F")

        'Cek No. Order
        Try
            With CO_ORDER
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbOrder where No_Order like 'O-%' order by No_Order desc"
                .CommandType = CommandType.Text
            End With
            DR_ORDER = CO_ORDER.ExecuteReader
            DR_ORDER.Read()
            If DR_ORDER.HasRows Then
                txt_kode.Text = DR_ORDER.Item(0)
                DR_ORDER.Close()
            Else
                txt_kode.Text = "O-000000"
                DR_ORDER.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Menampilkan group kategori pada lsv_order
        Try
            Dim CO_KATEGORI As New OleDbCommand
            Dim DR_KATEGORI As OleDbDataReader
            Dim i As Integer = 0

            lsv_order.Groups.Add("BF-0", "Buy 1 Get 1 Free")
            With CO_KATEGORI
                .Connection = CON_KASIR
                .CommandText = "SELECT ID, Kategori from tbKategori where Initials like '%'"
                .CommandType = CommandType.Text
            End With
            DR_KATEGORI = CO_KATEGORI.ExecuteReader
            Do While DR_KATEGORI.Read()
                With lsv_order
                    .Groups.Add(DR_KATEGORI.Item(0), DR_KATEGORI.Item(1))
                End With
            Loop
            DR_KATEGORI.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Check_Pemesanan()
        Call CheckTahanList()
        btn_next_Click(sender, e)
    End Sub

    Private Sub Form_Order_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        DS_BARANG.Reset()
        Counter_Order = 0

        Menu_Utama_Kasir.Show()
    End Sub

#End Region

#Region "Buy 1 Get 1 Free"
    Private Sub ControlsDisabled(value As Boolean)
        Select Case value
            Case True
                GroupBox2.Enabled = False
                cbb_noMeja.Enabled = False
                btn_listOrder.Enabled = False
                btn_tahanOrder.Enabled = False
                btn_next.Enabled = False
                btn_delete.Enabled = False

                Me.BackColor = Color.FromArgb(64, 0, 64)
                Label12.BackColor = Color.FromArgb(64, 0, 64)
                Label8.BackColor = Color.FromArgb(64, 0, 64)
                lbl_total.BackColor = Color.FromArgb(64, 0, 64)

                link_buyfree.Hide()
                btn_done.Show()
                btn_batal.Show()
                lbl_freeStatus.Show()
            Case False
                GroupBox2.Enabled = True
                cbb_noMeja.Enabled = True
                btn_listOrder.Enabled = True
                btn_tahanOrder.Enabled = True
                btn_next.Enabled = True
                btn_delete.Enabled = True

                Me.BackColor = Color.Purple
                Label12.BackColor = Color.Purple
                Label8.BackColor = Color.Purple
                lbl_total.BackColor = Color.Purple

                link_buyfree.Show()
                btn_done.Hide()
                btn_batal.Hide()
                lbl_freeStatus.Hide()
                Call Check_Pemesanan()
                Call CheckTahanList()
        End Select
    End Sub

    Private Sub link_buyfree_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_buyfree.LinkClicked
        'kalo udah dicek dari awal.
        For i As Integer = 0 To lsv_order.Items.Count - 1
            If lsv_order.Items(i).Checked = True Then
                lsv_order.Items(i).BackColor = Color.LightGray
            End If
        Next

        lbl_freeStatus.Text = (2 - checkedItemsCount()) & " items left"
        lsv_order.CheckBoxes = True
        ControlsDisabled(True)
        lsv_order.Focus()
    End Sub

    Private Sub CompareItemBuyFree(value1 As ListViewItem, value2 As ListViewItem)
        Dim temp As New ListViewItem
        Dim free As New ListViewItem
        If CDbl(value1.SubItems(2).Text) < CDbl(value2.SubItems(2).Text) Then
            free = value1
            temp = value2
        Else
            temp = value1
            free = value2
        End If
        For i As Integer = 0 To lsv_order.Items.Count - 1
            If lsv_order.Items(i).Text = free.Text And lsv_order.Items(i).BackColor <> Color.LightGray Then
                lsv_order.Items(i).SubItems(3).Text = "100"
                lsv_order.Items(i).SubItems(4).Text = "Dibundle dengan " & NamePicker(temp.Text)
            End If
        Next

        temp = Nothing
        free = Nothing
    End Sub

    Sub DoSortingAfterComparing(value1 As ListViewItem, value2 As ListViewItem)
        '2 item ditaruh diatas setelah dibandingkan dan diubah keterangannya
        'yang paling mahal diatas
        'yang paling murah dibawah setelah yang paling mahal
        'ditaruh paling atas, kalau sudah ada ditaruh dibawahnya
        'yg lainnya diturunkan semua
        Dim tempListView As New ListView
        Dim temp As New ListViewItem
        Dim free As New ListViewItem
        If CDbl(value1.SubItems(2).Text) < CDbl(value2.SubItems(2).Text) Then
            free = value1
            temp = value2
        Else
            temp = value1
            free = value2
        End If

        For Each item As ListViewItem In lsv_order.Items
            tempListView.Items.Add(item.Clone)
        Next

        For Each item As ListViewItem In tempListView.Items
            If item.Text = free.Text Then
                tempListView.Items(item.Index).Remove()
            End If
        Next

        For Each item As ListViewItem In tempListView.Items
            If item.Text = temp.Text Then
                tempListView.Items(item.Index).Remove()
            End If
        Next

        lsv_order.Items.Clear()
        lsv_order.Items.Add(temp.Clone())
        lsv_order.Items.Add(free.Clone())
        For Each item As ListViewItem In tempListView.Items
            lsv_order.Items.Add(item.Clone)
        Next

        For Each item As ListViewItem In lsv_order.Items
            If item.Text = temp.Text Then
                lsv_order.Items(item.Index).Checked = True
                lsv_order.Items(item.Index).Group = lsv_order.Groups("BF-0")
            End If
        Next

        For Each item As ListViewItem In lsv_order.Items
            If item.Text = free.Text Then
                lsv_order.Items(item.Index).Checked = True
                lsv_order.Items(item.Index).Group = lsv_order.Groups("BF-0")
            End If
        Next

    End Sub

    Private Function checkedItemsCount()
        Dim count As Integer = 0

        For i As Integer = 0 To lsv_order.Items.Count - 1
            If lsv_order.Items(i).Checked And lsv_order.Items(i).BackColor <> Color.LightGray Then
                count += 1
            End If
        Next

        Return count
    End Function

    Private Sub lsv_order_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lsv_order.ItemChecked
        Dim itemsheader(1) As String
        Dim j As Integer = 0

        Select Case checkedItemsCount()
            Case 0
                lbl_freeStatus.Text = (2 - checkedItemsCount()) & " items left"
                btn_done.Enabled = False
            Case 1
                lbl_freeStatus.Text = (2 - checkedItemsCount()) & " item left"
                btn_done.Enabled = False
            Case 2
                For i As Integer = 0 To lsv_order.CheckedItems.Count - 1
                    If lsv_order.CheckedItems(i).BackColor <> Color.LightGray Then
                        itemsheader(j) = lsv_order.CheckedItems(i).Group.Header.ToString
                        j += 1
                    End If

                    If itemsheader(0) <> itemsheader(1) Then
                        lbl_freeStatus.Text = "Both items should be in the same group!"
                        btn_done.Enabled = False
                    Else
                        lbl_freeStatus.Text = "All set!"
                        btn_done.Enabled = True
                    End If
                Next
            Case Else
                lbl_freeStatus.Text = "This feature is only for two items!"
                btn_done.Enabled = False
        End Select
    End Sub

    Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click, btn_batal.Click
        Dim items(1) As ListViewItem
        Select Case sender.tag
            Case 1
                Dim j As Integer = 0
                For i As Integer = 0 To lsv_order.Items.Count - 1
                    If lsv_order.Items(i).Checked = True And lsv_order.Items(i).BackColor <> Color.LightGray Then
                        items(j) = lsv_order.Items(i)
                        j += 1
                    End If
                Next
                CompareItemBuyFree(items(0), items(1))
                ControlsDisabled(False)
                lsv_order.CheckBoxes = False
                For i As Integer = 0 To lsv_order.Items.Count - 1
                    If lsv_order.Items(i).BackColor = Color.LightGray Then
                        lsv_order.Items(i).BackColor = Color.White
                    End If
                Next
                DoSortingAfterComparing(items(0), items(1))
                items = Nothing
                btn_next_Click(sender, e)
            Case 2
                For i As Integer = 0 To lsv_order.Items.Count - 1
                    If lsv_order.Items(i).Checked = True Then
                        If lsv_order.Items(i).BackColor <> Color.LightGray Then
                            lsv_order.Items(i).Checked = False
                        End If
                    End If
                Next
                ControlsDisabled(False)
                lsv_order.CheckBoxes = False
                For i As Integer = 0 To lsv_order.Items.Count - 1
                    If lsv_order.Items(i).BackColor = Color.LightGray Then
                        lsv_order.Items(i).BackColor = Color.White
                    End If
                Next
                items = Nothing
        End Select
    End Sub
#End Region

End Class
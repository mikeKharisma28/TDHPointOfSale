Imports System.Data
Imports System.Data.OleDb

Public Class Master_Edit
    Private Sub Tampil_Data(temp As String)
        DS_BARANG.Clear()
        DA_BARANG = New OleDbDataAdapter("Select Kode_Barang as 'ID', " &
                                         "Nama_Asli as 'Nama Asli', " &
                                         "Nama_Alias as 'Nama Alias', " &
                                         "Deskripsi as 'Deskripsi', " &
                                         "Harga as 'Harga'" & " from tbItem where Kode_Barang like '" &
                                         temp & "-%' and Nama_Asli like '%'", CON_KASIR)
        DA_BARANG.Fill(DS_BARANG)
        DA_BARANG.Dispose()
        dgv_barang.DataSource = DS_BARANG.Tables(0)
    End Sub

    Private Sub Tampil_Data_Search(category As String, name As String)
        DS_BARANG.Clear()
        DA_BARANG = New OleDbDataAdapter("Select Kode_Barang as 'ID', " &
                                         "Nama_Asli as 'Nama Asli', " &
                                         "Nama_Alias as 'Nama Alias', " &
                                         "Harga as 'Harga' from tbItem where Kode_Barang like '" & category & "-%' AND " &
                                         "Nama_Asli like '%" & name & "%' OR Nama_Alias like '%" & name & "%'", CON_KASIR)
        DA_BARANG.Fill(DS_BARANG)
        DA_BARANG.Dispose()
        dgv_barang.DataSource = DS_BARANG.Tables(0)
    End Sub

    Sub Clear_View()
        txt_kode.Text = Nothing
        txt_namaAsli.Text = Nothing
        txt_namaAlias.Text = Nothing
        rtb_deskripsi.Text = Nothing
        txt_harga.Text = Nothing

        txt_namaAsli.Enabled = False
        txt_namaAlias.Enabled = False
        rtb_deskripsi.Enabled = False
        txt_harga.Enabled = False
    End Sub

    Private Sub cbb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_kategori.SelectedIndexChanged
        Tampil_Data(GetKategoriInitials())
    End Sub

    Dim BRS As Integer
    Dim XKODE As String
    Private Sub dgv_barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_barang.CellClick
        BRS = dgv_barang.SelectedRows(0).Index
        XKODE = dgv_barang.Rows(BRS).Cells(0).Value

        Try
            With CO_BARANG
                .Connection = CON_KASIR
                .CommandText = "SELECT Kode_Barang, Nama_Asli, Nama_Alias, Deskripsi, Harga from tbItem where Kode_Barang = '" & XKODE & "'"
                .CommandType = CommandType.Text
            End With
            DR_BARANG = CO_BARANG.ExecuteReader
            DR_BARANG.Read()
            txt_kode.Text = DR_BARANG.Item(0)
            txt_namaAsli.Text = DR_BARANG.Item(1)
            txt_namaAlias.Text = DR_BARANG.Item(2)
            rtb_deskripsi.Text = DR_BARANG.Item(3)
            txt_harga.Text = DR_BARANG.Item(4)
            DR_BARANG.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        txt_namaAsli.Enabled = True
        txt_namaAlias.Enabled = True
        rtb_deskripsi.Enabled = True
        txt_harga.Enabled = True

        btn_save.Visible = True
        btn_cancel.Visible = True
        btn_edit.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click, btn_cancel.Click
        btn_save.Visible = False
        btn_cancel.Visible = False
        btn_edit.Visible = True

        Try
            If sender.tag = 1 Then
                With CO_BARANG
                    .Connection = CON_KASIR
                    .CommandText = "Update tbItem set Nama_Asli = '" & txt_namaAsli.Text & _
                                   "', Nama_Alias = '" & txt_namaAlias.Text & _
                                   "', Deskripsi = '" & rtb_deskripsi.Text & _
                                   "', Harga = " & CInt(txt_harga.Text) & _
                                   " where Kode_Barang = '" & txt_kode.Text & "'"
                    .CommandType = CommandType.Text
                End With
                DR_BARANG = CO_BARANG.ExecuteReader
                DR_BARANG.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Clear_View()
        cbb_kategori.SelectedIndex = 0
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged, txt_namaAsli.TextChanged, txt_namaAlias.TextChanged, rtb_deskripsi.TextChanged
        If txt_namaAlias.Text = "" Or txt_namaAsli.Text = "" Or rtb_deskripsi.Text = "" Or txt_harga.Text = "" Then
            btn_edit.Enabled = False
            btn_save.Enabled = False
        Else
            btn_edit.Enabled = True
            btn_save.Enabled = True
        End If
    End Sub

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

#Region "Get Kategori Values"
    Function GetKategoriInitials()
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

    Function GetKategori()
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

    Function GetKategoriKeterangan()
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
End Class
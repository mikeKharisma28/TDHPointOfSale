Imports System.Data
Imports System.Data.OleDb

Public Class Master_Add
    Sub Penomoran()
        Dim NO As Integer = Val(Microsoft.VisualBasic.Right(txt_kode.Text, 5)) + 1
        Dim Panjang As Integer = 5 - Trim(Str(NO)).Length
        Dim XNOMOR As String = NO
        For N As Integer = 1 To Panjang
            XNOMOR = "0" & XNOMOR
        Next

        txt_kode.Text = GetKategoriInitials() & "-" & XNOMOR
    End Sub

    Sub Clear_View()
        txt_kode.Text = ""
        txt_namaAsli.Text = ""
        txt_namaAlias.Text = ""
        rtb_deskripsi.Text = ""
        txt_harga.Text = ""
        cbb_kategori.Text = ""

        txt_namaAsli.Enabled = False
        txt_namaAlias.Enabled = False
        rtb_deskripsi.Enabled = False
        txt_harga.Enabled = False
    End Sub

    Sub KategoriSelected()
        txt_namaAsli.Enabled = True
        rtb_deskripsi.Enabled = True
        txt_harga.Enabled = True
        If GetKategoriKeterangan() = "No" Then
            txt_namaAlias.Text = "-"
            txt_namaAlias.Enabled = False
        Else
            txt_namaAlias.Text = ""
            txt_namaAlias.Enabled = True
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            With CO_BARANG
                .Connection = CON_KASIR
                If GetKategoriKeterangan() = "Yes" Then
                    .CommandText = "UPDATE tbItem set ID_Kategori = '" & _
                                   Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & _
                                   "', Nama_Asli = '" & txt_namaAsli.Text & "', Nama_Alias = '" & txt_namaAlias.Text & _
                                   "', Deskripsi = '" & rtb_deskripsi.Text & "', Harga = " & Val(txt_harga.Text) & " where Kode_Barang = '" & _
                                    txt_kode.Text & "'"
                Else
                    .CommandText = "UPDATE tbItem set ID_Kategori = '" & _
                                   Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & _
                                   "', Nama_Asli = '" & txt_namaAsli.Text & "', Nama_Alias = '-', Deskripsi = '" & rtb_deskripsi.Text & _
                                   "', Harga = " & Val(txt_harga.Text) & " where Kode_Barang = '" & _
                                   txt_kode.Text & "'"
                End If
                .CommandType = CommandType.Text
            End With
            DR_BARANG = CO_BARANG.ExecuteReader
            DR_BARANG.Close()
            Call Penomoran()

            Try
                With CO_BARANG
                    .Connection = CON_KASIR
                    .CommandText = "Insert into tbItem (Kode_Barang, ID_Kategori) values('" & txt_kode.Text & "', '" & Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & "')"
                    .CommandType = CommandType.Text
                End With
                DR_BARANG = CO_BARANG.ExecuteReader
                DR_BARANG.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                DR_BARANG.Close()
            End Try
            Call Clear_View()
        Catch ex As Exception
            MsgBox(ex.Message)
            DR_BARANG.Close()
        End Try
    End Sub

    Private Sub cbb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_kategori.SelectedIndexChanged
        Call KategoriSelected()

        Try
            With CO_BARANG
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbItem where ID_Kategori = '" & _
                               Microsoft.VisualBasic.Left(cbb_kategori.SelectedItem.ToString(), 4) & _
                               "' order by Kode_Barang desc"
                .CommandType = CommandType.Text
            End With
            DR_BARANG = CO_BARANG.ExecuteReader
            DR_BARANG.Read()
            If DR_BARANG.HasRows Then
                txt_kode.Text = DR_BARANG.Item(0)
                DR_BARANG.Close()
            Else
                txt_kode.Text = GetKategoriInitials() & "-00000"
                DR_BARANG.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call Clear_View()
    End Sub

    Private Sub Master_Add_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Call Clear_View()
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged, txt_namaAsli.TextChanged, txt_namaAlias.TextChanged, rtb_deskripsi.TextChanged
        If txt_namaAlias.Text = "" Or txt_namaAsli.Text = "" Or rtb_deskripsi.Text = "" Or txt_harga.Text = "" Then
            btn_add.Enabled = False
        Else
            btn_add.Enabled = True
        End If
    End Sub

    Private Sub btn_addCategory_Click(sender As Object, e As EventArgs) Handles btn_addCategory.Click
        Master_EditKategori.ShowDialog()
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
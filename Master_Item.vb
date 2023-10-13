Imports System.Data
Imports System.Data.OleDb

Public Class Master_Item
    Sub Tampil_Data(temp As String)
        DS_BARANG.Clear()
        DA_BARANG = New OleDbDataAdapter("Select Kode_Barang as 'ID', " &
                                         "Nama_Asli as 'Nama Asli', " &
                                         "Nama_Alias as 'Nama Alias', " &
                                         "Deskripsi as 'Deskripsi', " &
                                         "Harga as 'Harga'" & " from tbItem where Kode_Barang like '" &
                                         temp & "-%' and Nama_Asli like '%'", CON_KASIR)
        DA_BARANG.Fill(DS_BARANG)
        DA_BARANG.Dispose()
        dgv_barangItem.DataSource = DS_BARANG.Tables(0)
    End Sub

    Private Sub cbb_kategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_kategori.SelectedIndexChanged
        Tampil_Data(GetKategoriInitials())
    End Sub

    Dim BRS As Integer
    Dim XKODE As String
    Private Sub dgv_barang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_barangItem.CellClick
        BRS = dgv_barangItem.SelectedRows(0).Index
        XKODE = dgv_barangItem.Rows(BRS).Cells(0).Value

        Try
            With CO_BARANG
                .Connection = CON_KASIR
                .CommandText = "SELECT Kode_Barang, Nama_Asli, Nama_Alias, Deskripsi, Harga from tbItem where Kode_Barang = '" & XKODE & "'"
                .CommandType = CommandType.Text
            End With
            DR_BARANG = CO_BARANG.ExecuteReader
            DR_BARANG.Read()
            DR_BARANG.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
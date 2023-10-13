Imports System.Data
Imports System.Data.OleDb

Public Class Order_TahanOrderList

    Private Sub Order_TahanOrderList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Tampil_Data()
    End Sub

    Sub Tampil_Data()
        DS_ORDER.Clear()
        DA_ORDER = New OleDbDataAdapter("Select No_Order, No_Meja, (sum((Harga - (Harga * (Diskon / 100))) * Jumlah_Barang)) as Total_Harga " & _
                                        "from tbTahanOrder " & _
                                        "where No_Meja Is Not Null group by No_Order, No_Meja", CON_KASIR)
        DA_ORDER.Fill(DS_ORDER)
        DA_ORDER.Dispose()
        dgv_order.DataSource = DS_ORDER.Tables(0)
    End Sub

    Dim BRS As Integer
    Public XKODE As String
    Private Sub dgv_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_order.CellClick
        BRS = dgv_order.SelectedRows(0).Index
        XKODE = dgv_order.Rows(BRS).Cells(0).Value
    End Sub

    Private Sub dgv_order_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_order.CellDoubleClick
        Counter_Order = 0
        Form_Order.lsv_order.Items.Clear()
        Try
            Dim CO_MOVETOORDER As New OleDbCommand
            Dim DR_MOVETOORDER As OleDbDataReader
            With CO_MOVETOORDER
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbTahanOrder where No_Order = '" & XKODE & "'"
                .CommandType = CommandType.Text
            End With
            DR_MOVETOORDER = CO_MOVETOORDER.ExecuteReader

            Do While DR_MOVETOORDER.Read()
                Dim tempMejaDO As String() = Split(DR_MOVETOORDER.Item(1), " // ")
                With Form_Order
                    .txt_kode.Text = DR_MOVETOORDER.Item(0)
                    .cbb_noMeja.Text = tempMejaDO(0)
                    .txt_alamat.Text = tempMejaDO(1)
                    .lsv_order.Items.Add(DR_MOVETOORDER.Item(2) & " - " & DR_MOVETOORDER.Item(3)) 'Kode + Nama barang
                    .lsv_order.Items(Counter_Order).SubItems.Add(DR_MOVETOORDER.Item(4)) 'Qty
                    .lsv_order.Items(Counter_Order).SubItems.Add(DR_MOVETOORDER.Item(6)) 'Harga

                    'Checked if disc. of an item contains 100%
                    If DR_MOVETOORDER.Item(5) <> "100" Then
                        .lsv_order.Items(Counter_Order).SubItems.Add(DR_MOVETOORDER.Item(5))
                    ElseIf DR_MOVETOORDER.Item(5) = "100" Then
                        .lsv_order.Items(Counter_Order).SubItems.Add(DR_MOVETOORDER.Item(5)) 'Disc.
                        .lsv_order.Items(Counter_Order).Checked = True
                    End If

                    Dim tempItemFree As String 'Digunakan untuk pencarian item "Buy 1 get 1 free
                    If DR_MOVETOORDER.Item(8).ToString().Contains("Dibundle dengan ") Then
                        tempItemFree = DR_MOVETOORDER.Item(8).ToString().Substring(16).ToString()
                        If .lsv_order.Items(Counter_Order - 1).SubItems(0).Text.EndsWith(tempItemFree) Then
                            .lsv_order.Items(Counter_Order - 1).Checked = True
                        End If
                    End If
                    .lsv_order.Items(Counter_Order).SubItems.Add(DR_MOVETOORDER.Item(8)) 'Catatan
                    .lsv_order.Items(Counter_Order).Group = .lsv_order.Groups(GetKategoriGroup(DR_MOVETOORDER.Item(2))) 'Group
                End With
                Counter_Order += 1
            Loop
            With Form_Order
                For i As Integer = 0 To .lsv_order.Items.Count - 1
                    If .lsv_order.Items(i).Checked Then
                        .lsv_order.Items(i).Group = .lsv_order.Groups("BF-0")
                    End If
                Next
            End With
            DR_MOVETOORDER.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Form_Order.Check_Pemesanan()
        Call Form_Order.btn_next_Click(sender, e)
        Me.Dispose()
    End Sub

    Dim i As DataGridViewCellEventArgs
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click, btn_cancel.Click
        If sender.tag = 1 Then
            dgv_order_CellDoubleClick(sender, i)
        End If
        Me.Dispose()
    End Sub

    Private Sub Order_TahanOrderList_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        DS_ORDER.Reset()
    End Sub

#Region "Get Kategori Group"
    Function GetKategoriGroup(nama As String) 'Contoh GetKategoriGroup(DR_MOVETOORDER.Item(0)) = K-00
        Dim Temp As String
        Dim CO_KATEGORI As New OleDbCommand
        Dim DR_KATEGORI As OleDbDataReader

        With CO_KATEGORI
            .Connection = CON_KASIR
            .CommandText = "SELECT ID_Kategori from tbItem where Kode_Barang = '" & nama & "'"
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
Imports System.Data
Imports System.Data.OleDb

Public Class Laporan_Graphic
    Private Sub cbb_tipeLaporan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_tipeLaporan.SelectedValueChanged
        If cbb_tipeLaporan.SelectedItem = "Penjualan Keseluruhan" Then
            pnl_child.Controls.Clear()
            Laporan_Graphic_Overall.pnl_overall.Parent = Me.pnl_child
            Laporan_Graphic_Overall.pnl_overall.Visible = True
        ElseIf cbb_tipeLaporan.SelectedItem = "Penjualan Tiap Barang" Then
            pnl_child.Controls.Clear()
            Laporan_Graphic_PerItem.pnl_perItem.Parent = Me.pnl_child
            Laporan_Graphic_PerItem.pnl_perItem.Visible = True

            Laporan_Graphic_PerItem.TampilItem()
        End If
    End Sub

    Private Sub Laporan_Graphic_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Laporan_Graphic_Overall = Nothing
        Laporan_Graphic_PerItem = Nothing
    End Sub
End Class
Imports System.Data
Imports System.Data.OleDb

Public Class Laporan_Text

    Private Sub cbb_tipeLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_tipeLaporan.SelectedIndexChanged
        If cbb_tipeLaporan.SelectedItem = "Penjualan Per Hari" Then
            pnl_child.Controls.Clear()
            Laporan_Text_PerHari.pnl_perhari.Parent = Me.pnl_child
            Laporan_Text_PerHari.pnl_perhari.Visible = True
        ElseIf cbb_tipeLaporan.SelectedItem = "History Penjualan" Then
            pnl_child.Controls.Clear()
            Laporan_Text_History.pnl_history.Parent = Me.pnl_child
            Laporan_Text_History.pnl_history.Visible = True

            Laporan_Text_History.TampilItem(Laporan_Text_History.picker_Tanggal.Text)
        End If
    End Sub

    Private Sub Laporan_Text_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Laporan_Text_PerHari = Nothing
        Laporan_Text_History = Nothing
    End Sub

End Class
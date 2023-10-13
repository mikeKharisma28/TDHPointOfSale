Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Graphic_PerItem
    Sub TampilItem()
        Dim DS_SHOWITEM As New DataSet
        Dim DA_SHOWITEM As OleDbDataAdapter

        DS_SHOWITEM.Clear()
        DA_SHOWITEM = New OleDbDataAdapter("SELECT Kode_Barang, Nama_Alias, Nama_Asli from tbItem " & _
                                           "where Nama_Asli is NOT NULL ORDER by Kode_Barang ASC", CON_KASIR)
        DA_SHOWITEM.Fill(DS_SHOWITEM)
        DA_SHOWITEM.Dispose()
        dgv_item.DataSource = DS_SHOWITEM.Tables(0)
    End Sub

    Sub LoadChart(Item As String, TglAwal As String, TglAkhir As String)
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfo As New TableLogOnInfo
        Try
            With crtableLogoninfo.ConnectionInfo
                .ServerName = Application.StartupPath & "\TDHDatabase.accdb"
                .DatabaseName = ""
                .UserID = "Admin"
                .Password = ""
            End With

            'load report
            cryRpt.Load(Application.StartupPath & "\GraphicPerItem.rpt")
            For i As Integer = 0 To cryRpt.Database.Tables.Count - 1
                cryRpt.Database.Tables(i).ApplyLogOnInfo(crtableLogoninfo)
            Next
            cryRpt.DataSourceConnections.Item(0).SetConnection(Application.StartupPath & "\TDHDatabase.accdb", "", False)
            cryRpt.DataSourceConnections.Item(0).SetLogon("Admin", "")

            cryRpt.SetParameterValue("Item", Item)
            cryRpt.SetParameterValue("Tanggal Awal", TglAwal)
            cryRpt.SetParameterValue("Tanggal Akhir", TglAkhir)
            Laporan_Graphic.CrystalReportViewer1.Refresh()
            Laporan_Graphic.CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim BRS As Integer
    Dim XKODE As String
    Private Sub dgv_item_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_item.CellClick
        BRS = dgv_item.SelectedRows(0).Index
        XKODE = dgv_item.Rows(BRS).Cells(0).Value
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Call LoadChart(XKODE, picker_TglAwal.Text, picker_TglAkhir.Text)
    End Sub
End Class
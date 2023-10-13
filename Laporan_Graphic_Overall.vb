Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Graphic_Overall
    Sub LoadChart(TglAwal As String, TglAkhir As String)
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
            cryRpt.Load(Application.StartupPath & "\GraphicOverall.rpt")
            For i As Integer = 0 To cryRpt.Database.Tables.Count - 1
                cryRpt.Database.Tables(i).ApplyLogOnInfo(crtableLogoninfo)
            Next
            cryRpt.DataSourceConnections.Item(0).SetConnection(Application.StartupPath & "\TDHDatabase.accdb", "", False)
            cryRpt.DataSourceConnections.Item(0).SetLogon("Admin", "")

            cryRpt.SetParameterValue("Tanggal Awal", TglAwal)
            cryRpt.SetParameterValue("Tanggal Akhir", TglAkhir)
            Laporan_Graphic.CrystalReportViewer1.Refresh()
            Laporan_Graphic.CrystalReportViewer1.ReportSource = cryRpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Call LoadChart(picker_TglAwal.Text, picker_TglAkhir.Text)
    End Sub
End Class
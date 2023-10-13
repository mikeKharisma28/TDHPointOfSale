Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Text_History
    Sub TampilItem(tanggal As String)
        Dim DS_SHOWITEM As New DataSet
        Dim DA_SHOWITEM As OleDbDataAdapter

        DS_SHOWITEM.Clear()
        DA_SHOWITEM = New OleDbDataAdapter("SELECT ID, No_Transaksi, Grand_Total from tbTransaksi " &
                                           "where No_Order is NOT NULL AND Tgl_Transaksi like '" & tanggal & " %'" &
                                           "ORDER by ID ASC", CON_KASIR)
        DA_SHOWITEM.Fill(DS_SHOWITEM)
        DA_SHOWITEM.Dispose()
        dgv_transaksi.DataSource = DS_SHOWITEM.Tables(0)
    End Sub

    Private Sub PrintNota(value As String)
        Dim CrTables As Tables
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Try
            'reportdoc object
            Dim cryRpt As New ReportDocument

            'load report
            cryRpt.Load(Application.StartupPath & "\PrintNotaBuatPajak.rpt")

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

    Sub LoadReport(idTransaksi As String)
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
            cryRpt.Load(Application.StartupPath & "\PrintNotaBuatPajak.rpt")
            For i As Integer = 0 To cryRpt.Database.Tables.Count - 1
                cryRpt.Database.Tables(i).ApplyLogOnInfo(crtableLogoninfo)
            Next
            cryRpt.DataSourceConnections.Item(0).SetConnection(Application.StartupPath & "\TDHDatabase.accdb", "", False)
            cryRpt.DataSourceConnections.Item(0).SetLogon("Admin", "")

            cryRpt.SetParameterValue("No Transaksi", idTransaksi)
            Laporan_Text.CrystalReportViewer1.Refresh()
            Laporan_Text.CrystalReportViewer1.ReportSource = cryRpt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim BRS As Integer
    Dim XKODE As String
    Private Sub dgv_transaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_transaksi.CellClick
        BRS = dgv_transaksi.SelectedRows(0).Index
        XKODE = dgv_transaksi.Rows(BRS).Cells(0).Value
        btn_print.Enabled = True
        btn_ubah.Enabled = True
    End Sub

    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        LoadReport(XKODE)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintNota(XKODE)
    End Sub

    Private Sub picker_Tanggal_ValueChanged(sender As Object, e As EventArgs) Handles picker_Tanggal.ValueChanged
        TampilItem(picker_Tanggal.Text)
        btn_print.Enabled = False
        btn_ubah.Enabled = False
    End Sub

    Private Sub dgv_transaksi_DataSourceChanged(sender As Object, e As EventArgs) Handles dgv_transaksi.DataSourceChanged
        If dgv_transaksi.Rows.Count = 0 Then
            btn_print.Enabled = False
            btn_ubah.Enabled = False
        End If
    End Sub
End Class
Public Class Form_Help

    Private Sub Form_Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Help_Master.Hide()
            Help_Order.Hide()
            Help_Laporan.Hide()
            Help_About.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_About_Click(sender As Object, e As EventArgs) Handles btn_About.Click
        pnl_master.Controls.Clear()
        Help_About.pnl_About.Parent = Me.pnl_master
        Help_About.pnl_About.Visible = True
    End Sub

    Private Sub Form_Help_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Help_Master.Dispose()
        Help_Order.Dispose()
        Help_Laporan.Dispose()
        Help_About.Dispose()
        Menu_Utama_Kasir.Show()
    End Sub

    Private Sub btn_Master_Click(sender As Object, e As EventArgs) Handles btn_Master.Click
        pnl_master.Controls.Clear()
        Help_Master.pnl_Master.Parent = Me.pnl_master
        Help_Master.pnl_Master.Visible = True
    End Sub

    Private Sub btn_Order_Click(sender As Object, e As EventArgs) Handles btn_Order.Click
        pnl_master.Controls.Clear()
        Help_Order.pnl_Order.Parent = Me.pnl_master
        Help_Order.pnl_Order.Visible = True
    End Sub

    Private Sub btn_Laporan_Click(sender As Object, e As EventArgs) Handles btn_Laporan.Click
        pnl_master.Controls.Clear()
        Help_Laporan.pnl_Laporan.Parent = Me.pnl_master
        Help_Laporan.pnl_Laporan.Visible = True
    End Sub
End Class
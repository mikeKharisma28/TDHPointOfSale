Public Class Menu_Utama_Kasir

    Private Sub btn_master_Click(sender As Object, e As EventArgs) Handles btn_master.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Hide()
            Form_Master.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Hide()
            Form_Order.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Hide()
            Form_Laporan.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Hide()
            Form_Settings.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Hide()
            Form_Help.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_signOut_Click(sender As Object, e As EventArgs) Handles btn_signOut.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Form_Login.Show()
            Me.Hide()
            Form_Login.txt_user.Text = Nothing
            Form_Login.txt_pass.Text = Nothing
            Form_Login.txt_user.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        Form_Login.Close()
        CO_ORDER.Dispose()
        CO_BARANG.Dispose()
        CO_TRANSAKSI.Dispose()
        CO_USER.Dispose()
        CON_KASIR.Close()
    End Sub

    Private Sub Menu_Utama_Kasir_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        btn_close_Click(sender, e)
    End Sub
End Class
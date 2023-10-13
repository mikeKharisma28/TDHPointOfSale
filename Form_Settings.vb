Public Class Form_Settings

    Private Sub Form_Settings_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Menu_Utama_Kasir.Show()
    End Sub

    Private Sub btn_changeKode_Click(sender As Object, e As EventArgs) Handles btn_changeKode.Click
        Setting_ChangeCode.ShowDialog()
    End Sub
End Class
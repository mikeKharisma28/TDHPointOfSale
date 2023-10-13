Imports System.Data
Imports System.Data.OleDb

Public Class Form_Login

    Private Sub checkTransaksi()
        Dim CO_TRANSAKSI As New OleDbCommand
        Dim DR_TRANSAKSI As OleDbDataReader

        With CO_TRANSAKSI
            .Connection = CON_KASIR
            .CommandText = "Select No_Transaksi from tbTransaksi where No_Transaksi like '%-%' order by ID asc"
            .CommandType = CommandType.Text
        End With
        DR_TRANSAKSI = CO_TRANSAKSI.ExecuteReader
        DR_TRANSAKSI.Read()
        If DR_TRANSAKSI.HasRows Then
            If IsDBNull(DR_TRANSAKSI.Item(0)) Then
                DR_TRANSAKSI.Close()
                MsgBox("Lakukan penyetelan kode transaksi untuk pertama kali.")
                Setting_ChangeCode.ShowDialog()
            Else
                DR_TRANSAKSI.Close()
                Exit Sub
            End If
        Else
            DR_TRANSAKSI.Close()
            MsgBox("Lakukan penyetelan kode transaksi untuk pertama kali.")
            Setting_ChangeCode.ShowDialog()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        CO_ORDER.Dispose()
        CO_BARANG.Dispose()
        CO_TRANSAKSI.Dispose()
        CO_USER.Dispose()
        CON_KASIR.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            With CO_USER
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbUsers where Username = '" & txt_user.Text & "' and Password = '" & txt_pass.Text & "'"
                .CommandType = CommandType.Text
            End With
            DR_USER = CO_USER.ExecuteReader
            DR_USER.Read()
            If DR_USER.HasRows Then
                checkTransaksi()
                Menu_Utama_Kasir.Show()
                Me.Hide()
                Menu_Utama_Kasir.lbl_name.Text = DR_USER.Item(2)
                Menu_Utama_Kasir.lbl_jobTitle.Text = DR_USER.Item(3)
            Else
                MsgBox("Invalid username / password!")
                txt_pass.Text = Nothing
                txt_user.Text = Nothing
                Me.Show()
                txt_user.Focus()
            End If
            DR_USER.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txt_user.Focus()
        Connection.Connection()
    End Sub

    Dim i As EventArgs
    Private Sub txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If e.KeyChar = Chr(13) Then
            btn_login_Click(sender, i)
        End If
    End Sub
End Class

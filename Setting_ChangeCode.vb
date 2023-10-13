Imports System.Data
Imports System.Data.OleDb

Public Class Setting_ChangeCode
    'Prosedur ini digunakan untuk mengecek kode transaksi awal
    Private Sub CheckKode()
        Dim CO_KODE As New OleDbCommand
        Dim DR_KODE As OleDbDataReader

        Try
            With CO_KODE
                .Connection = CON_KASIR
                .CommandText = "Select No_Transaksi from tbTransaksi where No_Transaksi like '%-%' order by ID desc"
                .CommandType = CommandType.Text
            End With
            DR_KODE = CO_KODE.ExecuteReader
            DR_KODE.Read()
            If DR_KODE.HasRows() Then
                If IsDBNull(DR_KODE.Item(0)) Then
                    txt_awal.Text = "None"
                Else
                    Dim temp As String() = Split(DR_KODE.Item(0), "-")
                    txt_awal.Text = temp(0).ToString()
                End If
            Else
                txt_awal.Text = "None"
            End If

            DR_KODE.Close()
        Catch ex As Exception
            txt_awal.Text = "None"
        End Try
    End Sub

    'Digunakan untuk mereset kode
    'Mengambil kode dari txt_baru dan menambahkan "-00001"
    Private Sub ResetKode()
        Dim CO_RESET As New OleDbCommand
        Dim DR_RESET As OleDbDataReader
        Try
            With CO_RESET
                .Connection = CON_KASIR
                .CommandText = "DELETE * FROM tbTransaksi where No_Order is NULL"
                .CommandType = CommandType.Text
            End With
            DR_RESET = CO_RESET.ExecuteReader
            DR_RESET.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            With CO_RESET
                .Connection = CON_KASIR
                .CommandText = "Insert into tbTransaksi (ID, No_Transaksi) values('" & IDGenerator() & "', '" & txt_baru.Text & "-00001')"
                .CommandType = CommandType.Text
            End With
            DR_RESET = CO_RESET.ExecuteReader
            DR_RESET.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_View()
        txt_awal.Text = ""
        txt_baru.Text = ""
    End Sub

    Private Sub Setting_ChangeCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CheckKode()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call Clear_View()
        Me.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Try
            Call ResetKode()
            Call Clear_View()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txt_baru_TextChanged(sender As Object, e As EventArgs) Handles txt_baru.TextChanged
        If txt_baru.Text = "" Or Nothing Then
            btn_reset.Enabled = False
        Else
            btn_reset.Enabled = True
        End If
    End Sub
End Class
Imports System.Data
Imports System.Data.OleDb

Public Class Master_EditKategori
    Dim CO_KATEGORI As New OleDbCommand
    Dim DR_KATEGORI As OleDbDataReader

    Sub Penomoran()
        Dim NO As Integer = Val(Microsoft.VisualBasic.Right(txt_kode.Text, 2)) + 1
        Dim Panjang As Integer = 2 - Trim(Str(NO)).Length
        Dim XNOMOR As String = NO
        For N As Integer = 1 To Panjang
            XNOMOR = "0" & XNOMOR
        Next

        txt_kode.Text = "K-" & XNOMOR
    End Sub

    Sub Clear_View()
        txt_kategori.Text = Nothing
        txt_initial.Text = Nothing
        cbb_WithAlias.SelectedIndex = -1
    End Sub


    Private Sub Master_EditKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With CO_KATEGORI
                .Connection = CON_KASIR
                .CommandText = "SELECT ID from tbKategori order by ID desc"
                .CommandType = CommandType.Text
            End With
            DR_KATEGORI = CO_KATEGORI.ExecuteReader
            DR_KATEGORI.Read()
            If DR_KATEGORI.HasRows Then
                txt_kode.Text = DR_KATEGORI.Item(0)
                DR_KATEGORI.Close()
            Else
                txt_kode.Text = "K-00"
                DR_KATEGORI.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click, btn_cancel.Click
        If sender.tag = 1 Then
            Try
                With CO_KATEGORI
                    .Connection = CON_KASIR
                    .CommandText = "UPDATE tbKategori set Kategori = '" & txt_kategori.Text & _
                                    "', Initials = '" & txt_initial.Text & "', WithAlias = '" & cbb_WithAlias.Text & _
                                    "' where ID = '" & txt_kode.Text & "'"
                    .CommandType = CommandType.Text
                End With
                DR_KATEGORI = CO_KATEGORI.ExecuteReader
                DR_KATEGORI.Close()

                Try
                    With CO_BARANG
                        .Connection = CON_KASIR
                        .CommandText = "Insert into tbItem (Kode_Barang, ID_Kategori) values('" & Trim(txt_initial.Text) & "-00000" & _
                                       "', '" & txt_kode.Text & "')"
                        .CommandType = CommandType.Text
                    End With
                    DR_BARANG = CO_BARANG.ExecuteReader
                    DR_BARANG.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    DR_BARANG.Close()
                End Try

                Call Penomoran()

                Try
                    With CO_BARANG
                        .Connection = CON_KASIR
                        .CommandText = "Insert into tbKategori (ID) values('" & txt_kode.Text & "')"
                        .CommandType = CommandType.Text
                    End With
                    DR_BARANG = CO_BARANG.ExecuteReader
                    DR_BARANG.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    DR_BARANG.Close()
                End Try
                Call Clear_View()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        Me.Dispose()
    End Sub

    Private Sub txt_kategori_TextChanged(sender As Object, e As EventArgs) Handles txt_kategori.TextChanged, txt_initial.TextChanged, cbb_WithAlias.TextChanged
        If txt_kategori.Text = "" Or txt_initial.Text = "" Or cbb_WithAlias.Text = "" Then
            btn_add.Enabled = False
        Else
            btn_add.Enabled = True
        End If
    End Sub

    Private Sub Master_EditKategori_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Call Clear_View()
        'Menambahkan Kategori item pada cbb_kategori di Master_Add
        Master_Add.cbb_kategori.Items.Clear()
        Try
            With CO_KATEGORI
                .Connection = CON_KASIR
                .CommandText = "SELECT ID, Kategori from tbKategori where Kategori like '%' order by ID asc"
                .CommandType = CommandType.Text
            End With
            DR_KATEGORI = CO_KATEGORI.ExecuteReader
            Dim i As Integer = 0
            Do While DR_KATEGORI.Read()
                Master_Add.cbb_kategori.Items.Add("" & DR_KATEGORI.Item(0) & " - " & DR_KATEGORI.Item(1))
                i += 1
            Loop
            DR_KATEGORI.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
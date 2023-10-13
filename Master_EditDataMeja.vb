Imports System.Data
Imports System.Data.OleDb

Public Class Master_EditDataMeja
    Dim CO_DATAMEJA As New OleDbCommand
    Dim DR_DATAMEJA As OleDbDataReader
    Dim DA_DATAMEJA As OleDbDataAdapter
    Dim DS_DATAMEJA As New DataSet

    Sub Clear_View()
        txt_kode.Text = Nothing
        txt_kapasitas.Text = Nothing
        txt_kode.Enabled = False
        txt_kapasitas.Enabled = False
        With btn_add
            .Enabled = False
            .Visible = True
        End With
        With btn_edit
            .Enabled = False
            .Visible = False
        End With
    End Sub

    Sub Tampil_Data()
        DS_DATAMEJA.Clear()
        DA_DATAMEJA = New OleDbDataAdapter("Select * from tbMeja Order By No_Meja", CON_KASIR)
        DA_DATAMEJA.Fill(DS_DATAMEJA)
        DA_DATAMEJA.Dispose()
        dgv_meja.DataSource = DS_DATAMEJA.Tables(0)
    End Sub

    Sub Master_EditDataMeja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil_Data()
        Call Clear_View()
    End Sub

    Dim BRS As Integer
    Dim XKODE As String
    Private Sub dgv_meja_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_meja.CellClick
        BRS = dgv_meja.SelectedRows(0).Index
        XKODE = dgv_meja.Rows(BRS).Cells(0).Value

        'Jika grid view langsung diklik, maka akan dipakai untuk edit data
        btn_add.Hide()
        btn_edit.Show()
        txt_kode.Enabled = False
        txt_kapasitas.Enabled = True
        Try
            With CO_DATAMEJA
                .Connection = CON_KASIR
                .CommandText = "SELECT * from tbMeja where No_Meja = '" & XKODE & "'"
                .CommandType = CommandType.Text
            End With
            DR_DATAMEJA = CO_DATAMEJA.ExecuteReader
            DR_DATAMEJA.Read()
            txt_kode.Text = DR_DATAMEJA.Item(0)
            txt_kapasitas.Text = DR_DATAMEJA.Item(1)
            DR_DATAMEJA.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click, btn_edit.Click
        If IsNumeric(txt_kapasitas.Text) = False Then
            MsgBox("Field 'Kapasitas' must be filled in numbers.")
            txt_kapasitas.Text = ""
        Else
            If sender.tag = 1 Then
                Try
                    With CO_DATAMEJA
                        .Connection = CON_KASIR
                        .CommandText = "Insert into tbMeja values('" & txt_kode.Text & "', " & txt_kapasitas.Text & ")"
                        .CommandType = CommandType.Text
                    End With
                    DR_DATAMEJA = CO_DATAMEJA.ExecuteReader
                    DR_DATAMEJA.Close()
                    Call Clear_View()
                    txt_kode.Enabled = True
                    txt_kapasitas.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf sender.tag = 2 Then
                Try
                    With CO_DATAMEJA
                        .Connection = CON_KASIR
                        .CommandText = "UPDATE tbMeja set Kapasitas = '" & txt_kapasitas.Text & "' where No_Meja = '" & txt_kode.Text & "'"
                        .CommandType = CommandType.Text
                    End With
                    DR_DATAMEJA = CO_DATAMEJA.ExecuteReader
                    DR_DATAMEJA.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Call Clear_View()
            End If
            Call Tampil_Data()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Call Clear_View()
        txt_kode.Enabled = True
        txt_kapasitas.Enabled = True
    End Sub

    Private Sub txt_kapasitas_TextChanged(sender As Object, e As EventArgs) Handles txt_kapasitas.TextChanged
        If txt_kode.Text = "" Or txt_kapasitas.Text = "" Then
            btn_add.Enabled = False
            btn_edit.Enabled = False
        Else
            btn_add.Enabled = True
            btn_edit.Enabled = True
        End If
    End Sub
End Class
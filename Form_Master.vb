Imports System.Data
Imports System.Data.OleDb

Public Class Form_Master
    Private Sub Form_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DS_BARANG.Reset()
        Master_Edit.btn_edit.Enabled = False
    End Sub

    Private Sub btn_addData_Click(sender As Object, e As EventArgs) Handles btn_addData.Click, btn_editData.Click
        Select Case sender.tag
            Case 1
                Try
                    Me.Cursor = Cursors.WaitCursor

                    pnl_master.Controls.Clear()
                    Master_Add.pnl_addItem.Parent = Me.pnl_master
                    Master_Add.pnl_addItem.Visible = True

                    'Menambahkan Kategori item pada cbb_kategori di Master_Add
                    Master_Add.cbb_kategori.Items.Clear()
                    Dim CO_KATEGORI As New OleDbCommand
                    Dim DR_KATEGORI As OleDbDataReader

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
                Master_Add.Clear_View()
                Me.Cursor = Cursors.Default
            Case 2
                Try
                    Me.Cursor = Cursors.WaitCursor

                    pnl_master.Controls.Clear()
                    Master_Edit.pnl_editItem.Parent = Me.pnl_master
                    Master_Edit.pnl_editItem.Visible = True

                    'Menambahkan Kategori item pada cbb_kategori di Master_Add
                    Master_Edit.cbb_kategori.Items.Clear()

                    Dim CO_KATEGORI As New OleDbCommand
                    Dim DR_KATEGORI As OleDbDataReader

                    With CO_KATEGORI
                        .Connection = CON_KASIR
                        .CommandText = "SELECT ID, Kategori from tbKategori where Kategori like '%' order by ID asc"
                        .CommandType = CommandType.Text
                    End With
                    DR_KATEGORI = CO_KATEGORI.ExecuteReader
                    Dim i As Integer = 0
                    Do While DR_KATEGORI.Read()
                        Master_Edit.cbb_kategori.Items.Add("" & DR_KATEGORI.Item(0) & " - " & DR_KATEGORI.Item(1))
                        i += 1
                    Loop
                    DR_KATEGORI.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Master_Edit.cbb_kategori.SelectedIndex = 0

                Me.Cursor = Cursors.Default
            Case 3, 4
                Me.Cursor = Cursors.WaitCursor

                pnl_master.Controls.Clear()
                Master_EditDataMeja.pnl_editMeja.Parent = Me.pnl_master
                Master_EditDataMeja.pnl_editMeja.Visible = True
                If sender.tag = 3 Then
                    Try
                        With Master_EditDataMeja
                            Call .Tampil_Data()
                            Call .Clear_View()
                            .btn_add.Show()
                            .btn_edit.Hide()
                            .txt_kode.Enabled = True
                            .txt_kapasitas.Enabled = True
                        End With

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf sender.tag = 4 Then
                    With Master_EditDataMeja
                        Call .Tampil_Data()
                        Call .Clear_View()
                        .btn_add.Hide()
                        .btn_edit.Show()
                        .txt_kapasitas.Enabled = True
                    End With
                End If
                Me.Cursor = Cursors.Default
        End Select

    End Sub

    Private Sub btn_DataItem_Click(sender As Object, e As EventArgs) Handles btn_DataItem.Click, btn_DataMeja.Click
        If sender.tag = 1 Then
            btn_addData.Tag = 1
            btn_editData.Tag = 2
            lbl_judul.Text = "Master Data Item"
            btn_addData.Text = "Add Data Item"
            btn_editData.Text = "Edit Data Item"
            pnl_master.Controls.Clear()
            Master_Item.pnl_Item.Parent = Me.pnl_master
            Master_Item.pnl_Item.Visible = True

            Master_Item.Tampil_Data("F")

            btn_addData.Visible = True
            btn_editData.Visible = True

            'Menambahkan Kategori item pada cbb_kategori di Master_Item
            Master_Item.cbb_kategori.Items.Clear()
            Dim CO_KATEGORI As New OleDbCommand
            Dim DR_KATEGORI As OleDbDataReader

            With CO_KATEGORI
                .Connection = CON_KASIR
                .CommandText = "SELECT ID, Kategori from tbKategori where Kategori like '%' order by ID asc"
                .CommandType = CommandType.Text
            End With
            DR_KATEGORI = CO_KATEGORI.ExecuteReader
            Dim i As Integer = 0
            Do While DR_KATEGORI.Read()
                Master_Item.cbb_kategori.Items.Add("" & DR_KATEGORI.Item(0) & " - " & DR_KATEGORI.Item(1))
                i += 1
            Loop
            DR_KATEGORI.Close()

            Master_Item.cbb_kategori.SelectedIndex = 0
        Else
            btn_addData.Tag = 3
            btn_editData.Tag = 4
            lbl_judul.Text = "Master Data Meja"
            btn_addData.Text = "Add Data Meja"
            btn_editData.Text = "Edit Data Meja"
            pnl_master.Controls.Clear()
            Master_EditDataMeja.pnl_editMeja.Parent = Me.pnl_master
            Master_EditDataMeja.pnl_editMeja.Visible = True
            With Master_EditDataMeja
                Call .Tampil_Data()
                Call .Clear_View()
                .btn_add.Show()
                .btn_edit.Hide()
                .txt_kode.Enabled = True
                .txt_kapasitas.Enabled = True
            End With
            btn_addData.Visible = False
            btn_editData.Visible = False
        End If
    End Sub

    Private Sub Form_Master_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Master_Item = Nothing
        Master_Add = Nothing
        Master_Edit = Nothing
        Master_EditDataMeja = Nothing
        DS_BARANG.Reset()

        Menu_Utama_Kasir.Show()
    End Sub
End Class
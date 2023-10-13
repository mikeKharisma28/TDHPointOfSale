Imports System.Data
Imports System.Data.OleDb

Public Class Form_Laporan

    Private Sub Form_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Laporan_Graphic.Hide()

            Laporan_Text.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btn_graphic_Click(sender As Object, e As EventArgs) Handles btn_graphic.Click
        'If Me.Height < 645 Then
        '    Timer1.Enabled = True
        '    While Me.Height < 645
        '        Me.Height += 5
        '        While Me.Top > 55
        '            Me.Top -= 1
        '        End While
        '    End While
        'End If
        pnl_master.Controls.Clear()
        Laporan_Graphic.pnl_graphic.Parent = Me.pnl_master
        Laporan_Graphic.pnl_graphic.Visible = True
    End Sub

    Private Sub btn_laporan_Click(sender As Object, e As EventArgs) Handles btn_laporan.Click
        'If Me.Height < 645 Then
        '    Timer1.Enabled = True
        '    While Me.Height < 645
        '        Me.Height += 5
        '        While Me.Top > 55
        '            Me.Top -= 1
        '        End While
        '    End While
        'End If
        pnl_master.Controls.Clear()
        Laporan_Text.pnl_text.Parent = Me.pnl_master
        Laporan_Text.pnl_text.Visible = True
    End Sub

    Private Sub Form_Laporan_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Laporan_Graphic.Dispose()
        Laporan_Text.Dispose()

        Menu_Utama_Kasir.Show()
    End Sub
End Class
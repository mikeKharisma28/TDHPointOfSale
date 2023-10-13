Imports System.Data
Imports System.Data.OleDb

Module Libraries
    Public CON_KASIR As OleDbConnection
    Public CO_BARANG As New OleDbCommand
    Public DR_BARANG As OleDbDataReader

    Public DA_BARANG As OleDbDataAdapter
    Public DS_BARANG As New DataSet

    Public CO_ORDER As New OleDbCommand
    Public DR_ORDER As OleDbDataReader

    Public CO_TRANSAKSI As New OleDbCommand
    Public DR_TRANSAKSI As OleDbDataReader

    Public DA_ORDER As OleDbDataAdapter
    Public DS_ORDER As New DataSet

    Public CO_USER As New OleDbCommand
    Public DR_USER As OleDbDataReader

    'Penyimpanan sementara pada pemesanan
    Public Jumlah_Barang As Integer
    Public Catatan As String
    Public Counter_Order As Integer
    Public LastDigitID As String
    Public tempID As String

    'Penyimpanan sementara pada transaksi
    Public TempNoTransaksi As String
    Public TempKembalian As Long

    Public Function GetID()
        Dim Output As String
        Dim CO_ID As New OleDbCommand
        Dim DR_ID As OleDbDataReader
        With CO_ID
            .Connection = CON_KASIR
            .CommandText = "Select ID from tbTransaksi order by ID desc"
            .CommandType = CommandType.Text
        End With
        DR_ID = CO_ID.ExecuteReader
        DR_ID.Read()
        Output = DR_ID.Item(0)
        DR_ID.Close()
        Return Output
    End Function

    Public Function CheckID()
        Dim IsTrue As Boolean
        Dim CO_ID As New OleDbCommand
        Dim DR_ID As OleDbDataReader
        With CO_ID
            .Connection = CON_KASIR
            .CommandText = "Select ID from tbTransaksi order by ID desc"
            .CommandType = CommandType.Text
        End With
        DR_ID = CO_ID.ExecuteReader
        DR_ID.Read()
        If DR_ID.HasRows() Then
            IsTrue = True
        Else
            IsTrue = False
        End If
        DR_ID.Close()
        Return IsTrue
    End Function

    Public Function IDGenerator()
        Dim Output As String
        Dim day As String = Date.Today.Day
        Dim month As String = Date.Today.Month

        If day.Length = 1 Then
            day = "0" & day
        End If

        If month.Length = 1 Then
            month = "0" & month
        End If

        'Untuk mereset LastDigitID jika hari sudah berubah
        If CheckID() = True Then
            If day <> Microsoft.VisualBasic.Mid(GetID(), 7, 2) Then
                LastDigitID = "001"
            Else
                LastDigitID = Val(Microsoft.VisualBasic.Right(GetID(), 3)) + 1
                Dim Panjang As Integer = 3 - Trim(Str(LastDigitID)).Length
                For N As Integer = 1 To Panjang
                    LastDigitID = "0" & LastDigitID
                Next
            End If
            Output = Date.Today.Year & month & day & LastDigitID
        Else
            LastDigitID = "001"
            Output = Date.Today.Year & month & day & LastDigitID
        End If

        Return Output
    End Function
End Module

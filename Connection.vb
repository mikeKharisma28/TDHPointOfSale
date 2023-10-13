Imports System.Data
Imports System.Data.OleDb

Module Connection
    Public Sub Connection()
        Try
            CON_KASIR = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\TDHDatabase.accdb")
            CON_KASIR.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module

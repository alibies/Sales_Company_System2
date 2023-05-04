Imports System.Data.SqlClient

Module connectionModule

    Public Sub dbConnection()
        Try
            conn = New SqlConnection
            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Documents\Ali+hayder+hamza.mdf;Integrated Security=True;Connect Timeout=30"
            conn.Open()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module

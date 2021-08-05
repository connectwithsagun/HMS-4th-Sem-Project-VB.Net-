Imports System.Data.SqlClient
Module forbackup
    Public cmd1 As New SqlCommand
    Public con1 As New SqlConnection
    Public Sub connect()
        'Dim con As New SqlConnection
        Try
            con1.ConnectionString = "Data Source=DESKTOP-7RAO8LE\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
            con1.Open()
            cmd1.Connection = con1
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub
End Module


Imports System.Data.SqlClient
Public Class databackup
    Private Sub databackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginmodule.con()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        forbackup.connect()
        forbackup.cmd1 = New SqlCommand("restore database sytem from disk='D:\\sanjay.bak' with replace", forbackup.con1)
        forbackup.cmd1.ExecuteNonQuery()
        MsgBox("database is stored")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        forbackup.connect()
        forbackup.cmd1 = New SqlCommand("backup database sytem to disk='D:\\sanjay.bak'", forbackup.con1)
        forbackup.cmd1.ExecuteNonQuery()
        MsgBox("data is backpuped")
    End Sub
End Class
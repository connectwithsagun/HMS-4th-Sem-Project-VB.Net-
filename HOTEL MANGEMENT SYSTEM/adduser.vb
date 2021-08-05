Imports System.Data.SqlClient
Public Class adduser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = Loginmodule.cn
            cmd.CommandText = "insert into User1(username,password)VALUES('" & TextBox1.Text & "', '" & Trim(TextBox2.Text) & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub
    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loginmodule.con()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


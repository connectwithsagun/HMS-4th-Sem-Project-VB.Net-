Imports System.Data.SqlClient
Public Class form1
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loginmodule.con()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Close()
        cn.Open()
        Dim str As String
        str = "select*from User1 where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "' "
        Dim cmd As New SqlCommand(str, Loginmodule.cn)
        Dim rdr As SqlDataReader
        rdr = cmd.ExecuteReader()
        If (rdr.Read = True) Then
            MsgBox("Welcome to Hotel Management System")
            TextBox1.Text = ""
            TextBox2.Text = ""
            Mdiform.Show()
        Else
            MsgBox("SORRY login name or password is incorrect", MsgBoxStyle.Critical, "Error")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

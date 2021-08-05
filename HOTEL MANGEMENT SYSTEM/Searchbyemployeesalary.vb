Imports System.Data.SqlClient
Public Class Searchbyemployeesalary
    Private Sub guestlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        Try
            'Dim cmd As SqlCommand
            Dim rdr As SqlDataReader
            Dim n As Int16
            Dim str As String = "select * from Salary"
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("post")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("CurrentAddress")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentDate")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("JoinDate")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("DueMonth")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("SalaryPerMonth")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("Amount")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("Allowances")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("AdvanceSalary")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("TotalAmount")
            End While
        Catch ext As Exception
            MsgBox(ext.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        'Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim n As Int16
        Dim str As String
        'MsgBox(TextBox1.Text)
        'DataGridView1.Rows.Clear()
        If (TextBox1.Text.Length > 0) Then
            str = "select * from Salary where TotalAmount ='" & TextBox1.Text & "'"
        Else
            str = "select * from Salary"
        End If
        Dim cmd As New SqlCommand(str, Loginmodule.cn)
        rdr = cmd.ExecuteReader
        While rdr.Read()
            n = DataGridView1.Rows.Add()
            DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
            DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
            DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
            DataGridView1.Rows.Item(n).Cells(3).Value = rdr("post")
            DataGridView1.Rows.Item(n).Cells(4).Value = rdr("CurrentAddress")
            DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentDate")
            DataGridView1.Rows.Item(n).Cells(6).Value = rdr("JoinDate")
            DataGridView1.Rows.Item(n).Cells(7).Value = rdr("DueMonth")
            DataGridView1.Rows.Item(n).Cells(8).Value = rdr("SalaryPerMonth")
            DataGridView1.Rows.Item(n).Cells(9).Value = rdr("Amount")
            DataGridView1.Rows.Item(n).Cells(10).Value = rdr("Allowances")
            DataGridView1.Rows.Item(n).Cells(11).Value = rdr("AdvanceSalary")
            DataGridView1.Rows.Item(n).Cells(12).Value = rdr("TotalAmount")
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
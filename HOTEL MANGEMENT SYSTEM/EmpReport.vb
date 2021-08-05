Imports System.Data.SqlClient
Public Class EmpReport
    Private Sub EmpReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Visible = False
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        Try
            'Dim cmd As SqlCommand
            Dim rdr As SqlDataReader
            Dim n As Int16
            Dim str As String = "select * from Employeereg"
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentAddress")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("PermanentAddress")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("EmailId")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("post")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("JoinDate")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("SalaryPerMonth")
            End While
        Catch ext As Exception
            '' MsgBox(ext.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        Dim rdr As SqlDataReader
        Dim n As Int16
        Dim str As String
        If ComboBox1.SelectedItem = "ID" Then
            DataGridView1.Rows.Clear()
            If (TextBox1.Text.Length > 0) Then
                str = "select * from Employeereg where EmployeeId='" & TextBox1.Text & "'"
            Else
                str = "select * from Employeereg"
            End If
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentAddress")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("PermanentAddress")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("EmailId")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("post")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("JoinDate")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("SalaryPerMonth")
            End While
        ElseIf ComboBox1.SelectedItem = "First Name" Then
            DataGridView1.Rows.Clear()
            If (TextBox1.Text.Length > 0) Then
                str = "select * from Employeereg where FirstName='" & TextBox1.Text & "' "
            Else
                str = "select * from Employeereg"
            End If
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentAddress")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("PermanentAddress")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("EmailId")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("post")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("JoinDate")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("SalaryPerMonth")
            End While
        Else
            TextBox1.Visible = False
            str = "select * from Employeereg where  JoinDate ='" & CDate(DateTimePicker1.Value) & "'"

            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("EmployeeId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("CurrentAddress")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("PermanentAddress")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("EmailId")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("post")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("JoinDate")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("SalaryPerMonth")
            End While
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Date" Then
            TextBox1.Visible = False
            DateTimePicker1.Visible = True
        Else
            TextBox1.Visible = True
            DateTimePicker1.Visible = False
        End If
    End Sub
End Class
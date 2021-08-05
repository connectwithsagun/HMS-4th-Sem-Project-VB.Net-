Imports System.Data.SqlClient
Public Class updateemployee
    Private Sub updateemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells.Item(6).Value
        TextBox8.Text = DataGridView1.CurrentRow.Cells.Item(7).Value
        TextBox9.Text = DataGridView1.CurrentRow.Cells.Item(8).Value
        TextBox10.Text = DataGridView1.CurrentRow.Cells.Item(9).Value
        TextBox11.Text = DataGridView1.CurrentRow.Cells.Item(10).Value
        TextBox12.Text = DataGridView1.CurrentRow.Cells.Item(11).Value
        TextBox13.Text = DataGridView1.CurrentRow.Cells.Item(12).Value
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cn.Close()
        cn.Open()
        Dim cmd1 As New SqlCommand
        cmd1.Connection = cn
        cmd1.CommandText = "update Employeereg set FirstName='" & Trim(TextBox2.Text) & "',LastName='" & Trim(TextBox3.Text) & "',Age='" & Trim(TextBox4.Text) & "',Gender='" & Trim(TextBox5.Text) & "',CurrentAddress='" & Trim(TextBox6.Text) & "',PermanentAddress='" & Trim(TextBox7.Text) & "',ContactNumber='" & Trim(TextBox8.Text) & "',Nationality='" & Trim(TextBox9.Text) & "',EmailId='" & Trim(TextBox10.Text) & "',post='" & Trim(TextBox11.Text) & "',JoinDate='" & Trim(TextBox12.Text) & "',SalaryPerMonth='" & Trim(TextBox13.Text) & "' where EmployeeId='" & TextBox1.Text & "' "
        cmd1.ExecuteNonQuery()
        MsgBox("Record is updated sucessfully")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()

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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
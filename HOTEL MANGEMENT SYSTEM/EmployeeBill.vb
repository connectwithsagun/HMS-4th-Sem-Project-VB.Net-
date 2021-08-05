Imports System.Data.SqlClient
Public Class EmployeeBill
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loginmodule.con()
        Try
            ' Dim cmd1 As SqlCommand
            Dim rdr As SqlDataReader
            'Dim n As Int16
            Dim str As String
            If (TextBox1.Text.Length > 0) Then
                str = "select * from Employeereg where EmployeeId='" & TextBox1.Text & "'"
                Dim cmd1 As New SqlCommand(str, Loginmodule.cn)
                rdr = cmd1.ExecuteReader
                While rdr.Read()
                    TextBox2.Text = rdr("FirstName")
                    TextBox3.Text = rdr("LastName")
                    TextBox4.Text = rdr("post")
                    TextBox5.Text = rdr("CurrentAddress")
                    TextBox7.Text = rdr("SalaryPerMonth")
                    MaskedTextBox1.Text = rdr("JoinDate")

                    'for calculating due months
                    Dim d1 As DateTime = DateTimePicker1.Text
                    Dim d2 As DateTime = MaskedTextBox1.Text
                    Dim M As Integer = Math.Abs((d1.Year - d2.Year))
                    Dim months As Integer = ((M * 12) + Math.Abs((d1.Month - d2.Month)))
                    TextBox6.Text = months

                    'for calculating amount
                    Dim result As Decimal = TextBox6.Text * TextBox7.Text
                    TextBox8.Text = result

                    'for calculating Allownces
                    Dim result1 As Decimal = TextBox8.Text * 5 / 100
                    TextBox9.Text = result1

                    TextBox10.Text = 0

                    'for calculating total Salary
                    Dim d3 As Decimal = TextBox8.Text
                    Dim d4 As Decimal = TextBox9.Text
                    Dim d5 As Decimal = TextBox10.Text
                    Dim result2 As Decimal = d3 + d4 + d5
                    TextBox11.Text = result2
                End While
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loginmodule.con()
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        Try
            Loginmodule.con()
            cmd.CommandText = "insert into Salary(EmployeeId,FirstName,LastName,post,CurrentAddress,CurrentDate,JoinDate,DueMonth,SalaryPerMonth,Amount,Allowances,AdvanceSalary,TotalAmount) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & Trim(TextBox3.Text) & "', '" & Trim(TextBox4.Text) & "','" & Trim(TextBox5.Text) & "','" & CDate(Trim(DateTimePicker1.Text)) & "','" & CDate(MaskedTextBox1.Text) & "','" & Trim(TextBox6.Text) & "','" & Trim(TextBox7.Text) & "','" & Trim(TextBox8.Text) & "','" & Trim(TextBox9.Text) & "','" & Trim(TextBox10.Text) & "','" & Trim(TextBox11.Text) & "') "
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            DateTimePicker1.Text = ""
            MaskedTextBox1.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub
    Private Sub EmployeeBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
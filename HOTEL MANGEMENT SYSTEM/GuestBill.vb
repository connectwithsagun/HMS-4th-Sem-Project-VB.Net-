Imports System.Data.SqlClient
Public Class GuestBill
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loginmodule.con()
        Try
            'Dim cmd As SqlCommand
            Dim rdr As SqlDataReader
            'Dim n As Int16
            Dim str As String
            If (TextBox1.Text.Length > 0) Then
                str = "select * from Guestreg where GuestId='" & TextBox1.Text & "'"
                Dim cmd As New SqlCommand(str, Loginmodule.cn)
                rdr = cmd.ExecuteReader
                While rdr.Read()
                    TextBox3.Text = rdr("FirstName")
                    TextBox4.Text = rdr("LastName")
                    MaskedTextBox1.Text = rdr("ArrivalDate")
                    MaskedTextBox2.Text = rdr("CheckOutDate")
                    TextBox7.Text = rdr("RoomNo")
                    TextBox9.Text = rdr("PricePerDay")

                End While
            Else
            End If
            str = ("select count(BillNo) as 'BillNo' from bill")
            Dim cmd1 As New SqlCommand(str, Loginmodule.cn)
            rdr.Close()
            rdr = cmd1.ExecuteReader
            While rdr.Read()
                TextBox2.Text = rdr("BillNo") + 1
            End While

            'for calculating the total days of guest stayed

            Dim d1 As DateTime = MaskedTextBox1.Text
            Dim d2 As DateTime = MaskedTextBox2.Text
            Dim result As TimeSpan = d2.Subtract(d1)
            Dim days As Integer = result.TotalDays
            TextBox8.Text = days

            'for calculating the total amount
            Dim d3 As Decimal = TextBox8.Text
            Dim d4 As Decimal = TextBox9.Text
            Dim result1 As Decimal = d3 * d4
            TextBox10.Text = result1

            'for calculating the discount amount
            Dim d As Decimal = TextBox10.Text
            Dim result2 As Decimal = d * 5 / 100
            TextBox11.Text = result2

            'for calculating the amount after discount
            Dim result3 As Decimal = TextBox10.Text - TextBox11.Text
            TextBox12.Text = result3

            'for calculating the VAT amount
            Dim result4 As Decimal = TextBox12.Text * 13 / 100
            TextBox13.Text = result4

            'for calculating total amount
            Dim d5 As Decimal = TextBox12.Text
            Dim result5 As Decimal = d5 + TextBox13.Text
            TextBox14.Text = result5

        Catch ext As Exception
            MsgBox(ext.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Loginmodule.con()
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        Try
            Loginmodule.con()
            cmd.CommandText = "insert into bill(GuestId,BillNo,BillDate,FirstName,LastName,ArrivalDate,CheckOutDate,RoomNo,NoOfDays,PricePerDay,Amount,discount,TotalAmount,VAT,GrandTotal) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & CDate(Trim(DateTimePicker1.Text)) & "', '" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "','" & CDate(MaskedTextBox1.Text) & "','" & CDate(MaskedTextBox2.Text) & "','" & Trim(TextBox7.Text) & "','" & Trim(TextBox8.Text) & "','" & Trim(TextBox9.Text) & "','" & Trim(TextBox10.Text) & "','" & Trim(TextBox11.Text) & "','" & Trim(TextBox12.Text) & "','" & Trim(TextBox13.Text) & "','" & Trim(TextBox14.Text) & "') "
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            MaskedTextBox1.Text = ""
            MaskedTextBox2.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
            TextBox11.Text = ""
            TextBox12.Text = ""
            TextBox13.Text = ""
            TextBox14.Text = ""
            DateTimePicker1.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub GuestBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class





Imports System.Data.SqlClient
Public Class EmployeeRegistration
    Private Sub EmployeeRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Nawalpur")
        ComboBox1.Items.Add("Chitwan")
        ComboBox1.Items.Add("Kathmandu")
        ComboBox1.Items.Add("Pokhara")
        ComboBox1.Items.Add("Butwol")
        ComboBox1.Items.Add("Biratnagar")
        ComboBox1.Items.Add("Bhaktapur")
        ComboBox1.Items.Add("Dhangadhi")
        ComboBox1.Items.Add("Palpa")
        ComboBox1.Items.Add("Gorkha")
        ComboBox1.Items.Add("Mustang")
        ComboBox1.Items.Add("Baglung")
        ComboBox1.Items.Add("ilam")
        ComboBox2.Items.Add("Birgunj")
        ComboBox2.Items.Add("Kathmandu")
        ComboBox2.Items.Add("Pokhara")
        ComboBox2.Items.Add("Chitwan")
        ComboBox2.Items.Add("Nawalpur")
        ComboBox2.Items.Add("Biratnagar")
        ComboBox2.Items.Add("butwol")
        ComboBox2.Items.Add("Dhangadhi")
        ComboBox2.Items.Add("Palpa")
        ComboBox2.Items.Add("Bhaktapur")
        ComboBox1.Items.Add("Palpa")
        ComboBox1.Items.Add("Gorkha")
        ComboBox1.Items.Add("Mustang")
        ComboBox1.Items.Add("Baglung")
        ComboBox1.Items.Add("ilam")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loginmodule.con()
        Dim cmd As New SqlCommand
        Dim gender As String
        cmd.Connection = cn
        If (TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Or TextBox4.Text.Length = 0 Or RadioButton1.Text.Length = 0 Or RadioButton2.Text.Length = 0 Or RadioButton3.Text.Length = 0 Or ComboBox1.Text.Length = 0 Or ComboBox2.Text.Length = 0 Or TextBox5.Text.Length = 0 Or TextBox6.Text.Length = 0 Or TextBox7.Text.Length = 0 Or TextBox8.Text.Length = 0 Or MaskedTextBox1.Text.Length = 0) Then
            MsgBox("check the fields, no one can be blank")
        Else
            If (RadioButton1.Checked = True) Then
                gender = "male"
            Else
                gender = "female"
            End If
            Try
                Loginmodule.con()
                cmd.CommandText = "insert into Employeereg(EmployeeId,FirstName,LastName,Age,Gender,CurrentAddress,PermanentAddress,ContactNumber,Nationality,EmailId,Post,JoinDate,SalaryPerMonth) VALUES('" & TextBox1.Text & "', '" & Trim(TextBox2.Text) & "', '" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "','" & Trim(gender) & "','" & Trim(ComboBox1.Text) & "','" & Trim(ComboBox2.Text) & "','" & Trim(TextBox5.Text) & "','" & Trim(TextBox6.Text) & "','" & Trim(TextBox7.Text) & "','" & Trim(ComboBox3.Text) & "','" & Trim(MaskedTextBox1.Text) & "','" & Trim(TextBox8.Text) & "') "
                cmd.ExecuteNonQuery()
                MsgBox("Record inserted successfully")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                MaskedTextBox1.Text = ""
                ' RadioButton1.Text = ""
                'RadioButton2.Text = ""
                'RadioButton3.Text = ""
                ComboBox1.Text = ""
                ComboBox2.Text = ""
                ComboBox3.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Manager" Then
            TextBox8.Text = 70000
        End If
        If ComboBox3.SelectedItem = "Assistant Manager" Then
            TextBox8.Text = 35000
        End If
        If ComboBox3.SelectedItem = "Receptionist" Then
            TextBox8.Text = 15000
        End If
        If ComboBox3.SelectedItem = "Waiter" Then
            TextBox8.Text = 10000
        End If
        If ComboBox3.SelectedItem = "Security Guard" Then
            TextBox8.Text = 28000
        End If
        If ComboBox3.SelectedItem = "Kitchen Manager" Then
            TextBox8.Text = 30000
        End If
        If ComboBox3.SelectedItem = "Kitchen Staff" Then
            TextBox8.Text = "20000"
        End If
    End Sub
End Class
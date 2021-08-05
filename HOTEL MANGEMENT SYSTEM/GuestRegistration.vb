Imports System.Data.SqlClient
Public Class GuestRegistration

    Private Sub guestreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ComboBox3.Items.Add("Nawalpur")
        ComboBox3.Items.Add("Chitwan")
        ComboBox3.Items.Add("Kathmandu")
        ComboBox3.Items.Add("Pokhara")
        ComboBox3.Items.Add("Butwol")
        ComboBox3.Items.Add("Biratnagar")
        ComboBox3.Items.Add("Bhaktapur")
        ComboBox3.Items.Add("Dhangadhi")
        ComboBox3.Items.Add("Palpa")
        ComboBox3.Items.Add("Gorkha")
        ComboBox3.Items.Add("Mustang")
        ComboBox3.Items.Add("Baglung")
        ComboBox3.Items.Add("ilam")

        ComboBox5.Items.Add("Single")
        ComboBox5.Items.Add("Double")
        ComboBox5.Items.Add("Deluxe")

        ComboBox4.Items.Add("Standard Room")
        ComboBox4.Items.Add("Simple Room")
        ComboBox4.Items.Add("Suit Room")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Loginmodule.con()
        Dim cmd As New SqlCommand
        Dim gender As String
        cmd.Connection = cn
        If (TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Or TextBox3.Text.Length = 0 Or TextBox4.Text.Length = 0 Or RadioButton3.Text.Length = 0 Or RadioButton3.Text.Length = 0 Or RadioButton3.Text.Length = 0 Or ComboBox1.Text.Length = 0 Or TextBox5.Text.Length = 0 Or TextBox6.Text.Length = 0 Or ComboBox2.Text.Length = 0 Or ComboBox3.Text.Length = 0 Or TextBox7.Text.Length = 0 Or ComboBox4.Text.Length = 0 Or ComboBox5.Text.Length = 0 Or TextBox7.Text.Length = 0) Then
            MsgBox("check the fields, no one can be blank")
        Else
            If (RadioButton1.Checked = True) Then
                gender = "male"
            Else
                gender = "female"
            End If
            Try
                Loginmodule.con()
                cmd.CommandText = "insert into Guestreg(GuestId,FirstName,LastName,Age,Gender,Location,ContactNumber,Nationality,CommingFrom,GoingTo,RoomNo,RoomType,BedType,PricePerDay,ArrivalDate) VALUES('" & TextBox1.Text & "', '" & Trim(TextBox2.Text) & "', '" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "','" & Trim(gender) & "','" & Trim(ComboBox1.Text) & "','" & Trim(TextBox5.Text) & "','" & Trim(TextBox6.Text) & "','" & Trim(ComboBox2.Text) & "','" & Trim(ComboBox3.Text) & "','" & Trim(TextBox7.Text) & "','" & Trim(ComboBox4.Text) & "','" & Trim(ComboBox5.Text) & "','" & Trim(TextBox8.Text) & "','" & Trim(MaskedTextBox1.Text) & "') "
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
                ComboBox4.Text = ""
                ComboBox5.Text = ""

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()


    End Sub


    

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        MaskedTextBox1.Text = Date.Today
    End Sub
       


    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim standard, simple, suit As Integer
        Dim sgl, doub, del As Decimal
        ' price for room type
        standard = 1500
        simple = 1000
        suit = 1200
        ' price for bed type
        sgl = 1
        doub = 1.5
        del = 2
        If ComboBox4.SelectedItem = "Standard Room" Then
            Dim res As Integer
            If ComboBox5.SelectedItem = "Single" Then
                res = standard * sgl
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Double" Then
                res = standard * doub
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Deluxe" Then
                res = standard * del
                TextBox8.Text = res
            End If
        ElseIf ComboBox4.SelectedItem = "Simple Room" Then
            Dim res As Integer
            If ComboBox5.SelectedItem = "Single" Then
                res = simple * sgl
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Double" Then
                res = simple * doub
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Deluxe" Then
                res = simple * del
                TextBox8.Text = res
            End If
        ElseIf ComboBox4.SelectedItem = "Suit Room" Then
            Dim res As Integer
            If ComboBox5.SelectedItem = "Single" Then
                res = suit * sgl
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Double" Then
                res = suit * doub
                TextBox8.Text = res

            ElseIf ComboBox5.SelectedItem = "Deluxe" Then
                res = suit * del
                TextBox8.Text = res

            End If
        End If
    End Sub

    
   
End Class
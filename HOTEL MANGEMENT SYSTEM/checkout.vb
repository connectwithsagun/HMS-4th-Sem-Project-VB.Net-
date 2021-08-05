Imports System.Data.SqlClient
Public Class checkout
    Private Sub checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        Try
            Dim rdr As SqlDataReader
            Dim n As Int32
            Dim str As String = "select *from Guestreg"
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("GuestId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("Location")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("CommingFrom")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("GoingTo")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("ArrivalDate")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("RoomNo")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("GuestStatus")
                DataGridView1.Rows.Item(n).Cells(13).Value = rdr("RoomType")
                DataGridView1.Rows.Item(n).Cells(14).Value = rdr("BedType")
                DataGridView1.Rows.Item(n).Cells(15).Value = rdr("CheckOutDate")
                DataGridView1.Rows.Item(n).Cells(16).Value = rdr("RoomStatus")
                DataGridView1.Rows.Item(n).Cells(17).Value = rdr("PricePerDay")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
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
        TextBox14.Text = DataGridView1.CurrentRow.Cells.Item(13).Value
        TextBox15.Text = DataGridView1.CurrentRow.Cells.Item(14).Value
        ''TextBox16.Text = DataGridView1.CurrentRow.Cells.Item(15).Value
        TextBox17.Text = DataGridView1.CurrentRow.Cells.Item(16).Value
        TextBox18.Text = DataGridView1.CurrentRow.Cells.Item(17).Value
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cn.Close()
            cn.Open()
            Dim cmd1 As New SqlCommand
            cmd1.Connection = cn
            cmd1.CommandText = "update Guestreg set RoomStatus='" & (TextBox17.Text) & "',GuestStatus='" & Trim(TextBox13.Text) & "',CheckOutDate='" & Trim(TextBox16.Text) & "' where GuestId='" & TextBox1.Text & " ' "
            cmd1.ExecuteNonQuery()
            MsgBox("The Guest is Checked Out Successfully")
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
            TextBox14.Clear()
            TextBox15.Clear()
            TextBox16.Clear()
            TextBox17.Clear()
            TextBox18.Clear()

            DataGridView1.Rows.Clear()
            Loginmodule.con()
            Dim rdr As SqlDataReader
            Dim n As Int32
            Dim str As String = "select *from Guestreg"
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("GuestId")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("FirstName")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("LastName")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("Age")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("Gender")
                DataGridView1.Rows.Item(n).Cells(5).Value = rdr("Location")
                DataGridView1.Rows.Item(n).Cells(6).Value = rdr("ContactNumber")
                DataGridView1.Rows.Item(n).Cells(7).Value = rdr("Nationality")
                DataGridView1.Rows.Item(n).Cells(8).Value = rdr("CommingFrom")
                DataGridView1.Rows.Item(n).Cells(9).Value = rdr("GoingTo")
                DataGridView1.Rows.Item(n).Cells(10).Value = rdr("ArrivalDate")
                DataGridView1.Rows.Item(n).Cells(11).Value = rdr("RoomNo")
                DataGridView1.Rows.Item(n).Cells(12).Value = rdr("GuestStatus")
                DataGridView1.Rows.Item(n).Cells(13).Value = rdr("RoomType")
                DataGridView1.Rows.Item(n).Cells(14).Value = rdr("BedType")
                DataGridView1.Rows.Item(n).Cells(15).Value = rdr("CheckOutDate")
                DataGridView1.Rows.Item(n).Cells(16).Value = rdr("RoomStatus")
                DataGridView1.Rows.Item(n).Cells(17).Value = rdr("PricePerDay")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
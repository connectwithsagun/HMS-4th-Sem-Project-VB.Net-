﻿Imports System.Data.SqlClient
Public Class AvailableRoom
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        Loginmodule.con()
        Try
            Dim rdr As SqlDataReader
            Dim n As Int32
            Dim str As String = "select *from Guestreg where RoomStatus='leaved'"
            Dim cmd As New SqlCommand(str, Loginmodule.cn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                n = DataGridView1.Rows.Add()
                DataGridView1.Rows.Item(n).Cells(0).Value = rdr("RoomNo")
                DataGridView1.Rows.Item(n).Cells(1).Value = rdr("RoomType")
                DataGridView1.Rows.Item(n).Cells(2).Value = rdr("BedType")
                DataGridView1.Rows.Item(n).Cells(3).Value = rdr("PricePerDay")
                DataGridView1.Rows.Item(n).Cells(4).Value = rdr("RoomStatus")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
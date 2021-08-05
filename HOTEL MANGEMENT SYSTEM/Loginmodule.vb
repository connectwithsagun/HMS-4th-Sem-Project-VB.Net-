Imports System.Data.SqlClient
Module Loginmodule
    Public cn As SqlConnection
    Public Sub con()
        Dim strconnection As String = "Data Source=DESKTOP-7RAO8LE\SQLEXPRESS; Initial Catalog=Sytem;Integrated Security=True"
        cn = New SqlConnection(strconnection)
        cn.Open()
    End Sub
End Module

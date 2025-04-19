
Imports MySql.Data.MySqlClient

Module db

    Dim MysqlConn As New MySqlConnection

    Public Function myconn() As MySqlConnection
      
        Return New MySqlConnection(My.Settings.mydbConnection)
    End Function


End Module

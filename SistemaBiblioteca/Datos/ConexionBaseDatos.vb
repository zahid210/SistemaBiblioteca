Imports MySqlConnector

Public Class ConexionBaseDatos

    Private Const cadenaConexion As String =
        "Server=localhost;Port=3306;User ID=root;Password=root;Database=biblioteca;"

    Public Shared Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(cadenaConexion)
    End Function

End Class
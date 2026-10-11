
Imports MySqlConnector
Imports System.Data

Public Class CategoriaDatos

    Public Function ObtenerCategoriasActivas() As DataTable

        Dim tablaCategorias As New DataTable()

        Dim consulta As String =
            "SELECT id_categoria, nombre " &
            "FROM categorias " &
            "WHERE esta_activa = TRUE " &
            "ORDER BY nombre;"

        Using conexion As MySqlConnection =
            ConexionBaseDatos.ObtenerConexion()

            Using comando As New MySqlCommand(consulta, conexion)

                Using adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tablaCategorias)
                End Using

            End Using

        End Using

        Return tablaCategorias

    End Function

End Class

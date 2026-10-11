Imports MySqlConnector
Imports System.Data
Public Class LibroDatos
    Public Function ObtenerLibros() As DataTable

        Dim tablaLibros As New DataTable()

        Dim consulta As String =
            "SELECT " &
            "    l.id_libro, " &
            "    l.titulo, " &
            "    l.isbn, " &
            "    l.anio_publicacion, " &
            "    l.cantidad_total, " &
            "    l.cantidad_disponible, " &
            "    e.nombre AS nombre_editorial, " &
            "    c.nombre AS nombre_categoria " &
            "FROM libros l " &
            "INNER JOIN editoriales e " &
            "    ON l.id_editorial = e.id_editorial " &
            "INNER JOIN categorias c " &
            "    ON l.id_categoria = c.id_categoria " &
            "WHERE l.esta_activo = TRUE " &
            "ORDER BY l.titulo;"

        Using conexion As MySqlConnection = ConexionBaseDatos.ObtenerConexion()

            Using comando As New MySqlCommand(consulta, conexion)

                Using adaptador As New MySqlDataAdapter(comando)

                    adaptador.Fill(tablaLibros)

                End Using

            End Using

        End Using

        Return tablaLibros

    End Function


End Class

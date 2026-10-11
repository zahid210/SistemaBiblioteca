
Imports MySqlConnector
Imports System.Data

Public Class LibroDatos

    Public Function ObtenerLibros() As DataTable
        Return ObtenerLibrosConFiltro(Nothing)
    End Function

    Public Function BuscarLibros(textoBusqueda As String) As DataTable
        Return ObtenerLibrosConFiltro(textoBusqueda)
    End Function

    Private Function ObtenerLibrosConFiltro(
        textoBusqueda As String
    ) As DataTable

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
            "AND ( " &
            "    @textoBusqueda IS NULL " &
            "    OR l.titulo LIKE @textoBusqueda " &
            "    OR l.isbn LIKE @textoBusqueda " &
            ") " &
            "ORDER BY l.titulo;"

        Using conexion As MySqlConnection =
            ConexionBaseDatos.ObtenerConexion()

            Using comando As New MySqlCommand(consulta, conexion)

                Dim parametro =
                    comando.Parameters.Add(
                        "@textoBusqueda",
                        MySqlDbType.VarChar,
                        255
                    )

                If String.IsNullOrWhiteSpace(textoBusqueda) Then
                    parametro.Value = DBNull.Value
                Else
                    parametro.Value = "%" & textoBusqueda.Trim() & "%"
                End If

                Using adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tablaLibros)
                End Using

            End Using

        End Using

        Return tablaLibros

    End Function

End Class


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
            "    l.ubicacion, " &
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

    Public Function RegistrarLibro(libro As Libro) As Boolean
        Dim consulta As String =
        "INSERT INTO libros " &
        "(id_editorial, id_categoria, titulo, isbn, " &
        "anio_publicacion, cantidad_total, cantidad_disponible, " &
        "ubicacion, esta_activo) " &
        "VALUES " &
        "(@idEditorial, @idCategoria, @titulo, @isbn, " &
        "@anioPublicacion, @cantidadTotal, @cantidadDisponible, " &
        "@ubicacion, TRUE);"

        Using conexion As MySqlConnector.MySqlConnection =
       ConexionBaseDatos.ObtenerConexion()

            Using comando As New MySqlConnector.MySqlCommand(
                consulta, conexion)

                comando.Parameters.AddWithValue(
                    "@idEditorial", libro.IdEditorial)

                comando.Parameters.AddWithValue(
                    "@idCategoria", libro.IdCategoria)

                comando.Parameters.AddWithValue(
                    "@titulo", libro.Titulo.Trim())

                comando.Parameters.AddWithValue(
                    "@isbn",
                    If(String.IsNullOrWhiteSpace(libro.Isbn),
                       CType(DBNull.Value, Object),
                       libro.Isbn.Trim()))

                comando.Parameters.AddWithValue(
                    "@anioPublicacion", libro.AnioPublicacion)

                comando.Parameters.AddWithValue(
                    "@cantidadTotal", libro.CantidadTotal)

                comando.Parameters.AddWithValue(
                    "@cantidadDisponible", libro.CantidadTotal)

                comando.Parameters.AddWithValue(
                    "@ubicacion",
                    If(String.IsNullOrWhiteSpace(libro.Ubicacion),
                       CType(DBNull.Value, Object),
                       libro.Ubicacion.Trim()))

                conexion.Open()

                Return comando.ExecuteNonQuery() = 1

            End Using

        End Using


    End Function



End Class

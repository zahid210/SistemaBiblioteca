Imports MySqlConnector
Imports System.Data
Public Class EditorialDatos
    Public Function ObtenerEditoriales() As DataTable
        Dim tablaEditoriales As New DataTable()

        Dim consulta As String = "SELECT id_editorial, nombre " & "FROM editoriales " & "ORDER BY nombre;"

        Using conexion As MySqlConnection =
            ConexionBaseDatos.ObtenerConexion()

            Using comando As New MySqlCommand(consulta, conexion)

                Using adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tablaEditoriales)
                End Using

            End Using

        End Using

        Return tablaEditoriales

    End Function



End Class

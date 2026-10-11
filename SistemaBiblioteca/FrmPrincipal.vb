Imports MySqlConnector

Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Using conexion As MySqlConnection = ConexionBaseDatos.ObtenerConexion()

                conexion.Open()

                MessageBox.Show(
                    "Conexión a MySQL exitosa.",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo conectar con MySQL." & Environment.NewLine &
                ex.Message,
                "Error de conexión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

        Dim libroDatos As New LibroDatos()
        Dim tablaLibros As DataTable = libroDatos.ObtenerLibros()

        MessageBox.Show("Libros encontrados: " & tablaLibros.Rows.Count.ToString(), "Prueba Libros", MessageBoxButtons.OK, MessageBoxIcon.Information)








    End Sub

End Class
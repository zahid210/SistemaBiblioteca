Imports System.Data
Public Class FrmLibros
    Private ReadOnly libroDatos As New LibroDatos()

    Private Sub FrmLibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLibros()
    End Sub

    Private Sub CargarLibros()
        Try
            Dim tablaLibros As DataTable = libroDatos.ObtenerLibros()
            dgvLibros.DataSource = tablaLibros

        Catch ex As Exception
            MessageBox.Show(
                "No se pudieron cargar los libros." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try

            Dim tablaLibros As DataTable = libroDatos.BuscarLibros(txtBuscar.Text)
            dgvLibros.DataSource = tablaLibros

            If tablaLibros.Rows.Count = 0 Then
                MessageBox.Show(
                "No se encontraron libros con ese criterio.",
                "Búsqueda de libros",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            End If

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo realizar la búsqueda." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Using formulario As New FrmLibroNuevo()
            If formulario.ShowDialog(Me) = DialogResult.OK Then
                CargarLibros()

            End If
        End Using

    End Sub


    Private Sub btnEditar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditar.Click

        If dgvLibros.CurrentRow Is Nothing Then
            MessageBox.Show(
                "Selecciona un libro para editar.",
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim codigoLibro As Integer =
            Convert.ToInt32(
                dgvLibros.CurrentRow.Cells("colIdLibro").Value
            )

        Using formulario As New FrmLibroEditar(codigoLibro)

            If formulario.ShowDialog(Me) = DialogResult.OK Then
                CargarLibros()
            End If

        End Using

    End Sub

End Class
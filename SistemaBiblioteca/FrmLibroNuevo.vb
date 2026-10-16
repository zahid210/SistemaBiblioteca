Imports System.Data

Public Class FrmLibroNuevo
    Private ReadOnly editorialDatos As New EditorialDatos()
    Private ReadOnly categoriaDatos As New CategoriaDatos()
    Private ReadOnly libroDatos As New LibroDatos()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrWhiteSpace(txtTitulo.Text) Then
            MessageBox.Show(
            "Ingresa el título del libro.",
            "Validación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            txtTitulo.Focus()
            Return
        End If

        If cboEditorial.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona una editorial.")
            cboEditorial.Focus()
            Return
        End If

        If cboCategoria.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona una categoría.")
            cboCategoria.Focus()
            Return
        End If

        If nudCantidad.Value < 1 Then
            MessageBox.Show("La cantidad debe ser mayor que cero.")
            nudCantidad.Focus()
            Return
        End If

        Dim libro As New Libro With {
        .IdEditorial = CInt(cboEditorial.SelectedValue),
        .IdCategoria = CInt(cboCategoria.SelectedValue),
        .Titulo = txtTitulo.Text.Trim(),
        .Isbn = txtIsbn.Text.Trim(),
        .AnioPublicacion = CInt(nudAnio.Value),
        .CantidadTotal = CInt(nudCantidad.Value),
        .Ubicacion = txtUbicacion.Text.Trim()
        }

        Try
            If libroDatos.RegistrarLibro(libro) Then

                MessageBox.Show(
                    "El libro se registró correctamente.",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else
                MessageBox.Show(
                    "No se pudo registrar el libro.",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            End If

        Catch ex As MySqlConnector.MySqlException
            MessageBox.Show(
                "Error al registrar el libro." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception
            MessageBox.Show(
                "Ocurrió un error inesperado." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub FrmLibroNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarEditoriales()

    End Sub

    Private Sub CargarEditoriales()
        Try

            Dim tablaEditoriales As DataTable = editorialDatos.ObtenerEditoriales()
            cboEditorial.DataSource = tablaEditoriales
            cboEditorial.DisplayMember = "nombre"
            cboEditorial.ValueMember = "id_editorial"
            cboEditorial.SelectedIndex = -1


        Catch ex As Exception
            MessageBox.Show(
                "No se pudieron cargar las editoriales." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub


    Private Sub CargarCategorias()

        Try

            Dim tablaCategorias As DataTable = categoriaDatos.ObtenerCategoriasActivas()

            cboCategoria.DataSource = tablaCategorias
            cboCategoria.DisplayMember = "nombre"
            cboCategoria.ValueMember = "id_categoria"
            cboCategoria.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(
                "No se pudieron cargar las categorías." &
                Environment.NewLine & ex.Message,
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try


    End Sub

End Class
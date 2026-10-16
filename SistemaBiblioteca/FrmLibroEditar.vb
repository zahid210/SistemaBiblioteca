
Imports System.Data

Public Class FrmLibroEditar

    Private ReadOnly libroDatos As New LibroDatos()
    Private ReadOnly editorialDatos As New EditorialDatos()
    Private ReadOnly categoriaDatos As New CategoriaDatos()

    Private idLibro As Integer

    Public Sub New(codigoLibro As Integer)

        InitializeComponent()
        idLibro = codigoLibro

    End Sub

    Private Sub FrmLibroEditar_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        CargarEditoriales()
        CargarCategorias()
        CargarDatosLibro()

    End Sub

    Private Sub CargarEditoriales()

        Dim tablaEditoriales As DataTable =
            editorialDatos.ObtenerEditoriales()

        cboEditorial.DataSource = tablaEditoriales
        cboEditorial.DisplayMember = "nombre"
        cboEditorial.ValueMember = "id_editorial"
        cboEditorial.SelectedIndex = -1

    End Sub

    Private Sub CargarCategorias()

        Dim tablaCategorias As DataTable =
            categoriaDatos.ObtenerCategoriasActivas()

        cboCategoria.DataSource = tablaCategorias
        cboCategoria.DisplayMember = "nombre"
        cboCategoria.ValueMember = "id_categoria"
        cboCategoria.SelectedIndex = -1

    End Sub

    Private Sub CargarDatosLibro()

        Dim tablaLibro As DataTable =
            libroDatos.ObtenerLibroPorId(idLibro)

        If tablaLibro.Rows.Count = 0 Then
            MessageBox.Show(
                "No se encontró el libro seleccionado.",
                "Sistema de Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Me.Close()
            Return
        End If

        Dim fila As DataRow = tablaLibro.Rows(0)

        txtTitulo.Text = fila("titulo").ToString()
        txtIsbn.Text = fila("isbn").ToString()
        nudAnio.Value = Convert.ToDecimal(fila("anio_publicacion"))
        nudCantidad.Value = Convert.ToDecimal(fila("cantidad_total"))
        txtUbicacion.Text = fila("ubicacion").ToString()

        cboEditorial.SelectedValue =
            Convert.ToInt32(fila("id_editorial"))

        cboCategoria.SelectedValue =
            Convert.ToInt32(fila("id_categoria"))

    End Sub


    Private Sub btnGuardar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGuardar.Click

        If String.IsNullOrWhiteSpace(txtTitulo.Text) Then
            MessageBox.Show("Ingresa el título del libro.")
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
            If libroDatos.ActualizarLibro(idLibro, libro) Then

                MessageBox.Show(
                    "El libro se actualizó correctamente.",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else
                MessageBox.Show(
                    "No se actualizaron los datos. Comprueba que el libro siga activo " &
                    "y que la cantidad total no sea inferior a la cantidad disponible.",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            End If

        Catch ex As MySqlConnector.MySqlException
            MessageBox.Show(
                "Error al actualizar el libro." &
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


    Private Sub btnCancelar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelar.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class

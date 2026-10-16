
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

End Class

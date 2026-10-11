Imports System.Data
Public Class FrmLibroNuevo
    Private ReadOnly editorialDatos As New EditorialDatos()
    Private ReadOnly categoriaDatos As New CategoriaDatos()

    Private Sub FrmLibroNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategorias()
        CargarEditoriales()


    End Sub

    Private Sub CargarEditoriales()
        Try

            Dim tablaEditoriales As DataTable = editorialDatos.ObtenerEditoriales
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
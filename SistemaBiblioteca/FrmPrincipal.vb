Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Dim formularioLibros As New FrmLibros()
        formularioLibros.Show()

    End Sub

End Class
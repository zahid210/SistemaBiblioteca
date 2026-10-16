<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibroEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtTitulo = New TextBox()
        txtIsbn = New TextBox()
        nudAnio = New NumericUpDown()
        cboEditorial = New ComboBox()
        cboCategoria = New ComboBox()
        nudCantidad = New NumericUpDown()
        txtUbicacion = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(nudAnio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(31, 44)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(156, 23)
        txtTitulo.TabIndex = 0
        ' 
        ' txtIsbn
        ' 
        txtIsbn.Location = New Point(31, 97)
        txtIsbn.Name = "txtIsbn"
        txtIsbn.Size = New Size(156, 23)
        txtIsbn.TabIndex = 1
        ' 
        ' nudAnio
        ' 
        nudAnio.Location = New Point(31, 257)
        nudAnio.Name = "nudAnio"
        nudAnio.Size = New Size(79, 23)
        nudAnio.TabIndex = 2
        ' 
        ' cboEditorial
        ' 
        cboEditorial.FormattingEnabled = True
        cboEditorial.Location = New Point(31, 151)
        cboEditorial.Name = "cboEditorial"
        cboEditorial.Size = New Size(156, 23)
        cboEditorial.TabIndex = 3
        ' 
        ' cboCategoria
        ' 
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(31, 204)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(156, 23)
        cboCategoria.TabIndex = 4
        ' 
        ' nudCantidad
        ' 
        nudCantidad.Location = New Point(117, 257)
        nudCantidad.Name = "nudCantidad"
        nudCantidad.Size = New Size(71, 23)
        nudCantidad.TabIndex = 5
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Location = New Point(31, 314)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(156, 23)
        txtUbicacion.TabIndex = 6
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(31, 355)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guadar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(112, 355)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 9
        Label1.Text = "Titulo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 15)
        Label2.TabIndex = 10
        Label2.Text = "ISBN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 11
        Label3.Text = "Editorial"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 12
        Label4.Text = "Categoria"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 15)
        Label5.TabIndex = 13
        Label5.Text = "Año"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(117, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 14
        Label6.Text = "Cantidad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 292)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 15
        Label7.Text = "Ubicacion"
        ' 
        ' FrmLibroEditar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 404)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(txtUbicacion)
        Controls.Add(nudCantidad)
        Controls.Add(cboCategoria)
        Controls.Add(cboEditorial)
        Controls.Add(nudAnio)
        Controls.Add(txtIsbn)
        Controls.Add(txtTitulo)
        Name = "FrmLibroEditar"
        Text = "FrmLibroEditar"
        CType(nudAnio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents nudAnio As NumericUpDown
    Friend WithEvents cboEditorial As ComboBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

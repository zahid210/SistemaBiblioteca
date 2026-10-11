<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibroNuevo
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
        txtUbicacion = New TextBox()
        nudAnio = New NumericUpDown()
        cboEditorial = New ComboBox()
        cboCategoria = New ComboBox()
        nudCantidad = New NumericUpDown()
        btnGuardar = New Button()
        btnCancelar = New Button()
        lblTitulo = New Label()
        lblIsbn = New Label()
        lblCantidad = New Label()
        lblAnio = New Label()
        lblUbicacion = New Label()
        lblCategoria = New Label()
        lblEditorial = New Label()
        CType(nudAnio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(23, 37)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(151, 23)
        txtTitulo.TabIndex = 0
        ' 
        ' txtIsbn
        ' 
        txtIsbn.Location = New Point(180, 36)
        txtIsbn.Name = "txtIsbn"
        txtIsbn.Size = New Size(136, 23)
        txtIsbn.TabIndex = 1
        ' 
        ' txtUbicacion
        ' 
        txtUbicacion.Location = New Point(23, 95)
        txtUbicacion.Name = "txtUbicacion"
        txtUbicacion.Size = New Size(151, 23)
        txtUbicacion.TabIndex = 2
        ' 
        ' nudAnio
        ' 
        nudAnio.Location = New Point(111, 157)
        nudAnio.Maximum = New Decimal(New Integer() {2026, 0, 0, 0})
        nudAnio.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudAnio.Name = "nudAnio"
        nudAnio.Size = New Size(50, 23)
        nudAnio.TabIndex = 3
        nudAnio.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' cboEditorial
        ' 
        cboEditorial.DropDownStyle = ComboBoxStyle.DropDownList
        cboEditorial.FormattingEnabled = True
        cboEditorial.Location = New Point(179, 156)
        cboEditorial.Name = "cboEditorial"
        cboEditorial.Size = New Size(137, 23)
        cboEditorial.TabIndex = 4
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(180, 95)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(136, 23)
        cboCategoria.TabIndex = 5
        ' 
        ' nudCantidad
        ' 
        nudCantidad.Location = New Point(23, 157)
        nudCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudCantidad.Name = "nudCantidad"
        nudCantidad.Size = New Size(82, 23)
        nudCantidad.TabIndex = 6
        nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(170, 199)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(147, 23)
        btnGuardar.TabIndex = 7
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(23, 199)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(140, 23)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(23, 19)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(37, 15)
        lblTitulo.TabIndex = 9
        lblTitulo.Text = "Titulo"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIsbn
        ' 
        lblIsbn.AutoSize = True
        lblIsbn.Location = New Point(180, 18)
        lblIsbn.Name = "lblIsbn"
        lblIsbn.Size = New Size(32, 15)
        lblIsbn.TabIndex = 10
        lblIsbn.Text = "ISBN"
        lblIsbn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Location = New Point(21, 134)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(55, 15)
        lblCantidad.TabIndex = 11
        lblCantidad.Text = "Cantidad"
        ' 
        ' lblAnio
        ' 
        lblAnio.AutoSize = True
        lblAnio.Location = New Point(111, 134)
        lblAnio.Name = "lblAnio"
        lblAnio.Size = New Size(29, 15)
        lblAnio.TabIndex = 12
        lblAnio.Text = "Año"
        lblAnio.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUbicacion
        ' 
        lblUbicacion.AutoSize = True
        lblUbicacion.Location = New Point(23, 76)
        lblUbicacion.Name = "lblUbicacion"
        lblUbicacion.Size = New Size(60, 15)
        lblUbicacion.TabIndex = 13
        lblUbicacion.Text = "Ubicacion"
        lblUbicacion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New Point(180, 76)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New Size(58, 15)
        lblCategoria.TabIndex = 14
        lblCategoria.Text = "Categoria"
        lblCategoria.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEditorial
        ' 
        lblEditorial.AutoSize = True
        lblEditorial.Location = New Point(179, 134)
        lblEditorial.Name = "lblEditorial"
        lblEditorial.Size = New Size(50, 15)
        lblEditorial.TabIndex = 15
        lblEditorial.Text = "Editorial"
        lblEditorial.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FrmLibroNuevo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(341, 242)
        Controls.Add(lblEditorial)
        Controls.Add(lblCategoria)
        Controls.Add(lblUbicacion)
        Controls.Add(lblAnio)
        Controls.Add(lblCantidad)
        Controls.Add(lblIsbn)
        Controls.Add(lblTitulo)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(nudCantidad)
        Controls.Add(cboCategoria)
        Controls.Add(cboEditorial)
        Controls.Add(nudAnio)
        Controls.Add(txtUbicacion)
        Controls.Add(txtIsbn)
        Controls.Add(txtTitulo)
        Name = "FrmLibroNuevo"
        Text = "FrmLibroNuevo"
        CType(nudAnio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents nudAnio As NumericUpDown
    Friend WithEvents cboEditorial As ComboBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblIsbn As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblEditorial As Label
End Class

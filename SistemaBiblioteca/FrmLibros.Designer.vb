<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibros
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
        btnBuscar = New Button()
        lblBuscar = New Label()
        lblTitutlo = New Label()
        txtBuscar = New TextBox()
        dgvLibros = New DataGridView()
        btnNuevo = New Button()
        btnEditar = New Button()
        btnDesactivar = New Button()
        colIdLibro = New DataGridViewTextBoxColumn()
        colTitulo = New DataGridViewTextBoxColumn()
        colUbicacion = New DataGridViewTextBoxColumn()
        colIsbn = New DataGridViewTextBoxColumn()
        colAnio = New DataGridViewTextBoxColumn()
        colEditorial = New DataGridViewTextBoxColumn()
        colCategoria = New DataGridViewTextBoxColumn()
        colCantidadTotal = New DataGridViewTextBoxColumn()
        colDisponibles = New DataGridViewTextBoxColumn()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(695, 83)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 0
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New Point(42, 56)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(45, 15)
        lblBuscar.TabIndex = 1
        lblBuscar.Text = "Buscar:"
        ' 
        ' lblTitutlo
        ' 
        lblTitutlo.AutoSize = True
        lblTitutlo.Location = New Point(364, 28)
        lblTitutlo.Name = "lblTitutlo"
        lblTitutlo.Size = New Size(98, 15)
        lblTitutlo.TabIndex = 2
        lblTitutlo.Text = "Gestion de Libros"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(43, 83)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(646, 23)
        txtBuscar.TabIndex = 3
        ' 
        ' dgvLibros
        ' 
        dgvLibros.AllowUserToAddRows = False
        dgvLibros.AllowUserToDeleteRows = False
        dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Columns.AddRange(New DataGridViewColumn() {colIdLibro, colTitulo, colUbicacion, colIsbn, colAnio, colEditorial, colCategoria, colCantidadTotal, colDisponibles})
        dgvLibros.Location = New Point(42, 112)
        dgvLibros.MultiSelect = False
        dgvLibros.Name = "dgvLibros"
        dgvLibros.ReadOnly = True
        dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLibros.Size = New Size(728, 239)
        dgvLibros.TabIndex = 4
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(695, 366)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(75, 23)
        btnNuevo.TabIndex = 5
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(614, 366)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(75, 23)
        btnEditar.TabIndex = 6
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnDesactivar
        ' 
        btnDesactivar.Location = New Point(533, 366)
        btnDesactivar.Name = "btnDesactivar"
        btnDesactivar.Size = New Size(75, 23)
        btnDesactivar.TabIndex = 7
        btnDesactivar.Text = "Desactivar"
        btnDesactivar.UseVisualStyleBackColor = True
        ' 
        ' colIdLibro
        ' 
        colIdLibro.DataPropertyName = "id_libro"
        colIdLibro.HeaderText = "Código"
        colIdLibro.Name = "colIdLibro"
        colIdLibro.ReadOnly = True
        colIdLibro.Visible = False
        ' 
        ' colTitulo
        ' 
        colTitulo.DataPropertyName = "titulo"
        colTitulo.HeaderText = "Titulo"
        colTitulo.Name = "colTitulo"
        colTitulo.ReadOnly = True
        ' 
        ' colUbicacion
        ' 
        colUbicacion.DataPropertyName = "ubicacion"
        colUbicacion.HeaderText = "Ubicacion"
        colUbicacion.Name = "colUbicacion"
        colUbicacion.ReadOnly = True
        ' 
        ' colIsbn
        ' 
        colIsbn.DataPropertyName = "isbn"
        colIsbn.HeaderText = "ISBN"
        colIsbn.Name = "colIsbn"
        colIsbn.ReadOnly = True
        ' 
        ' colAnio
        ' 
        colAnio.DataPropertyName = "anio_publicacion"
        colAnio.HeaderText = "Año"
        colAnio.Name = "colAnio"
        colAnio.ReadOnly = True
        ' 
        ' colEditorial
        ' 
        colEditorial.DataPropertyName = "nombre_editorial"
        colEditorial.HeaderText = "Editorial"
        colEditorial.Name = "colEditorial"
        colEditorial.ReadOnly = True
        ' 
        ' colCategoria
        ' 
        colCategoria.DataPropertyName = "nombre_categoria"
        colCategoria.HeaderText = "Categoria"
        colCategoria.Name = "colCategoria"
        colCategoria.ReadOnly = True
        ' 
        ' colCantidadTotal
        ' 
        colCantidadTotal.DataPropertyName = "cantidad_total"
        colCantidadTotal.HeaderText = "Ejemplares"
        colCantidadTotal.Name = "colCantidadTotal"
        colCantidadTotal.ReadOnly = True
        ' 
        ' colDisponibles
        ' 
        colDisponibles.DataPropertyName = "cantidad_disponible"
        colDisponibles.HeaderText = "Disponibles"
        colDisponibles.Name = "colDisponibles"
        colDisponibles.ReadOnly = True
        ' 
        ' FrmLibros
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(820, 405)
        Controls.Add(btnDesactivar)
        Controls.Add(btnEditar)
        Controls.Add(btnNuevo)
        Controls.Add(dgvLibros)
        Controls.Add(txtBuscar)
        Controls.Add(lblTitutlo)
        Controls.Add(lblBuscar)
        Controls.Add(btnBuscar)
        Name = "FrmLibros"
        Text = "FrmLibros"
        TopMost = True
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblTitutlo As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnDesactivar As Button
    Friend WithEvents colIdLibro As DataGridViewTextBoxColumn
    Friend WithEvents colTitulo As DataGridViewTextBoxColumn
    Friend WithEvents colUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents colIsbn As DataGridViewTextBoxColumn
    Friend WithEvents colAnio As DataGridViewTextBoxColumn
    Friend WithEvents colEditorial As DataGridViewTextBoxColumn
    Friend WithEvents colCategoria As DataGridViewTextBoxColumn
    Friend WithEvents colCantidadTotal As DataGridViewTextBoxColumn
    Friend WithEvents colDisponibles As DataGridViewTextBoxColumn
End Class

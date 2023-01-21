<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPuesto
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Id_PuestoLabel As System.Windows.Forms.Label
        Dim Nom_PuestoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPuesto))
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.PuestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PuestoTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.PuestoTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PuestoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Id_PuestoLabel = New System.Windows.Forms.Label()
        Nom_PuestoLabel = New System.Windows.Forms.Label()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PuestoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(117, 235)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(52, 35)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'Id_PuestoLabel
        '
        Id_PuestoLabel.AutoSize = True
        Id_PuestoLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_PuestoLabel.Location = New System.Drawing.Point(33, 285)
        Id_PuestoLabel.Name = "Id_PuestoLabel"
        Id_PuestoLabel.Size = New System.Drawing.Size(136, 35)
        Id_PuestoLabel.TabIndex = 3
        Id_PuestoLabel.Text = "Id Puesto:"
        '
        'Nom_PuestoLabel
        '
        Nom_PuestoLabel.AutoSize = True
        Nom_PuestoLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Nom_PuestoLabel.Location = New System.Drawing.Point(53, 341)
        Nom_PuestoLabel.Name = "Nom_PuestoLabel"
        Nom_PuestoLabel.Size = New System.Drawing.Size(116, 35)
        Nom_PuestoLabel.TabIndex = 5
        Nom_PuestoLabel.Text = "Nombre:"
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PuestoBindingSource
        '
        Me.PuestoBindingSource.DataMember = "Puesto"
        Me.PuestoBindingSource.DataSource = Me.ArandanosDataSet
        '
        'PuestoTableAdapter
        '
        Me.PuestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.PuestoTableAdapter = Me.PuestoTableAdapter
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'IdTextBox
        '
        Me.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PuestoBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(194, 230)
        Me.IdTextBox.MaximumSize = New System.Drawing.Size(100, 50)
        Me.IdTextBox.MaxLength = 3
        Me.IdTextBox.MinimumSize = New System.Drawing.Size(100, 40)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdTextBox.TabIndex = 2
        '
        'Id_PuestoTextBox
        '
        Me.Id_PuestoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PuestoBindingSource, "Id_Puesto", True))
        Me.Id_PuestoTextBox.Location = New System.Drawing.Point(194, 280)
        Me.Id_PuestoTextBox.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Id_PuestoTextBox.MaxLength = 2
        Me.Id_PuestoTextBox.MinimumSize = New System.Drawing.Size(100, 40)
        Me.Id_PuestoTextBox.Name = "Id_PuestoTextBox"
        Me.Id_PuestoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Id_PuestoTextBox.TabIndex = 4
        '
        'Nom_PuestoTextBox
        '
        Me.Nom_PuestoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nom_PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PuestoBindingSource, "nom_Puesto", True))
        Me.Nom_PuestoTextBox.Location = New System.Drawing.Point(194, 336)
        Me.Nom_PuestoTextBox.MaximumSize = New System.Drawing.Size(100, 50)
        Me.Nom_PuestoTextBox.MinimumSize = New System.Drawing.Size(100, 40)
        Me.Nom_PuestoTextBox.Name = "Nom_PuestoTextBox"
        Me.Nom_PuestoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nom_PuestoTextBox.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(28, 23)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(27, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 35)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Ingresar un nuevo puesto:"
        '
        'PuestoDataGridView
        '
        Me.PuestoDataGridView.AllowUserToAddRows = False
        Me.PuestoDataGridView.AllowUserToDeleteRows = False
        Me.PuestoDataGridView.AutoGenerateColumns = False
        Me.PuestoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PuestoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Puesto, Me.Nombre})
        Me.PuestoDataGridView.DataSource = Me.PuestoBindingSource
        Me.PuestoDataGridView.Location = New System.Drawing.Point(390, 184)
        Me.PuestoDataGridView.Name = "PuestoDataGridView"
        Me.PuestoDataGridView.ReadOnly = True
        Me.PuestoDataGridView.RowHeadersVisible = False
        Me.PuestoDataGridView.RowTemplate.Height = 24
        Me.PuestoDataGridView.Size = New System.Drawing.Size(300, 192)
        Me.PuestoDataGridView.TabIndex = 21
        '
        'Id_Puesto
        '
        Me.Id_Puesto.DataPropertyName = "Id_Puesto"
        Me.Id_Puesto.HeaderText = "Id Puesto"
        Me.Id_Puesto.Name = "Id_Puesto"
        Me.Id_Puesto.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nom_Puesto"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(390, 86)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BSalir.Size = New System.Drawing.Size(200, 75)
        Me.BSalir.TabIndex = 22
        Me.BSalir.Text = "Regresar"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.White
        Me.BNuevo.Location = New System.Drawing.Point(28, 398)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 23
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.White
        Me.BEliminar.Location = New System.Drawing.Point(144, 398)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 24
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(254, 398)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 25
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(369, 398)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 30
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'FPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 453)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.PuestoDataGridView)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Id_PuestoLabel)
        Me.Controls.Add(Me.Id_PuestoTextBox)
        Me.Controls.Add(Nom_PuestoLabel)
        Me.Controls.Add(Me.Nom_PuestoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPuesto"
        Me.Text = "Administrar Puestos"
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PuestoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents PuestoBindingSource As BindingSource
    Friend WithEvents PuestoTableAdapter As arandanosDataSetTableAdapters.PuestoTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Id_PuestoTextBox As TextBox
    Friend WithEvents Nom_PuestoTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PuestoDataGridView As DataGridView
    Friend WithEvents BSalir As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents Id_Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
End Class

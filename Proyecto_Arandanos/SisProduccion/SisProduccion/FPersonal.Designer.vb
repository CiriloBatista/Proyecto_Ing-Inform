<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPersonal
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
        Dim Id_PersonalLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim Id_PuestoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPersonal))
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.Id_PersonalTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PuestoTextBox = New System.Windows.Forms.TextBox()
        Me.PersonalDataGridView = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PersonalTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.PersonalTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        IdLabel = New System.Windows.Forms.Label()
        Id_PersonalLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        Id_PuestoLabel = New System.Windows.Forms.Label()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        IdLabel.Location = New System.Drawing.Point(143, 239)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(52, 35)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'Id_PersonalLabel
        '
        Id_PersonalLabel.AutoSize = True
        Id_PersonalLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_PersonalLabel.Location = New System.Drawing.Point(36, 287)
        Id_PersonalLabel.Name = "Id_PersonalLabel"
        Id_PersonalLabel.Size = New System.Drawing.Size(158, 35)
        Id_PersonalLabel.TabIndex = 3
        Id_PersonalLabel.Text = "Id Personal:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(78, 333)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(116, 35)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        ApellidoLabel.Location = New System.Drawing.Point(78, 380)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(117, 35)
        ApellidoLabel.TabIndex = 7
        ApellidoLabel.Text = "Apellido:"
        '
        'Id_PuestoLabel
        '
        Id_PuestoLabel.AutoSize = True
        Id_PuestoLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_PuestoLabel.Location = New System.Drawing.Point(59, 426)
        Id_PuestoLabel.Name = "Id_PuestoLabel"
        Id_PuestoLabel.Size = New System.Drawing.Size(136, 35)
        Id_PuestoLabel.TabIndex = 9
        Id_PuestoLabel.Text = "Id Puesto:"
        '
        'IdTextBox
        '
        Me.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.IdTextBox.Location = New System.Drawing.Point(206, 232)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 40)
        Me.IdTextBox.TabIndex = 2
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.ArandanosDataSet
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_PersonalTextBox
        '
        Me.Id_PersonalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_PersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "Id_Personal", True))
        Me.Id_PersonalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Id_PersonalTextBox.Location = New System.Drawing.Point(205, 283)
        Me.Id_PersonalTextBox.MaxLength = 3
        Me.Id_PersonalTextBox.Name = "Id_PersonalTextBox"
        Me.Id_PersonalTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_PersonalTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(206, 330)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 40)
        Me.NombreTextBox.TabIndex = 6
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "apellido", True))
        Me.ApellidoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.ApellidoTextBox.Location = New System.Drawing.Point(206, 376)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(200, 40)
        Me.ApellidoTextBox.TabIndex = 8
        '
        'Id_PuestoTextBox
        '
        Me.Id_PuestoTextBox.AllowDrop = True
        Me.Id_PuestoTextBox.AutoCompleteCustomSource.AddRange(New String() {"01", "02", "03", "04"})
        Me.Id_PuestoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_PuestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonalBindingSource, "id_Puesto", True))
        Me.Id_PuestoTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Id_PuestoTextBox.Location = New System.Drawing.Point(206, 422)
        Me.Id_PuestoTextBox.MaxLength = 2
        Me.Id_PuestoTextBox.Name = "Id_PuestoTextBox"
        Me.Id_PuestoTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_PuestoTextBox.TabIndex = 10
        '
        'PersonalDataGridView
        '
        Me.PersonalDataGridView.AllowUserToAddRows = False
        Me.PersonalDataGridView.AllowUserToDeleteRows = False
        Me.PersonalDataGridView.AutoGenerateColumns = False
        Me.PersonalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.DataGridViewTextBoxColumn3})
        Me.PersonalDataGridView.DataSource = Me.PersonalBindingSource
        Me.PersonalDataGridView.Location = New System.Drawing.Point(455, 181)
        Me.PersonalDataGridView.Name = "PersonalDataGridView"
        Me.PersonalDataGridView.ReadOnly = True
        Me.PersonalDataGridView.RowHeadersVisible = False
        Me.PersonalDataGridView.RowTemplate.Height = 24
        Me.PersonalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PersonalDataGridView.Size = New System.Drawing.Size(424, 280)
        Me.PersonalDataGridView.TabIndex = 11
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(38, 480)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 12
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(378, 480)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 13
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(262, 480)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 14
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(149, 480)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 15
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 35)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Administración de Personal"
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CosechaTableAdapter = Nothing
        Me.TableAdapterManager.CubetasTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductorTableAdapter = Nothing
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'FPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 543)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.PersonalDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Id_PersonalLabel)
        Me.Controls.Add(Me.Id_PersonalTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(Id_PuestoLabel)
        Me.Controls.Add(Me.Id_PuestoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPersonal"
        Me.Text = "Administración de Personal"
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As arandanosDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Id_PersonalTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents Id_PuestoTextBox As TextBox
    Friend WithEvents PersonalDataGridView As DataGridView
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BNuevo As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class

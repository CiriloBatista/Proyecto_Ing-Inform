<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCubetas
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
        Dim Id_regCubetaLabel As System.Windows.Forms.Label
        Dim Id_PersonalLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CubetaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCubetas))
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.CubetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CubetasTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.CubetasTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.CubetasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Id_regCubetaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_PersonalTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CubetaTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.LabelRegistroCubetas = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Id_regCubetaLabel = New System.Windows.Forms.Label()
        Id_PersonalLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CubetaLabel = New System.Windows.Forms.Label()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CubetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CubetasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_regCubetaLabel
        '
        Id_regCubetaLabel.AutoSize = True
        Id_regCubetaLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_regCubetaLabel.Location = New System.Drawing.Point(99, 217)
        Id_regCubetaLabel.Name = "Id_regCubetaLabel"
        Id_regCubetaLabel.Size = New System.Drawing.Size(140, 35)
        Id_regCubetaLabel.TabIndex = 1
        Id_regCubetaLabel.Text = "Id Cubeta:"
        '
        'Id_PersonalLabel
        '
        Id_PersonalLabel.AutoSize = True
        Id_PersonalLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_PersonalLabel.Location = New System.Drawing.Point(82, 269)
        Id_PersonalLabel.Name = "Id_PersonalLabel"
        Id_PersonalLabel.Size = New System.Drawing.Size(158, 35)
        Id_PersonalLabel.TabIndex = 3
        Id_PersonalLabel.Text = "Id Personal:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(128, 324)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(116, 35)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'CubetaLabel
        '
        CubetaLabel.AutoSize = True
        CubetaLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        CubetaLabel.Location = New System.Drawing.Point(82, 378)
        CubetaLabel.Name = "CubetaLabel"
        CubetaLabel.Size = New System.Drawing.Size(157, 35)
        CubetaLabel.TabIndex = 7
        CubetaLabel.Text = "Cubeta (kg):"
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CubetasBindingSource
        '
        Me.CubetasBindingSource.DataMember = "Cubetas"
        Me.CubetasBindingSource.DataSource = Me.ArandanosDataSet
        '
        'CubetasTableAdapter
        '
        Me.CubetasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CosechaTableAdapter = Nothing
        Me.TableAdapterManager.CubetasTableAdapter = Me.CubetasTableAdapter
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductorTableAdapter = Nothing
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'CubetasDataGridView
        '
        Me.CubetasDataGridView.AllowUserToAddRows = False
        Me.CubetasDataGridView.AllowUserToDeleteRows = False
        Me.CubetasDataGridView.AutoGenerateColumns = False
        Me.CubetasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CubetasDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.CubetasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CubetasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.CubetasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CubetasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CubetasDataGridView.DataSource = Me.CubetasBindingSource
        Me.CubetasDataGridView.Location = New System.Drawing.Point(476, 176)
        Me.CubetasDataGridView.Name = "CubetasDataGridView"
        Me.CubetasDataGridView.ReadOnly = True
        Me.CubetasDataGridView.RowHeadersVisible = False
        Me.CubetasDataGridView.RowTemplate.Height = 24
        Me.CubetasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CubetasDataGridView.Size = New System.Drawing.Size(500, 360)
        Me.CubetasDataGridView.TabIndex = 1
        '
        'Id_regCubetaTextBox
        '
        Me.Id_regCubetaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_regCubetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CubetasBindingSource, "Id_regCubeta", True))
        Me.Id_regCubetaTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Id_regCubetaTextBox.Location = New System.Drawing.Point(251, 214)
        Me.Id_regCubetaTextBox.MinimumSize = New System.Drawing.Size(100, 40)
        Me.Id_regCubetaTextBox.Name = "Id_regCubetaTextBox"
        Me.Id_regCubetaTextBox.ReadOnly = True
        Me.Id_regCubetaTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_regCubetaTextBox.TabIndex = 2
        '
        'Id_PersonalTextBox
        '
        Me.Id_PersonalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_PersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CubetasBindingSource, "Id_Personal", True))
        Me.Id_PersonalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Id_PersonalTextBox.Location = New System.Drawing.Point(250, 267)
        Me.Id_PersonalTextBox.Name = "Id_PersonalTextBox"
        Me.Id_PersonalTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_PersonalTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CubetasBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTextBox.Location = New System.Drawing.Point(250, 322)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(145, 40)
        Me.NombreTextBox.TabIndex = 6
        '
        'CubetaTextBox
        '
        Me.CubetaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CubetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CubetasBindingSource, "cubeta", True))
        Me.CubetaTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.CubetaTextBox.Location = New System.Drawing.Point(249, 375)
        Me.CubetaTextBox.MaxLength = 3
        Me.CubetaTextBox.Name = "CubetaTextBox"
        Me.CubetaTextBox.Size = New System.Drawing.Size(100, 40)
        Me.CubetaTextBox.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(129, 463)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 23
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(242, 463)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 22
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(358, 463)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 21
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(18, 463)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 20
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'LabelRegistroCubetas
        '
        Me.LabelRegistroCubetas.AutoSize = True
        Me.LabelRegistroCubetas.BackColor = System.Drawing.Color.LightGreen
        Me.LabelRegistroCubetas.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRegistroCubetas.Location = New System.Drawing.Point(350, 60)
        Me.LabelRegistroCubetas.Name = "LabelRegistroCubetas"
        Me.LabelRegistroCubetas.Size = New System.Drawing.Size(351, 48)
        Me.LabelRegistroCubetas.TabIndex = 24
        Me.LabelRegistroCubetas.Text = "Registro de cubetas"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_regCubeta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Cubeta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id_Personal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Personal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cubeta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cubeta(kg)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 173)
        Me.Panel1.TabIndex = 25
        '
        'FCubetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 543)
        Me.Controls.Add(Me.LabelRegistroCubetas)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Id_regCubetaLabel)
        Me.Controls.Add(Me.Id_regCubetaTextBox)
        Me.Controls.Add(Id_PersonalLabel)
        Me.Controls.Add(Me.Id_PersonalTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CubetaLabel)
        Me.Controls.Add(Me.CubetaTextBox)
        Me.Controls.Add(Me.CubetasDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCubetas"
        Me.Text = "Registro de Cubetas por Personal"
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CubetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CubetasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents CubetasBindingSource As BindingSource
    Friend WithEvents CubetasTableAdapter As arandanosDataSetTableAdapters.CubetasTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CubetasDataGridView As DataGridView
    Friend WithEvents Id_regCubetaTextBox As TextBox
    Friend WithEvents Id_PersonalTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CubetaTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents LabelRegistroCubetas As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FProductor
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
        Dim Id_ProductorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FProductor))
        Me.Id_ProductorTextBox = New System.Windows.Forms.TextBox()
        Me.ProductorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ProductorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductorTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.ProductorTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Id_ProductorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.ProductorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ProductorLabel
        '
        Id_ProductorLabel.AutoSize = True
        Id_ProductorLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_ProductorLabel.Location = New System.Drawing.Point(61, 265)
        Id_ProductorLabel.Name = "Id_ProductorLabel"
        Id_ProductorLabel.Size = New System.Drawing.Size(174, 35)
        Id_ProductorLabel.TabIndex = 1
        Id_ProductorLabel.Text = "Id Productor:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(119, 321)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(116, 35)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'Id_ProductorTextBox
        '
        Me.Id_ProductorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_ProductorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductorBindingSource, "Id_Productor", True))
        Me.Id_ProductorTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Id_ProductorTextBox.Location = New System.Drawing.Point(241, 262)
        Me.Id_ProductorTextBox.Name = "Id_ProductorTextBox"
        Me.Id_ProductorTextBox.Size = New System.Drawing.Size(116, 40)
        Me.Id_ProductorTextBox.TabIndex = 2
        '
        'ProductorBindingSource
        '
        Me.ProductorBindingSource.DataMember = "Productor"
        Me.ProductorBindingSource.DataSource = Me.ArandanosDataSet
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductorBindingSource, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.NombreTextBox.Location = New System.Drawing.Point(241, 318)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(141, 40)
        Me.NombreTextBox.TabIndex = 4
        '
        'ProductorDataGridView
        '
        Me.ProductorDataGridView.AllowUserToAddRows = False
        Me.ProductorDataGridView.AllowUserToDeleteRows = False
        Me.ProductorDataGridView.AutoGenerateColumns = False
        Me.ProductorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductorDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.ProductorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ProductorDataGridView.DataSource = Me.ProductorBindingSource
        Me.ProductorDataGridView.Location = New System.Drawing.Point(469, 174)
        Me.ProductorDataGridView.Name = "ProductorDataGridView"
        Me.ProductorDataGridView.ReadOnly = True
        Me.ProductorDataGridView.RowHeadersVisible = False
        Me.ProductorDataGridView.RowTemplate.Height = 24
        Me.ProductorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductorDataGridView.Size = New System.Drawing.Size(500, 360)
        Me.ProductorDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Productor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Productor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre de Productor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ProductorTableAdapter
        '
        Me.ProductorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CosechaTableAdapter = Nothing
        Me.TableAdapterManager.CubetasTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductorTableAdapter = Me.ProductorTableAdapter
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(350, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Administrar productores"
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(241, 431)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 19
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(132, 431)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 18
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(358, 431)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 17
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(15, 431)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 16
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 173)
        Me.Panel1.TabIndex = 22
        '
        'FProductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 543)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductorDataGridView)
        Me.Controls.Add(Id_ProductorLabel)
        Me.Controls.Add(Me.Id_ProductorTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FProductor"
        Me.Text = "Productores"
        CType(Me.ProductorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents ProductorBindingSource As BindingSource
    Friend WithEvents ProductorTableAdapter As arandanosDataSetTableAdapters.ProductorTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_ProductorTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ProductorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class

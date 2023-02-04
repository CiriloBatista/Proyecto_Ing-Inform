<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCosecha
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
        Dim Id_PersonalLabel As System.Windows.Forms.Label
        Dim Total_cubetasLabel As System.Windows.Forms.Label
        Dim Total_kilosLabel As System.Windows.Forms.Label
        Dim Id_cosechaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCosecha))
        Me.CosechaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.Id_PersonalTextBox = New System.Windows.Forms.TextBox()
        Me.Total_cubetasTextBox = New System.Windows.Forms.TextBox()
        Me.Total_kilosTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id_cosechaTextBox = New System.Windows.Forms.TextBox()
        Me.CosechaTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.CosechaTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Id_PersonalLabel = New System.Windows.Forms.Label()
        Total_cubetasLabel = New System.Windows.Forms.Label()
        Total_kilosLabel = New System.Windows.Forms.Label()
        Id_cosechaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.CosechaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CosechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_PersonalLabel
        '
        Id_PersonalLabel.AutoSize = True
        Id_PersonalLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_PersonalLabel.Location = New System.Drawing.Point(88, 379)
        Id_PersonalLabel.Name = "Id_PersonalLabel"
        Id_PersonalLabel.Size = New System.Drawing.Size(158, 35)
        Id_PersonalLabel.TabIndex = 23
        Id_PersonalLabel.Text = "Id Personal:"
        '
        'Total_cubetasLabel
        '
        Total_cubetasLabel.AutoSize = True
        Total_cubetasLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Total_cubetasLabel.Location = New System.Drawing.Point(28, 433)
        Total_cubetasLabel.Name = "Total_cubetasLabel"
        Total_cubetasLabel.Size = New System.Drawing.Size(223, 35)
        Total_cubetasLabel.TabIndex = 25
        Total_cubetasLabel.Text = "Total de Cubetas:"
        '
        'Total_kilosLabel
        '
        Total_kilosLabel.AutoSize = True
        Total_kilosLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Total_kilosLabel.Location = New System.Drawing.Point(62, 489)
        Total_kilosLabel.Name = "Total_kilosLabel"
        Total_kilosLabel.Size = New System.Drawing.Size(186, 35)
        Total_kilosLabel.TabIndex = 27
        Total_kilosLabel.Text = "Total en Kilos:"
        '
        'Id_cosechaLabel
        '
        Id_cosechaLabel.AutoSize = True
        Id_cosechaLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_cosechaLabel.Location = New System.Drawing.Point(95, 256)
        Id_cosechaLabel.Name = "Id_cosechaLabel"
        Id_cosechaLabel.Size = New System.Drawing.Size(151, 35)
        Id_cosechaLabel.TabIndex = 30
        Id_cosechaLabel.Text = "Id cosecha:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        FechaLabel.Location = New System.Drawing.Point(157, 318)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(92, 35)
        FechaLabel.TabIndex = 31
        FechaLabel.Text = "Fecha:"
        '
        'CosechaDataGridView
        '
        Me.CosechaDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
        Me.CosechaDataGridView.AllowUserToAddRows = False
        Me.CosechaDataGridView.AllowUserToDeleteRows = False
        Me.CosechaDataGridView.AutoGenerateColumns = False
        Me.CosechaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CosechaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CosechaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CosechaDataGridView.DataSource = Me.CosechaBindingSource
        Me.CosechaDataGridView.Location = New System.Drawing.Point(492, 114)
        Me.CosechaDataGridView.Name = "CosechaDataGridView"
        Me.CosechaDataGridView.ReadOnly = True
        Me.CosechaDataGridView.RowHeadersVisible = False
        Me.CosechaDataGridView.RowTemplate.Height = 24
        Me.CosechaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CosechaDataGridView.Size = New System.Drawing.Size(335, 288)
        Me.CosechaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_Personal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_Personal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "total_cubetas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "total_cubetas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "total_kilos"
        Me.DataGridViewTextBoxColumn5.HeaderText = "total_kilos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'CosechaBindingSource
        '
        Me.CosechaBindingSource.DataMember = "Cosecha"
        Me.CosechaBindingSource.DataSource = Me.ArandanosDataSet
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(615, 430)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 19
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(499, 484)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 18
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(615, 484)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 17
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(499, 430)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 16
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = True
        '
        'Id_PersonalTextBox
        '
        Me.Id_PersonalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_PersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosechaBindingSource, "id_Personal", True))
        Me.Id_PersonalTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Id_PersonalTextBox.Location = New System.Drawing.Point(268, 374)
        Me.Id_PersonalTextBox.Name = "Id_PersonalTextBox"
        Me.Id_PersonalTextBox.Size = New System.Drawing.Size(139, 40)
        Me.Id_PersonalTextBox.TabIndex = 24
        '
        'Total_cubetasTextBox
        '
        Me.Total_cubetasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total_cubetasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosechaBindingSource, "total_cubetas", True))
        Me.Total_cubetasTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Total_cubetasTextBox.Location = New System.Drawing.Point(268, 430)
        Me.Total_cubetasTextBox.Name = "Total_cubetasTextBox"
        Me.Total_cubetasTextBox.Size = New System.Drawing.Size(139, 40)
        Me.Total_cubetasTextBox.TabIndex = 26
        '
        'Total_kilosTextBox
        '
        Me.Total_kilosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total_kilosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosechaBindingSource, "total_kilos", True))
        Me.Total_kilosTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Total_kilosTextBox.Location = New System.Drawing.Point(268, 487)
        Me.Total_kilosTextBox.Name = "Total_kilosTextBox"
        Me.Total_kilosTextBox.Size = New System.Drawing.Size(139, 40)
        Me.Total_kilosTextBox.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(77, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 35)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Registro de Cosecha"
        '
        'Id_cosechaTextBox
        '
        Me.Id_cosechaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_cosechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CosechaBindingSource, "Id_cosecha", True))
        Me.Id_cosechaTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Id_cosechaTextBox.Location = New System.Drawing.Point(268, 254)
        Me.Id_cosechaTextBox.Name = "Id_cosechaTextBox"
        Me.Id_cosechaTextBox.ReadOnly = True
        Me.Id_cosechaTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_cosechaTextBox.TabIndex = 31
        '
        'CosechaTableAdapter
        '
        Me.CosechaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CosechaTableAdapter = Me.CosechaTableAdapter
        Me.TableAdapterManager.CubetasTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
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
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CosechaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(268, 313)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 40)
        Me.FechaDateTimePicker.TabIndex = 32
        '
        'FCosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 607)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Id_cosechaLabel)
        Me.Controls.Add(Me.Id_cosechaTextBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Id_PersonalLabel)
        Me.Controls.Add(Me.Id_PersonalTextBox)
        Me.Controls.Add(Total_cubetasLabel)
        Me.Controls.Add(Me.Total_cubetasTextBox)
        Me.Controls.Add(Total_kilosLabel)
        Me.Controls.Add(Me.Total_kilosTextBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(Me.CosechaDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCosecha"
        Me.Text = "Registro de Cosecha"
        CType(Me.CosechaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CosechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents CosechaBindingSource As BindingSource
    Friend WithEvents CosechaTableAdapter As arandanosDataSetTableAdapters.CosechaTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CosechaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BNuevo As Button
    Friend WithEvents Id_PersonalTextBox As TextBox
    Friend WithEvents Total_cubetasTextBox As TextBox
    Friend WithEvents Total_kilosTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Id_cosechaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
End Class

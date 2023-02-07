<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUser
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
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim Id_UsuariosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FUser))
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.NivelComboBox = New System.Windows.Forms.ComboBox()
        Me.UsuariosTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BNuevo = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Id_UsuariosTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        UsuarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        Id_UsuariosLabel = New System.Windows.Forms.Label()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        UsuarioLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        UsuarioLabel.Location = New System.Drawing.Point(103, 257)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(112, 35)
        UsuarioLabel.TabIndex = 3
        UsuarioLabel.Text = "Usuario:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.Transparent
        NombreLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        NombreLabel.Location = New System.Drawing.Point(97, 301)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(116, 35)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.BackColor = System.Drawing.Color.Transparent
        ContraseñaLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        ContraseñaLabel.Location = New System.Drawing.Point(56, 345)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(153, 35)
        ContraseñaLabel.TabIndex = 7
        ContraseñaLabel.Text = "Contraseña:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.BackColor = System.Drawing.Color.Transparent
        NivelLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        NivelLabel.Location = New System.Drawing.Point(83, 391)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(126, 35)
        NivelLabel.TabIndex = 9
        NivelLabel.Text = "Permisos:"
        '
        'Id_UsuariosLabel
        '
        Id_UsuariosLabel.AutoSize = True
        Id_UsuariosLabel.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Id_UsuariosLabel.Location = New System.Drawing.Point(60, 213)
        Id_UsuariosLabel.Name = "Id_UsuariosLabel"
        Id_UsuariosLabel.Size = New System.Drawing.Size(149, 35)
        Id_UsuariosLabel.TabIndex = 16
        Id_UsuariosLabel.Text = "Id Usuario:"
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ArandanosDataSet
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "usuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.UsuarioTextBox.Location = New System.Drawing.Point(221, 254)
        Me.UsuarioTextBox.MaxLength = 20
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(120, 38)
        Me.UsuarioTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.NombreTextBox.Location = New System.Drawing.Point(221, 301)
        Me.NombreTextBox.MaxLength = 255
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 38)
        Me.NombreTextBox.TabIndex = 6
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContraseñaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "contraseña", True))
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(221, 345)
        Me.ContraseñaTextBox.MaxLength = 255
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(160, 38)
        Me.ContraseñaTextBox.TabIndex = 8
        '
        'NivelComboBox
        '
        Me.NivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "nivel", True))
        Me.NivelComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.NivelComboBox.FormattingEnabled = True
        Me.NivelComboBox.Items.AddRange(New Object() {"01", "02", "03", "04"})
        Me.NivelComboBox.Location = New System.Drawing.Point(221, 391)
        Me.NivelComboBox.Name = "NivelComboBox"
        Me.NivelComboBox.Size = New System.Drawing.Size(70, 39)
        Me.NivelComboBox.TabIndex = 10
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CosechaTableAdapter = Nothing
        Me.TableAdapterManager.CubetasTableAdapter = Nothing
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.ProduccionTableAdapter = Nothing
        Me.TableAdapterManager.ProductorTableAdapter = Nothing
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(350, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 48)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Administrar usuarios"
        '
        'BNuevo
        '
        Me.BNuevo.BackColor = System.Drawing.Color.White
        Me.BNuevo.Location = New System.Drawing.Point(12, 472)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(99, 40)
        Me.BNuevo.TabIndex = 13
        Me.BNuevo.Text = "Nuevo"
        Me.BNuevo.UseVisualStyleBackColor = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(241, 472)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(99, 40)
        Me.BGuardar.TabIndex = 15
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.White
        Me.BEliminar.Location = New System.Drawing.Point(127, 472)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(99, 40)
        Me.BEliminar.TabIndex = 16
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'Id_UsuariosTextBox
        '
        Me.Id_UsuariosTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Id_UsuariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "id_Usuarios", True))
        Me.Id_UsuariosTextBox.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Id_UsuariosTextBox.Location = New System.Drawing.Point(221, 208)
        Me.Id_UsuariosTextBox.Name = "Id_UsuariosTextBox"
        Me.Id_UsuariosTextBox.ReadOnly = True
        Me.Id_UsuariosTextBox.Size = New System.Drawing.Size(100, 40)
        Me.Id_UsuariosTextBox.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(29, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsuariosDataGridView.BackgroundColor = System.Drawing.Color.LightGreen
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.nivel})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(475, 176)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.UsuariosDataGridView.RowHeadersVisible = False
        Me.UsuariosDataGridView.RowTemplate.Height = 24
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(500, 360)
        Me.UsuariosDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "usuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'nivel
        '
        Me.nivel.DataPropertyName = "nivel"
        Me.nivel.HeaderText = "Nivel"
        Me.nivel.Name = "nivel"
        Me.nivel.ReadOnly = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(350, 472)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 40)
        Me.BCancelar.TabIndex = 29
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 173)
        Me.Panel1.TabIndex = 30
        '
        'FUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(982, 543)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Id_UsuariosLabel)
        Me.Controls.Add(Me.Id_UsuariosTextBox)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BNuevo)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.NivelComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FUser"
        Me.Text = "Catalogo de Usuarios"
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As arandanosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents NivelComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BNuevo As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents Id_UsuariosTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UsuariosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents nivel As DataGridViewTextBoxColumn
    Friend WithEvents BCancelar As Button
    Friend WithEvents Panel1 As Panel
End Class

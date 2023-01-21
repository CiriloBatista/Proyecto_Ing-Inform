<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FLogin))
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.usuario_textBox = New System.Windows.Forms.TextBox()
        Me.Btn_Ingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginUsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.password = New System.Windows.Forms.Label()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.ArandanosDataSet = New SisProduccion.arandanosDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New SisProduccion.arandanosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginUsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.Location = New System.Drawing.Point(648, 11)
        Me.Btn_Cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(81, 42)
        Me.Btn_Cancelar.TabIndex = 13
        Me.Btn_Cancelar.Text = "Salir"
        Me.Btn_Cancelar.UseVisualStyleBackColor = True
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LUsuario.Location = New System.Drawing.Point(171, 221)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(85, 25)
        Me.LUsuario.TabIndex = 10
        Me.LUsuario.Text = "Usuario:"
        '
        'usuario_textBox
        '
        Me.usuario_textBox.BackColor = System.Drawing.Color.White
        Me.usuario_textBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.usuario_textBox.Location = New System.Drawing.Point(285, 216)
        Me.usuario_textBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usuario_textBox.MaximumSize = New System.Drawing.Size(130, 50)
        Me.usuario_textBox.MaxLength = 3
        Me.usuario_textBox.MinimumSize = New System.Drawing.Size(100, 30)
        Me.usuario_textBox.Name = "usuario_textBox"
        Me.usuario_textBox.Size = New System.Drawing.Size(130, 30)
        Me.usuario_textBox.TabIndex = 8
        '
        'Btn_Ingresar
        '
        Me.Btn_Ingresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Btn_Ingresar.Image = CType(resources.GetObject("Btn_Ingresar.Image"), System.Drawing.Image)
        Me.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ingresar.Location = New System.Drawing.Point(97, 328)
        Me.Btn_Ingresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Ingresar.Name = "Btn_Ingresar"
        Me.Btn_Ingresar.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Btn_Ingresar.Size = New System.Drawing.Size(204, 76)
        Me.Btn_Ingresar.TabIndex = 12
        Me.Btn_Ingresar.Text = "Ingresar"
        Me.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Ingresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(146, 36)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LoginUsBindingSource
        '
        Me.LoginUsBindingSource.DataMember = "LoginUs"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.password.Location = New System.Drawing.Point(136, 265)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(120, 25)
        Me.password.TabIndex = 14
        Me.password.Text = "Contraseña:"
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passwordTextBox.Location = New System.Drawing.Point(285, 262)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordTextBox.MaximumSize = New System.Drawing.Size(130, 50)
        Me.passwordTextBox.MaxLength = 8
        Me.passwordTextBox.MinimumSize = New System.Drawing.Size(100, 30)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(130, 30)
        Me.passwordTextBox.TabIndex = 13
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(321, 328)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BSalir.Size = New System.Drawing.Size(151, 76)
        Me.BSalir.TabIndex = 15
        Me.BSalir.Text = "Salir"
        Me.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'ArandanosDataSet
        '
        Me.ArandanosDataSet.DataSetName = "arandanosDataSet"
        Me.ArandanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ArandanosDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PersonalTableAdapter = Nothing
        Me.TableAdapterManager.PuestoTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SisProduccion.arandanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        '
        'FLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 450)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.Btn_Ingresar)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.usuario_textBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FLogin"
        Me.Text = "Iniciar Sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginUsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArandanosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Ingresar As Button
    Friend WithEvents LUsuario As Label
    Friend WithEvents usuario_textBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginUsBindingSource As BindingSource
    Friend WithEvents password As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents BSalir As Button
    Friend WithEvents ArandanosDataSet As arandanosDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As arandanosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As arandanosDataSetTableAdapters.TableAdapterManager
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenuP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMenuP))
        Me.ButtonConsult = New System.Windows.Forms.Button()
        Me.BAsignDer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BAdmin_Puesto = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConsult
        '
        Me.ButtonConsult.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonConsult.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConsult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonConsult.Location = New System.Drawing.Point(302, 298)
        Me.ButtonConsult.Name = "ButtonConsult"
        Me.ButtonConsult.Size = New System.Drawing.Size(133, 62)
        Me.ButtonConsult.TabIndex = 3
        Me.ButtonConsult.Text = "Administrar Personal"
        Me.ButtonConsult.UseVisualStyleBackColor = False
        '
        'BAsignDer
        '
        Me.BAsignDer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BAsignDer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAsignDer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BAsignDer.Location = New System.Drawing.Point(133, 298)
        Me.BAsignDer.Name = "BAsignDer"
        Me.BAsignDer.Size = New System.Drawing.Size(133, 62)
        Me.BAsignDer.TabIndex = 4
        Me.BAsignDer.Text = "Asignar Derechos"
        Me.BAsignDer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(85, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(587, 372)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(228, 108)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(274, 148)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BSalir.Image = CType(resources.GetObject("BSalir.Image"), System.Drawing.Image)
        Me.BSalir.Location = New System.Drawing.Point(574, 71)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.BSalir.Size = New System.Drawing.Size(72, 76)
        Me.BSalir.TabIndex = 16
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BAdmin_Puesto
        '
        Me.BAdmin_Puesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BAdmin_Puesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAdmin_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BAdmin_Puesto.Location = New System.Drawing.Point(467, 298)
        Me.BAdmin_Puesto.Name = "BAdmin_Puesto"
        Me.BAdmin_Puesto.Size = New System.Drawing.Size(133, 62)
        Me.BAdmin_Puesto.TabIndex = 17
        Me.BAdmin_Puesto.Text = "Puestos"
        Me.BAdmin_Puesto.UseVisualStyleBackColor = False
        '
        'FMenuP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BAdmin_Puesto)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BAsignDer)
        Me.Controls.Add(Me.ButtonConsult)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMenuP"
        Me.Text = "Menú Principal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonConsult As Button
    Friend WithEvents BAsignDer As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BSalir As Button
    Friend WithEvents BAdmin_Puesto As Button
End Class

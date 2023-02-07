Public Class FUser
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.User' Puede moverla o quitarla según sea necesario.
        Actualiza()
    End Sub

    Private Sub Block()
        UsuariosDataGridView.Enabled = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        Id_UsuariosTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        UsuariosDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        Id_UsuariosTextBox.Enabled = False
    End Sub

    Private Sub FButtonGuardar_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)
    End Sub
    Private Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.UsuariosTableAdapter.Fill(Me.ArandanosDataSet.Usuarios) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            MsgBox("Fallo la conexion", vbCritical)
        End Try
    End Sub

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        UsuariosBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        UsuarioTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                UsuariosBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
                TableAdapterManager.UpdateAll(Me.ArandanosDataSet) 'Actualiza los datos ingresados'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Guardar", vbCritical)
            End Try
        Else
            MsgBox("Aún hay campos vacíos!", vbCritical)
        End If
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If UsuarioTextBox.Text = Nothing Then

            Return False
        End If
        Return True
    End Function

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim OpBorra
        OpBorra = MsgBox("¿Borrar el registro?", vbCritical + vbYesNo, "A T E N C I O N") 'Cuadro de texto de pregunta a usuario '
        If OpBorra = vbYes Then
            Try
                UsuariosBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                UsuariosTableAdapter.Update(ArandanosDataSet.Usuarios) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Eliminar", vbCritical)
            End Try
        End If
    End Sub
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        UsuariosBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
    End Sub

End Class

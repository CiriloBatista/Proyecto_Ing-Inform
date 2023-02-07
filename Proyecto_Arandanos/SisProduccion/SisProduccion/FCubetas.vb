Public Class FCubetas
    Private Sub CubetasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CubetasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FCubetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Personal' Puede moverla o quitarla según sea necesario.
        Actualiza()
    End Sub

    Private Sub Block()
        CubetasDataGridView.Enabled = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        Id_PersonalTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        CubetasDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        Id_PersonalTextBox.Enabled = False
    End Sub

    Private Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.CubetasTableAdapter.Fill(Me.ArandanosDataSet.Cubetas) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            MsgBox("Fallo la conexion", vbCritical)
        End Try
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If Id_PersonalTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        CubetasBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Id_PersonalTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        CubetasBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                CubetasBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
                TableAdapterManager.UpdateAll(Me.ArandanosDataSet) 'Actualiza los datos ingresados'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Guardar", vbCritical)
            End Try
        Else
            MsgBox("Aún hay campos vacíos!", vbCritical)
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim OpBorra
        OpBorra = MsgBox("¿Borrar el registro?", vbCritical + vbYesNo, "A T E N C I O N") 'Cuadro de texto de pregunta a usuario '
        If OpBorra = vbYes Then
            Try
                CubetasBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                CubetasTableAdapter.Update(ArandanosDataSet.Cubetas) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Eliminar", vbCritical)
            End Try
        End If
    End Sub

    Private Sub Id_PersonalTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Id_PersonalTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub CubetaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NombreTextBox.KeyPress 'Evento KeyPress revisa letra por letra'
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

End Class
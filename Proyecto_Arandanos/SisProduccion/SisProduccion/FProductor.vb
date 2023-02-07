Public Class FProductor
    Private Sub ProductorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Productor' Puede moverla o quitarla según sea necesario.
        Me.ProductorTableAdapter.Fill(Me.ArandanosDataSet.Productor)
        Actualiza()
    End Sub

    Private Sub Block()
        ProductorDataGridView.Enabled = False
        BNuevo.Visible = False
        BEliminar.Visible = False
        Id_ProductorTextBox.Enabled = True
    End Sub
    Private Sub DesBlock()
        ProductorDataGridView.Enabled = True
        BNuevo.Visible = True
        BEliminar.Visible = True
        Id_ProductorTextBox.Enabled = False
    End Sub

    Private Sub Actualiza()
        Try 'Es una funcion que nos ayuda a controlar que no caiga el sistema'
            Me.ProductorTableAdapter.Fill(Me.ArandanosDataSet.Productor) 'Actualiza el los datos de la tabla'
        Catch ex As Exception
            MsgBox("Fallo la conexion", vbCritical)
        End Try
    End Sub
    Private Sub BNuevo_Click(sender As Object, e As EventArgs) Handles BNuevo.Click
        ProductorBindingSource.AddNew() 'Se selecciona la tabla a la que haremos referencia y añadimos una nueva fila'
        Id_ProductorTextBox.Focus()     'Apuntaremos a la caja de texto de ID_Personal'
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        ProductorBindingSource.CancelEdit() 'Se selecciona la tabla a la que haremos referencia y ponemos para cancelar'
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If Completo() Then
            Try
                ProductorBindingSource.EndEdit()  'Termina de guardar los datos que se ingresaron en la tabla'
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
                ProductorBindingSource.RemoveCurrent()  'Elimina los datos de la tabla de personal'
                ProductorTableAdapter.Update(ArandanosDataSet.Productor) 'Actualiza los datos que se ingresaron en este caso se elimina'
                Actualiza()
            Catch ex As Exception
                MsgBox("Fallo al tratar de Eliminar", vbCritical)
            End Try
        End If
    End Sub

    Function Completo() As Boolean 'Valida que no esté vacío'
        If Id_ProductorTextBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

End Class
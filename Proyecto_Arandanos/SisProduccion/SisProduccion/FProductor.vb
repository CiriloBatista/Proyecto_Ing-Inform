Public Class FProductor
    Private Sub ProductorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FProductor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Productor' Puede moverla o quitarla según sea necesario.
        Me.ProductorTableAdapter.Fill(Me.ArandanosDataSet.Productor)

    End Sub
End Class
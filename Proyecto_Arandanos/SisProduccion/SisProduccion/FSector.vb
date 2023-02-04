Public Class FSector
    Private Sub SectorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SectorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FSector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Sector' Puede moverla o quitarla según sea necesario.
        Me.SectorTableAdapter.Fill(Me.ArandanosDataSet.Sector)

    End Sub
End Class
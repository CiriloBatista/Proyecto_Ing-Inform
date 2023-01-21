Public Class FMenuP
    Private Sub ButtonConsult_Click(sender As Object, e As EventArgs) Handles ButtonConsult.Click
        Me.Close()
        FPersonal.Show()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
        FLogin.Show()
    End Sub

    Private Sub BAsignDer_Click(sender As Object, e As EventArgs) Handles BAsignDer.Click
        Me.Close()
        FUser.Show()
    End Sub

    Private Sub BAdmin_Puesto_Click(sender As Object, e As EventArgs) Handles BAdmin_Puesto.Click
        FPuesto.Show()
        Me.Close()
    End Sub
End Class
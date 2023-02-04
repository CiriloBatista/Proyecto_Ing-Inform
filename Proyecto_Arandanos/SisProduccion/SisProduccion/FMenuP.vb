Public Class FMenuP
    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        Dim NewMdiChild As New FPersonal 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim OpSalir
        OpSalir = MsgBox("¿Desea salir del menu?", vbQuestion + vbYesNo + vbDefaultButton2, "A T E N C I Ó N !")
        If OpSalir = vbYes Then
            FLogin.Visible = True  ' Abrirá el formulario de login mientras se cierra el menu '
            Me.Close()
        End If
    End Sub

    Private Sub FMenuP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FLogin.Visible = False  ' Ocultará el formulario de login mientras está abierto el menu '
    End Sub
    Private Sub FMenuP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FLogin.Visible = True   ' Abrirá el formulario de login mientras se cierra el menu '
    End Sub

    Private Sub PuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestoToolStripMenuItem.Click
        Dim NewMdiChild As New FPuesto 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub CubetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CubetasToolStripMenuItem.Click
        Dim NewMdiChild As New FCubetas 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub CosechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosechaToolStripMenuItem.Click
        Dim NewMdiChild As New FCosecha 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub

    Private Sub SectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectorToolStripMenuItem.Click
        Dim NewMdiChild As New FSector 'Se crea una instancia en donde se abrira el form dentro de la ventana del menu'
        NewMdiChild.MdiParent = Me       '
        NewMdiChild.Show()
    End Sub
End Class
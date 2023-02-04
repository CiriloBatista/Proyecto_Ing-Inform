Public Class FormLoginPractica
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArandanosDataSet)

    End Sub

    Private Sub FormLoginPractica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ArandanosDataSet.Usuarios)

    End Sub

    Private Sub Btn_Aceptar_Click(sender As Object, e As EventArgs) Handles Btn_Aceptar.Click
        If TxtUsuario.Text <> "" And TxtPass.Text <> "" Then
            Me.UsuariosTableAdapter.FillByUsuario(Me.ArandanosDataSet.Usuarios, TxtUsuario.Text)
            Compara()
        Else
            MsgBox("Faltan datos por ingresar")
        End If
    End Sub

    Private Sub Compara()
        If TxtPass.Text = "" Then
            MsgBox("No existe el usuario")
        Else
            If TxtPass.Text = ContrasenaTextBox.Text Then
                MsgBox("Bienvenido " & UsuarioTextBox.Text) 'El simbolo "&" concatena texto con funciones'
                IdUsr = Id_UsuariosTextBox.Text
                User = UsuarioTextBox.Text
            Else
                MsgBox("Usuario o Contraseña no validos") 'Podemos ver el video 8 de la sesion extra!'
            End If
        End If
    End Sub

End Class
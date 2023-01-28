Public Class FLogin

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArandanosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ArandanosDataSet.Usuarios)
    End Sub
    Function Completo() As Boolean 'Valida que no esté vacío'
        If usuario_textBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        If usuario_textBox.Text <> "" And passwordTextBox.Text <> "" Then
            Me.UsuariosTableAdapter.FillByUsuario(Me.ArandanosDataSet.Usuarios, usuario_textBox.Text)
            Compara()
        Else
            MsgBox("Faltan datos por ingresar")
        End If
    End Sub

    Private Sub Compara()
        If passwordTextBox.Text = "" Then
            MsgBox("No existe el usuario")
        Else
            If passwordTextBox.Text = ContrasenaTextBox.Text Then
                MsgBox("Bienvenido " & UsuarioTextBox.Text) 'El simbolo "&" concatena texto con funciones'
            Else
                MsgBox("Usuario o Contraseña no validos") 'Podemos ver el video 8 de la sesion extra!'
            End If
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub usuario_textBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usuario_textBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub passwordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passwordTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub
End Class
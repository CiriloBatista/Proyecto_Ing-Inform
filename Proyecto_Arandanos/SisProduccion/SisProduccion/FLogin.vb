Public Class FLogin

    Function Completo() As Boolean 'Valida que no esté vacío'
        If usuario_textBox.Text = Nothing Then
            Return False
        End If
        Return True
    End Function
    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        FMenuP.Show()
        Me.Hide()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub usuario_textBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usuario_textBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

    Private Sub passwordTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passwordTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) 'e.Handled solo se puede usar en KeyPress'
    End Sub

End Class
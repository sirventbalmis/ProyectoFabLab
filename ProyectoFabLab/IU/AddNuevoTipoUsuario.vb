Public Class AddNuevoTipoUsuario
    Private Sub AddTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddTipoMaquinaButton.Click
        If NegocioTiposUsuarios.InsertarTipoUsuario(NuevoTipoMaquinaTextBox.Text) Then
            MessageBox.Show("Tipo de Usuario Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
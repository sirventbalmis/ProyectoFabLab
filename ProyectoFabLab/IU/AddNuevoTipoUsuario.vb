Public Class AddNuevoTipoUsuario


    Private Sub AddTipoUsuarioBTN_Click(sender As Object, e As EventArgs) Handles AddTipoUsuarioBTN.Click
        If NegocioTiposUsuarios.InsertarTipoUsuario(NuevoTipoUsuarioTXT.Text) Then
            MessageBox.Show("Tipo de Usuario Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
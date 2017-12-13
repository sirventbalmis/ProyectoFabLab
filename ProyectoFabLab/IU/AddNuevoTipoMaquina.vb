Public Class AddNuevoTipoMaquina
    Private Sub AddTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddTipoMaquinaButton.Click

        If NegocioTiposMaquinas.InsertarTipoMaquina(NuevoTipoMaquinaTextBox.Text) Then

            MessageBox.Show("Tipo de Máquina Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class
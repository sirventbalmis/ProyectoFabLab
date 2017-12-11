Public Class AddNuevoTipoMaquina
    Private Sub AddTipoMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddTipoMaquinaButton.Click

        NegocioTiposMaquinas.InsertarTipoMaquina(NuevoTipoMaquinaTextBox.Text)

    End Sub
End Class
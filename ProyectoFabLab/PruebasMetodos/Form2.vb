Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NegocioUsuarios.ModificarDatosUsuarioPorId(5, "Pepito", "Grillo", "111111111", "ki@ju.com", "C\ Los Tuertos", "", "Estudiante", "")

    End Sub
End Class
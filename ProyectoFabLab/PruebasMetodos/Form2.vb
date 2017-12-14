Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NegocioUsuarios.InsertarUsuario("Pepito", "Grillo", "111111111", "ki@ju.com", "C\ Los Tuertos", "", "Estudiante", "2", "")

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class GestionUsuarios
    Private FormPrincipal As Form1

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(ByRef formPrincipal As Form1)

        InitializeComponent()
        Me.FormPrincipal = formPrincipal

    End Sub
End Class
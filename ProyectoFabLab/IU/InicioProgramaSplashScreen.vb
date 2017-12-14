Public NotInheritable Class InicioProgramaSplashScreen

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Private Sub InicioProgramaSplashScreen_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()

    End Sub
End Class

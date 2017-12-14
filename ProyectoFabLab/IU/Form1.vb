Imports System.Threading

Public Class Form1

    Private Sub AddUsuario_Click(sender As Object, e As EventArgs) Handles AddUsuarioToolStripMenuItem.Click
        Dim formNuevoUsuario As New NuevoUsuario(Foo.TipoAccion.Insertar.ToString(), Me)
        formNuevoUsuario.MdiParent = Me
        formNuevoUsuario.Show()

    End Sub

    Private Sub AddUsuarioToolStripButton_Click(sender As Object, e As EventArgs) Handles AddUsuarioToolStripButton.Click
        AddUsuarioToolStripMenuItem.PerformClick()

    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click

        For Each ventana In Me.MdiChildren

            ventana.WindowState = FormWindowState.Minimized

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BarraProgresoAPI.Visible = False
        BarraProgresoAPI.Style = ProgressBarStyle.Marquee
        BarraProgresoAPI.MarqueeAnimationSpeed = 120

        Dim numUsuarios As Integer = NegocioUsuarios.ObtenerNumUsuarios()
        NumUsuariosToolStripLabel.Text = "Usuarios: " & numUsuarios

        Dim numMaquinas As Integer = NegocioMaquinas.ObtenerNumeroMaquinas()
        MaquinasEtiqueta.Text = "Maquinas: " & numMaquinas

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim formGestionMaq As New GestionMaquinas(Me)
        formGestionMaq.MdiParent = Me
        formGestionMaq.Show()

    End Sub

    Private Sub NuevaMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem.Click

        Dim formNuevaMaquina As New NuevaMaquina(Foo.TipoAccion.Insertar.ToString(), Me)
        formNuevaMaquina.MdiParent = Me
        formNuevaMaquina.Show()

    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim formNuevaMaquina = New InicioProgramaSplashScreen()
        ' formNuevaMaquina.MdiParent = Me
        formNuevaMaquina.Show()
    End Sub

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        Dim formGestionMaq As New GestionUsuarios(Me)
        formGestionMaq.MdiParent = Me
        formGestionMaq.Show()
    End Sub

    Private Sub NuevaMaquinaToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripButton.Click

        NuevaMaquinaToolStripMenuItem.PerformClick()

    End Sub
End Class

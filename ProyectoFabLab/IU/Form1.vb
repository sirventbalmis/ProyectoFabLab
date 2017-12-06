Imports System.Threading

Public Class Form1
    Private Sub AddUsuario_Click(sender As Object, e As EventArgs) Handles AddUsuarioToolStripMenuItem.Click

        Dim documento As New GestionUsuarios
        documento.MdiParent = Me
        documento.Text = "Gestión de usuarios"
        documento.Show()

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

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

        Dim formNuevaMaquina As New NuevaMaquina
        formNuevaMaquina.MdiParent = Me
        formNuevaMaquina.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim numUsuarios As Integer = NegocioUsuarios.ObtenerNumUsuarios()
        NumUsuariosToolStripLabel.Text = "Usuarios: " & numUsuarios

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim formGestionMaq As New GestionMaquinas(Me)
        formGestionMaq.MdiParent = Me
        formGestionMaq.Show()

    End Sub
End Class

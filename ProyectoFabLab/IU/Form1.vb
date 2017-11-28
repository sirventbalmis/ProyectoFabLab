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
End Class

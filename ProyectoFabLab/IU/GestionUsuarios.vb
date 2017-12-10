Public Class GestionUsuarios
    Private FormPrincipal As Form1
    Private Enlace As BindingSource

    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataSet As DataSet = NegocioUsuarios.ObtenerDatosUsuarios
        Enlace = New BindingSource(dataSet, "Usuarios")
        UsuariosDGV.DataSource = Enlace
        SetColumnas()
    End Sub
    Private Sub SetColumnas()
        UsuariosDGV.Columns(0).Width = 200
        UsuariosDGV.Columns(1).Width = 200
        UsuariosDGV.Columns(2).Width = 200
        UsuariosDGV.Columns(3).Width = 200
    End Sub
    Public Sub New(ByRef formPrincipal As Form1)
        InitializeComponent()
        Me.FormPrincipal = formPrincipal
    End Sub

    Private Sub BuscarTxtBox_TextChanged(sender As Object, e As EventArgs) Handles BuscarTxtBox.TextChanged
        Enlace.Filter = "Nombre LIKE '" & BuscarTxtBox.Text & "%'"
    End Sub

    Private Sub NuevoUsuarioButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioButton.Click
        Dim nuevoUsuario As New NuevoUsuario(Foo.TipoAccion.Insertar.ToString())
        nuevoUsuario.MdiParent = FormPrincipal
        nuevoUsuario.Show()
    End Sub

    Private Sub ConsultaButton_Click(sender As Object, e As EventArgs) Handles ConsultaButton.Click
        Dim seleccionados As Integer = UsuariosDGV.SelectedCells.Count
        If seleccionados > 0 Then
            For Each fila As DataGridViewRow In UsuariosDGV.SelectedRows
                MsgBox(UsuariosDGV.SelectedCells(0).Value.ToString())
            Next
        Else
            MessageBox.Show("Tienes que seleccionar una entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click

    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim seleccionados As Integer = UsuariosDGV.SelectedCells.Count
        If seleccionados > 0 Then
            For Each fila As DataGridViewRow In UsuariosDGV.SelectedRows
                UsuariosDGV.Rows.Remove(fila)
            Next
        Else
            MessageBox.Show("Tienes que seleccionar una entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
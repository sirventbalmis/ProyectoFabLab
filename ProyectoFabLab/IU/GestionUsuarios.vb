Public Class GestionUsuarios
    Private FormPrincipal As Form1
    Private Enlace As BindingSource
    Private Sub GestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
    End Sub
    Public Sub Carga()
        Dim dataTable As DataTable = NegocioUsuarios.ObtenerDatosUsuarios
        Dim dataSet As New DataSet()
        dataSet.Tables.Add(dataTable)
        Enlace = New BindingSource(dataSet, "Usuarios")
        UsuariosDGV.DataSource = Enlace
        SetColumnas()
    End Sub
    Private Sub SetColumnas()
        UsuariosDGV.Columns(0).Visible = False
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
        Dim nuevoUsuario As New NuevoUsuario(Foo.TipoAccion.Insertar.ToString(), FormPrincipal)
        nuevoUsuario.MdiParent = FormPrincipal
        nuevoUsuario.Show()
    End Sub

    Private Sub ConsultaButton_Click(sender As Object, e As EventArgs) Handles ConsultaButton.Click
        Dim seleccionados As Integer = UsuariosDGV.SelectedCells.Count
        If seleccionados > 0 Then
            For Each fila As DataGridViewRow In UsuariosDGV.SelectedRows
                Dim nuevoUsuario As New NuevoUsuario(Foo.TipoAccion.Consultar.ToString(), FormPrincipal)
                nuevoUsuario.MdiParent = FormPrincipal
                nuevoUsuario.IdUsuario = Integer.Parse(UsuariosDGV.Rows(fila.Index).Cells(0).Value.ToString())
                nuevoUsuario.Show()
            Next
        Else
            MessageBox.Show("Tienes que seleccionar una entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EditarButton_Click(sender As Object, e As EventArgs) Handles EditarButton.Click
        Dim seleccionados As Integer = UsuariosDGV.SelectedCells.Count
        If seleccionados > 0 Then
            For Each fila As DataGridViewRow In UsuariosDGV.SelectedRows
                Dim nuevoUsuario As New NuevoUsuario(Foo.TipoAccion.Modificar.ToString(), FormPrincipal)
                nuevoUsuario.MdiParent = FormPrincipal
                nuevoUsuario.IdUsuario = Integer.Parse(UsuariosDGV.Rows(fila.Index).Cells(0).Value.ToString())
                nuevoUsuario.Show()
            Next
        Else
            MessageBox.Show("Tienes que seleccionar una entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EliminarButton_Click(sender As Object, e As EventArgs) Handles EliminarButton.Click
        Dim seleccionados As Integer = UsuariosDGV.SelectedCells.Count
        If seleccionados > 0 Then
            For Each fila As DataGridViewRow In UsuariosDGV.SelectedRows
                If NegocioUsuarios.EliminarUsuarioPorId(Integer.Parse(UsuariosDGV.Rows(fila.Index).Cells(0).Value.ToString)) Then
                    MessageBox.Show("Usuario Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se ha podido borrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                UsuariosDGV.Rows.Remove(fila)
            Next
        Else
            MessageBox.Show("Tienes que seleccionar una entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub VerReservasButton_Click(sender As Object, e As EventArgs) Handles VerReservasButton.Click

        Dim formReservasUsuario As New ReservasUsuario(FormPrincipal)
        formReservasUsuario.MdiParent = FormPrincipal
        Dim estaFilaSeleccionada = False

        Try
            formReservasUsuario.IdUsuario = Integer.Parse(UsuariosDGV.SelectedRows.Item(0).Cells(0).Value.ToString())
            estaFilaSeleccionada = True

        Catch ex As Exception

        End Try

        If estaFilaSeleccionada Then

            formReservasUsuario.Show()

        End If

    End Sub

    Private Sub GestionUsuarios_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Carga()
    End Sub
End Class
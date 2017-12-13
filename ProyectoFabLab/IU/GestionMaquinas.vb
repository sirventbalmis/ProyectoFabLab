Public Class GestionMaquinas

    Private Enlace As BindingSource
    Private TablaMaquinas As DataTable
    Private FormPrincipal As Form1

    Private Sub AddMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddMaquinaButton.Click

        Dim formNuevaMaq As New NuevaMaquina(Foo.TipoAccion.Insertar.ToString(), FormPrincipal)
        formNuevaMaq.MdiParent = FormPrincipal
        formNuevaMaq.Show()

    End Sub

    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataTable As DataTable = NegocioMaquinas.ObtenerTodasLasMaquinas()
        Dim dataSet As New DataSet()

        dataSet.Tables.Add(dataTable)

        Enlace = New BindingSource(dataSet, "Maquinas")
        DatosMaquinasDataGridView.DataSource = Enlace

        EstablecerColumnasDataGridView()

    End Sub

    Private Sub ConsultarMaqButton_Click(sender As Object, e As EventArgs) Handles ConsultarMaqButton.Click

        Dim formNuevaMaquina As New NuevaMaquina(Foo.TipoAccion.Consultar.ToString(), FormPrincipal)
        formNuevaMaquina.Text = "FabLab - Consultar Máquina"
        formNuevaMaquina.MdiParent = FormPrincipal

        Dim estaFilaSeleccionada = False

        ' Por si el usuario no seleccionase una fila.
        Try
            formNuevaMaquina.IdMaquina = Integer.Parse(DatosMaquinasDataGridView.SelectedRows.Item(0).Cells(0).Value.ToString())
            formNuevaMaquina.Show()

        Catch ex As Exception

            MessageBox.Show("Tienes que seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        If estaFilaSeleccionada Then

            formNuevaMaquina.Show()

        End If

    End Sub

    Private Sub EditarMaqButton_Click(sender As Object, e As EventArgs) Handles EditarMaqButton.Click

        Dim formNuevaMaquina As New NuevaMaquina(Foo.TipoAccion.Modificar.ToString(), FormPrincipal)
        formNuevaMaquina.Text = "FabLab - Modificar Máquina"
        formNuevaMaquina.MdiParent = FormPrincipal

        Dim estaFilaSeleccionada = False

        ' Por si el usuario no seleccionase una fila.
        Try
            formNuevaMaquina.IdMaquina = Integer.Parse(DatosMaquinasDataGridView.SelectedRows.Item(0).Cells(0).Value.ToString())
            estaFilaSeleccionada = True

        Catch ex As Exception

            MessageBox.Show("Tienes que seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        If estaFilaSeleccionada Then

            formNuevaMaquina.Show()

        End If

    End Sub

    Private Sub EliminarMaqButton_Click(sender As Object, e As EventArgs) Handles EliminarMaqButton.Click

        Dim idMaqSeleccionada As Integer = Integer.Parse(DatosMaquinasDataGridView.SelectedRows.Item(0).Cells(0).Value.ToString())

        If BorrarFilaDataGridView() Then

            If NegocioMaquinas.BorrarMaquina(idMaqSeleccionada) Then          ' Eliminamos la máquina de la BD.

                MessageBox.Show("Máquina Eliminada", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("No se ha podido eliminar la máquina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        End If

    End Sub


    ''' <summary>
    ''' Borra la fila seleccionada que contiene los datos de la máquina en el DataGridView.
    ''' </summary>
    Private Function BorrarFilaDataGridView() As Boolean

        If DatosMaquinasDataGridView.SelectedRows.Count = 0 Then

            MessageBox.Show("Tienes que seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False

        Else

            For Each fila As DataGridViewRow In DatosMaquinasDataGridView.SelectedRows

                DatosMaquinasDataGridView.Rows.Remove(fila)

            Next

            Return True

        End If

    End Function


    ''' <summary>
    ''' Establece el título y anchura de las columnas del DataGridView
    ''' </summary>
    Private Sub EstablecerColumnasDataGridView()

        DatosMaquinasDataGridView.Columns(0).HeaderText = "Modelo"
        DatosMaquinasDataGridView.Columns(0).Width = 120

        DatosMaquinasDataGridView.Columns(1).HeaderText = "Tipo de Máquina"
        DatosMaquinasDataGridView.Columns(1).Width = 120

        DatosMaquinasDataGridView.Columns(2).HeaderText = "Precio / Hora"
        DatosMaquinasDataGridView.Columns(3).HeaderText = "Teléfono SAT"

    End Sub

    Private Sub BuscarPorNombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles BuscarPorNombreTextBox.TextChanged

        Enlace.Filter = "Modelo LIKE '" & BuscarPorNombreTextBox.Text & "%'"

    End Sub

    Public Sub New(ByRef formPrincipal As Form1)

        InitializeComponent()
        Me.FormPrincipal = formPrincipal

    End Sub

End Class
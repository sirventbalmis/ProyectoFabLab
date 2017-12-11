Public Class GestionMaquinas

    Private Enlace As BindingSource
    Private TablaMaquinas As DataTable
    Private FormPrincipal As Form1

    Private Sub AddMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddMaquinaButton.Click

        Dim formNuevaMaq As New NuevaMaquina(Foo.TipoAccion.Insertar.ToString())
        formNuevaMaq.MdiParent = FormPrincipal
        formNuevaMaq.Show()

    End Sub

    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataSet As DataSet = NegocioMaquinas.ObtenerTodasLasMaquinas()

        Enlace = New BindingSource(dataSet, "Maquinas")

        DatosMaquinasDataGridView.DataSource = Enlace

        EstablecerColumnasDataGridView()

    End Sub

    Private Sub ConsultarMaqButton_Click(sender As Object, e As EventArgs) Handles ConsultarMaqButton.Click

        Dim formNuevaMaquina As New NuevaMaquina(Foo.TipoAccion.Consultar.ToString())
        formNuevaMaquina.Text = "FabLab - Consultar Máquina"
        formNuevaMaquina.MdiParent = FormPrincipal

        formNuevaMaquina.IdMaquina = DirectCast(DatosMaquinasDataGridView.SelectedCells(0).Value, Integer)
        formNuevaMaquina.Show()

    End Sub

    Private Sub EliminarMaqButton_Click(sender As Object, e As EventArgs) Handles EliminarMaqButton.Click

        BorrarFilaDataGridView()

        If NegocioMaquinas.BorrarMaquina(DirectCast(DatosMaquinasDataGridView.SelectedCells(0).Value, Integer)) Then          ' Eliminamos la máquina de la BD.

            MessageBox.Show("Máquina Eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("No se ha podido eliminar la máquina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    ''' <summary>
    ''' Borra la fila que contiene los datos de la máquina en el DataGridView.
    ''' </summary>
    Private Sub BorrarFilaDataGridView()

        If DatosMaquinasDataGridView.SelectedRows.Count = 0 Then

            MessageBox.Show("Tienes que seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            For Each fila As DataGridViewRow In DatosMaquinasDataGridView.SelectedRows

                DatosMaquinasDataGridView.Rows.Remove(fila)

            Next

        End If

    End Sub


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
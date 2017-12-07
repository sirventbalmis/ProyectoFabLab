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

        PruebaLabel.DataBindings.Add("Text", Enlace, "id")
        DatosMaquinasDataGridView.DataSource = Enlace

    End Sub

    Private Sub ConsultarMaqButton_Click(sender As Object, e As EventArgs) Handles ConsultarMaqButton.Click

        Dim formNuevaMaquina As New NuevaMaquina(Foo.TipoAccion.Consultar.ToString())
        formNuevaMaquina.Text = "FabLab - Consultar Máquina"
        formNuevaMaquina.MdiParent = FormPrincipal

        formNuevaMaquina.IdMaquina = Integer.Parse(PruebaLabel.Text)
        formNuevaMaquina.Show()

    End Sub

    Public Sub New(ByRef formPrincipal As Form1)

        InitializeComponent()
        Me.FormPrincipal = formPrincipal

    End Sub

End Class
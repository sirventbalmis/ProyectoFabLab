Imports ProyectoFabLab

Public Class ReservasUsuario

    Private _IdUsuario As Integer

    Public Property IdUsuario() As Integer
        Get
            Return _IdUsuario
        End Get

        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub CerrarFormButton_Click(sender As Object, e As EventArgs) Handles CerrarFormButton.Click

        Me.Close()

    End Sub

    Private Sub ReservasUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tabla As DataTable = NegocioReservas.ObtenerReservasUsuarioPorId(2)

        Dim dataSet As New DataSet()
        dataSet.Tables.Add(tabla)

        ReservUsuariosDataGridView.DataSource = dataSet.Tables("Reservas")
        EstablecerColumnasReservUsuarios()

    End Sub

    Private Sub EstablecerColumnasReservUsuarios()

        ReservUsuariosDataGridView.Columns(0).HeaderText = "Fecha"
        ReservUsuariosDataGridView.Columns(1).HeaderText = "Hora"
        ReservUsuariosDataGridView.Columns(2).HeaderText = "Proyecto"

    End Sub
End Class
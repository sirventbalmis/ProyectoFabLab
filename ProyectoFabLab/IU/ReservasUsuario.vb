Public Class ReservasUsuario

    Private FormPrincipal As Form1
    Private _IdUsuario As Integer
    Public Property IdUsuario() As Integer
        Get
            Return _IdUsuario
        End Get

        Set(ByVal value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Private Sub ReservasUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tablaReservas As DataTable = NegocioReservas.ObtenerReservasUsuarioPorId(IdUsuario)

        Dim dataSet As New DataSet()
        dataSet.Tables.Add(tablaReservas)

        Dim enlace As New BindingSource(dataSet, "Reservas")
        ReservUsuarioDataGridView.DataSource = enlace

    End Sub

    Public Sub New(ByRef formPrincipal As Form1)

        Me.FormPrincipal = formPrincipal

    End Sub

    Private Sub CerrarReservaButton_Click(sender As Object, e As EventArgs) Handles CerrarReservaButton.Click

        Me.Close()

    End Sub
End Class
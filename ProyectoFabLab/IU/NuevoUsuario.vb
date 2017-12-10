Imports System.Data.SqlClient
Public Class NuevoUsuario

    Private TipoAccion As String
    Private _IdUsuario As Integer
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(val As Integer)
            _IdUsuario = val
        End Set
    End Property

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then
            NombreTextBox.Enabled = False

            Dim valoresUsuario As SqlDataReader = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)
            NombreTextBox.Text = valoresUsuario.GetString(1)


            CargaValores()
        Else
            If TipoAccion.Equals(Foo.TipoAccion.Modificar.ToString()) Then

            End If
        End If
    End Sub

    Public Sub CargaValores()
        Dim valoresTipoUsuario As SqlDataReader = NegocioTiposUsuarios.ObtenerTiposUsuarios
        While valoresTipoUsuario.Read
            TipoUsuariosCMB.Items.Add(valoresTipoUsuario.GetString(0))
        End While
    End Sub


    Public Sub New(ByRef tipoAccion As String)

        InitializeComponent()
        Me.TipoAccion = tipoAccion

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class
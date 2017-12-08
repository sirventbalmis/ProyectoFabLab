Imports System.Data.SqlClient
Public Class NuevoUsuario

    Private TipoAccion As String

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaValores()
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
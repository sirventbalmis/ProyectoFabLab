Imports System.Data.SqlClient
Public Class NuevoUsuario

    Private TipoAccion As String

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub CargaValores()
        'Dim valoresTipoUsuario As New SqlRea
    End Sub


    Public Sub New(ByRef tipoAccion As String)

        InitializeComponent()
        Me.TipoAccion = tipoAccion

    End Sub
End Class
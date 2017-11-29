Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class MaquinasGateway
    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Inserta un usuario en la tabla.
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario</param>
    ''' <returns></returns>
    ''' 

    'Public Function InsertaMaquina(ByRef nombre As String,)

    'End Function

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

Imports System.Data.SqlClient

Public Class TiposUsuarioGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Inserta un tipo de usuario en la tabla.
    ''' </summary>
    ''' <param name="tipoUsuario">Tipo de usuario a insertar</param>
    ''' <returns></returns>
    Public Function Insertar(ByRef tipoUsuario As String) As Boolean

        Dim numFilas As Integer

        If tipoUsuario.Equals("") Or tipoUsuario = Nothing Then

            Throw New ArgumentException("No se ha introducido un nuevo tipo de usuario.")

        Else

            ConexionABd.Open()
            Comando.CommandText = String.Format("INSERT INTO TiposUsuario (tipoUsuario) VALUES('{0}')", tipoUsuario)
            numFilas = Comando.ExecuteNonQuery()

            If numFilas > 0 Then

                ConexionABd.Close()
                Return True

            Else

                Return False

            End If

        End If

    End Function

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

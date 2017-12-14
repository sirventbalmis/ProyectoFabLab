Imports System.Data.SqlClient

Public Class ReservasGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Obtiene las reservas de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="idUsuario">Id del usuario</param>
    ''' <returns>DataTable con las reservas de un usuario.</returns>
    Public Function SeleccionarReservasPorId(ByRef idUsuario As Integer) As DataTable

        Dim tablaReservas As New DataTable("Reservas")
        Dim tablaDatos As SqlDataReader

        If idUsuario = 0 Or idUsuario = Nothing Then

            Throw New ArgumentException("El id de la reserva es 0 o está vacío.")

        Else

            Try
                ConexionABd.Open()
                Comando.CommandText = String.Format("SELECT fecha, hora, proyecto FROM reservas WHERE usuario = {0}", idUsuario)
                tablaDatos = Comando.ExecuteReader()

                tablaReservas.Load(tablaDatos)

            Catch ex As Exception

                Throw New Exception(ex.Message)

            Finally

                If ConexionABd.State = ConnectionState.Open Then

                    ConexionABd.Close()

                End If

            End Try

            Return tablaReservas

        End If

    End Function

    Public Sub New(ByRef conexion As String)
        Me.ConexionABd = New SqlConnection(My.Settings.Conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

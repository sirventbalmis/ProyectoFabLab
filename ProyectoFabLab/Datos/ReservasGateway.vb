Imports System.Data.SqlClient

Public Class ReservasGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Altera la tabla de reservas para que permita borrar sin problema alguno
    ''' </summary>
    Public Sub NoCheck()
        ConexionABd.Open()
        Comando.CommandText = "ALTER TABLE MaquinasReserva NOCHECK CONSTRAINT all"
        Comando.ExecuteNonQuery()
        ConexionABd.Close()
    End Sub
    ''' <summary>
    ''' Vuelve al estado original de la tabla haciendo un check
    ''' </summary>
    Public Sub Check()
        ConexionABd.Open()
        Comando.CommandText = "ALTER TABLE MaquinasReserva CHECK CONSTRAINT all"
        Comando.ExecuteNonQuery()
        ConexionABd.Close()
    End Sub

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

                    ' ConexionABd.Close()

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

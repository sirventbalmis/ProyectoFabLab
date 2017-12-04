Imports System.Data.SqlClient

Public Class ReservasGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Obtiene las reservas de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario</param>
    ''' <returns>DataTable con las reservas de un usuario.</returns>
    Public Function SeleccionarReservasPorId(ByRef id As Integer) As DataTable

        Dim tablaReservas As New DataTable("Reservas")
        Dim tablaDatos As SqlDataReader

        If id = 0 Or id = Nothing Then

            Throw New ArgumentException("El id de la reserva es 0 o está vacío.")

        Else

            Try
                ConexionABd.Open()
                Comando.CommandText = String.Format("SELECT fecha, hora, proyecto FROM reservas WHERE usuario = {0}", id)
                tablaDatos = Comando.ExecuteReader()

                tablaReservas.Load(tablaDatos)

            Catch ex As Exception

                Throw New Exception(ex.Message)

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

Module NegocioReservas

    ''' <summary>
    ''' Obtiene las reservas de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario</param>
    ''' <returns>DataTable con las reservas de un usuario.</returns>
    Public Function ObtenerReservasUsuarioPorId(ByRef id As Integer) As DataTable

        Dim gatewayReservas As New ReservasGateway(My.Settings.Conexion)

        Return gatewayReservas.SeleccionarReservasPorId(id)

    End Function

End Module

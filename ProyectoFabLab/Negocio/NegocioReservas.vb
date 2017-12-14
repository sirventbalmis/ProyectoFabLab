Module NegocioReservas

    ''' <summary>
    ''' Obtiene las reservas de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="idUsuario">Id del usuario</param>
    ''' <returns>DataTable con las reservas de un usuario.</returns>
    Public Function ObtenerReservasUsuarioPorId(ByRef idUsuario As Integer) As DataTable

        Dim gatewayReservas As New ReservasGateway(My.Settings.Conexion)

        Return gatewayReservas.SeleccionarReservasPorId(idUsuario)

    End Function

End Module

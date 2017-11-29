Public Class Negocio

    ''' <summary>
    ''' Inserta un usuario a la tabla "Usuarios".
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario</param>
    ''' <param name="apellidos">Apellidos del usuario</param>
    ''' <param name="fechaNacimiento">Fecha de Nacimiento del usuario</param>
    ''' <param name="telefono">Teléfono del usuario</param>
    ''' <param name="email">E-mail del usuario</param>
    ''' <param name="direccion">Dirección del usuario</param>
    ''' <param name="organizacion">Organización del usuario</param>
    ''' <param name="tipo">Tipo de usuario</param>
    ''' <param name="fechaAlta">Fecha de alta del usuario</param>
    Public Function InsertarUsuario(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As Integer) As Boolean



        Dim gatewayUsuario As New UsuariosGateway(My.Settings.Conexion)

        If gatewayUsuario.Insertar(nombre, apellidos, fechaNacimiento, telefono, email, direccion, organizacion, tipo) Then

            Return True

        Else

            Return False

        End If

    End Function


    ''' <summary>
    ''' Muestra los datos del usuario a partir de su Id.
    ''' </summary>
    ''' <param name="idUsuario"></param>
    ''' <returns>DataTable con los datos de ese usuario</returns>
    Public Function MostrarDatosUsuario(ByRef idUsuario As Integer) As DataTable

        Dim gatewayDatosUsuario As New UsuariosGateway(My.Settings.Conexion)

        Return gatewayDatosUsuario.SeleccionarUsuarioPorId(idUsuario)

    End Function

    Public Function InsertarTipoUsuario(ByRef tipoUsuario As String) As Boolean

        Dim gatewayTipoUsuario As New TiposUsuarioGateway(My.Settings.Conexion)

        If gatewayTipoUsuario.Insertar(tipoUsuario) Then

            Return True

        Else

            Return False

        End If

    End Function

End Class

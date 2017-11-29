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
    Public Function InsertarUsuario(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As Integer, ByRef fechaAlta As Date) As Boolean

        Dim gatewayUsuario As New UsuariosGateway(My.Settings.Conexion)

        If gatewayUsuario.Insertar(nombre, apellidos, fechaAlta, telefono, email, direccion, organizacion, tipo, fechaAlta) Then

            Return True

        Else

            Return False

        End If

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

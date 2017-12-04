Imports System.Data.SqlClient

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
    Public Function InsertarUsuario(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As String) As Boolean

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.Insertar(nombre, apellidos, fechaNacimiento, telefono, email, direccion, organizacion, tipo)

    End Function


    ''' <summary>
    ''' Muestra los datos del usuario a partir de su Id.
    ''' </summary>
    ''' <param name="idUsuario"></param>
    ''' <returns>DataTable con los datos de ese usuario</returns>
    Public Function ObtenerDatosUsuarioPorId(ByRef idUsuario As Integer) As DataTable

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.SeleccionarPorId(idUsuario)

    End Function


    ''' <summary>
    ''' Modifica los datos de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario</param>
    ''' <param name="nombre">Nuevo nombre del usuario</param>
    ''' <param name="apellidos">Nuevos apellidos del usuario</param>
    ''' <param name="telefono">Nuevo teléfono del usuario</param>
    ''' <param name="email">Nuevo email del usuario</param>
    ''' <param name="direccion">Nueva dirección del usuario</param>
    ''' <param name="organizacion">Nueva organización del usuario</param>
    ''' <param name="tipo">Nuevo tipo de usuario</param>
    ''' <returns>True: Se han actualizado los datos. False: No se han actualizado los datos</returns>
    Public Function ModificarDatosUsuarioPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As String) As Boolean

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.ModificarPorId(id, nombre, apellidos, telefono, email, direccion, organizacion, tipo)

    End Function


    ''' <summary>
    ''' Elimina un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario a borrar</param>
    ''' <returns>True: El usuario se ha eliminado. False: El usuario no se ha eliminado</returns>
    Public Function EliminarUsuarioPorId(ByRef id As Integer) As Boolean

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.EliminarPorId(id)

    End Function


    ''' <summary>
    ''' Obtiene el número de usuarios actuales.
    ''' </summary>
    ''' <returns>Número de usuarios actuales</returns>
    Public Function ObtenerNumUsuarios() As Integer

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.SeleccionarNumUsuarios()

    End Function


    ''' <summary>
    ''' Inserta un nuevo tipo de usuario.
    ''' </summary>
    ''' <param name="tipoUsuario">Tipo de usuario a insertar</param>
    ''' <returns>True: Se ha insertado el nuevo tipo de usuario False: No se ha insertado el nuevo tipo de usuario</returns>
    Public Function InsertarTipoUsuario(ByRef tipoUsuario As String) As Boolean

        Dim gatewayTipoUsuario As New TiposUsuarioGateway(My.Settings.Conexion)

        If gatewayTipoUsuario.InsertarTipoUsuario(tipoUsuario) Then

            Return True

        Else

            Return False

        End If

    End Function


    ''' <summary>
    ''' Obtiene todos los tipos de usuarios.
    ''' </summary>
    ''' <returns>SqlDataReader con todos los tipos</returns>
    Public Function ObtenerTiposUsuarios() As SqlDataReader

        Dim tiposUsuarioGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        Return tiposUsuarioGateway.SeleccionarTipos()

    End Function


    ''' <summary>
    ''' Obtiene el Id del tipo de usuario a partir de uno introducido.
    ''' </summary>
    ''' <param name="tipo">Tipo de usuario existente</param>
    ''' <returns>El id del tipo de usuario</returns>
    Public Function ObtenerIdTipoUsuarioPorNombre(ByRef tipo As String) As Integer

        Dim tiposUsuarioGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        Return tiposUsuarioGateway.SeleccionarPorNombre(tipo)

    End Function

End Class

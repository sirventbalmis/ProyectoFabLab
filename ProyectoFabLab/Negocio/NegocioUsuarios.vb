Imports System.Data.SqlClient

Module NegocioUsuarios

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
    ''' <param name="tipoUsuario">Tipo de usuario</param>    
    Public Function InsertarUsuario(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As DateTime, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipoUsuario As String, ByRef observaciones As String) As Boolean

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.Insertar(nombre, apellidos, fechaNacimiento, telefono, email, direccion, organizacion, tipoUsuario, observaciones)

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
    '''  Modifica los datos de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="nombre"></param>
    ''' <param name="apellidos"></param>
    ''' <param name="telefono"></param>
    ''' <param name="email"></param>
    ''' <param name="direccion"></param>
    ''' <param name="organizacion"></param>
    ''' <param name="tipo"></param>
    ''' <param name="observaciones"></param>
    ''' <returns>True: Se han actualizado los datos. False: No se han actualizado los datos</returns>
    Public Function ModificarDatosUsuarioPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As String, ByRef observaciones As String) As Boolean

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.ModificarPorId(id, nombre, apellidos, fechaNacimiento, telefono, email, direccion, organizacion, tipo, observaciones)

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

    Public Function ObtenerUltimoIdUsuarios() As Integer
        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)
        Return usuariosGateway.SeleccionarUltimoUsuario()
    End Function

    ''' <summary>
    ''' Obtiene los datos de los usuarios para mostrarlos en el DataGridView de la gestión de los usuarios.
    ''' </summary>
    ''' <returns>SqlDataAdapter con la información de los usuarios.</returns>
    Public Function ObtenerDatosUsuarios() As DataTable

        Dim usuariosGateway As New UsuariosGateway(My.Settings.Conexion)

        Return usuariosGateway.SeleccionarDatosUsuarios()

    End Function

End Module

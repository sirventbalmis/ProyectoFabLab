Imports System.Data.SqlClient

Module NegocioTiposUsuarios

    ''' <summary>
    ''' Inserta un nuevo tipo de usuario.
    ''' </summary>
    ''' <param name="tipo">Tipo de usuario a insertar</param>
    ''' <returns>True: Se ha insertado el nuevo tipo de usuario False: No se ha insertado el nuevo tipo de usuario</returns>
    Public Function InsertarTipoUsuario(ByRef tipo As String) As Boolean

        Dim gatewayTipoUsuario As New TiposUsuarioGateway(My.Settings.Conexion)

        Return gatewayTipoUsuario.InsertarTipoUsuario(tipo)

    End Function


    ''' <summary>
    ''' Modifica el tipo de usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">El id del tipo de usuario</param>
    ''' <param name="tipoUsuario">Nuevo tipo de usuario</param>
    ''' <returns>True: Se ha modificado el tipo de usuario. False: No se ha modificado el tipo de usuario.</returns>
    Public Function ModificarTipoUsuarioPorId(ByRef id As Integer, ByRef tipoUsuario As String) As Boolean

        Dim gatewayTiposUsuario As New TiposUsuarioGateway(My.Settings.Conexion)

        Return gatewayTiposUsuario.ModificarPorId(id, tipoUsuario)

    End Function


    ''' <summary>
    ''' Elimina un tipo de usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del tipo de usuario a eliminar</param>
    ''' <returns>True: El tipo de usuario se ha eliminado. False: El tipo de usuario no se ha eliminado.</returns>
    Public Function EliminarTipoUsuarioPorId(ByRef id As Integer) As Boolean

        Dim gatewayTiposUsuario As New TiposUsuarioGateway(My.Settings.Conexion)

        Return gatewayTiposUsuario.EliminarPorId(id)

    End Function


    ''' <summary>
    ''' Obtiene todos los tipos de usuarios.
    ''' </summary>
    ''' <returns>DatatTable con todos los tipos</returns>
    Public Function ObtenerTiposUsuarios() As DataTable

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

End Module

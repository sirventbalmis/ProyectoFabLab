Imports System.Data.SqlClient
Module NegocioTiposMaquinas

    ''' <summary>
    ''' Obtiene todos los tipos de máquinas
    ''' </summary>
    ''' <returns>Devuelve un DataTable con los tipos de máquinas</returns>
    Public Function ObtenerTiposMaquinas() As DataTable
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.SeleccionarTipos()
    End Function

    ''' <summary>
    ''' Obtiene una máquina a partir de su nombre
    ''' </summary>
    ''' <param name="tipo">Tipo de máquina a obtener</param>
    ''' <returns>Devuelve un ID (entero) de la máquina </returns>
    Public Function ObtieneMaquinaPorNombre(ByRef tipo As String) As Integer
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.SeleccionaMaquinaPorNombre(tipo)
    End Function

    ''' <summary>
    ''' Modifica maquina mediante parámetros
    ''' </summary>
    ''' <param name="id">Id de la máquina a modificar</param>
    ''' <param name="tipo">Nuevo tipo de máquina</param>
    ''' <returns>Devuelve un booleano si el tipo de máquina ha sido modificado correctamente</returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef tipo As String) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.ModificaMaquina(id, tipo)
    End Function

    ''' <summary>
    ''' Borra una máquina con un ID
    ''' </summary>
    ''' <param name="id">Id de máquina a borrar</param>
    ''' <returns>Devuelve un booleano si el borrado ha sido correcto</returns>
    Public Function BorraMaquina(ByRef id As Integer) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.BorraMaquina(id)
    End Function
    ''' <summary>
    ''' Inserta un tipo de máquina
    ''' </summary>
    ''' <param name="tipo">Tipo de máquina</param>
    ''' <returns>Devuelve un booleano si la inserción ha sido correcto</returns>
    Public Function InsertarTipoMaquina(ByRef tipo As String) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.InsertarTipoMaquina(tipo)
    End Function



End Module

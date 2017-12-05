Imports System.Data.SqlClient
Module NegocioTiposMaquinas                                                             ' Atributos de la Clase -> PASCAL CASE. Nombres de variables en funciones, procedimientos -> CAMEL CASE    

    ''' <summary>
    ''' Obtiene todos los tipos de máquinas
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerTiposMaquinas() As SqlDataReader

        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.SeleccionarTipos()
    End Function

    ''' <summary>
    ''' Obtiene una máquina a partir de su nombre
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
    Public Function ObtieneMaquinaPorNombre(ByRef tipo As String) As Integer
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.SeleccionaMaquinaPorNombre(tipo)
    End Function

    ''' <summary>
    ''' Modifica maquina mediante parámetros
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef tipo As String) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.ModificaMaquina(id, tipo)
    End Function
    ''' <summary>
    ''' Borra una máquina con un ID
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function BorraMaquina(ByRef id As Integer) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.BorraMaquina(id)
    End Function
    ''' <summary>
    ''' Inserta un tipo de máquina
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
    Public Function InsertarTipoMaquina(ByRef tipo As String) As Boolean
        Dim TiposMaquinaGateway As New TiposMaquinaGateway(My.Settings.Conexion)
        Return TiposMaquinaGateway.InsertarTipoMaquina(tipo)
    End Function



End Module

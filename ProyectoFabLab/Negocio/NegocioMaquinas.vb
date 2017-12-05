Imports System.Data.SqlClient
Module NegocioMaquinas
    ''' <summary>
    ''' Obtiene todas las máquinas
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerTodasLasMaquinas() As DataTable
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.SeleccionaTodasLasMaquinas()
    End Function
    ''' <summary>
    ''' Obtiene el número de máquinas
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerNumeroMaquinas() As SqlDataReader
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.NumeroMaquinas()
    End Function
    ''' <summary>
    ''' Obtiene las máquinas por ID
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function ObtenerMaquinasPorId(ByRef id As Integer) As DataTable
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.SeleccionarMaquinasPorId(id)
    End Function
    ''' <summary>
    ''' Inserta la máquina 
    ''' </summary>
    ''' <param name="modelo"></param>
    ''' <param name="precio_hora"></param>
    ''' <param name="fecha_compra"></param>
    ''' <param name="telefono_sat"></param>
    ''' <param name="tipo"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="caracteristicas"></param>
    ''' <returns></returns>
    Public Function InsertarMaquina(ByRef modelo As String, ByRef precio_hora As Integer, ByRef fecha_compra As Date, ByRef telefono_sat As String, ByRef tipo As Integer, ByRef descripcion As String, ByRef caracteristicas As String) As Boolean
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.InsertarMaquina(modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
    End Function
    ''' <summary>
    ''' Modifica una máquina con el ID y sus parámetros correspondientes
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="modelo"></param>
    ''' <param name="precio_hora"></param>
    ''' <param name="fecha_compra"></param>
    ''' <param name="telefono_sat"></param>
    ''' <param name="tipo"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="caracteristicas"></param>
    ''' <returns></returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef modelo As String, ByRef precio_hora As Integer, ByRef fecha_compra As Date, ByRef telefono_sat As String, ByRef tipo As Integer, ByRef descripcion As String, ByRef caracteristicas As String) As Boolean
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.ModificaMaquina(id, modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
    End Function

    ''' <summary>
    ''' Borra una máquina con el ID
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function BorrarMaquina(ByRef id As Integer) As Boolean
        Dim MaquinasGateway As New MaquinasGateway(My.Settings.Conexion)
        Return MaquinasGateway.BorrarMaquina(id)
    End Function

End Module

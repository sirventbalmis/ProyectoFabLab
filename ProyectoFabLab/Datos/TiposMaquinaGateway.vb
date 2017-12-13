Imports System.Data.SqlClient
Public Class TiposMaquinaGateway
    Private ConexionBD As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Selecciona los tipos de máquina existentes
    ''' </summary>
    ''' <returns>Devuelve un DataTable con los tipos de máquinas existentes</returns>
    Public Function SeleccionarTipos() As DataTable
        Dim lector As SqlDataReader
        Dim tabla As New DataTable("TipoMaquinas")
        Try
            ConexionBD.Open()
            Comando.CommandText = "SELECT tipo FROM TiposMaquina"
            lector = Comando.ExecuteReader()
            tabla.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return tabla
    End Function

    ''' <summary>
    ''' Inserta un tipo de máquina especificado por parámetro
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns>Devuelve un booleano si la inserción ha sido correcta</returns>
    Public Function InsertarTipoMaquina(ByRef tipo As String) As Boolean
        Dim numeroFilas As Integer
        If tipo.Equals("") Or tipo = Nothing Then
            Throw New ArgumentException("No has introducido un tipo de máquina correcto.")
        Else
            Try
                ConexionBD.Open()
                Comando.CommandText = String.Format("INSERT INTO TiposMaquina VALUES('{0}')", tipo)
                numeroFilas = Comando.ExecuteNonQuery()
                CerrarBD()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            If numeroFilas > 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function


    ''' <summary>
    ''' Devuelve ID de la máquina con un nombre
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
    Public Function SeleccionaMaquinaPorNombre(ByRef tipo As String) As Integer
        Dim idTipoMaquina As Integer
        Try
            ConexionBD.Open()
            Comando.CommandText = String.Format("SELECT id FROM TiposMaquina WHERE tipo = '{0}'", tipo)
            idTipoMaquina = DirectCast(Comando.ExecuteScalar(), Integer)
            CerrarBD()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idTipoMaquina
    End Function

    ''' <summary>
    ''' Modifica máquina a partir de parámetros
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef tipo As String) As Boolean
        Dim numeroFilas As Integer
        Try
            ConexionBD.Open()
            Comando.CommandText = String.Format("UPDATE TiposMaquina SET tipo = '{0}' WHERE id = {1}", tipo, id)
            numeroFilas = Comando.ExecuteNonQuery()
            CerrarBD()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        If numeroFilas > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Borra una máquina a partir de un ID
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function BorraMaquina(ByRef id As Integer) As Boolean
        Dim numeroFilas As Integer
        Try
            ConexionBD.Open()
            Comando.CommandText = String.Format("DELETE FROM TiposMaquina WHERE id = {0}", id)
            numeroFilas = Comando.ExecuteNonQuery()
            CerrarBD()



        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        If numeroFilas > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Cierra la conexión a la BBDD
    ''' </summary>
    Private Sub CerrarBD()
        ConexionBD.Close()
    End Sub

    ''' <summary>
    ''' Conexión a BBDD
    ''' </summary>
    ''' <param name="conexion"></param>
    Public Sub New(ByRef conexion As String)
        Me.ConexionBD = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionBD
    End Sub
End Class

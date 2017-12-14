Imports System.Data.SqlClient
Public Class TiposMaquinaGateway
    Private ConexionBaseDatos As SqlConnection
    Private ComandoSql As SqlCommand

    ''' <summary>
    ''' Selecciona los tipos de máquina existentes
    ''' </summary>
    ''' <returns>Devuelve un DataTable con los tipos de máquinas existentes</returns>
    Public Function SeleccionarTipos() As DataTable
        Dim lectorReader As SqlDataReader
        Dim tablaMaquinas As New DataTable("TipoMaquinas")
        Try
            ConexionBaseDatos.Open()
            ComandoSql.CommandText = "SELECT tipo FROM TiposMaquina"
            lectorReader = ComandoSql.ExecuteReader()
            tablaMaquinas.Load(lectorReader)
            CerrarBD()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return tablaMaquinas
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
                ConexionBaseDatos.Open()
                ComandoSql.CommandText = String.Format("INSERT INTO TiposMaquina VALUES('{0}')", tipo)
                numeroFilas = ComandoSql.ExecuteNonQuery()
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
    ''' <param name="tipo">Tipo de máquina</param>
    ''' <returns>Devuelve el ID de la máquina especificándole un nombre</returns>
    Public Function SeleccionaMaquinaPorNombre(ByRef tipo As String) As Integer
        Dim idTipoMaquina As Integer
        Try
            ConexionBaseDatos.Open()
            ComandoSql.CommandText = String.Format("SELECT id FROM TiposMaquina WHERE tipo = '{0}'", tipo)
            idTipoMaquina = DirectCast(ComandoSql.ExecuteScalar(), Integer)
            CerrarBD()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idTipoMaquina
    End Function

    ''' <summary>
    ''' Modifica máquina a partir de parámetros
    ''' </summary>
    ''' <param name="id">Id de la máquina a modificar</param>
    ''' <param name="tipo">Nuevo tipo de máquina</param>
    ''' <returns>Devuelve un booleano si la modificación ha sido correcta</returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef tipo As String) As Boolean
        Dim numeroFilas As Integer
        Try
            ConexionBaseDatos.Open()
            ComandoSql.CommandText = String.Format("UPDATE TiposMaquina SET tipo = '{0}' WHERE id = {1}", tipo, id)
            numeroFilas = ComandoSql.ExecuteNonQuery()
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
    ''' <param name="id">Id de la máquina a borrar</param>
    ''' <returns>Devuelve un booleano si el borrado ha sido correcto</returns>
    Public Function BorraMaquina(ByRef id As Integer) As Boolean
        Dim numeroFilas As Integer
        Try
            ConexionBaseDatos.Open()
            ComandoSql.CommandText = String.Format("DELETE FROM TiposMaquina WHERE id = {0}", id)
            numeroFilas = ComandoSql.ExecuteNonQuery()
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
        ConexionBaseDatos.Close()
    End Sub

    ''' <summary>
    ''' Conexión a BBDD
    ''' </summary>
    ''' <param name="conexion"></param>
    Public Sub New(ByRef conexion As String)
        Me.ConexionBaseDatos = New SqlConnection(conexion)
        Me.ComandoSql = New SqlCommand()
        Me.ComandoSql.Connection = Me.ConexionBaseDatos
    End Sub
End Class

Imports System.Data.SqlClient
Public Class TiposMaquinaGateway
    Private ConexionBD As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Selecciona los tipos de máquina existentes
    ''' </summary>
    ''' <returns></returns>
    Public Function SeleccionarTipos() As SqlDataReader
        Dim lector As SqlDataReader
        Try
            ConexionBD.Open()
            Comando.CommandText = "SELECT tipo FROM TiposMaquina"
            lector = Comando.ExecuteReader()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return lector
    End Function

    ''' <summary>
    ''' Inserta un tipo de máquina especificado por parámetro
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns></returns>
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

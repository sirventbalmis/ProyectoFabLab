﻿Imports System.Data.SqlClient

Public Class TiposUsuarioGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Inserta un nuevo tipo de usuario en la tabla TiposUsuarios.
    ''' </summary>
    ''' <param name="tipo">El tipo de usuario a insertar</param>
    ''' <returns>True: Se ha insertado el nuevo tipo de usuario False: No se ha insertado el nuevo tipo de usuario</returns>
    Public Function InsertarTipoUsuario(ByRef tipo As String) As Boolean

        Dim numFilas As Integer

        If tipo.Equals("") Or tipo = Nothing Then

            Throw New ArgumentException("No se ha introducido un nuevo tipo de usuario.")

        Else

            Try
                ConexionABd.Open()
                Comando.CommandText = String.Format("INSERT INTO TiposUsuario (tipoUsuario) VALUES('{0}')", tipo)
                numFilas = Comando.ExecuteNonQuery()

                ConexionABd.Close()

            Catch ex As Exception

                Throw New Exception(ex.Message)

            End Try

            If numFilas > 0 Then

                Return True

            Else

                Return False

            End If

        End If

    End Function


    ''' <summary>
    ''' Obtiene todos los tipos de usuarios.
    ''' </summary>
    ''' <returns>SqlDataReader con todos los tipos</returns>
    Public Function SeleccionarTipos() As SqlDataReader

        Dim lector As SqlDataReader

        Try
            ConexionABd.Open()
            Comando.CommandText = "SELECT tipo FROM TiposUsuario"
            lector = Comando.ExecuteReader()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        Return lector

    End Function


    ''' <summary>
    ''' Obtiene el Id del tipo de usuario a partir de uno introducido.
    ''' </summary>
    ''' <param name="tipo"></param>
    ''' <returns>El id del tipo</returns>
    Public Function SeleccionarPorNombre(ByRef tipo As String) As Integer

        Dim numTipoUsuario As Integer

        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("SELECT id FROM TiposUsuario WHERE tipo = '{0}'", tipo)
            numTipoUsuario = DirectCast(Comando.ExecuteScalar(), Integer)

            CerrarConexionABd()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        Return numTipoUsuario

    End Function


    Public Function EliminarPorId(ByRef id As Integer) As Boolean

        Dim numFilas As Integer

        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("DELETE FROM TiposUsuario WHERE id = {0}", id)
            numFilas = Comando.ExecuteNonQuery()

            CerrarConexionABd()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        If numFilas > 0 Then

            Return True

        Else

            Return False

        End If

    End Function


    ''' <summary>
    ''' Cierra la conexión a la Base de Datos.
    ''' </summary>
    Private Sub CerrarConexionABd()

        ConexionABd.Close()

    End Sub

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

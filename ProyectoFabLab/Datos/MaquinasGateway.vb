﻿Imports System.Data.SqlClient
Public Class MaquinasGateway
    Private ConexionBD As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Selecciona todas las máquinas y las carga en una tabla
    ''' </summary>
    ''' <returns>Devuelve todas las máquinas en un DataTable</returns>
    Public Function SeleccionaTodasLasMaquinas() As DataTable
        Dim lector As SqlDataReader
        Dim tabla As New DataTable("Maquinas")
        Try
            ConexionBD.Open()
            Comando.CommandText = "SELECT m.id, m.modelo, t.tipo, m.precio_hora, m.telefono_sat FROM Maquinas AS m JOIN TiposMaquina AS t ON m.tipo = t.id"
            lector = Comando.ExecuteReader()
            tabla.Load(lector)
            ConexionBD.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return tabla
    End Function

    ''' <summary>
    ''' Obtenemos el número de todas las máquinas ahora mismo
    ''' </summary>
    ''' <returns>Devuelve un entero con el número de maquinas actuales</returns>
    Public Function NumeroMaquinas() As Integer
        Dim num As Integer
        Try
            ConexionBD.Open()
            Comando.CommandText = "SELECT COUNT(*) FROM Maquinas"
            num = CInt(Comando.ExecuteScalar())
            ConexionBD.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return num
    End Function

    ''' <summary>
    ''' Selecciona una máquina por ID
    ''' </summary>
    ''' <param name="id">Id de la máquina a seleccionar</param>
    ''' <returns>Devuelve un DataTable con el valor de la máquina seleccionada</returns>
    Public Function SeleccionarMaquinasPorId(ByRef id As Integer) As DataTable
        Dim lector As SqlDataReader
        Dim tabla As New DataTable("Maquinas")
        If id > 0 Then
            Try
                ConexionBD.Open()
                Comando.CommandText = String.Format("SELECT id, modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas FROM Maquinas WHERE id = {0}", id)
                lector = Comando.ExecuteReader()
                tabla.Load(lector)
                ConexionBD.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Else
            Throw New ArgumentException("El ID no es correcto.")
        End If
        Return tabla
    End Function

    ''' <summary>
    ''' Inserta una máquina en la BBDD
    ''' </summary>
    ''' <param name="modelo">Modelo de máquina</param>
    ''' <param name="precio_hora">Precio/hora de máquina</param>
    ''' <param name="fecha_compra">Fecha de compra de máquina</param>
    ''' <param name="telefono_sat">Teléfono de máquina</param>
    ''' <param name="tipo">Tipo de máquina</param>
    ''' <param name="descripcion">Descripción de máquina</param>
    ''' <param name="caracteristicas">Características de máquina</param>
    ''' <returns>Devuelve un booleano de si la inserción ha sido correcta</returns>
    Public Function InsertarMaquina(ByRef modelo As String, ByRef precio_hora As Integer, ByRef fecha_compra As Date, ByRef telefono_sat As String, ByRef tipo As Integer, ByRef descripcion As String, ByRef caracteristicas As String) As Boolean
        Dim numeroFilas As Integer = 0
        Dim condicionModelo As Boolean = False
        Dim condicionprecio_hora As Boolean = False
        Dim condicionfecha_compra As Boolean = False
        Dim condiciontipo As Boolean = False

        ' ---------------------------------------------
        ' Comprobamos que el campo modelo no sea vacío
        If modelo.Equals("") Or modelo = Nothing Then
            Throw New ArgumentException("El campo nombre está vacío.")
        Else
            condicionModelo = True
        End If
        ' ---------------------------------------------
        ' Comprobamos que el campo precio hora sea correcto
        If precio_hora < 0 Then
            Throw New ArgumentException("El campo precio hora no es correcto.")
        Else
            condicionprecio_hora = True
        End If
        ' ---------------------------------------------
        ' Comprobamos que el campo fecha compra sea correcto
        If fecha_compra = Nothing Then
            Throw New ArgumentException("El campo fecha compra no es correcto.")
        Else
            condicionfecha_compra = True
        End If
        ' ---------------------------------------------
        ' Comprobamos que el campo fecha compra sea correcto
        If fecha_compra = Nothing Then
            Throw New ArgumentException("El campo fecha compra no es correcto.")
        Else
            condicionfecha_compra = True
        End If
        ' ---------------------------------------------
        ' Comprobamos que el campo tipo sea correcto
        If tipo < 0 Then
            Throw New ArgumentException("El campo tipo no es correcto.")
        Else
            condiciontipo = True
        End If

        MsgBox(precio_hora)
        Dim sentenciaInsert As String
        sentenciaInsert = String.Format("INSERT INTO Maquinas(modelo, precio_hora, fechacompra, telefono_sat, tipo, descripcion, caracteristicas) VALUES('{0}',{1},{2},'{3}',{4},'{5}','{6}'", modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
        ConexionBD.Open()
        Comando.CommandText = sentenciaInsert.ToString()
        numeroFilas = Comando.ExecuteNonQuery()
        ConexionBD.Close()

        If numeroFilas > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Modificamos la máquina mediante los parámetros
    ''' </summary>
    ''' <param name="id">Id de la máquina a modificar</param>
    ''' <param name="modelo">Nuevo modelo de máquina</param>
    ''' <param name="precio_hora">Nuevo precio/hora de máquina</param>
    ''' <param name="fecha_compra">Nueva fecha de compra de máquina</param>
    ''' <param name="telefono_sat">Nuevo teléfono de máquina</param>
    ''' <param name="tipo">Nuevo tipo de máquina</param>
    ''' <param name="descripcion">Nueva descripción de máquina</param>
    ''' <param name="caracteristicas">Nuevas características de máquina</param>
    ''' <returns>Devuelve si la modificación ha sido correcta o no mediante un Booleano</returns>
    Public Function ModificaMaquina(ByRef id As Integer, ByRef modelo As String, ByRef precio_hora As Integer, ByRef fecha_compra As Date, ByRef telefono_sat As String, ByRef tipo As Integer, ByRef descripcion As String, ByRef caracteristicas As String) As Boolean
        Dim numeroFilas As Integer = 0
        Dim condicionModelo As Boolean = False
        Dim condicionprecio_hora As Boolean = False
        Dim condicionfecha_compra As Boolean = False
        Dim condiciontipo As Boolean = False
        If id > 0 Then
            ' ---------------------------------------------
            ' Comprobamos que el campo modelo no sea vacío
            If modelo.Equals("") Or modelo = Nothing Then
                Throw New ArgumentException("El campo nombre está vacío.")
            Else
                condicionModelo = True
            End If
            ' ---------------------------------------------
            ' Comprobamos que el campo precio hora sea correcto
            If precio_hora < 0 Then
                Throw New ArgumentException("El campo precio hora no es correcto.")
            Else
                condicionprecio_hora = True
            End If
            ' ---------------------------------------------
            ' Comprobamos que el campo fecha compra sea correcto
            If fecha_compra = Nothing Then
                Throw New ArgumentException("El campo fecha compra no es correcto.")
            Else
                condicionfecha_compra = True
            End If
            ' ---------------------------------------------
            ' Comprobamos que el campo fecha compra sea correcto
            If fecha_compra = Nothing Then
                Throw New ArgumentException("El campo fecha compra no es correcto.")
            Else
                condicionfecha_compra = True
            End If
            ' ---------------------------------------------
            ' Comprobamos que el campo tipo sea correcto
            If tipo < 0 Then
                Throw New ArgumentException("El campo tipo no es correcto.")
            Else
                condiciontipo = True
            End If
            Dim sentenciaUpdate As String
            sentenciaUpdate = String.Format("UPDATE Maquinas SET modelo = '{0}', precio_hora = {1},fecha_compra = {2},telefono_sat = '{3}', tipo = {4},descripcion = '{5}', caracteristicas = '{6}'", modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
            ConexionBD.Open()
            Comando.CommandText = sentenciaUpdate.ToString()
            numeroFilas = Comando.ExecuteNonQuery()
            ConexionBD.Close()

            If numeroFilas > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Throw New ArgumentException("El ID no es correcto.")
        End If
    End Function

    ''' <summary>
    ''' Borra la máquina con un ID seleccionado
    ''' </summary>
    ''' <param name="id">Id de la máquina a borrar</param>
    ''' <returns>Devuelve un booleano de si el borrado ha sido correcto o no</returns>
    Public Function BorrarMaquina(ByRef id As Integer) As Boolean
        Dim numReservas As Integer
        Dim numFilas As Integer
        If id > 0 Then
            Try
                ConexionBD.Open()
                Comando.CommandText = "SELECT COUNT(Maq.Reserva) FROM MaquinasReserva Maq WHERE  Maq.Maquina = 1"
                numReservas = DirectCast(Comando.ExecuteScalar(), Integer)

                If numReservas > 0 Then

                    MessageBox.Show("No se puede eliminar la máquina porque tiene reservas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else

                    Comando.CommandText = String.Format("DELETE FROM Maquinas WHERE Id = {0}", id)
                    numFilas = Comando.ExecuteNonQuery()

                    ConexionBD.Close()

                    If numFilas > 0 Then
                        Return True
                    Else
                        Return False
                    End If

                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        Else
            Throw New ArgumentException("El ID no es correcto.")
        End If

    End Function


    ''' <summary>
    ''' Obtenemos el último Id de la máquina
    ''' </summary>
    ''' <returns>El último Id de la máquina</returns>
    Public Function SeleccionarUltimoIdMaquina() As Integer
        Dim ultimoId As Integer
        Try
            ConexionBD.Open()
            Comando.CommandText = "SELECT MAX(Id) FROM Maquinas"
            ultimoId = Integer.Parse(Comando.ExecuteScalar().ToString())
            ConexionBD.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return ultimoId

    End Function

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

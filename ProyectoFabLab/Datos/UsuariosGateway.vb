Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text

Public Class UsuariosGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Inserta un usuario en la tabla.
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario</param>
    ''' <param name="apellidos">Apellidos del usuario</param>
    ''' <param name="fechaNacimiento">Fecha de Nacimiento del usuario</param>
    ''' <param name="telefono">Teléfono del usuario</param>
    ''' <param name="email">E-mail del usuario</param>
    ''' <param name="direccion">Dirección del usuario</param>
    ''' <param name="organizacion">Organización del usuario</param>
    ''' <param name="tipo">Tipo de usuario</param>    
    ''' <returns>True: El usuario se ha insertado. False: El usuario no se ha insertado</returns>
    Public Function Insertar(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As String) As Boolean

        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esNombreCorrecto As Boolean = False
        Dim esApellidoCorrecto As Boolean = False
        Dim esProfesionalOInvestigador As Boolean = False
        ' Dim patronTelefono As Regex = New Regex("^[0-9]{9}$")
        ' Dim patronEmail As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim sentenciaInsert As New StringBuilder("INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta) VALUES(")
        Dim lector As SqlDataReader
        Dim tiposUsuarioGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        If nombre.Equals("") Or nombre = Nothing Then

            Throw New ArgumentException("El campo nombre está vacío.")

        Else

            esNombreCorrecto = True

        End If

        If apellidos.Equals("") Or apellidos = Nothing Then

            Throw New ArgumentException("El campo apellidos está vacío.")

        Else

            esApellidoCorrecto = True

        End If


        If esNombreCorrecto And esApellidoCorrecto Then         ' Añadimos el nombre, los apellidos y la fecha de nacimiento al INSERT.

            sentenciaInsert.Append(String.Format("'{0}', '{1}', CONVERT(varchar, '{2}', 105)", nombre, apellidos, fechaNacimiento.Date.ToString()))

        End If

        If telefono.Equals("") Then

            sentenciaInsert.Append(", NULL")

        Else

            sentenciaInsert.Append(String.Format(", '{0}'", telefono))          ' Añadimos el teléfono.

        End If

        If email.Equals("") Then

            sentenciaInsert.Append(", NULL")

        Else

            sentenciaInsert.Append(String.Format(", '{0}'", email))             ' Añadimos el email.

        End If

        If direccion.Equals("") Then

            sentenciaInsert.Append(", NULL")

        Else

            sentenciaInsert.Append(String.Format(", '{0}'", direccion))         ' Añadimos la dirección.

        End If

        lector = tiposUsuarioGateway.SeleccionarTipos()         ' Obtenemos los tipos de usuarios para, saber si el usuario es profesional o investigador.

        While lector.Read

            If tipo.Equals(lector.GetString(0)) Then

                esProfesionalOInvestigador = True

            End If

        End While

        CerrarConexionABd()

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            Else

                sentenciaInsert.Append(String.Format(", '{0}'", organizacion))                ' Añadimos la organización.

            End If

        Else

            sentenciaInsert.Append(", NULL")

        End If

        numTipoUsuario = tiposUsuarioGateway.SeleccionarPorNombre(tipo)
        sentenciaInsert.Append(String.Format(", {0}", numTipoUsuario))

        sentenciaInsert.Append(", CONVERT(varchar, GETDATE(), 105))")
        MessageBox.Show(sentenciaInsert.ToString(), "Sentencia", MessageBoxButtons.OK, MessageBoxIcon.Information)          ' Para hacer pruebas mientras se depura.

        Try
            ConexionABd.Open()
            Comando.CommandText = sentenciaInsert.ToString()
            numFilas = Comando.ExecuteNonQuery()

            CerrarConexionABd()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        If numFilas > 0 Then            ' Se ha insertado un usuario.

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


    ''' <summary>
    ''' Muestra los datos de un usuario a partir de un Id.
    ''' </summary>
    ''' <param name="idUsuario">Id del usuario para obtener sus datos</param>
    ''' <returns>DataTable con los datos de ese usuario</returns>
    Public Function SeleccionarPorId(ByRef idUsuario As Integer) As DataTable

        Dim tabla As New DataTable("Usuarios")
        Dim lector As SqlDataReader

        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("SELECT nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta FROM Usuarios WHERE Usuarios.id = {0}", idUsuario)
            lector = Comando.ExecuteReader()

            tabla.Load(lector)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally
            If ConexionABd.State = ConnectionState.Open Then

                ConexionABd.Close()

            End If

        End Try

        Return tabla

    End Function


    ''' <summary>
    ''' Cambia los datos de un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario</param>
    ''' <param name="nombre">Nuevo nombre del usuario</param>
    ''' <param name="apellidos">Nuevos apellidos del usuario</param>
    ''' <param name="telefono">Nuevo teléfono del usuario</param>
    ''' <param name="email">Nuevo email del usuario</param>
    ''' <param name="direccion">Nueva dirección del usuario</param>
    ''' <param name="organizacion">Nueva organización del usuario</param>
    ''' <param name="tipo">Nuevo tipo del usuario</param>
    ''' <returns>True: Se han actualizado los datos. False: No se han actualizado los datos</returns>
    Public Function ModificarPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As String) As Boolean

        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esNombreCorrecto As Boolean = False
        Dim esApellidoCorrecto As Boolean = False
        Dim esProfesionalOInvestigador As Boolean = False
        Dim sentenciaUpdate As New StringBuilder("UPDATE Usuarios ")
        Dim lector As SqlDataReader
        Dim tiposUsuariosGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        If nombre.Equals("") Or nombre = Nothing Then

            Throw New ArgumentException("El campo nombre está vacío.")

        Else

            esNombreCorrecto = True

        End If

        If apellidos.Equals("") Or apellidos = Nothing Then

            Throw New ArgumentException("El campo apellidos está vacío.")

        Else

            esApellidoCorrecto = True

        End If

        If esNombreCorrecto And esApellidoCorrecto Then

            sentenciaUpdate.Append(String.Format("SET nombre = '{0}', SET apellidos = '{1}'", nombre, apellidos))

        End If

        If email.Equals("") Then

            sentenciaUpdate.Append(", SET email = NULL")

        Else

            sentenciaUpdate.Append(String.Format(", SET email = '{0}'", email))

        End If

        If direccion.Equals("") Then

            sentenciaUpdate.Append(", SET direccion = NULL")

        Else

            sentenciaUpdate.Append(String.Format(", SET direccion = '{0}'", direccion))

        End If

        lector = tiposUsuariosGateway.SeleccionarTipos()          ' Obtenemos los tipos de usuarios para, saber si el usuario es profesional o investigador.

        While lector.Read

            If tipo.Equals(lector.GetString(0)) Then

                esProfesionalOInvestigador = True

            End If

        End While

        CerrarConexionABd()

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            Else

                sentenciaUpdate.Append(String.Format(", SET organizacion = '{0}'", organizacion))                ' Cambiamos la organización.

            End If

        Else

            sentenciaUpdate.Append(", SET organizacion = NULL")

        End If

        numTipoUsuario = tiposUsuariosGateway.SeleccionarPorNombre(tipo)
        sentenciaUpdate.Append(String.Format(", SET tipo = {0}", numTipoUsuario)).Append(")")
        MessageBox.Show(sentenciaUpdate.ToString(), "Sentencia", MessageBoxButtons.OK, MessageBoxIcon.Information)          ' Para hacer pruebas mientras se depura.

        Try
            ConexionABd.Open()
            Comando.CommandText = sentenciaUpdate.ToString()
            numFilas = Comando.ExecuteNonQuery()

            CerrarConexionABd()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        If numFilas > 0 Then            ' Se ha actualizado un usuario.

            Return True

        Else

            Return False

        End If

    End Function


    ''' <summary>
    ''' Elimina un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario a borrar</param>
    ''' <returns></returns>
    Public Function EliminarPorId(ByRef id As Integer) As Boolean

        Dim numFilas As Integer

        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("DELETE FROM Usuarios WHERE id = {0}", id)
            numFilas = Comando.ExecuteNonQuery()

            CerrarConexionABd()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        If numFilas > 0 Then            ' Se ha actualizado un usuario.

            Return True

        Else

            Return False

        End If

    End Function

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

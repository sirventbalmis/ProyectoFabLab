Imports System.Data.SqlClient
Imports System.Text

Public Class UsuariosGateway

    Private ConexionABd As SqlConnection
    Private Comando As SqlCommand

    ''' <summary>
    ''' Altera la tabla de reservas para que permita borrar sin problema alguno
    ''' </summary>
    Public Sub NoCheck()
        ConexionABd.Open()
        Comando.CommandText = "ALTER TABLE Reservas NOCHECK CONSTRAINT all"
        Comando.ExecuteNonQuery()
        ConexionABd.Close()
    End Sub
    ''' <summary>
    ''' Vuelve al estado original de la tabla haciendo un check
    ''' </summary>
    Public Sub Check()
        ConexionABd.Open()
        Comando.CommandText = "ALTER TABLE Reservas CHECK CONSTRAINT all"
        Comando.ExecuteNonQuery()
        ConexionABd.Close()
    End Sub
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
    ''' <param name="tipoUsuario">Tipo de usuario</param>    
    ''' <param name="observaciones">Observaciones del usuario</param>  
    ''' <returns>True: El usuario se ha insertado. False: El usuario no se ha insertado</returns>
    Public Function Insertar(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As String, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipoUsuario As String, ByRef observaciones As String) As Boolean


        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esNombreCorrecto As Boolean = False
        Dim esApellidoCorrecto As Boolean = False
        Dim esProfesionalOInvestigador As Boolean = False
        ' Dim patronTelefono As Regex = New Regex("^[0-9]{9}$")
        ' Dim patronEmail As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim sentenciaInsert As New StringBuilder("INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones) VALUES(")
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

            sentenciaInsert.Append("@Nombre, @Apellidos, '@FechaNacimiento'")

        End If

        If telefono.Equals("") Then

            sentenciaInsert.Append(", @TefVacio")

        Else

            sentenciaInsert.Append(", @Telefono")

        End If

        If email.Equals("") Then

            sentenciaInsert.Append(", @EmailVacio")

        Else

            sentenciaInsert.Append(", @Email")

        End If

        If direccion.Equals("") Then

            sentenciaInsert.Append(", @DireccVacio")

        Else

            sentenciaInsert.Append(", @Direccion")

        End If

        If observaciones.Equals("") Then

            sentenciaInsert.Append(", @ObservacionesVacio")

        Else

            sentenciaInsert.Append(", @Observaciones")

        End If

        If tipoUsuario.Equals("Profesional") Or tipoUsuario.Equals("Investigador") Then

            esProfesionalOInvestigador = True

        End If

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            Else

                sentenciaInsert.Append(", @Organizacion")

            End If

        Else

            sentenciaInsert.Append(", @OrgVacio")

        End If

        numTipoUsuario = tiposUsuarioGateway.SeleccionarPorNombre(tipoUsuario)              ' Obtenemos el id del tipo de usuario.
        sentenciaInsert.Append(", @NumTipoUsuario")

        sentenciaInsert.Append(", '@FechaAlta')")

        Try
            ConexionABd.Open()
            Comando.CommandText = sentenciaInsert.ToString()

            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
            Comando.Parameters("@Nombre").Value = nombre

            Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar)
            Comando.Parameters("@Apellidos").Value = apellidos

            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date)
            Comando.Parameters("@FechaNacimiento").Value = Date.Parse(fechaNacimiento)

            Comando.Parameters.Add("@TefVacio", SqlDbType.VarChar)
            Comando.Parameters("@TefVacio").Value = DBNull.Value

            Comando.Parameters.Add("@EmailVacio", SqlDbType.VarChar)
            Comando.Parameters("@EmailVacio").Value = DBNull.Value

            Comando.Parameters.Add("@DireccVacio", SqlDbType.VarChar)
            Comando.Parameters("@DireccVacio").Value = DBNull.Value

            Comando.Parameters.Add("@OrgVacio", SqlDbType.VarChar)
            Comando.Parameters("@OrgVacio").Value = DBNull.Value

            Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
            Comando.Parameters("@Telefono").Value = telefono

            Comando.Parameters.Add("@Email", SqlDbType.VarChar)
            Comando.Parameters("@Email").Value = email

            Comando.Parameters.Add("@Direccion", SqlDbType.VarChar)
            Comando.Parameters("@Direccion").Value = direccion

            Comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)
            Comando.Parameters("@Organizacion").Value = organizacion

            Comando.Parameters.Add("@NumTipoUsuario", SqlDbType.Int)
            Comando.Parameters("@NumTipoUsuario").Value = numTipoUsuario

            Comando.Parameters.Add("@FechaAlta", SqlDbType.Date)
            Comando.Parameters("@FechaAlta").Value = Date.Now

            Comando.Parameters.Add("@Observaciones", SqlDbType.Text)
            Comando.Parameters("@Observaciones").Value = observaciones
            numFilas = Comando.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                CerrarConexionABd()

            End If

        End Try

        If numFilas > 0 Then            ' Se ha insertado el usuario.

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
        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("SELECT nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones FROM Usuarios WHERE Usuarios.id = {0}", idUsuario)
            Dim datos As SqlDataReader = Comando.ExecuteReader()
            tabla.Load(datos)
            Return tabla
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try

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
    ''' <param name="tipoUsuario">Nuevo tipo de usuario</param>
    ''' <param name="observaciones">Nuevas observaciones del usuario</param>
    ''' <returns>True: Se han actualizado los datos. False: No se han actualizado los datos</returns>
    Public Function ModificarPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipoUsuario As String, ByRef observaciones As String) As Boolean

        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esNombreCorrecto As Boolean = False
        Dim esApellidoCorrecto As Boolean = False
        Dim esProfesionalOInvestigador As Boolean = False
        Dim sentenciaUpdate As New StringBuilder("UPDATE Usuarios ")
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

            sentenciaUpdate.Append("SET Nombre = @Nombre, Apellidos = @Apellidos")

        End If

        If email.Equals("") Then

            sentenciaUpdate.Append(", Email = @EmailVacio")

        Else

            sentenciaUpdate.Append(", Email = @Email")

        End If

        If observaciones.Equals("") Then

            sentenciaUpdate.Append(", Observaciones = @ObservacionesVacio")

        Else

            sentenciaUpdate.Append(", Observaciones = @Observaciones")

        End If

        If telefono.Equals("") Then

            sentenciaUpdate.Append(", Telefono = @TefVacio")

        Else

            sentenciaUpdate.Append(", Telefono = @Telefono")

        End If

        If direccion.Equals("") Then

            sentenciaUpdate.Append(", Direccion = @DireccVacio")

        Else

            sentenciaUpdate.Append(", Direccion = @Direccion")

        End If

        If tipoUsuario.Equals("Profesional") Or tipoUsuario.Equals("Investigador") Then

            esProfesionalOInvestigador = True

        End If

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            Else

                sentenciaUpdate.Append(", Organizacion = @Organizacion")

            End If

        Else

            sentenciaUpdate.Append(", Organizacion = @OrgVacio")

        End If

        numTipoUsuario = tiposUsuariosGateway.SeleccionarPorNombre(tipoUsuario)
        sentenciaUpdate.Append(", tipo = @NumTipoUsuario WHERE id = @NumUsuario")

        Try
            ConexionABd.Open()
            Comando.CommandText = sentenciaUpdate.ToString()

            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
            Comando.Parameters("@Nombre").Value = nombre

            Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar)
            Comando.Parameters("@Apellidos").Value = apellidos

            Comando.Parameters.Add("@TefVacio", SqlDbType.VarChar)
            Comando.Parameters("@TefVacio").Value = DBNull.Value

            Comando.Parameters.Add("@EmailVacio", SqlDbType.VarChar)
            Comando.Parameters("@EmailVacio").Value = DBNull.Value

            Comando.Parameters.Add("@DireccVacio", SqlDbType.VarChar)
            Comando.Parameters("@DireccVacio").Value = DBNull.Value

            Comando.Parameters.Add("@OrgVacio", SqlDbType.VarChar)
            Comando.Parameters("@OrgVacio").Value = DBNull.Value

            Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)
            Comando.Parameters("@Telefono").Value = telefono

            Comando.Parameters.Add("@Email", SqlDbType.VarChar)
            Comando.Parameters("@Email").Value = email

            Comando.Parameters.Add("@Direccion", SqlDbType.VarChar)
            Comando.Parameters("@Direccion").Value = direccion

            Comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)
            Comando.Parameters("@Organizacion").Value = organizacion

            Comando.Parameters.Add("@Observaciones", SqlDbType.Text)
            Comando.Parameters("@Observaciones").Value = observaciones

            Comando.Parameters.Add("@ObservacionesVacio", SqlDbType.Text)
            Comando.Parameters("@ObservacionesVacio").Value = DBNull.Value

            Comando.Parameters.Add("@NumTipoUsuario", SqlDbType.Int)
            Comando.Parameters("@NumTipoUsuario").Value = numTipoUsuario

            Comando.Parameters.Add("@NumUsuario", SqlDbType.Int)
            Comando.Parameters("@NumUsuario").Value = id

            numFilas = Comando.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                CerrarConexionABd()

            End If

        End Try

        If numFilas > 0 Then            ' Se ha actualizado el usuario.

            Return True

        Else

            Return False

        End If

    End Function


    ''' <summary>
    ''' Elimina un usuario a partir de su Id.
    ''' </summary>
    ''' <param name="id">Id del usuario a borrar</param>
    ''' <returns>True: El usuario se ha eliminado. False: El usuario no se ha eliminado</returns>
    Public Function EliminarPorId(ByRef id As Integer) As Boolean
        Dim numFilas As Integer
        Try
            ConexionABd.Open()
            Comando.CommandText = String.Format("DELETE FROM Usuarios WHERE Id = {0}", id)
            numFilas = Comando.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                CerrarConexionABd()

            End If

        End Try

        If numFilas > 0 Then            ' Se ha actualizado el usuario.

            Return True

        Else

            Return False

        End If
    End Function


    ''' <summary>
    ''' Obtiene el número de usuarios actuales.
    ''' </summary>
    ''' <returns>Número de usuarios actuales</returns>
    Public Function SeleccionarNumUsuarios() As Integer

        Dim numUsuariosActuales As Integer

        Try
            ConexionABd.Open()
            Comando.CommandText = "SELECT COUNT(Id) FROM Usuarios"
            numUsuariosActuales = DirectCast(Comando.ExecuteScalar(), Integer)

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                CerrarConexionABd()

            End If

        End Try

        Return numUsuariosActuales

    End Function


    ''' <summary>
    ''' Obtiene los datos de los usuarios para mostrarlos en el DataGridView de la gestión de los usuarios.
    ''' </summary>
    ''' <returns>DataTable con la información de los usuarios.</returns>
    Public Function SeleccionarDatosUsuarios() As DataTable

        Dim tabla As New DataTable("Usuarios")
        Try
            ConexionABd.Open()
            Comando.CommandText = "SELECT Usuarios.Id, Usuarios.Nombre, TiposUsuario.Tipo, Usuarios.Organizacion, Usuarios.Fecha_Alta
                                            FROM   Usuarios
	                                               JOIN TiposUsuario ON Usuarios.tipo = TiposUsuario.Id"

            Dim datos As SqlDataReader = Comando.ExecuteReader()
            tabla.Load(datos)

            Return tabla

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

    End Function

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

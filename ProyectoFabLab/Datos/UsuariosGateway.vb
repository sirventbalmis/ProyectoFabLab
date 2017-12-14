Imports System.Data.SqlClient
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
    ''' <param name="tipoUsuario">Tipo de usuario</param>    
    ''' <param name="observaciones">Observaciones del usuario</param>  
    ''' <returns>True: El usuario se ha insertado. False: El usuario no se ha insertado</returns>
    Public Function Insertar(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As DateTime, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipoUsuario As String, ByRef observaciones As String) As Boolean

        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esProfesionalOInvestigador As Boolean = False
        Dim tiposUsuarioGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        If nombre.Equals("") Or nombre = Nothing Then

            Throw New ArgumentException("El campo nombre está vacío.")

        End If

        If apellidos.Equals("") Or apellidos = Nothing Then

            Throw New ArgumentException("El campo apellidos está vacío.")

        End If

        If tipoUsuario.Equals("Profesional") Or tipoUsuario.Equals("Investigador") Then

            esProfesionalOInvestigador = True

        End If

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            End If

        End If

        numTipoUsuario = tiposUsuarioGateway.SeleccionarPorNombre(tipoUsuario)              ' Obtenemos el id del tipo de usuario.

        Try
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
            Comando.Parameters("@Nombre").Value = nombre

            Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar)
            Comando.Parameters("@Apellidos").Value = apellidos

            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date)
            Comando.Parameters("@FechaNacimiento").Value = fechaNacimiento

            Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)

            If telefono.Equals("") Then

                Comando.Parameters("@Telefono").Value = DBNull.Value

            Else

                Comando.Parameters("@Telefono").Value = telefono

            End If

            Comando.Parameters.Add("@Email", SqlDbType.VarChar)

            If email.Equals("") Then

                Comando.Parameters("@Email").Value = DBNull.Value

            Else

                Comando.Parameters("@Email").Value = email

            End If

            Comando.Parameters.Add("@Direccion", SqlDbType.VarChar)

            If direccion.Equals("") Then

                Comando.Parameters("@Direccion").Value = DBNull.Value

            Else

                Comando.Parameters("@Direccion").Value = direccion

            End If

            Comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)

            If esProfesionalOInvestigador Then

                If Not organizacion.Equals("") Then

                    Comando.Parameters("@Organizacion").Value = organizacion

                End If

            Else

                Comando.Parameters("@Organizacion").Value = DBNull.Value

            End If

            Comando.Parameters.Add("@NumTipoUsuario", SqlDbType.Int)
            Comando.Parameters("@NumTipoUsuario").Value = numTipoUsuario

            Comando.Parameters.Add("@FechaAlta", SqlDbType.Date)
            Comando.Parameters("@FechaAlta").Value = DateTime.Today

            Comando.Parameters.Add("@Observaciones", SqlDbType.Text)

            If observaciones.Equals("") Then

                Comando.Parameters("@Observaciones").Value = DBNull.Value

            Else

                Comando.Parameters("@Observaciones").Value = observaciones

            End If

            ConexionABd.Open()

            Dim sentenciaInsert As String = "INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones) VALUES(@Nombre, @Apellidos, @FechaNacimiento, @Telefono, @Email, @Direccion, @Organizacion, @NumTipoUsuario, @FechaAlta, @Observaciones)"
            Comando.CommandText = sentenciaInsert

            numFilas = Comando.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                ConexionABd.Close()

            End If

        End Try

        If numFilas > 0 Then            ' Se ha insertado el usuario.

            Return True

        Else

            Return False

        End If

    End Function


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
            ConexionABd.Close()
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
    Public Function ModificarPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipoUsuario As String, ByRef observaciones As String) As Boolean

        Dim numFilas As Integer, numTipoUsuario As Integer
        Dim esProfesionalOInvestigador As Boolean = False
        Dim tiposUsuariosGateway As New TiposUsuarioGateway(My.Settings.Conexion)

        If nombre.Equals("") Or nombre = Nothing Then

            Throw New ArgumentException("El campo nombre está vacío.")

        End If

        If apellidos.Equals("") Or apellidos = Nothing Then

            Throw New ArgumentException("El campo apellidos está vacío.")

        End If

        If tipoUsuario.Equals("Profesional") Or tipoUsuario.Equals("Investigador") Then

            esProfesionalOInvestigador = True

        End If

        If esProfesionalOInvestigador Then

            If organizacion.Equals("") Then             ' Si el usuario es profesional o investigador. Pero, no ha introducido una orgnanización, lanzamos una excepción.

                Throw New ArgumentException("El campo organización está vacío.")

            End If

        End If

        numTipoUsuario = NegocioTiposUsuarios.ObtenerIdTipoUsuarioPorNombre(tipoUsuario)              ' Obtenemos el id del tipo de usuario.

        Try
            Comando.Parameters.Add("@Nombre", SqlDbType.VarChar)
            Comando.Parameters("@Nombre").Value = nombre

            Comando.Parameters.Add("@Apellidos", SqlDbType.VarChar)
            Comando.Parameters("@Apellidos").Value = apellidos

            Comando.Parameters.Add("@FechaNacimiento", SqlDbType.Date)
            Comando.Parameters("@FechaNacimiento").Value = fechaNacimiento

            Comando.Parameters.Add("@Telefono", SqlDbType.VarChar)

            If telefono.Equals("") Then

                Comando.Parameters("@Telefono").Value = DBNull.Value

            Else

                Comando.Parameters("@Telefono").Value = telefono

            End If

            Comando.Parameters.Add("@Email", SqlDbType.VarChar)

            If email.Equals("") Then

                Comando.Parameters("@Email").Value = DBNull.Value

            Else

                Comando.Parameters("@Email").Value = email

            End If

            Comando.Parameters.Add("@Direccion", SqlDbType.VarChar)

            If direccion.Equals("") Then

                Comando.Parameters("@Direccion").Value = DBNull.Value

            Else

                Comando.Parameters("@Direccion").Value = direccion

            End If

            Comando.Parameters.Add("@Organizacion", SqlDbType.VarChar)

            If esProfesionalOInvestigador Then

                If Not organizacion.Equals("") Then

                    Comando.Parameters("@Organizacion").Value = organizacion

                End If

            Else

                Comando.Parameters("@Organizacion").Value = DBNull.Value

            End If

            Comando.Parameters.Add("@NumTipoUsuario", SqlDbType.Int)
            Comando.Parameters("@NumTipoUsuario").Value = numTipoUsuario

            Comando.Parameters.Add("@FechaAlta", SqlDbType.Date)
            Comando.Parameters("@FechaAlta").Value = DateTime.Today

            Comando.Parameters.Add("@Observaciones", SqlDbType.Text)

            If observaciones.Equals("") Then

                Comando.Parameters("@Observaciones").Value = DBNull.Value

            Else

                Comando.Parameters("@Observaciones").Value = observaciones

            End If

            ConexionABd.Open()

            Dim sentenciaUpdate As String = "UPDATE Usuarios SET nombre = @Nombre, apellidos = @Apellidos, fecha_nacimiento = @FechaNacimiento, telefono = @Telefono, email = @Email, direccion = @Direccion, organizacion = @Organizacion, tipo = @NumTipoUsuario, observaciones = @Observaciones WHERE id = " & id
            Comando.CommandText = sentenciaUpdate

            numFilas = Comando.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            If ConexionABd.State = ConnectionState.Open Then

                ConexionABd.Close()

            End If

        End Try

        If numFilas > 0 Then            ' Se ha insertado el usuario.

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

                ConexionABd.Close()

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

                ConexionABd.Close()

            End If

        End Try

        Return numUsuariosActuales

    End Function

    ''' <summary>
    ''' Selecciona el último ID de la tabla usuarios
    ''' </summary>
    ''' <returns>Devuelve un ID con el último usuario</returns>
    Public Function SeleccionarUltimoUsuario() As Integer
        Dim ultimoId As Integer
        Try
            ConexionABd.Open()
            Comando.CommandText = "SELECT MAX(Id) FROM Usuarios"
            ultimoId = Integer.Parse(Comando.ExecuteScalar().ToString())
            ConexionABd.Close()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return ultimoId
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

Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

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
    ''' <param name="fechaAlta">Fecha de alta del usuario</param>
    ''' <returns>True: El usuario se ha insertado. False: El usuario no se ha insertado</returns>
    Public Function Insertar(ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As Integer) As Boolean

        Dim numFilas As Integer
        Dim esNombreCorrecto As Boolean = False
        Dim esApellidoCorrecto As Boolean = False
        Dim esTelefonoCorrecto As Boolean = False
        Dim esEmailCorrecto As Boolean = False
        Dim esDireccionCorrecta As Boolean = False
        Dim esOrgCorrecta As Boolean = False
        Dim esTipoCorrecto As Boolean = False
        Dim patronTelefono As Regex = New Regex("^[0-9]{9}$")
        Dim patronEmail As Regex = New Regex("^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$")






        'If nombre.Equals("") Or nombre = Nothing Then

        '    Throw New ArgumentException("El campo nombre está vacío.")

        'Else

        '    esNombreCorrecto = True

        'End If

        'If apellidos.Equals("") Or apellidos = Nothing Then

        '    Throw New ArgumentException("El campo apellidos está vacío.")

        'Else

        '    esApellidoCorrecto = True

        'End If

        'If telefono.Equals("") Or telefono = Nothing Then

        '    Throw New ArgumentException("El campo teléfono está vacío.")

        'Else

        '    If patronTelefono.IsMatch(telefono) Then

        '        esTelefonoCorrecto = True

        '    End If

        'End If

        'If email.Equals("") Or email = Nothing Then

        '    Throw New ArgumentException("El campo email está vacío.")

        'Else

        '    esEmailCorrecto = True

        'End If

        'If direccion.Equals("") Or direccion = Nothing Then

        '    Throw New ArgumentException("El campo dirección está vacío.")

        'Else

        '    esDireccionCorrecta = True

        'End If

        'If organizacion.Equals("") Or organizacion = Nothing Then

        '    Throw New ArgumentException("El campo organización está vacío.")

        'Else

        '    esOrgCorrecta = True

        'End If

        If esNombreCorrecto And esApellidoCorrecto And esTelefonoCorrecto And esEmailCorrecto And esDireccionCorrecta And esOrgCorrecta Then        ' Si todos los campos son correctos añadimos el usuario.

            Try
                ConexionABd.Open()
                Comando.CommandText = String.Format("")
                numFilas = Comando.ExecuteNonQuery()

            Catch ex As Exception

                Throw New Exception(ex.Message)

            Finally
                If ConexionABd.State = ConnectionState.Open Then

                    ConexionABd.Close()

                End If

            End Try

        End If

        If numFilas > 0 Then            ' Se ha insertado un usuario.

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
    Public Function SeleccionarUsuarioPorId(ByRef idUsuario As Integer) As DataTable

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

    Public Function ModificarUsuarioPorId(ByRef id As Integer, ByRef nombre As String, ByRef apellidos As String, ByRef fechaNacimiento As Date, ByRef telefono As String, ByRef email As String, ByRef direccion As String, ByRef organizacion As String, ByRef tipo As Integer, ByRef fechaAlta As Date) As Boolean



    End Function

    Public Sub New(ByRef conexion As String)

        Me.ConexionABd = New SqlConnection(conexion)
        Me.Comando = New SqlCommand()
        Me.Comando.Connection = Me.ConexionABd

    End Sub

End Class

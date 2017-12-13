Imports System.Data.SqlClient
Public Class NuevoUsuario

    Private TipoAccion As String
    Private _IdUsuario As Integer
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(val As Integer)
            _IdUsuario = val
        End Set
    End Property

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then
            Dim valoresUsuario As DataTable = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)
            '0 nombre, 1 apellidos, 2 fecha_nacimiento, 3 telefono, 4 email, 5 direccion, 6 organizacion, 7 tipo, 8 fecha_alta'

            NombreTextBox.Enabled = False
            NombreTextBox.Text = CType(valoresUsuario.Rows(0).Item(0), String)

            ApellidosTextBox.Enabled = False
            ApellidosTextBox.Text = CType(valoresUsuario.Rows(0).Item(1), String)

            FechaNacimientoDTP.Enabled = False
            FechaNacimientoDTP.Text = CType(valoresUsuario.Rows(0).Item(2), String)

            TelefonoTextBox.Enabled = False
            EmailTextBox.Enabled = False
            DireccionTextBox.Enabled = False
            OrganizacionTextBox.Enabled = False


            If Not IsDBNull(valoresUsuario.Rows(0).Item(3)) Then
                TelefonoTextBox.Text = CType(valoresUsuario.Rows(0).Item(3), String)
            End If
            If Not IsDBNull(valoresUsuario.Rows(0).Item(4)) Then
                EmailTextBox.Text = CType(valoresUsuario.Rows(0).Item(4), String)
            End If
            If Not IsDBNull(valoresUsuario.Rows(0).Item(5)) Then
                DireccionTextBox.Text = CType(valoresUsuario.Rows(0).Item(5), String)
            End If
            If Not IsDBNull(valoresUsuario.Rows(0).Item(6)) Then
                OrganizacionTextBox.Text = CType(valoresUsuario.Rows(0).Item(6), String)
            End If
            AceptarButton.Visible = False
            CancelarButton.Text = "OK"
            CargaValores()
        Else
            If TipoAccion.Equals(Foo.TipoAccion.Modificar.ToString()) Then
                Dim valoresUsuario As DataTable = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)
                '0 nombre, 1 apellidos, 2 fecha_nacimiento, 3 telefono, 4 email, 5 direccion, 6 organizacion, 7 tipo, 8 fecha_alta'

                NombreTextBox.Text = CType(valoresUsuario.Rows(0).Item(0), String)
                ApellidosTextBox.Text = CType(valoresUsuario.Rows(0).Item(1), String)
                FechaNacimientoDTP.Text = CType(valoresUsuario.Rows(0).Item(2), String)

                If Not IsDBNull(valoresUsuario.Rows(0).Item(3)) Then
                    TelefonoTextBox.Text = CType(valoresUsuario.Rows(0).Item(3), String)
                End If
                If Not IsDBNull(valoresUsuario.Rows(0).Item(4)) Then
                    EmailTextBox.Text = CType(valoresUsuario.Rows(0).Item(4), String)
                End If
                If Not IsDBNull(valoresUsuario.Rows(0).Item(5)) Then
                    DireccionTextBox.Text = CType(valoresUsuario.Rows(0).Item(5), String)
                End If
                If Not IsDBNull(valoresUsuario.Rows(0).Item(6)) Then
                    OrganizacionTextBox.Text = CType(valoresUsuario.Rows(0).Item(6), String)
                End If
                CargaValores()
                AceptarButton.Text = "Guardar"
            End If
        End If
    End Sub

    Public Sub CargaValores()
        Dim valoresTipoUsuario As SqlDataReader = NegocioTiposUsuarios.ObtenerTiposUsuarios
        While valoresTipoUsuario.Read
            TipoUsuariosCMB.Items.Add(valoresTipoUsuario.GetString(0))
        End While
    End Sub


    Public Sub New(ByRef tipoAccion As String)

        InitializeComponent()
        Me.TipoAccion = tipoAccion

    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

End Class
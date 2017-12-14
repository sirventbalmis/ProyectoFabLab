Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.ProjectOxford.Vision
Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class NuevoUsuario

    Private TipoAccion As String
    Private _IdUsuario As Integer
    Private FormPrincipal As Form1

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(val As Integer)
            _IdUsuario = val
        End Set
    End Property

    Private Sub CargarImgUsuario()
        Try
            FotoPictureBox.Image = Image.FromFile(My.Settings.CarpetaUsuarios & IdUsuario & ".jpg")
        Catch ex As FileNotFoundException

        End Try

    End Sub

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then
            CargaValores()
            CargarImgUsuario()
            Dim valoresUsuario As DataTable = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)

            NombreTextBox.Enabled = False
            NombreTextBox.Text = CType(valoresUsuario.Rows(0).Item(0), String)
            ApellidosTextBox.Enabled = False
            ApellidosTextBox.Text = CType(valoresUsuario.Rows(0).Item(1), String)
            ExaminarButton.Visible = False
            FechaNacimientoDTP.Enabled = False
            FechaNacimientoDTP.Text = CType(valoresUsuario.Rows(0).Item(2), String)

            TelefonoTextBox.Enabled = False
            EmailTextBox.Enabled = False
            DireccionTextBox.Enabled = False
            OrganizacionTextBox.Enabled = False
            ObservacionesRichTextBox.Enabled = False
            AddTipoUsuario.Enabled = False
            AddTipoUsuario.Visible = False
            TipoUsuariosCMB.Enabled = False
            TipoUsuariosCMB.SelectedIndex = CInt(valoresUsuario.Rows(0).Item(7)) - 1

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
            If Not IsDBNull(valoresUsuario.Rows(0).Item(9)) Then
                ObservacionesRichTextBox.Text = CType(valoresUsuario.Rows(0).Item(9), String)
            End If
            AceptarButton.Visible = False
            CancelarButton.Text = "OK"
        Else
            If TipoAccion.Equals(Foo.TipoAccion.Modificar.ToString()) Then

                Dim valoresUsuario As DataTable = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)
                CargarImgUsuario()
                CargaValores()
                NombreTextBox.Text = CType(valoresUsuario.Rows(0).Item(0), String)

                ApellidosTextBox.Text = CType(valoresUsuario.Rows(0).Item(1), String)

                FechaNacimientoDTP.Text = CType(valoresUsuario.Rows(0).Item(2), String)

                TipoUsuariosCMB.SelectedIndex = CInt(valoresUsuario.Rows(0).Item(7)) - 1

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
                If Not IsDBNull(valoresUsuario.Rows(0).Item(9)) Then
                    ObservacionesRichTextBox.Text = CType(valoresUsuario.Rows(0).Item(9), String)
                End If
                AceptarButton.Text = "Guardar"
            Else
                If TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then
                    CargaValores()
                    AceptarButton.Text = "Guardar"
                End If
            End If
        End If
    End Sub

    Public Sub CargaValores()
        TipoUsuariosCMB.Items.Clear()
        Dim valoresTipoUsuario As SqlDataReader = NegocioTiposUsuarios.ObtenerTiposUsuarios
        While valoresTipoUsuario.Read
            TipoUsuariosCMB.Items.Add(valoresTipoUsuario.GetString(0))
        End While
    End Sub


    Public Sub New(ByRef tipoAccion As String, ByRef formPrincipal As Form1)

        InitializeComponent()
        Me.TipoAccion = tipoAccion
        Me.FormPrincipal = formPrincipal
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Public Function ComprobarValores() As Boolean
        If TelefonoTextBox.Text = String.Empty Then
            If EmailTextBox.Text = String.Empty Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        If ComprobarValores() Then
            If TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then
                If NegocioUsuarios.InsertarUsuario(NombreTextBox.Text, ApellidosTextBox.Text, FechaNacimientoDTP.Value.Date, TelefonoTextBox.Text, EmailTextBox.Text, DireccionTextBox.Text, OrganizacionTextBox.Text, TipoUsuariosCMB.Text, ObservacionesRichTextBox.Text) Then
                    MessageBox.Show("Usuario Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If NegocioUsuarios.ModificarDatosUsuarioPorId(_IdUsuario, NombreTextBox.Text, ApellidosTextBox.Text, FechaNacimientoDTP.Value.Date, TelefonoTextBox.Text, EmailTextBox.Text, DireccionTextBox.Text, OrganizacionTextBox.Text, TipoUsuariosCMB.Text, ObservacionesRichTextBox.Text) Then
                    MessageBox.Show("Usuario Guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Revisa tus valores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    ''' <summary>
    ''' Obtiene una miniatura de la imagen seleccionada.
    ''' </summary>
    ''' <param name="rutaImagen"></param>
    ''' <returns>Array de byte con los datos de la miniatura.</returns>
    Private Async Function GetThumbnail(ByVal rutaImagen As String) As Task(Of Byte())

        Dim client As New VisionServiceClient(My.Settings.ClaveServicioMiniatura, My.Settings.UrlServicioMiniatura)
        Dim miniatura As Byte()

        Using stream As Stream = File.OpenRead(rutaImagen)

            Try
                miniatura = Await client.GetThumbnailAsync(stream, 400, 400, True)

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End Using

        Return miniatura

    End Function

    Private Function ConvertirArrayByteAImage(ByRef arrayMiniaturaImg As Byte()) As Image

        Dim imagen As Image
        Dim memoryStream As New MemoryStream(arrayMiniaturaImg)

        imagen = Image.FromStream(memoryStream)
        Return imagen

    End Function

    ''' <summary>
    ''' Añade una imagen a la galería de máquinas.
    ''' </summary>
    ''' <param name="imagen">Imagen para añadirla a un PictureBox.</param>
    Private Sub AddImagenAListaImgs(ByRef imagen As Image)

        FotoPictureBox.Image = imagen

    End Sub

    Private Sub AddImagenAListaImgs(ByRef imagen As Bitmap)

        FotoPictureBox.Image = imagen

    End Sub

    Private Async Sub ExaminarButton_Click(sender As Object, e As EventArgs) Handles ExaminarButton.Click
        Dim seleccionarImg As New OpenFileDialog()

        seleccionarImg.Title = "Seleccionar Imagen"
        seleccionarImg.Filter = "jpg|*.jpg|png|*.png"
        seleccionarImg.ShowDialog()

        FormPrincipal.BarraProgresoAPI.Visible = True

        Dim arrayMiniaturaImg As Byte() = Await GetThumbnail(seleccionarImg.FileName)
        Dim nombreImagen As String = Path.GetFileNameWithoutExtension(seleccionarImg.FileName)

        Dim imagen As Image = ConvertirArrayByteAImage(arrayMiniaturaImg)
        Dim ultimoIdUsuario As Integer = 0
        If TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then
            ultimoIdUsuario = NegocioUsuarios.ObtenerUltimoIdUsuarios()
        Else
            If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Or TipoAccion.Equals(Foo.TipoAccion.Modificar.ToString()) Then
                ultimoIdUsuario = IdUsuario
            Else
            End If
        End If


        If Not File.Exists(My.Settings.CarpetaUsuarios & IdUsuario & ".jpg") Then
            File.WriteAllBytes(My.Settings.CarpetaUsuarios & ultimoIdUsuario & ".jpg", arrayMiniaturaImg)
            AddImagenAListaImgs(imagen)
            FormPrincipal.BarraProgresoAPI.Visible = False
        Else
            AddImagenAListaImgs(imagen)
            FormPrincipal.BarraProgresoAPI.Visible = False
        End If
    End Sub

    Private Sub AddTipoUsuario_Click(sender As Object, e As EventArgs) Handles AddTipoUsuario.Click
        Dim addTipoUsuario As New AddNuevoTipoUsuario()
        addTipoUsuario.Text = "Añadir Tipo Usuario"
        addTipoUsuario.MdiParent = FormPrincipal
        addTipoUsuario.Show()
    End Sub

    Private Sub NuevoUsuario_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        CargaValores()
    End Sub

    Private Sub TelefonoTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TelefonoTextBox.Validating
        Dim patronTelefono As String = "^[0-9]{9}$"

        Dim patronTelefonoValido As Boolean = False


        If Regex.IsMatch(TelefonoTextBox.Text, patronTelefono) Then
            patronTelefonoValido = True

        End If

        If Not patronTelefonoValido Then
            ErrorProvider1.SetError(TelefonoTextBox, "Introduce un teléfono válido")
        End If


    End Sub

    Private Sub EmailTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        Dim patronEmail As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"

        Dim patronEmailValido As Boolean = False

        If Regex.IsMatch(EmailTextBox.Text, patronEmail) Then
            patronEmailValido = True
        End If

        If Not patronEmailValido Then
            ErrorProvider1.SetError(EmailTextBox, "Introduce un correo válido")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub
End Class
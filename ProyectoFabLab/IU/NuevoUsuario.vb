﻿Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.ProjectOxford.Vision
Imports System.Drawing
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

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then
            CargaValores()

            Dim valoresUsuario As DataTable = NegocioUsuarios.ObtenerDatosUsuarioPorId(_IdUsuario)

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
            ObservacionesRichTextBox.Enabled = False

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

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        If TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then
            If NegocioUsuarios.InsertarUsuario(NombreTextBox.Text, ApellidosTextBox.Text, CType(FechaNacimientoDTP.Value, String), TelefonoTextBox.Text, EmailTextBox.Text, DireccionTextBox.Text, OrganizacionTextBox.Text, TipoUsuariosCMB.Text, ObservacionesRichTextBox.Text) Then
                MessageBox.Show("Máquina Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If NegocioUsuarios.ModificarDatosUsuarioPorId(_IdUsuario, NombreTextBox.Text, ApellidosTextBox.Text, TelefonoTextBox.Text, EmailTextBox.Text, DireccionTextBox.Text, OrganizacionTextBox.Text, TipoUsuariosCMB.Text, ObservacionesRichTextBox.Text) Then
                MessageBox.Show("Máquina Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
            If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then
                ultimoIdUsuario = IdUsuario
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
End Class
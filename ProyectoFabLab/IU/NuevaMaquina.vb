Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.ProjectOxford.Vision
Imports System.Drawing

Public Class NuevaMaquina

    Private TipoAccion As String
    Private _IdMaquina As Integer

    Public Property IdMaquina As Integer
        Get
            Return _IdMaquina
        End Get
        Set(value As Integer)
            _IdMaquina = value
        End Set
    End Property

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click

        Me.Close()

    End Sub

    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComprobarValorEnum()

    End Sub


    ''' <summary>
    ''' Carga en el ComboBox los diferentes tipos de máquinas.
    ''' </summary>
    Private Sub CargarTiposMaquinas()

        Dim tablaTiposMaquinas As SqlDataReader = NegocioTiposMaquinas.ObtenerTiposMaquinas()

        While tablaTiposMaquinas.Read()

            TipoMaquinaComboBox.Items.Add(tablaTiposMaquinas.GetString(0))

        End While

    End Sub


    ''' <summary>
    ''' Comprueba el valor de la enumeración "TipoAccion" para activar o desactivar controles.
    ''' </summary>
    Private Sub ComprobarValorEnum()

        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then

            ModeloTextBox.Enabled = False
            PrecioPorHoraTextBox.Enabled = False
            FechaCompraDateTimePicker.Enabled = False
            TefSATTextBox.Enabled = False
            TipoMaquinaComboBox.Enabled = False
            AddTipoMaquinaPictureBox.Visible = False
            DescripcionRichTextBox.Enabled = False
            CaracTecnicasRichTextBox.Enabled = False
            AddImgMaquinaButton.Enabled = False
            AceptarButton.Visible = False

            CancelarButton.Text = "Cerrar"

            NegocioMaquinas.ObtenerMaquinasPorId(IdMaquina)

        ElseIf TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then

            CargarTiposMaquinas()

        End If

    End Sub

    Private Sub AddTipoMaquinaPictureBox_Click(sender As Object, e As EventArgs) Handles AddTipoMaquinaPictureBox.Click



    End Sub

    Private Sub ModeloTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ModeloTextBox.Validating

        If ModeloTextBox.Text.Equals("") Then

            ' e.Cancel = True                 ' True -> No permite cambiar de control. False -> Permite cambiar de control.
            ErrorProvider.SetError(DirectCast(sender, Control), "El Modelo está vacío")

        End If

    End Sub

    Private Sub ModeloTextBox_Validated(sender As Object, e As EventArgs) Handles ModeloTextBox.Validated

        ErrorProvider.SetError(DirectCast(sender, Control), "")

    End Sub

    Private Sub PrecioPorHoraTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PrecioPorHoraTextBox.Validating

        If PrecioPorHoraTextBox.Text.Equals("") Then

            e.Cancel = True
            ErrorProvider.SetError(DirectCast(sender, Control), "El precio por hora está vacío")

        ElseIf Integer.Parse(PrecioPorHoraTextBox.Text) < 0 Then

            e.Cancel = True
            ErrorProvider.SetError(DirectCast(sender, Control), "El precio por hora tiene que ser mayor que 0")

        End If

    End Sub

    Private Sub PrecioPorHoraTextBox_Validated(sender As Object, e As EventArgs) Handles PrecioPorHoraTextBox.Validated

        ErrorProvider.SetError(DirectCast(sender, Control), "")

    End Sub

    Private Sub PrecioPorHoraTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioPorHoraTextBox.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True                    ' True -> No muestra la tecla pulsada en el TextBox. False -> Muestra la tecla pulsada en el TextBox.

        End If

    End Sub

    Private Sub TefSATTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TefSATTextBox.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Async Sub AddImgMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddImgMaquinaButton.Click

        Dim seleccionarImg As New OpenFileDialog()

        seleccionarImg.Title = "Seleccionar Imagen"
        seleccionarImg.Filter = "jpg|*.jpg|png|*.png"
        seleccionarImg.ShowDialog()

        Dim arrayMiniaturaImg As Byte() = Await GetThumbnail(seleccionarImg.FileName)
        Dim nombreImagen As String = Path.GetFileName(seleccionarImg.FileName)

        File.WriteAllBytes(My.Settings.CarpetaMaquinas & nombreImagen, arrayMiniaturaImg)
        Dim imagen As Image = ConvertirArrayByteAImage(arrayMiniaturaImg)

        AddImagenAListaImgs(imagen)

    End Sub

    Private Async Function GetThumbnail(ByVal rutaImagen As String) As Task(Of Byte())

        Dim client As New VisionServiceClient(My.Settings.ClaveServicioMiniatura, My.Settings.UrlServicioMiniatura)

        Using stream As Stream = File.OpenRead(rutaImagen)

            Try
                Dim miniatura As Byte() = Await client.GetThumbnailAsync(stream, 400, 400, True)
                Return miniatura

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End Using

    End Function

    Private Function ConvertirArrayByteAImage(ByRef arrayMiniaturaImg As Byte()) As Image

        Dim imagen As Image
        Dim memoryStream As New MemoryStream(arrayMiniaturaImg)

        imagen = Image.FromStream(memoryStream)
        Return imagen

    End Function

    Private Sub AddImagenAListaImgs(ByRef imagen As Image)

        Dim pb As New PictureBox()
        pb.Image = imagen
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        ImgsMaquinasFlowLayoutPanel.Controls.Add(pb)

    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If NegocioMaquinas.InsertarMaquina(ModeloTextBox.Text, Integer.Parse(PrecioPorHoraTextBox.Text), FechaCompraDateTimePicker.Value.Date, TefSATTextBox.Text, TipoMaquinaComboBox.SelectedIndex + 1, DescripcionRichTextBox.Text, CaracTecnicasRichTextBox.Text) Then

            MessageBox.Show("Máquina Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Public Sub New(ByRef tipoAccion As String)

        InitializeComponent()
        Me.TipoAccion = tipoAccion

    End Sub

End Class
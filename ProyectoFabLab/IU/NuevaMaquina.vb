Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.ProjectOxford.Vision

Public Class NuevaMaquina

    Private TipoAccion As String

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click

        Me.Close()

    End Sub

    Private Sub NuevaMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTiposMaquinas()

    End Sub

    Private Sub CargarTiposMaquinas()

        Dim tablaTiposMaquinas As SqlDataReader = NegocioTiposMaquinas.ObtenerTiposMaquinas()

        While tablaTiposMaquinas.Read()

            TipoMaquinaComboBox.Items.Add(tablaTiposMaquinas.GetString(0))

        End While

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

    Private Sub AddImgMaquinaButton_Click(sender As Object, e As EventArgs) Handles AddImgMaquinaButton.Click

        Dim seleccionarImg As New OpenFileDialog()

        seleccionarImg.Title = "Seleccionar Imagen"
        seleccionarImg.Filter = "jpg|*.jpg|png|*.png"
        seleccionarImg.ShowDialog()

        Dim visionClient As New VisionServiceClient(My.Settings.ClaveServicioMiniatura)
        Dim rutaImagen As String = seleccionarImg.FileName

        Dim anchura As Integer = 50
        Dim altura As Integer = 50

        Dim miniatura As Byte() = visionClient.GetThumbnailAsync(rutaImagen, anchura, altura, True).Result

        Using binaryWrite As New BinaryWriter(New FileStream("C:\img\Hola.jpg", FileMode.Create, FileAccess.Write))

            binaryWrite.Write(miniatura)

        End Using

        Process.Start("C:\img\Hola.jpg")
        Process.Start(rutaImagen)

        ' AddImagenAListaImgs(seleccionarImg.FileName)

    End Sub

    'Private Async Sub MakeThumbnailRequest(ByVal rutaImagen As String)

    '    Dim client As New HttpClient()

    '    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", My.Settings.ClaveServicioMiniatura)

    '    Dim requestParameters As String = "width=50&height=50&smartCropping=true"
    '    Dim uri As String = My.Settings.UrlServicioMiniatura & "?" & requestParameters

    '    Dim response As HttpResponseMessage
    '    Dim byteData As Byte() = GetImageAsByteArray(rutaImagen)

    '    Using content As New ByteArrayContent(byteData)

    '        content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/octet-stream")

    '        response = Await client.PostAsync(uri, content)

    '        If response.IsSuccessStatusCode Then

    '            Dim miniaturaImagen As Byte() = Await response.Content.ReadAsByteArrayAsync()

    '        End If

    '    End Using

    'End Sub

    'Private Function GetImageAsByteArray(ByRef rutaImagen As String) As Byte()

    '    Dim fileStream As New FileStream(rutaImagen, FileMode.Open, FileAccess.Read)
    '    Dim binaryReader As New BinaryReader(fileStream)

    '    Return binaryReader.ReadBytes(CType(fileStream.Length, Integer))

    'End Function

    Private Sub AddImagenAListaImgs(ByRef nombreArchivo As String)

        Dim pb As New PictureBox()
        pb.Image = Image.FromFile(nombreArchivo)
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
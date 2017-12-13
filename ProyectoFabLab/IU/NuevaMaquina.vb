Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.ProjectOxford.Vision
Imports System.Drawing

Public Class NuevaMaquina

    Private TipoAccion As String
    Private _IdMaquina As Integer
    Private FormPrincipal As Form1

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

        Dim tablaTiposMaquinas As DataTable = NegocioTiposMaquinas.ObtenerTiposMaquinas()

        For i As Integer = 0 To tablaTiposMaquinas.Rows.Count - 1           ' Recorremos las filas del DataTable.

            TipoMaquinaComboBox.Items.Add(tablaTiposMaquinas.Rows.Item(i).Item(0).ToString())

        Next

    End Sub


    ''' <summary>
    ''' Comprueba el valor de la enumeración "TipoAccion" para activar o desactivar controles.
    ''' </summary>
    Private Sub ComprobarValorEnum()

        If TipoAccion.Equals(Foo.TipoAccion.Consultar.ToString()) Then          ' Se van a consultar los datos de una máquina.

            Dim tablaDatosMaquina As DataTable = NegocioMaquinas.ObtenerMaquinasPorId(IdMaquina)

            ModeloTextBox.Enabled = False
            ModeloTextBox.Text = tablaDatosMaquina.Rows(0).Item(1).ToString()

            PrecioPorHoraTextBox.Enabled = False
            PrecioPorHoraTextBox.Text = tablaDatosMaquina.Rows(0).Item(2).ToString()

            FechaCompraDateTimePicker.Enabled = False
            FechaCompraDateTimePicker.Value = Date.Parse(tablaDatosMaquina.Rows(0).Item(3).ToString())

            TefSATTextBox.Enabled = False
            TefSATTextBox.Text = tablaDatosMaquina.Rows(0).Item(4).ToString()

            TipoMaquinaComboBox.Enabled = False
            TipoMaquinaComboBox.Text = tablaDatosMaquina.Rows(0).Item(5).ToString()

            AddTipoMaquinaPictureBox.Visible = False
            DescripcionRichTextBox.Enabled = False
            DescripcionRichTextBox.Text = tablaDatosMaquina.Rows(0).Item(6).ToString()

            CaracTecnicasRichTextBox.Enabled = False
            CaracTecnicasRichTextBox.Text = tablaDatosMaquina.Rows(0).Item(7).ToString()

            AddImgMaquinaButton.Enabled = False
            AceptarButton.Visible = False

            CancelarButton.Text = "Cerrar"

        ElseIf TipoAccion.Equals(Foo.TipoAccion.Insertar.ToString()) Then       ' Se va a añadir una nueva máquina.

            CargarTiposMaquinas()

        Else                ' Se va a modificar los datos de una máquina.

            Dim tablaDatos As DataTable = NegocioMaquinas.ObtenerMaquinasPorId(IdMaquina)

            ModeloTextBox.Text = tablaDatos.Rows(0).Item(1).ToString()
            PrecioPorHoraTextBox.Text = tablaDatos.Rows(0).Item(2).ToString()
            FechaCompraDateTimePicker.Value = Date.Parse(tablaDatos.Rows(0).Item(3).ToString())
            TefSATTextBox.Text = tablaDatos.Rows(0).Item(4).ToString()
            TipoMaquinaComboBox.Text = tablaDatos.Rows(0).Item(5).ToString()
            DescripcionRichTextBox.Text = tablaDatos.Rows(0).Item(6).ToString()
            CaracTecnicasRichTextBox.Text = tablaDatos.Rows(0).Item(7).ToString()

            CargarImgsMaquinaSeleccionada()

        End If

    End Sub

    Private Sub CargarImgsMaquinaSeleccionada()

        Dim arrayImgs As String() = Directory.GetFiles(My.Settings.CarpetaMaquinas, IdMaquina & "*")        ' Obtenemos todas las miniaturas de la máquina seleccionada.

        For Each minImg As String In arrayImgs

            Dim bitmap As New Bitmap(My.Settings.CarpetaMaquinas & minImg)

            AddImagenAListaImgs(bitmap)

        Next

    End Sub

    Private Sub AddTipoMaquinaPictureBox_Click(sender As Object, e As EventArgs) Handles AddTipoMaquinaPictureBox.Click

        Dim formAddNuevoTipoMaquina As New AddNuevoTipoMaquina()
        formAddNuevoTipoMaquina.Text = "Añadir Tipo Máquina"
        formAddNuevoTipoMaquina.MdiParent = FormPrincipal
        formAddNuevoTipoMaquina.Show()

    End Sub

    Private Sub ModeloTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ModeloTextBox.Validating

        If ModeloTextBox.Text.Equals("") Then

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

        FormPrincipal.BarraProgresoAPI.Visible = True

        Dim arrayMiniaturaImg As Byte() = Await GetThumbnail(seleccionarImg.FileName)
        Dim nombreImagen As String = Path.GetFileNameWithoutExtension(seleccionarImg.FileName)

        Dim imagen As Image = ConvertirArrayByteAImage(arrayMiniaturaImg)           ' Convierte la imagen seleccionada a Image para añadirla a la galería de imágenes.

        Dim ultimoIdMaquina As Integer = NegocioMaquinas.ObtenerUltimoIdMaquina()
        ultimoIdMaquina += 1

        If Not File.Exists(My.Settings.CarpetaMaquinas & ultimoIdMaquina & "_1.jpg") Then           ' Si no existe la primera imagen de la máquina.

            File.WriteAllBytes(My.Settings.CarpetaMaquinas & ultimoIdMaquina & "_1.jpg", arrayMiniaturaImg)            ' Creamos la primera miniatura.
            AddImagenAListaImgs(imagen)

            FormPrincipal.BarraProgresoAPI.Visible = False

        Else

            Dim arrayArchivos As String() = Directory.GetFiles(My.Settings.CarpetaMaquinas, ultimoIdMaquina & "*")

            If arrayArchivos.Length = 1 Then            ' Si hay una sóla miniatura.

                File.WriteAllBytes(My.Settings.CarpetaMaquinas & ultimoIdMaquina & "_2.jpg", arrayMiniaturaImg)            ' Creamos la segunda miniatura.
                AddImagenAListaImgs(imagen)

                FormPrincipal.BarraProgresoAPI.Visible = False

            Else

                Dim listaMinImgs As New List(Of String)
                Dim subIdMayor As Integer
                Dim primerSubId As Integer

                For Each archivo As String In arrayArchivos

                    listaMinImgs.Add(archivo)

                Next

                primerSubId = Integer.Parse(listaMinImgs(0).Substring(listaMinImgs(0).Length - 5, 1))

                For Each minImg As String In listaMinImgs           ' Recorremos la lista de miniaturas para saber cuál es el mayor subId de todas las miniaturas.

                    If Integer.Parse(minImg.Substring(minImg.Length - 5, 1)) > primerSubId Then

                        subIdMayor = Integer.Parse(minImg.Substring(minImg.Length - 5, 1))

                    End If

                Next
                subIdMayor += 1

                File.WriteAllBytes(My.Settings.CarpetaMaquinas & ultimoIdMaquina & "_"c & subIdMayor & ".jpg", arrayMiniaturaImg)       ' Creamos las demás miniaturas.
                AddImagenAListaImgs(imagen)

                FormPrincipal.BarraProgresoAPI.Visible = False

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

        Dim pb As New PictureBox()
        pb.Size = New Size(142, 122)

        pb.Image = imagen
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        ImgsMaquinasFlowLayoutPanel.Controls.Add(pb)

    End Sub

    Private Sub AddImagenAListaImgs(ByRef imagen As Bitmap)

        Dim pb As New PictureBox()
        pb.Size = New Size(142, 122)

        pb.Image = DirectCast(imagen, Image)
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        ImgsMaquinasFlowLayoutPanel.Controls.Add(pb)

    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If NegocioMaquinas.InsertarMaquina(ModeloTextBox.Text, Integer.Parse(PrecioPorHoraTextBox.Text), FechaCompraDateTimePicker.Value.Date, TefSATTextBox.Text, TipoMaquinaComboBox.SelectedIndex + 1, DescripcionRichTextBox.Text, CaracTecnicasRichTextBox.Text) Then

            MessageBox.Show("Máquina Guardada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Public Sub New(ByRef tipoAccion As String, ByRef formPrincipal As Form1)

        InitializeComponent()
        Me.TipoAccion = tipoAccion
        Me.FormPrincipal = formPrincipal

    End Sub

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaMaquina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ModeloLabel = New System.Windows.Forms.Label()
        Me.TelefSATLabel = New System.Windows.Forms.Label()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.TefSATTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioPorHoraTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipoMaquinaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescripcionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CaracTecnicasRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AddImgMaquinaButton = New System.Windows.Forms.Button()
        Me.ImgsMaquinasFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.AddTipoMaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.AddTipoMaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModeloLabel
        '
        Me.ModeloLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeloLabel.AutoSize = True
        Me.ModeloLabel.Location = New System.Drawing.Point(12, 43)
        Me.ModeloLabel.Name = "ModeloLabel"
        Me.ModeloLabel.Size = New System.Drawing.Size(42, 13)
        Me.ModeloLabel.TabIndex = 0
        Me.ModeloLabel.Text = "Modelo"
        '
        'TelefSATLabel
        '
        Me.TelefSATLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefSATLabel.AutoSize = True
        Me.TelefSATLabel.Location = New System.Drawing.Point(12, 94)
        Me.TelefSATLabel.Name = "TelefSATLabel"
        Me.TelefSATLabel.Size = New System.Drawing.Size(73, 13)
        Me.TelefSATLabel.TabIndex = 1
        Me.TelefSATLabel.Text = "Teléfono SAT"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeloTextBox.Location = New System.Drawing.Point(68, 40)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 1
        '
        'TefSATTextBox
        '
        Me.TefSATTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TefSATTextBox.Location = New System.Drawing.Point(91, 91)
        Me.TefSATTextBox.Name = "TefSATTextBox"
        Me.TefSATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TefSATTextBox.TabIndex = 4
        '
        'PrecioPorHoraTextBox
        '
        Me.PrecioPorHoraTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrecioPorHoraTextBox.Location = New System.Drawing.Point(352, 40)
        Me.PrecioPorHoraTextBox.Name = "PrecioPorHoraTextBox"
        Me.PrecioPorHoraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioPorHoraTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Precio/hora"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(582, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de Compra"
        '
        'FechaCompraDateTimePicker
        '
        Me.FechaCompraDateTimePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FechaCompraDateTimePicker.Location = New System.Drawing.Point(679, 40)
        Me.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker"
        Me.FechaCompraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaCompraDateTimePicker.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo"
        '
        'TipoMaquinaComboBox
        '
        Me.TipoMaquinaComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TipoMaquinaComboBox.FormattingEnabled = True
        Me.TipoMaquinaComboBox.Location = New System.Drawing.Point(352, 90)
        Me.TipoMaquinaComboBox.Name = "TipoMaquinaComboBox"
        Me.TipoMaquinaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TipoMaquinaComboBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripción"
        '
        'DescripcionRichTextBox
        '
        Me.DescripcionRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionRichTextBox.Location = New System.Drawing.Point(15, 200)
        Me.DescripcionRichTextBox.Name = "DescripcionRichTextBox"
        Me.DescripcionRichTextBox.Size = New System.Drawing.Size(373, 96)
        Me.DescripcionRichTextBox.TabIndex = 6
        Me.DescripcionRichTextBox.Text = ""
        '
        'CaracTecnicasRichTextBox
        '
        Me.CaracTecnicasRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CaracTecnicasRichTextBox.Location = New System.Drawing.Point(494, 200)
        Me.CaracTecnicasRichTextBox.Name = "CaracTecnicasRichTextBox"
        Me.CaracTecnicasRichTextBox.Size = New System.Drawing.Size(385, 96)
        Me.CaracTecnicasRichTextBox.TabIndex = 7
        Me.CaracTecnicasRichTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(491, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Características Técnicas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Imágenes"
        '
        'AddImgMaquinaButton
        '
        Me.AddImgMaquinaButton.Location = New System.Drawing.Point(71, 341)
        Me.AddImgMaquinaButton.Name = "AddImgMaquinaButton"
        Me.AddImgMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.AddImgMaquinaButton.TabIndex = 8
        Me.AddImgMaquinaButton.Text = "Examinar"
        Me.AddImgMaquinaButton.UseVisualStyleBackColor = True
        '
        'ImgsMaquinasFlowLayoutPanel
        '
        Me.ImgsMaquinasFlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImgsMaquinasFlowLayoutPanel.AutoScroll = True
        Me.ImgsMaquinasFlowLayoutPanel.Location = New System.Drawing.Point(15, 383)
        Me.ImgsMaquinasFlowLayoutPanel.Name = "ImgsMaquinasFlowLayoutPanel"
        Me.ImgsMaquinasFlowLayoutPanel.Size = New System.Drawing.Size(864, 125)
        Me.ImgsMaquinasFlowLayoutPanel.TabIndex = 16
        '
        'AceptarButton
        '
        Me.AceptarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptarButton.Location = New System.Drawing.Point(697, 530)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 9
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.Location = New System.Drawing.Point(804, 530)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 10
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'AddTipoMaquinaPictureBox
        '
        Me.AddTipoMaquinaPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTipoMaquinaPictureBox.Image = Global.ProyectoFabLab.My.Resources.Resources.AddTipoMaquina
        Me.AddTipoMaquinaPictureBox.Location = New System.Drawing.Point(476, 86)
        Me.AddTipoMaquinaPictureBox.Name = "AddTipoMaquinaPictureBox"
        Me.AddTipoMaquinaPictureBox.Size = New System.Drawing.Size(36, 30)
        Me.AddTipoMaquinaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AddTipoMaquinaPictureBox.TabIndex = 17
        Me.AddTipoMaquinaPictureBox.TabStop = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'NuevaMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 565)
        Me.Controls.Add(Me.AddTipoMaquinaPictureBox)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.ImgsMaquinasFlowLayoutPanel)
        Me.Controls.Add(Me.AddImgMaquinaButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CaracTecnicasRichTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DescripcionRichTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TipoMaquinaComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaCompraDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrecioPorHoraTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TefSATTextBox)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.TelefSATLabel)
        Me.Controls.Add(Me.ModeloLabel)
        Me.Name = "NuevaMaquina"
        Me.Text = "FabLab - Nueva Máquina"
        CType(Me.AddTipoMaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModeloLabel As Label
    Friend WithEvents TelefSATLabel As Label
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents TefSATTextBox As TextBox
    Friend WithEvents PrecioPorHoraTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaCompraDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TipoMaquinaComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DescripcionRichTextBox As RichTextBox
    Friend WithEvents CaracTecnicasRichTextBox As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddImgMaquinaButton As Button
    Friend WithEvents ImgsMaquinasFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents AddTipoMaquinaPictureBox As PictureBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoUsuario))
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.OrganizacionLabel = New System.Windows.Forms.Label()
        Me.ApellidosLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.FechaNacimientoLabel = New System.Windows.Forms.Label()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.FotoLabel = New System.Windows.Forms.Label()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExaminarButton = New System.Windows.Forms.Button()
        Me.ObservacionesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ObservacionesLabel = New System.Windows.Forms.Label()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizacionTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TipoUsuariosCMB = New System.Windows.Forms.ComboBox()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(48, 55)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 0
        Me.NombreLabel.Text = "Nombre"
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(48, 124)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(49, 13)
        Me.TelefonoLabel.TabIndex = 1
        Me.TelefonoLabel.Text = "Teléfono"
        '
        'OrganizacionLabel
        '
        Me.OrganizacionLabel.AutoSize = True
        Me.OrganizacionLabel.Location = New System.Drawing.Point(53, 197)
        Me.OrganizacionLabel.Name = "OrganizacionLabel"
        Me.OrganizacionLabel.Size = New System.Drawing.Size(69, 13)
        Me.OrganizacionLabel.TabIndex = 2
        Me.OrganizacionLabel.Text = "Organización"
        '
        'ApellidosLabel
        '
        Me.ApellidosLabel.AutoSize = True
        Me.ApellidosLabel.Location = New System.Drawing.Point(349, 55)
        Me.ApellidosLabel.Name = "ApellidosLabel"
        Me.ApellidosLabel.Size = New System.Drawing.Size(49, 13)
        Me.ApellidosLabel.TabIndex = 3
        Me.ApellidosLabel.Text = "Apellidos"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(349, 124)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 4
        Me.EmailLabel.Text = "E-mail"
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(349, 197)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 5
        Me.TipoLabel.Text = "Tipo"
        '
        'FechaNacimientoLabel
        '
        Me.FechaNacimientoLabel.AutoSize = True
        Me.FechaNacimientoLabel.Location = New System.Drawing.Point(602, 55)
        Me.FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        Me.FechaNacimientoLabel.Size = New System.Drawing.Size(106, 13)
        Me.FechaNacimientoLabel.TabIndex = 6
        Me.FechaNacimientoLabel.Text = "Fecha de nacimiento"
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(602, 124)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(83, 13)
        Me.DireccionLabel.TabIndex = 7
        Me.DireccionLabel.Text = "Dirección postal"
        '
        'FotoLabel
        '
        Me.FotoLabel.AutoSize = True
        Me.FotoLabel.Location = New System.Drawing.Point(56, 262)
        Me.FotoLabel.Name = "FotoLabel"
        Me.FotoLabel.Size = New System.Drawing.Size(28, 13)
        Me.FotoLabel.TabIndex = 8
        Me.FotoLabel.Text = "Foto"
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.Location = New System.Drawing.Point(56, 286)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(328, 245)
        Me.FotoPictureBox.TabIndex = 9
        Me.FotoPictureBox.TabStop = False
        '
        'ExaminarButton
        '
        Me.ExaminarButton.Location = New System.Drawing.Point(110, 257)
        Me.ExaminarButton.Name = "ExaminarButton"
        Me.ExaminarButton.Size = New System.Drawing.Size(75, 23)
        Me.ExaminarButton.TabIndex = 10
        Me.ExaminarButton.Text = "Examinar"
        Me.ExaminarButton.UseVisualStyleBackColor = True
        '
        'ObservacionesRichTextBox
        '
        Me.ObservacionesRichTextBox.Location = New System.Drawing.Point(573, 286)
        Me.ObservacionesRichTextBox.Name = "ObservacionesRichTextBox"
        Me.ObservacionesRichTextBox.Size = New System.Drawing.Size(335, 245)
        Me.ObservacionesRichTextBox.TabIndex = 11
        Me.ObservacionesRichTextBox.Text = ""
        '
        'ObservacionesLabel
        '
        Me.ObservacionesLabel.AutoSize = True
        Me.ObservacionesLabel.Location = New System.Drawing.Point(570, 270)
        Me.ObservacionesLabel.Name = "ObservacionesLabel"
        Me.ObservacionesLabel.Size = New System.Drawing.Size(78, 13)
        Me.ObservacionesLabel.TabIndex = 12
        Me.ObservacionesLabel.Text = "Observaciones"
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(711, 551)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 13
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(806, 551)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 14
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(145, 52)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(159, 20)
        Me.NombreTextBox.TabIndex = 15
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Location = New System.Drawing.Point(145, 121)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(159, 20)
        Me.TelefonoTextBox.TabIndex = 16
        '
        'OrganizacionTextBox
        '
        Me.OrganizacionTextBox.Location = New System.Drawing.Point(145, 194)
        Me.OrganizacionTextBox.Name = "OrganizacionTextBox"
        Me.OrganizacionTextBox.Size = New System.Drawing.Size(159, 20)
        Me.OrganizacionTextBox.TabIndex = 17
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Location = New System.Drawing.Point(418, 52)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(159, 20)
        Me.ApellidosTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(418, 121)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(159, 20)
        Me.EmailTextBox.TabIndex = 19
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(767, 117)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(159, 20)
        Me.DireccionTextBox.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(767, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 21
        '
        'TipoUsuariosCMB
        '
        Me.TipoUsuariosCMB.FormattingEnabled = True
        Me.TipoUsuariosCMB.Location = New System.Drawing.Point(418, 194)
        Me.TipoUsuariosCMB.Name = "TipoUsuariosCMB"
        Me.TipoUsuariosCMB.Size = New System.Drawing.Size(159, 21)
        Me.TipoUsuariosCMB.TabIndex = 22
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 598)
        Me.Controls.Add(Me.TipoUsuariosCMB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(Me.OrganizacionTextBox)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesRichTextBox)
        Me.Controls.Add(Me.ExaminarButton)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.FotoLabel)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.FechaNacimientoLabel)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.ApellidosLabel)
        Me.Controls.Add(Me.OrganizacionLabel)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoUsuario"
        Me.Text = "NuevoUsuario"
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents OrganizacionLabel As Label
    Friend WithEvents ApellidosLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents TipoLabel As Label
    Friend WithEvents FechaNacimientoLabel As Label
    Friend WithEvents DireccionLabel As Label
    Friend WithEvents FotoLabel As Label
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents ExaminarButton As Button
    Friend WithEvents ObservacionesRichTextBox As RichTextBox
    Friend WithEvents ObservacionesLabel As Label
    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents OrganizacionTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TipoUsuariosCMB As ComboBox
End Class

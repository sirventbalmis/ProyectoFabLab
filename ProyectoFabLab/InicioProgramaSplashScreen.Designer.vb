<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioProgramaSplashScreen
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PortadaPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Descripcion1ProgramaLabel = New System.Windows.Forms.Label()
        Me.Descripcion2ProgramaLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RealizacionProgramaLabel = New System.Windows.Forms.Label()
        Me.ProgramadoresLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.PortadaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.09322!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.90678!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Controls.Add(Me.PortadaPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 2
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(472, 279)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'PortadaPictureBox
        '
        Me.PortadaPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PortadaPictureBox.Image = Global.ProyectoFabLab.My.Resources.Resources.Fab_Lab_logo_png
        Me.PortadaPictureBox.InitialImage = Nothing
        Me.PortadaPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.PortadaPictureBox.Name = "PortadaPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.PortadaPictureBox, 2)
        Me.PortadaPictureBox.Size = New System.Drawing.Size(220, 273)
        Me.PortadaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PortadaPictureBox.TabIndex = 0
        Me.PortadaPictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Descripcion2ProgramaLabel)
        Me.Panel1.Controls.Add(Me.Descripcion1ProgramaLabel)
        Me.Panel1.Location = New System.Drawing.Point(229, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 138)
        Me.Panel1.TabIndex = 1
        '
        'Descripcion1ProgramaLabel
        '
        Me.Descripcion1ProgramaLabel.AutoSize = True
        Me.Descripcion1ProgramaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion1ProgramaLabel.Location = New System.Drawing.Point(18, 47)
        Me.Descripcion1ProgramaLabel.Name = "Descripcion1ProgramaLabel"
        Me.Descripcion1ProgramaLabel.Size = New System.Drawing.Size(208, 15)
        Me.Descripcion1ProgramaLabel.TabIndex = 0
        Me.Descripcion1ProgramaLabel.Text = "Programa que gestiona los usuarios,"
        '
        'Descripcion2ProgramaLabel
        '
        Me.Descripcion2ProgramaLabel.AutoSize = True
        Me.Descripcion2ProgramaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion2ProgramaLabel.Location = New System.Drawing.Point(18, 88)
        Me.Descripcion2ProgramaLabel.Name = "Descripcion2ProgramaLabel"
        Me.Descripcion2ProgramaLabel.Size = New System.Drawing.Size(201, 15)
        Me.Descripcion2ProgramaLabel.TabIndex = 1
        Me.Descripcion2ProgramaLabel.Text = "máquinas y reservas de un FabLab."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProgramadoresLabel)
        Me.Panel2.Controls.Add(Me.RealizacionProgramaLabel)
        Me.Panel2.Location = New System.Drawing.Point(229, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 129)
        Me.Panel2.TabIndex = 2
        '
        'RealizacionProgramaLabel
        '
        Me.RealizacionProgramaLabel.AutoSize = True
        Me.RealizacionProgramaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealizacionProgramaLabel.Location = New System.Drawing.Point(71, 39)
        Me.RealizacionProgramaLabel.Name = "RealizacionProgramaLabel"
        Me.RealizacionProgramaLabel.Size = New System.Drawing.Size(101, 15)
        Me.RealizacionProgramaLabel.TabIndex = 0
        Me.RealizacionProgramaLabel.Text = "Realizado por:"
        '
        'ProgramadoresLabel
        '
        Me.ProgramadoresLabel.AutoSize = True
        Me.ProgramadoresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramadoresLabel.Location = New System.Drawing.Point(34, 74)
        Me.ProgramadoresLabel.Name = "ProgramadoresLabel"
        Me.ProgramadoresLabel.Size = New System.Drawing.Size(173, 15)
        Me.ProgramadoresLabel.TabIndex = 1
        Me.ProgramadoresLabel.Text = "Pablo Sirvent y Alejandro Pons"
        '
        'InicioProgramaSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InicioProgramaSplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel.ResumeLayout(False)
        CType(Me.PortadaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents PortadaPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Descripcion1ProgramaLabel As Label
    Friend WithEvents Descripcion2ProgramaLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RealizacionProgramaLabel As Label
    Friend WithEvents ProgramadoresLabel As Label
End Class

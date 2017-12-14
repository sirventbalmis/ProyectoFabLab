<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNuevoTipoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNuevoTipoUsuario))
        Me.AddTipoUsuarioBTN = New System.Windows.Forms.Button()
        Me.NuevoTipoUsuarioTXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddTipoUsuarioBTN
        '
        Me.AddTipoUsuarioBTN.Location = New System.Drawing.Point(111, 156)
        Me.AddTipoUsuarioBTN.Name = "AddTipoUsuarioBTN"
        Me.AddTipoUsuarioBTN.Size = New System.Drawing.Size(75, 23)
        Me.AddTipoUsuarioBTN.TabIndex = 5
        Me.AddTipoUsuarioBTN.Text = "Añadir"
        Me.AddTipoUsuarioBTN.UseVisualStyleBackColor = True
        '
        'NuevoTipoUsuarioTXT
        '
        Me.NuevoTipoUsuarioTXT.Location = New System.Drawing.Point(82, 111)
        Me.NuevoTipoUsuarioTXT.Name = "NuevoTipoUsuarioTXT"
        Me.NuevoTipoUsuarioTXT.Size = New System.Drawing.Size(124, 20)
        Me.NuevoTipoUsuarioTXT.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nuevo tipo usuario"
        '
        'AddNuevoTipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.AddTipoUsuarioBTN)
        Me.Controls.Add(Me.NuevoTipoUsuarioTXT)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddNuevoTipoUsuario"
        Me.Text = "AddNuevoTipoUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddTipoUsuarioBTN As Button
    Friend WithEvents NuevoTipoUsuarioTXT As TextBox
    Friend WithEvents Label1 As Label
End Class

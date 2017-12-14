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
        Me.AddTipoMaquinaButton = New System.Windows.Forms.Button()
        Me.NuevoTipoMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddTipoMaquinaButton
        '
        Me.AddTipoMaquinaButton.Location = New System.Drawing.Point(111, 156)
        Me.AddTipoMaquinaButton.Name = "AddTipoMaquinaButton"
        Me.AddTipoMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.AddTipoMaquinaButton.TabIndex = 5
        Me.AddTipoMaquinaButton.Text = "Añadir"
        Me.AddTipoMaquinaButton.UseVisualStyleBackColor = True
        '
        'NuevoTipoMaquinaTextBox
        '
        Me.NuevoTipoMaquinaTextBox.Location = New System.Drawing.Point(82, 111)
        Me.NuevoTipoMaquinaTextBox.Name = "NuevoTipoMaquinaTextBox"
        Me.NuevoTipoMaquinaTextBox.Size = New System.Drawing.Size(124, 20)
        Me.NuevoTipoMaquinaTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Usuario:"
        '
        'AddNuevoTipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.AddTipoMaquinaButton)
        Me.Controls.Add(Me.NuevoTipoMaquinaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddNuevoTipoUsuario"
        Me.Text = "Add tipo usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddTipoMaquinaButton As Button
    Friend WithEvents NuevoTipoMaquinaTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class

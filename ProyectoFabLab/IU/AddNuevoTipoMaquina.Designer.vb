﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNuevoTipoMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNuevoTipoMaquina))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuevoTipoMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.AddTipoMaquinaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Tipo Máquina"
        '
        'NuevoTipoMaquinaTextBox
        '
        Me.NuevoTipoMaquinaTextBox.Location = New System.Drawing.Point(67, 66)
        Me.NuevoTipoMaquinaTextBox.Name = "NuevoTipoMaquinaTextBox"
        Me.NuevoTipoMaquinaTextBox.Size = New System.Drawing.Size(124, 20)
        Me.NuevoTipoMaquinaTextBox.TabIndex = 1
        '
        'AddTipoMaquinaButton
        '
        Me.AddTipoMaquinaButton.Location = New System.Drawing.Point(96, 111)
        Me.AddTipoMaquinaButton.Name = "AddTipoMaquinaButton"
        Me.AddTipoMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.AddTipoMaquinaButton.TabIndex = 2
        Me.AddTipoMaquinaButton.Text = "Añadir"
        Me.AddTipoMaquinaButton.UseVisualStyleBackColor = True
        '
        'AddNuevoTipoMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 156)
        Me.Controls.Add(Me.AddTipoMaquinaButton)
        Me.Controls.Add(Me.NuevoTipoMaquinaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddNuevoTipoMaquina"
        Me.Text = "AddNuevoTipoMaquina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoTipoMaquinaTextBox As TextBox
    Friend WithEvents AddTipoMaquinaButton As Button
End Class

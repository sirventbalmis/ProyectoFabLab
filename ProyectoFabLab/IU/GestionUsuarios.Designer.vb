<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionUsuarios))
        Me.BuscarTxtBox = New System.Windows.Forms.TextBox()
        Me.NuevoUsuarioButton = New System.Windows.Forms.Button()
        Me.UsuariosDGV = New System.Windows.Forms.DataGridView()
        Me.ConsultaButton = New System.Windows.Forms.Button()
        Me.EditarButton = New System.Windows.Forms.Button()
        Me.EliminarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VerReservasButton = New System.Windows.Forms.Button()
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarTxtBox
        '
        Me.BuscarTxtBox.Location = New System.Drawing.Point(179, 53)
        Me.BuscarTxtBox.Name = "BuscarTxtBox"
        Me.BuscarTxtBox.Size = New System.Drawing.Size(200, 20)
        Me.BuscarTxtBox.TabIndex = 0
        '
        'NuevoUsuarioButton
        '
        Me.NuevoUsuarioButton.Location = New System.Drawing.Point(875, 53)
        Me.NuevoUsuarioButton.Name = "NuevoUsuarioButton"
        Me.NuevoUsuarioButton.Size = New System.Drawing.Size(155, 23)
        Me.NuevoUsuarioButton.TabIndex = 1
        Me.NuevoUsuarioButton.Text = "Nuevo Usuario"
        Me.NuevoUsuarioButton.UseVisualStyleBackColor = True
        '
        'UsuariosDGV
        '
        Me.UsuariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDGV.Location = New System.Drawing.Point(98, 124)
        Me.UsuariosDGV.Name = "UsuariosDGV"
        Me.UsuariosDGV.Size = New System.Drawing.Size(932, 374)
        Me.UsuariosDGV.TabIndex = 2
        '
        'ConsultaButton
        '
        Me.ConsultaButton.Location = New System.Drawing.Point(700, 513)
        Me.ConsultaButton.Name = "ConsultaButton"
        Me.ConsultaButton.Size = New System.Drawing.Size(75, 23)
        Me.ConsultaButton.TabIndex = 3
        Me.ConsultaButton.Text = "Consultar"
        Me.ConsultaButton.UseVisualStyleBackColor = True
        '
        'EditarButton
        '
        Me.EditarButton.Location = New System.Drawing.Point(808, 513)
        Me.EditarButton.Name = "EditarButton"
        Me.EditarButton.Size = New System.Drawing.Size(75, 23)
        Me.EditarButton.TabIndex = 4
        Me.EditarButton.Text = "Editar"
        Me.EditarButton.UseVisualStyleBackColor = True
        '
        'EliminarButton
        '
        Me.EliminarButton.Location = New System.Drawing.Point(911, 513)
        Me.EliminarButton.Name = "EliminarButton"
        Me.EliminarButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarButton.TabIndex = 5
        Me.EliminarButton.Text = "Eliminar"
        Me.EliminarButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buscar Usuario"
        '
        'VerReservasButton
        '
        Me.VerReservasButton.Location = New System.Drawing.Point(98, 513)
        Me.VerReservasButton.Name = "VerReservasButton"
        Me.VerReservasButton.Size = New System.Drawing.Size(87, 23)
        Me.VerReservasButton.TabIndex = 7
        Me.VerReservasButton.Text = "Ver Reservas"
        Me.VerReservasButton.UseVisualStyleBackColor = True
        '
        'GestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 619)
        Me.Controls.Add(Me.VerReservasButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EliminarButton)
        Me.Controls.Add(Me.EditarButton)
        Me.Controls.Add(Me.ConsultaButton)
        Me.Controls.Add(Me.UsuariosDGV)
        Me.Controls.Add(Me.NuevoUsuarioButton)
        Me.Controls.Add(Me.BuscarTxtBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionUsuarios"
        Me.Text = "GestionUsuarios"
        CType(Me.UsuariosDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscarTxtBox As TextBox
    Friend WithEvents NuevoUsuarioButton As Button
    Friend WithEvents UsuariosDGV As DataGridView
    Friend WithEvents ConsultaButton As Button
    Friend WithEvents EditarButton As Button
    Friend WithEvents EliminarButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents VerReservasButton As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionMaquinas
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
        Me.BuscarPorNombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddMaquinaButton = New System.Windows.Forms.Button()
        Me.DatosMaquinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.ConsultarMaqButton = New System.Windows.Forms.Button()
        Me.EditarMaqButton = New System.Windows.Forms.Button()
        Me.EliminarMaqButton = New System.Windows.Forms.Button()
        Me.PruebaLabel = New System.Windows.Forms.Label()
        CType(Me.DatosMaquinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarPorNombreTextBox
        '
        Me.BuscarPorNombreTextBox.Location = New System.Drawing.Point(130, 48)
        Me.BuscarPorNombreTextBox.Name = "BuscarPorNombreTextBox"
        Me.BuscarPorNombreTextBox.Size = New System.Drawing.Size(127, 20)
        Me.BuscarPorNombreTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar Por Modelo"
        '
        'AddMaquinaButton
        '
        Me.AddMaquinaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddMaquinaButton.Location = New System.Drawing.Point(806, 51)
        Me.AddMaquinaButton.Name = "AddMaquinaButton"
        Me.AddMaquinaButton.Size = New System.Drawing.Size(96, 23)
        Me.AddMaquinaButton.TabIndex = 2
        Me.AddMaquinaButton.Text = "Nueva Máquina"
        Me.AddMaquinaButton.UseVisualStyleBackColor = True
        '
        'DatosMaquinasDataGridView
        '
        Me.DatosMaquinasDataGridView.AllowUserToAddRows = False
        Me.DatosMaquinasDataGridView.AllowUserToDeleteRows = False
        Me.DatosMaquinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosMaquinasDataGridView.Location = New System.Drawing.Point(30, 115)
        Me.DatosMaquinasDataGridView.Name = "DatosMaquinasDataGridView"
        Me.DatosMaquinasDataGridView.ReadOnly = True
        Me.DatosMaquinasDataGridView.Size = New System.Drawing.Size(872, 327)
        Me.DatosMaquinasDataGridView.TabIndex = 3
        '
        'ConsultarMaqButton
        '
        Me.ConsultarMaqButton.Location = New System.Drawing.Point(628, 500)
        Me.ConsultarMaqButton.Name = "ConsultarMaqButton"
        Me.ConsultarMaqButton.Size = New System.Drawing.Size(75, 23)
        Me.ConsultarMaqButton.TabIndex = 4
        Me.ConsultarMaqButton.Text = "Consultar"
        Me.ConsultarMaqButton.UseVisualStyleBackColor = True
        '
        'EditarMaqButton
        '
        Me.EditarMaqButton.Location = New System.Drawing.Point(727, 500)
        Me.EditarMaqButton.Name = "EditarMaqButton"
        Me.EditarMaqButton.Size = New System.Drawing.Size(75, 23)
        Me.EditarMaqButton.TabIndex = 5
        Me.EditarMaqButton.Text = "Editar"
        Me.EditarMaqButton.UseVisualStyleBackColor = True
        '
        'EliminarMaqButton
        '
        Me.EliminarMaqButton.Location = New System.Drawing.Point(826, 500)
        Me.EliminarMaqButton.Name = "EliminarMaqButton"
        Me.EliminarMaqButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarMaqButton.TabIndex = 6
        Me.EliminarMaqButton.Text = "Eliminar"
        Me.EliminarMaqButton.UseVisualStyleBackColor = True
        '
        'PruebaLabel
        '
        Me.PruebaLabel.AutoSize = True
        Me.PruebaLabel.Location = New System.Drawing.Point(447, 48)
        Me.PruebaLabel.Name = "PruebaLabel"
        Me.PruebaLabel.Size = New System.Drawing.Size(39, 13)
        Me.PruebaLabel.TabIndex = 7
        Me.PruebaLabel.Text = "Label2"
        '
        'GestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 559)
        Me.Controls.Add(Me.PruebaLabel)
        Me.Controls.Add(Me.EliminarMaqButton)
        Me.Controls.Add(Me.EditarMaqButton)
        Me.Controls.Add(Me.ConsultarMaqButton)
        Me.Controls.Add(Me.DatosMaquinasDataGridView)
        Me.Controls.Add(Me.AddMaquinaButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuscarPorNombreTextBox)
        Me.Name = "GestionMaquinas"
        Me.Text = "FabLab - Gestion de Maquinas"
        CType(Me.DatosMaquinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscarPorNombreTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddMaquinaButton As Button
    Friend WithEvents DatosMaquinasDataGridView As DataGridView
    Friend WithEvents ConsultarMaqButton As Button
    Friend WithEvents EditarMaqButton As Button
    Friend WithEvents EliminarMaqButton As Button
    Friend WithEvents PruebaLabel As Label
End Class

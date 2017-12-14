<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservasUsuario
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
        Me.ReservUsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.CerrarFormButton = New System.Windows.Forms.Button()
        CType(Me.ReservUsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReservUsuariosDataGridView
        '
        Me.ReservUsuariosDataGridView.AllowUserToAddRows = False
        Me.ReservUsuariosDataGridView.AllowUserToDeleteRows = False
        Me.ReservUsuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReservUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservUsuariosDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ReservUsuariosDataGridView.Name = "ReservUsuariosDataGridView"
        Me.ReservUsuariosDataGridView.ReadOnly = True
        Me.ReservUsuariosDataGridView.Size = New System.Drawing.Size(542, 243)
        Me.ReservUsuariosDataGridView.TabIndex = 0
        '
        'CerrarFormButton
        '
        Me.CerrarFormButton.Location = New System.Drawing.Point(232, 308)
        Me.CerrarFormButton.Name = "CerrarFormButton"
        Me.CerrarFormButton.Size = New System.Drawing.Size(75, 23)
        Me.CerrarFormButton.TabIndex = 1
        Me.CerrarFormButton.Text = "Cerrar"
        Me.CerrarFormButton.UseVisualStyleBackColor = True
        '
        'ReservasUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 362)
        Me.Controls.Add(Me.CerrarFormButton)
        Me.Controls.Add(Me.ReservUsuariosDataGridView)
        Me.Name = "ReservasUsuario"
        Me.Text = "Reservas Usuario"
        CType(Me.ReservUsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReservUsuariosDataGridView As DataGridView
    Friend WithEvents CerrarFormButton As Button
End Class

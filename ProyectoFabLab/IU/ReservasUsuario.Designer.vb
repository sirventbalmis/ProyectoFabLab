﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservasUsuario))
        Me.CerrarReservaButton = New System.Windows.Forms.Button()
        Me.ReservUsuarioDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ReservUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CerrarReservaButton
        '
        Me.CerrarReservaButton.Location = New System.Drawing.Point(210, 287)
        Me.CerrarReservaButton.Name = "CerrarReservaButton"
        Me.CerrarReservaButton.Size = New System.Drawing.Size(75, 23)
        Me.CerrarReservaButton.TabIndex = 6
        Me.CerrarReservaButton.Text = "Cerrar"
        Me.CerrarReservaButton.UseVisualStyleBackColor = True
        '
        'ReservUsuarioDataGridView
        '
        Me.ReservUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservUsuarioDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ReservUsuarioDataGridView.Name = "ReservUsuarioDataGridView"
        Me.ReservUsuarioDataGridView.Size = New System.Drawing.Size(485, 222)
        Me.ReservUsuarioDataGridView.TabIndex = 7
        '
        'ReservasUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 322)
        Me.Controls.Add(Me.ReservUsuarioDataGridView)
        Me.Controls.Add(Me.CerrarReservaButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReservasUsuario"
        Me.Text = "Reservas Usuario"
        CType(Me.ReservUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CerrarReservaButton As Button
    Friend WithEvents ReservUsuarioDataGridView As DataGridView
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMaquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuMaquinasStatusStrip = New System.Windows.Forms.ToolStrip()
        Me.NumUsuariosToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.MaquinasEtiqueta = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AddUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.NuevaMaquinaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BarraProgresoAPI = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip.SuspendLayout()
        Me.UsuMaquinasStatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ArchivoToolStripMenuItem, Me.InformesToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(952, 24)
        Me.MenuStrip.TabIndex = 3
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUsuarioToolStripMenuItem, Me.GestionUsuariosToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'AddUsuarioToolStripMenuItem
        '
        Me.AddUsuarioToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddUsuarioToolStripMenuItem.Name = "AddUsuarioToolStripMenuItem"
        Me.AddUsuarioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'GestionUsuariosToolStripMenuItem
        '
        Me.GestionUsuariosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GestionUsuariosToolStripMenuItem.Name = "GestionUsuariosToolStripMenuItem"
        Me.GestionUsuariosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GestionUsuariosToolStripMenuItem.Text = "Gestión de Usuarios"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaMaquinaToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ArchivoToolStripMenuItem.Text = "Máquinas"
        '
        'NuevaMaquinaToolStripMenuItem
        '
        Me.NuevaMaquinaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevaMaquinaToolStripMenuItem.Name = "NuevaMaquinaToolStripMenuItem"
        Me.NuevaMaquinaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevaMaquinaToolStripMenuItem.Text = "Nueva Máquina"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GuardarToolStripMenuItem.Text = "Gestión de Máquinas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarVentanasToolStripMenuItem, Me.MinimizarTodasToolStripMenuItem, Me.ToolStripSeparator1})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "Ventana"
        '
        'OrganizarVentanasToolStripMenuItem
        '
        Me.OrganizarVentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.MosaicoVerticalToolStripMenuItem, Me.MosaicoHorizontalToolStripMenuItem})
        Me.OrganizarVentanasToolStripMenuItem.Name = "OrganizarVentanasToolStripMenuItem"
        Me.OrganizarVentanasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrganizarVentanasToolStripMenuItem.Text = "Organizar Ventanas"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'MosaicoVerticalToolStripMenuItem
        '
        Me.MosaicoVerticalToolStripMenuItem.Name = "MosaicoVerticalToolStripMenuItem"
        Me.MosaicoVerticalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MosaicoVerticalToolStripMenuItem.Text = "Mosaico Vertical"
        '
        'MosaicoHorizontalToolStripMenuItem
        '
        Me.MosaicoHorizontalToolStripMenuItem.Name = "MosaicoHorizontalToolStripMenuItem"
        Me.MosaicoHorizontalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MosaicoHorizontalToolStripMenuItem.Text = "Mosaico Horizontal"
        '
        'MinimizarTodasToolStripMenuItem
        '
        Me.MinimizarTodasToolStripMenuItem.Name = "MinimizarTodasToolStripMenuItem"
        Me.MinimizarTodasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MinimizarTodasToolStripMenuItem.Text = "Minimizar Todas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(172, 6)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'UsuMaquinasStatusStrip
        '
        Me.UsuMaquinasStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsuMaquinasStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NumUsuariosToolStripLabel, Me.ToolStripLabel2, Me.MaquinasEtiqueta, Me.BarraProgresoAPI})
        Me.UsuMaquinasStatusStrip.Location = New System.Drawing.Point(0, 528)
        Me.UsuMaquinasStatusStrip.Name = "UsuMaquinasStatusStrip"
        Me.UsuMaquinasStatusStrip.Size = New System.Drawing.Size(952, 25)
        Me.UsuMaquinasStatusStrip.TabIndex = 5
        Me.UsuMaquinasStatusStrip.Text = "ToolStrip1"
        '
        'NumUsuariosToolStripLabel
        '
        Me.NumUsuariosToolStripLabel.Name = "NumUsuariosToolStripLabel"
        Me.NumUsuariosToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.NumUsuariosToolStripLabel.Text = "Usuarios: 15"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel2.Text = "-"
        '
        'MaquinasEtiqueta
        '
        Me.MaquinasEtiqueta.Name = "MaquinasEtiqueta"
        Me.MaquinasEtiqueta.Size = New System.Drawing.Size(71, 22)
        Me.MaquinasEtiqueta.Text = "Máquinas: 6"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUsuarioToolStripButton, Me.NuevaMaquinaToolStripButton, Me.toolStripSeparator, Me.AyudaToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(952, 25)
        Me.ToolStrip.TabIndex = 7
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'AddUsuarioToolStripButton
        '
        Me.AddUsuarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddUsuarioToolStripButton.Image = CType(resources.GetObject("AddUsuarioToolStripButton.Image"), System.Drawing.Image)
        Me.AddUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddUsuarioToolStripButton.Name = "AddUsuarioToolStripButton"
        Me.AddUsuarioToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AddUsuarioToolStripButton.Text = "Nuevo Usuario"
        '
        'NuevaMaquinaToolStripButton
        '
        Me.NuevaMaquinaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevaMaquinaToolStripButton.Image = CType(resources.GetObject("NuevaMaquinaToolStripButton.Image"), System.Drawing.Image)
        Me.NuevaMaquinaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevaMaquinaToolStripButton.Name = "NuevaMaquinaToolStripButton"
        Me.NuevaMaquinaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevaMaquinaToolStripButton.Text = "Nueva Máquina"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'BarraProgresoAPI
        '
        Me.BarraProgresoAPI.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BarraProgresoAPI.Name = "BarraProgresoAPI"
        Me.BarraProgresoAPI.Size = New System.Drawing.Size(100, 22)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 553)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.UsuMaquinasStatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Form1"
        Me.Text = "FabLab - Ventana Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.UsuMaquinasStatusStrip.ResumeLayout(False)
        Me.UsuMaquinasStatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaMaquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuMaquinasStatusStrip As ToolStrip
    Friend WithEvents MaquinasEtiqueta As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents NumUsuariosToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents AddUsuarioToolStripButton As ToolStripButton
    Friend WithEvents NuevaMaquinaToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MinimizarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarraProgresoAPI As ToolStripProgressBar
End Class

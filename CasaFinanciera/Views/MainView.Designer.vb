﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        EntradaToolStripMenuItem = New ToolStripMenuItem()
        DatosMenuItem = New ToolStripMenuItem()
        ListaToolStripMenuItem = New ToolStripMenuItem()
        PrestamoToolStripMenuItem = New ToolStripMenuItem()
        AdministrarToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        LiquidacionesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(28, 28)
        MenuStrip1.Items.AddRange(New ToolStripItem() {EntradaToolStripMenuItem, PrestamoToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1343, 38)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' EntradaToolStripMenuItem
        ' 
        EntradaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DatosMenuItem, ListaToolStripMenuItem})
        EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        EntradaToolStripMenuItem.Size = New Size(95, 34)
        EntradaToolStripMenuItem.Text = "Cliente"
        ' 
        ' DatosMenuItem
        ' 
        DatosMenuItem.Name = "DatosMenuItem"
        DatosMenuItem.Size = New Size(278, 40)
        DatosMenuItem.Text = "Datos"
        ' 
        ' ListaToolStripMenuItem
        ' 
        ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        ListaToolStripMenuItem.Size = New Size(278, 40)
        ListaToolStripMenuItem.Text = "Lista de clientes"
        ' 
        ' PrestamoToolStripMenuItem
        ' 
        PrestamoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdministrarToolStripMenuItem, LiquidacionesToolStripMenuItem})
        PrestamoToolStripMenuItem.Name = "PrestamoToolStripMenuItem"
        PrestamoToolStripMenuItem.Size = New Size(127, 34)
        PrestamoToolStripMenuItem.Text = "Prestamos"
        ' 
        ' AdministrarToolStripMenuItem
        ' 
        AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        AdministrarToolStripMenuItem.Size = New Size(315, 40)
        AdministrarToolStripMenuItem.Text = "Administrar"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(70, 34)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' LiquidacionesToolStripMenuItem
        ' 
        LiquidacionesToolStripMenuItem.Name = "LiquidacionesToolStripMenuItem"
        LiquidacionesToolStripMenuItem.Size = New Size(315, 40)
        LiquidacionesToolStripMenuItem.Text = "Liquidaciones"
        ' 
        ' MainView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1343, 984)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "MainView"
        Text = "Casa financiera"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiquidacionesToolStripMenuItem As ToolStripMenuItem

End Class

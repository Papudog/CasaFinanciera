<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GridClientes = New DataGridView()
        Label1 = New Label()
        CType(GridClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GridClientes
        ' 
        GridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GridClientes.Location = New Point(12, 12)
        GridClientes.Name = "GridClientes"
        GridClientes.RowHeadersWidth = 72
        GridClientes.Size = New Size(1039, 625)
        GridClientes.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label1.Location = New Point(12, 657)
        Label1.Name = "Label1"
        Label1.Size = New Size(503, 30)
        Label1.TabIndex = 1
        Label1.Text = "Dé doble click sobre un cliente para crear un préstamo."
        ' 
        ' ClientesView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 696)
        Controls.Add(Label1)
        Controls.Add(GridClientes)
        Name = "ClientesView"
        Text = "Lista de clientes"
        CType(GridClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GridClientes As DataGridView
    Friend WithEvents Label1 As Label
End Class

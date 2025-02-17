<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiquidacionesView
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
        DataGridLiquidaciones = New DataGridView()
        CType(DataGridLiquidaciones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridLiquidaciones
        ' 
        DataGridLiquidaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridLiquidaciones.Location = New Point(12, 12)
        DataGridLiquidaciones.Name = "DataGridLiquidaciones"
        DataGridLiquidaciones.RowHeadersWidth = 72
        DataGridLiquidaciones.Size = New Size(1039, 672)
        DataGridLiquidaciones.TabIndex = 0
        ' 
        ' LiquidacionesView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 696)
        Controls.Add(DataGridLiquidaciones)
        Name = "LiquidacionesView"
        Text = "LiquidacionesView"
        CType(DataGridLiquidaciones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridLiquidaciones As DataGridView
End Class

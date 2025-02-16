<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestamosView
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
        PrestamosGrid = New DataGridView()
        CType(PrestamosGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrestamosGrid
        ' 
        PrestamosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PrestamosGrid.Location = New Point(12, 12)
        PrestamosGrid.Name = "PrestamosGrid"
        PrestamosGrid.RowHeadersWidth = 72
        PrestamosGrid.Size = New Size(1039, 672)
        PrestamosGrid.TabIndex = 0
        ' 
        ' PrestamosView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 696)
        Controls.Add(PrestamosGrid)
        Name = "PrestamosView"
        Text = "PrestamosView"
        CType(PrestamosGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrestamosGrid As DataGridView
End Class

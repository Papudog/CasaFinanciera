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
        Label1 = New Label()
        CType(PrestamosGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrestamosGrid
        ' 
        PrestamosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PrestamosGrid.Location = New Point(12, 12)
        PrestamosGrid.Name = "PrestamosGrid"
        PrestamosGrid.RowHeadersWidth = 72
        PrestamosGrid.Size = New Size(1039, 625)
        PrestamosGrid.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label1.Location = New Point(12, 657)
        Label1.Name = "Label1"
        Label1.Size = New Size(448, 30)
        Label1.TabIndex = 2
        Label1.Text = "Dé doble click sobre un préstamo para liquidarlo."
        ' 
        ' PrestamosView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 696)
        Controls.Add(Label1)
        Controls.Add(PrestamosGrid)
        Name = "PrestamosView"
        Text = "Tabla de préstamos"
        CType(PrestamosGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrestamosGrid As DataGridView
    Friend WithEvents Label1 As Label
End Class

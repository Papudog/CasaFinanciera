<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLiquidacion
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
        GroupBox1 = New GroupBox()
        ButtonLiquidar = New Button()
        TextTotal = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        TextCuota = New TextBox()
        TextPlazos = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextNombre = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ButtonLiquidar)
        GroupBox1.Controls.Add(TextTotal)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextCuota)
        GroupBox1.Controls.Add(TextPlazos)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(614, 347)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cliente a liquidar"
        ' 
        ' ButtonLiquidar
        ' 
        ButtonLiquidar.Location = New Point(431, 301)
        ButtonLiquidar.Name = "ButtonLiquidar"
        ButtonLiquidar.Size = New Size(177, 40)
        ButtonLiquidar.TabIndex = 8
        ButtonLiquidar.Text = "Liquidar cliente"
        ButtonLiquidar.UseVisualStyleBackColor = True
        ' 
        ' TextTotal
        ' 
        TextTotal.Enabled = False
        TextTotal.Location = New Point(331, 198)
        TextTotal.Name = "TextTotal"
        TextTotal.Size = New Size(277, 35)
        TextTotal.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(332, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 30)
        Label4.TabIndex = 6
        Label4.Text = "Total a pagar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 30)
        Label3.TabIndex = 5
        Label3.Text = "Cuota mensual"
        ' 
        ' TextCuota
        ' 
        TextCuota.Enabled = False
        TextCuota.Location = New Point(6, 198)
        TextCuota.Name = "TextCuota"
        TextCuota.Size = New Size(277, 35)
        TextCuota.TabIndex = 4
        ' 
        ' TextPlazos
        ' 
        TextPlazos.Enabled = False
        TextPlazos.Location = New Point(332, 105)
        TextPlazos.Name = "TextPlazos"
        TextPlazos.Size = New Size(277, 35)
        TextPlazos.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(332, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 30)
        Label2.TabIndex = 2
        Label2.Text = "Plazos en meses"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 30)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' TextNombre
        ' 
        TextNombre.Enabled = False
        TextNombre.Location = New Point(6, 105)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(277, 35)
        TextNombre.TabIndex = 0
        ' 
        ' FormLiquidacion
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 371)
        Controls.Add(GroupBox1)
        Name = "FormLiquidacion"
        Text = "FormLiquidacion"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCuota As TextBox
    Friend WithEvents TextPlazos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonLiquidar As Button
End Class

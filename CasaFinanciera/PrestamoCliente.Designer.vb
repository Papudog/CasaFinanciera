<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrestamoCliente
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextCliente = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        LabelCuota = New Label()
        LabelTotal = New Label()
        Label8 = New Label()
        LabelInteres = New Label()
        Label10 = New Label()
        ButtonCalcular = New Button()
        ButtonGuardar = New Button()
        LabelMonto = New Label()
        Label9 = New Label()
        NumericPrestamo = New NumericUpDown()
        NumericPlazo = New NumericUpDown()
        CType(NumericPrestamo, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericPlazo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(288, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 30)
        Label1.TabIndex = 0
        Label1.Text = "Monto del préstamo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 30)
        Label2.TabIndex = 2
        Label2.Text = "Interes mensual:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(239, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 30)
        Label3.TabIndex = 3
        Label3.Text = "3%"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(547, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 30)
        Label4.TabIndex = 4
        Label4.Text = "Plazo"
        ' 
        ' TextCliente
        ' 
        TextCliente.Font = New Font("Segoe UI", 12F)
        TextCliente.Location = New Point(43, 102)
        TextCliente.Name = "TextCliente"
        TextCliente.Size = New Size(202, 45)
        TextCliente.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 30)
        Label5.TabIndex = 6
        Label5.Text = "Cliente"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 30)
        Label6.TabIndex = 8
        Label6.Text = "Cuota mensual:"
        ' 
        ' LabelCuota
        ' 
        LabelCuota.AutoSize = True
        LabelCuota.Location = New Point(247, 273)
        LabelCuota.Name = "LabelCuota"
        LabelCuota.Size = New Size(24, 30)
        LabelCuota.TabIndex = 9
        LabelCuota.Text = "0"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(247, 337)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(24, 30)
        LabelTotal.TabIndex = 11
        LabelTotal.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(43, 337)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 30)
        Label8.TabIndex = 10
        Label8.Text = "Total a pagar:"
        ' 
        ' LabelInteres
        ' 
        LabelInteres.AutoSize = True
        LabelInteres.Location = New Point(247, 394)
        LabelInteres.Name = "LabelInteres"
        LabelInteres.Size = New Size(24, 30)
        LabelInteres.TabIndex = 13
        LabelInteres.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(43, 394)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 30)
        Label10.TabIndex = 12
        Label10.Text = "Interés total:"
        ' 
        ' ButtonCalcular
        ' 
        ButtonCalcular.Font = New Font("Segoe UI", 12F)
        ButtonCalcular.Location = New Point(485, 295)
        ButtonCalcular.Name = "ButtonCalcular"
        ButtonCalcular.Size = New Size(272, 54)
        ButtonCalcular.TabIndex = 14
        ButtonCalcular.Text = "Calcular prestamo"
        ButtonCalcular.UseVisualStyleBackColor = True
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Font = New Font("Segoe UI", 12F)
        ButtonGuardar.Location = New Point(485, 370)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(272, 54)
        ButtonGuardar.TabIndex = 15
        ButtonGuardar.Text = "Guardar prestamo"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' LabelMonto
        ' 
        LabelMonto.AutoSize = True
        LabelMonto.Location = New Point(689, 243)
        LabelMonto.Name = "LabelMonto"
        LabelMonto.Size = New Size(24, 30)
        LabelMonto.TabIndex = 18
        LabelMonto.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(485, 243)
        Label9.Name = "Label9"
        Label9.Size = New Size(160, 30)
        Label9.TabIndex = 17
        Label9.Text = "Monto máximo:"
        ' 
        ' NumericPrestamo
        ' 
        NumericPrestamo.Font = New Font("Segoe UI", 12F)
        NumericPrestamo.Location = New Point(288, 102)
        NumericPrestamo.Name = "NumericPrestamo"
        NumericPrestamo.Size = New Size(210, 45)
        NumericPrestamo.TabIndex = 19
        ' 
        ' NumericPlazo
        ' 
        NumericPlazo.Font = New Font("Segoe UI", 12F)
        NumericPlazo.Location = New Point(547, 102)
        NumericPlazo.Name = "NumericPlazo"
        NumericPlazo.Size = New Size(210, 45)
        NumericPlazo.TabIndex = 20
        ' 
        ' PrestamoCliente
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 534)
        Controls.Add(NumericPlazo)
        Controls.Add(NumericPrestamo)
        Controls.Add(LabelMonto)
        Controls.Add(Label9)
        Controls.Add(ButtonGuardar)
        Controls.Add(ButtonCalcular)
        Controls.Add(LabelInteres)
        Controls.Add(Label10)
        Controls.Add(LabelTotal)
        Controls.Add(Label8)
        Controls.Add(LabelCuota)
        Controls.Add(Label6)
        Controls.Add(TextCliente)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PrestamoCliente"
        Text = "PrestamoCliente"
        CType(NumericPrestamo, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericPlazo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelCuota As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelInteres As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents LabelMonto As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericPrestamo As NumericUpDown
    Friend WithEvents NumericPlazo As NumericUpDown
End Class

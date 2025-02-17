<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrestamoView
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextCliente = New TextBox()
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
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1 = New GroupBox()
        TextCivil = New TextBox()
        Label11 = New Label()
        CheckDeuda = New CheckBox()
        Label7 = New Label()
        NumericSalario = New NumericUpDown()
        Label5 = New Label()
        CType(NumericPrestamo, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericPlazo, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(NumericSalario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(378, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 30)
        Label1.TabIndex = 0
        Label1.Text = "Préstamo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(378, 245)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 30)
        Label2.TabIndex = 2
        Label2.Text = "Interés mensual:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(574, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 30)
        Label3.TabIndex = 3
        Label3.Text = "3%"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(378, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 30)
        Label4.TabIndex = 4
        Label4.Text = "Plazo"
        ' 
        ' TextCliente
        ' 
        TextCliente.Enabled = False
        TextCliente.Font = New Font("Segoe UI", 9F)
        TextCliente.Location = New Point(6, 37)
        TextCliente.Name = "TextCliente"
        TextCliente.Size = New Size(336, 35)
        TextCliente.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(378, 290)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 30)
        Label6.TabIndex = 8
        Label6.Text = "Cuota mensual:"
        ' 
        ' LabelCuota
        ' 
        LabelCuota.AutoSize = True
        LabelCuota.Location = New Point(582, 290)
        LabelCuota.Name = "LabelCuota"
        LabelCuota.Size = New Size(24, 30)
        LabelCuota.TabIndex = 9
        LabelCuota.Text = "0"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.AutoSize = True
        LabelTotal.Location = New Point(582, 334)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(24, 30)
        LabelTotal.TabIndex = 11
        LabelTotal.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(378, 334)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 30)
        Label8.TabIndex = 10
        Label8.Text = "Total a pagar:"
        ' 
        ' LabelInteres
        ' 
        LabelInteres.AutoSize = True
        LabelInteres.Location = New Point(582, 379)
        LabelInteres.Name = "LabelInteres"
        LabelInteres.Size = New Size(24, 30)
        LabelInteres.TabIndex = 13
        LabelInteres.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(378, 379)
        Label10.Name = "Label10"
        Label10.Size = New Size(129, 30)
        Label10.TabIndex = 12
        Label10.Text = "Interés total:"
        ' 
        ' ButtonCalcular
        ' 
        ButtonCalcular.Font = New Font("Segoe UI", 9F)
        ButtonCalcular.Location = New Point(378, 173)
        ButtonCalcular.Name = "ButtonCalcular"
        ButtonCalcular.Size = New Size(202, 45)
        ButtonCalcular.TabIndex = 14
        ButtonCalcular.Text = "Calcular préstamo"
        ButtonCalcular.UseVisualStyleBackColor = True
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Font = New Font("Segoe UI", 9F)
        ButtonGuardar.Location = New Point(378, 435)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(202, 45)
        ButtonGuardar.TabIndex = 15
        ButtonGuardar.Text = "Guardar préstamo"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' LabelMonto
        ' 
        LabelMonto.AutoSize = True
        LabelMonto.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        LabelMonto.Location = New Point(211, 168)
        LabelMonto.Name = "LabelMonto"
        LabelMonto.Size = New Size(24, 30)
        LabelMonto.TabIndex = 18
        LabelMonto.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label9.Location = New Point(7, 168)
        Label9.Name = "Label9"
        Label9.Size = New Size(155, 30)
        Label9.TabIndex = 17
        Label9.Text = "Monto máximo:"
        ' 
        ' NumericPrestamo
        ' 
        NumericPrestamo.Font = New Font("Segoe UI", 9F)
        NumericPrestamo.Location = New Point(484, 49)
        NumericPrestamo.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        NumericPrestamo.Name = "NumericPrestamo"
        NumericPrestamo.Size = New Size(287, 35)
        NumericPrestamo.TabIndex = 19
        ' 
        ' NumericPlazo
        ' 
        NumericPlazo.Font = New Font("Segoe UI", 9F)
        NumericPlazo.Location = New Point(484, 108)
        NumericPlazo.Name = "NumericPlazo"
        NumericPlazo.Size = New Size(287, 35)
        NumericPlazo.TabIndex = 20
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextCivil)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(CheckDeuda)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(NumericSalario)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextCliente)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(LabelMonto)
        GroupBox1.Location = New Point(6, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(350, 468)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cliente"
        ' 
        ' TextCivil
        ' 
        TextCivil.Enabled = False
        TextCivil.Font = New Font("Segoe UI", 9F)
        TextCivil.Location = New Point(6, 309)
        TextCivil.Name = "TextCivil"
        TextCivil.Size = New Size(336, 35)
        TextCivil.TabIndex = 26
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 276)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 30)
        Label11.TabIndex = 25
        Label11.Text = "Estado civil"
        ' 
        ' CheckDeuda
        ' 
        CheckDeuda.AutoSize = True
        CheckDeuda.Enabled = False
        CheckDeuda.Location = New Point(162, 225)
        CheckDeuda.Name = "CheckDeuda"
        CheckDeuda.Size = New Size(22, 21)
        CheckDeuda.TabIndex = 24
        CheckDeuda.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 30)
        Label7.TabIndex = 23
        Label7.Text = "¿Posee deuda?"
        ' 
        ' NumericSalario
        ' 
        NumericSalario.Enabled = False
        NumericSalario.Font = New Font("Segoe UI", 9F)
        NumericSalario.Location = New Point(6, 117)
        NumericSalario.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        NumericSalario.Name = "NumericSalario"
        NumericSalario.Size = New Size(336, 35)
        NumericSalario.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(159, 30)
        Label5.TabIndex = 22
        Label5.Text = "Salario mensual"
        ' 
        ' FormPrestamoView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 502)
        Controls.Add(GroupBox1)
        Controls.Add(NumericPlazo)
        Controls.Add(NumericPrestamo)
        Controls.Add(ButtonGuardar)
        Controls.Add(ButtonCalcular)
        Controls.Add(LabelInteres)
        Controls.Add(Label10)
        Controls.Add(LabelTotal)
        Controls.Add(Label8)
        Controls.Add(LabelCuota)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormPrestamoView"
        Text = "Préstamo para un cliente"
        CType(NumericPrestamo, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericPlazo, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericSalario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCliente As TextBox
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
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericSalario As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckDeuda As CheckBox
    Friend WithEvents TextCivil As TextBox
    Friend WithEvents Label11 As Label
End Class

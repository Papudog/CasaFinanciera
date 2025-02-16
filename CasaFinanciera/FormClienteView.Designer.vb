<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClienteView
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
        TextNombre = New TextBox()
        Label1 = New Label()
        TextDireccion = New TextBox()
        Label2 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TextTelefono = New TextBox()
        Label3 = New Label()
        TextCorreo = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        NacimientoPicker = New DateTimePicker()
        Label6 = New Label()
        ComboDocumento = New ComboBox()
        Label7 = New Label()
        Label8 = New Label()
        CheckHistorial = New CheckBox()
        Label9 = New Label()
        NumericSalario = New NumericUpDown()
        ButtonGuardar = New Button()
        ComboCivil = New ComboBox()
        FontDialog1 = New FontDialog()
        ErrorProvider1 = New ErrorProvider(components)
        CType(NumericSalario, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextNombre
        ' 
        TextNombre.Font = New Font("Segoe UI", 12F)
        TextNombre.Location = New Point(45, 107)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(200, 45)
        TextNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 30)
        Label1.TabIndex = 2
        Label1.Text = "Nombre"
        ' 
        ' TextDireccion
        ' 
        TextDireccion.Font = New Font("Segoe UI", 12F)
        TextDireccion.Location = New Point(578, 243)
        TextDireccion.Multiline = True
        TextDireccion.Name = "TextDireccion"
        TextDireccion.Size = New Size(315, 104)
        TextDireccion.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(578, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 30)
        Label2.TabIndex = 4
        Label2.Text = "Direccion"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Font = New Font("Segoe UI", 12F)
        TextTelefono.Location = New Point(313, 107)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(200, 45)
        TextTelefono.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(313, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 30)
        Label3.TabIndex = 6
        Label3.Text = "Teléfono"
        ' 
        ' TextCorreo
        ' 
        TextCorreo.Font = New Font("Segoe UI", 12F)
        TextCorreo.Location = New Point(578, 107)
        TextCorreo.Name = "TextCorreo"
        TextCorreo.Size = New Size(315, 45)
        TextCorreo.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(578, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 30)
        Label4.TabIndex = 8
        Label4.Text = "Correo electrónico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 30)
        Label5.TabIndex = 10
        Label5.Text = "Fecha de nacimiento"
        ' 
        ' NacimientoPicker
        ' 
        NacimientoPicker.CalendarFont = New Font("Segoe UI", 12F)
        NacimientoPicker.Font = New Font("Segoe UI", 12F)
        NacimientoPicker.Location = New Point(45, 249)
        NacimientoPicker.Name = "NacimientoPicker"
        NacimientoPicker.Size = New Size(468, 45)
        NacimientoPicker.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 384)
        Label6.Name = "Label6"
        Label6.Size = New Size(194, 30)
        Label6.TabIndex = 13
        Label6.Text = "Tipo de documento"
        ' 
        ' ComboDocumento
        ' 
        ComboDocumento.FormattingEnabled = True
        ComboDocumento.Location = New Point(45, 444)
        ComboDocumento.Name = "ComboDocumento"
        ComboDocumento.Size = New Size(212, 38)
        ComboDocumento.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(325, 380)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 30)
        Label7.TabIndex = 16
        Label7.Text = "Estado civil"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(578, 380)
        Label8.Name = "Label8"
        Label8.Size = New Size(179, 30)
        Label8.TabIndex = 18
        Label8.Text = "Historial crediticio"
        ' 
        ' CheckHistorial
        ' 
        CheckHistorial.AutoSize = True
        CheckHistorial.Location = New Point(578, 437)
        CheckHistorial.Name = "CheckHistorial"
        CheckHistorial.Size = New Size(231, 34)
        CheckHistorial.TabIndex = 8
        CheckHistorial.Text = "Tiene deudas activas"
        CheckHistorial.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(45, 546)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 30)
        Label9.TabIndex = 20
        Label9.Text = "Salario mensual"
        ' 
        ' NumericSalario
        ' 
        NumericSalario.Font = New Font("Segoe UI", 12F)
        NumericSalario.Location = New Point(45, 607)
        NumericSalario.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        NumericSalario.Name = "NumericSalario"
        NumericSalario.Size = New Size(210, 45)
        NumericSalario.TabIndex = 9
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Font = New Font("Segoe UI", 12F)
        ButtonGuardar.Location = New Point(664, 602)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(229, 64)
        ButtonGuardar.TabIndex = 10
        ButtonGuardar.Text = "Guardar cliente"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' ComboCivil
        ' 
        ComboCivil.FormattingEnabled = True
        ComboCivil.Location = New Point(325, 444)
        ComboCivil.Name = "ComboCivil"
        ComboCivil.Size = New Size(212, 38)
        ComboCivil.TabIndex = 7
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' DatosCliente
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 705)
        Controls.Add(ComboCivil)
        Controls.Add(ButtonGuardar)
        Controls.Add(NumericSalario)
        Controls.Add(Label9)
        Controls.Add(CheckHistorial)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(ComboDocumento)
        Controls.Add(Label6)
        Controls.Add(NacimientoPicker)
        Controls.Add(Label5)
        Controls.Add(TextCorreo)
        Controls.Add(Label4)
        Controls.Add(TextTelefono)
        Controls.Add(Label3)
        Controls.Add(TextDireccion)
        Controls.Add(Label2)
        Controls.Add(TextNombre)
        Controls.Add(Label1)
        Name = "DatosCliente"
        Text = "Datos del cliente"
        CType(NumericSalario, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NacimientoPicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboDocumento As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckHistorial As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericSalario As NumericUpDown
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ComboCivil As ComboBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class

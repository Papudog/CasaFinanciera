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
        CheckHistorial = New CheckBox()
        Label9 = New Label()
        NumericSalario = New NumericUpDown()
        ButtonGuardar = New Button()
        ComboCivil = New ComboBox()
        FontDialog1 = New FontDialog()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        CType(NumericSalario, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextNombre
        ' 
        TextNombre.Font = New Font("Segoe UI", 9F)
        TextNombre.Location = New Point(9, 75)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(375, 35)
        TextNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 30)
        Label1.TabIndex = 2
        Label1.Text = "Nombre"
        ' 
        ' TextDireccion
        ' 
        TextDireccion.Font = New Font("Segoe UI", 9F)
        TextDireccion.Location = New Point(15, 227)
        TextDireccion.Multiline = True
        TextDireccion.Name = "TextDireccion"
        TextDireccion.Size = New Size(445, 104)
        TextDireccion.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 30)
        Label2.TabIndex = 4
        Label2.Text = "Dirección"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Font = New Font("Segoe UI", 9F)
        TextTelefono.Location = New Point(6, 82)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(215, 35)
        TextTelefono.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 30)
        Label3.TabIndex = 6
        Label3.Text = "Teléfono"
        ' 
        ' TextCorreo
        ' 
        TextCorreo.Font = New Font("Segoe UI", 9F)
        TextCorreo.Location = New Point(6, 175)
        TextCorreo.Name = "TextCorreo"
        TextCorreo.Size = New Size(402, 35)
        TextCorreo.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 30)
        Label4.TabIndex = 8
        Label4.Text = "Correo electrónico"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(205, 30)
        Label5.TabIndex = 10
        Label5.Text = "Fecha de nacimiento"
        ' 
        ' NacimientoPicker
        ' 
        NacimientoPicker.CalendarFont = New Font("Segoe UI", 12F)
        NacimientoPicker.Font = New Font("Segoe UI", 9F)
        NacimientoPicker.Location = New Point(9, 160)
        NacimientoPicker.Name = "NacimientoPicker"
        NacimientoPicker.Size = New Size(375, 35)
        NacimientoPicker.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(194, 30)
        Label6.TabIndex = 13
        Label6.Text = "Tipo de documento"
        ' 
        ' ComboDocumento
        ' 
        ComboDocumento.FormattingEnabled = True
        ComboDocumento.Location = New Point(9, 259)
        ComboDocumento.Name = "ComboDocumento"
        ComboDocumento.Size = New Size(212, 38)
        ComboDocumento.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 320)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 30)
        Label7.TabIndex = 16
        Label7.Text = "Estado civil"
        ' 
        ' CheckHistorial
        ' 
        CheckHistorial.AutoSize = True
        CheckHistorial.Location = New Point(15, 123)
        CheckHistorial.Name = "CheckHistorial"
        CheckHistorial.Size = New Size(184, 34)
        CheckHistorial.TabIndex = 8
        CheckHistorial.Text = "¿Posee deudas?"
        CheckHistorial.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(15, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(159, 30)
        Label9.TabIndex = 20
        Label9.Text = "Salario mensual"
        ' 
        ' NumericSalario
        ' 
        NumericSalario.Font = New Font("Segoe UI", 9F)
        NumericSalario.Location = New Point(15, 76)
        NumericSalario.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        NumericSalario.Name = "NumericSalario"
        NumericSalario.Size = New Size(210, 35)
        NumericSalario.TabIndex = 7
        ' 
        ' ButtonGuardar
        ' 
        ButtonGuardar.Font = New Font("Segoe UI", 9F)
        ButtonGuardar.Location = New Point(752, 614)
        ButtonGuardar.Name = "ButtonGuardar"
        ButtonGuardar.Size = New Size(180, 43)
        ButtonGuardar.TabIndex = 10
        ButtonGuardar.Text = "Guardar cliente"
        ButtonGuardar.UseVisualStyleBackColor = True
        ' 
        ' ComboCivil
        ' 
        ComboCivil.FormattingEnabled = True
        ComboCivil.Location = New Point(9, 356)
        ComboCivil.Name = "ComboCivil"
        ComboCivil.Size = New Size(212, 38)
        ComboCivil.TabIndex = 4
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextTelefono)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextCorreo)
        GroupBox1.Location = New Point(12, 447)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(433, 246)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Información de contacto"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(TextNombre)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(ComboCivil)
        GroupBox2.Controls.Add(NacimientoPicker)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(ComboDocumento)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(433, 429)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Perfil del cliente"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(NumericSalario)
        GroupBox3.Controls.Add(CheckHistorial)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(TextDireccion)
        GroupBox3.Location = New Point(459, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(473, 350)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "Historial crediticio"
        ' 
        ' FormClienteView
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 705)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ButtonGuardar)
        Name = "FormClienteView"
        Text = "Datos del cliente"
        CType(NumericSalario, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents CheckHistorial As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericSalario As NumericUpDown
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents ComboCivil As ComboBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

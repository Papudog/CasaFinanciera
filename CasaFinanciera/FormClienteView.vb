Imports System.Text.RegularExpressions
Imports CasaFinanciera.Domain
Imports CasaFinanciera.Interfaces

Public Class FormClienteView
    Implements IForm

    Private ReadOnly Property _tipoDocumento As String() = {"Cédula", "Pasaporte"}
    Private ReadOnly Property _estadoCivil As String() = {"Soltero", "Casado"}
    Private ReadOnly Property _clienteService As IClienteService
    ' xd
    Private ReadOnly Property _errorDialog As New Dictionary(Of String, String) From {
        {"esVacio", "El campo no puede estar vacío"},
        {"email", "El correo ingresado no es valido"},
        {"telefono", "El teléfono excede el número de caracteres permitidos"},
        {"fechaNacimiento", "La edad del deudor es de un menor xD"},
        {"salario", "El salario del cliente no cumple con los requisitos establecidos"},
        {"noExiste", "El valor ingresado no es permitido"}
    }


    Sub New(clienteService As IClienteService)
        InitializeComponent()
        Me._clienteService = clienteService

        ComboDocumento.Items.AddRange(_tipoDocumento)
        ComboCivil.Items.AddRange(_estadoCivil)
    End Sub


    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If Not ValidarCampos() Then Return

        Dim nombre As String = TextNombre.Text
        Dim telefono As String = TextTelefono.Text
        Dim direccion As String = TextDireccion.Text
        Dim correo As String = TextCorreo.Text
        Dim fechaNacimiento As Date = NacimientoPicker.Value
        Dim historialCrediticio As Boolean = CheckHistorial.Checked
        Dim salarioMensual As Decimal = NumericSalario.Value

        Dim estadoCivil As String = ComboCivil.SelectedItem
        Dim tipoDocumento As String = ComboDocumento.SelectedItem

        _clienteService.AgregarCliente(New Cliente With {
            .Nombre = nombre,
            .Telefono = telefono,
            .Direccion = direccion,
            .Correo = correo,
            .FechaNacimiento = fechaNacimiento,
            .HistorialCrediticio = historialCrediticio,
            .Salario = salarioMensual,
            .EstadoCivil = estadoCivil,
            .TipoDocumento = tipoDocumento
        })

        MessageBox.Show("Cliente agregado correctamente", "Cliente agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LimpiarCampos()
    End Sub


    Private Function isEmail(email As String) As Boolean
        Return New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email)
    End Function


    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If TextNombre.Text = "" Then
            ErrorProvider1.SetError(TextNombre, _errorDialog("esVacio"))
            Return False
        End If

        If TextTelefono.Text.Length < 8 Or TextTelefono.Text.Length > 8 Then
            ErrorProvider1.SetError(TextTelefono, _errorDialog("telefono"))
            Return False
        End If

        If Not isEmail(TextCorreo.Text) Then
            ErrorProvider1.SetError(TextCorreo, _errorDialog("email"))
            Return False
        End If

        Dim salario As Decimal
        If (Decimal.TryParse(NumericSalario.Value, salario)) Then
            If salario < 0 Or salario < 5000 Then
                ErrorProvider1.SetError(NumericSalario, _errorDialog("salario"))
                Return False
            End If
        End If

        If NacimientoPicker.Value.Year > 2007 Then
            ErrorProvider1.SetError(NacimientoPicker, _errorDialog("fechaNacimiento"))
            Return False
        End If

        If Not _estadoCivil.Contains(ComboCivil.SelectedItem) Then
            ErrorProvider1.SetError(ComboCivil, _errorDialog("noExiste"))
            Return False
        End If

        If Not _tipoDocumento.Contains(ComboDocumento.SelectedItem) Then
            ErrorProvider1.SetError(ComboDocumento, _errorDialog("noExiste"))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        TextNombre.Clear()
        TextTelefono.Clear()
        TextDireccion.Clear()
        TextCorreo.Clear()
        NacimientoPicker.Value = Date.Now
        CheckHistorial.Checked = False
        NumericSalario.Value = 0
        ComboCivil.SelectedIndex = -1
        ComboDocumento.SelectedIndex = -1
    End Sub
End Class
Imports CasaFinanciera.Application
Imports CasaFinanciera.Models

Public Class DatosCliente
    Private Property _clienteController As ClienteController

    Private ReadOnly Property _tipoDocumento As String() = {"Cédula", "Pasaporte"}
    Private ReadOnly Property _estadoCivil As String() = {"Soltero", "Casado"}



    Sub New(clienteService As IClienteService)
        InitializeComponent()

        ComboDocumento.Items.AddRange(_tipoDocumento)
        ComboCivil.Items.AddRange(_estadoCivil)

        _clienteController = New ClienteController(clienteService)
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim nombre As String = TextNombre.Text
        Dim telefono As String = TextTelefono.Text
        Dim direccion As String = TextDireccion.Text
        Dim correo As String = TextCorreo.Text
        Dim fechaNacimiento As Date = NacimientoPicker.Value
        Dim historialCrediticio As Boolean = CheckHistorial.Checked
        Dim salarioMensual As Decimal = NumericSalario.Value

        Dim estadoCivil As String = ComboCivil.SelectedItem
        Dim tipoDocumento As String = ComboDocumento.SelectedItem

        Dim cliente As New Cliente With {
            .Nombre = nombre,
            .Telefono = telefono,
            .Direccion = direccion,
            .Correo = correo,
            .FechaNacimiento = fechaNacimiento,
            .HistorialCrediticio = historialCrediticio,
            .Salario = salarioMensual,
            .EstadoCivil = estadoCivil,
            .TipoDocumento = tipoDocumento
        }
        Try
            _clienteController.AgregarCliente(cliente)
            MessageBox.Show("Cliente agregado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
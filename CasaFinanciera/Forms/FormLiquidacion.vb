Imports CasaFinanciera.Application
Imports CasaFinanciera.Interfaces

Public Class FormLiquidacion
    Private ReadOnly Property _prestamoService As IPrestamoService
    Private ReadOnly Property _clienteService As IClienteService
    Private ReadOnly Property _prestamo As IPrestamo
    Sub New(prestamo As IPrestamo, prestamoService As IPrestamoService, clienteService As IClienteService)
        InitializeComponent()

        _prestamo = prestamo
        _clienteService = clienteService
        _prestamoService = prestamoService
    End Sub

    Private Sub ButtonLiquidar_Click(sender As Object, e As EventArgs) Handles ButtonLiquidar.Click
        _prestamo.Cliente.HistorialCrediticio = False
        _prestamo.EstaPagada = True

        _clienteService.EditarCliente(_prestamo.Cliente)
        _prestamoService.EditarPrestamo(_prestamo)
        MessageBox.Show("Préstamo liquidado")
        Me.Close()
    End Sub

    Private Sub FormLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextNombre.Text = _prestamo.Cliente.Nombre
        TextPlazos.Text = _prestamo.PlazoMeses.ToString()
        TextCuota.Text = _prestamo.CuotaMensual.ToString()
        TextTotal.Text = _prestamo.Total.ToString()
    End Sub
End Class
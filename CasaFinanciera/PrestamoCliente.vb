Imports CasaFinanciera.Application
Imports CasaFinanciera.Models

Public Class PrestamoCliente
    Private ReadOnly Property _prestamoService As IPrestamoService
    Private Property _cliente As ICliente
    Private Property _plazosMeses As String() = {"6", "12", "18", "24"}

    'Private ReadOnly Property _prestamoController As PrestamoController

    Sub New(cliente As ICliente, prestamoService As IPrestamoService)
        InitializeComponent()
        _prestamoService = prestamoService
        _cliente = cliente
    End Sub

    Private Sub PrestamoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboPrestamo.Items.AddRange(_plazosMeses)

        NumericPlazo.Maximum = 24
        LabelMonto.Text = _cliente.Prestamo.ToString()
        NumericPrestamo.Maximum = _cliente.Prestamo
        TextCliente.Text = _cliente.Nombre
    End Sub

    Private Function CalcularCuota(monto As Decimal, interesMensual As Decimal, plazoMeses As Integer) As Decimal
        Return (monto / plazoMeses) * ((interesMensual / 100) + 1)
    End Function

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim monto As Decimal = NumericPrestamo.Value
        Dim plazoMeses As Integer = NumericPlazo.Value
        If plazoMeses > 0 Then
            Dim cuota As Decimal = CalcularCuota(monto, 3, plazoMeses)
            Dim total As Decimal = cuota * plazoMeses
            Dim interesTotal As Decimal = total - monto

            LabelCuota.Text = Math.Round(cuota, 2).ToString()
            LabelTotal.Text = Math.Round(total, 2).ToString()
            LabelInteres.Text = Math.Round(interesTotal, 2).ToString()
        Else
            MessageBox.Show("Por favor, selecciona un plazo válido.")
        End If
    End Sub

    'Private Sub AgregarPrestamo()
End Class
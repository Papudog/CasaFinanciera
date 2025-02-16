Imports CasaFinanciera.Application
Imports CasaFinanciera.Domain
Imports CasaFinanciera.Interfaces

Public Class FormPrestamoView
    Implements IForm

    Private ReadOnly Property _prestamoService As IPrestamoService
    Private ReadOnly Property _cliente As ICliente
    Private ReadOnly Property _plazosMeses As String() = {"6", "12", "18", "24"}
    Private Property _prestamo As IPrestamo
    Private ReadOnly Property _errorDictionary As New Dictionary(Of String, String) From {
        {"negativo", "El valor no puede ser menor que 0."},
        {"nan", "El valor ingresado debe ser numérico."},
        {"vacio", "El campo no puede estar vacío."},
        {"cliente", "El cliente no puede ser nulo."},
        {"plazoContains", "Digite un plazo válido (6, 12, 18, 24 meses)."},
        {"montoMayor", "El monto no puede superar el préstamo permitido."}
    }

    Sub New(cliente As ICliente, prestamoService As IPrestamoService)
        InitializeComponent()
        _prestamoService = prestamoService
        _cliente = cliente
    End Sub

    Private Sub PrestamoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboPrestamo.Items.AddRange(_plazosMeses)
        NumericPrestamo.Maximum = 1000000
        NumericPlazo.Maximum = 24

        LabelMonto.Text = _cliente.Prestamo.ToString()
        TextCliente.Text = _cliente.Nombre
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        If Not ValidarCampos() Then Return

        Dim monto As Decimal = NumericPrestamo.Value
        Dim plazoMeses As Integer = NumericPlazo.Value

        Dim cuota As Decimal = _prestamoService.CalcularCuota(monto, 3, plazoMeses)
        Dim total As Decimal = cuota * plazoMeses
        Dim interesTotal As Decimal = total - monto

        LabelCuota.Text = Math.Round(cuota, 2).ToString()
        LabelTotal.Text = Math.Round(total, 2).ToString()
        LabelInteres.Text = Math.Round(interesTotal, 2).ToString()

        _prestamo = New Prestamo With {
            .Cliente = _cliente,
            .InteresMensual = 3,
            .Monto = monto,
            .PlazoMeses = plazoMeses
        }

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If Not ValidarCampos() Then Return

        _cliente.HistorialCrediticio = True
        _prestamoService.AgregarPrestamo(_prestamo)
        MessageBox.Show("Cuota mensual: " & _prestamo.CuotaMensual & vbCrLf & "Total: " & _prestamo.Total & vbCrLf & "Interés total: " & _prestamo.InteresTotal)
        Me.Close()
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If _cliente Is Nothing OrElse String.IsNullOrWhiteSpace(_cliente.Nombre) Then
            ErrorProvider1.SetError(TextCliente, _errorDictionary("cliente"))
            Return False
        End If

        If String.IsNullOrWhiteSpace(NumericPrestamo.Text) Then
            ErrorProvider1.SetError(NumericPrestamo, _errorDictionary("vacio"))
            Return False
        End If

        Dim monto As Decimal
        If Not Decimal.TryParse(NumericPrestamo.Text, monto) Then
            ErrorProvider1.SetError(NumericPrestamo, _errorDictionary("nan"))
            Return False
        End If

        If monto <= 0 Then
            ErrorProvider1.SetError(NumericPrestamo, _errorDictionary("negativo"))
            Return False
        End If

        If monto > _cliente.Prestamo Then
            ErrorProvider1.SetError(NumericPrestamo, _errorDictionary("montoMayor"))
            Return False
        End If

        If NumericPlazo.Value <= 0 Then
            ErrorProvider1.SetError(NumericPlazo, _errorDictionary("negativo"))
            Return False
        End If

        If Not _plazosMeses.Contains(NumericPlazo.Value.ToString()) Then
            ErrorProvider1.SetError(NumericPlazo, _errorDictionary("plazoContains"))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos

    End Sub
End Class
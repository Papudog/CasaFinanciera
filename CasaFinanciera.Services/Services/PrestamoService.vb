Public Class PrestamoService
    Implements IPrestamoService

    Private ReadOnly Property _prestamos As ICollection(Of IPrestamo) = New List(Of IPrestamo)

    Public ReadOnly Property Prestamos As ICollection(Of IPrestamo) Implements IPrestamoService.Prestamos
        Get
            Return _prestamos
        End Get
    End Property

    Public Function CalcularCuota(prestamo As IPrestamo) As Decimal Implements IPrestamoService.CalcularCuota

    End Function

    Public Event OnPrestamoAgregado As Action(Of IPrestamo) Implements IPrestamoService.OnPrestamoAgregado

    Public Sub AgregarPrestamo(prestamo As IPrestamo) Implements IPrestamoService.AgregarPrestamo
        _prestamos.Add(prestamo)
    End Sub
End Class

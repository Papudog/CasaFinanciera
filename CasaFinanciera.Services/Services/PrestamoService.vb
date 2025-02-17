Imports CasaFinanciera.Interfaces
Public Class PrestamoService
    Implements IPrestamoService

    Private ReadOnly Property _prestamos As ICollection(Of IPrestamo) = New List(Of IPrestamo)

    Public ReadOnly Property Prestamos As ICollection(Of IPrestamo) Implements IPrestamoService.Prestamos
        Get
            Return _prestamos
        End Get
    End Property

    Public Function CalcularCuota(monto As Decimal, interesMensual As Decimal, plazoMeses As Integer) As Decimal Implements IPrestamoService.CalcularCuota
        Return (monto / plazoMeses) * ((interesMensual / 100) + 1)
    End Function

    Public Event OnPrestamoChanged As Action(Of IPrestamo) Implements IPrestamoService.OnPrestamoChanged

    Public Sub AgregarPrestamo(prestamo As IPrestamo) Implements IPrestamoService.AgregarPrestamo
        _prestamos.Add(prestamo)
        RaiseEvent OnPrestamoChanged(prestamo)
    End Sub
End Class

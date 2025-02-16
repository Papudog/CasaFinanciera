Public Interface IPrestamoService
    ReadOnly Property Prestamos As ICollection(Of IPrestamo)
    Sub AgregarPrestamo(prestamo As IPrestamo)
    Function CalcularCuota(monto As Decimal, interesMensual As Decimal, plazoMeses As Integer) As Decimal
    Event OnPrestamoAgregado As Action(Of IPrestamo)
End Interface

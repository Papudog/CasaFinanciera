Public Interface IPrestamoService
    ReadOnly Property Prestamos As ICollection(Of IPrestamo)
    Sub AgregarPrestamo(prestamo As IPrestamo)
    Function CalcularCuota(prestamo As IPrestamo) As Decimal
    Event OnPrestamoAgregado As Action(Of IPrestamo)
End Interface

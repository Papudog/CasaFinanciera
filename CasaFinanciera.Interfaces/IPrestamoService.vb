Imports System.Collections.ObjectModel

Public Interface IPrestamoService
    ReadOnly Property Prestamos As List(Of IPrestamo)
    Sub AgregarPrestamo(prestamo As IPrestamo)
    Sub EditarPrestamo(prestamo As IPrestamo)
    Function ObtenerPrestamosPor(parametro As String) As ICollection(Of IPrestamo)
    Function CalcularCuota(monto As Decimal, interesMensual As Decimal, plazoMeses As Integer) As Decimal
    Event OnPrestamoChanged As Action(Of IPrestamo)
End Interface

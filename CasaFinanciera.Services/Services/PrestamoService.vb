Imports System.Collections.ObjectModel
Imports System.Reflection.PortableExecutable
Imports CasaFinanciera.Domain
Imports CasaFinanciera.Interfaces
Public Class PrestamoService
    Implements IPrestamoService

    Private ReadOnly Property _prestamos As List(Of IPrestamo) = New List(Of IPrestamo)

    Public ReadOnly Property Prestamos As List(Of IPrestamo) Implements IPrestamoService.Prestamos
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

    Public Sub EditarPrestamo(prestamo As IPrestamo) Implements IPrestamoService.EditarPrestamo
        Dim indexPrestamo As Integer = _prestamos.FindIndex(Function(p As IPrestamo) p.Cliente.Correo = prestamo.Cliente.Correo)
        If indexPrestamo >= 0 Then
            _prestamos(indexPrestamo) = prestamo
            RaiseEvent OnPrestamoChanged(prestamo)
        End If
    End Sub

    Public Function ObtenerPrestamosPor(parametro As String) As ICollection(Of IPrestamo) Implements IPrestamoService.ObtenerPrestamosPor

        Dim resultado As IEnumerable(Of IPrestamo)

        Select Case parametro
            Case "Pagados"
                resultado = _prestamos.Where(Function(p As IPrestamo) p.EstaPagada = True)
            Case "NoPagados"
                resultado = _prestamos.Where(Function(p As IPrestamo) p.EstaPagada = False)
            Case Else
                resultado = _prestamos
        End Select

        Return resultado.ToList()
    End Function
End Class

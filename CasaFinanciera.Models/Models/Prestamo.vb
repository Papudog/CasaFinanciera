Imports CasaFinanciera.Application

Public Class Prestamo
    Implements IPrestamo

    Private Property _cliente As ICliente
    Private Property _monto As Decimal
    Private Property _interesMensual As Decimal = 0.03D
    Private Property _plazoMeses As Integer

    Public Property Cliente As ICliente Implements IPrestamo.Cliente
        Get
            Return _cliente
        End Get
        Set(ByVal value As ICliente)
            _cliente = value
        End Set
    End Property

    Public Property Monto As Decimal Implements IPrestamo.Monto
        Get
            Return _monto
        End Get
        Set(ByVal value As Decimal)
            _monto = value
        End Set
    End Property

    Public Property InteresMensual As Decimal Implements IPrestamo.InteresMensual
        Get
            Return _interesMensual
        End Get
        Set(ByVal value As Decimal)
            _interesMensual = value
        End Set
    End Property

    Public Property PlazoMeses As Integer Implements IPrestamo.PlazoMeses
        Get
            Return _plazoMeses
        End Get
        Set(ByVal value As Integer)
            _plazoMeses = value
        End Set
    End Property

    Public ReadOnly Property CuotaMensual As Decimal Implements IPrestamo.CuotaMensual
        Get
            Return (Monto * (1 + InteresMensual)) / PlazoMeses
        End Get
    End Property
End Class

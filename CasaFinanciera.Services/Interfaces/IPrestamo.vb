Public Interface IPrestamo
    Property Cliente As ICliente
    Property Monto As Decimal
    Property InteresMensual As Decimal
    Property PlazoMeses As Integer
    ReadOnly Property CuotaMensual As Decimal
End Interface

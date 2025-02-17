Public Interface IPrestamo
    Property Cliente As ICliente
    Property Monto As Decimal
    Property InteresMensual As Decimal
    Property PlazoMeses As Integer
    ReadOnly Property CuotaMensual As Decimal
    ReadOnly Property Total As Decimal
    ReadOnly Property InteresTotal As Decimal

    ReadOnly Property NombreCliente As String

End Interface

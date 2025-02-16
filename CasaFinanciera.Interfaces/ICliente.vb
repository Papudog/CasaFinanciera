Public Interface ICliente
    Property Nombre As String
    Property Direccion As String
    Property Telefono As String
    Property Correo As String
    Property TipoDocumento As String
    Property FechaNacimiento As Date
    Property EstadoCivil As String
    Property HistorialCrediticio As Boolean
    Property Salario As Decimal
    ReadOnly Property Prestamo As Decimal
End Interface

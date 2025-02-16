Imports CasaFinanciera.Interfaces

Public Class Cliente
    Implements ICliente

    Private Property _nombre As String
    Private Property _direccion As String
    Private Property _telefono As String
    Private Property _correo As String
    Private Property _tipoDocumento As String
    Private Property _fechaNacimiento As Date
    Private Property _estadoCivil As String
    Private Property _historialCrediticio As Boolean
    Private Property _salario As Decimal

    Public Property Nombre As String Implements ICliente.Nombre
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String Implements ICliente.Direccion
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As String Implements ICliente.Telefono
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String Implements ICliente.Correo
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property TipoDocumento As String Implements ICliente.TipoDocumento
        Get
            Return _tipoDocumento
        End Get
        Set(ByVal value As String)
            _tipoDocumento = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements ICliente.FechaNacimiento
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property EstadoCivil As String Implements ICliente.EstadoCivil
        Get
            Return _estadoCivil
        End Get
        Set(ByVal value As String)
            _estadoCivil = value
        End Set
    End Property

    Public Property HistorialCrediticio As Boolean Implements ICliente.HistorialCrediticio
        Get
            Return _historialCrediticio
        End Get
        Set(ByVal value As Boolean)
            _historialCrediticio = value
        End Set
    End Property

    Public Property Salario As Decimal Implements ICliente.Salario
        Get
            Return _salario
        End Get
        Set(ByVal value As Decimal)
            _salario = value
        End Set
    End Property

    Public ReadOnly Property Prestamo As Decimal Implements ICliente.Prestamo
        Get
            Dim porcertaje As Decimal = If(Salario > 20000, 0.75D, 0.5D)
            Return Salario * porcertaje
        End Get
    End Property
End Class
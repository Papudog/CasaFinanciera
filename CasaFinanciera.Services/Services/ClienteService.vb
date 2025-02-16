Imports CasaFinanciera.Interfaces
Imports CasaFinanciera.Domain

Public Class ClienteService
    Implements IClienteService

    Private Property _clientes As List(Of ICliente) = New List(Of ICliente) From {
        New Cliente With {
            .Nombre = "Juan Pérez",
            .Direccion = "Calle 123, Managua",
            .Telefono = "87654321",
            .Correo = "juan.perez@email.com",
            .TipoDocumento = "Cédula",
            .FechaNacimiento = #1990-05-15#,
            .EstadoCivil = "Soltero",
            .HistorialCrediticio = True,
            .Salario = 25000D
        },
        New Cliente With {
            .Nombre = "María Gómez",
            .Direccion = "Avenida Central, León",
            .Telefono = "76543210",
            .Correo = "maria.gomez@email.com",
            .TipoDocumento = "Pasaporte",
            .FechaNacimiento = #1985-10-20#,
            .EstadoCivil = "Casado",
            .HistorialCrediticio = False,
            .Salario = 18000D
        }
    }

    Public ReadOnly Property Clientes As List(Of ICliente) Implements IClienteService.Clientes
        Get
            Return _clientes
        End Get
    End Property

    Public Sub AgregarCliente(cliente As ICliente) Implements IClienteService.AgregarCliente
        _clientes.Add(cliente)
        RaiseEvent OnClienteChanged(cliente)
    End Sub

    Public Event OnClienteChanged As Action(Of ICliente) Implements IClienteService.OnClienteChanged

    Public Function ObtenerCliente(cliente As ICliente) As ICliente Implements IClienteService.ObtenerCliente
        Return _clientes.Find(Function(c As ICliente) c.Nombre = cliente.Nombre)
    End Function

    Public Sub EditarCliente(cliente As ICliente) Implements IClienteService.EditarCliente
        Dim indexCliente As Integer = _clientes.ToList().FindIndex(Function(c As ICliente) c.Correo = cliente.Correo)

        If indexCliente >= 0 Then
            _clientes(indexCliente) = cliente
            RaiseEvent OnClienteChanged(cliente)
        End If
    End Sub
End Class

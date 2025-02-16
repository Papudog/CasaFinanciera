Imports System.Reflection.Metadata.Ecma335

Public Class ClienteService
    Implements IClienteService

    Private Property _clientes As ICollection(Of ICliente) = New List(Of ICliente)

    Public Property Clientes As ICollection(Of ICliente) Implements IClienteService.Clientes
        Get
            Return _clientes
        End Get
        Set(value As ICollection(Of ICliente))
            _clientes = value
        End Set
    End Property

    Public Sub AgregarCliente(cliente As ICliente) Implements IClienteService.AgregarCliente
        _clientes.Add(cliente)
        RaiseEvent OnClienteAgregado(cliente)
    End Sub

    Public Event OnClienteAgregado As Action(Of ICliente) Implements IClienteService.OnClienteAgregado

    Public Function ObtenerCliente(cliente As ICliente) As ICliente Implements IClienteService.ObtenerCliente
        Return _clientes.ToList().Find(Function(c As ICliente) c.Nombre = cliente.Nombre)
    End Function
End Class

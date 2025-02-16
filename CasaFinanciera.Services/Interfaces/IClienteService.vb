Public Interface IClienteService
    Property Clientes As ICollection(Of ICliente)
    Function ObtenerCliente(cliente As ICliente) As ICliente
    Sub AgregarCliente(cliente As ICliente)
    Event OnClienteAgregado As Action(Of ICliente)
End Interface

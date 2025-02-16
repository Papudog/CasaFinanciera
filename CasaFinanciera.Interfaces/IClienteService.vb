Public Interface IClienteService
    ReadOnly Property Clientes As List(Of ICliente)
    Function ObtenerCliente(cliente As ICliente) As ICliente
    Sub AgregarCliente(cliente As ICliente)
    Sub EditarCliente(cliente As ICliente)
    Event OnClienteChanged As Action(Of ICliente)
End Interface

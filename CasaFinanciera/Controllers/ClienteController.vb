Imports CasaFinanciera.Application

Public Class ClienteController
    Private ReadOnly Property _clienteService As IClienteService
    Sub New(clienteService As IClienteService)
        _clienteService = clienteService
    End Sub

    Public Sub AgregarCliente(cliente As ICliente)
        _clienteService.AgregarCliente(cliente)
    End Sub
End Class

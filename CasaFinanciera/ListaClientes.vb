Imports CasaFinanciera.Application

Public Class ListaClientes
    Private ReadOnly Property _clienteService As IClienteService
    Sub New(clienteService As IClienteService)
        InitializeComponent()
        _clienteService = clienteService
        AddHandler clienteService.OnClienteAgregado, AddressOf OnClienteAgregado
    End Sub

    Private Sub OnClienteAgregado(cliente As ICliente)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        GridClientes.DataSource = Nothing
        GridClientes.DataSource = _clienteService.Clientes
    End Sub

    Private Sub GridClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellDoubleClick
        Dim data As ICliente = GridClientes.Rows(e.RowIndex).DataBoundItem

        Dim prestamoCliente As New PrestamoCliente(data, New PrestamoService)
        prestamoCliente.Show()
    End Sub
End Class
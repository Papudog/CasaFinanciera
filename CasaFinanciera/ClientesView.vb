Imports CasaFinanciera.Application
Imports CasaFinanciera.Interfaces

Public Class ClientesView
    Private ReadOnly Property _clienteService As IClienteService
    Sub New(clienteService As IClienteService)
        InitializeComponent()
        _clienteService = clienteService
        PopulateGrid()
        AddHandler clienteService.OnClienteChanged, AddressOf OnClienteChanged
    End Sub

    Private Sub OnClienteChanged(cliente As ICliente)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        GridClientes.DataSource = Nothing
        GridClientes.DataSource = _clienteService.Clientes
    End Sub

    Private Sub GridClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridClientes.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim cliente As ICliente = GridClientes.Rows(e.RowIndex).DataBoundItem

        Dim prestamoCliente As New FormPrestamoView(cliente, New PrestamoService)
        prestamoCliente.Show()
    End Sub
End Class
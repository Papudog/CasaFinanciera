Imports CasaFinanciera.Application
Imports CasaFinanciera.Interfaces

Public Class ClientesView
    Private ReadOnly Property _clienteService As IClienteService
    Private ReadOnly Property _prestamoService As IPrestamoService
    Sub New(clienteService As IClienteService, prestamoService As IPrestamoService)
        InitializeComponent()

        _clienteService = clienteService
        _prestamoService = prestamoService
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

        Dim prestamoCliente As New FormPrestamoView(cliente, _prestamoService) With {
            .MdiParent = MainView
        }
        prestamoCliente.Show()
    End Sub

    Private Sub ClientesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With GridClientes
            .AutoGenerateColumns = False
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Nombre",
                .HeaderText = "Nombre"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Direccion",
                .HeaderText = "Dirección"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Telefono",
                .HeaderText = "Teléfono"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Correo",
                .HeaderText = "Correo"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "TipoDocumento",
                .HeaderText = "Tipo de Documento"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "FechaNacimiento",
                .HeaderText = "Fecha de Nacimiento"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "EstadoCivil",
                .HeaderText = "Estado Civil"
            })
            .Columns.Add(New DataGridViewCheckBoxColumn With {
                .DataPropertyName = "HistorialCrediticio",
                .HeaderText = "¿Posee deuda?"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Salario",
                .HeaderText = "Salario"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Prestamo",
                .HeaderText = "Préstamo"
            })

            GridClientes.DataSource = _clienteService.Clientes
        End With
    End Sub
End Class
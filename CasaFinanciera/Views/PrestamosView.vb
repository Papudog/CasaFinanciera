Imports CasaFinanciera.Domain
Imports CasaFinanciera.Interfaces

Public Class PrestamosView
    Private ReadOnly Property _prestamoService As IPrestamoService
    Private ReadOnly Property _clienteService As IClienteService

    Sub New(prestamoService As IPrestamoService, clienteService As IClienteService)
        InitializeComponent()

        _prestamoService = prestamoService
        _clienteService = clienteService
        AddHandler prestamoService.OnPrestamoChanged, AddressOf OnPrestamoChanged
    End Sub

    Private Sub OnPrestamoChanged(prestamo As IPrestamo)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        PrestamosGrid.DataSource = Nothing
        PrestamosGrid.DataSource = _prestamoService.ObtenerPrestamosPor("NoPagados")
    End Sub

    Private Sub PrestamosView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With PrestamosGrid
            .AutoGenerateColumns = False
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "NombreCliente",
                .HeaderText = "Nombre del Cliente"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Monto",
                .HeaderText = "Monto"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "InteresMensual",
                .HeaderText = "Interés Mensual (%)"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "PlazoMeses",
                .HeaderText = "Plazo (Meses)"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "CuotaMensual",
                .HeaderText = "Cuota Mensual"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "Total",
                .HeaderText = "Total"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .DataPropertyName = "InteresTotal",
                .HeaderText = "Interés Total"
            })
            PrestamosGrid.DataSource = _prestamoService.ObtenerPrestamosPor("NoPagados")
        End With
    End Sub

    Private Sub PrestamosGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PrestamosGrid.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim prestamo As IPrestamo = PrestamosGrid.Rows(e.RowIndex).DataBoundItem
        Dim liquidacionCliente As New FormLiquidacion(prestamo, _prestamoService, _clienteService) With {
            .MdiParent = MainView
        }
        liquidacionCliente.Show()
    End Sub
End Class

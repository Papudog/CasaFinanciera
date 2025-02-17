Imports CasaFinanciera.Interfaces

Public Class PrestamosView
    Private ReadOnly Property _prestamoService As IPrestamoService

    Sub New(prestamoService As IPrestamoService)
        InitializeComponent()

        _prestamoService = prestamoService
        AddHandler prestamoService.OnPrestamoChanged, AddressOf OnPrestamoAgregado
    End Sub

    Private Sub OnPrestamoAgregado(prestamo As IPrestamo)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        PrestamosGrid.DataSource = Nothing
        PrestamosGrid.DataSource = _prestamoService.Prestamos
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
            PrestamosGrid.DataSource = _prestamoService.Prestamos
        End With
    End Sub
End Class

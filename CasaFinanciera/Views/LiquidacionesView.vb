Imports CasaFinanciera.Interfaces

Public Class LiquidacionesView
    Private ReadOnly Property _prestamoService As IPrestamoService
    Sub New(prestamoService As IPrestamoService)
        InitializeComponent()

        _prestamoService = prestamoService

        AddHandler prestamoService.OnPrestamoChanged, AddressOf OnPrestamoChanged
    End Sub

    Private Sub OnPrestamoChanged(prestamo As IPrestamo)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        DataGridLiquidaciones.DataSource = Nothing
        DataGridLiquidaciones.DataSource = _prestamoService.ObtenerPrestamosPor("Pagados")
    End Sub

    Private Sub LiquidacionesView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridLiquidaciones
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
            DataGridLiquidaciones.DataSource = _prestamoService.ObtenerPrestamosPor("Pagados")
        End With
    End Sub
End Class
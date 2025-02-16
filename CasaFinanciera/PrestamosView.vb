Imports CasaFinanciera.Interfaces

Public Class PrestamosView
    Private ReadOnly Property _prestamoService As IPrestamoService

    Sub New(prestamoService As IPrestamoService)
        InitializeComponent()

        _prestamoService = prestamoService
        AddHandler prestamoService.OnPrestamoAgregado, AddressOf OnPrestamoAgregado
        PopulateGrid()
    End Sub

    Private Sub OnPrestamoAgregado(prestamo As IPrestamo)
        PopulateGrid()
    End Sub

    Private Sub PopulateGrid()
        PrestamosGrid.DataSource = Nothing
        PrestamosGrid.DataSource = _prestamoService.Prestamos
    End Sub
End Class

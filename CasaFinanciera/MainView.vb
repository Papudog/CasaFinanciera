Imports CasaFinanciera.Application

Public Class MainView

    Private Property _clienteService As New ClienteService
    Private Property _prestamoService As New PrestamoService


    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListaClientes()
    End Sub

    Private Sub DatosMenuItem_Click(sender As Object, e As EventArgs) Handles DatosMenuItem.Click
        Dim datos As New FormClienteView(_clienteService) With {
            .MdiParent = Me
        }
        datos.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        LoadListaClientes()
    End Sub

    Private Sub LoadListaClientes()
        Dim lista As New ClientesView(_clienteService) With {
            .MdiParent = Me
        }
        lista.Show()
    End Sub

    Private Sub AdministrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarToolStripMenuItem.Click
        Dim vistaPrestamos As New PrestamosView(_prestamoService) With {
            .MdiParent = Me
        }
    End Sub
End Class

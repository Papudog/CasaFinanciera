Imports CasaFinanciera.Application

Public Class MainWindow

    Private Property _clienteService As New ClienteService
    Private Property _prestamoService As New PrestamoService


    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListaClientes()
    End Sub

    Private Sub DatosMenuItem_Click(sender As Object, e As EventArgs) Handles DatosMenuItem.Click
        Dim datos As New DatosCliente(_clienteService) With {
            .MdiParent = Me
        }
        datos.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        LoadListaClientes()
    End Sub

    Private Sub LoadListaClientes()
        Dim lista As New ListaClientes(_clienteService) With {
            .MdiParent = Me
        }
        lista.Show()
    End Sub
End Class

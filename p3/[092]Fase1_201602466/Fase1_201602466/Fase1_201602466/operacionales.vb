Public Class operacionales
    Private Sub listaclientesv_Click(sender As Object, e As EventArgs) Handles listaclientesv.Click
        Me.Close()
        listaclientes.Show()
    End Sub

    Private Sub cambiarcontrav_Click(sender As Object, e As EventArgs) Handles cambiarcontrav.Click
        operacionalcontraseña.Show()
        Me.Close()
    End Sub

    Private Sub cerrarseisionv_Click(sender As Object, e As EventArgs) Handles cerrarseisionv.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub nuevoclientev_Click(sender As Object, e As EventArgs) Handles nuevoclientev.Click
        nuevocliente.Show()
        Me.Close()
    End Sub

    Private Sub ventas_Click(sender As Object, e As EventArgs) Handles venta.Click
        ventas.Show()
        Me.Close()
    End Sub
End Class
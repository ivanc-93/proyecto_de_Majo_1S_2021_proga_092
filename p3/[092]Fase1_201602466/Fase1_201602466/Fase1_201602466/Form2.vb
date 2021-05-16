Public Class administradores
    Private Sub cerrar1_Click(sender As Object, e As EventArgs) Handles cerrar1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub reportesb_Click(sender As Object, e As EventArgs) Handles reportesb.Click
        Me.Close()
        reportes.Show()
    End Sub

    Private Sub nuevop_Click(sender As Object, e As EventArgs) Handles nuevop.Click
        Me.Close()
        nuevoproducto.Show()
    End Sub

    Private Sub nuevoe_Click(sender As Object, e As EventArgs) Handles nuevoe.Click
        Me.Close()
        nuevoempleado.Show()
    End Sub

    Private Sub cambiarcontr_Click(sender As Object, e As EventArgs) Handles cambiarcontr.Click
        Me.Close()
        cambiocontraseña.Show()
    End Sub
End Class
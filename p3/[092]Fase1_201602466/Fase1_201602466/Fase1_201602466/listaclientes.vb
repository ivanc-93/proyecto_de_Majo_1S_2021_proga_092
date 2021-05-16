Public Class listaclientes
    Private Sub cerrarlista_Click(sender As Object, e As EventArgs) Handles cerrarlista.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub regresarlista_Click(sender As Object, e As EventArgs) Handles regresarlista.Click
        Me.Close()
        operacionales.Show()
    End Sub
End Class
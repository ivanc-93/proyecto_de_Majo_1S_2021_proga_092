Public Class operacionalcontraseña
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        operacionales.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nuevacontra.Text <> confirmarcontra.Text Then
            MsgBox("¡ERROR!" + Chr(13) + Chr(10) + "Su cambio de contraseña no coincide con la confirmación", MsgBoxStyle.Exclamation)
        ElseIf nuevacontra.Text = confirmarcontra.Text Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class
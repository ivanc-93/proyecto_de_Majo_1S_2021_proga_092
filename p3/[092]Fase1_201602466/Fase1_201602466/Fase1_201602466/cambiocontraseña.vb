Public Class cambiocontraseña
    Private Sub cambiarcontracc_Click(sender As Object, e As EventArgs) Handles cambiarcontracc.Click
        If ncontraseñacc.Text <> ccontraseñacc.Text Then
            MsgBox("¡ERROR!" + Chr(13) + Chr(10) + " No conincide la nueva contraseña con la confirmación", MsgBoxStyle.Exclamation)
        ElseIf ncontraseñacc.Text = ccontraseñacc.Text Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub cerrar5_Click(sender As Object, e As EventArgs) Handles cerrar5.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub regresar4_Click(sender As Object, e As EventArgs) Handles regresar4.Click
        Me.Close()
        administradores.Show()
    End Sub
End Class
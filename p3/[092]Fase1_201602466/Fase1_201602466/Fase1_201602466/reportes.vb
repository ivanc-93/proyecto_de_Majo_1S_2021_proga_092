Public Class reportes
    Private Sub cerrar2_Click(sender As Object, e As EventArgs) Handles cerrar2.Click
        If MsgBox("Desea cerrar su sesión", vbYesNo) = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub regresar1_Click(sender As Object, e As EventArgs) Handles regresar1.Click
        Me.Close()
        administradores.Show()
    End Sub
End Class
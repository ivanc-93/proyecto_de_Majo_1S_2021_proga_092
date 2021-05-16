Public Class nuevoproducto
    Private Sub crearnv_Click(sender As Object, e As EventArgs) Handles crearnv.Click
        If MsgBox("¿Desea crear este nuevo producto?", vbYesNo) = vbYes Then
            DataGridView1.Rows.Add(codigonv.Text, nombrenv.Text, descripcionnv.Text, NumericUpDown1.Value)
            codigonv.Clear()
            nombrenv.Clear()
            descripcionnv.Clear()
            NumericUpDown1.ResetText()
        End If
    End Sub

    Private Sub cerrar3_Click(sender As Object, e As EventArgs) Handles cerrar3.Click
        If MsgBox("¿Desea cerrar sesión?", vbYesNo) Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub regresar2_Click(sender As Object, e As EventArgs) Handles regresar2.Click
        Me.Close()
        administradores.Show()
    End Sub
End Class
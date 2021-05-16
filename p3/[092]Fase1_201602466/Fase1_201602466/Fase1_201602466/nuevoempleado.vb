Public Class nuevoempleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tipoemplado As String
        tipoemplado = "No"
        If contraseñane.Text = confirmacionne.Text Then
            If MsgBox("¿Desea agregar un nuevo empleado?", vbYesNo) = vbYes Then
                If administradorne.Checked Then
                    tipoemplado = "Si"
                End If
                DataGridView1.Rows.Add(cuine.Text, nombrene.Text, telefonone.Text, fechanacne.Text, correone.Text, tipoemplado)
            End If
            cuine.Clear()
            nombrene.Clear()
            telefonone.Clear()
            fechanacne.Clear()
            correone.Clear()
            contraseñane.Clear()
            confirmacionne.Clear()
            administradorne.Checked = False
        End If
    End Sub

    Private Sub cerrar4_Click(sender As Object, e As EventArgs) Handles cerrar4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub regresar3_Click(sender As Object, e As EventArgs) Handles regresar3.Click
        Me.Close()
        administradores.Show()
    End Sub
End Class
Public Class nuevocliente
    Private Sub regresar_nc_Click(sender As Object, e As EventArgs) Handles regresar_nc.Click
        Me.Close()
        operacionales.Show()
    End Sub

    Private Sub cerrar_nc_Click(sender As Object, e As EventArgs) Handles cerrar_nc.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub crearcliente_nc_Click(sender As Object, e As EventArgs) Handles crearcliente_nc.Click
        If MsgBox("¿Desea agregar un nuevo cliente?", vbOKCancel) = vbOK Then
            DataGridView1.Rows.Add(nitnc.Text, nombrenc.Text, telefono_nc.Text, fechanacimiento_nc.Text, correonc.Text, direccion_nc.Text)
            nitnc.Clear()
            nombrenc.Clear()
            correonc.Clear()
            telefono_nc.Clear()
            fechanacimiento_nc.Clear()
            direccion_nc.Clear()
        End If
    End Sub
End Class
Public Class ventas
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        operacionales.Show()
    End Sub
    Private Sub ventas_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecha_rv.Text = Date.Today
    End Sub

    Private Sub productorv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productorv.SelectedIndexChanged
        If productorv.Text = "Shampoo" Then
            precio_rv.Text = "45.00"
        ElseIf productorv.Text = "Cartón de huevos" Then
            precio_rv.Text = "35.00"
        ElseIf productorv.Text = "Leche" Then
            precio_rv.Text = "12.50"
        ElseIf productorv.Text = "Arroz blanco" Then
            precio_rv.Text = "4.50"
        ElseIf productorv.Text = "Detergente" Then
            precio_rv.Text = "8.50"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double
        Dim cantidad As Double
        cantidad = Val(cantidadrv.Value)
        total = cantidad * precio_rv.Text
        DataGridView1.Rows.Add("codigo", productorv.Text, cantidadrv.Value, total)
        productorv.ResetText()
        cantidadrv.ResetText()
        precio_rv.Clear()
    End Sub

    Private Sub efectivo_rv_CheckedChanged(sender As Object, e As EventArgs) Handles efectivo_rv.CheckedChanged
        Label6.Show()
        montorv.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cantidadtotal As Integer
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            cantidadtotal += Val(row.Cells(2).Value)
        Next

        Dim totalventa As Double
        For Each row As DataGridViewRow In Me.DataGridView1.Rows
            totalventa += Val(row.Cells(3).Value)
        Next

        If MsgBox("RESUMEN DE VENTA" + Chr(13) + Chr(10) + "" + Chr(13) + Chr(10) + "Cliente: " & cliente_rv.Text + Chr(13) + Chr(10) + "Fecha: " & fecha_rv.Text + Chr(13) + Chr(10) + "Cantidad de productos: " & cantidadtotal & Chr(13) + Chr(10) + "Total:  Q. " & totalventa, vbOKCancel) = vbOK Then
            If efectivo_rv.Checked Then
                Dim monto As Double
                Dim diferencia As Double
                monto = montorv.Value
                diferencia = Math.Abs(totalventa - monto)
                If monto > totalventa Then
                    If MsgBox("Total:  Q. " & totalventa & Chr(13) + Chr(10) + "Pago:  Q. " & monto & Chr(13) + Chr(10) + "Se debe dar cambio  Q. " & diferencia, vbOKCancel) = vbOK Then
                        MsgBox("¡Se realizó la venta!")
                        Me.Close()
                        operacionales.Show()
                    End If
                ElseIf monto = totalventa Then
                    MsgBox("¡Se realizó la venta!")
                    Me.Close()
                    operacionales.Show()
                ElseIf monto < totalventa Then
                    MsgBox("Total:  Q. " & totalventa & Chr(13) + Chr(10) + "Pago:  Q. " & monto & Chr(13) + Chr(10) + "¡EL PAGO ES MENOR AL MONTO TOTAL FACTURADO!", MsgBoxStyle.Critical)
                End If
            End If
            If cheque_rv.Checked Or tarjeta_rv.Checked Then
                MsgBox("¡Se realizó la venta!")
                Me.Close()
                operacionales.Show()
            End If
        End If
    End Sub
End Class
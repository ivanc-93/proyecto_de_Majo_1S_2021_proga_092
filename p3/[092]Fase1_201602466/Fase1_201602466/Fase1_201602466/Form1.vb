Public Class Form1
    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        If correo.Text = "admin" And contraseña.Text = "admin" Then
            administradores.Show()
            Me.Hide()
            administradores.Label2.Text = correo.Text
            correo.Clear()
            contraseña.Clear()
        ElseIf correo.Text = "empleado" And contraseña.Text = "empleado" Then
            operacionales.Show()
            Me.Hide()
            ventas.Label2.Text = correo.Text
            correo.Clear()
            contraseña.Clear()
        Else
            MsgBox("Credenciales incorrectas", MsgBoxStyle.Exclamation)
            correo.Clear()
            contraseña.Clear()
        End If
    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class operacionalcontraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.antigua = New System.Windows.Forms.TextBox()
        Me.nuevacontra = New System.Windows.Forms.TextBox()
        Me.confirmarcontra = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antigua contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nueva contraseña"
        '
        'antigua
        '
        Me.antigua.Location = New System.Drawing.Point(60, 83)
        Me.antigua.Name = "antigua"
        Me.antigua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.antigua.Size = New System.Drawing.Size(100, 20)
        Me.antigua.TabIndex = 3
        '
        'nuevacontra
        '
        Me.nuevacontra.Location = New System.Drawing.Point(60, 145)
        Me.nuevacontra.Name = "nuevacontra"
        Me.nuevacontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.nuevacontra.Size = New System.Drawing.Size(100, 20)
        Me.nuevacontra.TabIndex = 4
        '
        'confirmarcontra
        '
        Me.confirmarcontra.Location = New System.Drawing.Point(203, 145)
        Me.confirmarcontra.Name = "confirmarcontra"
        Me.confirmarcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmarcontra.Size = New System.Drawing.Size(100, 20)
        Me.confirmarcontra.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cambiar contraseña"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(60, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(243, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cerrar sesión"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'operacionalcontraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 341)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirmarcontra)
        Me.Controls.Add(Me.nuevacontra)
        Me.Controls.Add(Me.antigua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "operacionalcontraseña"
        Me.Text = "CAMBIAR CONTRASEÑA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents antigua As TextBox
    Friend WithEvents nuevacontra As TextBox
    Friend WithEvents confirmarcontra As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

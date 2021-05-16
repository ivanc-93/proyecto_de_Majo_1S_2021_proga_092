<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiocontraseña
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
        Me.vcontraseñacc = New System.Windows.Forms.TextBox()
        Me.ncontraseñacc = New System.Windows.Forms.TextBox()
        Me.ccontraseñacc = New System.Windows.Forms.TextBox()
        Me.cambiarcontracc = New System.Windows.Forms.Button()
        Me.regresar4 = New System.Windows.Forms.Button()
        Me.cerrar5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Antigua contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva contraseña"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(193, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nueva contraseña"
        '
        'vcontraseñacc
        '
        Me.vcontraseñacc.Location = New System.Drawing.Point(36, 75)
        Me.vcontraseñacc.Name = "vcontraseñacc"
        Me.vcontraseñacc.Size = New System.Drawing.Size(100, 20)
        Me.vcontraseñacc.TabIndex = 3
        '
        'ncontraseñacc
        '
        Me.ncontraseñacc.Location = New System.Drawing.Point(36, 153)
        Me.ncontraseñacc.Name = "ncontraseñacc"
        Me.ncontraseñacc.Size = New System.Drawing.Size(100, 20)
        Me.ncontraseñacc.TabIndex = 4
        '
        'ccontraseñacc
        '
        Me.ccontraseñacc.Location = New System.Drawing.Point(196, 153)
        Me.ccontraseñacc.Name = "ccontraseñacc"
        Me.ccontraseñacc.Size = New System.Drawing.Size(100, 20)
        Me.ccontraseñacc.TabIndex = 5
        '
        'cambiarcontracc
        '
        Me.cambiarcontracc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambiarcontracc.Location = New System.Drawing.Point(36, 197)
        Me.cambiarcontracc.Name = "cambiarcontracc"
        Me.cambiarcontracc.Size = New System.Drawing.Size(263, 33)
        Me.cambiarcontracc.TabIndex = 6
        Me.cambiarcontracc.Text = "Cambiar contraseña"
        Me.cambiarcontracc.UseVisualStyleBackColor = True
        '
        'regresar4
        '
        Me.regresar4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar4.Location = New System.Drawing.Point(196, 277)
        Me.regresar4.Name = "regresar4"
        Me.regresar4.Size = New System.Drawing.Size(103, 23)
        Me.regresar4.TabIndex = 22
        Me.regresar4.Text = "Regresar"
        Me.regresar4.UseVisualStyleBackColor = True
        '
        'cerrar5
        '
        Me.cerrar5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar5.Location = New System.Drawing.Point(196, 248)
        Me.cerrar5.Name = "cerrar5"
        Me.cerrar5.Size = New System.Drawing.Size(103, 23)
        Me.cerrar5.TabIndex = 21
        Me.cerrar5.Text = "Cerrar sesión"
        Me.cerrar5.UseVisualStyleBackColor = True
        '
        'cambiocontraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 342)
        Me.Controls.Add(Me.regresar4)
        Me.Controls.Add(Me.cerrar5)
        Me.Controls.Add(Me.cambiarcontracc)
        Me.Controls.Add(Me.ccontraseñacc)
        Me.Controls.Add(Me.ncontraseñacc)
        Me.Controls.Add(Me.vcontraseñacc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cambiocontraseña"
        Me.Text = "CAMBIAR CONTRASEÑA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents vcontraseñacc As TextBox
    Friend WithEvents ncontraseñacc As TextBox
    Friend WithEvents ccontraseñacc As TextBox
    Friend WithEvents cambiarcontracc As Button
    Friend WithEvents regresar4 As Button
    Friend WithEvents cerrar5 As Button
End Class

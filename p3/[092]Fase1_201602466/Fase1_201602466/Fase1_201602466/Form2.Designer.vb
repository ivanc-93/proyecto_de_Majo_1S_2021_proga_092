<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class administradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administradores))
        Me.reportesb = New System.Windows.Forms.Button()
        Me.nuevop = New System.Windows.Forms.Button()
        Me.nuevoe = New System.Windows.Forms.Button()
        Me.cerrar1 = New System.Windows.Forms.Button()
        Me.cambiarcontr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportesb
        '
        Me.reportesb.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.reportesb.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportesb.Location = New System.Drawing.Point(330, 104)
        Me.reportesb.Name = "reportesb"
        Me.reportesb.Size = New System.Drawing.Size(280, 49)
        Me.reportesb.TabIndex = 0
        Me.reportesb.Text = "Reportes"
        Me.reportesb.UseVisualStyleBackColor = False
        '
        'nuevop
        '
        Me.nuevop.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.nuevop.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevop.Location = New System.Drawing.Point(330, 161)
        Me.nuevop.Name = "nuevop"
        Me.nuevop.Size = New System.Drawing.Size(277, 49)
        Me.nuevop.TabIndex = 1
        Me.nuevop.Text = "Nuevo producto"
        Me.nuevop.UseVisualStyleBackColor = False
        '
        'nuevoe
        '
        Me.nuevoe.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.nuevoe.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoe.Location = New System.Drawing.Point(330, 217)
        Me.nuevoe.Name = "nuevoe"
        Me.nuevoe.Size = New System.Drawing.Size(277, 49)
        Me.nuevoe.TabIndex = 2
        Me.nuevoe.Text = "Nuevo empleado"
        Me.nuevoe.UseVisualStyleBackColor = False
        '
        'cerrar1
        '
        Me.cerrar1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cerrar1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cerrar1.Location = New System.Drawing.Point(171, 334)
        Me.cerrar1.Name = "cerrar1"
        Me.cerrar1.Size = New System.Drawing.Size(261, 30)
        Me.cerrar1.TabIndex = 3
        Me.cerrar1.Text = "Cerrar sesión"
        Me.cerrar1.UseVisualStyleBackColor = False
        '
        'cambiarcontr
        '
        Me.cambiarcontr.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cambiarcontr.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambiarcontr.Location = New System.Drawing.Point(438, 334)
        Me.cambiarcontr.Name = "cambiarcontr"
        Me.cambiarcontr.Size = New System.Drawing.Size(261, 30)
        Me.cambiarcontr.TabIndex = 4
        Me.cambiarcontr.Text = "Cambiar contraseña"
        Me.cambiarcontr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(550, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 35)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "¡BIENVENIDO!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 304)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'administradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cambiarcontr)
        Me.Controls.Add(Me.cerrar1)
        Me.Controls.Add(Me.nuevoe)
        Me.Controls.Add(Me.nuevop)
        Me.Controls.Add(Me.reportesb)
        Me.Name = "administradores"
        Me.Text = "ADMINISTRADORES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reportesb As Button
    Friend WithEvents nuevop As Button
    Friend WithEvents nuevoe As Button
    Friend WithEvents cerrar1 As Button
    Friend WithEvents cambiarcontr As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

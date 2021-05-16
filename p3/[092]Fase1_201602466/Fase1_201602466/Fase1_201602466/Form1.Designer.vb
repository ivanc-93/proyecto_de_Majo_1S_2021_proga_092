<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ingresar = New System.Windows.Forms.Button()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 455)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo electrónico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 489)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'ingresar
        '
        Me.ingresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ingresar.Location = New System.Drawing.Point(464, 462)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(107, 35)
        Me.ingresar.TabIndex = 2
        Me.ingresar.Text = "INGRESAR"
        Me.ingresar.UseVisualStyleBackColor = False
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(269, 458)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(100, 20)
        Me.correo.TabIndex = 3
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(269, 491)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña.Size = New System.Drawing.Size(100, 20)
        Me.contraseña.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(710, 381)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(695, 586)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.correo)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "LOG IN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ingresar As Button
    Friend WithEvents correo As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

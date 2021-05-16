<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class operacionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(operacionales))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.venta = New System.Windows.Forms.Button()
        Me.nuevoclientev = New System.Windows.Forms.Button()
        Me.listaclientesv = New System.Windows.Forms.Button()
        Me.cerrarseisionv = New System.Windows.Forms.Button()
        Me.cambiarcontrav = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "¡BIENVENIDO!"
        '
        'venta
        '
        Me.venta.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.venta.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.venta.Location = New System.Drawing.Point(68, 111)
        Me.venta.Name = "venta"
        Me.venta.Size = New System.Drawing.Size(212, 50)
        Me.venta.TabIndex = 9
        Me.venta.Text = "Ventas"
        Me.venta.UseVisualStyleBackColor = False
        '
        'nuevoclientev
        '
        Me.nuevoclientev.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nuevoclientev.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevoclientev.Location = New System.Drawing.Point(68, 179)
        Me.nuevoclientev.Name = "nuevoclientev"
        Me.nuevoclientev.Size = New System.Drawing.Size(212, 50)
        Me.nuevoclientev.TabIndex = 10
        Me.nuevoclientev.Text = "Nuevo cliente"
        Me.nuevoclientev.UseVisualStyleBackColor = False
        '
        'listaclientesv
        '
        Me.listaclientesv.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.listaclientesv.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaclientesv.Location = New System.Drawing.Point(68, 249)
        Me.listaclientesv.Name = "listaclientesv"
        Me.listaclientesv.Size = New System.Drawing.Size(212, 50)
        Me.listaclientesv.TabIndex = 11
        Me.listaclientesv.Text = "Lista de clientes"
        Me.listaclientesv.UseVisualStyleBackColor = False
        '
        'cerrarseisionv
        '
        Me.cerrarseisionv.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cerrarseisionv.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrarseisionv.Location = New System.Drawing.Point(123, 345)
        Me.cerrarseisionv.Name = "cerrarseisionv"
        Me.cerrarseisionv.Size = New System.Drawing.Size(191, 27)
        Me.cerrarseisionv.TabIndex = 12
        Me.cerrarseisionv.Text = "Cerrar sesión"
        Me.cerrarseisionv.UseVisualStyleBackColor = False
        '
        'cambiarcontrav
        '
        Me.cambiarcontrav.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cambiarcontrav.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cambiarcontrav.Location = New System.Drawing.Point(349, 345)
        Me.cambiarcontrav.Name = "cambiarcontrav"
        Me.cambiarcontrav.Size = New System.Drawing.Size(191, 27)
        Me.cambiarcontrav.TabIndex = 13
        Me.cambiarcontrav.Text = "Cambiar contraseña"
        Me.cambiarcontrav.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(349, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 297)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'operacionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cambiarcontrav)
        Me.Controls.Add(Me.cerrarseisionv)
        Me.Controls.Add(Me.listaclientesv)
        Me.Controls.Add(Me.nuevoclientev)
        Me.Controls.Add(Me.venta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "operacionales"
        Me.Text = "Ventas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents venta As Button
    Friend WithEvents nuevoclientev As Button
    Friend WithEvents listaclientesv As Button
    Friend WithEvents cerrarseisionv As Button
    Friend WithEvents cambiarcontrav As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

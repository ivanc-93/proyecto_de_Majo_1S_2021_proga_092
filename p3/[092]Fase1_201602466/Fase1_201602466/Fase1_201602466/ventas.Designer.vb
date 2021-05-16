<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
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
        Me.cliente_rv = New System.Windows.Forms.TextBox()
        Me.fecha_rv = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.precio_rv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cantidadrv = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.productorv = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo_rv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.producto_rv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad_rv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_rv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.montorv = New System.Windows.Forms.NumericUpDown()
        Me.cheque_rv = New System.Windows.Forms.RadioButton()
        Me.tarjeta_rv = New System.Windows.Forms.RadioButton()
        Me.efectivo_rv = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cantidadrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.montorv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'cliente_rv
        '
        Me.cliente_rv.Location = New System.Drawing.Point(112, 28)
        Me.cliente_rv.MaxLength = 8
        Me.cliente_rv.Name = "cliente_rv"
        Me.cliente_rv.Size = New System.Drawing.Size(100, 20)
        Me.cliente_rv.TabIndex = 2
        '
        'fecha_rv
        '
        Me.fecha_rv.Location = New System.Drawing.Point(416, 28)
        Me.fecha_rv.Name = "fecha_rv"
        Me.fecha_rv.ReadOnly = True
        Me.fecha_rv.Size = New System.Drawing.Size(100, 20)
        Me.fecha_rv.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.precio_rv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cantidadrv)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.productorv)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 103)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'precio_rv
        '
        Me.precio_rv.Location = New System.Drawing.Point(321, 52)
        Me.precio_rv.Name = "precio_rv"
        Me.precio_rv.ReadOnly = True
        Me.precio_rv.Size = New System.Drawing.Size(100, 20)
        Me.precio_rv.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Precio unitario"
        '
        'cantidadrv
        '
        Me.cantidadrv.Location = New System.Drawing.Point(52, 75)
        Me.cantidadrv.Name = "cantidadrv"
        Me.cantidadrv.Size = New System.Drawing.Size(120, 20)
        Me.cantidadrv.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cantidad"
        '
        'productorv
        '
        Me.productorv.FormattingEnabled = True
        Me.productorv.Items.AddRange(New Object() {"Shampoo", "Leche", "Cartón de huevos", "Arroz blanco", "Detergente"})
        Me.productorv.Location = New System.Drawing.Point(53, 23)
        Me.productorv.Name = "productorv"
        Me.productorv.Size = New System.Drawing.Size(121, 21)
        Me.productorv.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Producto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MintCream
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(161, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar producto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_rv, Me.producto_rv, Me.cantidad_rv, Me.total_rv})
        Me.DataGridView1.Location = New System.Drawing.Point(70, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'codigo_rv
        '
        Me.codigo_rv.HeaderText = "Código"
        Me.codigo_rv.Name = "codigo_rv"
        '
        'producto_rv
        '
        Me.producto_rv.HeaderText = "Producto"
        Me.producto_rv.Name = "producto_rv"
        '
        'cantidad_rv
        '
        Me.cantidad_rv.HeaderText = "Cantidad"
        Me.cantidad_rv.Name = "cantidad_rv"
        '
        'total_rv
        '
        Me.total_rv.HeaderText = "Total Q."
        Me.total_rv.Name = "total_rv"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.montorv)
        Me.GroupBox2.Controls.Add(Me.cheque_rv)
        Me.GroupBox2.Controls.Add(Me.tarjeta_rv)
        Me.GroupBox2.Controls.Add(Me.efectivo_rv)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método de pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Monto"
        Me.Label6.Visible = False
        '
        'montorv
        '
        Me.montorv.DecimalPlaces = 2
        Me.montorv.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.montorv.Location = New System.Drawing.Point(194, 51)
        Me.montorv.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.montorv.Name = "montorv"
        Me.montorv.Size = New System.Drawing.Size(120, 20)
        Me.montorv.TabIndex = 3
        Me.montorv.Visible = False
        '
        'cheque_rv
        '
        Me.cheque_rv.AutoSize = True
        Me.cheque_rv.Location = New System.Drawing.Point(68, 71)
        Me.cheque_rv.Name = "cheque_rv"
        Me.cheque_rv.Size = New System.Drawing.Size(62, 17)
        Me.cheque_rv.TabIndex = 2
        Me.cheque_rv.TabStop = True
        Me.cheque_rv.Text = "Cheque"
        Me.cheque_rv.UseVisualStyleBackColor = True
        '
        'tarjeta_rv
        '
        Me.tarjeta_rv.AutoSize = True
        Me.tarjeta_rv.Location = New System.Drawing.Point(68, 48)
        Me.tarjeta_rv.Name = "tarjeta_rv"
        Me.tarjeta_rv.Size = New System.Drawing.Size(58, 17)
        Me.tarjeta_rv.TabIndex = 1
        Me.tarjeta_rv.TabStop = True
        Me.tarjeta_rv.Text = "Tarjeta"
        Me.tarjeta_rv.UseVisualStyleBackColor = True
        '
        'efectivo_rv
        '
        Me.efectivo_rv.AutoSize = True
        Me.efectivo_rv.Location = New System.Drawing.Point(68, 25)
        Me.efectivo_rv.Name = "efectivo_rv"
        Me.efectivo_rv.Size = New System.Drawing.Size(64, 17)
        Me.efectivo_rv.TabIndex = 0
        Me.efectivo_rv.TabStop = True
        Me.efectivo_rv.Text = "Efectivo"
        Me.efectivo_rv.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Honeydew
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(366, 520)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 30)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Realizar compra"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Honeydew
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(366, 556)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 30)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Honeydew
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(366, 592)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Cerrar sesión"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(593, 646)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fecha_rv)
        Me.Controls.Add(Me.cliente_rv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ventas"
        Me.Text = "REALIZAR VENTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cantidadrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.montorv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cliente_rv As TextBox
    Friend WithEvents fecha_rv As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents precio_rv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cantidadrv As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents productorv As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigo_rv As DataGridViewTextBoxColumn
    Friend WithEvents producto_rv As DataGridViewTextBoxColumn
    Friend WithEvents cantidad_rv As DataGridViewTextBoxColumn
    Friend WithEvents total_rv As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cheque_rv As RadioButton
    Friend WithEvents tarjeta_rv As RadioButton
    Friend WithEvents efectivo_rv As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents montorv As NumericUpDown
End Class

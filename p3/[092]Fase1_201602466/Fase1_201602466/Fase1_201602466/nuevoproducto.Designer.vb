<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoproducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevoproducto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.codigonv = New System.Windows.Forms.TextBox()
        Me.nombrenv = New System.Windows.Forms.TextBox()
        Me.descripcionnv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.crearnv = New System.Windows.Forms.Button()
        Me.regresar2 = New System.Windows.Forms.Button()
        Me.cerrar3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripciont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio unitario"
        '
        'codigonv
        '
        Me.codigonv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.codigonv.Location = New System.Drawing.Point(139, 65)
        Me.codigonv.MaxLength = 4
        Me.codigonv.Name = "codigonv"
        Me.codigonv.Size = New System.Drawing.Size(192, 20)
        Me.codigonv.TabIndex = 4
        '
        'nombrenv
        '
        Me.nombrenv.Location = New System.Drawing.Point(139, 120)
        Me.nombrenv.Name = "nombrenv"
        Me.nombrenv.Size = New System.Drawing.Size(192, 20)
        Me.nombrenv.TabIndex = 5
        '
        'descripcionnv
        '
        Me.descripcionnv.Location = New System.Drawing.Point(139, 170)
        Me.descripcionnv.Multiline = True
        Me.descripcionnv.Name = "descripcionnv"
        Me.descripcionnv.Size = New System.Drawing.Size(192, 50)
        Me.descripcionnv.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Q."
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Location = New System.Drawing.Point(139, 250)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(192, 20)
        Me.NumericUpDown1.TabIndex = 8
        '
        'crearnv
        '
        Me.crearnv.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.crearnv.Location = New System.Drawing.Point(315, 298)
        Me.crearnv.Name = "crearnv"
        Me.crearnv.Size = New System.Drawing.Size(197, 33)
        Me.crearnv.TabIndex = 9
        Me.crearnv.Text = "¡CREAR NUEVO PRODUCTO!"
        Me.crearnv.UseVisualStyleBackColor = False
        '
        'regresar2
        '
        Me.regresar2.Location = New System.Drawing.Point(654, 403)
        Me.regresar2.Name = "regresar2"
        Me.regresar2.Size = New System.Drawing.Size(119, 23)
        Me.regresar2.TabIndex = 11
        Me.regresar2.Text = "Regresar"
        Me.regresar2.UseVisualStyleBackColor = True
        '
        'cerrar3
        '
        Me.cerrar3.Location = New System.Drawing.Point(654, 374)
        Me.cerrar3.Name = "cerrar3"
        Me.cerrar3.Size = New System.Drawing.Size(119, 23)
        Me.cerrar3.TabIndex = 10
        Me.cerrar3.Text = "Cerrar sesión"
        Me.cerrar3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigot, Me.nombret, Me.descripciont, Me.preciot})
        Me.DataGridView1.Location = New System.Drawing.Point(70, 337)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(442, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'codigot
        '
        Me.codigot.HeaderText = "Código"
        Me.codigot.Name = "codigot"
        '
        'nombret
        '
        Me.nombret.HeaderText = "Nombre"
        Me.nombret.Name = "nombret"
        '
        'descripciont
        '
        Me.descripciont.HeaderText = "Descripción"
        Me.descripciont.Name = "descripciont"
        '
        'preciot
        '
        Me.preciot.HeaderText = "Precio"
        Me.preciot.Name = "preciot"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(140, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 9)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "*cuatro caracteres solo letras mayúsculas y numeros"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(509, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 334)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'nuevoproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 499)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.regresar2)
        Me.Controls.Add(Me.cerrar3)
        Me.Controls.Add(Me.crearnv)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.descripcionnv)
        Me.Controls.Add(Me.nombrenv)
        Me.Controls.Add(Me.codigonv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "nuevoproducto"
        Me.Text = "NUEVO PRODUCTO"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents codigonv As TextBox
    Friend WithEvents nombrenv As TextBox
    Friend WithEvents descripcionnv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents crearnv As Button
    Friend WithEvents regresar2 As Button
    Friend WithEvents cerrar3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigot As DataGridViewTextBoxColumn
    Friend WithEvents nombret As DataGridViewTextBoxColumn
    Friend WithEvents descripciont As DataGridViewTextBoxColumn
    Friend WithEvents preciot As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

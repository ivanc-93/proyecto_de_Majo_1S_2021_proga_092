<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevocliente
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nitnc = New System.Windows.Forms.TextBox()
        Me.nombrenc = New System.Windows.Forms.TextBox()
        Me.correonc = New System.Windows.Forms.TextBox()
        Me.telefono_nc = New System.Windows.Forms.TextBox()
        Me.fechanacimiento_nc = New System.Windows.Forms.TextBox()
        Me.direccion_nc = New System.Windows.Forms.TextBox()
        Me.crearcliente_nc = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nit_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_nc_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono_nc_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nacimientofunfacion_nc_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo_nc_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion_nc_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cerrar_nc = New System.Windows.Forms.Button()
        Me.regresar_nc = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo electrónico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(417, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de nacimiento/fundación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'nitnc
        '
        Me.nitnc.Location = New System.Drawing.Point(60, 57)
        Me.nitnc.MaxLength = 8
        Me.nitnc.Name = "nitnc"
        Me.nitnc.Size = New System.Drawing.Size(100, 20)
        Me.nitnc.TabIndex = 6
        '
        'nombrenc
        '
        Me.nombrenc.Location = New System.Drawing.Point(60, 102)
        Me.nombrenc.Name = "nombrenc"
        Me.nombrenc.Size = New System.Drawing.Size(373, 20)
        Me.nombrenc.TabIndex = 7
        '
        'correonc
        '
        Me.correonc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.correonc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.correonc.Location = New System.Drawing.Point(60, 153)
        Me.correonc.Name = "correonc"
        Me.correonc.Size = New System.Drawing.Size(332, 27)
        Me.correonc.TabIndex = 8
        '
        'telefono_nc
        '
        Me.telefono_nc.Location = New System.Drawing.Point(475, 102)
        Me.telefono_nc.Name = "telefono_nc"
        Me.telefono_nc.Size = New System.Drawing.Size(100, 20)
        Me.telefono_nc.TabIndex = 9
        '
        'fechanacimiento_nc
        '
        Me.fechanacimiento_nc.Location = New System.Drawing.Point(420, 153)
        Me.fechanacimiento_nc.Name = "fechanacimiento_nc"
        Me.fechanacimiento_nc.Size = New System.Drawing.Size(155, 20)
        Me.fechanacimiento_nc.TabIndex = 10
        '
        'direccion_nc
        '
        Me.direccion_nc.Location = New System.Drawing.Point(60, 209)
        Me.direccion_nc.Multiline = True
        Me.direccion_nc.Name = "direccion_nc"
        Me.direccion_nc.Size = New System.Drawing.Size(515, 85)
        Me.direccion_nc.TabIndex = 11
        '
        'crearcliente_nc
        '
        Me.crearcliente_nc.BackColor = System.Drawing.Color.White
        Me.crearcliente_nc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crearcliente_nc.Location = New System.Drawing.Point(592, 256)
        Me.crearcliente_nc.Name = "crearcliente_nc"
        Me.crearcliente_nc.Size = New System.Drawing.Size(113, 38)
        Me.crearcliente_nc.TabIndex = 12
        Me.crearcliente_nc.Text = "Crear cliente"
        Me.crearcliente_nc.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nit_t, Me.nombre_nc_t, Me.telefono_nc_t, Me.nacimientofunfacion_nc_t, Me.correo_nc_t, Me.direccion_nc_t})
        Me.DataGridView1.Location = New System.Drawing.Point(60, 322)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 151)
        Me.DataGridView1.TabIndex = 13
        '
        'nit_t
        '
        Me.nit_t.HeaderText = "NIT"
        Me.nit_t.Name = "nit_t"
        '
        'nombre_nc_t
        '
        Me.nombre_nc_t.HeaderText = "NOMBRE"
        Me.nombre_nc_t.Name = "nombre_nc_t"
        '
        'telefono_nc_t
        '
        Me.telefono_nc_t.HeaderText = "Teléfono"
        Me.telefono_nc_t.Name = "telefono_nc_t"
        '
        'nacimientofunfacion_nc_t
        '
        Me.nacimientofunfacion_nc_t.HeaderText = "FECHA DE NACIMIENTO/FUNDACIÓN"
        Me.nacimientofunfacion_nc_t.Name = "nacimientofunfacion_nc_t"
        '
        'correo_nc_t
        '
        Me.correo_nc_t.HeaderText = "CORREO ELECTRÓNICO"
        Me.correo_nc_t.Name = "correo_nc_t"
        '
        'direccion_nc_t
        '
        Me.direccion_nc_t.HeaderText = "DIRECCIÓN"
        Me.direccion_nc_t.Name = "direccion_nc_t"
        '
        'cerrar_nc
        '
        Me.cerrar_nc.BackColor = System.Drawing.Color.White
        Me.cerrar_nc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar_nc.Location = New System.Drawing.Point(60, 533)
        Me.cerrar_nc.Name = "cerrar_nc"
        Me.cerrar_nc.Size = New System.Drawing.Size(230, 23)
        Me.cerrar_nc.TabIndex = 15
        Me.cerrar_nc.Text = "Cerrar sesión"
        Me.cerrar_nc.UseVisualStyleBackColor = False
        '
        'regresar_nc
        '
        Me.regresar_nc.BackColor = System.Drawing.Color.White
        Me.regresar_nc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar_nc.Location = New System.Drawing.Point(60, 504)
        Me.regresar_nc.Name = "regresar_nc"
        Me.regresar_nc.Size = New System.Drawing.Size(230, 23)
        Me.regresar_nc.TabIndex = 14
        Me.regresar_nc.Text = "Regresar"
        Me.regresar_nc.UseVisualStyleBackColor = False
        '
        'nuevocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(773, 596)
        Me.Controls.Add(Me.cerrar_nc)
        Me.Controls.Add(Me.regresar_nc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.crearcliente_nc)
        Me.Controls.Add(Me.direccion_nc)
        Me.Controls.Add(Me.fechanacimiento_nc)
        Me.Controls.Add(Me.telefono_nc)
        Me.Controls.Add(Me.correonc)
        Me.Controls.Add(Me.nombrenc)
        Me.Controls.Add(Me.nitnc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "nuevocliente"
        Me.Text = "NUEVO CLIENTE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nitnc As TextBox
    Friend WithEvents nombrenc As TextBox
    Friend WithEvents correonc As TextBox
    Friend WithEvents telefono_nc As TextBox
    Friend WithEvents fechanacimiento_nc As TextBox
    Friend WithEvents direccion_nc As TextBox
    Friend WithEvents crearcliente_nc As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nit_t As DataGridViewTextBoxColumn
    Friend WithEvents nombre_nc_t As DataGridViewTextBoxColumn
    Friend WithEvents telefono_nc_t As DataGridViewTextBoxColumn
    Friend WithEvents nacimientofunfacion_nc_t As DataGridViewTextBoxColumn
    Friend WithEvents correo_nc_t As DataGridViewTextBoxColumn
    Friend WithEvents direccion_nc_t As DataGridViewTextBoxColumn
    Friend WithEvents cerrar_nc As Button
    Friend WithEvents regresar_nc As Button
End Class

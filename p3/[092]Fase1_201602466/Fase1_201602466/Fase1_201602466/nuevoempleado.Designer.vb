<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevoempleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nuevoempleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cuine = New System.Windows.Forms.TextBox()
        Me.nombrene = New System.Windows.Forms.TextBox()
        Me.telefonone = New System.Windows.Forms.TextBox()
        Me.fechanacne = New System.Windows.Forms.TextBox()
        Me.correone = New System.Windows.Forms.TextBox()
        Me.contraseñane = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.confirmacionne = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.administradorne = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dpit2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombret2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonot2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fnacimientot2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correot2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipempleadot2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.regresar3 = New System.Windows.Forms.Button()
        Me.cerrar4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ingresar los siguientes datos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo electrónico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contraseña"
        '
        'cuine
        '
        Me.cuine.Location = New System.Drawing.Point(170, 62)
        Me.cuine.MaxLength = 13
        Me.cuine.Name = "cuine"
        Me.cuine.Size = New System.Drawing.Size(100, 20)
        Me.cuine.TabIndex = 8
        '
        'nombrene
        '
        Me.nombrene.Location = New System.Drawing.Point(170, 113)
        Me.nombrene.Name = "nombrene"
        Me.nombrene.Size = New System.Drawing.Size(100, 20)
        Me.nombrene.TabIndex = 9
        '
        'telefonone
        '
        Me.telefonone.Location = New System.Drawing.Point(170, 164)
        Me.telefonone.Name = "telefonone"
        Me.telefonone.Size = New System.Drawing.Size(100, 20)
        Me.telefonone.TabIndex = 10
        '
        'fechanacne
        '
        Me.fechanacne.Location = New System.Drawing.Point(448, 164)
        Me.fechanacne.Name = "fechanacne"
        Me.fechanacne.Size = New System.Drawing.Size(100, 20)
        Me.fechanacne.TabIndex = 11
        '
        'correone
        '
        Me.correone.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.correone.Location = New System.Drawing.Point(170, 225)
        Me.correone.Name = "correone"
        Me.correone.Size = New System.Drawing.Size(274, 20)
        Me.correone.TabIndex = 12
        '
        'contraseñane
        '
        Me.contraseñane.Location = New System.Drawing.Point(170, 272)
        Me.contraseñane.Name = "contraseñane"
        Me.contraseñane.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseñane.Size = New System.Drawing.Size(100, 20)
        Me.contraseñane.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Confirme contraseña"
        '
        'confirmacionne
        '
        Me.confirmacionne.Location = New System.Drawing.Point(448, 272)
        Me.confirmacionne.Name = "confirmacionne"
        Me.confirmacionne.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmacionne.Size = New System.Drawing.Size(100, 20)
        Me.confirmacionne.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.administradorne)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 42)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de empleado"
        '
        'administradorne
        '
        Me.administradorne.AutoSize = True
        Me.administradorne.Location = New System.Drawing.Point(100, 20)
        Me.administradorne.Name = "administradorne"
        Me.administradorne.Size = New System.Drawing.Size(88, 17)
        Me.administradorne.TabIndex = 0
        Me.administradorne.TabStop = True
        Me.administradorne.Text = "Administrador"
        Me.administradorne.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(582, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 37)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "¡Crear empleado!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dpit2, Me.nombret2, Me.telefonot2, Me.fnacimientot2, Me.correot2, Me.tipempleadot2})
        Me.DataGridView1.Location = New System.Drawing.Point(77, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 150)
        Me.DataGridView1.TabIndex = 18
        '
        'dpit2
        '
        Me.dpit2.HeaderText = "DPI"
        Me.dpit2.Name = "dpit2"
        '
        'nombret2
        '
        Me.nombret2.HeaderText = "Nombre"
        Me.nombret2.Name = "nombret2"
        '
        'telefonot2
        '
        Me.telefonot2.HeaderText = "Teléfono"
        Me.telefonot2.Name = "telefonot2"
        '
        'fnacimientot2
        '
        Me.fnacimientot2.HeaderText = "Fecha de nacimiento"
        Me.fnacimientot2.Name = "fnacimientot2"
        '
        'correot2
        '
        Me.correot2.HeaderText = "Correo electrónico"
        Me.correot2.Name = "correot2"
        '
        'tipempleadot2
        '
        Me.tipempleadot2.HeaderText = "Administrador"
        Me.tipempleadot2.Name = "tipempleadot2"
        '
        'regresar3
        '
        Me.regresar3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar3.Location = New System.Drawing.Point(733, 569)
        Me.regresar3.Name = "regresar3"
        Me.regresar3.Size = New System.Drawing.Size(119, 23)
        Me.regresar3.TabIndex = 20
        Me.regresar3.Text = "Regresar"
        Me.regresar3.UseVisualStyleBackColor = True
        '
        'cerrar4
        '
        Me.cerrar4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar4.Location = New System.Drawing.Point(733, 540)
        Me.cerrar4.Name = "cerrar4"
        Me.cerrar4.Size = New System.Drawing.Size(119, 23)
        Me.cerrar4.TabIndex = 19
        Me.cerrar4.Text = "Cerrar sesión"
        Me.cerrar4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(572, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 305)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'nuevoempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 605)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.regresar3)
        Me.Controls.Add(Me.cerrar4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.confirmacionne)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.contraseñane)
        Me.Controls.Add(Me.correone)
        Me.Controls.Add(Me.fechanacne)
        Me.Controls.Add(Me.telefonone)
        Me.Controls.Add(Me.nombrene)
        Me.Controls.Add(Me.cuine)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "nuevoempleado"
        Me.Text = "NUEVO EMPLEADO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cuine As TextBox
    Friend WithEvents nombrene As TextBox
    Friend WithEvents telefonone As TextBox
    Friend WithEvents fechanacne As TextBox
    Friend WithEvents correone As TextBox
    Friend WithEvents contraseñane As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents confirmacionne As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents administradorne As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dpit2 As DataGridViewTextBoxColumn
    Friend WithEvents nombret2 As DataGridViewTextBoxColumn
    Friend WithEvents telefonot2 As DataGridViewTextBoxColumn
    Friend WithEvents fnacimientot2 As DataGridViewTextBoxColumn
    Friend WithEvents correot2 As DataGridViewTextBoxColumn
    Friend WithEvents tipempleadot2 As DataGridViewTextBoxColumn
    Friend WithEvents regresar3 As Button
    Friend WithEvents cerrar4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

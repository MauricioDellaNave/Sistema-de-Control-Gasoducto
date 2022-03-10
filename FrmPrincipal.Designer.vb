<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnRonda = New System.Windows.Forms.Button
        Me.BtnDescarga = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnConfig = New System.Windows.Forms.Button
        Me.btnOperador = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtPlanta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEstado = New System.Windows.Forms.TextBox
        Me.txtHora = New System.Windows.Forms.TextBox
        Me.txtOpcion = New System.Windows.Forms.TextBox
        Me.txtIndice = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'BtnRonda
        '
        Me.BtnRonda.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRonda.Location = New System.Drawing.Point(26, 298)
        Me.BtnRonda.Name = "BtnRonda"
        Me.BtnRonda.Size = New System.Drawing.Size(425, 100)
        Me.BtnRonda.TabIndex = 7
        Me.BtnRonda.Text = "F2 - (Comenzar Ronda)"
        '
        'BtnDescarga
        '
        Me.BtnDescarga.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDescarga.Location = New System.Drawing.Point(26, 399)
        Me.BtnDescarga.Name = "BtnDescarga"
        Me.BtnDescarga.Size = New System.Drawing.Size(425, 100)
        Me.BtnDescarga.TabIndex = 9
        Me.BtnDescarga.Text = "F3 - (Descargar Datos)"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(0, 569)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(240, 70)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "ESC - &Salir"
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(240, 569)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(240, 70)
        Me.btnConfig.TabIndex = 11
        Me.btnConfig.Text = "&Config."
        '
        'btnOperador
        '
        Me.btnOperador.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOperador.Location = New System.Drawing.Point(26, 197)
        Me.btnOperador.Name = "btnOperador"
        Me.btnOperador.Size = New System.Drawing.Size(425, 100)
        Me.btnOperador.TabIndex = 17
        Me.btnOperador.Text = "F1 - (Seleccionar Operador)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(14, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(123, 51)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Text = "Planta:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(14, 150)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(123, 41)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "Operador:  "
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(198, 507)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(254, 38)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "Desarrollado para TGS S.A."
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(326, 530)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(126, 38)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "Versión 1.0.9"
        '
        'txtOperador
        '
        Me.txtOperador.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtOperador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtOperador.ForeColor = System.Drawing.Color.White
        Me.txtOperador.Location = New System.Drawing.Point(143, 150)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.ReadOnly = True
        Me.txtOperador.Size = New System.Drawing.Size(306, 41)
        Me.txtOperador.TabIndex = 25
        '
        'txtPlanta
        '
        Me.txtPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlanta.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlanta.ForeColor = System.Drawing.Color.White
        Me.txtPlanta.Location = New System.Drawing.Point(132, 103)
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.ReadOnly = True
        Me.txtPlanta.Size = New System.Drawing.Size(346, 58)
        Me.txtPlanta.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 40)
        Me.Label2.Text = "Transportadora de Gas del Sur"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(3, 504)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(67, 41)
        Me.txtEstado.TabIndex = 71
        Me.txtEstado.Text = "False"
        Me.txtEstado.Visible = False
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(70, 504)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(44, 41)
        Me.txtHora.TabIndex = 72
        Me.txtHora.Visible = False
        '
        'txtOpcion
        '
        Me.txtOpcion.Location = New System.Drawing.Point(115, 504)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(44, 41)
        Me.txtOpcion.TabIndex = 73
        Me.txtOpcion.Visible = False
        '
        'txtIndice
        '
        Me.txtIndice.Location = New System.Drawing.Point(166, 522)
        Me.txtIndice.Name = "txtIndice"
        Me.txtIndice.Size = New System.Drawing.Size(74, 41)
        Me.txtIndice.TabIndex = 76
        Me.txtIndice.Visible = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIndice)
        Me.Controls.Add(Me.txtOpcion)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOperador)
        Me.Controls.Add(Me.txtPlanta)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnOperador)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.BtnDescarga)
        Me.Controls.Add(Me.BtnRonda)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeBox = False
        Me.Name = "FrmPrincipal"
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRonda As System.Windows.Forms.Button
    Friend WithEvents BtnDescarga As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents btnOperador As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtPlanta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents txtIndice As System.Windows.Forms.TextBox

End Class

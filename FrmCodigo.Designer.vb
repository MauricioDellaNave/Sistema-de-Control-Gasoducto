<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmCodigo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCodigo))
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtPlanta = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.btnTeclado = New System.Windows.Forms.Button
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEquipo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.txtHora = New System.Windows.Forms.ListBox
        Me.btnHora = New System.Windows.Forms.Button
        Me.TimerHoraSeleccionada = New System.Windows.Forms.Timer
        Me.txtEditado = New System.Windows.Forms.ListBox
        Me.HoraAnterior = New System.Windows.Forms.Label
        Me.HoraActual = New System.Windows.Forms.Label
        Me.HoraPosterior = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(239, 575)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(241, 63)
        Me.BtnAceptar.TabIndex = 30
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(0, 575)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 63)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "&Atras"
        '
        'txtOperador
        '
        Me.txtOperador.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtOperador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtOperador.ForeColor = System.Drawing.Color.White
        Me.txtOperador.Location = New System.Drawing.Point(143, 144)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(306, 41)
        Me.txtOperador.TabIndex = 36
        '
        'txtPlanta
        '
        Me.txtPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlanta.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlanta.ForeColor = System.Drawing.Color.White
        Me.txtPlanta.Location = New System.Drawing.Point(132, 100)
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.Size = New System.Drawing.Size(338, 58)
        Me.txtPlanta.TabIndex = 37
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(14, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 41)
        Me.TextBox2.TabIndex = 35
        Me.TextBox2.Text = "Operador:  "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(14, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 51)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Text = "Planta:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCodigo.Location = New System.Drawing.Point(9, 390)
        Me.txtCodigo.MaxLength = 30
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(361, 41)
        Me.txtCodigo.TabIndex = 39
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(5, 357)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(315, 33)
        Me.lblCodigo.Text = "INGRESAR CODIGO:"
        '
        'btnTeclado
        '
        Me.btnTeclado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.btnTeclado.Location = New System.Drawing.Point(380, 390)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(94, 41)
        Me.btnTeclado.TabIndex = 43
        Me.btnTeclado.Text = "&Teclado"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 40)
        Me.Label2.Text = "Transportadora de Gas del Sur"
        '
        'txtEquipo
        '
        Me.txtEquipo.BackColor = System.Drawing.Color.Black
        Me.txtEquipo.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtEquipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEquipo.Location = New System.Drawing.Point(0, 436)
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.Size = New System.Drawing.Size(480, 138)
        Me.txtEquipo.Text = "Equipo"
        Me.txtEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 38)
        Me.Label1.Text = "HORA DE COMIENZO:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtHora.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtHora.Items.Add("14:12")
        Me.txtHora.Items.Add("16:12")
        Me.txtHora.Items.Add("18:12")
        Me.txtHora.Location = New System.Drawing.Point(9, 208)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(311, 194)
        Me.txtHora.TabIndex = 56
        '
        'btnHora
        '
        Me.btnHora.Enabled = False
        Me.btnHora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.btnHora.Location = New System.Drawing.Point(380, 310)
        Me.btnHora.Name = "btnHora"
        Me.btnHora.Size = New System.Drawing.Size(94, 41)
        Me.btnHora.TabIndex = 61
        Me.btnHora.Text = "&Editar"
        '
        'TimerHoraSeleccionada
        '
        Me.TimerHoraSeleccionada.Interval = 600000
        '
        'txtEditado
        '
        Me.txtEditado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtEditado.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtEditado.Location = New System.Drawing.Point(159, 104)
        Me.txtEditado.Name = "txtEditado"
        Me.txtEditado.Size = New System.Drawing.Size(311, 50)
        Me.txtEditado.TabIndex = 70
        Me.txtEditado.Visible = False
        '
        'HoraAnterior
        '
        Me.HoraAnterior.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HoraAnterior.ForeColor = System.Drawing.Color.White
        Me.HoraAnterior.Location = New System.Drawing.Point(320, 214)
        Me.HoraAnterior.Name = "HoraAnterior"
        Me.HoraAnterior.Size = New System.Drawing.Size(56, 42)
        Me.HoraAnterior.Text = "<<"
        '
        'HoraActual
        '
        Me.HoraActual.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HoraActual.ForeColor = System.Drawing.Color.White
        Me.HoraActual.Location = New System.Drawing.Point(320, 260)
        Me.HoraActual.Name = "HoraActual"
        Me.HoraActual.Size = New System.Drawing.Size(56, 42)
        Me.HoraActual.Text = "<<"
        '
        'HoraPosterior
        '
        Me.HoraPosterior.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HoraPosterior.ForeColor = System.Drawing.Color.White
        Me.HoraPosterior.Location = New System.Drawing.Point(320, 309)
        Me.HoraPosterior.Name = "HoraPosterior"
        Me.HoraPosterior.Size = New System.Drawing.Size(56, 42)
        Me.HoraPosterior.Text = "<<"
        '
        'FrmCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.HoraPosterior)
        Me.Controls.Add(Me.HoraActual)
        Me.Controls.Add(Me.HoraAnterior)
        Me.Controls.Add(Me.txtEditado)
        Me.Controls.Add(Me.btnHora)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtPlanta)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTeclado)
        Me.Controls.Add(Me.txtOperador)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtEquipo)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeBox = False
        Me.Name = "FrmCodigo"
        Me.Text = "FrmCodigo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtPlanta As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnTeclado As System.Windows.Forms.Button
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEquipo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtHora As System.Windows.Forms.ListBox
    Friend WithEvents btnHora As System.Windows.Forms.Button
    Friend WithEvents TimerHoraSeleccionada As System.Windows.Forms.Timer
    Friend WithEvents txtEditado As System.Windows.Forms.ListBox
    Friend WithEvents HoraAnterior As System.Windows.Forms.Label
    Friend WithEvents HoraActual As System.Windows.Forms.Label
    Friend WithEvents HoraPosterior As System.Windows.Forms.Label
End Class

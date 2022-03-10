<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmEstados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstados))
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtEquipo = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.txtDescripcion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdER = New System.Windows.Forms.RadioButton
        Me.rdES = New System.Windows.Forms.RadioButton
        Me.rdEM = New System.Windows.Forms.RadioButton
        Me.rdFS = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 40)
        Me.Label2.Text = "Transportadora de Gas del Sur"
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
        'txtEquipo
        '
        Me.txtEquipo.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtEquipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEquipo.Location = New System.Drawing.Point(7, 173)
        Me.txtEquipo.Name = "txtEquipo"
        Me.txtEquipo.Size = New System.Drawing.Size(461, 122)
        Me.txtEquipo.Text = "Equipo"
        Me.txtEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(239, 576)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(241, 63)
        Me.BtnAceptar.TabIndex = 32
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(0, 576)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 63)
        Me.BtnSalir.TabIndex = 31
        Me.BtnSalir.Text = "&Atras"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcion.ForeColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(7, 114)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(461, 73)
        Me.txtDescripcion.Text = "MOTOGENERADORES"
        Me.txtDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 39)
        Me.Label1.Text = "Indicar el estado actual del equipo:"
        '
        'rdER
        '
        Me.rdER.Checked = True
        Me.rdER.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdER.Location = New System.Drawing.Point(49, 359)
        Me.rdER.Name = "rdER"
        Me.rdER.Size = New System.Drawing.Size(166, 40)
        Me.rdER.TabIndex = 37
        Me.rdER.Tag = "Equipo en Reserva"
        Me.rdER.Text = "E/R"
        '
        'rdES
        '
        Me.rdES.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdES.Location = New System.Drawing.Point(276, 359)
        Me.rdES.Name = "rdES"
        Me.rdES.Size = New System.Drawing.Size(164, 40)
        Me.rdES.TabIndex = 38
        Me.rdES.TabStop = False
        Me.rdES.Tag = "Equipo en Servicio"
        Me.rdES.Text = "E/S"
        '
        'rdEM
        '
        Me.rdEM.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdEM.Location = New System.Drawing.Point(49, 457)
        Me.rdEM.Name = "rdEM"
        Me.rdEM.Size = New System.Drawing.Size(166, 40)
        Me.rdEM.TabIndex = 39
        Me.rdEM.TabStop = False
        Me.rdEM.Tag = "Equipo en Mantenimiento"
        Me.rdEM.Text = "E/M"
        '
        'rdFS
        '
        Me.rdFS.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.rdFS.Location = New System.Drawing.Point(276, 457)
        Me.rdFS.Name = "rdFS"
        Me.rdFS.Size = New System.Drawing.Size(189, 40)
        Me.rdFS.TabIndex = 40
        Me.rdFS.TabStop = False
        Me.rdFS.Tag = "Equipo fuera de Servicio"
        Me.rdFS.Text = "F/S"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextBox1.Location = New System.Drawing.Point(14, 337)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(454, 202)
        Me.TextBox1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 500)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 30)
        Me.Label3.Text = "(En mantenimiento)"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(256, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 30)
        Me.Label4.Text = "(Fuera de servicio)"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 30)
        Me.Label5.Text = "(En reserva)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(282, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 30)
        Me.Label6.Text = "(En servicio)"
        '
        'FrmEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdFS)
        Me.Controls.Add(Me.rdEM)
        Me.Controls.Add(Me.rdES)
        Me.Controls.Add(Me.rdER)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEquipo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmEstados"
        Me.Text = "FrmEstados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEquipo As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdER As System.Windows.Forms.RadioButton
    Friend WithEvents rdES As System.Windows.Forms.RadioButton
    Friend WithEvents rdEM As System.Windows.Forms.RadioButton
    Friend WithEvents rdFS As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

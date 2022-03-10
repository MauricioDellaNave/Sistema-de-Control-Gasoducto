<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmTeclado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTeclado))
        Me.Opcion1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdON = New System.Windows.Forms.RadioButton
        Me.rdOFF = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.BtnSiguiente = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Opcion1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Opcion1
        '
        Me.Opcion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Opcion1.Controls.Add(Me.Label1)
        Me.Opcion1.Controls.Add(Me.rdON)
        Me.Opcion1.Controls.Add(Me.rdOFF)
        Me.Opcion1.Location = New System.Drawing.Point(9, 220)
        Me.Opcion1.Name = "Opcion1"
        Me.Opcion1.Size = New System.Drawing.Size(462, 200)
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 96)
        Me.Label1.Text = "Permite habilitar la opción de teclado virtual cuando el código de barra no se en" & _
            "cuentra disponible."
        '
        'rdON
        '
        Me.rdON.ForeColor = System.Drawing.Color.Black
        Me.rdON.Location = New System.Drawing.Point(132, 123)
        Me.rdON.Name = "rdON"
        Me.rdON.Size = New System.Drawing.Size(121, 40)
        Me.rdON.TabIndex = 40
        Me.rdON.TabStop = False
        Me.rdON.Text = "ON"
        '
        'rdOFF
        '
        Me.rdOFF.Checked = True
        Me.rdOFF.ForeColor = System.Drawing.Color.Black
        Me.rdOFF.Location = New System.Drawing.Point(17, 123)
        Me.rdOFF.Name = "rdOFF"
        Me.rdOFF.Size = New System.Drawing.Size(96, 40)
        Me.rdOFF.TabIndex = 39
        Me.rdOFF.Text = "OFF"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 34)
        Me.Label2.Text = "Transportadora de Gas del Sur"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(441, 40)
        Me.Label4.Text = "Teclado Virtual"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(123, 481)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 61)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "&Guardar"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSiguiente.Location = New System.Drawing.Point(240, 570)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(240, 70)
        Me.BtnSiguiente.TabIndex = 55
        Me.BtnSiguiente.Text = ">>"
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(0, 570)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 70)
        Me.BtnSalir.TabIndex = 54
        Me.BtnSalir.Text = "<<"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Location = New System.Drawing.Point(12, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 10)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Cyan
        Me.Label3.Location = New System.Drawing.Point(6, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(474, 48)
        Me.Label3.Text = "Menú de Configuración:"
        '
        'FrmTeclado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Opcion1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmTeclado"
        Me.Text = "FrmTeclado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Opcion1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Opcion1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdON As System.Windows.Forms.RadioButton
    Friend WithEvents rdOFF As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

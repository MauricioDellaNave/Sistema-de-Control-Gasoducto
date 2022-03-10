<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalida))
        Me.Opcion3 = New System.Windows.Forms.Panel
        Me.txtRutaConfig = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.BtnSiguiente = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Opcion3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Opcion3
        '
        Me.Opcion3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Opcion3.Controls.Add(Me.txtRutaConfig)
        Me.Opcion3.Controls.Add(Me.Button1)
        Me.Opcion3.Controls.Add(Me.Label5)
        Me.Opcion3.Location = New System.Drawing.Point(10, 234)
        Me.Opcion3.Name = "Opcion3"
        Me.Opcion3.Size = New System.Drawing.Size(459, 222)
        '
        'txtRutaConfig
        '
        Me.txtRutaConfig.Location = New System.Drawing.Point(10, 80)
        Me.txtRutaConfig.Multiline = True
        Me.txtRutaConfig.Name = "txtRutaConfig"
        Me.txtRutaConfig.Size = New System.Drawing.Size(433, 73)
        Me.txtRutaConfig.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Button1.Location = New System.Drawing.Point(9, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(446, 73)
        Me.Label5.Text = "Permite cargar el archivo de configuración especifico de cada Planta."
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
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(123, 480)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 61)
        Me.btnGuardar.TabIndex = 56
        Me.btnGuardar.Text = "&Guardar"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Enabled = False
        Me.BtnSiguiente.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSiguiente.Location = New System.Drawing.Point(240, 569)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(240, 70)
        Me.BtnSiguiente.TabIndex = 55
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(0, 569)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 70)
        Me.BtnSalir.TabIndex = 54
        Me.BtnSalir.Text = "<<"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 40)
        Me.Label1.Text = "Cargar Archivo de Planta"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "\Upload"
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
        'FrmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Opcion3)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmSalida"
        Me.Text = "FrmSalida"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Opcion3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Opcion3 As System.Windows.Forms.Panel
    Friend WithEvents txtRutaConfig As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

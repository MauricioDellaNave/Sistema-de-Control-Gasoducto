<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmDatosPC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosPC))
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSiguiente = New System.Windows.Forms.Button
        Me.Opcion2 = New System.Windows.Forms.Panel
        Me.btnTeclado = New System.Windows.Forms.Button
        Me.txtRutaPC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Opcion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(123, 481)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 61)
        Me.btnGuardar.TabIndex = 64
        Me.btnGuardar.Text = "&Guardar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(0, 568)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 70)
        Me.BtnSalir.TabIndex = 62
        Me.BtnSalir.Text = "<<"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 40)
        Me.Label1.Text = "Archivos de Salida en la PC"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 34)
        Me.Label2.Text = "Transportadora de Gas del Sur"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSiguiente.Location = New System.Drawing.Point(240, 568)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(240, 70)
        Me.BtnSiguiente.TabIndex = 63
        Me.BtnSiguiente.Text = ">>"
        '
        'Opcion2
        '
        Me.Opcion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Opcion2.Controls.Add(Me.btnTeclado)
        Me.Opcion2.Controls.Add(Me.txtRutaPC)
        Me.Opcion2.Controls.Add(Me.Label5)
        Me.Opcion2.Location = New System.Drawing.Point(7, 207)
        Me.Opcion2.Name = "Opcion2"
        Me.Opcion2.Size = New System.Drawing.Size(459, 176)
        '
        'btnTeclado
        '
        Me.btnTeclado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
        Me.btnTeclado.Location = New System.Drawing.Point(348, 124)
        Me.btnTeclado.Name = "btnTeclado"
        Me.btnTeclado.Size = New System.Drawing.Size(108, 41)
        Me.btnTeclado.TabIndex = 56
        Me.btnTeclado.Text = "&Teclado"
        '
        'txtRutaPC
        '
        Me.txtRutaPC.Location = New System.Drawing.Point(10, 124)
        Me.txtRutaPC.Name = "txtRutaPC"
        Me.txtRutaPC.Size = New System.Drawing.Size(332, 41)
        Me.txtRutaPC.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, -3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(457, 89)
        Me.Label5.Text = "Permite seleccionar la ruta de la PC donde seran transferidos los archivos genera" & _
            "dos por la aplicación."
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(364, 34)
        Me.Label4.Text = "Ejemplo=  \\NombrePC\Carpeta"
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
        'FrmDatosPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Opcion2)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmDatosPC"
        Me.Text = "FrmDatosPC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Opcion2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents Opcion2 As System.Windows.Forms.Panel
    Friend WithEvents btnTeclado As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRutaPC As System.Windows.Forms.TextBox
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

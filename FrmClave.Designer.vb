<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmClave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClave))
        Me.Opcion4 = New System.Windows.Forms.Panel
        Me.txtConfirmacion = New System.Windows.Forms.TextBox
        Me.txtSupervisor = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.BtnSiguiente = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Opcion4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Opcion4
        '
        Me.Opcion4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Opcion4.Controls.Add(Me.txtConfirmacion)
        Me.Opcion4.Controls.Add(Me.txtSupervisor)
        Me.Opcion4.Controls.Add(Me.Label6)
        Me.Opcion4.Controls.Add(Me.Label7)
        Me.Opcion4.Location = New System.Drawing.Point(11, 263)
        Me.Opcion4.Name = "Opcion4"
        Me.Opcion4.Size = New System.Drawing.Size(459, 186)
        '
        'txtConfirmacion
        '
        Me.txtConfirmacion.Location = New System.Drawing.Point(10, 126)
        Me.txtConfirmacion.MaxLength = 20
        Me.txtConfirmacion.Name = "txtConfirmacion"
        Me.txtConfirmacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmacion.Size = New System.Drawing.Size(328, 41)
        Me.txtConfirmacion.TabIndex = 4
        '
        'txtSupervisor
        '
        Me.txtSupervisor.Location = New System.Drawing.Point(10, 38)
        Me.txtSupervisor.MaxLength = 20
        Me.txtSupervisor.Name = "txtSupervisor"
        Me.txtSupervisor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSupervisor.Size = New System.Drawing.Size(328, 41)
        Me.txtSupervisor.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(446, 73)
        Me.Label6.Text = "Nueva clave de Supervisor:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(446, 39)
        Me.Label7.Text = "Confirmar clave de Supervisor:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(393, 36)
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
        Me.btnGuardar.Location = New System.Drawing.Point(123, 481)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(240, 61)
        Me.btnGuardar.TabIndex = 53
        Me.btnGuardar.Text = "&Guardar"
        '
        'BtnSiguiente
        '
        Me.BtnSiguiente.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSiguiente.Location = New System.Drawing.Point(240, 570)
        Me.BtnSiguiente.Name = "BtnSiguiente"
        Me.BtnSiguiente.Size = New System.Drawing.Size(240, 70)
        Me.BtnSiguiente.TabIndex = 52
        Me.BtnSiguiente.Text = ">>"
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.Location = New System.Drawing.Point(0, 570)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 70)
        Me.BtnSalir.TabIndex = 51
        Me.BtnSalir.Text = "<<"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 40)
        Me.Label1.Text = "Modificar clave "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(441, 40)
        Me.Label4.Text = "Maximo (20 caracteres)"
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
        'FrmClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.BtnSiguiente)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Opcion4)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmClave"
        Me.Text = "FrmClave"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Opcion4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Opcion4 As System.Windows.Forms.Panel
    Friend WithEvents txtConfirmacion As System.Windows.Forms.TextBox
    Friend WithEvents txtSupervisor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

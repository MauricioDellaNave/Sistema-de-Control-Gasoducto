<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmDatos
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
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtPlanta = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.lblUnidad = New System.Windows.Forms.Label
        Me.btnAtras = New System.Windows.Forms.Button
        Me.btnAvanzar = New System.Windows.Forms.Button
        Me.txtCabecera = New System.Windows.Forms.TextBox
        Me.txtEspecificacion = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblHora = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMax = New System.Windows.Forms.TextBox
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CkAgregar = New System.Windows.Forms.CheckBox
        Me.txtMed1 = New System.Windows.Forms.TextBox
        Me.txtMed2 = New System.Windows.Forms.TextBox
        Me.txtMed3 = New System.Windows.Forms.TextBox
        Me.txtMed4 = New System.Windows.Forms.TextBox
        Me.txtFecha1 = New System.Windows.Forms.Label
        Me.txtFecha2 = New System.Windows.Forms.Label
        Me.txtFecha4 = New System.Windows.Forms.Label
        Me.txtFecha3 = New System.Windows.Forms.Label
        Me.txtHora1 = New System.Windows.Forms.Label
        Me.txtHora2 = New System.Windows.Forms.Label
        Me.txtHora3 = New System.Windows.Forms.Label
        Me.txtHora4 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblSinDatos = New System.Windows.Forms.Label
        Me.rdER = New System.Windows.Forms.RadioButton
        Me.rdEM = New System.Windows.Forms.RadioButton
        Me.rdFS = New System.Windows.Forms.RadioButton
        Me.rdBien = New System.Windows.Forms.RadioButton
        Me.rdMal = New System.Windows.Forms.RadioButton
        Me.rdSI = New System.Windows.Forms.RadioButton
        Me.rdNO = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(240, 558)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(240, 81)
        Me.BtnAceptar.TabIndex = 46
        Me.BtnAceptar.Text = "&Observación"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(0, 558)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(240, 81)
        Me.BtnSalir.TabIndex = 45
        Me.BtnSalir.Text = "&Menu"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.Location = New System.Drawing.Point(117, 484)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(232, 68)
        Me.btnOK.TabIndex = 53
        Me.btnOK.Text = "OK"
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.LightBlue
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtValor.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValor.Location = New System.Drawing.Point(117, 364)
        Me.txtValor.MaxLength = 8
        Me.txtValor.Multiline = True
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(233, 79)
        Me.txtValor.TabIndex = 56
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOperador
        '
        Me.txtOperador.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtOperador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOperador.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtOperador.ForeColor = System.Drawing.Color.White
        Me.txtOperador.Location = New System.Drawing.Point(143, 51)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.ReadOnly = True
        Me.txtOperador.Size = New System.Drawing.Size(318, 41)
        Me.txtOperador.TabIndex = 60
        '
        'txtPlanta
        '
        Me.txtPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlanta.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlanta.ForeColor = System.Drawing.Color.White
        Me.txtPlanta.Location = New System.Drawing.Point(127, 8)
        Me.txtPlanta.Name = "txtPlanta"
        Me.txtPlanta.ReadOnly = True
        Me.txtPlanta.Size = New System.Drawing.Size(350, 58)
        Me.txtPlanta.TabIndex = 61
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(14, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(123, 41)
        Me.TextBox2.TabIndex = 59
        Me.TextBox2.Text = "Operador:  "
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(14, 13)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(123, 51)
        Me.TextBox3.TabIndex = 58
        Me.TextBox3.Text = "Planta:"
        '
        'lblUnidad
        '
        Me.lblUnidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnidad.ForeColor = System.Drawing.Color.White
        Me.lblUnidad.Location = New System.Drawing.Point(353, 386)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(121, 45)
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAtras.Location = New System.Drawing.Point(15, 484)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(89, 68)
        Me.btnAtras.TabIndex = 69
        Me.btnAtras.Text = "<<"
        '
        'btnAvanzar
        '
        Me.btnAvanzar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAvanzar.Location = New System.Drawing.Point(362, 484)
        Me.btnAvanzar.Name = "btnAvanzar"
        Me.btnAvanzar.Size = New System.Drawing.Size(89, 68)
        Me.btnAvanzar.TabIndex = 70
        Me.btnAvanzar.Text = ">>"
        '
        'txtCabecera
        '
        Me.txtCabecera.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCabecera.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.txtCabecera.Location = New System.Drawing.Point(3, 87)
        Me.txtCabecera.Multiline = True
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.ReadOnly = True
        Me.txtCabecera.Size = New System.Drawing.Size(474, 40)
        Me.txtCabecera.TabIndex = 74
        Me.txtCabecera.Text = "Cabecera"
        Me.txtCabecera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEspecificacion
        '
        Me.txtEspecificacion.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEspecificacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtEspecificacion.Location = New System.Drawing.Point(3, 129)
        Me.txtEspecificacion.Multiline = True
        Me.txtEspecificacion.Name = "txtEspecificacion"
        Me.txtEspecificacion.ReadOnly = True
        Me.txtEspecificacion.Size = New System.Drawing.Size(474, 34)
        Me.txtEspecificacion.TabIndex = 75
        Me.txtEspecificacion.Text = "Especificacion"
        Me.txtEspecificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(4, 376)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(111, 29)
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(6, 405)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(109, 29)
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(376, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 40)
        Me.Label1.Text = "MAX."
        '
        'txtMax
        '
        Me.txtMax.BackColor = System.Drawing.Color.White
        Me.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMax.Location = New System.Drawing.Point(357, 224)
        Me.txtMax.Multiline = True
        Me.txtMax.Name = "txtMax"
        Me.txtMax.ReadOnly = True
        Me.txtMax.Size = New System.Drawing.Size(105, 41)
        Me.txtMax.TabIndex = 81
        Me.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.White
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMin.Location = New System.Drawing.Point(357, 303)
        Me.txtMin.Multiline = True
        Me.txtMin.Name = "txtMin"
        Me.txtMin.ReadOnly = True
        Me.txtMin.Size = New System.Drawing.Size(105, 41)
        Me.txtMin.TabIndex = 83
        Me.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(376, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 40)
        Me.Label2.Text = "MIN."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(70, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 25)
        Me.Label3.Text = "Mediciones anteriores:"
        '
        'CkAgregar
        '
        Me.CkAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CkAgregar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CkAgregar.ForeColor = System.Drawing.Color.Lime
        Me.CkAgregar.Location = New System.Drawing.Point(118, 446)
        Me.CkAgregar.Name = "CkAgregar"
        Me.CkAgregar.Size = New System.Drawing.Size(248, 36)
        Me.CkAgregar.TabIndex = 89
        Me.CkAgregar.Text = "Agregar Aceite"
        '
        'txtMed1
        '
        Me.txtMed1.BackColor = System.Drawing.Color.White
        Me.txtMed1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMed1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMed1.Location = New System.Drawing.Point(195, 199)
        Me.txtMed1.Multiline = True
        Me.txtMed1.Name = "txtMed1"
        Me.txtMed1.ReadOnly = True
        Me.txtMed1.Size = New System.Drawing.Size(154, 35)
        Me.txtMed1.TabIndex = 98
        Me.txtMed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMed2
        '
        Me.txtMed2.BackColor = System.Drawing.Color.Silver
        Me.txtMed2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMed2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMed2.Location = New System.Drawing.Point(195, 237)
        Me.txtMed2.Multiline = True
        Me.txtMed2.Name = "txtMed2"
        Me.txtMed2.ReadOnly = True
        Me.txtMed2.Size = New System.Drawing.Size(154, 35)
        Me.txtMed2.TabIndex = 103
        Me.txtMed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMed3
        '
        Me.txtMed3.BackColor = System.Drawing.Color.White
        Me.txtMed3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMed3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMed3.Location = New System.Drawing.Point(195, 273)
        Me.txtMed3.Multiline = True
        Me.txtMed3.Name = "txtMed3"
        Me.txtMed3.ReadOnly = True
        Me.txtMed3.Size = New System.Drawing.Size(154, 35)
        Me.txtMed3.TabIndex = 105
        Me.txtMed3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMed4
        '
        Me.txtMed4.BackColor = System.Drawing.Color.Silver
        Me.txtMed4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMed4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txtMed4.Location = New System.Drawing.Point(195, 309)
        Me.txtMed4.Multiline = True
        Me.txtMed4.Name = "txtMed4"
        Me.txtMed4.ReadOnly = True
        Me.txtMed4.Size = New System.Drawing.Size(154, 35)
        Me.txtMed4.TabIndex = 107
        Me.txtMed4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFecha1
        '
        Me.txtFecha1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtFecha1.ForeColor = System.Drawing.Color.White
        Me.txtFecha1.Location = New System.Drawing.Point(4, 205)
        Me.txtFecha1.Name = "txtFecha1"
        Me.txtFecha1.Size = New System.Drawing.Size(111, 29)
        Me.txtFecha1.Text = "---"
        Me.txtFecha1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFecha2
        '
        Me.txtFecha2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtFecha2.ForeColor = System.Drawing.Color.White
        Me.txtFecha2.Location = New System.Drawing.Point(4, 241)
        Me.txtFecha2.Name = "txtFecha2"
        Me.txtFecha2.Size = New System.Drawing.Size(111, 29)
        Me.txtFecha2.Text = "---"
        Me.txtFecha2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFecha4
        '
        Me.txtFecha4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtFecha4.ForeColor = System.Drawing.Color.White
        Me.txtFecha4.Location = New System.Drawing.Point(5, 313)
        Me.txtFecha4.Name = "txtFecha4"
        Me.txtFecha4.Size = New System.Drawing.Size(111, 29)
        Me.txtFecha4.Text = "---"
        Me.txtFecha4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFecha3
        '
        Me.txtFecha3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtFecha3.ForeColor = System.Drawing.Color.White
        Me.txtFecha3.Location = New System.Drawing.Point(5, 278)
        Me.txtFecha3.Name = "txtFecha3"
        Me.txtFecha3.Size = New System.Drawing.Size(111, 29)
        Me.txtFecha3.Text = "---"
        Me.txtFecha3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHora1
        '
        Me.txtHora1.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtHora1.ForeColor = System.Drawing.Color.White
        Me.txtHora1.Location = New System.Drawing.Point(111, 205)
        Me.txtHora1.Name = "txtHora1"
        Me.txtHora1.Size = New System.Drawing.Size(60, 29)
        Me.txtHora1.Text = "---"
        Me.txtHora1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHora2
        '
        Me.txtHora2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtHora2.ForeColor = System.Drawing.Color.White
        Me.txtHora2.Location = New System.Drawing.Point(111, 241)
        Me.txtHora2.Name = "txtHora2"
        Me.txtHora2.Size = New System.Drawing.Size(60, 29)
        Me.txtHora2.Text = "---"
        Me.txtHora2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHora3
        '
        Me.txtHora3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtHora3.ForeColor = System.Drawing.Color.White
        Me.txtHora3.Location = New System.Drawing.Point(111, 278)
        Me.txtHora3.Name = "txtHora3"
        Me.txtHora3.Size = New System.Drawing.Size(60, 29)
        Me.txtHora3.Text = "---"
        Me.txtHora3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtHora4
        '
        Me.txtHora4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtHora4.ForeColor = System.Drawing.Color.White
        Me.txtHora4.Location = New System.Drawing.Point(111, 313)
        Me.txtHora4.Name = "txtHora4"
        Me.txtHora4.Size = New System.Drawing.Size(60, 29)
        Me.txtHora4.Text = "---"
        Me.txtHora4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(169, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 29)
        Me.Label4.Text = "hs"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(169, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 29)
        Me.Label5.Text = "hs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(169, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 29)
        Me.Label6.Text = "hs"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(169, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 29)
        Me.Label7.Text = "hs"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSinDatos
        '
        Me.lblSinDatos.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSinDatos.ForeColor = System.Drawing.Color.Lime
        Me.lblSinDatos.Location = New System.Drawing.Point(160, 445)
        Me.lblSinDatos.Name = "lblSinDatos"
        Me.lblSinDatos.Size = New System.Drawing.Size(177, 36)
        Me.lblSinDatos.Text = "(Sin Datos)"
        '
        'rdER
        '
        Me.rdER.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdER.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdER.Location = New System.Drawing.Point(353, 433)
        Me.rdER.Name = "rdER"
        Me.rdER.Size = New System.Drawing.Size(123, 40)
        Me.rdER.TabIndex = 118
        Me.rdER.Text = "E/R"
        '
        'rdEM
        '
        Me.rdEM.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdEM.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdEM.Location = New System.Drawing.Point(353, 396)
        Me.rdEM.Name = "rdEM"
        Me.rdEM.Size = New System.Drawing.Size(123, 40)
        Me.rdEM.TabIndex = 119
        Me.rdEM.Text = "E/M"
        '
        'rdFS
        '
        Me.rdFS.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdFS.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdFS.Location = New System.Drawing.Point(353, 359)
        Me.rdFS.Name = "rdFS"
        Me.rdFS.Size = New System.Drawing.Size(123, 40)
        Me.rdFS.TabIndex = 120
        Me.rdFS.Text = "F/S"
        '
        'rdBien
        '
        Me.rdBien.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdBien.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdBien.Location = New System.Drawing.Point(354, 363)
        Me.rdBien.Name = "rdBien"
        Me.rdBien.Size = New System.Drawing.Size(123, 40)
        Me.rdBien.TabIndex = 140
        Me.rdBien.Text = "Bien"
        '
        'rdMal
        '
        Me.rdMal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdMal.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdMal.Location = New System.Drawing.Point(354, 411)
        Me.rdMal.Name = "rdMal"
        Me.rdMal.Size = New System.Drawing.Size(123, 40)
        Me.rdMal.TabIndex = 141
        Me.rdMal.Text = "Mal"
        '
        'rdSI
        '
        Me.rdSI.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdSI.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdSI.Location = New System.Drawing.Point(356, 365)
        Me.rdSI.Name = "rdSI"
        Me.rdSI.Size = New System.Drawing.Size(123, 40)
        Me.rdSI.TabIndex = 161
        Me.rdSI.Text = "SI"
        '
        'rdNO
        '
        Me.rdNO.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdNO.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.rdNO.Location = New System.Drawing.Point(356, 405)
        Me.rdNO.Name = "rdNO"
        Me.rdNO.Size = New System.Drawing.Size(123, 41)
        Me.rdNO.TabIndex = 162
        Me.rdNO.Text = "NO"
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.rdNO)
        Me.Controls.Add(Me.rdSI)
        Me.Controls.Add(Me.rdMal)
        Me.Controls.Add(Me.rdBien)
        Me.Controls.Add(Me.rdFS)
        Me.Controls.Add(Me.rdEM)
        Me.Controls.Add(Me.rdER)
        Me.Controls.Add(Me.lblSinDatos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHora4)
        Me.Controls.Add(Me.txtHora3)
        Me.Controls.Add(Me.txtHora2)
        Me.Controls.Add(Me.txtHora1)
        Me.Controls.Add(Me.txtFecha4)
        Me.Controls.Add(Me.txtFecha3)
        Me.Controls.Add(Me.txtFecha2)
        Me.Controls.Add(Me.txtFecha1)
        Me.Controls.Add(Me.txtMed4)
        Me.Controls.Add(Me.txtMed3)
        Me.Controls.Add(Me.txtMed2)
        Me.Controls.Add(Me.txtMed1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.CkAgregar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtEspecificacion)
        Me.Controls.Add(Me.txtCabecera)
        Me.Controls.Add(Me.btnAvanzar)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.lblUnidad)
        Me.Controls.Add(Me.txtOperador)
        Me.Controls.Add(Me.txtPlanta)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeBox = False
        Me.Name = "FrmDatos"
        Me.Text = "FrmDatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtPlanta As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAvanzar As System.Windows.Forms.Button
    Friend WithEvents txtCabecera As System.Windows.Forms.TextBox
    Friend WithEvents txtEspecificacion As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CkAgregar As System.Windows.Forms.CheckBox
    Friend WithEvents txtMed1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMed2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMed3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMed4 As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha1 As System.Windows.Forms.Label
    Friend WithEvents txtFecha2 As System.Windows.Forms.Label
    Friend WithEvents txtFecha4 As System.Windows.Forms.Label
    Friend WithEvents txtFecha3 As System.Windows.Forms.Label
    Friend WithEvents txtHora1 As System.Windows.Forms.Label
    Friend WithEvents txtHora2 As System.Windows.Forms.Label
    Friend WithEvents txtHora3 As System.Windows.Forms.Label
    Friend WithEvents txtHora4 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSinDatos As System.Windows.Forms.Label
    Friend WithEvents rdER As System.Windows.Forms.RadioButton
    Friend WithEvents rdEM As System.Windows.Forms.RadioButton
    Friend WithEvents rdFS As System.Windows.Forms.RadioButton
    Friend WithEvents rdBien As System.Windows.Forms.RadioButton
    Friend WithEvents rdMal As System.Windows.Forms.RadioButton
    Friend WithEvents rdSI As System.Windows.Forms.RadioButton
    Friend WithEvents rdNO As System.Windows.Forms.RadioButton
End Class

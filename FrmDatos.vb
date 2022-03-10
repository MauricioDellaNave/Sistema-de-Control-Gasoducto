Public Class FrmDatos

#Region "Variables"
    Dim oDatos As New Datos
    Dim oArchivo As New Archivos
    Dim indice As Integer = 0
    Dim indiceEsp As Integer = 0
    'Public IndiceDatos As Integer = 0
    Dim indiceValor As Integer = 1
    Dim IndiceFormato As Integer = 0
    Dim FinCarga As Boolean = False
    Dim IndiceMediciones1 As Integer = 1
    Dim IndiceMediciones2 As Integer = 1
    Dim IndiceMediciones3 As Integer = 1
    Dim IndiceMediciones4 As Integer = 1

    Private mHora As String
    Public Property Hora() As String
        Get
            Return mHora
        End Get
        Set(ByVal value As String)
            mHora = value
        End Set
    End Property

    Private mCodigo As String
    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal value As String)
            mCodigo = value
        End Set
    End Property


    Private mValor As Double
    Public Property Valor() As Double
        Get
            Return mValor
        End Get
        Set(ByVal value As Double)
            mValor = value
        End Set
    End Property


    Private mMax As Double
    Public Property Max() As Double
        Get
            Return mMax
        End Get
        Set(ByVal value As Double)
            mMax = value
        End Set
    End Property


    Private mMin As Double
    Public Property Min() As Double
        Get
            Return mMin
        End Get
        Set(ByVal value As Double)
            mMin = value
        End Set
    End Property




    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Sub New(ByVal pCodigo As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        mCodigo = pCodigo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region


#Region "Eventos del Formulario"

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        If (MsgBox("¿Esta seguro que desea regresar al menu principal? Perdera los datos cargados hasta el momento.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Información del Sistema")) = MsgBoxResult.Yes Then

            Me.Visible = False
            FrmPrincipal.Show()
        End If

    End Sub

    Private Sub FrmDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cargar los Vectores con los datos de las mediciones anteriores
        oDatos.CargarMedicionesAnteriores(mCodigo)

        'Cargo las mediciones anteriores en el formulario
        CargarMedicionesAnteriores(oDatos.EstadoAnterior, IndiceMediciones1, IndiceMediciones2, IndiceMediciones3, IndiceMediciones4)


        'limpio el formulario
        rdEM.Visible = False
        rdER.Visible = False
        rdFS.Visible = False
        btnAvanzar.Enabled = False
        btnAtras.Enabled = False
        lblSinDatos.Visible = False

        txtCabecera.Text = ""
        txtEspecificacion.Text = ""
        txtValor.Text = ""
        txtValor.Focus()
        CkAgregar.Visible = False

        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)

        txtPlanta.Text = FrmPrincipal.txtPlanta.Text
        txtOperador.Text = FrmPrincipal.txtOperador.Text

        'CARGO LAS CABECERAS EN EL VECTOR
        oDatos.Cabeceras.Clear()
        oDatos.BuscarCabeceras(Codigo)

        If oDatos.Cabeceras.Count > 0 Then

            'La condicion es que no sea Horario ni Condicional
            Dim Condicion As String
            Condicion = oDatos.Cabeceras.Item(indice)
            If (Condicion = "Horario") Then
                indice = indice + 1
                Condicion = oDatos.Cabeceras.Item(indice)
            End If
            If (Condicion = "Condicional ") Then
                indice = indice + 1
                Condicion = oDatos.Cabeceras.Item(indice)
            End If
            If (Condicion = "Cierre Diario") Then
                indice = indice + 1
                Condicion = oDatos.Cabeceras.Item(indice)
            End If

            txtCabecera.Text = oDatos.Cabeceras.Item(indice)

            'CARGO LOS DATOS PARA CADA CABECERA
            'Especificacion, etc 
            oDatos.CargarDatos(Codigo, txtCabecera.Text)

            txtEspecificacion.Text = oDatos.Especificacion.Item(indiceEsp)
            lblUnidad.Text = oDatos.Unidades.Item(indiceEsp)
            txtMax.Text = oDatos.Maximos.Item(indiceEsp)
            txtMin.Text = oDatos.Minimos.Item(indiceEsp)

            'PROBANDO FORMATO
            If oDatos.Formato.Item(indiceEsp) = "Alfanumerico" Then
                rdEM.Visible = True
                rdER.Visible = True
                rdFS.Visible = True
            Else
                rdEM.Visible = False
                rdER.Visible = False
                rdFS.Visible = False
            End If

            'PROBANDO FORMATO
            If oDatos.Formato.Item(indiceEsp) = "Bien/Mal" Then
                rdBien.Visible = True
                rdMal.Visible = True
            Else
                rdBien.Visible = False
                rdMal.Visible = False
            End If

            'PROBANDO FORMATO
            If oDatos.Formato.Item(indiceEsp) = "Si/No" Then
                rdSI.Visible = True
                rdNO.Visible = True
            Else
                rdSI.Visible = False
                rdNO.Visible = False
            End If


        Else

            ' Me.Visible = False
            'Me.Dispose()
            Me.Close()
            FrmCodigo.Show()
            MsgBox("El codigo ingresado no fue encontrado, verifiquelo e intente nuevamente.", MsgBoxStyle.Exclamation, "Informacion del Sistema")

        End If
        '  End If

    End Sub

    Private Sub btnAvanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvanzar.Click

        'GRABO EL DATO ANTERIOR MODIFICADO SI LO HAY
        ''   oDatos.Dato.Insert(oDatos.IndiceDatos - 1, txtValor.Text)

        btnAtras.Enabled = True

        oDatos.IndiceDatos = oDatos.IndiceDatos + 1


        If oDatos.Especificacion2.Count > oDatos.IndiceDatos Then

            txtCabecera.Text = oDatos.Cabeceras2.Item(oDatos.IndiceDatos)
            txtEspecificacion.Text = oDatos.Especificacion2.Item(oDatos.IndiceDatos)
            lblUnidad.Text = oDatos.Unidades2.Item(oDatos.IndiceDatos)
            txtMax.Text = oDatos.Maximos2.Item(oDatos.IndiceDatos)
            txtMin.Text = oDatos.Minimos2.Item(oDatos.IndiceDatos)
            txtValor.Text = oDatos.Dato.Item(oDatos.IndiceDatos)
            '  txtValor.Enabled = False

        Else

            'txtCabecera.Text = oDatos.Cabeceras.Item(indiceEsp)
            ''MsgBox(oDatos.Cabeceras2.Count)
            txtCabecera.Text = oDatos.Cabeceras2.Item(oDatos.IndiceDatos)
            txtEspecificacion.Text = oDatos.Especificacion.Item(indiceEsp)
            lblUnidad.Text = oDatos.Unidades.Item(indiceEsp)
            txtMax.Text = oDatos.Maximos.Item(indiceEsp)
            txtMin.Text = oDatos.Minimos.Item(indiceEsp)
            btnAvanzar.Enabled = False
            ' txtValor.Text = oDatos.Dato.Item(oDatos.IndiceDatos)
            'txtValor.Enabled = False
        End If




        IndiceFormato = IndiceFormato + 1
        'PROBANDO FORMATO ALFANUMERICO
        'MsgBox(oDatos.Formato.Item(IndiceFormato))
        If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
            rdEM.Visible = True
            rdER.Visible = True
            rdFS.Visible = True
            rdEM.Enabled = False
            rdER.Enabled = False
            rdFS.Enabled = False
        Else
            rdEM.Visible = False
            rdER.Visible = False
            rdFS.Visible = False
        End If

        'PROBANDO FORMATO
        If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
            rdBien.Visible = True
            rdMal.Visible = True
            rdBien.Enabled = False
            rdMal.Enabled = False
        Else
            rdBien.Visible = False
            rdMal.Visible = False
        End If

        'PROBANDO FORMATO
        If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
            rdSI.Visible = True
            rdNO.Visible = True
            rdSI.Enabled = False
            rdNO.Enabled = False
        Else
            rdSI.Visible = False
            rdNO.Visible = False
        End If


        If oDatos.IndiceDatos = oDatos.Dato.Count Then 'saque Or oDatos.Especificacion2.Count = oDatos.IndiceDatos + 1
            txtValor.Text = ""
            txtValor.Enabled = True
            btnOK.Enabled = True
            btnAvanzar.Enabled = False

            rdEM.Enabled = True
            rdER.Enabled = True
            rdFS.Enabled = True
            rdBien.Enabled = True
            rdMal.Enabled = True
            rdSI.Enabled = True
            rdNO.Enabled = True

            txtValor.Focus()
            oDatos.IndiceDatos = oDatos.IndiceDatos + 1
        Else
            ' txtValor.Text = oDatos.Dato.Item(oDatos.IndiceDatos)
            btnOK.Enabled = False
            btnAvanzar.Enabled = True
        End If

        'Cargo las mediciones anteriores en el formulario
        IndiceMediciones1 = IndiceMediciones1 + 1
        IndiceMediciones2 = IndiceMediciones2 + 1
        IndiceMediciones3 = IndiceMediciones3 + 1
        IndiceMediciones4 = IndiceMediciones4 + 1
        CargarMedicionesAnteriores(oDatos.EstadoAnterior, IndiceMediciones1, IndiceMediciones2, IndiceMediciones3, IndiceMediciones4)

    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        'Decremeno el indice
        oDatos.IndiceDatos = oDatos.IndiceDatos - 1


        'MsgBox(oDatos.Dato.Item(oDatos.IndiceDatos))
        'If txtValor.Text <> "" Then
        '    'GRABO EL DATO ANTERIOR MODIFICADO SI LO HAY
        '    oDatos.Dato.Insert(oDatos.IndiceDatos, txtValor.Text)
        'End If



        If oDatos.IndiceDatos = oDatos.Cabeceras2.Count Then
            'Si es el ultimo registro lo almaceno
            oDatos.Cabeceras2.Add(txtCabecera.Text)
        End If

        btnAvanzar.Enabled = True
        If oDatos.IndiceDatos > 0 Then

            If oDatos.IndiceDatos >= 1 Then
                'Los vectores comienzan indeice 0 x eso hago -1
                txtCabecera.Text = oDatos.Cabeceras2.Item(oDatos.IndiceDatos - 1)
                txtEspecificacion.Text = oDatos.Especificacion2.Item(oDatos.IndiceDatos - 1)
                txtMax.Text = oDatos.Maximos2.Item(oDatos.IndiceDatos - 1)
                txtMin.Text = oDatos.Minimos2.Item(oDatos.IndiceDatos - 1)
                lblUnidad.Text = oDatos.Unidades2.Item(oDatos.IndiceDatos - 1)
                txtValor.Text = oDatos.Dato.Item(oDatos.IndiceDatos - 1)

            End If


            ' txtValor.Enabled = False
            btnOK.Enabled = False

            'Cargo las mediciones anteriores en el formulario
            IndiceMediciones1 = IndiceMediciones1 - 1
            IndiceMediciones2 = IndiceMediciones2 - 1
            IndiceMediciones3 = IndiceMediciones3 - 1
            IndiceMediciones4 = IndiceMediciones4 - 1
            CargarMedicionesAnteriores(oDatos.EstadoAnterior, IndiceMediciones1, IndiceMediciones2, IndiceMediciones3, IndiceMediciones4)

        End If

        If IndiceFormato > 0 Then
            IndiceFormato = IndiceFormato - 1
        End If

        'PROBANDO FORMATO ALFANUMERICO
        'MsgBox(oDatos.Formato.Item(IndiceFormato))
        If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
            rdEM.Visible = True
            rdER.Visible = True
            rdFS.Visible = True
            rdEM.Enabled = False
            rdER.Enabled = False
            rdFS.Enabled = False
        Else
            rdEM.Visible = False
            rdER.Visible = False
            rdFS.Visible = False
        End If

        'PROBANDO FORMATO
        If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
            rdBien.Visible = True
            rdMal.Visible = True
            rdBien.Enabled = False
            rdMal.Enabled = False
        Else
            rdBien.Visible = False
            rdMal.Visible = False
        End If

        'PROBANDO FORMATO
        If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
            rdSI.Visible = True
            rdNO.Visible = True
            rdSI.Enabled = False
            rdNO.Enabled = False
        Else
            rdSI.Visible = False
            rdNO.Visible = False
        End If

        If oDatos.IndiceDatos = 1 Then
            btnAtras.Enabled = False
            oDatos.IndiceDatos = 0
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If txtValor.Text = "" Then
            MsgBox("Recuerde que la carga de datos no puede estar vacia. Si no dispone del valor apropiado pongase en contacto con el supervisor e intentelo nuevamente.", MsgBoxStyle.Exclamation, "Ingreso de Datos")
        Else

            btnAvanzar.Enabled = False
            btnAtras.Enabled = True
            '  IndiceDatos = IndiceDatos + 1
            indiceValor = indiceValor + 1

            'Cargo la hora de comienzo en la primera posicion
            CargarHoraComienzo()

            'cargo el estado solo para TURBINAS y MOTOGENERADORES
            If FrmEstados.txtEquipo.Text.Chars(0) = "T" Or FrmEstados.txtEquipo.Text.Chars(0) = "M" Then
                CargarEstado()
            End If


            'Cargo las mediciones anteriores en el formulario
            IndiceMediciones1 = IndiceMediciones1 + 1
            IndiceMediciones2 = IndiceMediciones2 + 1
            IndiceMediciones3 = IndiceMediciones3 + 1
            IndiceMediciones4 = IndiceMediciones4 + 1
            CargarMedicionesAnteriores(oDatos.EstadoAnterior, IndiceMediciones1, IndiceMediciones2, IndiceMediciones3, IndiceMediciones4)


            'ESPECIFICACION
            'Incremento el indice de especificaciones
            indiceEsp = indiceEsp + 1
            IndiceFormato = IndiceFormato + 1


            '///ACA ESTABA ANTES

            'Cargo datos en los vectores adicionales
            'Esto me permite recorrerlos con las flechas

            oDatos.Cabeceras2.Add(txtCabecera.Text)
            oDatos.Especificacion2.Add(txtEspecificacion.Text)
            oDatos.Unidades2.Add(lblUnidad.Text)
            oDatos.Maximos2.Add(txtMax.Text)
            oDatos.Minimos2.Add(txtMin.Text)
            oDatos.Dato.Add(txtValor.Text)

            oDatos.IndiceDatos = oDatos.IndiceDatos + 1



            If oDatos.Especificacion.Count > indiceEsp Then
                txtEspecificacion.Text = oDatos.Especificacion.Item(indiceEsp)
                lblUnidad.Text = oDatos.Unidades.Item(indiceEsp)
                txtMax.Text = oDatos.Maximos.Item(indiceEsp)
                txtMin.Text = oDatos.Minimos.Item(indiceEsp)

                'PROBANDO FORMATO ALFANUMERICO
                'MsgBox(oDatos.Formato.Item(IndiceFormato))
                If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
                    rdEM.Visible = True
                    rdER.Visible = True
                    rdFS.Visible = True
                Else
                    rdEM.Visible = False
                    rdER.Visible = False
                    rdFS.Visible = False
                End If

                'PROBANDO FORMATO
                If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
                    rdBien.Visible = True
                    rdMal.Visible = True
                Else
                    rdBien.Visible = False
                    rdMal.Visible = False
                End If

                'PROBANDO FORMATO
                If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
                    rdSI.Visible = True
                    rdNO.Visible = True
                Else
                    rdSI.Visible = False
                    rdNO.Visible = False
                End If

                'GUARDO LOS DATOS EN LA VARIABLE
                If txtValor.Text = "*" Then
                    oArchivo.VecArchivo.Add("S/D")
                Else
                    oArchivo.VecArchivo.Add(txtValor.Text)
                End If

                If CkAgregar.Checked = True Then
                    'GUARDO LA CANTIDAD DE ACEITE AGREGADO
                    oArchivo.VecArchivo.Add("A " & FrmAgregarAceite.AgregarAceite)
                End If

            End If


            'FIN DEL VECTOR ESPECIFICACION
            'GUARDO Y PASO A LA CABECERA SIGUIENTE
            If (indiceEsp = oDatos.Especificacion.Count) Then
                oDatos.limpiarBuffer()

                'GUARDO LOS DATOS EN LA VARIABLE
                If txtValor.Text = "*" Then
                    oArchivo.VecArchivo.Add("S/D")
                Else
                    oArchivo.VecArchivo.Add(txtValor.Text)
                End If
                If CkAgregar.Checked = True Then
                    'GUARDO LA CANTIDAD DE ACEITE AGREGADO
                    oArchivo.VecArchivo.Add("A " & FrmAgregarAceite.AgregarAceite)
                End If

                'CARGO DATOS PARA OTRA CABECERA
                If oDatos.Cabeceras.Count > indice Then

                    indice = indice + 1

                    'Valido en el caso de estar fuera del indice

                    If indice < oDatos.Cabeceras.Count Then
                        oDatos.CargarDatos(Codigo, oDatos.Cabeceras(indice))
                        txtCabecera.Text = oDatos.Cabeceras.Item(indice)

                        txtEspecificacion.Text = oDatos.Especificacion.Item(0)
                        lblUnidad.Text = oDatos.Unidades.Item(0)
                        txtMax.Text = oDatos.Maximos.Item(0)
                        txtMin.Text = oDatos.Minimos.Item(0)

                        'IndiceFormato = IndiceFormato + 1

                        'PROBANDO FORMATO
                        ' MsgBox(oDatos.Formato.Item(IndiceFormato))
                        If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
                            rdEM.Visible = True
                            rdER.Visible = True
                            rdFS.Visible = True
                        Else
                            rdEM.Visible = False
                            rdER.Visible = False
                            rdFS.Visible = False
                        End If

                        'PROBANDO FORMATO
                        If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
                            rdBien.Visible = True
                            rdMal.Visible = True
                        Else
                            rdBien.Visible = False
                            rdMal.Visible = False
                        End If

                        'PROBANDO FORMATO
                        If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
                            rdSI.Visible = True
                            rdNO.Visible = True
                        Else
                            rdSI.Visible = False
                            rdNO.Visible = False
                        End If

                        ' btnAtras.Enabled = True
                        ' btnAvanzar.Enabled = True

                        indiceEsp = 0

                        'NIVEL DE ACEITE
                        If txtCabecera.Text = "Nivel de Aceite (Condicional)" Then
                            CkAgregar.Visible = True
                            CkAgregar.Checked = False
                        Else
                            CkAgregar.Visible = False
                            CkAgregar.Checked = False
                        End If

                    End If

                    'Fin de carga 
                    ValidarFindeCarga()

                End If

            End If


            'Valido para CIERRE DIARIO
            'COPIAR LOS MISMO EN LA TECLA ENTER KEY
            If txtEspecificacion.Text = "Carga de Aceite" And Codigo = "PGOT200/5" Then

                'llamo a la funcion de buscar cargas de aceite
                'oArchivo.BuscarCargaAceite(mCodigo)
                'txtValor.Text = "1234"
                'txtValor.Enabled = False
            Else

                'txtValor.Enabled = True
                'Solucion F2 no activa luego de una carga
                If FinCarga = False Then
                    CkAgregar.Checked = False
                    txtValor.Text = ""
                    txtValor.Focus()
                Else
                    FrmPrincipal.BtnRonda.Focus()
                End If

            End If






        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblHora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        FrmObservaciones.txtPlanta.Text = txtPlanta.Text
        FrmObservaciones.txtOperador.Text = txtOperador.Text
        FrmObservaciones.txtObservacion.Text = ""
        FrmObservaciones.Show()
        FrmObservaciones.Visible = True
    End Sub

    Private Sub txtValor_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.GotFocus
        rdMal.Checked = False
        rdBien.Checked = False
        rdEM.Checked = False
        rdER.Checked = False
        rdFS.Checked = False
        txtValor.Text = ""

    End Sub

    Private Sub txtValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtValor.KeyDown
        If e.KeyData = Keys.Enter Then

            If txtValor.Text = "" Then
                MsgBox("Recuerde que la carga de datos no puede estar vacia. Si no dispone del valor apropiado pongase en contacto con el supervisor e intentelo nuevamente.", MsgBoxStyle.Exclamation, "Ingreso de Datos")
            Else
                btnAvanzar.Enabled = False
                btnAtras.Enabled = True
                'Cargo la hora de comienzo en la primera posicion
                CargarHoraComienzo()

                'cargo el estado solo para TURBINAS y MOTOGENERADORES
                If FrmEstados.txtEquipo.Text.Chars(0) = "T" Or FrmEstados.txtEquipo.Text.Chars(0) = "M" Then
                    CargarEstado()
                End If

                'Cargo las mediciones anteriores en el formulario
                IndiceMediciones1 = IndiceMediciones1 + 1
                IndiceMediciones2 = IndiceMediciones2 + 1
                IndiceMediciones3 = IndiceMediciones3 + 1
                IndiceMediciones4 = IndiceMediciones4 + 1
                CargarMedicionesAnteriores(oDatos.EstadoAnterior, IndiceMediciones1, IndiceMediciones2, IndiceMediciones3, IndiceMediciones4)


                'ESPECIFICACION
                'Incremento el indice de especificaciones
                indiceEsp = indiceEsp + 1
                IndiceFormato = IndiceFormato + 1

                'Cargo datos en los vectores adicionales
                'Esto me permite recorrerlos con las flechas
                oDatos.Cabeceras2.Add(txtCabecera.Text)
                oDatos.Especificacion2.Add(txtEspecificacion.Text)
                oDatos.Unidades2.Add(lblUnidad.Text)
                oDatos.Maximos2.Add(txtMax.Text)
                oDatos.Minimos2.Add(txtMin.Text)
                oDatos.Dato.Add(txtValor.Text)
                oDatos.IndiceDatos = oDatos.IndiceDatos + 1

                If oDatos.Especificacion.Count > indiceEsp Then
                    txtEspecificacion.Text = oDatos.Especificacion.Item(indiceEsp)
                    lblUnidad.Text = oDatos.Unidades.Item(indiceEsp)
                    txtMax.Text = oDatos.Maximos.Item(indiceEsp)
                    txtMin.Text = oDatos.Minimos.Item(indiceEsp)

                    'PROBANDO FORMATO
                    If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
                        rdEM.Visible = True
                        rdER.Visible = True
                        rdFS.Visible = True
                    Else
                        rdEM.Visible = False
                        rdER.Visible = False
                        rdFS.Visible = False
                    End If

                    'PROBANDO FORMATO
                    If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
                        rdBien.Visible = True
                        rdMal.Visible = True
                    Else
                        rdBien.Visible = False
                        rdMal.Visible = False
                    End If

                    'PROBANDO FORMATO
                    If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
                        rdSI.Visible = True
                        rdNO.Visible = True
                    Else
                        rdSI.Visible = False
                        rdNO.Visible = False
                    End If

                    'GUARDO LOS DATOS EN LA VARIABLE
                    If txtValor.Text = "*" Then
                        oArchivo.VecArchivo.Add("S/D")
                    Else
                        oArchivo.VecArchivo.Add(txtValor.Text)
                    End If
                    If CkAgregar.Checked = True Then
                        'GUARDO LA CANTIDAD DE ACEITE AGREGADO
                        oArchivo.VecArchivo.Add("A " & FrmAgregarAceite.AgregarAceite)
                    End If

                End If


                'FIN DEL VECTOR ESPECIFICACION
                'GUARDO Y PASO A LA CABECERA SIGUIENTE
                If (indiceEsp = oDatos.Especificacion.Count) Then
                    oDatos.limpiarBuffer()

                    'GUARDO LOS DATOS EN LA VARIABLE
                    If txtValor.Text = "*" Then
                        oArchivo.VecArchivo.Add("S/D")
                    Else
                        oArchivo.VecArchivo.Add(txtValor.Text)
                    End If
                    If CkAgregar.Checked = True Then
                        'GUARDO LA CANTIDAD DE ACEITE AGREGADO
                        oArchivo.VecArchivo.Add("A " & FrmAgregarAceite.AgregarAceite)
                    End If

                    'CARGO DATOS PARA OTRA CABECERA
                    If oDatos.Cabeceras.Count > indice Then

                        indice = indice + 1

                        'Valido en el caso de estar fuera del indice

                        If indice < oDatos.Cabeceras.Count Then
                            oDatos.CargarDatos(Codigo, oDatos.Cabeceras(indice))
                            txtCabecera.Text = oDatos.Cabeceras.Item(indice)

                            txtEspecificacion.Text = oDatos.Especificacion.Item(0)
                            lblUnidad.Text = oDatos.Unidades.Item(0)
                            txtMax.Text = oDatos.Maximos.Item(0)
                            txtMin.Text = oDatos.Minimos.Item(0)
                            ' btnAtras.Enabled = True
                            ' btnAvanzar.Enabled = True

                            'PROBANDO FORMATO
                            ' MsgBox(oDatos.Formato.Item(IndiceFormato))
                            If oDatos.Formato.Item(IndiceFormato) = "Alfanumerico" Then
                                rdEM.Visible = True
                                rdER.Visible = True
                                rdFS.Visible = True
                            Else
                                rdEM.Visible = False
                                rdER.Visible = False
                                rdFS.Visible = False
                            End If

                            'PROBANDO FORMATO
                            If oDatos.Formato.Item(IndiceFormato) = "Bien/Mal" Then
                                rdBien.Visible = True
                                rdMal.Visible = True
                            Else
                                rdBien.Visible = False
                                rdMal.Visible = False
                            End If

                            'PROBANDO FORMATO
                            If oDatos.Formato.Item(IndiceFormato) = "Si/No" Then
                                rdSI.Visible = True
                                rdNO.Visible = True
                            Else
                                rdSI.Visible = False
                                rdNO.Visible = False
                            End If

                            indiceEsp = 0


                            'NIVEL DE ACEITE
                            If txtCabecera.Text = "Nivel de Aceite (Condicional)" Then
                                CkAgregar.Visible = True
                                CkAgregar.Checked = False
                            Else
                                CkAgregar.Visible = False
                                CkAgregar.Checked = False
                            End If

                        End If

                        'Fin de carga 
                        ValidarFindeCarga()

                    End If

                End If


                'Valido para CIERRE DIARIO
                'COPIAR LOS MISMO EN LA TECLA ENTER KEY
                If txtEspecificacion.Text = "Carga de Aceite" And Codigo = "PGOT200/5" Then

                    'llamo a la funcion de buscar cargas de aceite
                    'oArchivo.BuscarCargaAceite(mCodigo)
                    'txtValor.Text = "1234"
                    'txtValor.Enabled = False
                Else

                    'txtValor.Enabled = True
                    'Solucion F2 no activa luego de una carga
                    If FinCarga = False Then
                        CkAgregar.Checked = False
                        txtValor.Text = ""
                        txtValor.Focus()
                    Else
                        FrmPrincipal.BtnRonda.Focus()
                    End If

                End If

            End If

        End If
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If IsNumeric(e.KeyChar) Then
            ColorearAlertas()
        End If
    End Sub

    Private Sub CkAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CkAgregar.Click
        If CkAgregar.Checked = True Then
            FrmAgregarAceite.Visible = True
            FrmAgregarAceite.txtEquipo.Text = txtEspecificacion.Text
            FrmAgregarAceite.txtAceite.Focus()
        End If
    End Sub

    Private Sub txtValor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged

        If Not IsNumeric(txtValor.Text) And txtValor.Text <> "-" And txtValor.Text <> "*" And txtValor.Text <> "E/R" And txtValor.Text <> "F/S" And txtValor.Text <> "E/M" And txtValor.Text <> "E/S" And txtValor.Text <> "Bien" And txtValor.Text <> "Mal" And txtValor.Text <> "SI" And txtValor.Text <> "NO" Then
            txtValor.Text = ""
        Else
            If txtValor.Text <> "E/R" And txtValor.Text <> "F/S" And txtValor.Text <> "E/M" And txtValor.Text <> "E/S" And txtValor.Text <> "Bien" And txtValor.Text <> "Mal" And txtValor.Text <> "SI" And txtValor.Text <> "NO" Then
                ColorearAlertas()
            End If
        End If

        If txtValor.Text = "*" Then
            lblSinDatos.Visible = True
        Else
            lblSinDatos.Visible = False
        End If


    End Sub

#End Region

#Region "Procedimientos"

    Public Sub ColorearAlertas()
        If txtValor.TextLength > 2 And txtValor.Text <> "  " Then
            mValor = txtValor.Text
        Else
            mValor = 0.0
        End If

        If txtValor.Text = "" Or txtValor.Text = " " Or txtValor.Text = "-" Or txtValor.Text = "*" Then
            mValor = 0.0
        Else
            mValor = txtValor.Text
        End If

        If txtMin.Text = "" Then
            mMin = 0.0
        Else
            If txtMin.Text <> "n/a" Then
                mMin = txtMin.Text.Replace(",", ".")
            End If

        End If

        If txtMax.Text = "" Then
            mMax = 0.0
        Else
            If txtMax.Text <> "n/a" Then
                mMax = txtMax.Text.Replace(",", ".")
            End If

        End If

        txtValor.BackColor = Color.LightBlue
        If mValor < mMin Then
            txtValor.BackColor = Color.Yellow
        End If

        If mValor > mMax And mMax <> 0.0 Then
            txtValor.BackColor = Color.Red
        End If

    End Sub

    Public Sub ValidarFindeCarga()
        If oDatos.Cabeceras.Count = indice Then

            txtMed1.Text = ""
            txtMed2.Text = ""
            txtMed3.Text = ""
            txtMed4.Text = ""

            MsgBox("Se completo la carga de datos.", MsgBoxStyle.Exclamation, "Información del Sistema")

            'GUARDAR REGISTROS EN ARCHIVO DE SALIDA

            'Antes de cargar la hora debo verificar si cargo la observacion

            If FrmObservaciones.Observacion <> "" Then
                oArchivo.VecArchivo.Add(FrmObservaciones.Observacion)
            End If
            FrmObservaciones.Observacion = ""

            'Cargo la hora de finalizacion
            oArchivo.VecArchivo.Add(Date.Now.ToString("HH:mm"))


            'DEbo verificar si es una toma nueva o corresponde a una abierta
            'paso el codigo y la hora seleccionada
            oArchivo.CrearArchivoSalida(Codigo, True, Hora)
            oDatos.limpiarVectores()

            Me.Visible = False
            FrmPrincipal.Show()
            FrmPrincipal.BtnRonda.Focus()
            FinCarga = True
        Else
            FinCarga = False

        End If
    End Sub

    Public Sub CargarHoraComienzo()

        If oArchivo.VecArchivo.Count > 0 Then
            oArchivo.VecArchivo(0) = Hora
        Else
            oArchivo.VecArchivo.Add(Hora)
        End If
    End Sub

    Public Sub CargarEstado()
        If FrmEstados.EstadoActual <> "" Then
            If oArchivo.VecArchivo.Count > 1 Then
                oArchivo.VecArchivo(1) = FrmEstados.EstadoActual
            Else
                oArchivo.VecArchivo.Add(FrmEstados.EstadoActual)
            End If
        End If
    End Sub

    'CARGA LAS MEDICIONES DEL DIA ANTERIOR

    Public Sub CargarMedicionesAnteriores(ByVal pAnterior As Boolean, ByVal pIndice1 As Integer, ByVal pIndice2 As Integer, ByVal pIndice3 As Integer, ByVal pIndice4 As Integer)
        If oDatos.MedAnterior1.Count > pIndice1 Then
            'FECHA
            If pAnterior = True Then
                txtFecha1.Text = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                DateTime.Now.AddDays(1)
            Else
                txtFecha1.Text = DateTime.Now.ToString("dd/MM/yyyy")
            End If
            'MEDICIONES
            txtHora1.Text = oDatos.MedAnterior1(0)
            'If oDatos.MedAnterior1(pIndice1) <> "E/S" And oDatos.MedAnterior1(pIndice1) <> "E/R" And oDatos.MedAnterior1(pIndice1) <> "E/MNP" And oDatos.MedAnterior1(pIndice1) <> "E/MP" Then
            '    txtMed1.Text = oDatos.MedAnterior1(pIndice1)
            'Else
            '    IndiceMediciones1 = IndiceMediciones1 + 1
            '    txtMed1.Text = oDatos.MedAnterior1(IndiceMediciones1)
            'End If
            If pIndice1 = 1 And (oDatos.MedAnterior1(1) = "E/S" Or oDatos.MedAnterior1(1) = "E/R" Or oDatos.MedAnterior1(1) = "E/MNP" Or oDatos.MedAnterior1(1) = "E/MP") Then
                IndiceMediciones1 = IndiceMediciones1 + 1
                txtMed1.Text = oDatos.MedAnterior1(IndiceMediciones1)
            Else
                txtMed1.Text = oDatos.MedAnterior1(pIndice1)
            End If
        End If

        If oDatos.MedAnterior2.Count > pIndice2 Then
            'FECHA
            If pAnterior = True Then
                txtFecha2.Text = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                DateTime.Now.AddDays(1)
            Else
                txtFecha2.Text = DateTime.Now.ToString("dd/MM/yyyy")
            End If
            'MEDICIONES
            txtHora2.Text = oDatos.MedAnterior2(0)
            'If oDatos.MedAnterior2(pIndice2) <> "E/S" And oDatos.MedAnterior2(pIndice2) <> "E/R" And oDatos.MedAnterior2(pIndice2) <> "E/MNP" And oDatos.MedAnterior2(pIndice2) <> "E/MP" Then
            '    txtMed2.Text = oDatos.MedAnterior2(pIndice2)
            'Else
            '    IndiceMediciones2 = IndiceMediciones2 + 1
            '    txtMed2.Text = oDatos.MedAnterior2(IndiceMediciones2)
            'End If
            If pIndice2 = 1 And (oDatos.MedAnterior2(1) = "E/S" Or oDatos.MedAnterior2(1) = "E/R" Or oDatos.MedAnterior2(1) = "E/MNP" Or oDatos.MedAnterior2(1) = "E/MP") Then
                IndiceMediciones2 = IndiceMediciones2 + 1
                txtMed2.Text = oDatos.MedAnterior2(IndiceMediciones2)
            Else
                txtMed2.Text = oDatos.MedAnterior2(pIndice2)
            End If
        End If

        If oDatos.MedAnterior3.Count > pIndice3 Then
            'FECHA
            If pAnterior = True Then
                txtFecha3.Text = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                DateTime.Now.AddDays(1)
            Else
                txtFecha3.Text = DateTime.Now.ToString("dd/MM/yyyy")
            End If
            txtHora3.Text = oDatos.MedAnterior3(0)
            'MEDICIONES
            'If oDatos.MedAnterior3(pIndice3) <> "E/S" And oDatos.MedAnterior3(pIndice3) <> "E/R" And oDatos.MedAnterior3(pIndice3) <> "E/MNP" And oDatos.MedAnterior3(pIndice3) <> "E/MP" Then
            '    txtMed3.Text = oDatos.MedAnterior3(pIndice3)
            'Else
            '    IndiceMediciones3 = IndiceMediciones3 + 1
            '    txtMed3.Text = oDatos.MedAnterior3(IndiceMediciones3)
            'End If
            If pIndice3 = 1 And (oDatos.MedAnterior3(1) = "E/S" Or oDatos.MedAnterior3(1) = "E/R" Or oDatos.MedAnterior3(1) = "E/MNP" Or oDatos.MedAnterior3(1) = "E/MP") Then
                IndiceMediciones3 = IndiceMediciones3 + 1
                txtMed3.Text = oDatos.MedAnterior3(IndiceMediciones3)
            Else
                txtMed3.Text = oDatos.MedAnterior3(pIndice3)
            End If
        End If

        If oDatos.MedAnterior4.Count > pIndice4 Then
            'FECHA
            If pAnterior = True Then
                txtFecha4.Text = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                DateTime.Now.AddDays(1)
            Else
                txtFecha4.Text = DateTime.Now.ToString("dd/MM/yyyy")
            End If
            txtHora4.Text = oDatos.MedAnterior4(0)

            'MEDICIONES
            'If oDatos.MedAnterior4(1) <> "E/S" And oDatos.MedAnterior4(1) <> "E/R" And oDatos.MedAnterior4(1) <> "E/MNP" And oDatos.MedAnterior4(1) <> "E/MP" Then
            '    txtMed4.Text = oDatos.MedAnterior4(pIndice4)
            'Else
            '    IndiceMediciones4 = IndiceMediciones4 + 1
            '    txtMed4.Text = oDatos.MedAnterior4(IndiceMediciones4)
            'End If

            If pIndice4 = 1 And (oDatos.MedAnterior4(1) = "E/S" Or oDatos.MedAnterior4(1) = "E/R" Or oDatos.MedAnterior4(1) = "E/MNP" Or oDatos.MedAnterior4(1) = "E/MP") Then
                IndiceMediciones4 = IndiceMediciones4 + 1
                txtMed4.Text = oDatos.MedAnterior4(IndiceMediciones4)
            Else
                txtMed4.Text = oDatos.MedAnterior4(pIndice4)
            End If
        End If
    End Sub

#End Region

    Private Sub rdFS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFS.CheckedChanged
        txtValor.Text = "F/S"
        btnOK.Focus()
    End Sub

    Private Sub rdEM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdEM.CheckedChanged
        txtValor.Text = "E/M"
        btnOK.Focus()
    End Sub

    Private Sub rdES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdER.Click
        txtValor.Text = "E/R"
        btnOK.Focus()
    End Sub

    Private Sub rdBien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdBien.Click
        txtValor.Text = "Bien"
        btnOK.Focus()
    End Sub

    Private Sub rdMal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdMal.Click
        txtValor.Text = "Mal"
        btnOK.Focus()
    End Sub

    Private Sub rdNO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdNO.Click
        txtValor.Text = "NO"
        btnOK.Focus()
    End Sub

    Private Sub rdSI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSI.Click
        txtValor.Text = "SI"
        btnOK.Focus()
    End Sub


End Class
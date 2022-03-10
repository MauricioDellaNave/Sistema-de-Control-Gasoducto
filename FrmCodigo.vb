Public Class FrmCodigo

    Dim tiempo As Integer = 0

    Private mHoraSeleccionada As String
    Public Property HoraSeleccionada() As String
        Get
            Return mHoraSeleccionada
        End Get
        Set(ByVal value As String)
            mHoraSeleccionada = value
        End Set
    End Property


    Private Sub FrmCodigo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Se inicializa el formulario
        PictureBox1.BackColor = Color.Transparent
        'txtCodigo.Focus()
        txtCodigo.Visible = True
        btnTeclado.Visible = True
        lblCodigo.Visible = True
        txtEquipo.Visible = False

        HoraActual.Visible = True
        HoraAnterior.Visible = False
        HoraPosterior.Visible = False

        txtPlanta.Text = FrmPrincipal.txtPlanta.Text
        txtOperador.Text = FrmPrincipal.txtOperador.Text
        BtnAceptar.Enabled = False

        ActualizarHorarios()

        If FrmPrincipal.txtIndice.Text <> "" Then
            txtHora.SelectedIndex = FrmPrincipal.txtIndice.Text
        Else
            txtHora.SelectedIndex = 1
        End If


        If FrmTeclado.rdON.Checked = True Then
            btnTeclado.Enabled = True
        Else
            btnTeclado.Enabled = False
        End If

        If FrmPrincipal.txtEstado.Text = True Then

            Select Case FrmPrincipal.txtOpcion.Text
                Case 0
                    HoraAnterior.Visible = True
                    HoraActual.Visible = False
                    HoraPosterior.Visible = False
                Case 1
                    HoraActual.Visible = True
                    HoraAnterior.Visible = False
                    HoraPosterior.Visible = False
                Case 2
                    HoraPosterior.Visible = True
                    HoraActual.Visible = False
                    HoraAnterior.Visible = False
            End Select

            txtHora.Enabled = False
            txtCodigo.Visible = True
            lblCodigo.Visible = True
            BtnAceptar.Enabled = False
            txtCodigo.Focus()
            'btnHora.Enabled = False

        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Visible = False
        FrmPrincipal.Visible = True
    End Sub

    Private Sub btnTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtCodigo.Focus()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        'Se lee el codigo de barra
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then

            'VERIFICAR SI EN ESE HORARIO YA FUE CARGADA LA PLANILLA

            'Verificar si existe archivo para esa fecha
            'Verificar si existe registro para esa hora

            Dim mFecha As String = ""
            Dim vInicio As String = "06:00"

            mHoraSeleccionada = txtHora.SelectedItem

            'Las fechas de las jornadas de trabajo comienzan a las 06:00 AM 
            If mHoraSeleccionada.Length < vInicio.Length Then
                vInicio = "6:00"
            Else
                vInicio = "06:00"
            End If

            If mHoraSeleccionada >= vInicio Then
                mFecha = DateTime.Now.ToString("dd-MM-yyyy")
            Else

                mFecha = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                DateTime.Now.AddDays(1)
            End If



            'Reservo el horario de la planilla
            FrmPrincipal.txtEstado.Text = "True"
            TimerHoraSeleccionada.Enabled = True

            Dim oArchivo As New Archivos
            Dim mRuta As String = txtCodigo.Text & "-" & mFecha
            mRuta = mRuta.Replace("/", "-")

            If txtHora.SelectedIndex >= 0 Then
                FrmEstados.Hora = txtHora.SelectedItem
            Else
                FrmEstados.Hora = FrmPrincipal.txtHora.Text
            End If

            If oArchivo.ExisteArchivoSalida(mRuta) = True And oArchivo.BuscarHoraPlanilla(FrmEstados.Hora, mRuta) = True Then

                MsgBox("El código de planilla ingresado ya fue finalizado. Por favor seleccione otro horario de carga.", MsgBoxStyle.Critical, "Información del Sistema")

                'Detengo el timer que retiene el horario seleccionado
                'TimerHoraSeleccionada.Enabled = False
                If txtHora.Enabled = True Then
                    FrmPrincipal.txtEstado.Text = "False"
                End If

                Dim FrmC As New FrmCodigo

                FrmC.txtPlanta.Text = txtPlanta.Text
                FrmC.txtOperador.Text = txtOperador.Text

                FrmC.txtEquipo.Text = ""
                FrmC.txtCodigo.Text = ""
                FrmC.txtCodigo.Enabled = True
                FrmC.txtCodigo.Visible = False
                FrmC.btnTeclado.Visible = False
                FrmC.lblCodigo.Visible = False

                FrmC.Show()
                FrmC.txtCodigo.Focus()


            Else


                Dim oPlanilla As New Planilla
                'Verifico que el codigo escaneado exista en el archivo
                If oPlanilla.ExistePlanilla(txtCodigo.Text) = True Then
                    'Segundo extraemos el Codigo de planilla del codigo de barras
                    'Y buscamos a que equipo corresponde
                    Dim mCode As String
                    mCode = oPlanilla.ObtenerCodigo(txtCodigo.Text)
                    txtEquipo.Visible = True
                    Me.txtEquipo.Text = oPlanilla.BuscarEquipo(mCode, txtCodigo.Text)

                    FrmEstados.rdES.Checked = False
                    FrmEstados.rdER.Checked = False
                    FrmEstados.rdEM.Checked = False
                    FrmEstados.rdFS.Checked = False


                    ' MsgBox(Me.txtEquipo.Text.Chars(1))
                    'Verifico el estado anterior del equipo
                    If Me.txtEquipo.Text.Chars(0) = "T" Or Me.txtEquipo.Text.Chars(0) = "M" Then

                        Dim mEstado As String
                        'Busco el estado anterior del equipo en el archivo con los datos recolectados
                        'Paso por paramero la fecha ya que el dia comienza a las 06 y no a las 00
                        mEstado = oArchivo.BuscarEstadoEquipo(txtCodigo.Text, mFecha)
                        If mEstado <> "E/R" And mEstado <> "E/MNP" And mEstado <> "E/MP" And mEstado <> "E/S" Then
                            mEstado = "E/R"
                        End If
                        FrmEstados.EstadoAnterior = mEstado

                        If mEstado <> "E/S" Then
                            'Verificar o cambiar los estados para TURBINAS y MOTOGENERADORES
                            EstadoEquipos()
                        Else
                            If mEstado = "E/S" Then
                                If (MsgBox("El equipo se encuentra en Servicio. ¿Desea continuar con ese Estado?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Información")) = MsgBoxResult.Yes Then
                                Else
                                    'Verificar o cambiar los estados para TURBINAS y MOTOGENERADORES
                                    EstadoEquipos()
                                    FrmEstados.rdES.Checked = True
                                End If
                            End If
                            'FrmEstados.txtEquipo.Text = "T"
                            FrmEstados.EstadoActual = mEstado
                        End If

                    Else
                        'limpio el equipo
                        FrmEstados.txtEquipo.Text = "VACIO"
                    End If



                    Me.txtCodigo.Enabled = False
                    BtnAceptar.Enabled = True
                    txtHora.Enabled = False
                    Me.BtnAceptar.Focus()

                Else
                    Me.txtEquipo.Text = ""
                    Me.txtCodigo.Text = ""
                    MsgBox("El codigo ingresado no ha sido encontrado, intentelo nuevamente o contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Importante")
                    Me.txtCodigo.Enabled = True
                    txtCodigo.Focus()
                End If

            End If

        End If

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'VERIFICAR SI EN ESE HORARIO YA FUE CARGADA LA PLANILLA

        'Verificar si existe archivo para esa fecha
        'Verificar si existe registro para esa hora

        'Reservo el horario de la planilla
        FrmPrincipal.txtEstado.Text = "True"
        TimerHoraSeleccionada.Enabled = True




        Dim oArchivo As New Archivos
        Dim mRuta As String = txtCodigo.Text & "-" & DateTime.Now.ToString("dd-MM-yyyy")
        ' Dim mHoraSeleccionada As String

        If txtHora.SelectedIndex >= 0 Then
            mHoraSeleccionada = txtHora.SelectedItem
        Else
            mHoraSeleccionada = FrmPrincipal.txtHora.Text
        End If

        mRuta = mRuta.Replace("/", "-")

        If oArchivo.ExisteArchivoSalida(mRuta) = True And oArchivo.BuscarHoraPlanilla(mHoraSeleccionada, mRuta) = True Then

            MsgBox("El código de planilla ingresado ya fue finalizado. Por favor seleccione otro horario de carga.", MsgBoxStyle.Critical, "Información del Sistema")

            'Detengo el timer que retiene el horario seleccionado
            'TimerHoraSeleccionada.Enabled = False
            If txtHora.Enabled = True Then
                FrmPrincipal.txtEstado.Text = "False"
            End If


            Dim FrmC As New FrmCodigo

            FrmC.txtPlanta.Text = txtPlanta.Text
            FrmC.txtOperador.Text = txtOperador.Text

            FrmC.txtEquipo.Text = ""
            FrmC.txtCodigo.Text = ""
            FrmC.txtCodigo.Enabled = True
            FrmC.txtCodigo.Visible = False
            FrmC.btnTeclado.Visible = False
            FrmC.lblCodigo.Visible = False

            FrmC.Show()
            FrmC.txtHora.Focus()


        Else
            Me.InputPanel1.Enabled = False

            'Cargo el nombre del Equipo en el formulario de estados
            FrmDatos.Codigo = txtCodigo.Text
            FrmEstados.txtEquipo.Text = Me.txtEquipo.Text

            Dim mFrm As New FrmDatos(txtCodigo.Text)
            mFrm.Show()


            If txtHora.SelectedIndex >= 0 Then
                mFrm.Hora = txtHora.SelectedItem
            Else
                mFrm.Hora = FrmPrincipal.txtHora.Text
            End If

        End If

    End Sub

    Public Sub ActualizarHorarios()

        Dim pCada As Integer = 2
        Dim mHoraActual() As String
        Dim mAux As String
        Dim mMin As Integer = 0
        Dim mSuma As Integer = 0
        Dim mResta As Integer = 0

        'Hora Actual del Sistema
        txtHora.Items(1) = String.Format("{0:HH:mm}", DateTime.Now)
        mAux = txtHora.Items(1)
        mHoraActual = mAux.Split(":")

        'APLICO EL REDONDEO
        'Primero con los minutos
        If mHoraActual(1) > 30 Then
            mHoraActual(0) = mHoraActual(0) + 1
        End If
        'Luego para que los horarios sean PARES
        If EsPar(mHoraActual(0)) Then
        Else
            mHoraActual(0) = mHoraActual(0) + 1
        End If



        'Hora Actual con Redondeo
        If mHoraActual(0) < 10 And mHoraActual(0).Length < 2 Then
            txtHora.Items(1) = "0" & mHoraActual(0) & ":00"
        Else
            If mHoraActual(0) = 24 Then
                txtHora.Items(1) = "00:00"
            Else
                txtHora.Items(1) = mHoraActual(0) & ":00"
            End If

        End If


        'Calcular Hora Posterior
        mSuma = mHoraActual(0) + pCada
        If mSuma >= 24 Then
            txtHora.Items(2) = "0" & mSuma - 24 & ":00"
        Else
            If mSuma < 10 Then
                txtHora.Items(2) = "0" & mSuma & ":00"
            Else
                txtHora.Items(2) = mSuma & ":00"
            End If
        End If

        'Calcular Hora Anterior
        mResta = mHoraActual(0) - pCada
        If mResta < 0 Then
            txtHora.Items(0) = mResta + 24 & ":00"
        Else
            If mResta < 10 Then
                txtHora.Items(0) = "0" & mResta & ":00"
            Else
                txtHora.Items(0) = mResta & ":00"
            End If
        End If



        If FrmHora.HoraEditada = True Then

            'Hora Actual del Sistema
            mAux = FrmHora.txtHora.Text
            mHoraActual = mAux.Split(":")

            If FrmHora.txtID.Text = 0 Then
                ' Hora Anterior
                txtHora.Items(0) = mHoraActual(0) & ":00"
            End If
            If FrmHora.txtID.Text = 1 Then
                ' Hora Actual
                txtHora.Items(1) = mHoraActual(0) & ":00"
            End If
            If FrmHora.txtID.Text = 2 Then
                ' Hora Posterior
                txtHora.Items(2) = mHoraActual(0) & ":00"
            End If

        End If

    End Sub

    Public Sub EstadoEquipos()
        Dim mValor As String = Me.txtEquipo.Text.Substring(0, 1)
        If mValor.Equals("T") Then
            Me.Visible = False
            FrmEstados.txtEquipo.Text = txtEquipo.Text
            FrmEstados.txtDescripcion.Text = "TURBINAS"
            FrmEstados.Codigo = txtCodigo.Text
            FrmEstados.Show()
        End If

        If mValor.Equals("M") Then
            Me.Visible = False
            FrmEstados.txtDescripcion.Text = "MOTOGENERADORES"
            FrmEstados.txtEquipo.Text = txtEquipo.Text
            FrmEstados.Codigo = txtCodigo.Text
            FrmEstados.Show()
        End If
    End Sub

    Public Function EsPar(ByVal pHora As Integer) As Boolean
        Dim retorno As Boolean = False
        If (pHora Mod 2) = 0 Then
            retorno = True
        End If

        Return retorno
    End Function

    Private Sub txtHora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHora.SelectedIndexChanged
        If txtHora.SelectedIndex = 0 Then
            HoraActual.Visible = False
            HoraAnterior.Visible = True
            HoraPosterior.Visible = False
            FrmPrincipal.txtOpcion.Text = 0
            FrmPrincipal.txtIndice.Text = 0
        End If
        If txtHora.SelectedIndex = 1 Then
            HoraActual.Visible = True
            HoraAnterior.Visible = False
            HoraPosterior.Visible = False
            FrmPrincipal.txtOpcion.Text = 1
            FrmPrincipal.txtIndice.Text = 1
        End If
        If txtHora.SelectedIndex = 2 Then
            HoraActual.Visible = False
            HoraAnterior.Visible = False
            HoraPosterior.Visible = True
            FrmPrincipal.txtOpcion.Text = 2
            FrmPrincipal.txtIndice.Text = 2
        End If

        'Permite habilitar la edicion de horario de comienzo
        btnHora.Enabled = True

        txtCodigo.Visible = True
        btnTeclado.Visible = True
        lblCodigo.Visible = True
        BtnAceptar.Enabled = False
        txtCodigo.Focus()

        FrmPrincipal.txtHora.Text = txtHora.SelectedItem

    End Sub

    Private Sub TimerHoraSeleccionada_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHoraSeleccionada.Tick

        'El temporizador esta configurado en 10 MIN
        tiempo = tiempo + 1
        '2 Ciclos de 10 = 20 MIN
        If tiempo = 2 Then
            'MsgBox("Pasaron 20 minutos...!")
            tiempo = 0
            TimerHoraSeleccionada.Dispose()
            FrmPrincipal.txtEstado.Text = "False"
        End If

    End Sub

    Private Sub btnHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHora.Click
        FrmHora.txtHoraEditada.Value = Convert.ToDateTime(txtHora.SelectedItem)
        FrmHora.txtID.Text = txtHora.SelectedIndex
        FrmHora.Show()
        FrmHora.Visible = True
    End Sub

End Class
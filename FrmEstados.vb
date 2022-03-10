Public Class FrmEstados

    Dim oArchivo As New Archivos
    Private mHora As String
    Public Property Hora() As String
        Get
            Return mHora
        End Get
        Set(ByVal value As String)
            mHora = value
        End Set
    End Property


    Private mEstadoAnterior As String
    Public Property EstadoAnterior() As String
        Get
            Return mEstadoAnterior
        End Get
        Set(ByVal value As String)
            mEstadoAnterior = value
        End Set
    End Property

    Private mEstadoActual As String
    Public Property EstadoActual() As String
        Get
            Return mEstadoActual
        End Get
        Set(ByVal value As String)
            mEstadoActual = value
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



    Public Sub MostrarInterfaz(ByVal pEquipo As String)
        Dim oPlanilla As New Planilla
        Dim arrEstado As String()
        Dim cadena As String
        cadena = oPlanilla.EstadosDisponibles(pEquipo)
        arrEstado = Split(cadena, " ")

        rdES.Enabled = False
        rdER.Enabled = False
        rdEM.Enabled = False
        rdFS.Enabled = False

        For i = 0 To arrEstado.Count - 1

            If arrEstado(i) = "E/R" Then
                rdER.Enabled = True
            End If
            If arrEstado(i) = "E/S" Then
                rdES.Enabled = True
            End If
            If arrEstado(i) = "E/M" Then
                rdEM.Enabled = True
            End If
            If arrEstado(i) = "F/S" Then
                rdFS.Enabled = True
            End If

        Next


    End Sub

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        ' FrmCodigo.ckHora.Checked = False
        ' FrmCodigo.dtpHora.Enabled = True
        Me.BtnAceptar.Enabled = False
        Me.Visible = False
        FrmPrincipal.Show()
    End Sub

    Private Sub BtnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        ' If mEstadoActual = "E/S" Then

        FrmDatos.Codigo = Codigo
        Dim mFrm As New FrmDatos(Codigo)
        mFrm.Show()
        mFrm.Hora = Hora

        '  Else

        'grabo lor regitros en el archivo

        '  Me.BtnAceptar.Enabled = False
        ' Me.Visible = False
        ' FrmPrincipal.Show()

        ' End If

    End Sub

    Private Sub FrmEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Interface dependiendo del equipo
        'MostrarInterfaz(txtEquipo.Text)

        If EstadoAnterior = "E/R" Then
            rdER.Checked = True
        End If

        If EstadoAnterior = "F/S" Then
            rdFS.Checked = True
        End If

        If EstadoAnterior = "E/M" Then
            rdEM.Checked = True
        End If

        BtnAceptar.Enabled = False
        BtnSalir.Focus()

    End Sub

    Private Sub rdER_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdER.Click
        mEstadoActual = "E/R"
        BtnAceptar.Enabled = True
        BtnAceptar.Focus()
    End Sub

    Private Sub rdEMNP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdFS.Click
        If mEstadoAnterior <> "F/S" Then
            MsgBox("Recuerde realizar el Aviso de Avería", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
        mEstadoActual = "F/S"
        BtnAceptar.Enabled = True
        BtnAceptar.Focus()
    End Sub

    Private Sub rdEMP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEM.Click
        If mEstadoAnterior <> "E/M" Then
            MsgBox("Recuerde dar tratamiento a la Orden de Mantenimiento SAP", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
        mEstadoActual = "E/M"
        BtnAceptar.Enabled = True
        BtnAceptar.Focus()
    End Sub

    Private Sub rdES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdES.Click
        If mEstadoAnterior = "E/R" Or mEstadoAnterior = "E/M" Or mEstadoAnterior = "F/S" Then
            MsgBox("Recuerde realizar el chequeo previo antes de poner en servicio el equipo", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
        mEstadoActual = "E/S"
        BtnAceptar.Enabled = True
        BtnAceptar.Focus()
    End Sub

    Private Sub rdEM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdEM.CheckedChanged

    End Sub
End Class
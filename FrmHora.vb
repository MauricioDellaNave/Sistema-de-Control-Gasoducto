Public Class FrmHora


    Private mHora As String
    Public Property Hora() As String
        Get
            Return mHora
        End Get
        Set(ByVal value As String)
            mHora = value
        End Set
    End Property

    Private mHoraEditada As Boolean
    Public Property HoraEditada() As Boolean
        Get
            Return mHoraEditada
        End Get
        Set(ByVal value As Boolean)
            mHoraEditada = value
        End Set
    End Property


    Private mID As Integer
    Public Property ID() As Integer
        Get
            Return mID
        End Get
        Set(ByVal value As Integer)
            mID = value
        End Set
    End Property





    Private Sub btnConfig_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click

        Dim intIndex As Integer = txtID.Text
        FrmCodigo.Show()
        FrmCodigo.txtHora.Items.RemoveAt(intIndex)
        FrmCodigo.txtHora.Items.Insert(intIndex, txtHoraEditada.Text)
        FrmCodigo.txtHora.SelectedIndex = intIndex


        If intIndex = 0 Then
            FrmCodigo.HoraActual.Visible = False
            FrmCodigo.HoraAnterior.Visible = True
            FrmCodigo.HoraPosterior.Visible = False
            FrmPrincipal.txtOpcion.Text = 0
            FrmPrincipal.txtIndice.Text = 0
        End If
        If intIndex = 1 Then
            FrmCodigo.HoraActual.Visible = True
            FrmCodigo.HoraAnterior.Visible = False
            FrmCodigo.HoraPosterior.Visible = False
            FrmPrincipal.txtOpcion.Text = 1
            FrmPrincipal.txtIndice.Text = 1
        End If
        If intIndex = 2 Then
            FrmCodigo.HoraActual.Visible = False
            FrmCodigo.HoraAnterior.Visible = False
            FrmCodigo.HoraPosterior.Visible = True
            FrmPrincipal.txtOpcion.Text = 2
            FrmPrincipal.txtIndice.Text = 2
        End If

        mHoraEditada = True
        mID = txtID.Text
        mHora = txtHoraEditada.Text
        txtHora.Text = txtHoraEditada.Text
        'NUEVO version9
        FrmCodigo.txtEquipo.Text = ""
        FrmCodigo.txtEquipo.Visible = False
        FrmCodigo.txtCodigo.Enabled = True
        FrmCodigo.txtCodigo.Text = ""
        'FrmCodigo.BtnAceptar.Enabled = True
        FrmCodigo.txtCodigo.Focus()

    End Sub

    Private Sub FrmHora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtHoraEditada.CustomFormat = DateTimePickerFormat.Custom
        txtHoraEditada.CustomFormat = "HH:mm"
        txtHoraEditada.ShowUpDown = True
    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Visible = False
        FrmCodigo.txtCodigo.Focus()
    End Sub
End Class
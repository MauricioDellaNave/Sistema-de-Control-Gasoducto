Public Class FrmAgregarAceite


    Private mAgregarAceite As Integer
    Public Property AgregarAceite() As Integer
        Get
            Return mAgregarAceite
        End Get
        Set(ByVal value As Integer)
            mAgregarAceite = value
        End Set
    End Property



    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Visible = False
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Me.Visible = False
        mAgregarAceite = txtAceite.Value
        txtAceite.Value = 0
        FrmDatos.btnOK.Focus()
    End Sub

    Private Sub txtAceite_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub FrmAgregarAceite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtAceite.Focus()
    End Sub

    Private Sub txtAceite_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAceite.KeyDown
        If e.KeyData = Keys.Enter Then
            BtnAceptar.Focus()
        End If
    End Sub

End Class
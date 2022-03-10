Public Class FrmObservaciones


    Private mObservacion As String
    Public Property Observacion() As String
        Get
            Return mObservacion
        End Get
        Set(ByVal value As String)
            mObservacion = value
        End Set
    End Property


    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'Si el teclado virtual esta activado lo desactivo
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        End If

        ' Dim oArchivo As New Archivos
        mObservacion = mObservacion & "(" & txtObservacion.Text & ")"
        Me.Visible = False
        FrmCodigo.txtCodigo.Focus()
    End Sub

    Private Sub btnTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        'Habilito el teclado virtual
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtObservacion.Focus()
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'Si el teclado virtual esta activado lo desactivo
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        End If
        Me.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPlanta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmObservaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
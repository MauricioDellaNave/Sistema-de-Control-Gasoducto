Public Class FrmTeclado


    Public Sub InterfaceTeclado()
        'Interface Teclado
        If rdOFF.Checked = False Then
            FrmCodigo.btnTeclado.Enabled = True
            MsgBox("El teclado virtual fue habilitado.", MsgBoxStyle.Exclamation, "Información del Sistema")
            'Modifico = True
        Else
            FrmCodigo.btnTeclado.Enabled = False
            MsgBox("El teclado virtual fue deshabilitado.", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
    End Sub

    Private Sub FrmTeclado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdOFF.Checked = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmDatosPC.Show()
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        FrmClave.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        InterfaceTeclado()
    End Sub

    Private Sub rdON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOFF.CheckedChanged
        btnGuardar.Enabled = True
    End Sub

    Private Sub rdOFF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdON.CheckedChanged
        btnGuardar.Enabled = True
    End Sub

    Private Sub Label3_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
Public Class FrmClave

    Public Sub ActualizarClave()


        If txtSupervisor.Text = txtConfirmacion.Text And txtSupervisor.Text <> "" Then
            Dim oArvhivo As New Archivos
            Dim oEncriptar As New Encriptar
            oArvhivo.CrearArchivoSupervisor(oEncriptar.Encriptar(txtSupervisor.Text))
            txtConfirmacion.Text = ""
            txtSupervisor.Text = ""
            MsgBox("La clave de Supervisor ha sido modificada", MsgBoxStyle.Exclamation, "Información del Sistema")

        Else

            If txtSupervisor.Text <> txtConfirmacion.Text Then
                MsgBox("La clave de Supervisor no coincide. Por favor vuelva a intentarlo.", MsgBoxStyle.Exclamation, "Información del Sistema")
                txtConfirmacion.Text = ""
                txtSupervisor.Text = ""
                txtSupervisor.Focus()

            End If

        End If

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmTeclado.Show()
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        FrmSalida.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ActualizarClave()
    End Sub

End Class
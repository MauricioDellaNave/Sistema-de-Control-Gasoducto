Public Class FrmConfig

    Dim oArchivo As New Archivos

    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        If (MsgBox("¿Esta seguro que desea regresar al menu Principal? Las modificaciones realizadas que no fueron guardadas se perderán.", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Información del Sistema")) = MsgBoxResult.Yes Then

            FrmPrincipal.Show()

        End If

    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        End If
        FrmDatosPC.Show()
    End Sub

    Private Sub FrmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnGuardar.Enabled = False
        Me.txtRuta.Text = oArchivo.LeerRutaArchivoSalida
        If txtRuta.Text = "" Then
            txtRuta.Text = "Flash File Store\Descargas"
        End If
    End Sub



    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtRuta.Text <> "" Then
            oArchivo.CrearRutaArchivoSalida(txtRuta.Text)
            MsgBox("El nombre de la carpeta se generó correctamente.", MsgBoxStyle.Exclamation, "Información del Sistema")
        Else
            MsgBox("El nombre de la carpeta no puede estar vacio.", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If

    End Sub


    Private Sub btnTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtRuta.Focus()
    End Sub


    Private Sub txtRuta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRuta.TextChanged
        btnGuardar.Enabled = True
    End Sub

End Class
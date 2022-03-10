Public Class FrmDatosPC

    Dim oArchivo As New Archivos

    Private Sub FrmDatosPC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnGuardar.Enabled = False
        Me.txtRutaPC.Text = oArchivo.LeerRutaArchivosPC
        If txtRutaPC.Text = "" Then
            txtRutaPC.Text = "NombrePC\Upload"
        End If
    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSiguiente.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        End If
        FrmTeclado.Show()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        End If
        FrmConfig.Show()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtRutaPC.Text <> "" Then
            oArchivo.CrearRutaArchivoSalidaPC(txtRutaPC.Text)
            MsgBox("La ruta se cargo correctamente.", MsgBoxStyle.Exclamation, "Información del Sistema")
        Else
            MsgBox("El nombre de la ruta no puede estar vacio.", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
    End Sub

    Private Sub btnTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeclado.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtRutaPC.Focus()
    End Sub

    Private Sub txtRutaPC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRutaPC.TextChanged
        btnGuardar.Enabled = True
    End Sub
End Class
Public Class FrmSalida
    Dim oArchivo As New Archivos


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        FrmClave.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.InitialDirectory = "Flash File Store\Upload"
        openFileDialog1.Filter = "Plantas (*.txt)|*.txt"
        openFileDialog1.FilterIndex = 2
        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRutaConfig.Text = openFileDialog1.FileName
            btnGuardar.Enabled = True
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtRutaConfig.Text <> "" Then
            oArchivo.CrearRutaArchivoEntrada(txtRutaConfig.Text)
            MsgBox("Los datos de la Planta se cargaron correctamente.", MsgBoxStyle.Exclamation, "Información del Sistema")
            Dim oPlanta As New Planta
            oPlanta.CargarPlanta()
            FrmPrincipal.txtOperador.Text = ""
            FrmPrincipal.BtnRonda.Enabled = False
            FrmPrincipal.btnOperador.Enabled = True
        Else
            MsgBox("El archivo de la Planta no puede estar vacio.", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
    End Sub

    Private Sub FrmSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnGuardar.Enabled = False

        Me.txtRutaConfig.Text = oArchivo.LeerRutaArchivoSalida
        If txtRutaConfig.Text = "" Then
            MsgBox("Debe cargar el archivo de la Planta para utilizar la aplicación.", MsgBoxStyle.Exclamation, "Información del Sistema")
        End If
    End Sub
End Class
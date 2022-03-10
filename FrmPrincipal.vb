Imports System
Imports System.IO
Imports System.Collections
Imports System.Net.Sockets
Imports System.Net

Public Class FrmPrincipal

    Public Sub Descargar()
        Dim oArchivo As New Archivos
        Dim origen As String = oArchivo.LeerRutaArchivoSalida
        Dim destino As String = oArchivo.LeerRutaArchivosPC

        If origen = "" Then
            oArchivo.CrearRutaArchivoSalida("Flash File Store\Descargas")
            origen = oArchivo.LeerRutaArchivoSalida()
        End If

        If destino = "" Then
            MsgBox("Debe cargar desde la opcion de Configuración la carpeta donde se descargaran los archivos en la PC.", MsgBoxStyle.Critical, "Informacion del Sistema")

        Else
            Try
                'Transfiero los archivos
                Dim source As New DirectoryInfo(origen)
                Dim filesToCopy As IEnumerable(Of FileInfo) = source.GetFiles()


                For Each file1 As FileInfo In filesToCopy

                    file1.CopyTo(String.Format("{0}\{1}", destino, file1.Name), True)

                Next
                MsgBox("Los archivos han sido transferidos correctamente.", MsgBoxStyle.Information, "Información del Sistema")
            Catch ex As Exception
                MsgBox("Por favor verifique que el dispositivo este conectado a una PC y que la ruta de descarga ingresada sea la correcta.", MsgBoxStyle.Information, "Error de conexión")
            End Try
        End If



    End Sub

    Private Sub btnOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperador.Click
        'Cargamos la lista de operadores
        Dim oOper As New Usuarios
        oOper.CargarOperadores()
        FrmOperadores.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        FrmSalir.Show()
    End Sub

    Private Sub FrmPrincipal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If txtOperador.Text <> "" Then
            BtnRonda.Enabled = True
            BtnRonda.Focus()
        End If
    End Sub

    Private Sub FrmPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'F1 Seleccionar Operador
        If e.KeyValue = 112 Then
            'Cargamos la lista de operadores
            Dim oOper As New Usuarios
            oOper.CargarOperadores()
            FrmOperadores.Show()
        End If

        'F2 Comenzar Ronda
        If e.KeyValue = 113 And BtnRonda.Enabled = True Then
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
        End If

    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oArchivos As New Archivos
        'Verifico que exista el archivo de configuracion
        If oArchivos.ExisteArchivo = True Then
            Dim oPlanta As New Planta
            oPlanta.CargarPlanta()

            If txtOperador.Text = "" Then
                btnOperador.Enabled = True
                btnOperador.Focus()
            End If

        Else
            btnOperador.Enabled = False
            MsgBox("El archivo de configuración no se encuentra en el equipo. Por favor contactese con el administrador del sistema.", MsgBoxStyle.Critical, "Importante")
        End If
        BtnDescarga.Enabled = True
        BtnRonda.Enabled = False

    End Sub

    Private Sub BtnRonda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRonda.Click


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

    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        FrmSupervisor.Show()
        FrmSupervisor.txtClave.Text = ""
        FrmSupervisor.txtClave.Focus()

        FrmSupervisor.txtPlanta.Text = txtPlanta.Text
        FrmSupervisor.txtOperador.Text = txtOperador.Text
    End Sub

    Private Sub BtnDescarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDescarga.Click
        Descargar()
    End Sub

    Private Sub BtnRonda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnRonda.KeyDown
        If e.KeyValue = Keys.F3 Then
            Descargar()
        End If
        If e.KeyValue = Keys.Escape Then
            FrmSalir.Show()
        End If
    End Sub

    Private Sub btnOperador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOperador.KeyDown
        If e.KeyValue = Keys.F3 Then
            Descargar()
        End If
        If e.KeyValue = Keys.Escape Then
            FrmSalir.Show()
        End If
    End Sub

    Private Sub BtnDescarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnDescarga.KeyDown
        If e.KeyValue = Keys.F3 Then
            Descargar()
        End If
        If e.KeyValue = Keys.Escape Then
            FrmSalir.Show()
        End If
    End Sub

    Private Sub btnConfig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnConfig.KeyDown
        If e.KeyValue = Keys.F3 Then
            Descargar()
        End If
        If e.KeyValue = Keys.Escape Then
            FrmSalir.Show()
        End If
    End Sub

End Class

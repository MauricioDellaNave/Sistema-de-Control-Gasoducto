Imports System.IO

Public Class Usuarios


    Private mSupervisor As String
    Public Property Supervisor() As String
        Get
            Return mSupervisor
        End Get
        Set(ByVal value As String)
            mSupervisor = value
        End Set
    End Property


    Public Sub CargarOperadores()

        'Cargo los Operadores
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Try

            mText = oArchivo.LeerArchivoConfiguracion()
            mRegistro = Split(mText(0), "|")
            'limpimos la lista
            FrmOperadores.ListOperadores.Items.Clear()
            'lista de usuarios
            'Recorro el primer registro que contiene los usuarios
            Dim contUsu As Integer = 0
            While mRegistro(contUsu) <> ""
                FrmOperadores.ListOperadores.Items.Add(mRegistro(contUsu + 1))
                contUsu = contUsu + 1
            End While

        Catch ex As Exception


        End Try

    End Sub

    Public Function ValidarSupervisor(ByVal pSupervisor As String) As Boolean

        'Cargo los Operadores
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mSup() As String
        Dim encontro As Boolean = False
        Dim oEncriptar As New Encriptar
        Try

            mText = oArchivo.LeerArchivoSupervisor()
            mSup = Split(mText(0), "|")

            If mSup(0) = oEncriptar.Encriptar(pSupervisor) Then
                encontro = True
                mSupervisor = pSupervisor
            End If


        Catch ex As Exception


        End Try


        Return encontro
    End Function

End Class

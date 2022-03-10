Imports System.IO

Public Class Archivos

#Region "Variables del Salida"

    Private mVecArchivo As New ArrayList
    Public Property VecArchivo() As ArrayList
        Get
            Return mVecArchivo
        End Get
        Set(ByVal value As ArrayList)
            mVecArchivo = value
        End Set
    End Property

    'Observaciones
    Private mObservacion As String
    Public Property Observacion() As String
        Get
            Return mObservacion
        End Get
        Set(ByVal value As String)
            mObservacion = value
        End Set
    End Property

#End Region


#Region "Constructor"

    Sub New()

    End Sub

#End Region


    Public Function ExisteArchivo() As Boolean
        Dim mRuta As String = LeerRutaArchivoEntrada()
        Dim encontro As Boolean = False
        If File.Exists(mRuta) Then
            encontro = True
        End If

        Return encontro
    End Function

    Public Function ExisteArchivoSalida(ByVal pNombre As String) As Boolean
        Dim mRuta As String = LeerRutaArchivoSalida()
        mRuta = mRuta & "\" & pNombre & ".txt"
        Dim encontro As Boolean = False
        If File.Exists(mRuta) Then
            encontro = True
        End If

        Return encontro
    End Function

    Public Function BuscarEstadoEquipo(ByVal pCodigo As String, ByVal pFecha As String) As String

        'Verifico existencia de Planilla
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Dim mEstado As String = ""
        Dim mValido As Boolean = True
        Try

            pCodigo = pCodigo.Replace("/", "-")
            'VERIFICAR LA FALLA DEL PUNTO 2 ENTRE HORARIO 00:00 A 08:00 ES POR LA FECHA DATETIME.NOW
            'TENGO Q PASAR LA FECHA POR PARAMETRO NO LA DEL SISTEMA
            'mText = oArchivo.LeerArchivoSalida(pCodigo & "-" & DateTime.Now.ToString("dd-MM-yyyy"))

            mText = oArchivo.LeerArchivoSalida(pCodigo & "-" & pFecha)
            For Each cadena In mText
                mRegistro = Split(cadena, ",")

                mEstado = mRegistro(1)
            Next


        Catch ex As Exception

        End Try
        Return mEstado

    End Function

    Public Function BuscarHoraPlanilla(ByVal pHora As String, ByVal pRuta As String) As Boolean

        'Verifico existencia de Planilla
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Dim mEncontro As Boolean = False
        Dim mValido As Boolean = True
        Try

            mText = oArchivo.LeerArchivoSalida(pRuta)

            For Each cadena In mText
                mRegistro = Split(cadena, ",")

                For i As Integer = 0 To mRegistro.Length - 1

                    If mRegistro(0) = pHora Then
                        'codigo encontrado
                        mEncontro = True
                        Exit For

                    End If
                Next
            Next

        Catch ex As Exception

        End Try
        Return mEncontro

    End Function

    Public Function BuscarCargaAceite(ByVal pRuta As String) As Double

        'Verifico existencia de Planilla
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Dim mValido As Boolean = True
        Dim mTotal As Double
        Try

            mText = oArchivo.LeerArchivoSalida(pRuta)
            For Each cadena In mText
                mRegistro = Split(cadena, ",")
                For i As Integer = 0 To mRegistro.Length - 1
                    If mRegistro(0) > 0 Then
                        'codigo encontrado

                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
        Return mTotal

    End Function

    Public Function LeerArchivoSalida(ByVal pNombre As String) As ArrayList
        Dim mRuta As String = LeerRutaArchivoSalida()
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList

        Try

            Dim objReader As New StreamReader(mRuta & "\" & pNombre & ".txt", System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

        Catch ex As Exception

        End Try
        Return arrText
    End Function

    Public Function LeerArchivoSupervisor() As ArrayList
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList
        Try

            Dim objReader As New StreamReader("Flash File Store\Upload\Clave.TXT", System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

        Catch ex As Exception

            'Si no lo encuentro lo creo
            Dim oEncriptar As New Encriptar
            CrearArchivoSupervisor(oEncriptar.Encriptar("123"))

        End Try
        Return arrText
    End Function

    Public Function LeerRutaArchivosPC() As String
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList
        Dim mRuta As String = ""
        Try

            Dim objReader As New StreamReader("\Flash File Store\Upload\DatosPC.TXT", System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()
            mRuta = arrText(0)
        Catch ex As Exception

        End Try
        Return mRuta
    End Function

    Public Function LeerRutaArchivoSalida() As String
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList
        Dim mRuta As String = ""
        Try

            Dim objReader As New StreamReader("\Flash File Store\Upload\Salida.TXT", System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()
            mRuta = arrText(0)
        Catch ex As Exception

        End Try
        Return mRuta
    End Function

    Public Function LeerRutaArchivoEntrada() As String
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList
        Dim mRuta As String = ""
        Try

            Dim objReader As New StreamReader("\Flash File Store\Upload\Entrada.TXT", System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()
            mRuta = arrText(0)
        Catch ex As Exception

        End Try
        Return mRuta
    End Function

    Public Function LeerArchivoConfiguracion() As ArrayList
        Dim mRuta As String = LeerRutaArchivoEntrada()
        'Leer Archivo
        Dim Sline As String = ""
        Dim arrText As New ArrayList
        Try

            Dim objReader As New StreamReader(mRuta, System.Text.Encoding.GetEncoding(1252))
            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

        Catch ex As Exception

        End Try
        Return arrText
    End Function

    Public Sub CrearRutaArchivoSalidaPC(ByVal pRuta As String)
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Flash File Store\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Flash File Store\Upload\DatosPC.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(pRuta)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Flash File Store\Upload\DatosPC.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, False)
                sw.WriteLine(pRuta)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub CrearArchivoSalida(ByVal pPlanilla As String, ByVal pNuevaToma As Boolean, ByVal pHora As String)
        Const mRuta As String = "\Flash File Store\Descargas\"
        Dim mArch As String = ""
        Dim mPlan As String = ""
        Dim mTexto As String = ""
        Dim mFecha As String = ""
        Dim vInicio As String = "06:00"
        mPlan = pPlanilla.Replace("/", "-")

        'Las fechas de las jornadas de trabajo comienzan a las 06:00 AM 
        If pHora.Length < vInicio.Length Then
            vInicio = "6:00"
        Else
            vInicio = "06:00"
        End If

        If pHora >= vInicio Then
            mFecha = DateTime.Now.ToString("dd-MM-yyyy")
        Else

            mFecha = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
            DateTime.Now.AddDays(1)
        End If

        mArch = mRuta & mPlan & "-" & mFecha & ".txt"

        Try

            'Creamos la carpeta 
            If Not Directory.Exists(mRuta) Then
                Directory.CreateDirectory(mRuta)
                Dim sw As New System.IO.StreamWriter(mArch)

                For i = 0 To VecArchivo.Count - 1
                    If mTexto = "" Then
                        mTexto = VecArchivo.Item(i)
                    Else
                        mTexto = mTexto & "," & VecArchivo.Item(i)
                    End If
                Next

                sw.WriteLine(mTexto)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Dim sw As New System.IO.StreamWriter(mArch, True)
                '  sw.WriteLine(mPuntoControl & "," & mStock & "," & mGoteo & "," & mReposicion & "," & mCloroLibre & "," & mCamara & "," & mComentarios & "," & Format(Now(), "dd/MM/yyyy") & "," & Format(Now(), "hh:mm:ss"))
                For i = 0 To VecArchivo.Count - 1
                    If mTexto = "" Then
                        mTexto = VecArchivo.Item(i)
                    Else
                        mTexto = mTexto & "," & VecArchivo.Item(i)
                    End If
                Next

                sw.WriteLine(mTexto)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub CrearArchivoSupervisor(ByVal pClave As String)
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Flash File Store\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Flash File Store\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Flash File Store\Upload\Clave.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(pClave)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Flash File Store\Upload\Clave.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, False)
                sw.WriteLine(pClave)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub CrearRutaArchivoSalida(ByVal pRuta As String)
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Flash File Store\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Flash File Store\Upload\Salida.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(pRuta)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Flash File Store\Upload\Salida.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, False)
                sw.WriteLine(pRuta)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub CrearRutaArchivoEntrada(ByVal pRuta As String)
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Flash File Store\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Flash File Store\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Flash File Store\Upload\Entrada.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(pRuta)
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Flash File Store\Upload\Entrada.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, False)
                sw.WriteLine(pRuta)
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class

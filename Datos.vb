Imports System.IO

Public Class Datos


#Region "Declaraciones"


    Private mEstadoAnterior As Boolean
    Public Property EstadoAnterior() As Boolean
        Get
            Return mEstadoAnterior
        End Get
        Set(ByVal value As Boolean)
            mEstadoAnterior = value
        End Set
    End Property

    'Vector de Mediciones anteriores
    Private VecMedAnterior4 As New ArrayList
    Public Property MedAnterior4() As ArrayList
        Get
            Return VecMedAnterior4
        End Get
        Set(ByVal value As ArrayList)
            VecMedAnterior4 = value
        End Set
    End Property

    Private VecMedAnterior3 As New ArrayList
    Public Property MedAnterior3() As ArrayList
        Get
            Return VecMedAnterior3
        End Get
        Set(ByVal value As ArrayList)
            VecMedAnterior3 = value
        End Set
    End Property

    Private VecMedAnterior2 As New ArrayList
    Public Property MedAnterior2() As ArrayList
        Get
            Return VecMedAnterior2
        End Get
        Set(ByVal value As ArrayList)
            VecMedAnterior2 = value
        End Set
    End Property

    Private VecMedAnterior1 As New ArrayList
    Public Property MedAnterior1() As ArrayList
        Get
            Return VecMedAnterior1
        End Get
        Set(ByVal value As ArrayList)
            VecMedAnterior1 = value
        End Set
    End Property

    'Vector de Maximos
    Private VecMaximos As New ArrayList
    Public Property Maximos() As ArrayList
        Get
            Return VecMaximos
        End Get
        Set(ByVal value As ArrayList)
            VecMaximos = value
        End Set
    End Property

    Private VecMaximos2 As New ArrayList
    Public Property Maximos2() As ArrayList
        Get
            Return VecMaximos2
        End Get
        Set(ByVal value As ArrayList)
            VecMaximos2 = value
        End Set
    End Property


    'Vector de Minimos
    Private VecMinimos As New ArrayList
    Public Property Minimos() As ArrayList
        Get
            Return VecMinimos
        End Get
        Set(ByVal value As ArrayList)
            VecMinimos = value
        End Set
    End Property

    Private VecMinimos2 As New ArrayList
    Public Property Minimos2() As ArrayList
        Get
            Return VecMinimos2
        End Get
        Set(ByVal value As ArrayList)
            VecMinimos2 = value
        End Set
    End Property


    'Vector de cabeceras
    Private VecCabeceras As New ArrayList
    Public Property Cabeceras() As ArrayList
        Get
            Return VecCabeceras
        End Get
        Set(ByVal value As ArrayList)
            VecCabeceras = value
        End Set
    End Property

    'Vector de cabeceras 2
    Private VecCabeceras2 As New ArrayList
    Public Property Cabeceras2() As ArrayList
        Get
            Return VecCabeceras2
        End Get
        Set(ByVal value As ArrayList)
            VecCabeceras2 = value
        End Set
    End Property

    'Vector Especificaciones

    Private VecEspecificacion As New ArrayList
    Public Property Especificacion() As ArrayList
        Get
            Return VecEspecificacion
        End Get
        Set(ByVal value As ArrayList)
            VecEspecificacion = value
        End Set
    End Property

    Private VecEspecificacion2 As New ArrayList
    Public Property Especificacion2() As ArrayList
        Get
            Return VecEspecificacion2
        End Get
        Set(ByVal value As ArrayList)
            VecEspecificacion2 = value
        End Set
    End Property

    'Vector Unidades
    Private VecUnidades As New ArrayList
    Public Property Unidades() As ArrayList
        Get
            Return VecUnidades
        End Get
        Set(ByVal value As ArrayList)
            VecUnidades = value
        End Set
    End Property

    Private VecUnidades2 As New ArrayList
    Public Property Unidades2() As ArrayList
        Get
            Return VecUnidades2
        End Get
        Set(ByVal value As ArrayList)
            VecUnidades2 = value
        End Set
    End Property

    'Vector Formato
    Private VecFormato As New ArrayList
    Public Property Formato() As ArrayList
        Get
            Return VecFormato
        End Get
        Set(ByVal value As ArrayList)
            VecFormato = value
        End Set
    End Property

    'Vector Datos
    Private VecDato As New ArrayList
    Public Property Dato() As ArrayList
        Get
            Return VecDato
        End Get
        Set(ByVal value As ArrayList)
            VecDato = value
        End Set
    End Property

    'Indice Datos
    Private Indice As Integer = 1
    Public Property IndiceDatos() As Integer
        Get
            Return Indice
        End Get
        Set(ByVal value As Integer)
            Indice = value
        End Set
    End Property

#End Region

#Region "Metodos"

    'Metodo que carga el vector especificaciones
    Public Sub CargarDatos(ByVal pCod As String, ByVal pCab As String)
        Dim Especificacion As String = ""
        'VALIDAR EXISTENCIA DE ARCHIVO
        'cargo el archivo


        Try
            Dim oArchivo As New Archivos
            Dim mRuta As String = oArchivo.LeerRutaArchivoEntrada
            Dim objReader As New StreamReader(mRuta, System.Text.Encoding.GetEncoding(1252))
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()
            Dim cont As Integer = 0
            Dim encontro As Boolean = False
            Dim primero As Boolean = False
            Dim mEspe As String = "NONE"




            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            For Each cadena In arrText
                arrCadena = Split(cadena, "|")

                For i As Integer = 0 To arrCadena.Length - 1
                    'Recorro el archivo buscando si el codigo escaneado es encontrado
                    'ejemplo PGOT200/2.S
                    If arrCadena(i) = pCod Then
                        encontro = True
                        If arrCadena(4) = "Horario" Then
                            Exit For
                        End If
                    End If

                    'Cargo las cabeceras restantes en el vector Cabeceras
                    If encontro = True Then

                        'Condicion para termninar la secuencia de carga de cabecera
                        'If arrCadena(j).Equals("") And arrCadena(j + 1).Equals("") And arrCadena(j + 2).Equals("") And arrCadena(j + 3).Equals("") And arrCadena(j + 4) <> "" Then
                        '    Exit Sub
                        'End If

                        If (primero = True And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3).Equals("") And arrCadena(4) <> "")) Then
                            Exit Sub
                        End If

                        If (primero = True And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3) <> "")) Then
                            Exit Sub
                        End If

                        If (primero = True And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2) <> "")) Then
                            Exit Sub
                        End If

                        'Para el caso de PGOT200/61.C
                        If (primero = True And (arrCadena(0).Equals("") And arrCadena(1) <> ("") And arrCadena(2) <> ("") And arrCadena(3) <> (""))) Then
                            Exit Sub
                        End If

                        'cargamos la primer especificacion
                        If (primero = False And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3).Equals("") And arrCadena(4) <> (""))) Or (primero = False And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3) <> ("") And arrCadena(4) <> ("")) Or (primero = False And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2) <> ("") And arrCadena(3).Equals("") And arrCadena(4) <> ("")))) Then

                            If arrCadena(4) = pCab Then
                                'Cargamos el vector especificaciones con el primer item
                                ' MsgBox("PRIMERO" & VecEspecificacion.Count)
                                VecEspecificacion.Add(arrCadena(5))
                                VecUnidades.Add(arrCadena(6))
                                VecFormato.Add(arrCadena(7))
                                VecMaximos.Add(arrCadena(9))
                                VecMinimos.Add(arrCadena(10))
                                primero = True
                            End If
                        End If

                        'CASO PARTICULAR PARA CODIGO PGOT200/60.S
                        If (primero = False And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2) <> ("") And arrCadena(3) <> ("") And arrCadena(4) <> (""))) Then

                            If arrCadena(4) = pCab Then
                                'Cargamos el vector especificaciones con el primer item
                                VecEspecificacion.Add(arrCadena(5))
                                VecUnidades.Add(arrCadena(6))
                                VecFormato.Add(arrCadena(7))
                                VecMaximos.Add(arrCadena(9))
                                VecMinimos.Add(arrCadena(10))
                                primero = True
                            End If
                        End If

                        'CASO PARTICULAR PARA CODIGO PGOT200/70.S
                        If (primero = False And (arrCadena(0).Equals("") And arrCadena(1) <> ("") And arrCadena(2) <> ("") And arrCadena(3) <> ("") And arrCadena(4) <> (""))) Then

                            If arrCadena(4) = pCab Then
                                'Cargamos el vector especificaciones con el primer item
                                VecEspecificacion.Add(arrCadena(5))
                                VecUnidades.Add(arrCadena(6))
                                VecFormato.Add(arrCadena(7))
                                VecMaximos.Add(arrCadena(9))
                                VecMinimos.Add(arrCadena(10))
                                primero = True
                            End If
                        End If

                        'cargamos a partir de la segunda Especificacion
                        If (primero = True And (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3).Equals("") And arrCadena(4).Equals(""))) Then

                            'Cargamos el vector especificaciones con los items restantes
                            VecEspecificacion.Add(arrCadena(5))
                            VecUnidades.Add(arrCadena(6))
                            VecFormato.Add(arrCadena(7))
                            VecMaximos.Add(arrCadena(9))
                            VecMinimos.Add(arrCadena(10))
                            ' primero = True

                        End If
                        Exit For

                    End If


                Next


            Next

        Catch ex As Exception


        End Try

    End Sub

    'Metodo que carga el vector de cabeceras
    Public Sub BuscarCabeceras(ByVal pCodigo As String)
        Dim Cabecera As String = ""
        'VALIDAR EXISTENCIA DE ARCHIVO
        'cargo el archivo
        Try
            Dim oArchivo As New Archivos
            Dim mRuta As String = oArchivo.LeerRutaArchivoEntrada
            Dim objReader As New StreamReader(mRuta, System.Text.Encoding.GetEncoding(1252))
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()
            Dim cont As Integer = 0
            Dim encontro As Boolean = False
            Dim mCabecera As String = "NONE"
            Dim mCierre As Boolean = False


            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            For Each cadena In arrText
                arrCadena = Split(cadena, "|")

                For i As Integer = 0 To arrCadena.Length - 1
                    'Recorro el archivo buscando si el codigo escaneado es encontrado
                    'ejemplo PGOT200/2.S
                    If arrCadena(i) = pCodigo Or mCierre = True Then
                        'Condicion valida para Cierre Diario
                        If arrCadena(i + 1) = FrmCodigo.txtEquipo.Text Then
                            mCierre = True
                            Exit For
                        End If


                        'Condicion necesaria para que sea cabecera
                        If arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2).Equals("") And arrCadena(3).Equals("") And arrCadena(4) <> "" Then
                            'El registro siguiente al codigo es la primera cabecera
                            FrmDatos.txtCabecera.Text = arrCadena(4)

                            'Cargamos el primer item del vector cabecera
                            VecCabeceras.Add(arrCadena(4))
                        Else

                            'El registro siguiente al codigo es la primera cabecera
                            FrmDatos.txtCabecera.Text = arrCadena(i + 1)

                            'Cargamos el primer item del vector cabecera
                            VecCabeceras.Add(arrCadena(i + 1))

                        End If




                        'Al encontrar la primera cabecera lo indico con(encontro=true)
                        encontro = True
                        mCierre = False
                        Exit For

                    End If

                    'Cargo las cabeceras restantes en el vector Cabeceras
                    If encontro = True Then
                        Dim j As Integer = 0

                        'Condicion para termninar la secuencia de carga de cabecera
                        If arrCadena(j).Equals("") And arrCadena(j + 1).Equals("") And arrCadena(j + 2).Equals("") And arrCadena(j + 3) <> "" Then
                            Exit Sub
                        End If

                        If arrCadena(0).Equals("") And arrCadena(1) <> "" Then
                            Exit Sub
                        End If

                        'Ultima modificacion 20/9 repite ultimo
                        If arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2) <> "" And arrCadena(3) <> "" Then
                            Exit Sub
                        End If


                        'Condicion necesaria para que sea cabecera
                        If (arrCadena(j).Equals("") And arrCadena(j + 1).Equals("") And arrCadena(j + 2).Equals("") And arrCadena(j + 3).Equals("") And arrCadena(j + 4) <> "" And mCabecera <> arrCadena(j + 4)) Or (arrCadena(0).Equals("") And arrCadena(1).Equals("") And arrCadena(2) <> ("") And arrCadena(3).Equals("") And mCabecera <> arrCadena(4)) Then

                            mCabecera = (arrCadena(j + 4))
                            'Cargamos el vector cabeceras desde el segundo item
                            VecCabeceras.Add(arrCadena(j + 4))
                            'Cargamos la matriz especificaciones
                            'VecEspecificacion.Add(arrCadena(j + 5), arrCadena(j + 6), arrCadena(j + 7), arrCadena(j + 8), arrCadena(j + 9), arrCadena(j + 10))
                            'MsgBox(arrCadena(j + 4))
                        End If
                    End If

                Next

            Next

        Catch ex As Exception


        End Try

    End Sub

    'Metodo limpiar busquedas anteriores
    Public Sub limpiarBuffer()
        ' VecCabeceras.Clear()
        VecEspecificacion.Clear()
        VecUnidades.Clear()
        VecMaximos.Clear()
        VecMinimos.Clear()
    End Sub

    Public Sub limpiarVectores()
        ' VecCabeceras.Clear()
        VecEspecificacion2.Clear()
        VecUnidades2.Clear()
        VecMaximos2.Clear()
        VecMinimos2.Clear()
    End Sub

    'Metodo cargar mediciones anteriores
    Public Sub CargarMedicionesAnteriores(ByVal pCodigo As String)

        'Verifico existencia de Planilla
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Dim mEstado As String = ""
        Dim mValido As Boolean = True
        Dim Indice1 As Integer
        Dim Indice2 As Integer
        Dim Indice3 As Integer
        Dim Indice4 As Integer

        Try

            pCodigo = pCodigo.Replace("/", "-")
            mText = oArchivo.LeerArchivoSalida(pCodigo & "-" & DateTime.Now.ToString("dd-MM-yyyy"))

            'Si para el dia de hoy no hay mediciones traigo la del dia anterior
            If mText.Count = 0 Then
                Dim mfecha As String = ""
                mfecha = DateTime.Now.AddDays(-1).ToString("dd-MM-yyyy")
                mText = oArchivo.LeerArchivoSalida(pCodigo & "-" & mfecha)
                DateTime.Now.AddDays(1)
                mEstadoAnterior = True
            Else
                mEstadoAnterior = False
            End If

            For Each cadena In mText

                Indice4 = mText.Count - 1
                Indice3 = mText.Count - 2
                Indice2 = mText.Count - 3
                Indice1 = mText.Count - 4

                If Indice4 >= 0 Then
                    mRegistro = Split(mText.Item(Indice4), ",")
                    'LA CARGA DEL VECTOR
                    For i As Integer = 0 To mRegistro.Length - 1
                        VecMedAnterior4.Add(mRegistro(i))
                    Next
                End If

                If Indice3 >= 0 Then
                    mRegistro = Split(mText.Item(Indice3), ",")
                    'LA CARGA DEL VECTOR
                    For i As Integer = 0 To mRegistro.Length - 1
                        VecMedAnterior3.Add(mRegistro(i))
                    Next
                End If

                If Indice2 >= 0 Then
                    mRegistro = Split(mText.Item(Indice2), ",")
                    'LA CARGA DEL VECTOR
                    For i As Integer = 0 To mRegistro.Length - 1
                        VecMedAnterior2.Add(mRegistro(i))
                    Next
                End If

                If Indice1 >= 0 Then
                    mRegistro = Split(mText.Item(Indice1), ",")
                    'LA CARGA DEL VECTOR
                    For i As Integer = 0 To mRegistro.Length - 1
                        VecMedAnterior1.Add(mRegistro(i))
                    Next
                End If


            Next

        Catch ex As Exception

        End Try

    End Sub

#End Region


End Class

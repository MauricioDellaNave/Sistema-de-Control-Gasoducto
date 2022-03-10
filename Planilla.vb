Imports System.IO

Public Class Planilla

    Public Function ExistePlanilla(ByVal pCodigo As String)

        'Verifico existencia de Planilla
        Dim oArchivo As New Archivos
        Dim mText As New ArrayList
        Dim mRegistro As String()
        Dim mSline As String = ""
        Dim mEncontro As Boolean = False
        Dim mValido As Boolean = True
        Try
            If pCodigo.Count < 6 Then
                mValido = False
            End If
            mText = oArchivo.LeerArchivoConfiguracion()

            For Each cadena In mText
                mRegistro = Split(cadena, "|")

                For i As Integer = 0 To mRegistro.Length - 1

                    If mRegistro(i) = pCodigo And mValido = True Then
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

    Public Function ObtenerCodigo(ByVal pCodigo As String)
        'Obtengo el codigo de Planilla del codigo escaneado
        Dim mPlanilla As String
        Dim mcode(1) As String
        'MsgBox(pCodigo.Length)
        If pCodigo.Length > 9 Then
            mPlanilla = pCodigo.Substring(0, 10)
            mcode = Split(mPlanilla, ".")
            ' MsgBox(mcode(0))
        Else
            mcode(0) = pCodigo
        End If
        Return mcode(0)
    End Function

    Public Function BuscarEquipo(ByVal pCodigo As String, ByVal pScan As String) As String
        Dim mOpcion1 As String = ""
        Dim mOpcion2 As String = ""
        Dim mOpcion3 As String = ""
        Dim mOpcion4 As String = ""
        Dim mEquipo As String = ""

        Try

            'Buscar Equipo
            Dim oArchivo As New Archivos
            Dim mText As New ArrayList
            Dim mRegistro As String()
            Dim mSline As String = ""
            Dim encontro As Boolean = False

            'Leer archivo
            mText = oArchivo.LeerArchivoConfiguracion()

            For Each cadena In mText
                mRegistro = Split(cadena, "|")
                'Ciclo para encontrar PLANILLA


                For i As Integer = 0 To mRegistro.Length - 1
                    If mRegistro(i) = pCodigo Then
                        'el registro siguiente es el EQUIPO
                        mOpcion1 = mRegistro(i + 1)
                        Exit For
                    End If
                Next


                For l As Integer = 0 To mRegistro.Length - 1
                    Dim mScan() As String
                    Dim mReal() As String
                    mScan = Split(pScan, ".")
                    mReal = Split(mRegistro(l), ".")

                    If mReal(0) = mScan(0) And encontro = False Then


                        If pScan = "PGOT200/61.S" Then

                            mOpcion3 = "Intercambiadores de Calor"
                            encontro = True
                        Else


                            If pScan = "PGOT200/30FFN" Then

                                mOpcion3 = "Aero Enfriadores"
                                encontro = True
                            Else
                                If pScan = "PGOT200/61.SC" Then
                                    mOpcion3 = "Cargadores Bancos Baterias"
                                    encontro = True
                                Else
                                    If pScan = "PGOT200/61.C" Then

                                        mOpcion1 = "Cargadores Bancos Baterias"
                                        encontro = True
                                    Else

                                        mOpcion3 = mRegistro(l - 1)
                                        encontro = True
                                    End If

                                End If
                            End If


                        End If



                        Exit For
                        End If
                Next


                For j As Integer = 0 To mRegistro.Length - 1
                    If mRegistro(j) = pScan Then
                        If pScan = "PGOT200/60.D" Then
                            mOpcion2 = "Deshidratadora"
                        Else

                            'If pScan = "PGOT200/61.C" Then
                            'mOpcion2 = "Cargadores Bancos Baterias"
                            '   mOpcion1 = "Cargadores Bancos Baterias"

                            'Else
                            'el registro anterior es el EQUIPO
                            mOpcion2 = mRegistro(j - 1)
                            mOpcion4 = mRegistro(j + 1)

                            ' End If

                        End If

                        Exit For

                        End If
                Next

            Next

        Catch ex As Exception


        End Try

        'Selecciono todas las posibilidades para que el equipo sea el buscado

        If (UCase(mOpcion1) = UCase(mOpcion2)) Or (UCase(mOpcion1) = UCase(mOpcion3)) Or (mOpcion2 = "" And mOpcion3 = "") Or (UCase(mOpcion1) = UCase(mOpcion4)) Then
            mEquipo = mOpcion1
        Else
            If mOpcion2 = "" Then
                mEquipo = mOpcion3
            Else
                mEquipo = mOpcion2
            End If
        End If


        Return mEquipo

    End Function

    Public Function EstadosDisponibles(ByVal pEquipo As String) As String

        Dim mEstado As String = ""

        Try

            'Buscar Equipo
            Dim oArchivo As New Archivos
            Dim mText As New ArrayList
            Dim mRegistro As String()
            Dim mSline As String = ""
            Dim mEncontro1 As Boolean = False
            Dim mEncontro2 As Boolean = False
            'Leer archivo
            mText = oArchivo.LeerArchivoConfiguracion()

            For Each cadena In mText
                mRegistro = Split(cadena, "|")
                'Ciclo para encontrar CONDICIONAL
                For i As Integer = 0 To mRegistro.Length - 1
                    If mRegistro(i) = pEquipo And mEncontro1 = False Then
                        mEncontro1 = True
                        mEncontro2 = True
                        Exit For
                    End If

                    If mEncontro2 = True Then
                        mEstado = mRegistro(5)
                        mEncontro2 = False
                    End If
                Next



            Next

        Catch ex As Exception


        End Try

        Return mEstado

    End Function

End Class
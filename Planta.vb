Imports System.IO

Public Class Planta

    Public Sub CargarPlanta()


        'VALIDAR EXISTENCIA DE ARCHIVO
        'cargo el archivo
        Dim encontro As Boolean = True
        Try
            Dim oArchivo As New Archivos
            Dim mRuta As String = oArchivo.LeerRutaArchivoEntrada
            Dim objReader As New StreamReader(mRuta)
            Dim Sline As String = ""
            Dim arrText As New ArrayList
            Dim arrCadena As String()


            'recorro el archivo y lo cargo en una lista

            Sline = objReader.ReadLine

            Do While Sline Is Nothing = False
                arrText.Add(Sline)
                Sline = objReader.ReadLine
            Loop
            objReader.Close()

            arrCadena = Split(arrText(2), "|")

            'cargo la planta

            FrmPrincipal.txtPlanta.Text = arrCadena(0)


        Catch ex As Exception


        End Try

    End Sub

End Class

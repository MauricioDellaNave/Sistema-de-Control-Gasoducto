Public Class Encriptar

    Dim sPalabra, sCaracter As String
    Dim sCodAscii As Char
    Dim iLongTexto As Integer

    'Funcion para desencriptar la clave de ingreso
    'Por el momento no la utilizo 
    Public Function Desencriptar(ByVal clave As String) As String
        ' Borro palabra
        sPalabra = ""
        ' Obtengo el largo del texto
        iLongTexto = Len(clave)
        ' recorro todo el texto
        Dim i As Integer

        For i = 1 To iLongTexto
            'tomo el caracter
            sCaracter = Mid(clave, i, 1)
            'desencripto el caracter
            sCodAscii = Chr(Int(Asc(sCaracter) / 2) + 32)
            'Si el codigo ASCII es impar la convierto a minusculas sino mayusculas
            If (Asc(sCaracter) Mod 2) = 0 Then sCaracter = UCase(sCodAscii) Else sCaracter = LCase(sCodAscii)
            ' armo el string de caracteres desencriptados
            sPalabra = sPalabra + sCaracter
        Next i
        ' Devuelvo la palabra desencriptada
        Desencriptar = sPalabra
    End Function

    'Funcion para encriptar la clave de ingreso al sistema de cada usuario
    Public Function Encriptar(ByVal clave As String) As String

        Dim i, iMayuscula, iResto As Integer

        ' Borro palabra
        On Error GoTo Manejoerror

        sPalabra = ""
        ' Obtengo el largo del texto
        iLongTexto = Len(clave)
        ' recorro todo el texto
        For i = 1 To iLongTexto
            'tomo el caracter
            sCaracter = Mid(clave, i, 1)
            'tomo el código de la mayúscula
            iMayuscula = Asc(UCase(sCaracter))
            ' Si la tecla ingresada es mayusculas pongo resto en 0 sino resto=1
            If iMayuscula = Asc(sCaracter) Then iResto = 0 Else iResto = 1
            ' Encripto el caracter
            sCaracter = Chr(((iMayuscula - 32) * 2) + iResto)
            ' armo el string de caracteres encriptados
            sPalabra = sPalabra + sCaracter
        Next i
        'Devuelvo la palabra encriptada
        Encriptar = sPalabra

Manejoerror: Exit Function

    End Function

End Class

Public Class Convertir
    Dim letras As String()() = {
        New String() {"", "Uno", "Dos ", "Tres ", "Cuatro ", "Cinco ", "Seis ", "Siete ", "Ocho ", "Nueve "}, 'Unidades
        New String() {"Cien ", "Once ", "Doce ", "Trece ", "Catorce ", "Quince ", "Dieciseis ", "Diecisiete ", "Dieciocho ", "Diecinueve ",
            "Veintiuno ", "Veintidos ", "Veintitres ", "Veintocuatro ", "Veinticinco ", "Veintiseis ", "Veintisiete ", "Veintiocho ", "Ventinueve "}, 'Especiales
        New String() {"", "Diez ", "Veinte ", "Treinta ", "Cuarenta ", "Cincuenta ", "Sesenta ", "Setenta ", "Ochenta ", "Noventa "}, 'Decenas
        New String() {"", "Ciento ", "Doscientos ", "Trescientos ", "Cuatrocientos ", "Quinientos ", "Seiscientos ", "Setecientos ",
            "Ochocientos ", "Novecientos "}, 'Centenas
        New String() {"Un ", "Mil ", "Millon ", "Billon "} 'Millares
    }
    Public Function convertirNumeroLetra(ByVal num As String)
        Dim unidades, enlace, especiales, decenas, centenas, millares, unidadMillar As String
        Dim longitud As Int16 = num.Length
        If longitud = 1 Then
            unidades = obtenerUnidades(longitud - 1, num)
        End If
        especiales = obtenerEspeciales(longitud - 1, num)
        If especiales.Length <= 0 And longitud = 2 Then
            '31=> 3 decena y 1 unidad
            decenas = obtenerUnidades(longitud, num.Substring(0, 1))
            unidades = obtenerUnidades(longitud - 2, num.Substring(1, 1))
            enlace = If(unidades.Length > 0, "y ", "")
        End If
        If longitud = 4 Then
            '3124=> 3 millar, 1 centena, 2 decena y 4 unidad
            millares = obtenerUnidades(longitud, 1)

            If (num.Substring(0, 1) = "1") Then
                unidadMillar = letras(4)(0)
            Else
                unidadMillar = obtenerUnidades(longitud - 4, num.Substring(0, 1))
            End If
            longitud = longitud - 1
            num = num.Substring(1, 3)
        End If
        If longitud = 3 Then
            If num = 100 Then
                especiales = letras(1)(0)
            Else
                Dim especial = num.Substring(1, 2)
                '312=> 3 centena, 1 decena y 2 unidad
                centenas = obtenerUnidades(longitud, num.Substring(0, 1))
                especiales = obtenerEspeciales(longitud - 2, especial)
                If especiales.Length <= 0 Then
                    decenas = obtenerUnidades(longitud - 1, num.Substring(1, 1))
                    unidades = obtenerUnidades(longitud - 3, num.Substring(2, 1))
                    enlace = If(unidades.Length > 0 And decenas.Length > 0, "y ", "")
                End If
            End If
        End If
        Return unidadMillar + millares + centenas + decenas + enlace + especiales + unidades
    End Function
    Function obtenerEspeciales(ByVal n As Int16, ByVal especial As String)
        Dim valor As String = ""
        If (especial > 10 And especial < 20) Then
            valor = obtenerUnidades(n, especial - 10)

        ElseIf (especial > 20 And especial < 30) Then
            valor = obtenerUnidades(n, especial - 11)
        End If
        Return valor
    End Function
    Function obtenerUnidades(ByVal n As Int16, ByVal num As String)
        Return letras(n)(num)
    End Function
End Class

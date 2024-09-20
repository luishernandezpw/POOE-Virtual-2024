Module Module1

    Sub Main()
        Dim continuar As String = "s"
        While continuar = "s"
            Console.WriteLine("::.. MENU ..::")
            Console.WriteLine("1. Determinar si un numero es par o impar.")
            Console.WriteLine("2. Determinar si un numero es primo o no.")
            Console.WriteLine("3. Serie Fibonacci.")
            Console.WriteLine("4. Tabla Multiplicar.")
            Console.WriteLine("5. Salir.")
            Console.Write("Opcion: ")
            Dim opcion As Integer = Console.ReadLine()
            Console.Clear()
            Select Case opcion
                Case 1
                    parImpar()
                Case 2
                    primo()
                Case 3
                    fibonacci()
                Case 4
                    tablaMultiplicar()
                Case Else
                    continuar = "n"
            End Select
        End While
    End Sub
    Sub tablaMultiplicar()
        Console.Write("Tabla: ")
        Dim i = 0, ntabla As Integer = Console.ReadLine()

        For i = 1 To 10 Step 1
            Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i)
        Next
    End Sub
    Sub fibonacci()
        Console.Write("Maximo a mostrar: ")
        Dim n As Integer = Console.ReadLine()
        Dim a = 1, b = 0, c As Integer = 1

        While c <= n
            c = a + b
            Console.WriteLine("{0}+{1}={2}", a, b, c)
            b = a
            a = c
        End While
    End Sub
    Sub primo()
        'Un numero es primo solo si es divisible entre el mismo y la unidad.
        Dim respuesta As String = "NO es primo"
        Dim num, n, i As Integer
        n = 0
        i = 1
        Console.Write("Num: ")
        num = Console.ReadLine()

        While (n <= 2 And i <= num)
            If (determinarParImpar(num, i)) Then
                n = n + 1
            End If
            i = i + 1
        End While
        If (n <= 2) Then
            respuesta = "SI es primo"
        End If
        Console.WriteLine("El numero {0} {1}", num, respuesta)
    End Sub
    Sub parImpar()
        Dim num As Integer

        Console.Write("Num: ")
        num = Console.ReadLine()

        Dim respuesta As String = "Impar"
        If (determinarParImpar(num, 2)) Then
            respuesta = "Par"
        End If
        Console.WriteLine("El numero {0} es: {1}", num, respuesta)
    End Sub
    Function determinarParImpar(ByVal num As Integer, ByVal i As Integer)
        Return num Mod i = 0
    End Function

End Module

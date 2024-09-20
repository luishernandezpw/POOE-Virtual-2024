Module Module1

    Sub Main()
        'Ejercicio 3. Determinarsi un numero si numero es par o impar.
        Dim continuar As String = "s"
        While continuar = "s"
            Dim num As Integer

            Console.Write("Num: ")
            num = Console.ReadLine()

            Dim respuesta As String = "Impar"
            If num Mod 2 = 0 Then
                respuesta = "Par"
            End If
            Console.WriteLine("El numero {0} es: {1}", num, respuesta)

            Console.Write("Desea continuar? Presiones S, sino cualquier otra tecla: ")
            continuar = Console.ReadLine()
        End While
    End Sub

End Module

Module Module1

    Sub Main()
        'Ejercicio 2: Determinar el mayor de 3 números.
        Dim num1, num2, num3, mayor As Integer

        Console.Write("Num 1: ")
        num1 = Console.ReadLine()

        Console.Write("Num 2: ")
        num2 = Console.ReadLine()

        Console.Write("Num 3: ")
        num3 = Console.ReadLine()

        If num1 > num2 Then
            mayor = num1
        Else
            mayor = num2
        End If
        If num3 > mayor Then
            mayor = num3
        End If
        Console.WriteLine("EL mayor de los tres numeros es: {0}", mayor)

        Console.ReadKey() 'Pausa.
    End Sub

End Module

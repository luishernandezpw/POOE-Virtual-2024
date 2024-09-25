Module Module1
    Dim objEstadistica As New Estadistica

    Sub Main()
        Dim continuar As Boolean = True
        Do While continuar
            Console.WriteLine("** MENU **")
            Console.WriteLine("1. Media Armonica")
            Console.WriteLine("2. Media Aritmetica")
            Console.WriteLine("3. Salir")
            Console.Write("Opcion: ")
            Dim opcion As String = Console.ReadLine()
            Console.Clear()

            Select Case opcion
                Case 1
                    Console.Write("Serie: ")
                    Dim serie As String = Console.ReadLine()
                    Console.WriteLine("Media Armonica: {0}", objEstadistica.armonica(serie))
                Case 2
                    Console.Write("Serie: ")
                    Dim serie As String = Console.ReadLine()
                    Console.WriteLine("Media Aritmetica: {0}", objEstadistica.media(serie))
                Case Else
                    continuar = False
            End Select
        Loop
    End Sub

End Module

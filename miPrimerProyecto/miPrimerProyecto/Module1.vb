Module Module1
    Dim objEstadistica As New Estadistica

    Sub Main()
        Console.Write("Serie: ")
        Dim serie As String = Console.ReadLine()
        Dim armonica As Double = objEstadistica.armonica(serie)

        Console.WriteLine("Media armonica: {0}", Math.Round(armonica, 2))

        Console.ReadKey() 'Pausa
    End Sub

End Module

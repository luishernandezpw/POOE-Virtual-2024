Public Class Estadistica
    Dim suma As Double

    Public Function armonica(ByVal serie As String)
        Dim valores() As String = serie.Split(",")
        For Each valor As String In valores
            suma += 1 / valor
        Next
        Return valores.Length / suma
    End Function
End Class

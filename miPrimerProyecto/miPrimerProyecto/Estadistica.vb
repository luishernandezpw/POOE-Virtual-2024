Public Class Estadistica
    Dim suma As Double = 1

    Private Function obtenerSerie(ByVal serie As String)
        If serie.Length > 0 Then
            Return serie.Split(",")
        End If
        Return Array.Empty(Of String)()
    End Function
    Public Function armonica(ByVal serie As String)
        Dim valores() As String = obtenerSerie(serie)
        For Each valor As String In valores
            suma += 1 / valor
        Next
        Return valores.Length / suma
    End Function
    Public Function media(ByVal serie As String)
        Dim valores() As String = obtenerSerie(serie)
        For Each valor As String In valores
            suma += valor
        Next
        Return suma / valores.Length
    End Function
End Class

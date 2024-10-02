Public Class Consumo
    Dim tarifas()() As String = {
        New String() {1, 18, 6, 0.0},
        New String() {19, 28, 6, 0.45},
        New String() {29, 9999999, 10.5, 0.65}
    }
    Function calcularConsumo(ByVal metros As Int16)
        Dim consumo As Double = 0.0
        For Each tarifa As String() In tarifas
            If metros >= tarifa(0) And metros <= tarifa(1) Then
                'mts = 25 - 18 = 7 * 0.45 = 3.15 + 6 = 9.15 
                'mts = 38 - 28 = 10 * 0.65 = 6.5 + 10.5 = 17
                consumo = tarifa(2) + (metros - (tarifa(0) - 1)) * tarifa(3)
            End If
        Next
        Return consumo
    End Function
End Class

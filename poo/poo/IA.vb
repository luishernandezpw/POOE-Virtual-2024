Public Class IA
    Public tablero(,) As Integer = New Integer(2, 2) {
        {-1, -1, -1},
        {-1, -1, -1},
        {-1, -1, -1}
    }
    Public ganador As Integer = -1
    Public mejorPosicion() As Integer = New Integer(1) {}
    Public Sub pulsarBoton(ByVal x As Int16, ByVal y As Int16)
        If tablero(x, y) = -1 AndAlso ganador = -1 Then
            tablero(x, y) = 1 'Usuario = 1
            ganador = ganarPartida()
            ponerFichaOrdenador()
        End If
    End Sub
    Public Function ganarPartida() As Integer
        If tablero(0, 0) <> -1 AndAlso tablero(0, 0) = tablero(1, 1) AndAlso tablero(0, 0) = tablero(2, 2) Then ' \ diagonal
            Return tablero(0, 0)
        End If
        If tablero(0, 2) <> -1 AndAlso tablero(0, 2) = tablero(1, 1) AndAlso tablero(0, 2) = tablero(2, 0) Then ' / diagonal
            Return tablero(0, 2)
        End If
        For i As Int16 = 0 To 2
            If tablero(i, 0) <> -1 AndAlso tablero(i, 0) = tablero(i, 1) AndAlso tablero(i, 0) = tablero(i, 2) Then ' horizontal
                Return tablero(i, 0)
            End If
            If tablero(0, i) <> -1 AndAlso tablero(0, i) = tablero(1, i) AndAlso tablero(0, i) = tablero(2, i) Then ' vertical
                Return tablero(0, i)
            End If
        Next
        Return -1
    End Function
    Public Function tableroLleno() As Boolean
        For i As Int16 = 0 To 2
            For j As Int16 = 0 To 2
                If tablero(i, j) = -1 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Public Function finPartida() As Boolean
        Return tableroLleno() OrElse ganarPartida() <> -1
    End Function
    Public Sub ponerFichaOrdenador()
        If Not finPartida() Then
            Dim f As Int16 = 0, c As Int16 = 0, aux As Integer
            Dim m As Integer = Integer.MinValue
            For i As Int16 = 0 To 2
                For j As Int16 = 0 To 2
                    If tablero(i, j) = -1 Then
                        tablero(i, j) = 0 'Ordenador = 0
                        aux = min()
                        If aux > m Then
                            m = aux
                            f = i
                            c = j
                        End If
                        tablero(i, j) = -1
                    End If
                Next
            Next
            tablero(f, c) = 0 'Ordenador = 0
            mejorPosicion(0) = f
            mejorPosicion(1) = c
        End If
    End Sub
    Private Function max() As Integer
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return -1
            Else
                Return 0
            End If
        End If
        Dim m As Integer = Integer.MinValue
        For i As Int16 = 0 To 2
            For j As Int16 = 0 To 2
                If tablero(i, j) = -1 Then
                    tablero(i, j) = 0 'Ordenador = 0
                    m = Math.Max(m, min())
                    tablero(i, j) = -1
                End If
            Next
        Next
        Return m
    End Function
    Private Function min() As Integer
        If finPartida() Then
            If ganarPartida() <> -1 Then
                Return 1
            Else
                Return 0
            End If
        End If
        Dim m As Integer = Integer.MaxValue
        For i As Int16 = 0 To 2
            For j As Int16 = 0 To 2
                If tablero(i, j) = -1 Then
                    tablero(i, j) = 1 'Usuario = 1
                    m = Math.Min(m, max())
                    tablero(i, j) = -1
                End If
            Next
        Next
        Return m
    End Function
End Class

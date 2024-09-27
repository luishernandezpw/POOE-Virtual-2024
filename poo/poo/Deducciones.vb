Public Class Deducciones
    Public isss, afp, isr, vacaciones, aguinaldo As Double
    Dim tablaIsr()() As Double = {
        New Double() {0, 472.0, 0.0, 0.0},
        New Double() {472.01, 895.24, 0.1, 17.67},
        New Double() {895.25, 2038.1, 0.2, 60.0},
        New Double() {2038.11, 99999999, 0.3, 288.57}
    }
    Sub calcularDeducciones(ByVal sueldo As Double, ByVal tiempo As Int16)
        isss = calcular(sueldo, 0.03) '3% = 0.03
        afp = calcular(sueldo, 0.0625) '6.25% = 0.0625
        isr = calcularIsr(sueldo - isss - afp)
        vacaciones = cacularVaciones(sueldo)
        aguinaldo = calcularAguinaldo(sueldo, tiempo)
    End Sub
    Function calcularAguinaldo(ByVal sueldo As Double, ByVal tiempo As Int16)
        Dim aguinaldo As Double
        Select Case tiempo
            Case 0
                aguinaldo = sueldo / 30 * 10 'Proporcional a los dias trabajados
            Case 1
                aguinaldo = sueldo / 30 * 15
            Case 2
                aguinaldo = sueldo / 30 * 19
            Case 3
                aguinaldo = sueldo / 30 * 21
        End Select
        Return Math.Round(aguinaldo, 2)
    End Function
    Function cacularVaciones(ByVal sueldo As Double)
        Return Math.Round(sueldo / 2 * 0.3, 2)
    End Function
    Function calcularIsr(ByVal sueldo As Double)
        Dim valorIsr As Double
        For Each tramo In tablaIsr
            If (sueldo >= tramo(0) And sueldo <= tramo(1)) Then
                valorIsr = (sueldo - tramo(0)) * tramo(2) + tramo(3)
            End If
        Next
        Return valorIsr
    End Function
    Function calcular(ByVal sueldo As Double, ByVal porcentaje As Double)
        Return Math.Round(sueldo * porcentaje, 2)
    End Function
End Class

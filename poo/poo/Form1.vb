Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim objIa As New IA()
    Sub verificarGanador()
        Dim i As Integer = 1
        Dim btn As Control
        For x As Int16 = 0 To 2
            For y As Int16 = 0 To 2
                If objIa.mejorPosicion(0) = x AndAlso objIa.mejorPosicion(1) = y Then
                    btn = Me.Controls("btn" & i)
                    btn.Text = btnMaquina.Text
                    btn.Enabled = False
                End If
                i += 1
            Next
        Next
        If objIa.ganador = 1 Then
            lblresultado.Text = "Ganaste"
        ElseIf objIa.ganador = 0 Then
            lblresultado.Text = "Perdiste"
        ElseIf objIa.tableroLleno() AndAlso objIa.ganador = -1 Then
            lblresultado.Text = "Empate"
        End If
    End Sub
    Sub establecerBoton(x As Int16, y As Int16, indexBtn As Int16)
        If objIa.tablero(x, y) = -1 Then
            Dim nombreBtn As String = "btn" & indexBtn
            Dim btn As Control = Me.Controls(nombreBtn)
            btn.Text = btnUsuario.Text
            btn.Enabled = False
            objIa.pulsarBoton(x, y)
            objIa.ganador = objIa.ganarPartida()
            verificarGanador()
        End If

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        establecerBoton(0, 0, 1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        establecerBoton(0, 1, 2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        establecerBoton(0, 2, 3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        establecerBoton(1, 0, 4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        establecerBoton(1, 1, 5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        establecerBoton(1, 2, 6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        establecerBoton(2, 0, 7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        establecerBoton(2, 1, 8)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        establecerBoton(2, 2, 9)
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim i As Integer = 1
        For x As Int16 = 0 To 2
            For y As Int16 = 0 To 2
                objIa.tablero(x, y) = -1
                Dim nombreBtn As String = "btn" & i
                Dim btn As Control = Me.Controls(nombreBtn)
                btn.Text = ""
                btn.Enabled = True
                i += 1
            Next
        Next
        objIa.ganador = -1
        lblresultado.Text = "Resultado"
    End Sub
End Class

Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim num1 As Double = txtNum1.Text
        Dim num2 As Double = txtNum2.Text
        Dim opcion As Integer = cboOpcion.SelectedIndex
        Dim respuesta As Double
        Select Case opcion
            Case 0
                respuesta = num1 + num2
            Case 1
                respuesta = num1 - num2
            Case 2
                respuesta = num1 * num2
            Case 3
                respuesta = num1 / num2
        End Select
        MessageBox.Show("La respuesta es: " & respuesta, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboOpcion.SelectedIndex = 0
    End Sub
End Class

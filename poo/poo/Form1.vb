Public Class Form1
    Dim consumo As New Consumo
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            Dim respuesta As Double = consumo.calcularConsumo(txtMetros.Text)
            lblRespuesta.ForeColor = Color.Black
            lblRespuesta.Text = "El total a pagar es: $" & respuesta
        Catch ex As Exception
            lblRespuesta.Text = "Valor incorrecto, consumo en metros"
            lblRespuesta.ForeColor = Color.Red
            txtMetros.Focus() 'enviado el enfoque hacia la caja de texto
        End Try
    End Sub
End Class

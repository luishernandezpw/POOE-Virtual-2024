Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim consumo As New Consumo
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            calcularPago()
            Dim pago As Double = lblPago.Text
            If pago > 0 Then
                ltsHistorial.Items.Add(txtMetros.Text & " --> $" & pago)
                erpConsumo.Clear()
            End If
        Catch ex As Exception
            erpConsumo.SetError(txtMetros, "Valor incorrecto, consumo en metros")
            'txtMetros.Focus() 'enviado el enfoque hacia la caja de texto
        End Try
    End Sub
    Sub calcularPago()
        Dim respuesta As Double = consumo.calcularConsumo(Integer.Parse(txtMetros.Text))
        lblPago.Text = respuesta
    End Sub

    Private Sub txtMetros_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMetros.KeyUp
        Try
            calcularPago()
            lblPago.ForeColor = Color.Black
            erpConsumo.Clear()
        Catch ex As Exception
            erpConsumo.SetError(txtMetros, "Valor incorrecto, consumo en metros")
            lblPago.Text = "0.00"
            lblPago.ForeColor = Color.Red
            'txtMetros.Focus() 'enviado el enfoque hacia la caja de texto
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ltsHistorial.Items.Add("Mts " & " -- " & "Pago")
    End Sub
End Class

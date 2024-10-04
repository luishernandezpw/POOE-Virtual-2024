Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim objConversor As New Convertir()

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        lblValorLetras.Text = objConversor.convertirNumeroLetra(txtNumero.Text)
    End Sub

    Private Sub txtNumero_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyUp
        Try
            lblValorLetras.Text = objConversor.convertirNumeroLetra(txtNumero.Text)
        Catch ex As Exception
            erpConsumo.SetError(txtNumero, ex.Message)
        End Try
    End Sub
End Class

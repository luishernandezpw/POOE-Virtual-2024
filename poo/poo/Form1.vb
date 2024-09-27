Public Class Form1
    Dim objDeducciones As New Deducciones

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim sueldo As Double = txtSueldo.Text

        objDeducciones.calcularDeducciones(sueldo, cboTiempo.SelectedIndex)
        lblIsss.Text = "ISSS: " + objDeducciones.isss.ToString()
        lblAfp.Text = "AFP: " + objDeducciones.afp.ToString()
        lblIsr.Text = "ISR: " + objDeducciones.isr.ToString()
        lblVacaciones.Text = "Vacaciones: " + objDeducciones.vacaciones.ToString()
        lblAguinaldo.Text = "Aguinaldo: " + objDeducciones.aguinaldo.ToString()
    End Sub
End Class

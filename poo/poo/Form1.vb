Public Class Form1
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        MessageBox.Show("Hola, " + txtNombre.Text, "Saludo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

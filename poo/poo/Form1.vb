Public Class Form1
    Dim objDirecciones As New Direcciones

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDeptos.Items.AddRange(objDirecciones.deptos)
    End Sub
    Private Sub cboDeptos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDeptos.SelectedIndexChanged
        cboMun.Items.Clear()
        cboDistritos.Items.Clear()
        cboMun.Items.AddRange(objDirecciones.municipios(cboDeptos.SelectedIndex))
    End Sub

    Private Sub cboMun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMun.SelectedIndexChanged
        cboDistritos.Items.Clear()
        cboDistritos.Items.AddRange(objDirecciones.distritos(cboDeptos.SelectedIndex)(cboMun.SelectedIndex))
    End Sub
End Class

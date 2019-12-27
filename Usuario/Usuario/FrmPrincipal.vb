Public Class FrmPrincipal
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Variables.vista = 0
        FrmClientes.Show()
    End Sub

    Private Sub BtnCuentas_Click(sender As Object, e As EventArgs) Handles BtnCuentas.Click
        FrmCrearCuenta.Show()
    End Sub

    Private Sub BtnMovimientos_Click(sender As Object, e As EventArgs) Handles BtnMovimientos.Click
        FrmMovimientos.Show()
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        FrmReportes.Show()
    End Sub

    Private Sub FrmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmLogin.Close()
    End Sub

    Private Sub BtnDetalles_Click(sender As Object, e As EventArgs) Handles BtnDetalles.Click
        FrmDetalles.Show()
    End Sub
End Class
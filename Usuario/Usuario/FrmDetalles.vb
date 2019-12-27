Imports System.Data.SqlClient
Public Class FrmDetalles
    Private da As SqlDataAdapter
    Private dt As DataTable
    Dim source1 As BindingSource
    Private Sub FrmDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sSel As String
            source1 = New BindingSource()
            sSel = "execute sp_Detalles"
            Dim ds As New DataSet
            dt = New DataTable
            da = New SqlDataAdapter(sSel, dbConnection)
            ds.Tables.Add("TablaDetalles")
            da.Fill(ds.Tables("TablaDetalles"))
            source1.DataSource = ds.Tables("TablaDetalles")
            Me.DataGridVDetalles.DataSource = source1

        Catch ex As Exception
            MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtDNICliente_TextChanged(sender As Object, e As EventArgs) Handles TxtDNICliente.TextChanged
        If TxtDNICliente.Text.Length <= 8 Then
            source1.Filter = "DNI like '" + TxtDNICliente.Text + "%'"
        End If
    End Sub

    Private Sub TxtDNICliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNICliente.KeyPress
        SoloNumerosYBorrar(e)
    End Sub
End Class
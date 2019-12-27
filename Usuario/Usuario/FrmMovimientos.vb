Imports System.Data.SqlClient

Public Class FrmMovimientos
    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Private Sub BtnBuscarClientes_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Variables.vista = 2
        FrmClientes.Show()
        FrmClientes.TxtBuscarCliente.Focus()
        FrmClientes.BtnAgregar.Visible = True
    End Sub

    Private Sub FrmMovimientos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Variables.vista = 0
    End Sub

    Private Sub FrmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtNombre.Clear()
        Me.TxtDNI.Clear()
        Me.TxtNombre.Enabled = False
        Me.TxtDNI.Enabled = False
        Me.TxtSaldo.Enabled = False
        Dim sSel As String = "execute sp_ListarOperaciones"
        Try
            Me.ComboOperacion.Items.Clear()
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim fii As Integer = 0
                While fii < dt.Rows.Count
                    Dim dr As DataRow = dt.Rows(fii)
                    Me.ComboOperacion.Items.Add(dr("IdOperacion").ToString.Trim)
                    fii = fii + 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI.TextChanged
        Dim sSel As String = "execute sp_consultarTarjeta " + TxtDNI.Text
        Try
            Me.ComboTarjeta.Items.Clear()
            If TxtDNI.Text <> "" Then
                da = New SqlDataAdapter(sSel, dbConnection)
                dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    Dim fii As Integer = 0
                    While fii < dt.Rows.Count
                        Dim dr As DataRow = dt.Rows(fii)
                        Me.ComboTarjeta.Items.Add(dr("NumTarjeta").ToString.Trim)
                        fii = fii + 1
                    End While
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboTarjeta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTarjeta.SelectedIndexChanged
        Dim sSel As String = "execute sp_consultarCtaTarjeta '" + Me.ComboTarjeta.SelectedItem.ToString + "'"
        Try
            Me.ComboCtaBancaria.Items.Clear()
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then

                Dim fii As Integer = 0
                While fii < dt.Rows.Count
                    Dim dr As DataRow = dt.Rows(fii)
                    Me.ComboCtaBancaria.Items.Add(dr("IdCtaBancaria").ToString.Trim)
                    fii = fii + 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboOperacion.SelectedIndexChanged
        If (ComboOperacion.SelectedItem.ToString() = "DEPO") Then
            TxtCtaDestino.Show()
            LblCtaDestino.Show()
        Else
            TxtCtaDestino.Hide()
            LblCtaDestino.Hide()
        End If
    End Sub

    Private Sub BtnRealizarTransaccion_Click(sender As Object, e As EventArgs) Handles BtnRealizarTransaccion.Click
        Dim sSel As String = "execute sp_GuardarMovimiento '" + Me.ComboCtaBancaria.SelectedItem.ToString + "', '" + Me.ComboOperacion.SelectedItem.ToString + "', '" + Me.TxtCtaDestino.Text + "', '" + Me.TxtMonto.Text + "'"
        Try
            Dim cmd As SqlCommand
            cmd = New SqlCommand(sSel, dbConnection)
            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Movimiento guardado exitosamente")
                TxtDNI.Clear()
                TxtNombre.Clear()
                TxtMonto.Clear()
                TxtCtaDestino.Clear()
                TxtSaldo.Clear()
                ComboCtaBancaria.Items.Clear()
                ComboTarjeta.Items.Clear()
                ComboCtaBancaria.Text = ""
                ComboTarjeta.Text = ""
                ComboOperacion.Text = ""
            Else
                MsgBox("Movimiento NO FUE guardado exitosamente")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ComboCtaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCtaBancaria.SelectedIndexChanged
        da = New SqlDataAdapter("sp_ConsultarSaldo '" & Me.ComboCtaBancaria.SelectedItem.ToString & "'", dbConnection)
        dt = New DataTable
        da.Fill(dt)
        Dim dr As DataRow = dt.Rows(0)
        Me.TxtSaldo.Text = dr("Saldo").ToString
    End Sub

    Private Sub TxtMonto_TextChanged(sender As Object, e As EventArgs) Handles TxtMonto.TextChanged
        If ComboOperacion.SelectedItem.ToString = "DEPO" Or ComboOperacion.SelectedItem.ToString = "RETI" Then
            If TxtMonto.Text <> "" Then
                Dim Saldo As Double = CDbl(TxtSaldo.Text.ToString)
                Dim Monto As Double = CDbl(TxtMonto.Text.ToString)
                If Saldo < Monto Then
                    MsgBox("Saldo insuficiente para Monto")
                    TxtMonto.Clear()
                End If
            End If
        End If
    End Sub
    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(44) Then
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
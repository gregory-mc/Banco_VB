Imports System.Data.SqlClient
Public Class FrmCrearCuenta
    Private da As SqlDataAdapter
    Private dt As DataTable

    Private Sub FrmCrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Clear()
        TxtDNI.Clear()
        GetTiposTarjetas()
        GetTipoCuentas()
    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        Variables.vista = 2
        FrmClientes.Show()
        FrmClientes.TxtBuscarCliente.Focus()
    End Sub

    Private Sub ComboTipoTarj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoTarj.SelectedIndexChanged
        Dim Existe As Boolean = True
        Dim sSel As String
        Dim cad As String = ""
        While Existe = True
            cad = ""
            cad = "4050" '4050 SERÁ EL CODIGO DEL BANCO
            If ComboTipoTarj.Text = "CREDITO" Then
                TxtSaldo.Text = ""
                TxtSaldo.Enabled = False
                ComboCredito.Visible = True
                cad = cad & "1001" '1001 SERÁ EL CODIGO DE CREDITO
                For i = 0 To 7
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            ElseIf ComboTipoTarj.Text = "DEBITO" Then
                TxtSaldo.Text = ""
                TxtSaldo.Enabled = True
                ComboCredito.Visible = False
                cad = cad & "2002" '2002 SERÁ EL CODIGO DE DEBITO
                For i = 0 To 7
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            End If
            sSel = "EXECUTE sp_validarTarjeta " + cad
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Existe = False
            End If
        End While
        TxtNumTarj.Text = cad
    End Sub

    Private Sub ComboTipoCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoCuenta.SelectedIndexChanged
        Dim Existe As Boolean = True
        Dim sSel As String
        Dim cad As String = ""
        While Existe = True
            If ComboTipoCuenta.Text = "AHORROS" Then
                cad = cad & "101" '101 SERÁ EL CODIGO DE AHORROS
                For i = 0 To 6
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            ElseIf ComboTipoCuenta.Text = "CORRIENTE" Then
                cad = cad & "102" '102 SERÁ EL CODIGO DE CORRIENTE
                For i = 0 To 6
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            End If
            sSel = "EXECUTE sp_validarCuenta " + cad
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Existe = False
            End If
        End While
        TxtNumCuenta.Text = cad
    End Sub

    Sub GetTiposTarjetas()
        Try
            Dim sSel As String = "SELECT * FROM TipoTarjeta"
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            For i = 0 To 1
                Dim dr As DataRow = dt.Rows(i)
                ComboTipoTarj.Items.Add(dr("Descripcion").ToString)
            Next
        Catch ex As Exception
            MsgBox("ERROR AL RECUPERAR DATOS DE TIPO DE TARJETAS")
        End Try
    End Sub

    Sub GetTipoCuentas()
        Try
            Dim sSel As String = "SELECT * FROM TipoCuenta"
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            For i = 0 To 1
                Dim dr As DataRow = dt.Rows(i)
                ComboTipoCuenta.Items.Add(dr("Descripcion").ToString)
                ComboTipoCuenta2.Items.Add(dr("Descripcion").ToString)
            Next
        Catch ex As Exception
            MsgBox("ERROR AL RECUPERAR DATOS DE TIPO DE CUENTAS")
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim cmd As New SqlCommand("sp_GuardarCuenta'" & Me.TxtDNI.Text & "', '" & Me.ComboTipoTarj.Text & "', '" & Me.TxtNumTarj.Text & "', '" & Me.ComboTipoCuenta.Text & "', '" & Me.TxtNumCuenta.Text & "', '" & Me.TxtSaldo.Text & "'", dbConnection)
            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Datos Guardados Correctamente")
                LimpiarTextos()
            Else
                MsgBox("No Se Guardaron Los Datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LimpiarTextos()
        Me.ComboCredito.Visible = False
        Me.TxtDNI.Clear()
        Me.TxtNombre.Clear()
        Me.TxtNumCuenta.Clear()
        Me.TxtNumTarj.Clear()
        Me.ComboTipoCuenta.Text = ""
        Me.ComboTipoTarj.Text = ""
        Me.TxtSaldo.Clear()
    End Sub



    Private Sub ComboTcuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipoCuenta2.SelectedIndexChanged
        Dim Existe As Boolean = True
        Dim sSel As String
        Dim cad As String = ""
        While Existe = True
            If ComboTipoCuenta2.Text = "AHORROS" Then
                cad = cad & "101" '101 SERÁ EL CODIGO DE AHORROS
                For i = 0 To 6
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            ElseIf ComboTipoCuenta2.Text = "CORRIENTE" Then
                cad = cad & "102" '102 SERÁ EL CODIGO DE CORRIENTE
                For i = 0 To 6
                    Randomize()
                    cad = cad & CInt(Math.Floor((10) * Rnd()))
                Next
            End If
            sSel = "EXECUTE sp_validarCuenta " + cad
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                Existe = False
            End If
        End While
        TxtNumCuenta2.Text = cad
    End Sub
    Private Sub BtnAgregarCliente2_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente2.Click
        Variables.vista = 2
        FrmClientes.Show()
        FrmClientes.TxtBuscarCliente.Focus()
    End Sub

    Private Sub TxtDNI2_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI2.TextChanged
        If (TxtDNI2.Text.Length = 8) Then
            Dim sSel As String = "Execute sp_consultarTarjeta '" + TxtDNI2.Text + "'"
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(i)
                ComboNroTarjeta2.Items.Add(dr("NumTarjeta").ToString)
            Next
        End If
    End Sub

    Private Sub BtnAñadirCuenta_Click(sender As Object, e As EventArgs) Handles BtnAñadirCuenta.Click
        Try
            Dim cmd As New SqlCommand("sp_GuardarCuenta'" & Me.TxtDNI2.Text & "', ' ', '" & Me.ComboNroTarjeta2.SelectedItem.ToString & "', '" & Me.ComboTipoCuenta2.Text & "', '" & Me.TxtNumCuenta2.Text & "', '" & Me.TxtSaldo2.Text & "'", dbConnection)
            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Datos Guardados Correctamente")
                LimpiarTextos()
            Else
                MsgBox("No Se Guardaron Los Datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboCredito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCredito.SelectedIndexChanged
        If ComboCredito.Text = "CLASICA" Then
            TxtSaldo.Text = "1000"
        ElseIf ComboCredito.Text = "GOLDEN" Then
            TxtSaldo.Text = "3000"
        ElseIf ComboCredito.Text = "PLATINUM" Then
            TxtSaldo.Text = "5000"
        End If
    End Sub

    Private Sub TxtSaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSaldo.KeyPress
        SoloNumerosYBorrar(e)
        If e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub TxtSaldo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSaldo2.KeyPress
        SoloNumerosYBorrar(e)
        If e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(44) Then
            e.Handled = False
        End If
    End Sub

End Class
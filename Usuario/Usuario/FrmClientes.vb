Imports System.Data.SqlClient

Public Class FrmClientes
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private fila As Integer
    Private bandera As Integer = 0
    Private ItemsBackup As New List(Of ListViewItem)

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If vista = 1 Then
            Me.PanelBus.Visible = False
            Me.Width = 780
            Me.Height = 370
            'Me.Size = New Size(Width, Height)
        ElseIf vista = 2 Then
            Me.Width = 780
            Me.Height = 370
            Me.PanelBus.Location = New Point(38, 55)
            Me.PanelReg.Visible = False
        End If
        InicioRsPrincipal()
        HabilitarCajas(False)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        limpiarCajas()
        HabilitarBotones(False)
        HabilitarCajas(True)
        TxtDNI.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (TxtDNI.TextLength = 0 Or TxtNombres.TextLength = 0 Or
        TxtApPat.TextLength = 0 Or TxtApMat.TextLength = 0 Or
        TxtCelular.TextLength = 0 Or TxtDireccion.TextLength = 0) Then
            MsgBox("Hay campos vacíos", MsgBoxStyle.Exclamation, "Campos vacíos")
        Else
            guardar()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarCajas(True)
        HabilitarBotones(False)
        bandera = 1
        Me.TxtDNI.Enabled = False
        TxtNombres.Focus()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Dim cmd As New SqlCommand("sp_EliminarCliente '" & Me.TxtDNI.Text & "'", dbConnection)
            If (cmd.ExecuteNonQuery()) Then
                MsgBox("Datos Eliminados Correctamente")
                limpiarCajas()
                bandera = 0
                InicioRsPrincipal()
            Else
                MsgBox("No se puedo eliminar los datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'cn.Close()
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If vista = 2 Then
            If Me.ListaClientes.SelectedItems.Count > 0 Then
                If (FrmMovimientos.Visible) Then
                    FrmMovimientos.TxtNombre.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(1).Text
                    FrmMovimientos.TxtDNI.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(0).Text
                ElseIf (FrmCrearCuenta.ControlCuenta.SelectedIndex = 0) Then
                    FrmCrearCuenta.TxtNombre.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(1).Text
                    FrmCrearCuenta.TxtDNI.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(0).Text
                ElseIf (FrmCrearCuenta.ControlCuenta.SelectedIndex = 1) Then
                    FrmCrearCuenta.TxtNombre2.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(1).Text
                    FrmCrearCuenta.TxtDNI2.Text = Me.ListaClientes.SelectedItems.Item(0).SubItems(0).Text
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub ListaClientes_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListaClientes.SelectedIndexChanged
        If Me.ListaClientes.SelectedIndices.Count > 0 Then
            fila = Me.ListaClientes.SelectedIndices.Item(0)
            'tt = ListView1.SelectedItems.Item(0).SubItems(1).Text
            mostrarDatos(fila)
        End If
    End Sub

    Sub InicioRsPrincipal()
        Dim sSel As String = "execute pa_ListaClientes"
        bandera = 0
        Try
            ListaClientes.Items.Clear()
            da = New SqlDataAdapter(sSel, dbConnection)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'btn_primero_Click(Nothing, Nothing)
                Dim fii As Integer = 0
                While fii < dt.Rows.Count
                    Dim dr As DataRow = dt.Rows(fii)
                    Me.ListaClientes.Items.Add(dr("IdCliente").ToString.Trim)
                    Me.ListaClientes.Items(fii).SubItems.Add(dr("Nombre").ToString.Trim)
                    Me.ListaClientes.Items(fii).SubItems.Add(dr("ApPaterno").ToString.Trim)
                    Me.ListaClientes.Items(fii).SubItems.Add(dr("ApMaterno").ToString.Trim)
                    Me.ListaClientes.Items(fii).SubItems.Add(dr("Celular").ToString.Trim)
                    Me.ListaClientes.Items(fii).SubItems.Add(dr("Direccion").ToString.Trim)
                    fii = fii + 1
                End While
                ItemsBackup.Clear()
                For Each item As ListViewItem In ListaClientes.Items
                    ItemsBackup.Add(item)
                Next
            Else
                fila = -1
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If (ListaClientes.Items.Count > 0) Then
            ListaClientes.Items(0).Selected = True
        End If
    End Sub

    Private Sub mostrarDatos(ByVal f As Integer)
        Dim uf As Integer = dt.Rows.Count - 1
        If f < 0 OrElse uf < 0 Then Exit Sub

        Dim dr As DataRow = dt.Rows(f)
        Me.TxtDNI.Text = dr("IdCliente").ToString.Trim
        Me.TxtNombres.Text = dr("Nombre").ToString.Trim
        Me.TxtApPat.Text = dr("ApPaterno").ToString.Trim
        Me.TxtApMat.Text = dr("ApMaterno").ToString.Trim
        Me.TxtCelular.Text = dr("Celular").ToString.Trim
        Me.TxtDireccion.Text = dr("Direccion").ToString.Trim
        HabilitarCajas(False)
        HabilitarBotones(True)
    End Sub

    Private Sub limpiarCajas()
        Me.TxtDNI.Text = ""
        Me.TxtNombres.Text = ""
        Me.TxtApPat.Text = ""
        Me.TxtApMat.Text = ""
        Me.TxtCelular.Text = ""
        Me.TxtDireccion.Text = ""
        Me.TxtDNI.Focus()
    End Sub

    Private Sub HabilitarBotones(boo)
        Me.BtnNuevo.Enabled = boo
        Me.BtnEliminar.Enabled = boo
        Me.BtnModificar.Enabled = boo
        Me.BtnGuardar.Enabled = Not boo
    End Sub
    Private Sub HabilitarCajas(boo)
        Me.TxtDNI.Enabled = boo
        Me.TxtNombres.Enabled = boo
        Me.TxtApPat.Enabled = boo
        Me.TxtApMat.Enabled = boo
        Me.TxtCelular.Enabled = boo
        Me.TxtDireccion.Enabled = boo
    End Sub

    Sub guardar()
        If bandera = 0 Then
            Try
                Dim cmd As New SqlCommand("sp_GuardarCliente'" & Me.TxtDNI.Text & "', '" & Me.TxtNombres.Text & "', '" & Me.TxtApPat.Text & "', '" & Me.TxtApMat.Text & "', '" & Me.TxtCelular.Text & "', '" & Me.TxtDireccion.Text & "'", dbConnection)
                If (cmd.ExecuteNonQuery()) Then
                    MsgBox("Datos Guardados Correctamente")
                    bandera = 0
                    limpiarCajas()
                    InicioRsPrincipal()
                Else
                    MsgBox("No se guardaron los datos")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'cn.Close()
            End Try
        Else
            Try
                Dim cmd As New SqlCommand("sp_ModificarCliente '" & Me.TxtDNI.Text & "', '" & Me.TxtNombres.Text & "', '" & Me.TxtApPat.Text & "', '" & Me.TxtApMat.Text & "', '" & Me.TxtCelular.Text & "', '" & Me.TxtDireccion.Text & "'", dbConnection)
                If (cmd.ExecuteNonQuery()) Then
                    MsgBox("Datos Modificados Correctamente")
                    bandera = 0
                    limpiarCajas()
                    InicioRsPrincipal()
                Else
                    MsgBox("No se puedo modificar los datos")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'cn.Close()
            End Try
        End If
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        FrmClientes_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCliente.TextChanged
        If TxtBuscarCliente.Text.Length = 0 Then
            InicioRsPrincipal()
        End If
        If TxtBuscarCliente.Text.Length <= 8 Then
            Me.ListaClientes.BeginUpdate()
            Me.ListaClientes.Items.Clear()
            For Each item As ListViewItem In ItemsBackup
                If (item.Text.StartsWith(Me.TxtBuscarCliente.Text)) Then
                    Me.ListaClientes.Items.Add(item)
                End If
            Next
            Me.ListaClientes.EndUpdate()
        End If
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        SoloNumerosYBorrar(e)
    End Sub

    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress
        SoloNumerosYBorrar(e)
    End Sub

    Private Sub TxtBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarCliente.KeyPress
        SoloNumerosYBorrar(e)
    End Sub
End Class

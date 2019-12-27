Imports System.Data.SqlClient

Public Class FrmReportes
    Private da As SqlDataAdapter
    Private dt As DataTable
    Private fila As Integer
    Dim source1 As BindingSource


    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCtaBancaria.Enabled = False
        FechaInicial.Enabled = False
        FechaFin.Enabled = False
        FechaInicial.Format = DateTimePickerFormat.Short
        FechaFin.Format = DateTimePickerFormat.Short
        FechaFin.MaxDate = Today
        MesPicker.Enabled = False
        AnoPicker.Enabled = False

    End Sub

    Private Sub ComboBoxCtaBancaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCtaBancaria.SelectedIndexChanged
        If CheckBoxCtaBancaria.Checked Then
            source1.Filter = "IdCtaBancaria= '" + ComboBoxCtaBancaria.SelectedItem + "'"
        End If

    End Sub

    Private Sub CheckBoxFecha_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxFecha.CheckedChanged
        If (FechaInicial.Enabled And FechaFin.Enabled) Then
            FechaInicial.Enabled = False
            FechaFin.Enabled = False
        Else
            FechaInicial.Enabled = True
            FechaFin.Enabled = True
            source1.Filter = "IdCtaBancaria= '+" + "'"
        End If
    End Sub

    Private Sub CheckBoxCtaBancaria_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCtaBancaria.CheckedChanged

        If (CheckBoxCtaBancaria.Checked) Then
            If (ComboBoxCtaBancaria.Enabled) Then
                ComboBoxCtaBancaria.Enabled = False
            Else
                ComboBoxCtaBancaria.Enabled = True
                ComboBoxCtaBancaria.Items.Clear()

                Dim sSel As String = "execute sp_consultaCta " + TxtDNI.Text
                Try
                    ComboBoxCtaBancaria.Text = ""
                    da = New SqlDataAdapter(sSel, dbConnection)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then

                        Dim fii As Integer = 0
                        While fii < dt.Rows.Count
                            Dim dr As DataRow = dt.Rows(fii)
                            Me.ComboBoxCtaBancaria.Items.Add(dr("IdCtaBancaria").ToString.Trim)
                            fii = fii + 1
                        End While
                    End If
                Catch ex As Exception
                    MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            End If
        Else
            ComboBoxCtaBancaria.Text = ""
            ComboBoxCtaBancaria.Enabled = False
            source1.RemoveFilter()
        End If

    End Sub

    Private Sub FechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles FechaInicial.ValueChanged
        If CheckBoxFecha.Checked Then
            source1.Filter = "FechaTransaccion >= '" + FechaInicial.Value.ToString("dd-MM-yyyy") + "'"
        End If
    End Sub

    Private Sub FechaFin_ValueChanged(sender As Object, e As EventArgs) Handles FechaFin.ValueChanged
        If CheckBoxFecha.Checked Then
            source1.Filter = "FechaTransaccion <= '" + FechaFin.Value.ToString("dd-MM-yyyy") + "'"
        End If
    End Sub

    Private Sub TxtDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtDNI.TextChanged
        ComboBoxCtaBancaria.Items.Clear()
        If (TxtDNI.Text.Length = 8) Then
            Try
                Dim sSel As String
                source1 = New BindingSource()
                sSel = "execute sp_reportes " + TxtDNI.Text
                Dim ds As New DataSet
                dt = New DataTable
                da = New SqlDataAdapter(sSel, dbConnection)
                ds.Tables.Add("Tablareporte")
                da.Fill(ds.Tables("Tablareporte"))
                source1.DataSource = ds.Tables("Tablareporte")
                Me.DataGridVReportes.DataSource = source1

            Catch ex As Exception
                MessageBox.Show("ERROR al recuperar los datos:" & vbCrLf & ex.Message, "Mostrar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub FrmReportes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmPrincipal.Show()
    End Sub

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        llenarExcel(DataGridVReportes)
    End Sub

    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.

            exHoja.Cells.Item(1, 3) = "Reportes"
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(3, i) = ElGrid.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 4, Col + 1) = ElGrid.Item(Col, Fila).Value
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna
            'se ajuste al texto

            exHoja.Rows.Item(3).Font.Bold = 1
            exHoja.Rows.Item(3).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

    Private Sub CheckBoxMes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMes.CheckedChanged
        If (CheckBoxMes.Checked) Then
            MesPicker.Enabled = True
            CheckBoxFecha.Checked = False
            source1.Filter = "FechaTransaccion >= '01-" + MesPicker.Value.Month.ToString + "-" + AnoPicker.Value.Year.ToString + "' AND FechaTransaccion <= '31-" + MesPicker.Value.Month.ToString + "-" + AnoPicker.Value.Year.ToString + "'"
        Else
            MesPicker.Enabled = False
            source1.RemoveFilter()
        End If

    End Sub

    Private Sub CheckBoxAño_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAño.CheckedChanged
        If CheckBoxAño.Checked Then
            AnoPicker.Enabled = True
            CheckBoxFecha.Checked = False
            source1.Filter = "FechaTransaccion >= '01-01-" + AnoPicker.Value.Year.ToString + "' AND FechaTransaccion <= '31-12-" + AnoPicker.Value.Year.ToString + "'"
        Else
            AnoPicker.Enabled = False
            source1.RemoveFilter()
        End If
    End Sub

    Private Sub AnoPicker_ValueChanged(sender As Object, e As EventArgs) Handles AnoPicker.ValueChanged
        source1.Filter = "FechaTransaccion >= '01-01-" + AnoPicker.Value.Year.ToString + "' AND FechaTransaccion <= '31-12-" + AnoPicker.Value.Year.ToString + "'"
    End Sub

    Private Sub MesPicker_ValueChanged(sender As Object, e As EventArgs) Handles MesPicker.ValueChanged
        Dim diape As String = MesPicker.Value.AddMonths(1).Month
        Dim fechita As DateTime = "01-" + diape + "-" + AnoPicker.Value.Year.ToString
        diape = fechita.AddDays(-1).Day.ToString
        source1.Filter = "FechaTransaccion >= '01-" + MesPicker.Value.Month.ToString + "-" + AnoPicker.Value.Year.ToString + "' AND FechaTransaccion <= '" + diape + "-" + MesPicker.Value.Month.ToString + "-" + AnoPicker.Value.Year.ToString + "'"

    End Sub

End Class




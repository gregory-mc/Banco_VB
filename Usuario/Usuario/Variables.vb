Module Variables
    Public opciones As Integer
    Public vista As Integer = 0

    Public Sub SoloNumerosYBorrar(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = ChrW(8) Then
                e.Handled = False
            End If
        End If
    End Sub

End Module

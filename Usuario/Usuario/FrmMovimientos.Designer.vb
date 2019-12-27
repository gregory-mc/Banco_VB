<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMovimientos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimientos))
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblTarjeta = New System.Windows.Forms.Label()
        Me.ComboTarjeta = New System.Windows.Forms.ComboBox()
        Me.LblCtaBancaria = New System.Windows.Forms.Label()
        Me.ComboCtaBancaria = New System.Windows.Forms.ComboBox()
        Me.LblOperacion = New System.Windows.Forms.Label()
        Me.ComboOperacion = New System.Windows.Forms.ComboBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.LblCtaDestino = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtCtaDestino = New System.Windows.Forms.TextBox()
        Me.BtnRealizarTransaccion = New System.Windows.Forms.Button()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.BackgroundImage = CType(resources.GetObject("BtnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarCliente.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(79, 41)
        Me.BtnBuscarCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(149, 41)
        Me.BtnBuscarCliente.TabIndex = 0
        Me.BtnBuscarCliente.Text = "Buscar Cliente"
        Me.BtnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblNombre.Location = New System.Drawing.Point(87, 118)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(54, 16)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtNombre.Location = New System.Drawing.Point(225, 114)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(333, 23)
        Me.TxtNombre.TabIndex = 2
        '
        'LblTarjeta
        '
        Me.LblTarjeta.AutoSize = True
        Me.LblTarjeta.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblTarjeta.Location = New System.Drawing.Point(86, 197)
        Me.LblTarjeta.Name = "LblTarjeta"
        Me.LblTarjeta.Size = New System.Drawing.Size(44, 16)
        Me.LblTarjeta.TabIndex = 3
        Me.LblTarjeta.Text = "Tarjeta"
        '
        'ComboTarjeta
        '
        Me.ComboTarjeta.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.ComboTarjeta.FormattingEnabled = True
        Me.ComboTarjeta.Location = New System.Drawing.Point(225, 190)
        Me.ComboTarjeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboTarjeta.Name = "ComboTarjeta"
        Me.ComboTarjeta.Size = New System.Drawing.Size(294, 24)
        Me.ComboTarjeta.TabIndex = 4
        '
        'LblCtaBancaria
        '
        Me.LblCtaBancaria.AutoSize = True
        Me.LblCtaBancaria.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblCtaBancaria.Location = New System.Drawing.Point(86, 242)
        Me.LblCtaBancaria.Name = "LblCtaBancaria"
        Me.LblCtaBancaria.Size = New System.Drawing.Size(99, 16)
        Me.LblCtaBancaria.TabIndex = 5
        Me.LblCtaBancaria.Text = "Cuenta Bancaria"
        '
        'ComboCtaBancaria
        '
        Me.ComboCtaBancaria.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.ComboCtaBancaria.FormattingEnabled = True
        Me.ComboCtaBancaria.Location = New System.Drawing.Point(225, 235)
        Me.ComboCtaBancaria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboCtaBancaria.Name = "ComboCtaBancaria"
        Me.ComboCtaBancaria.Size = New System.Drawing.Size(294, 24)
        Me.ComboCtaBancaria.TabIndex = 6
        '
        'LblOperacion
        '
        Me.LblOperacion.AutoSize = True
        Me.LblOperacion.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblOperacion.Location = New System.Drawing.Point(86, 284)
        Me.LblOperacion.Name = "LblOperacion"
        Me.LblOperacion.Size = New System.Drawing.Size(66, 16)
        Me.LblOperacion.TabIndex = 7
        Me.LblOperacion.Text = "Operacion"
        '
        'ComboOperacion
        '
        Me.ComboOperacion.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.ComboOperacion.FormattingEnabled = True
        Me.ComboOperacion.Location = New System.Drawing.Point(225, 279)
        Me.ComboOperacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboOperacion.Name = "ComboOperacion"
        Me.ComboOperacion.Size = New System.Drawing.Size(294, 24)
        Me.ComboOperacion.TabIndex = 8
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblMonto.Location = New System.Drawing.Point(87, 330)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(45, 16)
        Me.LblMonto.TabIndex = 9
        Me.LblMonto.Text = "Monto"
        '
        'LblCtaDestino
        '
        Me.LblCtaDestino.AutoSize = True
        Me.LblCtaDestino.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblCtaDestino.Location = New System.Drawing.Point(87, 372)
        Me.LblCtaDestino.Name = "LblCtaDestino"
        Me.LblCtaDestino.Size = New System.Drawing.Size(95, 16)
        Me.LblCtaDestino.TabIndex = 10
        Me.LblCtaDestino.Text = "Cuenta Destino"
        '
        'TxtMonto
        '
        Me.TxtMonto.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtMonto.Location = New System.Drawing.Point(225, 327)
        Me.TxtMonto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(333, 23)
        Me.TxtMonto.TabIndex = 11
        '
        'TxtCtaDestino
        '
        Me.TxtCtaDestino.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtCtaDestino.Location = New System.Drawing.Point(225, 368)
        Me.TxtCtaDestino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCtaDestino.Name = "TxtCtaDestino"
        Me.TxtCtaDestino.Size = New System.Drawing.Size(333, 23)
        Me.TxtCtaDestino.TabIndex = 12
        '
        'BtnRealizarTransaccion
        '
        Me.BtnRealizarTransaccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRealizarTransaccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRealizarTransaccion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealizarTransaccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRealizarTransaccion.Location = New System.Drawing.Point(280, 448)
        Me.BtnRealizarTransaccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRealizarTransaccion.Name = "BtnRealizarTransaccion"
        Me.BtnRealizarTransaccion.Size = New System.Drawing.Size(222, 63)
        Me.BtnRealizarTransaccion.TabIndex = 13
        Me.BtnRealizarTransaccion.Text = "Realizar Transaccion"
        Me.BtnRealizarTransaccion.UseVisualStyleBackColor = False
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblDNI.Location = New System.Drawing.Point(87, 154)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(31, 16)
        Me.LblDNI.TabIndex = 14
        Me.LblDNI.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtDNI.Location = New System.Drawing.Point(225, 149)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(333, 23)
        Me.TxtDNI.TabIndex = 15
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.LblSaldo.Location = New System.Drawing.Point(604, 219)
        Me.LblSaldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(38, 16)
        Me.LblSaldo.TabIndex = 16
        Me.LblSaldo.Text = "Saldo"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtSaldo.Location = New System.Drawing.Point(609, 261)
        Me.TxtSaldo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(116, 23)
        Me.TxtSaldo.TabIndex = 17
        '
        'FrmMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(775, 567)
        Me.Controls.Add(Me.TxtSaldo)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.BtnRealizarTransaccion)
        Me.Controls.Add(Me.TxtCtaDestino)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.LblCtaDestino)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.ComboOperacion)
        Me.Controls.Add(Me.LblOperacion)
        Me.Controls.Add(Me.ComboCtaBancaria)
        Me.Controls.Add(Me.LblCtaBancaria)
        Me.Controls.Add(Me.ComboTarjeta)
        Me.Controls.Add(Me.LblTarjeta)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMovimientos"
        Me.Text = "Movimientos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblTarjeta As Label
    Friend WithEvents ComboTarjeta As ComboBox
    Friend WithEvents LblCtaBancaria As Label
    Friend WithEvents ComboCtaBancaria As ComboBox
    Friend WithEvents LblOperacion As Label
    Friend WithEvents ComboOperacion As ComboBox
    Friend WithEvents LblMonto As Label
    Friend WithEvents LblCtaDestino As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents TxtCtaDestino As TextBox
    Friend WithEvents BtnRealizarTransaccion As Button
    Friend WithEvents LblDNI As Label
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents LblSaldo As Label
    Friend WithEvents TxtSaldo As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearCuenta))
        Me.ControlCuenta = New System.Windows.Forms.TabControl()
        Me.TabTarjetaNueva = New System.Windows.Forms.TabPage()
        Me.ComboCredito = New System.Windows.Forms.ComboBox()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.ComboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.ComboTipoTarj = New System.Windows.Forms.ComboBox()
        Me.TxtNumCuenta = New System.Windows.Forms.TextBox()
        Me.TxtNumTarj = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblNumCuenta = New System.Windows.Forms.Label()
        Me.LblTipoCuenta = New System.Windows.Forms.Label()
        Me.LblNumTarj = New System.Windows.Forms.Label()
        Me.LblTipoTarj = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAgregarCliente = New System.Windows.Forms.Button()
        Me.TabAñadirCuenta = New System.Windows.Forms.TabPage()
        Me.TxtSaldo2 = New System.Windows.Forms.TextBox()
        Me.LblSaldo2 = New System.Windows.Forms.Label()
        Me.BtnAñadirCuenta = New System.Windows.Forms.Button()
        Me.ComboTipoCuenta2 = New System.Windows.Forms.ComboBox()
        Me.LblNumCuenta2 = New System.Windows.Forms.Label()
        Me.LblTipoCuenta2 = New System.Windows.Forms.Label()
        Me.ComboNroTarjeta2 = New System.Windows.Forms.ComboBox()
        Me.TxtNumCuenta2 = New System.Windows.Forms.TextBox()
        Me.LblNumTarjeta2 = New System.Windows.Forms.Label()
        Me.LblDNI2 = New System.Windows.Forms.Label()
        Me.TxtDNI2 = New System.Windows.Forms.TextBox()
        Me.TxtNombre2 = New System.Windows.Forms.TextBox()
        Me.LblNombre2 = New System.Windows.Forms.Label()
        Me.BtnAgregarCliente2 = New System.Windows.Forms.Button()
        Me.ControlCuenta.SuspendLayout()
        Me.TabTarjetaNueva.SuspendLayout()
        Me.TabAñadirCuenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlCuenta
        '
        Me.ControlCuenta.Controls.Add(Me.TabTarjetaNueva)
        Me.ControlCuenta.Controls.Add(Me.TabAñadirCuenta)
        Me.ControlCuenta.Location = New System.Drawing.Point(38, 32)
        Me.ControlCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlCuenta.Name = "ControlCuenta"
        Me.ControlCuenta.SelectedIndex = 0
        Me.ControlCuenta.Size = New System.Drawing.Size(644, 509)
        Me.ControlCuenta.TabIndex = 0
        '
        'TabTarjetaNueva
        '
        Me.TabTarjetaNueva.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TabTarjetaNueva.BackgroundImage = CType(resources.GetObject("TabTarjetaNueva.BackgroundImage"), System.Drawing.Image)
        Me.TabTarjetaNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabTarjetaNueva.Controls.Add(Me.ComboCredito)
        Me.TabTarjetaNueva.Controls.Add(Me.TxtSaldo)
        Me.TabTarjetaNueva.Controls.Add(Me.LblSaldo)
        Me.TabTarjetaNueva.Controls.Add(Me.LblDNI)
        Me.TabTarjetaNueva.Controls.Add(Me.TxtDNI)
        Me.TabTarjetaNueva.Controls.Add(Me.ComboTipoCuenta)
        Me.TabTarjetaNueva.Controls.Add(Me.ComboTipoTarj)
        Me.TabTarjetaNueva.Controls.Add(Me.TxtNumCuenta)
        Me.TabTarjetaNueva.Controls.Add(Me.TxtNumTarj)
        Me.TabTarjetaNueva.Controls.Add(Me.TxtNombre)
        Me.TabTarjetaNueva.Controls.Add(Me.LblNumCuenta)
        Me.TabTarjetaNueva.Controls.Add(Me.LblTipoCuenta)
        Me.TabTarjetaNueva.Controls.Add(Me.LblNumTarj)
        Me.TabTarjetaNueva.Controls.Add(Me.LblTipoTarj)
        Me.TabTarjetaNueva.Controls.Add(Me.LblNombre)
        Me.TabTarjetaNueva.Controls.Add(Me.BtnGuardar)
        Me.TabTarjetaNueva.Controls.Add(Me.BtnAgregarCliente)
        Me.TabTarjetaNueva.Location = New System.Drawing.Point(4, 22)
        Me.TabTarjetaNueva.Margin = New System.Windows.Forms.Padding(2)
        Me.TabTarjetaNueva.Name = "TabTarjetaNueva"
        Me.TabTarjetaNueva.Padding = New System.Windows.Forms.Padding(2)
        Me.TabTarjetaNueva.Size = New System.Drawing.Size(636, 483)
        Me.TabTarjetaNueva.TabIndex = 0
        Me.TabTarjetaNueva.Text = "Crear Tarjeta"
        '
        'ComboCredito
        '
        Me.ComboCredito.FormattingEnabled = True
        Me.ComboCredito.Items.AddRange(New Object() {"CLASICA", "GOLDEN", "PLATINUM"})
        Me.ComboCredito.Location = New System.Drawing.Point(496, 166)
        Me.ComboCredito.Name = "ComboCredito"
        Me.ComboCredito.Size = New System.Drawing.Size(121, 21)
        Me.ComboCredito.TabIndex = 10
        Me.ComboCredito.Visible = False
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Location = New System.Drawing.Point(210, 342)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(138, 20)
        Me.TxtSaldo.TabIndex = 9
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Location = New System.Drawing.Point(52, 342)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(48, 13)
        Me.LblSaldo.TabIndex = 8
        Me.LblSaldo.Text = "SALDO"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(52, 125)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(29, 13)
        Me.LblDNI.TabIndex = 6
        Me.LblDNI.Text = "DNI"
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(210, 125)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(223, 20)
        Me.TxtDNI.TabIndex = 3
        '
        'ComboTipoCuenta
        '
        Me.ComboTipoCuenta.FormattingEnabled = True
        Me.ComboTipoCuenta.Location = New System.Drawing.Point(210, 256)
        Me.ComboTipoCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboTipoCuenta.Name = "ComboTipoCuenta"
        Me.ComboTipoCuenta.Size = New System.Drawing.Size(223, 21)
        Me.ComboTipoCuenta.TabIndex = 6
        '
        'ComboTipoTarj
        '
        Me.ComboTipoTarj.FormattingEnabled = True
        Me.ComboTipoTarj.Location = New System.Drawing.Point(210, 166)
        Me.ComboTipoTarj.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboTipoTarj.Name = "ComboTipoTarj"
        Me.ComboTipoTarj.Size = New System.Drawing.Size(223, 21)
        Me.ComboTipoTarj.TabIndex = 4
        '
        'TxtNumCuenta
        '
        Me.TxtNumCuenta.Location = New System.Drawing.Point(210, 302)
        Me.TxtNumCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumCuenta.Name = "TxtNumCuenta"
        Me.TxtNumCuenta.Size = New System.Drawing.Size(223, 20)
        Me.TxtNumCuenta.TabIndex = 7
        '
        'TxtNumTarj
        '
        Me.TxtNumTarj.Location = New System.Drawing.Point(210, 210)
        Me.TxtNumTarj.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumTarj.Name = "TxtNumTarj"
        Me.TxtNumTarj.Size = New System.Drawing.Size(223, 20)
        Me.TxtNumTarj.TabIndex = 5
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(210, 87)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(302, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'LblNumCuenta
        '
        Me.LblNumCuenta.AutoSize = True
        Me.LblNumCuenta.Location = New System.Drawing.Point(52, 302)
        Me.LblNumCuenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNumCuenta.Name = "LblNumCuenta"
        Me.LblNumCuenta.Size = New System.Drawing.Size(115, 13)
        Me.LblNumCuenta.TabIndex = 1
        Me.LblNumCuenta.Text = "NUMERO CUENTA"
        '
        'LblTipoCuenta
        '
        Me.LblTipoCuenta.AutoSize = True
        Me.LblTipoCuenta.Location = New System.Drawing.Point(52, 256)
        Me.LblTipoCuenta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipoCuenta.Name = "LblTipoCuenta"
        Me.LblTipoCuenta.Size = New System.Drawing.Size(90, 13)
        Me.LblTipoCuenta.TabIndex = 1
        Me.LblTipoCuenta.Text = "TIPO CUENTA"
        '
        'LblNumTarj
        '
        Me.LblNumTarj.AutoSize = True
        Me.LblNumTarj.Location = New System.Drawing.Point(52, 210)
        Me.LblNumTarj.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNumTarj.Name = "LblNumTarj"
        Me.LblNumTarj.Size = New System.Drawing.Size(120, 13)
        Me.LblNumTarj.TabIndex = 1
        Me.LblNumTarj.Text = "NUMERO TARJETA"
        '
        'LblTipoTarj
        '
        Me.LblTipoTarj.AutoSize = True
        Me.LblTipoTarj.Location = New System.Drawing.Point(52, 166)
        Me.LblTipoTarj.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipoTarj.Name = "LblTipoTarj"
        Me.LblTipoTarj.Size = New System.Drawing.Size(95, 13)
        Me.LblTipoTarj.TabIndex = 1
        Me.LblTipoTarj.Text = "TIPO TARJETA"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(52, 92)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(60, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "NOMBRE"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Location = New System.Drawing.Point(287, 412)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(61, 46)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnAgregarCliente
        '
        Me.BtnAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCliente.BackgroundImage = CType(resources.GetObject("BtnAgregarCliente.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarCliente.Location = New System.Drawing.Point(79, 24)
        Me.BtnAgregarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarCliente.Name = "BtnAgregarCliente"
        Me.BtnAgregarCliente.Size = New System.Drawing.Size(59, 47)
        Me.BtnAgregarCliente.TabIndex = 0
        Me.BtnAgregarCliente.UseVisualStyleBackColor = False
        '
        'TabAñadirCuenta
        '
        Me.TabAñadirCuenta.BackgroundImage = CType(resources.GetObject("TabAñadirCuenta.BackgroundImage"), System.Drawing.Image)
        Me.TabAñadirCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabAñadirCuenta.Controls.Add(Me.TxtSaldo2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblSaldo2)
        Me.TabAñadirCuenta.Controls.Add(Me.BtnAñadirCuenta)
        Me.TabAñadirCuenta.Controls.Add(Me.ComboTipoCuenta2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblNumCuenta2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblTipoCuenta2)
        Me.TabAñadirCuenta.Controls.Add(Me.ComboNroTarjeta2)
        Me.TabAñadirCuenta.Controls.Add(Me.TxtNumCuenta2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblNumTarjeta2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblDNI2)
        Me.TabAñadirCuenta.Controls.Add(Me.TxtDNI2)
        Me.TabAñadirCuenta.Controls.Add(Me.TxtNombre2)
        Me.TabAñadirCuenta.Controls.Add(Me.LblNombre2)
        Me.TabAñadirCuenta.Controls.Add(Me.BtnAgregarCliente2)
        Me.TabAñadirCuenta.Location = New System.Drawing.Point(4, 22)
        Me.TabAñadirCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.TabAñadirCuenta.Name = "TabAñadirCuenta"
        Me.TabAñadirCuenta.Padding = New System.Windows.Forms.Padding(2)
        Me.TabAñadirCuenta.Size = New System.Drawing.Size(636, 483)
        Me.TabAñadirCuenta.TabIndex = 1
        Me.TabAñadirCuenta.Text = "Añadir Cuenta"
        Me.TabAñadirCuenta.UseVisualStyleBackColor = True
        '
        'TxtSaldo2
        '
        Me.TxtSaldo2.Location = New System.Drawing.Point(218, 296)
        Me.TxtSaldo2.Name = "TxtSaldo2"
        Me.TxtSaldo2.Size = New System.Drawing.Size(123, 20)
        Me.TxtSaldo2.TabIndex = 19
        '
        'LblSaldo2
        '
        Me.LblSaldo2.AutoSize = True
        Me.LblSaldo2.Location = New System.Drawing.Point(84, 299)
        Me.LblSaldo2.Name = "LblSaldo2"
        Me.LblSaldo2.Size = New System.Drawing.Size(48, 13)
        Me.LblSaldo2.TabIndex = 18
        Me.LblSaldo2.Text = "SALDO"
        '
        'BtnAñadirCuenta
        '
        Me.BtnAñadirCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAñadirCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAñadirCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAñadirCuenta.Location = New System.Drawing.Point(229, 359)
        Me.BtnAñadirCuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAñadirCuenta.Name = "BtnAñadirCuenta"
        Me.BtnAñadirCuenta.Size = New System.Drawing.Size(184, 45)
        Me.BtnAñadirCuenta.TabIndex = 17
        Me.BtnAñadirCuenta.Text = "AÑADIR CUENTA"
        Me.BtnAñadirCuenta.UseVisualStyleBackColor = False
        '
        'ComboTipoCuenta2
        '
        Me.ComboTipoCuenta2.FormattingEnabled = True
        Me.ComboTipoCuenta2.Location = New System.Drawing.Point(218, 223)
        Me.ComboTipoCuenta2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboTipoCuenta2.Name = "ComboTipoCuenta2"
        Me.ComboTipoCuenta2.Size = New System.Drawing.Size(223, 21)
        Me.ComboTipoCuenta2.TabIndex = 16
        '
        'LblNumCuenta2
        '
        Me.LblNumCuenta2.AutoSize = True
        Me.LblNumCuenta2.Location = New System.Drawing.Point(84, 257)
        Me.LblNumCuenta2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNumCuenta2.Name = "LblNumCuenta2"
        Me.LblNumCuenta2.Size = New System.Drawing.Size(88, 13)
        Me.LblNumCuenta2.TabIndex = 15
        Me.LblNumCuenta2.Text = "NRO CUENTA"
        '
        'LblTipoCuenta2
        '
        Me.LblTipoCuenta2.AutoSize = True
        Me.LblTipoCuenta2.Location = New System.Drawing.Point(83, 222)
        Me.LblTipoCuenta2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipoCuenta2.Name = "LblTipoCuenta2"
        Me.LblTipoCuenta2.Size = New System.Drawing.Size(90, 13)
        Me.LblTipoCuenta2.TabIndex = 14
        Me.LblTipoCuenta2.Text = "TIPO CUENTA"
        '
        'ComboNroTarjeta2
        '
        Me.ComboNroTarjeta2.FormattingEnabled = True
        Me.ComboNroTarjeta2.Location = New System.Drawing.Point(217, 185)
        Me.ComboNroTarjeta2.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboNroTarjeta2.Name = "ComboNroTarjeta2"
        Me.ComboNroTarjeta2.Size = New System.Drawing.Size(222, 21)
        Me.ComboNroTarjeta2.TabIndex = 13
        '
        'TxtNumCuenta2
        '
        Me.TxtNumCuenta2.Location = New System.Drawing.Point(217, 257)
        Me.TxtNumCuenta2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumCuenta2.Name = "TxtNumCuenta2"
        Me.TxtNumCuenta2.Size = New System.Drawing.Size(226, 20)
        Me.TxtNumCuenta2.TabIndex = 12
        '
        'LblNumTarjeta2
        '
        Me.LblNumTarjeta2.AutoSize = True
        Me.LblNumTarjeta2.Location = New System.Drawing.Point(83, 188)
        Me.LblNumTarjeta2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNumTarjeta2.Name = "LblNumTarjeta2"
        Me.LblNumTarjeta2.Size = New System.Drawing.Size(94, 13)
        Me.LblNumTarjeta2.TabIndex = 11
        Me.LblNumTarjeta2.Text = "NUM TARJETA"
        '
        'LblDNI2
        '
        Me.LblDNI2.AutoSize = True
        Me.LblDNI2.Location = New System.Drawing.Point(83, 157)
        Me.LblDNI2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDNI2.Name = "LblDNI2"
        Me.LblDNI2.Size = New System.Drawing.Size(29, 13)
        Me.LblDNI2.TabIndex = 10
        Me.LblDNI2.Text = "DNI"
        '
        'TxtDNI2
        '
        Me.TxtDNI2.Location = New System.Drawing.Point(217, 154)
        Me.TxtDNI2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDNI2.Name = "TxtDNI2"
        Me.TxtDNI2.Size = New System.Drawing.Size(151, 20)
        Me.TxtDNI2.TabIndex = 9
        '
        'TxtNombre2
        '
        Me.TxtNombre2.Location = New System.Drawing.Point(217, 116)
        Me.TxtNombre2.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre2.Name = "TxtNombre2"
        Me.TxtNombre2.Size = New System.Drawing.Size(347, 20)
        Me.TxtNombre2.TabIndex = 8
        '
        'LblNombre2
        '
        Me.LblNombre2.AutoSize = True
        Me.LblNombre2.Location = New System.Drawing.Point(83, 119)
        Me.LblNombre2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre2.Name = "LblNombre2"
        Me.LblNombre2.Size = New System.Drawing.Size(60, 13)
        Me.LblNombre2.TabIndex = 7
        Me.LblNombre2.Text = "NOMBRE"
        '
        'BtnAgregarCliente2
        '
        Me.BtnAgregarCliente2.BackgroundImage = CType(resources.GetObject("BtnAgregarCliente2.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarCliente2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAgregarCliente2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarCliente2.Location = New System.Drawing.Point(83, 47)
        Me.BtnAgregarCliente2.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarCliente2.Name = "BtnAgregarCliente2"
        Me.BtnAgregarCliente2.Size = New System.Drawing.Size(63, 45)
        Me.BtnAgregarCliente2.TabIndex = 1
        Me.BtnAgregarCliente2.UseVisualStyleBackColor = True
        '
        'FrmCrearCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(723, 567)
        Me.Controls.Add(Me.ControlCuenta)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCrearCuenta"
        Me.Text = "Crear Cuenta"
        Me.ControlCuenta.ResumeLayout(False)
        Me.TabTarjetaNueva.ResumeLayout(False)
        Me.TabTarjetaNueva.PerformLayout()
        Me.TabAñadirCuenta.ResumeLayout(False)
        Me.TabAñadirCuenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlCuenta As TabControl
    Friend WithEvents TabTarjetaNueva As TabPage
    Friend WithEvents ComboTipoTarj As ComboBox
    Friend WithEvents TxtNumCuenta As TextBox
    Friend WithEvents TxtNumTarj As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNumCuenta As Label
    Friend WithEvents LblTipoCuenta As Label
    Friend WithEvents LblNumTarj As Label
    Friend WithEvents LblTipoTarj As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAgregarCliente As Button
    Friend WithEvents TabAñadirCuenta As TabPage
    Friend WithEvents ComboTipoCuenta As ComboBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents BtnAgregarCliente2 As Button
    Friend WithEvents LblDNI2 As Label
    Friend WithEvents TxtDNI2 As TextBox
    Friend WithEvents TxtNombre2 As TextBox
    Friend WithEvents LblNombre2 As Label
    Friend WithEvents BtnAñadirCuenta As Button
    Friend WithEvents ComboTipoCuenta2 As ComboBox
    Friend WithEvents LblNumCuenta2 As Label
    Friend WithEvents LblTipoCuenta2 As Label
    Friend WithEvents ComboNroTarjeta2 As ComboBox
    Friend WithEvents TxtNumCuenta2 As TextBox
    Friend WithEvents LblNumTarjeta2 As Label
    Friend WithEvents ComboCredito As ComboBox
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents LblSaldo As Label
    Friend WithEvents TxtSaldo2 As TextBox
    Friend WithEvents LblSaldo2 As Label
End Class

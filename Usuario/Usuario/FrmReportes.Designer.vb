<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportes))
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.ComboBoxCtaBancaria = New System.Windows.Forms.ComboBox()
        Me.FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxCtaBancaria = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFecha = New System.Windows.Forms.CheckBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.DataGridVReportes = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBoxMes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAño = New System.Windows.Forms.CheckBox()
        Me.MesPicker = New System.Windows.Forms.DateTimePicker()
        Me.AnoPicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridVReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDNI
        '
        Me.TxtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.TxtDNI.Location = New System.Drawing.Point(300, 85)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(312, 26)
        Me.TxtDNI.TabIndex = 0
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDNI.Location = New System.Drawing.Point(83, 89)
        Me.LblDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(45, 25)
        Me.LblDNI.TabIndex = 1
        Me.LblDNI.Text = "DNI"
        '
        'ComboBoxCtaBancaria
        '
        Me.ComboBoxCtaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.ComboBoxCtaBancaria.FormattingEnabled = True
        Me.ComboBoxCtaBancaria.Location = New System.Drawing.Point(300, 149)
        Me.ComboBoxCtaBancaria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxCtaBancaria.Name = "ComboBoxCtaBancaria"
        Me.ComboBoxCtaBancaria.Size = New System.Drawing.Size(484, 28)
        Me.ComboBoxCtaBancaria.TabIndex = 2
        '
        'FechaInicial
        '
        Me.FechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.FechaInicial.Location = New System.Drawing.Point(300, 213)
        Me.FechaInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Size = New System.Drawing.Size(200, 26)
        Me.FechaInicial.TabIndex = 4
        Me.FechaInicial.Value = New Date(2019, 12, 10, 0, 0, 0, 0)
        '
        'FechaFin
        '
        Me.FechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.FechaFin.Location = New System.Drawing.Point(587, 213)
        Me.FechaFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(197, 26)
        Me.FechaFin.TabIndex = 5
        '
        'CheckBoxCtaBancaria
        '
        Me.CheckBoxCtaBancaria.AutoSize = True
        Me.CheckBoxCtaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.CheckBoxCtaBancaria.Location = New System.Drawing.Point(88, 153)
        Me.CheckBoxCtaBancaria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxCtaBancaria.Name = "CheckBoxCtaBancaria"
        Me.CheckBoxCtaBancaria.Size = New System.Drawing.Size(156, 24)
        Me.CheckBoxCtaBancaria.TabIndex = 1
        Me.CheckBoxCtaBancaria.Text = "Cuenta Bancaria"
        Me.CheckBoxCtaBancaria.UseVisualStyleBackColor = True
        '
        'CheckBoxFecha
        '
        Me.CheckBoxFecha.AutoSize = True
        Me.CheckBoxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.CheckBoxFecha.Location = New System.Drawing.Point(88, 213)
        Me.CheckBoxFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxFecha.Name = "CheckBoxFecha"
        Me.CheckBoxFecha.Size = New System.Drawing.Size(153, 24)
        Me.CheckBoxFecha.TabIndex = 3
        Me.CheckBoxFecha.Text = "Rango de Fecha"
        Me.CheckBoxFecha.UseVisualStyleBackColor = True
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGenerar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnGenerar.Location = New System.Drawing.Point(359, 423)
        Me.BtnGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(148, 39)
        Me.BtnGenerar.TabIndex = 6
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'DataGridVReportes
        '
        Me.DataGridVReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridVReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVReportes.Location = New System.Drawing.Point(91, 486)
        Me.DataGridVReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridVReportes.Name = "DataGridVReportes"
        Me.DataGridVReportes.Size = New System.Drawing.Size(684, 228)
        Me.DataGridVReportes.TabIndex = 12
        '
        'CheckBoxMes
        '
        Me.CheckBoxMes.AutoSize = True
        Me.CheckBoxMes.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMes.Location = New System.Drawing.Point(87, 332)
        Me.CheckBoxMes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxMes.Name = "CheckBoxMes"
        Me.CheckBoxMes.Size = New System.Drawing.Size(67, 27)
        Me.CheckBoxMes.TabIndex = 13
        Me.CheckBoxMes.Text = "Mes"
        Me.CheckBoxMes.UseVisualStyleBackColor = True
        '
        'CheckBoxAño
        '
        Me.CheckBoxAño.AutoSize = True
        Me.CheckBoxAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.CheckBoxAño.Location = New System.Drawing.Point(88, 276)
        Me.CheckBoxAño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxAño.Name = "CheckBoxAño"
        Me.CheckBoxAño.Size = New System.Drawing.Size(60, 24)
        Me.CheckBoxAño.TabIndex = 14
        Me.CheckBoxAño.Text = "Año"
        Me.CheckBoxAño.UseVisualStyleBackColor = True
        '
        'MesPicker
        '
        Me.MesPicker.CustomFormat = "MM"
        Me.MesPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MesPicker.Location = New System.Drawing.Point(299, 331)
        Me.MesPicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MesPicker.Name = "MesPicker"
        Me.MesPicker.Size = New System.Drawing.Size(265, 22)
        Me.MesPicker.TabIndex = 17
        '
        'AnoPicker
        '
        Me.AnoPicker.CustomFormat = "yyyy"
        Me.AnoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AnoPicker.Location = New System.Drawing.Point(299, 279)
        Me.AnoPicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AnoPicker.Name = "AnoPicker"
        Me.AnoPicker.Size = New System.Drawing.Size(265, 22)
        Me.AnoPicker.TabIndex = 18
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(866, 729)
        Me.Controls.Add(Me.AnoPicker)
        Me.Controls.Add(Me.MesPicker)
        Me.Controls.Add(Me.CheckBoxAño)
        Me.Controls.Add(Me.CheckBoxMes)
        Me.Controls.Add(Me.DataGridVReportes)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.CheckBoxFecha)
        Me.Controls.Add(Me.CheckBoxCtaBancaria)
        Me.Controls.Add(Me.FechaFin)
        Me.Controls.Add(Me.FechaInicial)
        Me.Controls.Add(Me.ComboBoxCtaBancaria)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.TxtDNI)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmReportes"
        Me.Text = "Reportes"
        CType(Me.DataGridVReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents LblDNI As Label
    Friend WithEvents ComboBoxCtaBancaria As ComboBox
    Friend WithEvents FechaInicial As DateTimePicker
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents CheckBoxCtaBancaria As CheckBox
    Friend WithEvents CheckBoxFecha As CheckBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents DataGridVReportes As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents CheckBoxMes As CheckBox
    Friend WithEvents CheckBoxAño As CheckBox
    Friend WithEvents MesPicker As DateTimePicker
    Friend WithEvents AnoPicker As DateTimePicker
End Class

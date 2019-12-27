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
        Me.TxtDNI.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.TxtDNI.Location = New System.Drawing.Point(249, 69)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(235, 23)
        Me.TxtDNI.TabIndex = 0
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Font = New System.Drawing.Font("Lato Thin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDNI.Location = New System.Drawing.Point(86, 72)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(37, 19)
        Me.LblDNI.TabIndex = 1
        Me.LblDNI.Text = "DNI"
        '
        'ComboBoxCtaBancaria
        '
        Me.ComboBoxCtaBancaria.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.ComboBoxCtaBancaria.FormattingEnabled = True
        Me.ComboBoxCtaBancaria.Location = New System.Drawing.Point(249, 121)
        Me.ComboBoxCtaBancaria.Name = "ComboBoxCtaBancaria"
        Me.ComboBoxCtaBancaria.Size = New System.Drawing.Size(574, 24)
        Me.ComboBoxCtaBancaria.TabIndex = 2
        '
        'FechaInicial
        '
        Me.FechaInicial.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.FechaInicial.Location = New System.Drawing.Point(249, 173)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Size = New System.Drawing.Size(151, 23)
        Me.FechaInicial.TabIndex = 4
        Me.FechaInicial.Value = New Date(2019, 12, 10, 0, 0, 0, 0)
        '
        'FechaFin
        '
        Me.FechaFin.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.FechaFin.Location = New System.Drawing.Point(464, 173)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(149, 23)
        Me.FechaFin.TabIndex = 5
        '
        'CheckBoxCtaBancaria
        '
        Me.CheckBoxCtaBancaria.AutoSize = True
        Me.CheckBoxCtaBancaria.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.CheckBoxCtaBancaria.Location = New System.Drawing.Point(90, 124)
        Me.CheckBoxCtaBancaria.Name = "CheckBoxCtaBancaria"
        Me.CheckBoxCtaBancaria.Size = New System.Drawing.Size(118, 20)
        Me.CheckBoxCtaBancaria.TabIndex = 1
        Me.CheckBoxCtaBancaria.Text = "Cuenta Bancaria"
        Me.CheckBoxCtaBancaria.UseVisualStyleBackColor = True
        '
        'CheckBoxFecha
        '
        Me.CheckBoxFecha.AutoSize = True
        Me.CheckBoxFecha.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.CheckBoxFecha.Location = New System.Drawing.Point(90, 173)
        Me.CheckBoxFecha.Name = "CheckBoxFecha"
        Me.CheckBoxFecha.Size = New System.Drawing.Size(116, 20)
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
        Me.BtnGenerar.Location = New System.Drawing.Point(301, 344)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(111, 32)
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
        Me.DataGridVReportes.Location = New System.Drawing.Point(47, 395)
        Me.DataGridVReportes.Name = "DataGridVReportes"
        Me.DataGridVReportes.Size = New System.Drawing.Size(734, 185)
        Me.DataGridVReportes.TabIndex = 12
        '
        'CheckBoxMes
        '
        Me.CheckBoxMes.AutoSize = True
        Me.CheckBoxMes.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMes.Location = New System.Drawing.Point(89, 270)
        Me.CheckBoxMes.Name = "CheckBoxMes"
        Me.CheckBoxMes.Size = New System.Drawing.Size(54, 23)
        Me.CheckBoxMes.TabIndex = 13
        Me.CheckBoxMes.Text = "Mes"
        Me.CheckBoxMes.UseVisualStyleBackColor = True
        '
        'CheckBoxAño
        '
        Me.CheckBoxAño.AutoSize = True
        Me.CheckBoxAño.Font = New System.Drawing.Font("Lato Thin", 9.749999!)
        Me.CheckBoxAño.Location = New System.Drawing.Point(90, 224)
        Me.CheckBoxAño.Name = "CheckBoxAño"
        Me.CheckBoxAño.Size = New System.Drawing.Size(49, 20)
        Me.CheckBoxAño.TabIndex = 14
        Me.CheckBoxAño.Text = "Año"
        Me.CheckBoxAño.UseVisualStyleBackColor = True
        '
        'MesPicker
        '
        Me.MesPicker.CustomFormat = "MM"
        Me.MesPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MesPicker.Location = New System.Drawing.Point(248, 269)
        Me.MesPicker.Name = "MesPicker"
        Me.MesPicker.Size = New System.Drawing.Size(200, 20)
        Me.MesPicker.TabIndex = 17
        '
        'AnoPicker
        '
        Me.AnoPicker.CustomFormat = "yyyy"
        Me.AnoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AnoPicker.Location = New System.Drawing.Point(248, 227)
        Me.AnoPicker.Name = "AnoPicker"
        Me.AnoPicker.Size = New System.Drawing.Size(200, 20)
        Me.AnoPicker.TabIndex = 18
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 592)
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

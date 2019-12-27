<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnMovimientos = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnCuentas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnDetalles = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.Yellow
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(43, 244)
        Me.BtnClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(165, 48)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "◀ Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnMovimientos
        '
        Me.BtnMovimientos.BackColor = System.Drawing.Color.Yellow
        Me.BtnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMovimientos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMovimientos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnMovimientos.Location = New System.Drawing.Point(537, 244)
        Me.BtnMovimientos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMovimientos.Name = "BtnMovimientos"
        Me.BtnMovimientos.Size = New System.Drawing.Size(165, 48)
        Me.BtnMovimientos.TabIndex = 2
        Me.BtnMovimientos.Text = "Movimientos ▶"
        Me.BtnMovimientos.UseVisualStyleBackColor = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(521, 33)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(111, 17)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre Usuario"
        '
        'BtnReportes
        '
        Me.BtnReportes.BackColor = System.Drawing.Color.Yellow
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.Location = New System.Drawing.Point(537, 363)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(165, 48)
        Me.BtnReportes.TabIndex = 3
        Me.BtnReportes.Text = "Reportes ▶"
        Me.BtnReportes.UseVisualStyleBackColor = False
        '
        'BtnCuentas
        '
        Me.BtnCuentas.BackColor = System.Drawing.Color.Yellow
        Me.BtnCuentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCuentas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuentas.Location = New System.Drawing.Point(43, 363)
        Me.BtnCuentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCuentas.Name = "BtnCuentas"
        Me.BtnCuentas.Size = New System.Drawing.Size(165, 48)
        Me.BtnCuentas.TabIndex = 1
        Me.BtnCuentas.Text = "◀ Cuentas"
        Me.BtnCuentas.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 68)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(228, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Seleccione una Opción :"
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Image = CType(resources.GetObject("LblUsuario.Image"), System.Drawing.Image)
        Me.LblUsuario.Location = New System.Drawing.Point(673, 11)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(56, 59)
        Me.LblUsuario.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 210)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnDetalles
        '
        Me.BtnDetalles.BackColor = System.Drawing.Color.Yellow
        Me.BtnDetalles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDetalles.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.BtnDetalles.Location = New System.Drawing.Point(290, 455)
        Me.BtnDetalles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDetalles.Name = "BtnDetalles"
        Me.BtnDetalles.Size = New System.Drawing.Size(165, 48)
        Me.BtnDetalles.TabIndex = 8
        Me.BtnDetalles.Text = "Detalles ▶"
        Me.BtnDetalles.UseVisualStyleBackColor = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(745, 535)
        Me.Controls.Add(Me.BtnDetalles)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCuentas)
        Me.Controls.Add(Me.BtnReportes)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnMovimientos)
        Me.Controls.Add(Me.BtnClientes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPrincipal"
        Me.Text = "Menú Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnMovimientos As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnCuentas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnDetalles As Button
End Class

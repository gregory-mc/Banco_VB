<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetalles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetalles))
        Me.DataGridVDetalles = New System.Windows.Forms.DataGridView()
        Me.LblDetalles = New System.Windows.Forms.Label()
        Me.TxtDNICliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridVDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridVDetalles
        '
        Me.DataGridVDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridVDetalles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridVDetalles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Leelawadee UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVDetalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVDetalles.Location = New System.Drawing.Point(26, 120)
        Me.DataGridVDetalles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridVDetalles.Name = "DataGridVDetalles"
        Me.DataGridVDetalles.ReadOnly = True
        Me.DataGridVDetalles.RowTemplate.Height = 24
        Me.DataGridVDetalles.Size = New System.Drawing.Size(730, 277)
        Me.DataGridVDetalles.TabIndex = 0
        '
        'LblDetalles
        '
        Me.LblDetalles.AutoSize = True
        Me.LblDetalles.BackColor = System.Drawing.Color.Transparent
        Me.LblDetalles.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetalles.Location = New System.Drawing.Point(327, 19)
        Me.LblDetalles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDetalles.Name = "LblDetalles"
        Me.LblDetalles.Size = New System.Drawing.Size(141, 37)
        Me.LblDetalles.TabIndex = 1
        Me.LblDetalles.Text = "Detalles"
        '
        'TxtDNICliente
        '
        Me.TxtDNICliente.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDNICliente.Location = New System.Drawing.Point(124, 84)
        Me.TxtDNICliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDNICliente.MaxLength = 8
        Me.TxtDNICliente.Name = "TxtDNICliente"
        Me.TxtDNICliente.Size = New System.Drawing.Size(114, 26)
        Me.TxtDNICliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inserte DNI:"
        '
        'FrmDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 419)
        Me.Controls.Add(Me.TxtDNICliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDetalles)
        Me.Controls.Add(Me.DataGridVDetalles)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmDetalles"
        Me.Text = "Detalles"
        CType(Me.DataGridVDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridVDetalles As DataGridView
    Friend WithEvents LblDetalles As Label
    Friend WithEvents TxtDNICliente As TextBox
    Friend WithEvents Label1 As Label
End Class

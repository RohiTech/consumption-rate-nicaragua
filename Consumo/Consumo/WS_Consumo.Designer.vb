<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsumoServicioWS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdtipocambio = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTc = New System.Windows.Forms.TextBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.rbtCTabla = New System.Windows.Forms.RadioButton()
        Me.rbtCSencillo = New System.Windows.Forms.RadioButton()
        Me.cmdServicio = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdtipocambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdtipocambio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 319)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabla de tipo de cambios"
        '
        'grdtipocambio
        '
        Me.grdtipocambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdtipocambio.Location = New System.Drawing.Point(12, 32)
        Me.grdtipocambio.Name = "grdtipocambio"
        Me.grdtipocambio.Size = New System.Drawing.Size(792, 244)
        Me.grdtipocambio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Tipo de Cambio:"
        '
        'txtTc
        '
        Me.txtTc.Location = New System.Drawing.Point(110, 37)
        Me.txtTc.Name = "txtTc"
        Me.txtTc.Size = New System.Drawing.Size(90, 20)
        Me.txtTc.TabIndex = 10
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(348, 12)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 9
        '
        'rbtCTabla
        '
        Me.rbtCTabla.AutoSize = True
        Me.rbtCTabla.Location = New System.Drawing.Point(183, 12)
        Me.rbtCTabla.Name = "rbtCTabla"
        Me.rbtCTabla.Size = New System.Drawing.Size(99, 17)
        Me.rbtCTabla.TabIndex = 8
        Me.rbtCTabla.TabStop = True
        Me.rbtCTabla.Text = "Consumo Tabla"
        Me.rbtCTabla.UseVisualStyleBackColor = True
        '
        'rbtCSencillo
        '
        Me.rbtCSencillo.AutoSize = True
        Me.rbtCSencillo.Location = New System.Drawing.Point(23, 12)
        Me.rbtCSencillo.Name = "rbtCSencillo"
        Me.rbtCSencillo.Size = New System.Drawing.Size(109, 17)
        Me.rbtCSencillo.TabIndex = 7
        Me.rbtCSencillo.TabStop = True
        Me.rbtCSencillo.Text = "Consumo Sencillo"
        Me.rbtCSencillo.UseVisualStyleBackColor = True
        '
        'cmdServicio
        '
        Me.cmdServicio.BackColor = System.Drawing.Color.Salmon
        Me.cmdServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServicio.Location = New System.Drawing.Point(471, 8)
        Me.cmdServicio.Name = "cmdServicio"
        Me.cmdServicio.Size = New System.Drawing.Size(207, 45)
        Me.cmdServicio.TabIndex = 13
        Me.cmdServicio.Text = "&Consumir Servicio"
        Me.cmdServicio.UseVisualStyleBackColor = False
        '
        'frmConsumoServicioWS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTc)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.rbtCTabla)
        Me.Controls.Add(Me.rbtCSencillo)
        Me.Controls.Add(Me.cmdServicio)
        Me.Name = "frmConsumoServicioWS"
        Me.Text = "Consumo de Servicios "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdtipocambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdtipocambio As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTc As TextBox
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents rbtCTabla As RadioButton
    Friend WithEvents rbtCSencillo As RadioButton
    Friend WithEvents cmdServicio As Button
End Class

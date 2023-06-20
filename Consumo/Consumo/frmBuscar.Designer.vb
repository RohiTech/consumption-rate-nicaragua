<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Me.cmdSeleccion = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.lblComodin_Caracter = New System.Windows.Forms.Label()
        Me.lblComodin_Caracteres = New System.Windows.Forms.Label()
        Me.lblBuscarEn = New System.Windows.Forms.Label()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.cmbCampo = New System.Windows.Forms.ComboBox()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.lvw = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'cmdSeleccion
        '
        Me.cmdSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.cmdSeleccion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSeleccion.Location = New System.Drawing.Point(91, 227)
        Me.cmdSeleccion.Name = "cmdSeleccion"
        Me.cmdSeleccion.Size = New System.Drawing.Size(67, 28)
        Me.cmdSeleccion.TabIndex = 21
        Me.cmdSeleccion.Text = "&Selección"
        Me.cmdSeleccion.UseVisualStyleBackColor = False
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.Color.Transparent
        Me.cmdBuscar.Location = New System.Drawing.Point(18, 226)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(67, 28)
        Me.cmdBuscar.TabIndex = 20
        Me.cmdBuscar.Text = "&Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'lblComodin_Caracter
        '
        Me.lblComodin_Caracter.BackColor = System.Drawing.Color.Transparent
        Me.lblComodin_Caracter.ForeColor = System.Drawing.Color.Transparent
        Me.lblComodin_Caracter.Location = New System.Drawing.Point(41, 154)
        Me.lblComodin_Caracter.Name = "lblComodin_Caracter"
        Me.lblComodin_Caracter.Size = New System.Drawing.Size(120, 34)
        Me.lblComodin_Caracter.TabIndex = 19
        Me.lblComodin_Caracter.Text = "(_) comodín de un caracter."
        '
        'lblComodin_Caracteres
        '
        Me.lblComodin_Caracteres.BackColor = System.Drawing.Color.Transparent
        Me.lblComodin_Caracteres.ForeColor = System.Drawing.Color.Transparent
        Me.lblComodin_Caracteres.Location = New System.Drawing.Point(44, 120)
        Me.lblComodin_Caracteres.Name = "lblComodin_Caracteres"
        Me.lblComodin_Caracteres.Size = New System.Drawing.Size(120, 34)
        Me.lblComodin_Caracteres.TabIndex = 18
        Me.lblComodin_Caracteres.Text = "(%) comodín de muchos caracteres."
        '
        'lblBuscarEn
        '
        Me.lblBuscarEn.AutoSize = True
        Me.lblBuscarEn.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscarEn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEn.ForeColor = System.Drawing.Color.Transparent
        Me.lblBuscarEn.Location = New System.Drawing.Point(27, 78)
        Me.lblBuscarEn.Name = "lblBuscarEn"
        Me.lblBuscarEn.Size = New System.Drawing.Size(58, 13)
        Me.lblBuscarEn.TabIndex = 17
        Me.lblBuscarEn.Text = "Buscar en:"
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.BackColor = System.Drawing.Color.Transparent
        Me.lblTexto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.ForeColor = System.Drawing.Color.Transparent
        Me.lblTexto.Location = New System.Drawing.Point(24, 38)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(70, 13)
        Me.lblTexto.TabIndex = 16
        Me.lblTexto.Text = "Con el texto:"
        '
        'TxtValor
        '
        Me.TxtValor.ForeColor = System.Drawing.SystemColors.GrayText
        Me.TxtValor.Location = New System.Drawing.Point(27, 54)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(134, 20)
        Me.TxtValor.TabIndex = 12
        Me.TxtValor.Text = "Buscar elemento..."
        '
        'cmbCampo
        '
        Me.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCampo.FormattingEnabled = True
        Me.cmbCampo.Location = New System.Drawing.Point(27, 95)
        Me.cmbCampo.Name = "cmbCampo"
        Me.cmbCampo.Size = New System.Drawing.Size(134, 21)
        Me.cmbCampo.TabIndex = 13
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqueda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.ForeColor = System.Drawing.Color.Transparent
        Me.lblBusqueda.Location = New System.Drawing.Point(27, 9)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(125, 18)
        Me.lblBusqueda.TabIndex = 15
        Me.lblBusqueda.Text = "Búsqueda de registro"
        Me.lblBusqueda.UseCompatibleTextRendering = True
        '
        'lvw
        '
        Me.lvw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvw.BackColor = System.Drawing.Color.GhostWhite
        Me.lvw.BackgroundImageTiled = True
        Me.lvw.FullRowSelect = True
        Me.lvw.GridLines = True
        Me.lvw.HideSelection = False
        Me.lvw.LabelWrap = False
        Me.lvw.Location = New System.Drawing.Point(170, 12)
        Me.lvw.Name = "lvw"
        Me.lvw.Size = New System.Drawing.Size(618, 293)
        Me.lvw.TabIndex = 14
        Me.lvw.UseCompatibleStateImageBehavior = False
        Me.lvw.View = System.Windows.Forms.View.Details
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdSeleccion)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.lblComodin_Caracter)
        Me.Controls.Add(Me.lblComodin_Caracteres)
        Me.Controls.Add(Me.lblBuscarEn)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.cmbCampo)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.lvw)
        Me.Name = "frmBuscar"
        Me.Text = "Buscar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSeleccion As Button
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents lblComodin_Caracter As Label
    Friend WithEvents lblComodin_Caracteres As Label
    Friend WithEvents lblBuscarEn As Label
    Friend WithEvents lblTexto As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents cmbCampo As ComboBox
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents lvw As ListView
End Class

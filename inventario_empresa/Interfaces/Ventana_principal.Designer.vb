<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarMarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarFormatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarTrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarSedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarTrabajadoresReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerdidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPerdidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarTipoDePerdidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panel_hijo = New System.Windows.Forms.Panel()
        Me.AdministrarPerdidasDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.TrabajadoresToolStripMenuItem, Me.SedesToolStripMenuItem, Me.PerdidasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1503, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarProductosToolStripMenuItem, Me.CrearCategoriaToolStripMenuItem, Me.AdministrarMarcasToolStripMenuItem, Me.AdministrarFormatosToolStripMenuItem, Me.EntregaDeProductosToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(120, 27)
        Me.CategoriasToolStripMenuItem.Text = "Productos"
        '
        'AdministrarProductosToolStripMenuItem
        '
        Me.AdministrarProductosToolStripMenuItem.Name = "AdministrarProductosToolStripMenuItem"
        Me.AdministrarProductosToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.AdministrarProductosToolStripMenuItem.Text = "Administrar productos"
        '
        'CrearCategoriaToolStripMenuItem
        '
        Me.CrearCategoriaToolStripMenuItem.Name = "CrearCategoriaToolStripMenuItem"
        Me.CrearCategoriaToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.CrearCategoriaToolStripMenuItem.Text = "Administrar categorias"
        '
        'AdministrarMarcasToolStripMenuItem
        '
        Me.AdministrarMarcasToolStripMenuItem.Name = "AdministrarMarcasToolStripMenuItem"
        Me.AdministrarMarcasToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.AdministrarMarcasToolStripMenuItem.Text = "Administrar marcas"
        '
        'AdministrarFormatosToolStripMenuItem
        '
        Me.AdministrarFormatosToolStripMenuItem.Name = "AdministrarFormatosToolStripMenuItem"
        Me.AdministrarFormatosToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.AdministrarFormatosToolStripMenuItem.Text = "Administrar formatos"
        '
        'EntregaDeProductosToolStripMenuItem
        '
        Me.EntregaDeProductosToolStripMenuItem.Name = "EntregaDeProductosToolStripMenuItem"
        Me.EntregaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.EntregaDeProductosToolStripMenuItem.Text = "Entrega de productos"
        '
        'TrabajadoresToolStripMenuItem
        '
        Me.TrabajadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarTrabajadoresToolStripMenuItem})
        Me.TrabajadoresToolStripMenuItem.Name = "TrabajadoresToolStripMenuItem"
        Me.TrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(149, 27)
        Me.TrabajadoresToolStripMenuItem.Text = "Trabajadores"
        '
        'AdministrarTrabajadoresToolStripMenuItem
        '
        Me.AdministrarTrabajadoresToolStripMenuItem.Name = "AdministrarTrabajadoresToolStripMenuItem"
        Me.AdministrarTrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.AdministrarTrabajadoresToolStripMenuItem.Text = "Administrar trabajadores"
        '
        'SedesToolStripMenuItem
        '
        Me.SedesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarSedesToolStripMenuItem, Me.ProdToolStripMenuItem, Me.AdministrarTrabajadoresReToolStripMenuItem})
        Me.SedesToolStripMenuItem.Name = "SedesToolStripMenuItem"
        Me.SedesToolStripMenuItem.Size = New System.Drawing.Size(80, 27)
        Me.SedesToolStripMenuItem.Text = "Sedes"
        '
        'AdministrarSedesToolStripMenuItem
        '
        Me.AdministrarSedesToolStripMenuItem.Name = "AdministrarSedesToolStripMenuItem"
        Me.AdministrarSedesToolStripMenuItem.Size = New System.Drawing.Size(436, 28)
        Me.AdministrarSedesToolStripMenuItem.Text = "Administrar sedes"
        '
        'ProdToolStripMenuItem
        '
        Me.ProdToolStripMenuItem.Name = "ProdToolStripMenuItem"
        Me.ProdToolStripMenuItem.Size = New System.Drawing.Size(436, 28)
        Me.ProdToolStripMenuItem.Text = "Administrar productos registrados"
        '
        'AdministrarTrabajadoresReToolStripMenuItem
        '
        Me.AdministrarTrabajadoresReToolStripMenuItem.Name = "AdministrarTrabajadoresReToolStripMenuItem"
        Me.AdministrarTrabajadoresReToolStripMenuItem.Size = New System.Drawing.Size(436, 28)
        Me.AdministrarTrabajadoresReToolStripMenuItem.Text = "Administrar trabajadores registrados"
        '
        'PerdidasToolStripMenuItem
        '
        Me.PerdidasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarPerdidasToolStripMenuItem, Me.AdministrarTipoDePerdidaToolStripMenuItem, Me.AdministrarPerdidasDeProductosToolStripMenuItem})
        Me.PerdidasToolStripMenuItem.Name = "PerdidasToolStripMenuItem"
        Me.PerdidasToolStripMenuItem.Size = New System.Drawing.Size(106, 27)
        Me.PerdidasToolStripMenuItem.Text = "Perdidas"
        '
        'AdministrarPerdidasToolStripMenuItem
        '
        Me.AdministrarPerdidasToolStripMenuItem.Name = "AdministrarPerdidasToolStripMenuItem"
        Me.AdministrarPerdidasToolStripMenuItem.Size = New System.Drawing.Size(424, 28)
        Me.AdministrarPerdidasToolStripMenuItem.Text = "Administrar perdidas"
        '
        'AdministrarTipoDePerdidaToolStripMenuItem
        '
        Me.AdministrarTipoDePerdidaToolStripMenuItem.Name = "AdministrarTipoDePerdidaToolStripMenuItem"
        Me.AdministrarTipoDePerdidaToolStripMenuItem.Size = New System.Drawing.Size(424, 28)
        Me.AdministrarTipoDePerdidaToolStripMenuItem.Text = "Administrar tipo de perdida"
        '
        'panel_hijo
        '
        Me.panel_hijo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel_hijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hijo.Location = New System.Drawing.Point(0, 31)
        Me.panel_hijo.Name = "panel_hijo"
        Me.panel_hijo.Size = New System.Drawing.Size(1503, 884)
        Me.panel_hijo.TabIndex = 1
        '
        'AdministrarPerdidasDeProductosToolStripMenuItem
        '
        Me.AdministrarPerdidasDeProductosToolStripMenuItem.Name = "AdministrarPerdidasDeProductosToolStripMenuItem"
        Me.AdministrarPerdidasDeProductosToolStripMenuItem.Size = New System.Drawing.Size(424, 28)
        Me.AdministrarPerdidasDeProductosToolStripMenuItem.Text = "Administrar perdidas de productos"
        '
        'Ventana_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 915)
        Me.Controls.Add(Me.panel_hijo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventana_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana_principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarMarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarFormatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_hijo As Panel
    Friend WithEvents TrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarTrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SedesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarSedesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerdidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarPerdidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarTrabajadoresReToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarTipoDePerdidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarPerdidasDeProductosToolStripMenuItem As ToolStripMenuItem
End Class

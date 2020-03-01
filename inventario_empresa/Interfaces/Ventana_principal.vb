Public Class Ventana_principal

    Private currentform As Form = Nothing
    Private Sub abrirpanelhijo(childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        panel_hijo.Controls.Add(childform)
        panel_hijo.Tag = childform
        childform.BringToFront()
        childform.Show()

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click

    End Sub

    Private Sub Ventana_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As Form = New Ventana_principal
        ventana.AutoSize = False

    End Sub

    Private Sub AdministrarMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarMarcasToolStripMenuItem.Click
        abrirpanelhijo(New administrar_marca())
    End Sub

    Private Sub AdministrarFormatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarFormatosToolStripMenuItem.Click
        abrirpanelhijo(New administrar_formato())
    End Sub

    Private Sub CrearCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCategoriaToolStripMenuItem.Click
        abrirpanelhijo(New administrar_categoria())
    End Sub

    Private Sub AdministrarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarProductosToolStripMenuItem.Click
        abrirpanelhijo(New administrar_producto())
    End Sub

    Private Sub AdministrarTrabajadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarTrabajadoresToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_trabajadores())
    End Sub

    Private Sub AdministrarSedesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarSedesToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_sedes())
    End Sub

    Private Sub EntregaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaDeProductosToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_salida_productos())
    End Sub

    Private Sub ProdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_sede_producto())
    End Sub

    Private Sub AdministrarTrabajadoresReToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarTrabajadoresReToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_trabajador_sede())
    End Sub

    Private Sub AdministrarTipoDePerdidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarTipoDePerdidaToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_tipo_perdida())
    End Sub

    Private Sub AdministrarPerdidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarPerdidasToolStripMenuItem.Click
        abrirpanelhijo(New Administrar_perdidas())
    End Sub

    Private Sub AdministrarPerdidasDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarPerdidasDeProductosToolStripMenuItem.Click

    End Sub
End Class
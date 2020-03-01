Public Class Crear_sede_producto
    Private Sub Crear_sede_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsproductos.Reset()
        consulta_productos()
        dgvproducto.DataSource = dvproductos

        dssedes.Reset()
        consulta_sedes()
        dgvsede.DataSource = dvsedes
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datos As New sede_producto
        Dim sentencia As New Sentencias_sedeproducto

        Dim idsede As String = dgvsede.Rows(dgvsede.CurrentRow.Index).Cells(0).Value.ToString
        Dim idproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(idsede)) Then
            MessageBox.Show("Debe rellenar todos los datos para registrar un producto")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase


            datos.Id_sede_pro1 = idsede
            datos.Id_producto_se1 = idproducto
            datos.Cantidad_producto1 = txtcantidad.Text


            If sentencia.Creacion_sedeproducto(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
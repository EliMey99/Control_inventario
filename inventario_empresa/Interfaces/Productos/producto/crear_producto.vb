Public Class crear_producto

    Private Sub crear_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'obteniendo datos de la consulta y ingresandolos en el DATAGRIDVIEW correspondiente
        datos.Reset()
        consulta_marcas()
        dgvmarca.DataSource = _dtvdatos

        dscategorias.Reset()
        consulta_categorias()
        dgvcategoria.DataSource = dvcategorias

        dsformatos.Reset()
        consulta_formatos()
        dgvformato.DataSource = dvformatos
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim datosproducto As New productos
        Dim sentencia As New Sentencias_productos

        If (String.IsNullOrEmpty(txtnombre.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase



            Dim idproducto As Integer = 1
            Dim idmarca As String = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(0).Value.ToString
            Dim idcategoria As String = dgvcategoria.Rows(dgvcategoria.CurrentRow.Index).Cells(0).Value.ToString
            Dim idformato As String = dgvformato.Rows(dgvformato.CurrentRow.Index).Cells(0).Value.ToString

            datosproducto.Id_producto1 = idproducto
            datosproducto.Id_categorias1 = idcategoria
            datosproducto.Id_marca1 = idmarca
            datosproducto.Nombre_producto1 = txtnombre.Text
            datosproducto.Id_formato1 = idformato

            If sentencia.Creacion_productos(datosproducto) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
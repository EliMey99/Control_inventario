Public Class administrar_producto

    Private Sub administrar_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsproductos.Reset()
        consulta_productos()
        dgvproducto.DataSource = dvproductos
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New crear_producto
        AddHandler frm.FormClosing, AddressOf Crear_producto_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_producto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dsproductos.Reset()
        consulta_productos()
        dgvproducto.DataSource = dvproductos

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datosproducto As New productos
        Dim sentencia As New Sentencias_productos

        Dim idproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(0).Value.ToString
        Dim cate As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(1).Value.ToString
        Dim marca As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(2).Value.ToString
        Dim formato As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(4).Value.ToString

        If (String.IsNullOrEmpty(idproducto)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datosproducto.Id_producto1 = idproducto
                datosproducto.Id_categorias1 = cate
                datosproducto.Id_marca1 = marca
                datosproducto.Id_formato1 = formato

                If sentencia.Eliminar_productos(datosproducto) Then
                    MessageBox.Show("Datos Guardados")

                    dsproductos.Reset()
                    consulta_productos()
                    dgvproducto.DataSource = dvproductos

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvproducto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproducto.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(0).Value.ToString
        Dim idcategoria As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(1).Value.ToString
        Dim idmarca As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(2).Value.ToString
        Dim nombreproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(3).Value.ToString
        Dim idformato As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(4).Value.ToString

        If (String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(idcategoria) Or String.IsNullOrEmpty(idmarca) Or String.IsNullOrEmpty(nombreproducto) Or String.IsNullOrEmpty(idformato)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datosproducto As New productos
            Dim sentencia As New Sentencias_productos

            datosproducto.Id_producto1 = idproducto
            datosproducto.Id_categorias1 = idcategoria
            datosproducto.Id_marca1 = idmarca
            datosproducto.Id_formato1 = idformato
            datosproducto.Nombre_producto1 = nombreproducto

            If sentencia.Actualizar_productos(datosproducto) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub

End Class
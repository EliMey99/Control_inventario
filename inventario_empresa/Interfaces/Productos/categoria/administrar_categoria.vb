Public Class administrar_categoria

    Private Sub administrar_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dscategorias.Reset()
        consulta_categorias()
        dgvcategorias.DataSource = dvcategorias
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New crear_categoria
        AddHandler frm.FormClosing, AddressOf Crear_categoria_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_categoria_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dscategorias.Reset()
        consulta_categorias()
        dgvcategorias.DataSource = dvcategorias

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datoscategorias As New Categorias
        Dim sentencia As New Sentencias_productos

        Dim idcategoria As String = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idcategoria)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datoscategorias.Id_categoria1 = idcategoria

                If sentencia.Eliminar_categorias(datoscategorias) Then
                    MessageBox.Show("Datos Guardados")

                    dscategorias.Reset()
                    consulta_categorias()
                    dgvcategorias.DataSource = dvcategorias

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvcategorias_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcategorias.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idcategoria As String = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombrecategoria As String = dgvcategorias.Rows(dgvcategorias.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(nombrecategoria)) Then
            MessageBox.Show("Ingrese un nombre para actualizar marca")
        Else

            Dim datoscategorias As New Categorias
            Dim sentencia As New Sentencias_productos

            datoscategorias.Id_categoria1 = idcategoria
            datoscategorias.Nombre_categoria1 = nombrecategoria

            If sentencia.Actualizar_categorias(datoscategorias) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub

End Class
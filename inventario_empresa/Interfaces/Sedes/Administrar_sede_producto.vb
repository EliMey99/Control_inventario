Public Class Administrar_sede_producto
    Private Sub administrar_sede_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dssede_producto.Reset()
        consulta_sedeproducto()
        dgvsede_producto.DataSource = dvsede_producto
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_sede_producto
        AddHandler frm.FormClosing, AddressOf Crear_sede_producto_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_sede_producto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dssede_producto.Reset()
        consulta_sedeproducto()
        dgvsede_producto.DataSource = dvsede_producto

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datos As New sede_producto
        Dim sentencia As New Sentencias_sedeproducto

        Dim idsede As String = dgvsede_producto.Rows(dgvsede_producto.CurrentRow.Index).Cells(0).Value.ToString
        Dim idproducto As String = dgvsede_producto.Rows(dgvsede_producto.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(idsede) Or String.IsNullOrEmpty(idproducto)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datos.Id_sede_pro1 = idsede
                datos.Id_producto_se1 = idproducto

                If sentencia.Eliminar_sedeproducto(datos) Then
                    MessageBox.Show("Datos Guardados")

                    dssede_producto.Reset()
                    consulta_sedeproducto()
                    dgvsede_producto.DataSource = dvsede_producto

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvsede_producto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsede_producto.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idsede As String = dgvsede_producto.Rows(dgvsede_producto.CurrentRow.Index).Cells(0).Value.ToString
        Dim idproducto As String = dgvsede_producto.Rows(dgvsede_producto.CurrentRow.Index).Cells(1).Value.ToString
        Dim cantidad As String = dgvsede_producto.Rows(dgvsede_producto.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(idsede) Or String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(cantidad)) Then
            MessageBox.Show("Ingrese un nombre para actualizar marca")
        Else

            Dim datos As New sede_producto
            Dim sentencia As New Sentencias_sedeproducto

            datos.Id_sede_pro1 = idsede
            datos.Id_producto_se1 = idproducto
            datos.Cantidad_producto1 = cantidad

            If sentencia.Actualizar_sedeproducto(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub



End Class
Public Class Administrar_salida_productos
    Private Sub administrar_salida_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dssalida.Reset()
        consulta_salida_productos()
        dgvsalida.DataSource = dvsalida
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New crear_salida_producto
        AddHandler frm.FormClosing, AddressOf Crear_salida_producto_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_salida_producto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dssalida.Reset()
        consulta_salida_productos()
        dgvsalida.DataSource = dvsalida

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datossalida As New Salida_productos
        Dim sentencia As New Sentencias_salida_productos

        Dim idproducto As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(0).Value.ToString
        Dim idtrabajador As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(idtrabajador)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datossalida.Id_producto_tra1 = idproducto
                datossalida.Id_trabajador_pro1 = idtrabajador

                If sentencia.Eliminar_salida_productos(datossalida) Then
                    MessageBox.Show("Datos Guardados")

                    dssalida.Reset()
                    consulta_salida_productos()
                    dgvsalida.DataSource = dvsalida

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvsalida_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalida.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idproducto As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(0).Value.ToString
        Dim idtrabajador As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(1).Value.ToString
        Dim fecha As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(2).Value.ToString
        Dim hora As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(3).Value.ToString
        Dim cantidad As String = dgvsalida.Rows(dgvsalida.CurrentRow.Index).Cells(4).Value.ToString

        If (String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(idtrabajador) Or String.IsNullOrEmpty(fecha) Or String.IsNullOrEmpty(hora) Or String.IsNullOrEmpty(cantidad)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datossalida As New Salida_productos
            Dim sentencia As New Sentencias_salida_productos

            datossalida.Id_producto_tra1 = idproducto
            datossalida.Id_trabajador_pro1 = idtrabajador
            datossalida.Fecha_traspaso1 = fecha
            datossalida.Hora_traspaso1 = hora
            datossalida.Cantidad_producto1 = cantidad

            If sentencia.Actualizar_salida_productos(datossalida) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
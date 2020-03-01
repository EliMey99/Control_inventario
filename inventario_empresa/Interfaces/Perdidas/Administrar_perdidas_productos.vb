Public Class Administrar_perdidas_productos
    Private Sub Administrar_perdidas_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsperdidaproducto.Reset()
        consulta_perdida_producto()
        dgvperdidasproductos.DataSource = dvperdidaproducto
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_perdidas
        AddHandler frm.FormClosing, AddressOf Crear_perdidas_productos_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_perdidas_productos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dsperdidaproducto.Reset()
        consulta_perdida_producto()
        dgvperdidasproductos.DataSource = dvperdidaproducto

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datos As New perdidas_productos
        Dim sentencia As New Sentencias_perdidas_productos

        Dim idproducto As String = dgvperdidasproductos.Rows(dgvperdidasproductos.CurrentRow.Index).Cells(0).Value.ToString
        Dim idperdida As String = dgvperdidasproductos.Rows(dgvperdidasproductos.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(idperdida) Or String.IsNullOrEmpty(idproducto)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datos.Id_productos_per1 = idproducto
                datos.Id_perdidas_pro1 = idperdida

                If sentencia.Eliminar_perdidas_productos(datos) Then
                    MessageBox.Show("Datos Guardados")

                    dsperdidaproducto.Reset()
                    consulta_perdida_producto()
                    dgvperdidasproductos.DataSource = dvperdidaproducto

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvperdidas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvperdidasproductos.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idproducto As String = dgvperdidasproductos.Rows(dgvperdidasproductos.CurrentRow.Index).Cells(0).Value.ToString
        Dim idperdida As String = dgvperdidasproductos.Rows(dgvperdidasproductos.CurrentRow.Index).Cells(1).Value.ToString
        Dim cantidad As String = dgvperdidasproductos.Rows(dgvperdidasproductos.CurrentRow.Index).Cells(2).Value.ToString



        If (String.IsNullOrEmpty(idproducto) Or String.IsNullOrEmpty(idperdida) Or String.IsNullOrEmpty(cantidad)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datos As New perdidas_productos
            Dim sentencia As New Sentencias_perdidas_productos

            datos.Id_productos_per1 = idproducto
            datos.Id_perdidas_pro1 = idperdida
            datos.Cantidad_perdida1 = cantidad



            If sentencia.Actualizar_perdidas_productos(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
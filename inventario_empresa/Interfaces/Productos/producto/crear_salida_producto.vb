Public Class crear_salida_producto
    Private Sub crear_salida_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        dstrabajadores.Reset()
        consulta_trabajadores()
        dgvtrabajador.DataSource = dvtrabajadores

        dsproductos.Reset()
        consulta_productos()
        dgvproducto.DataSource = dvproductos
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datossalida As New Salida_productos
        Dim sentencia As New Sentencias_salida_productos

        If (String.IsNullOrEmpty(txtcantidad.Text)) Then
            MessageBox.Show("Debe ingresar una cantidad para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase


            Dim idproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(0).Value.ToString
            Dim idtrabajador As String = dgvtrabajador.Rows(dgvtrabajador.CurrentRow.Index).Cells(0).Value.ToString
            Dim fecha As String = dtpfecha.Value.ToString
            Dim hora As String = txthora.Text
            Dim cantidad As String = txtcantidad.Text


            datossalida.Id_producto_tra1 = idproducto
            datossalida.Id_trabajador_pro1 = idtrabajador
            datossalida.Fecha_traspaso1 = fecha
            datossalida.Hora_traspaso1 = hora
            datossalida.Cantidad_producto1 = cantidad

            If sentencia.Creacion_salida_productos(datossalida) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txthora.Text = TimeString

    End Sub
End Class
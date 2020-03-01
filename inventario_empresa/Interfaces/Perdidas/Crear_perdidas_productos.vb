Public Class Crear_perdidas_productos

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim datos As New perdidas_productos
        Dim sentencia As New Sentencias_perdidas_productos

        Dim idperdida As String = dgvperdida.Rows(dgvperdida.CurrentRow.Index).Cells(0).Value.ToString
        Dim idproducto As String = dgvproducto.Rows(dgvproducto.CurrentRow.Index).Cells(0).Value.ToString


        If (String.IsNullOrEmpty(txtcantidad.Text) Or String.IsNullOrEmpty(idperdida) Or String.IsNullOrEmpty(idproducto)) Then
            MessageBox.Show("Debe ingresar una cantidad para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datos.Id_perdidas_pro1 = idperdida
            datos.Id_productos_per1 = idproducto
            datos.Cantidad_perdida1 = txtcantidad.Text


            If sentencia.Creacion_perdidas_productos(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If

    End Sub

    Private Sub Crear_perdidas_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsproductos.Reset()
        consulta_productos()
        dgvproducto.DataSource = dvproductos

        dsperdida.Reset()
        consulta_perdida()
        dgvperdida.DataSource = dvperdida
    End Sub
End Class
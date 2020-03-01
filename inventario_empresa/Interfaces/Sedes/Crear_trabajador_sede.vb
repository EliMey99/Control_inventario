Public Class Crear_trabajador_sede
    Private Sub Crear_trabajador_sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dstrabajadores.Reset()
        consulta_trabajadores()
        dgvtrabajador.DataSource = dvtrabajadores

        dssedes.Reset()
        consulta_sedes()
        dgvsede.DataSource = dvsedes

        txtingreso.Text = Now.ToString("HH:mm:ss")
        txtsalida.Text = Now.ToString("HH:mm:ss")

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datos As New trabajador_sede
        Dim sentencia As New Sentencias_trabajador_sede

        If (String.IsNullOrEmpty(txtsalida.Text) Or String.IsNullOrEmpty(txtingreso.Text)) Then
            MessageBox.Show("Debe ingresar una cantidad para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase


            Dim idsede As String = dgvsede.Rows(dgvsede.CurrentRow.Index).Cells(0).Value.ToString
            Dim idtrabajador As String = dgvtrabajador.Rows(dgvtrabajador.CurrentRow.Index).Cells(0).Value.ToString
            Dim salida As String = txtsalida.Text
            Dim entrada As String = txtingreso.Text



            datos.Id_sede_tra1 = idsede
            datos.Id_trabajador_se1 = idtrabajador
            datos.Inicio_jornada1 = entrada
            datos.Termino_jornada1 = salida


            If sentencia.Creacion_trabajador_sede(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If

    End Sub
End Class
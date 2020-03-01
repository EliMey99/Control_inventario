Public Class Administrar_trabajador_sede
    Private Sub administrar_trabajador_sede_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dstrabajador_sede.Reset()
        consulta_trabajadorsede()
        dgvtrabajadorsede.DataSource = dvtrabajador_sede
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_trabajador_sede
        AddHandler frm.FormClosing, AddressOf crear_trabajador_sede_FormClosing
        frm.Show()

    End Sub

    Private Sub crear_trabajador_sede_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dstrabajador_sede.Reset()
        consulta_trabajadorsede()
        dgvtrabajadorsede.DataSource = dvtrabajador_sede

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datos As New trabajador_sede
        Dim sentencia As New Sentencias_trabajador_sede

        Dim idtrabajador As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(0).Value.ToString
        Dim idsede As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(idtrabajador) Or String.IsNullOrEmpty(idsede)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datos.Id_sede_tra1 = idsede
                datos.Id_trabajador_se1 = idtrabajador

                If sentencia.Eliminar_trabajador_sede(datos) Then
                    MessageBox.Show("Datos Guardados")

                    dssalida.Reset()
                    consulta_salida_productos()
                    dgvtrabajadorsede.DataSource = dvsalida

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvsalida_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrabajadorsede.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idtrabajador As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(0).Value.ToString
        Dim idsede As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(1).Value.ToString
        Dim entrada As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(2).Value.ToString
        Dim salida As String = dgvtrabajadorsede.Rows(dgvtrabajadorsede.CurrentRow.Index).Cells(3).Value.ToString


        If (String.IsNullOrEmpty(idtrabajador) Or String.IsNullOrEmpty(idsede) Or String.IsNullOrEmpty(entrada) Or String.IsNullOrEmpty(salida)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datos As New trabajador_sede
            Dim sentencia As New Sentencias_trabajador_sede


            datos.Id_sede_tra1 = idsede
            datos.Id_trabajador_se1 = idtrabajador
            datos.Inicio_jornada1 = entrada
            datos.Termino_jornada1 = salida


            If sentencia.Actualizar_trabajador_sede(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
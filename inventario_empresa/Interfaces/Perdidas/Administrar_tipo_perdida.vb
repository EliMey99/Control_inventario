Public Class Administrar_tipo_perdida
    Private Sub Administrar_tipo_perdida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dstipoperdida.Reset()
        consulta_tipo_perdida()
        dgvtipo.DataSource = dvtipoperdida
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_tipo_perdida
        AddHandler frm.FormClosing, AddressOf Crear_tipo_perdida_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_tipo_perdida_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dstipoperdida.Reset()
        consulta_tipo_perdida()
        dgvtipo.DataSource = dvtipoperdida

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datos As New tipo_perdida
        Dim sentencia As New Sentencias_tipo_perdida

        Dim idtipo As String = dgvtipo.Rows(dgvtipo.CurrentRow.Index).Cells(0).Value.ToString


        If (String.IsNullOrEmpty(idtipo)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datos.Id_tipo_perdida1 = idtipo


                If sentencia.Eliminar_tipo_perdida(datos) Then
                    MessageBox.Show("Datos Guardados")

                    dstipoperdida.Reset()
                    consulta_tipo_perdida()
                    dgvtipo.DataSource = dvtipoperdida

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvtipo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtipo.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idtipo As String = dgvtipo.Rows(dgvtipo.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombre As String = dgvtipo.Rows(dgvtipo.CurrentRow.Index).Cells(1).Value.ToString



        If (String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(idtipo)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datos As New tipo_perdida
            Dim sentencia As New Sentencias_tipo_perdida


            datos.Id_tipo_perdida1 = idtipo
            datos.Nombre_tipo1 = nombre



            If sentencia.Actualizar_tipo_perdida(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
Public Class Administrar_trabajadores
    Private Sub administrar_trabajadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dstrabajadores.Reset()
        consulta_trabajadores()
        dgvtrabajadores.DataSource = dvtrabajadores
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_trabajadores
        AddHandler frm.FormClosing, AddressOf Crear_trabajadores_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_trabajadores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dstrabajadores.Reset()
        consulta_trabajadores()
        dgvtrabajadores.DataSource = dvtrabajadores

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datostrabajador As New Trabajador
        Dim sentencia As New Sentencias_trabajadores

        Dim idtrabajador As String = dgvtrabajadores.Rows(dgvtrabajadores.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idtrabajador)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datostrabajador.Id_trabajador1 = idtrabajador

                If sentencia.Eliminar_trabajador(datostrabajador) Then
                    MessageBox.Show("Datos Guardados")

                    dstrabajadores.Reset()
                    consulta_trabajadores()
                    dgvtrabajadores.DataSource = dvtrabajadores

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvtrabajadores_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrabajadores.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idtrabajador As String = dgvtrabajadores.Rows(dgvtrabajadores.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombre_trabajador As String = dgvtrabajadores.Rows(dgvtrabajadores.CurrentRow.Index).Cells(1).Value.ToString
        Dim apellidos_trabajador As String = dgvtrabajadores.Rows(dgvtrabajadores.CurrentRow.Index).Cells(2).Value.ToString
        Dim rut As String = dgvtrabajadores.Rows(dgvtrabajadores.CurrentRow.Index).Cells(3).Value.ToString

        If (String.IsNullOrEmpty(idtrabajador) Or String.IsNullOrEmpty(nombre_trabajador) Or String.IsNullOrEmpty(apellidos_trabajador) Or String.IsNullOrEmpty(rut)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datostrabajador As New Trabajador
            Dim sentencia As New Sentencias_trabajadores

            datostrabajador.Id_trabajador1 = idtrabajador
            datostrabajador.Nombre_trabajador1 = nombre_trabajador
            datostrabajador.Apellidos_trabajador1 = apellidos_trabajador
            datostrabajador.Rut1 = rut


            If sentencia.Actualizar_trabajador(datostrabajador) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub

End Class
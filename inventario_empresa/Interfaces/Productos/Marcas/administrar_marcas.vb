Public Class administrar_formatos
    Private Sub administrar_marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        datos.Reset()
        consulta_marcas()
        dgvmarca.DataSource = _dtvdatos

    End Sub

    Private Sub btncrear_Click(sender As Object, e As EventArgs) Handles btncrear.Click
        crear_marca.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click

        Dim datosmarca As New Marcas
        Dim sentencia As New Sentencias_productos

        Dim idmarca As String = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idmarca)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datosmarca.Id_marca1 = idmarca

                If sentencia.Eliminar_Marcas(datosmarca) Then
                    MessageBox.Show("Datos Guardados")
                    datos.Reset()
                    consulta_marcas()
                    dgvmarca.DataSource = _dtvdatos
                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else


            End If

        End If
    End Sub

    Private Sub dgvmarca_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmarca.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idmarca As Integer = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombremarca As String = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(nombremarca)) Then
            MessageBox.Show("Ingrese un nombre para actualizar categoria")
        Else

            Dim datosmarca As New Marcas
            Dim sentencia As New Sentencias_productos

            datosmarca.Id_marca1 = idmarca
            datosmarca.Nombre_marca1 = nombremarca

            If sentencia.Actualizar_Marcas(datosmarca) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al actualizar")
            End If

        End If
    End Sub
End Class
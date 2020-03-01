Public Class administrar_marca

    Private Sub administrar_marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datos.Reset()
        consulta_marcas()
        dgvmarca.DataSource = _dtvdatos
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New crear_marca
        AddHandler frm.FormClosing, AddressOf Crear_marca_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_marca_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        datos.Reset()
        consulta_marcas()
        dgvmarca.DataSource = _dtvdatos

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
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
        Dim idmarca As String = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombremarca As String = dgvmarca.Rows(dgvmarca.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(nombremarca)) Then
            MessageBox.Show("Ingrese un nombre para actualizar marca")
        Else

            Dim datosmarca As New Marcas
            Dim sentencia As New Sentencias_productos

            datosmarca.Id_marca1 = idmarca
            datosmarca.Nombre_marca1 = nombremarca

            If sentencia.Actualizar_Marcas(datosmarca) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub







End Class
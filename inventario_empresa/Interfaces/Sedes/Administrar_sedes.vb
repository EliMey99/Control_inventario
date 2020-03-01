Public Class Administrar_sedes
    Private Sub administrar_sedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dssedes.Reset()
        consulta_sedes()
        dgvsedes.DataSource = dvsedes
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_sedes
        AddHandler frm.FormClosing, AddressOf Crear_sedes_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_sedes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dssedes.Reset()
        consulta_sedes()
        dgvsedes.DataSource = dvsedes

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datossedes As New Sedes
        Dim sentencia As New Sentencias_sedes

        Dim idsedes As String = dgvsedes.Rows(dgvsedes.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idsedes)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datossedes.Id_sedes1 = idsedes

                If sentencia.Eliminar_sede(datossedes) Then
                    MessageBox.Show("Datos Guardados")

                    dstrabajadores.Reset()
                    consulta_trabajadores()
                    dgvsedes.DataSource = dvsedes

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvsedes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsedes.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idsede As String = dgvsedes.Rows(dgvsedes.CurrentRow.Index).Cells(0).Value.ToString
        Dim calle As String = dgvsedes.Rows(dgvsedes.CurrentRow.Index).Cells(1).Value.ToString
        Dim numero As String = dgvsedes.Rows(dgvsedes.CurrentRow.Index).Cells(2).Value.ToString

        If (String.IsNullOrEmpty(idsede) Or String.IsNullOrEmpty(calle) Or String.IsNullOrEmpty(numero)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datossedes As New Sedes
            Dim sentencia As New Sentencias_sedes

            datossedes.Id_sedes1 = idsede
            datossedes.Calle1 = calle
            datossedes.Numero1 = numero



            If sentencia.Actualizar_sede(datossedes) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
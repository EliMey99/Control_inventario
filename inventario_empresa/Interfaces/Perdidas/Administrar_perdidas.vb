Public Class Administrar_perdidas
    Private Sub Administrar_perdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsperdida.Reset()
        consulta_perdida()
        dgvperdidas.DataSource = dvperdida
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New Crear_perdidas
        AddHandler frm.FormClosing, AddressOf Crear_perdidas_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_perdidas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dsperdida.Reset()
        consulta_perdida()
        dgvperdidas.DataSource = dvperdida

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datos As New Perdidas
        Dim sentencia As New Sentencias_perdidas

        Dim idperdida As String = dgvperdidas.Rows(dgvperdidas.CurrentRow.Index).Cells(0).Value.ToString
        Dim idtipo As String = dgvperdidas.Rows(dgvperdidas.CurrentRow.Index).Cells(1).Value.ToString

        If (String.IsNullOrEmpty(idperdida) Or String.IsNullOrEmpty(idtipo)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datos.Id_perdida1 = idperdida
                datos.Id_tipo1 = idtipo

                If sentencia.Eliminar_perdidas(datos) Then
                    MessageBox.Show("Datos Guardados")

                    dsperdida.Reset()
                    consulta_perdida()
                    dgvperdidas.DataSource = dvperdida

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvperdidas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvperdidas.CellEndEdit
        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idperdida As String = dgvperdidas.Rows(dgvperdidas.CurrentRow.Index).Cells(0).Value.ToString
        Dim idtipo As String = dgvperdidas.Rows(dgvperdidas.CurrentRow.Index).Cells(1).Value.ToString
        Dim descripcion As String = dgvperdidas.Rows(dgvperdidas.CurrentRow.Index).Cells(2).Value.ToString



        If (String.IsNullOrEmpty(idtipo) Or String.IsNullOrEmpty(idperdida) Or String.IsNullOrEmpty(descripcion)) Then
            MessageBox.Show("Rellene todos los datos para actualizar")
        Else

            Dim datos As New Perdidas
            Dim sentencia As New Sentencias_perdidas

            datos.Id_perdida1 = idperdida
            datos.Id_tipo1 = idtipo
            datos.Descripcion1 = descripcion



            If sentencia.Actualizar_perdidas(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If
    End Sub
End Class
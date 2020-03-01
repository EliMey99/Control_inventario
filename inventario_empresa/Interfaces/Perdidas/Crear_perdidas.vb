Public Class Crear_perdidas
    Private Sub Crear_perdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dstipoperdida.Reset()
        consulta_tipo_perdida()
        dgvtipo.DataSource = dvtipoperdida
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datos As New Perdidas
        Dim sentencia As New Sentencias_perdidas

        Dim idtipo As String = dgvtipo.Rows(dgvtipo.CurrentRow.Index).Cells(0).Value.ToString


        If (String.IsNullOrEmpty(idtipo) Or String.IsNullOrEmpty(txtdescripcion.Text)) Then
            MessageBox.Show("Debe rellenar todos los datos para registrar un producto")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase


            datos.Id_tipo1 = idtipo
            datos.Descripcion1 = txtdescripcion.Text


            If sentencia.Creacion_perdidas(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
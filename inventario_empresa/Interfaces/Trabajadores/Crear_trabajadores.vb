Public Class Crear_trabajadores
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click

        Dim datostrabajador As New Trabajador
        Dim sentencia As New Sentencias_trabajadores

        If (String.IsNullOrEmpty(txtrut.Text) Or String.IsNullOrEmpty(txtnombre.Text) Or String.IsNullOrEmpty(txtapellidos.Text) Or String.IsNullOrEmpty(txtrut.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datostrabajador.Id_trabajador1 = txtid.Text
            datostrabajador.Nombre_trabajador1 = txtnombre.Text
            datostrabajador.Apellidos_trabajador1 = txtapellidos.Text
            datostrabajador.Rut1 = txtrut.Text

            If sentencia.Creacion_trabajador(datostrabajador) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If

    End Sub

    Private Sub Crear_trabajadores_Load(sender As Object, e As EventArgs)

    End Sub
End Class
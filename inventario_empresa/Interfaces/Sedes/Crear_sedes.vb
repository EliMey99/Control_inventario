Public Class Crear_sedes
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datossedes As New Sedes
        Dim sentencia As New Sentencias_sedes

        If (String.IsNullOrEmpty(txtnumero.Text) Or String.IsNullOrEmpty(txtcalle.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datossedes.Calle1 = txtcalle.Text
            datossedes.Numero1 = txtnumero.Text

            If sentencia.Creacion_sede(datossedes) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
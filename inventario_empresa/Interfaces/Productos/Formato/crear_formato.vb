Public Class crear_formato
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datosformato As New Formatos
        Dim sentencia As New Sentencias_productos



        If (String.IsNullOrEmpty(txtnombre.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datosformato.Nombre_formato1 = txtnombre.Text
            datosformato.Capacidad_formato1 = txtcapacidad.Text

            If sentencia.Creacion_Formatos(datosformato) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
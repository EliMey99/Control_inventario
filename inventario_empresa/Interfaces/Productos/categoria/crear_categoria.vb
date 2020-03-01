Public Class crear_categoria

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datoscategorias As New Categorias
        Dim sentencia As New Sentencias_productos



        If (String.IsNullOrEmpty(txtnombre.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datoscategorias.Nombre_categoria1 = txtnombre.Text

            If sentencia.Creacion_categorias(datoscategorias) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If

    End Sub

End Class
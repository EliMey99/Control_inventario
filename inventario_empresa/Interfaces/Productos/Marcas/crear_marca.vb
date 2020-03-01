Public Class crear_marca
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim datosmarcas As New Marcas
        Dim sentencia As New Sentencias_productos



        If (String.IsNullOrEmpty(txtnombre.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase

            datosmarcas.Nombre_marca1 = txtnombre.Text

            If sentencia.Creacion_Marcas(datosmarcas) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub
End Class
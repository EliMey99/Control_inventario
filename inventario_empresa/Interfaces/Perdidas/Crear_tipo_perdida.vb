Public Class Crear_tipo_perdida
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datos As New tipo_perdida
        Dim sentencia As New Sentencias_tipo_perdida

        If (String.IsNullOrEmpty(txttipo.Text)) Then
            MessageBox.Show("Debe ingresar un nombre para continuar")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase


            datos.Nombre_tipo1 = txttipo.Text

            If sentencia.Creacion_tipo_perdida(datos) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If


        End If
    End Sub

    Private Sub Crear_tipo_perdida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
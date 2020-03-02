Public Class Add_user


    Private Sub Add_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validaciones_usuario.Cargar_combo(cmbox_tipos)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim datos_usuario As New usuario
        Dim sentencia As New Sentencias_usuario


        If ((String.IsNullOrEmpty(txtnombre.Text)) Or (String.IsNullOrEmpty(passwordtxt.Text)) Or (String.IsNullOrEmpty(password2.Text)) Or (cmbox_tipos.Text.Equals("Seleccione un tipo..."))) Then
            MessageBox.Show("Debe completar todos los campos")
        Else

            'Aca se extraen los datos de los TEXTBOX  y se pasan a cada atributo de la clase
            datos_usuario.Id_acceso_usuario1 = cmbox_tipos.SelectedValue
            datos_usuario.Name_user1 = txtnombre.Text
            datos_usuario.Password1 = passwordtxt.Text
            datos_usuario.Password21 = password2.Text

            'Verifica si el nombre de usuario esta disponible 
            If verificar_datos(datos_usuario) Then
                MessageBox.Show("Este nombre de usuario ya está en uso. Elige otro")
                txtnombre.Text = ""
                passwordtxt.Text = ""
                validaciones_usuario.Cargar_combo(cmbox_tipos)
            Else
                valida.Visible = False
                'Válida que las contraseñas coincidan
                If datos_usuario.Password1 = datos_usuario.Password21 Then
                    'Si esta disponible se añadirá
                    If sentencia.Crear_usuarios(datos_usuario) Then
                        MessageBox.Show("Datos guardados correctamente")
                        Me.Close()
                    Else
                        MessageBox.Show("Error al Guardar")
                    End If

                Else
                    'Si no coinciden se limpian los campos
                    valida.Visible = True
                    password2.Text = ""
                    passwordtxt.Text = ""

                End If

            End If

        End If

    End Sub
End Class
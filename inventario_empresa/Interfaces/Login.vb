

Public Class Login

    Private Sub ingreso_btn_Click(sender As Object, e As EventArgs) Handles ingreso_btn.Click
        Dim datos_sesion As New usuario


        If String.IsNullOrEmpty(passwordtxt.Text) Or (String.IsNullOrEmpty(name_usertxt.Text)) Then

            valida.Text = ""
            valida.Visible = True
            valida.Text = "Debe completar todos los campos"

        Else

            datos_sesion.Password1 = passwordtxt.Text
            datos_sesion.Name_user1 = name_usertxt.Text

            If Iniciar_sesion(datos_sesion) Then
                valida.Visible = False
                Me.Hide()
                Ventana_principal.Show()
            Else
                valida.Visible = True
                passwordtxt.Text = ""
                name_usertxt.Text = ""
            End If

        End If




    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As Form = New Login
        ventana.AutoSizeMode = False
        ventana.AutoSize = False
        Dim result As New Boolean
        result = Verifica_usuarios()
        If result Then

        Else
            Add_user.StartPosition = FormStartPosition.CenterScreen
            Add_user.ShowDialog()
        End If

    End Sub

End Class
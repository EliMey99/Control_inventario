Public Class Login
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()

        Ventana_principal.Show()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As Form = New Login
        ventana.AutoSizeMode = False
        ventana.AutoSize = False

    End Sub

End Class
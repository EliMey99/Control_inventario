
Imports Npgsql

Module validaciones_usuario

    Private adaptador As New Npgsql.NpgsqlDataAdapter
    'Verifica si existen registros de usuarios
    Public Function Verifica_usuarios() As Boolean

        Dim user As New usuario
        Dim resu As New Boolean
        Try
            Conectar()
            'Se prepara la sentencia 
            Dim consulta As New NpgsqlCommand("SELECT nombre_usuario, password FROM usuarios;", conex)
            'Nos aseguramos que no exista ninguna conexión abierta previa
            If Not conex Is Nothing Then conex.Close()
            conex.Open()
            Dim datos As NpgsqlDataReader = consulta.ExecuteReader

            If datos.Read Then
                resu = True
            Else
                resu = False

            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
        Return resu
    End Function

    'Cargael combo_box de los tipos de accesos
    Public Sub Cargar_combo(cmbox_tipos As ComboBox)
        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("SELECT * FROM accesos;", conex)
            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()
            'Configurar combobox
            Dim dt_cliente As New DataTable
            adaptador.Fill(dt_cliente)


            If dt_cliente.Rows.Count > 0 Then
                cmbox_tipos.DataSource = dt_cliente
                cmbox_tipos.DisplayMember = "nombre_acceso"
                cmbox_tipos.ValueMember = "id_acceso"
                cmbox_tipos.Text = "Seleccione un tipo..."
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub

    'Comrpueba que no se repitan los nombres de usuario
    Public Function verificar_datos(datos_usuarios As usuario) As Boolean

        Dim user As New usuario
        Dim resu As New Boolean
        Try
            Conectar()
            'Se prepara la sentencia 
            Dim consulta As New NpgsqlCommand("SELECT * FROM usuarios WHERE nombre_usuario='" + datos_usuarios.Name_user1 + "';", conex)
            'Nos aseguramos que no exista ninguna conexión abierta previa
            If Not conex Is Nothing Then conex.Close()
            conex.Open()
            Dim datos As NpgsqlDataReader = consulta.ExecuteReader

            If datos.Read Then
                resu = True
            Else
                resu = False

            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
        Return resu
    End Function

    'Comprobar nombre de usuario y contraseña para inicio de sesión
    Public Function Iniciar_sesion(datos_usuarios As usuario) As Boolean

        Dim user As New usuario
        Dim resu As New Boolean
        Try
            Conectar()
            'Se prepara la sentencia 
            Dim consulta As New NpgsqlCommand("SELECT id_acceso_usuario,nombre_usuario,password FROM usuarios WHERE 
                        nombre_usuario='" + datos_usuarios.Name_user1 + "' AND password='" + datos_usuarios.Password1 + "';", conex)
            'Nos aseguramos que no exista ninguna conexión abierta previa
            If Not conex Is Nothing Then conex.Close()
            conex.Open()
            Dim datos As NpgsqlDataReader = consulta.ExecuteReader

            If datos.Read Then
                resu = True
            Else
                resu = False

            End If

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
        Return resu
    End Function

End Module

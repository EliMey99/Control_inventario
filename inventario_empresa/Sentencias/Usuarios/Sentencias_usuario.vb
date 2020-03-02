Imports inventario_empresa
Imports Npgsql
Public Class Sentencias_usuario

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '-----------------------------------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------- I N S E R T S -----------------------------------------------------------------------------------


    Friend Function Crear_usuarios(datos_usuario As usuario) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("INSERT INTO usuarios(id_acceso_usuario,nombre_usuario,password) VALUES(@id,@name,@password);", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos_usuario.Id_acceso_usuario1
            adaptador.InsertCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos_usuario.Name_user1
            adaptador.InsertCommand.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos_usuario.Password1
            adaptador.InsertCommand.Connection = conex
            adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function


End Class

Imports Npgsql

Public Class Sentencias_tipo_perdida

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede
    Public Function Creacion_tipo_perdida(ByVal datos As tipo_perdida) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into tipo_perdida(nombre_tipo) VALUES (@nombre)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_tipo1
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

    '---------------------------------------------------------------------------------------------------------------------------------- 
    '-------------------------------------------------------- U P D A T E S ------------------------------------------------------------- 

    'Actualizar sede
    Public Function Actualizar_tipo_perdida(ByVal datos As tipo_perdida) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE tipo_perdida SET nombre_tipo=@nombre WHERE id_tipo_perdida=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo_perdida1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_tipo1



            adaptador.UpdateCommand.Connection = conex
            adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            conex.Close()
        End Try
        Return estado
    End Function

    '---------------------------------------------------------------------------------------------------------------------------------- 
    '-------------------------------------------------------- E L I M I N A R ------------------------------------------------------------- 


    'Eliminar sede
    Public Function Eliminar_tipo_perdida(ByVal datos As tipo_perdida) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From tipo_perdida Where id_tipo_perdida = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo_perdida1
            adaptador.DeleteCommand.Connection = conex
            adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As NpgsqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

End Class

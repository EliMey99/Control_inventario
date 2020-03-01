Imports Npgsql

Public Class Sentencias_perdidas

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede
    Public Function Creacion_perdidas(ByVal datos As Perdidas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into perdidas(id_tipo,descripcion_perdida) VALUES (@tipo,@descripcion)", conex)
            adaptador.InsertCommand.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_tipo1
            adaptador.InsertCommand.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Descripcion1
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
    Public Function Actualizar_perdidas(ByVal datos As Perdidas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE perdidas SET id_tipo=@tipo,descripcion_perdida=@descripcion WHERE id_perdida=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_perdida1
            adaptador.UpdateCommand.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Id_tipo1
            adaptador.UpdateCommand.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Descripcion1



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
    Public Function Eliminar_perdidas(ByVal datos As Perdidas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From perdidas Where id_perdida = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_perdida1
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

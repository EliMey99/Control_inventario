Imports Npgsql

Public Class Sentencias_perdidas_productos


    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede
    Public Function Creacion_perdidas_productos(ByVal datos As perdidas_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into perdidas_productos(id_productos_per,id_perdidas_pro,cantidad_perdida) VALUES (@id,@perdidas,@cantidad)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_productos_per1
            adaptador.InsertCommand.Parameters.Add("@perdida", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_perdidas_pro1
            adaptador.InsertCommand.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Cantidad_perdida1
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
    Public Function Actualizar_perdidas_productos(ByVal datos As perdidas_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE perdidas_productos SET cantidad_perdida=@cantidad WHERE id_productos_per=@id and id_perdidas_pro=@perdidas", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_productos_per1
            adaptador.UpdateCommand.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Id_perdidas_pro1
            adaptador.UpdateCommand.Parameters.Add("@descripcion", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Cantidad_perdida1



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
    Public Function Eliminar_perdidas_productos(ByVal datos As perdidas_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From perdidas_productos Where id_productos_per=@id and id_perdidas_pro=@perdidas", conex)
            adaptador.DeleteCommand.Parameters.Add("@perdidas", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_perdidas_pro1
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_productos_per1
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

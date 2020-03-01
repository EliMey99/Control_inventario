Imports Npgsql

Public Class Sentencias_trabajador_sede

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de trabajador_sede
    Public Function Creacion_trabajador_sede(ByVal datos As trabajador_sede) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into trabajador_sede(id_trabajador_se,id_sede_tra,inicio_jornada,termino_jornada) VALUES (@id,@sede,@inicio,@termino)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_se1
            adaptador.InsertCommand.Parameters.Add("@sede", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sede_tra1
            adaptador.InsertCommand.Parameters.Add("@inicio", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = datos.Inicio_jornada1
            adaptador.InsertCommand.Parameters.Add("@termino", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = datos.Termino_jornada1
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

    'Actualizar trabajador
    Public Function Actualizar_trabajador_sede(ByVal datos As trabajador_sede) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE trabajador_sede SET id_sede_tra=@sede,inicio_jornada=@inicio,termino_jornada=@termino WHERE id_trabajador_se=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_se1
            adaptador.UpdateCommand.Parameters.Add("@sede", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Id_sede_tra1
            adaptador.UpdateCommand.Parameters.Add("@inicio", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Inicio_jornada1
            adaptador.UpdateCommand.Parameters.Add("@termino", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Termino_jornada1

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


    'Eliminar trabajador
    Public Function Eliminar_trabajador_sede(ByVal datos As trabajador_sede) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From trabajador_sede Where id_trabajador_sede = @id and id_sede_tra=@sede", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_se1
            adaptador.DeleteCommand.Parameters.Add("@sede", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sede_tra1
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

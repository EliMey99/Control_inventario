Imports Npgsql

Public Class Sentencias_salida_productos

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede producto
    Public Function Creacion_salida_productos(ByVal datos As Salida_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into salida_productos(id_producto_tra,id_trabajador_pro,fecha_traspaso,hora_traspaso,cantidad_producto) VALUES (@id,@trabajador,@fecha,@hora,@cantidad)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_tra1
            adaptador.InsertCommand.Parameters.Add("@trabajador", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_pro1
            adaptador.InsertCommand.Parameters.Add("@fecha", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_traspaso1
            adaptador.InsertCommand.Parameters.Add("@hora", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = datos.Hora_traspaso1
            adaptador.InsertCommand.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Cantidad_producto1
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

    'Actualizar sede producto
    Public Function Actualizar_salida_productos(ByVal datos As Salida_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE salida_productos SET fecha_traspaso=@fecha,hora_traspaso=@hora,cantidad_producto=@cantidad WHERE id_producto_tra=@id and id_trabajador_pro=@trabajador", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_tra1
            adaptador.InsertCommand.Parameters.Add("@trabajador", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_pro1
            adaptador.InsertCommand.Parameters.Add("@fecha", NpgsqlTypes.NpgsqlDbType.Date).Value = datos.Fecha_traspaso1
            adaptador.InsertCommand.Parameters.Add("@hora", NpgsqlTypes.NpgsqlDbType.Timestamp).Value = datos.Hora_traspaso1
            adaptador.InsertCommand.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Cantidad_producto1


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


    'Eliminar sede producto
    Public Function Eliminar_salida_productos(ByVal datos As Salida_productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From salida_productos Where id_producto_tra=@id and id_trabajador_pro=@trabajador", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_tra1
            adaptador.DeleteCommand.Parameters.Add("@trabajador", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador_pro1
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

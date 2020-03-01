Imports Npgsql

Public Class Sentencias_sedeproducto

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede producto
    Public Function Creacion_sedeproducto(ByVal datos As sede_producto) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into sede_producto(id_sede_prod,id_producto_se,cantidad_producto) VALUES (@id,@producto,@cantidad)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sede_pro1
            adaptador.InsertCommand.Parameters.Add("@producto", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_se1
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
    Public Function Actualizar_sedeproducto(ByVal datos As sede_producto) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE sede_producto SET id_producto_se=@producto,cantidad_producto=@cantidad WHERE id_sede_prod=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sede_pro1
            adaptador.UpdateCommand.Parameters.Add("@producto", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_se1
            adaptador.UpdateCommand.Parameters.Add("@cantidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Cantidad_producto1


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
    Public Function Eliminar_sedeproducto(ByVal datos As sede_producto) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From sede_producto Where id_sede_prod = @id and id_producto_se=@producto", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sede_pro1
            adaptador.DeleteCommand.Parameters.Add("@producto", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto_se1
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

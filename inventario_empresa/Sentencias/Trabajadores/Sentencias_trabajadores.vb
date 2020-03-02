Imports Npgsql

Public Class Sentencias_trabajadores

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ----------------------------------------------------------------------------- 


    'Creación de trabajador
    Public Function Creacion_trabajador(ByVal datos As Trabajador) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into trabajador(id_trabajador,nombre_traba,apellidos_traba,rut) VALUES (@id,@nombre,@apellidos,@rut)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador1
            adaptador.InsertCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_trabajador1
            adaptador.InsertCommand.Parameters.Add("@apellidos", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Apellidos_trabajador1
            adaptador.InsertCommand.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Rut1
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
    Public Function Actualizar_trabajador(ByVal datos As Trabajador) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE trabajador SET nombre_traba=@nombre,apellidos_traba=@apellidos,rut=@rut WHERE id_trabajador=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_trabajador1
            adaptador.UpdateCommand.Parameters.Add("@apellidos", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Apellidos_trabajador1
            adaptador.UpdateCommand.Parameters.Add("@rut", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Rut1

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
    Public Function Eliminar_trabajador(ByVal datos As Trabajador) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From trabajador Where id_trabajador = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_trabajador1
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

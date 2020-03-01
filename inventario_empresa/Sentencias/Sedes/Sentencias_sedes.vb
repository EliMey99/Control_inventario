Imports Npgsql

Public Class Sentencias_sedes

    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de sede
    Public Function Creacion_sede(ByVal datos As Sedes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into sedes(calle,numero) VALUES (@calle,@numero)", conex)
            adaptador.InsertCommand.Parameters.Add("@calle", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Calle1
            adaptador.InsertCommand.Parameters.Add("@numero", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Numero1
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
    Public Function Actualizar_sede(ByVal datos As Sedes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE sedes SET calle=@calle,numero=@numero WHERE id_sedes=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sedes1
            adaptador.UpdateCommand.Parameters.Add("@calle", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Calle1
            adaptador.UpdateCommand.Parameters.Add("@numero", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Numero1


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
    Public Function Eliminar_sede(ByVal datos As Sedes) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From sedes Where id_sedes = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_sedes1
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

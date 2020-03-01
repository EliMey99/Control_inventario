Imports Npgsql

Public Class Sentencias_productos





    Private adaptador As New Npgsql.NpgsqlDataAdapter


    '--------------------------------------------------- I N S E R T S ------------------------------------------------------------- 


    'Creación de Marcas
    Public Function Creacion_Marcas(ByVal datos As Marcas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into marca(nombre_marca) VALUES (@nombres)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_marca1
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

    'Creación de formatos
    Public Function Creacion_Formatos(ByVal datos As Formatos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into formato_producto(nombre_formato,capacidad_cantidad) VALUES (@nombres,@capacidad)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_formato1
            adaptador.InsertCommand.Parameters.Add("@capacidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Capacidad_formato1
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

    'Creación de categorias
    Public Function Creacion_categorias(ByVal datos As Categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into categoria(nombre_categoria) VALUES (@nombres)", conex)
            adaptador.InsertCommand.Parameters.Add("@nombres", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1
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


    'Creación de productos
    Public Function Creacion_productos(ByVal datos As productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.InsertCommand = New NpgsqlCommand("insert into producto(id_producto,id_categorias,id_marca_prod,nombre_producto,id_formato_prod) VALUES (@id,@categoria,@marca,@nombre,@formato)", conex)
            adaptador.InsertCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto1
            adaptador.InsertCommand.Parameters.Add("@categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categorias1
            adaptador.InsertCommand.Parameters.Add("@formato", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_formato1
            adaptador.InsertCommand.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.InsertCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_producto1
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

    'Actualizar Marcas
    Public Function Actualizar_Marcas(ByVal datos As Marcas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE marca SET nombre_marca=@nombre WHERE id_marca=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_marca1

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

    'Actualizar formatos
    Public Function Actualizar_formatos(ByVal datos As Formatos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE formato_producto SET nombre_formato=@nombre,capacidad_cantidad=@capacidad WHERE id_formato=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_formato1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_formato1
            adaptador.UpdateCommand.Parameters.Add("@capacidad", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Capacidad_formato1

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

    'Actualizar categorias
    Public Function Actualizar_categorias(ByVal datos As Categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE categoria SET nombre_categoria=@nombre WHERE id_categoria=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_categoria1

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

    'Actualizar productos
    Public Function Actualizar_productos(ByVal datos As productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.UpdateCommand = New NpgsqlCommand("UPDATE producto SET id_categoria=@categoria,id_marca_prod=@marca,nombre_producto=@nombre,id_formato_prod=@formato WHERE id_producto=@id", conex)
            adaptador.UpdateCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.UpdateCommand.Parameters.Add("@categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.UpdateCommand.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.UpdateCommand.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 32).Value = datos.Nombre_producto1
            adaptador.UpdateCommand.Parameters.Add("@formato", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
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


    'Eliminar Marcas
    Public Function Eliminar_Marcas(ByVal datos As Marcas) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From marca Where id_marca = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
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

    'Eliminar formatos
    Public Function Eliminar_formatos(ByVal datos As Formatos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From formato_producto Where id_formato = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_formato1
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

    'Eliminar categorias
    Public Function Eliminar_categorias(ByVal datos As Categorias) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From categoria Where id_categoria = @id", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categoria1
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

    'Eliminar productos
    Public Function Eliminar_productos(ByVal datos As productos) As Boolean
        Dim estado As Boolean = True
        Try
            Conectar()
            adaptador.DeleteCommand = New NpgsqlCommand("Delete From producto Where id_producto = @id and id_categorias=@categoria and id_marca_prod=@marca and id_formato_prod=@formato", conex)
            adaptador.DeleteCommand.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_producto1
            adaptador.DeleteCommand.Parameters.Add("@categoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_categorias1
            adaptador.DeleteCommand.Parameters.Add("@marca", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_marca1
            adaptador.DeleteCommand.Parameters.Add("@formato", NpgsqlTypes.NpgsqlDbType.Integer).Value = datos.Id_formato1
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

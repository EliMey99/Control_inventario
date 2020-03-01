Imports Npgsql

Module consultas_productos

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public datos As New DataSet
    Public dsformatos As New DataSet
    Public dscategorias As New DataSet
    Public dsproductos As New DataSet


    Public _dtvdatos As New DataView
    Public dvformatos As New DataView
    Public dvcategorias As New DataView
    Public dvproductos As New DataView

    Public Sub consulta_marcas()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from marca", conex)
            adaptador.Fill(datos)
            _dtvdatos.Table = datos.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub


    Public Sub consulta_formatos()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from formato_producto", conex)
            adaptador.Fill(dsformatos)
            dvformatos.Table = dsformatos.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub

    Public Sub consulta_categorias()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from categoria", conex)
            adaptador.Fill(dscategorias)
            dvcategorias.Table = dscategorias.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub

    Public Sub consulta_productos()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from producto", conex)
            adaptador.Fill(dsproductos)
            dvproductos.Table = dsproductos.Tables(0)

            'Se ejecuta
            adaptador.SelectCommand.Connection = conex
            adaptador.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conex.Close()
        End Try
    End Sub


End Module

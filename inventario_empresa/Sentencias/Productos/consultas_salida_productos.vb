Imports Npgsql
Module consultas_salida_productos

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dssalida As New DataSet

    Public dvsalida As New DataView


    Public Sub consulta_salida_productos()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from salida_productos", conex)
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

End Module

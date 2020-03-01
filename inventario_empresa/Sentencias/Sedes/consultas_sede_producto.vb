Imports Npgsql

Module consultas_sede_producto

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dssede_producto As New DataSet

    Public dvsede_producto As New DataView


    Public Sub consulta_sedeproducto()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from sede_producto", conex)
            adaptador.Fill(dssede_producto)
            dvsede_producto.Table = dssede_producto.Tables(0)

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

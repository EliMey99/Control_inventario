Imports Npgsql

Module Consultas_perdida_producto

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dsperdidaproducto As New DataSet

    Public dvperdidaproducto As New DataView


    Public Sub consulta_perdida_producto()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from perdidas_productos", conex)
            adaptador.Fill(dsperdidaproducto)
            dvperdidaproducto.Table = dsperdidaproducto.Tables(0)

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

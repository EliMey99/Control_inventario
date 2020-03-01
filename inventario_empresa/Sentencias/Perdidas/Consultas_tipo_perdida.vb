Imports Npgsql

Module Consultas_tipo_perdida

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dstipoperdida As New DataSet

    Public dvtipoperdida As New DataView


    Public Sub consulta_tipo_perdida()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from tipo_perdida", conex)
            adaptador.Fill(dstipoperdida)
            dvtipoperdida.Table = dstipoperdida.Tables(0)

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

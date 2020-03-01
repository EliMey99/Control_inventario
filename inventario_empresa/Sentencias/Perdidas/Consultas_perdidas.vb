Imports Npgsql
Module Consultas_perdidas

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dsperdida As New DataSet

    Public dvperdida As New DataView


    Public Sub consulta_perdida()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from perdidas", conex)
            adaptador.Fill(dsperdida)
            dvperdida.Table = dsperdida.Tables(0)

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

Imports Npgsql

Module consultas_sedes

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dssedes As New DataSet

    Public dvsedes As New DataView


    Public Sub consulta_sedes()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from sedes", conex)
            adaptador.Fill(dssedes)
            dvsedes.Table = dssedes.Tables(0)

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

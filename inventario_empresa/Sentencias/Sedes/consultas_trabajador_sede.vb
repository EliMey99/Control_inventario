Imports Npgsql
Module consultas_trabajador_sede

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dstrabajador_sede As New DataSet

    Public dvtrabajador_sede As New DataView


    Public Sub consulta_trabajadorsede()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from trabajador_sede", conex)
            adaptador.Fill(dstrabajador_sede)
            dvtrabajador_sede.Table = dstrabajador_sede.Tables(0)

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

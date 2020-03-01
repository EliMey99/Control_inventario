Imports Npgsql

Module consultas_trabajadores

    Private adaptador As New Npgsql.NpgsqlDataAdapter

    Public dstrabajadores As New DataSet

    Public dvtrabajadores As New DataView


    Public Sub consulta_trabajadores()

        Try
            Conectar()
            'Se prepara la sentencia 
            adaptador.SelectCommand = New NpgsqlCommand("select * from trabajador", conex)
            adaptador.Fill(dstrabajadores)
            dvtrabajadores.Table = dstrabajadores.Tables(0)

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

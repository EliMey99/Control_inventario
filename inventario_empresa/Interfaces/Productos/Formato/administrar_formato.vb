Public Class administrar_formato


    Private Sub administrar_formato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsformatos.Reset()
        consulta_formatos()
        dgvformatos.DataSource = dvformatos
    End Sub

    Private Sub btn_crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_crear.Click

        Dim frm As New crear_formato
        AddHandler frm.FormClosing, AddressOf Crear_formato_FormClosing
        frm.Show()

    End Sub

    Private Sub Crear_formato_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

        dsformatos.Reset()
        consulta_formatos()
        dgvformatos.DataSource = dvformatos

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim datosformatos As New Formatos
        Dim sentencia As New Sentencias_productos

        Dim idformato As String = dgvformatos.Rows(dgvformatos.CurrentRow.Index).Cells(0).Value.ToString

        If (String.IsNullOrEmpty(idformato)) Then
            MessageBox.Show("no ha seleccionado un registro")
        Else


            If MessageBox.Show("Esta Seguro de borrar el registro?", "Borrar Registro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                datosformatos.Id_formato1 = idformato

                If sentencia.Eliminar_formatos(datosformatos) Then
                    MessageBox.Show("Datos Guardados")

                    dsformatos.Reset()
                    consulta_formatos()
                    dgvformatos.DataSource = dvformatos

                Else
                    MessageBox.Show("Error al Guardar")
                End If
            Else



            End If

        End If
    End Sub

    Private Sub dgvformatos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvformatos.CellEndEdit

        'obteniendo datos del datagridview de las columnas 0 y 1 y almacenandolos en variables 
        Dim idformato As String = dgvformatos.Rows(dgvformatos.CurrentRow.Index).Cells(0).Value.ToString
        Dim nombreformato As String = dgvformatos.Rows(dgvformatos.CurrentRow.Index).Cells(1).Value.ToString
        Dim capacidadformato As String = dgvformatos.Rows(dgvformatos.CurrentRow.Index).Cells(2).Value.ToString

        If (String.IsNullOrEmpty(nombreformato)) Then
            MessageBox.Show("Ingrese un nombre para actualizar marca")
        Else

            Dim datosformato As New Formatos
            Dim sentencia As New Sentencias_productos

            datosformato.Id_formato1 = idformato
            datosformato.Nombre_formato1 = nombreformato
            datosformato.Capacidad_formato1 = capacidadformato


            If sentencia.Actualizar_formatos(datosformato) Then
                MessageBox.Show("Datos Guardados")

            Else
                MessageBox.Show("Error al Guardar")
            End If

        End If

    End Sub







End Class
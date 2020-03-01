Public Class tipo_perdida

    Dim id_tipo_perdida As Integer
    Dim nombre_tipo As String

    Public Property Id_tipo_perdida1 As Integer
        Get
            Return id_tipo_perdida
        End Get
        Set(value As Integer)
            id_tipo_perdida = value
        End Set
    End Property

    Public Property Nombre_tipo1 As String
        Get
            Return nombre_tipo
        End Get
        Set(value As String)
            nombre_tipo = value
        End Set
    End Property
End Class

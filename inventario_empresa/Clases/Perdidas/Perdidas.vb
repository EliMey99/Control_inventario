Public Class Perdidas

    Dim id_perdida As Integer
    Dim id_tipo As Integer
    Dim descripcion As String

    Public Property Id_perdida1 As Integer
        Get
            Return id_perdida
        End Get
        Set(value As Integer)
            id_perdida = value
        End Set
    End Property

    Public Property Id_tipo1 As Integer
        Get
            Return id_tipo
        End Get
        Set(value As Integer)
            id_tipo = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
End Class

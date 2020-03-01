Public Class Formatos
    Dim id_formato As Integer
    Dim nombre_formato As String
    Dim capacidad_formato As Integer

    Public Property Id_formato1 As Integer
        Get
            Return id_formato
        End Get
        Set(value As Integer)
            id_formato = value
        End Set
    End Property

    Public Property Nombre_formato1 As String
        Get
            Return nombre_formato
        End Get
        Set(value As String)
            nombre_formato = value
        End Set
    End Property

    Public Property Capacidad_formato1 As Integer
        Get
            Return capacidad_formato
        End Get
        Set(value As Integer)
            capacidad_formato = value
        End Set
    End Property
End Class

Public Class Sedes

    Dim id_sedes As Integer
    Dim calle As String
    Dim numero As Integer

    Public Property Id_sedes1 As Integer
        Get
            Return id_sedes
        End Get
        Set(value As Integer)
            id_sedes = value
        End Set
    End Property

    Public Property Calle1 As String
        Get
            Return calle
        End Get
        Set(value As String)
            calle = value
        End Set
    End Property

    Public Property Numero1 As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property
End Class

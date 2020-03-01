Public Class perdidas_productos

    Dim id_productos_per As Integer
    Dim id_perdidas_pro As Integer
    Dim cantidad_perdida As Integer

    Public Property Id_productos_per1 As Integer
        Get
            Return id_productos_per
        End Get
        Set(value As Integer)
            id_productos_per = value
        End Set
    End Property

    Public Property Id_perdidas_pro1 As Integer
        Get
            Return id_perdidas_pro
        End Get
        Set(value As Integer)
            id_perdidas_pro = value
        End Set
    End Property

    Public Property Cantidad_perdida1 As Integer
        Get
            Return cantidad_perdida
        End Get
        Set(value As Integer)
            cantidad_perdida = value
        End Set
    End Property
End Class

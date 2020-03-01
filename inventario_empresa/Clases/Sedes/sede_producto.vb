Public Class sede_producto
    Dim id_sede_pro As Integer
    Dim id_producto_se As Integer
    Dim cantidad_producto As Integer

    Public Property Id_sede_pro1 As Integer
        Get
            Return id_sede_pro
        End Get
        Set(value As Integer)
            id_sede_pro = value
        End Set
    End Property

    Public Property Id_producto_se1 As Integer
        Get
            Return id_producto_se
        End Get
        Set(value As Integer)
            id_producto_se = value
        End Set
    End Property

    Public Property Cantidad_producto1 As Integer
        Get
            Return cantidad_producto
        End Get
        Set(value As Integer)
            cantidad_producto = value
        End Set
    End Property
End Class

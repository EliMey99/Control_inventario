Public Class productos
    Dim id_producto As Integer
    Dim id_categorias As Integer
    Dim id_marca As Integer
    Dim id_formato As Integer
    Dim nombre_producto As String

    Public Property Id_producto1 As Integer
        Get
            Return id_producto
        End Get
        Set(value As Integer)
            id_producto = value
        End Set
    End Property

    Public Property Id_categorias1 As Integer
        Get
            Return id_categorias
        End Get
        Set(value As Integer)
            id_categorias = value
        End Set
    End Property

    Public Property Id_marca1 As Integer
        Get
            Return id_marca
        End Get
        Set(value As Integer)
            id_marca = value
        End Set
    End Property

    Public Property Id_formato1 As Integer
        Get
            Return id_formato
        End Get
        Set(value As Integer)
            id_formato = value
        End Set
    End Property

    Public Property Nombre_producto1 As String
        Get
            Return nombre_producto
        End Get
        Set(value As String)
            nombre_producto = value
        End Set
    End Property
End Class

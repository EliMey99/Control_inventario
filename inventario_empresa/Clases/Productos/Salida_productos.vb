Public Class Salida_productos

    Dim id_producto_tra As Integer
    Dim id_trabajador_pro As Integer
    Dim fecha_traspaso As Date
    Dim hora_traspaso As Date
    Dim cantidad_producto As Integer

    Public Property Id_producto_tra1 As Integer
        Get
            Return id_producto_tra
        End Get
        Set(value As Integer)
            id_producto_tra = value
        End Set
    End Property

    Public Property Id_trabajador_pro1 As Integer
        Get
            Return id_trabajador_pro
        End Get
        Set(value As Integer)
            id_trabajador_pro = value
        End Set
    End Property

    Public Property Fecha_traspaso1 As Date
        Get
            Return fecha_traspaso
        End Get
        Set(value As Date)
            fecha_traspaso = value
        End Set
    End Property

    Public Property Hora_traspaso1 As Date
        Get
            Return hora_traspaso
        End Get
        Set(value As Date)
            hora_traspaso = value
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

Public Class trabajador_sede

    Dim id_trabajador_se As Integer
    Dim id_sede_tra As Integer
    Dim inicio_jornada As Date
    Dim termino_jornada As Date

    Public Property Id_trabajador_se1 As Integer
        Get
            Return id_trabajador_se
        End Get
        Set(value As Integer)
            id_trabajador_se = value
        End Set
    End Property

    Public Property Id_sede_tra1 As Integer
        Get
            Return id_sede_tra
        End Get
        Set(value As Integer)
            id_sede_tra = value
        End Set
    End Property

    Public Property Inicio_jornada1 As Date
        Get
            Return inicio_jornada
        End Get
        Set(value As Date)
            inicio_jornada = value
        End Set
    End Property

    Public Property Termino_jornada1 As Date
        Get
            Return termino_jornada
        End Get
        Set(value As Date)
            termino_jornada = value
        End Set
    End Property
End Class

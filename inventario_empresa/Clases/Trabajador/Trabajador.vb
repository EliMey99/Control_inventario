Public Class Trabajador

    Dim id_trabajador As Integer
    Dim nombre_trabajador As String
    Dim apellidos_trabajador As String
    Dim rut As String

    Public Property Id_trabajador1 As Integer
        Get
            Return id_trabajador
        End Get
        Set(value As Integer)
            id_trabajador = value
        End Set
    End Property

    Public Property Nombre_trabajador1 As String
        Get
            Return nombre_trabajador
        End Get
        Set(value As String)
            nombre_trabajador = value
        End Set
    End Property

    Public Property Apellidos_trabajador1 As String
        Get
            Return apellidos_trabajador
        End Get
        Set(value As String)
            apellidos_trabajador = value
        End Set
    End Property

    Public Property Rut1 As String
        Get
            Return rut
        End Get
        Set(value As String)
            rut = value
        End Set
    End Property
End Class

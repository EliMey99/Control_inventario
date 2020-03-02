Public Class accesos

    Private id_acceso As Integer
    Private nombre_acceso As String

    Public Property Id_acceso1 As Integer
        Get
            Return id_acceso
        End Get
        Set(value As Integer)
            id_acceso = value
        End Set
    End Property

    Public Property Nombre_acceso1 As String
        Get
            Return nombre_acceso
        End Get
        Set(value As String)
            nombre_acceso = value
        End Set
    End Property

End Class

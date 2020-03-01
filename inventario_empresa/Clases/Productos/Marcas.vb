Public Class Marcas

    Private id_marca As Integer
    Private nombre_marca As String

    Public Property Id_marca1 As Integer
        Get
            Return id_marca
        End Get
        Set(value As Integer)
            id_marca = value
        End Set
    End Property

    Public Property Nombre_marca1 As String
        Get
            Return nombre_marca
        End Get
        Set(value As String)
            nombre_marca = value
        End Set
    End Property
End Class

Public Class usuario

    Private id_usuario As Integer
    Private id_acceso_usuario As Integer
    Private name_user As String
    Private password As String
    Private password2 As String

    Public Property Id_usuario1 As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            id_usuario = value
        End Set
    End Property

    Public Property Id_acceso_usuario1 As Integer
        Get
            Return id_acceso_usuario
        End Get
        Set(value As Integer)
            id_acceso_usuario = value
        End Set
    End Property

    Public Property Name_user1 As String
        Get
            Return name_user
        End Get
        Set(value As String)
            name_user = value
        End Set
    End Property

    Public Property Password1 As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property Password21 As String
        Get
            Return password2
        End Get
        Set(value As String)
            password2 = value
        End Set
    End Property
End Class

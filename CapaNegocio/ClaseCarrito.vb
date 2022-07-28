Public Class ClaseCarrito
    Dim _tablaProductos As DataTable
    Dim _usuario As String



#Region "atributos"

    Public Property TablaProductos As DataTable
        Get
            Return _tablaProductos
        End Get
        Set(value As DataTable)
            _tablaProductos = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

#End Region

#Region "metodos"

    Sub guardarProductos()

    End Sub

    Sub agregarProductos()

    End Sub

#End Region
End Class

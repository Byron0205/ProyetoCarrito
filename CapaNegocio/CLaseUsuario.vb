Public Class CLaseUsuario
    Dim _totalPagar As Integer
    Dim _nombre As String




#Region "atributos"

    Public Property TotalPagar As Integer
        Get
            Return _totalPagar
        End Get
        Set(value As Integer)
            _totalPagar = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

#End Region

#Region "metodo"

    Sub agregarCarrito()

    End Sub

    Sub verificarCarrito()

    End Sub

    Sub iniciarSesion()

    End Sub

    Sub pagar()

    End Sub

#End Region
End Class

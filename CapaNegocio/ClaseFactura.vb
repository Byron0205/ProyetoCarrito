Public Class ClaseFactura
    Dim _totalAPagar As Integer
    Dim _tablaDetalles As DataTable
    Dim _tablaEncabezadoVenta As DataTable
    Dim _tablaDatosCliente As DataTable



#Region "atributos"

    Public Property TotalAPagar As Integer
        Get
            Return _totalAPagar
        End Get
        Set(value As Integer)
            _totalAPagar = value
        End Set
    End Property

    Public Property TablaDetalles As DataTable
        Get
            Return _tablaDetalles
        End Get
        Set(value As DataTable)
            _tablaDetalles = value
        End Set
    End Property

    Public Property TablaEncabezadoVenta As DataTable
        Get
            Return _tablaEncabezadoVenta
        End Get
        Set(value As DataTable)
            _tablaEncabezadoVenta = value
        End Set
    End Property

    Public Property TablaDatosCliente As DataTable
        Get
            Return _tablaDatosCliente
        End Get
        Set(value As DataTable)
            _tablaDatosCliente = value
        End Set
    End Property

#End Region

#Region "metodos"

    Sub mostrarFactura()

    End Sub

    Sub leerDatos()

    End Sub

#End Region
End Class

Imports ConexionBD
Public Class ClaseProducto
    Dim _id As Integer
    Dim _nombre As String
    Dim _descripcion As String
    Dim _precio As Integer
    Dim _disponibles As Integer
    Dim _impuestos As Integer
    Dim _proveedor As String
    Dim _garantía As String
    Dim _tablaProductos As DataTable
    Dim obj_conexion As New ConexionBDClientes
    'Dim row As DataRow

#Region "atributos"

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property

    Public Property Disponibles As Integer
        Get
            Return _disponibles
        End Get
        Set(value As Integer)
            _disponibles = value
        End Set
    End Property

    Public Property Impuestos As Integer
        Get
            Return _impuestos
        End Get
        Set(value As Integer)
            _impuestos = value
        End Set
    End Property

    Public Property Proveedor As String
        Get
            Return _proveedor
        End Get
        Set(value As String)
            _proveedor = value
        End Set
    End Property

    Public Property Garantía As String
        Get
            Return _garantía
        End Get
        Set(value As String)
            _garantía = value
        End Set
    End Property

    Public Property TablaProductos As DataTable
        Get
            Return _tablaProductos
        End Get
        Set(value As DataTable)
            _tablaProductos = value
        End Set
    End Property

#End Region


#Region "metodos"

    Function cargarDatos()
        obj_conexion.LeerDatos()
        TablaProductos = obj_conexion.TablaProductos.Copy()

        Return TablaProductos
    End Function

#End Region

End Class



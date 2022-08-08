Imports ConexionBD
Public Class ClaseLogin
    Dim _idCliente As Integer
    'Dim _usuario As String
    Dim _contrasena As String
    Dim _nombre As String
    Dim _telefono As Integer
    Dim _correo As String
    Dim _tablaUsuarios As DataTable
    Dim obj_Clientes As New ConexionBDClientes


#Region "atributos"

    'Public Property Usuario As String
    '    Get
    '        Return _usuario
    '    End Get
    '    Set(value As String)
    '        _usuario = value
    '    End Set
    'End Property

    Public Property Contrasena As String
        Get
            Return _contrasena
        End Get
        Set(value As String)
            _contrasena = value
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

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property TablaUsuarios As DataTable
        Get
            Return _tablaUsuarios
        End Get
        Set(value As DataTable)
            _tablaUsuarios = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

#End Region

#Region "metodos"

    Sub validarDatos()
        Try
            'If IsNumeric(Usuario) Then
            '    Throw New System.Exception("el usuario no pueden ser numeros")
            'End If
            'If Usuario.Length < 0 Then
            '    Throw New System.Exception("el usuario no puede quedar en blanco")
            'End If
            If Contrasena.Length < 0 Then
                Throw New System.Exception("La contraseña no puede quedar en blanco")
            End If
            If Contrasena.Length < 8 Then
                Throw New System.Exception("La contraseña no puede ser menor a 8 caraceres")
            End If
            If Nombre.Length < 0 Then
                Throw New System.Exception("el nombre no puede quedar en blanco")
            End If
            If Str(Telefono).Length < 0 Then
                Throw New System.Exception("el telefono no puede quedar en blanco")
            End If
            If Not IsNumeric(Telefono) Then
                Throw New System.Exception("el telefono solo debe contener numeros")
            End If
            If Correo.Length < 0 Then
                Throw New System.Exception("el correo no puede quedar en blanco")
            End If


        Catch ex As Exception
            MsgBox("Error al ingresar usuario:" + ex.Message)
        End Try

    End Sub

    Sub guardarDatos()
        obj_Clientes.InsertarCliente(IdCliente, Nombre, Contrasena, Telefono, Correo)

    End Sub

#End Region
End Class

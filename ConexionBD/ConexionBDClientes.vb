Imports System.Data
Imports System.Data.SqlClient
Public Class ConexionBDClientes
    Dim StringConexion As String = "Data Source=Personal;Integrated Security=SSPI; Initial Catalog=Ecomerce"
    Dim conexion As SqlConnection
    Dim miDataSet As New DataSet

#Region "atributos"

    Public Property TablaProductos As DataTable 'propiedad para devolver la tabla que se leyó de bd
        Get
            Return miDataSet.Tables(0)
        End Get
        Set(value As DataTable)

        End Set
    End Property

#End Region

#Region "metodos"

    Sub AbrirConexion()
        Try
            conexion = New SqlConnection(StringConexion)
            conexion.Open()
        Catch ex As Exception
            Throw New System.Exception("Error al abrir la conexion a BD:" + ex.Message)
        End Try
    End Sub

    Sub CerrarConexion()
        Try
            conexion.Close()
        Catch ex As Exception
            Throw New System.Exception("Error al cerrar la conexion a BD:" + ex.Message)
        End Try
    End Sub

    Sub InsertarCliente(idCliente As Integer, nombre As String, contrasena As String, telefono As Integer, correo As String)
        'variable para la instruccion
        Dim sqlInstruccion As SqlClient.SqlCommand

        'Abra la conexion
        AbrirConexion()

        'Se prepara la instruccion SQL 
        sqlInstruccion = New SqlClient.SqlCommand("insert into Clientes(IDCliente, Nombre, Contrasena, Telefono, Correo) values (@IDCliente, @Nombre, @Contrasena, @Telefono, @Correo) ", conexion)

        sqlInstruccion.Parameters.AddWithValue("@IDCliente", idCliente)
        sqlInstruccion.Parameters.AddWithValue("@Nombre", nombre)
        sqlInstruccion.Parameters.AddWithValue("@Contrasena", contrasena)
        sqlInstruccion.Parameters.AddWithValue("@Telefono", telefono)
        sqlInstruccion.Parameters.AddWithValue("@Correo", correo)

        Try
            sqlInstruccion.ExecuteNonQuery()

        Catch ex As Exception
            Throw New System.Exception("Error al ejecutar el insertar" + ex.Message)
        End Try
        CerrarConexion()

    End Sub

    Sub LeerDatos()
        'variable para la instruccion
        Dim sqlInstruccion As SqlClient.SqlCommand
        'me permite recibir datos
        Dim sqlAdapter As SqlClient.SqlDataAdapter

        'Abra la conexion
        AbrirConexion()



        Try

            If miDataSet.Tables.Count > 0 Then
                miDataSet.Tables(0).Clear()
            End If
            'Se prepara la instruccion SQL 
            sqlInstruccion = New SqlClient.SqlCommand("select * from Productos", conexion)

            'ejecucion de la instruccion
            sqlAdapter = New SqlClient.SqlDataAdapter(sqlInstruccion)
            sqlAdapter.Fill(miDataSet)

        Catch ex As Exception
            Throw New System.Exception("Error al ejecutar la lectura de la tabla:" + ex.Message)
        End Try

        'cerramos la conexion
        CerrarConexion()

    End Sub

#End Region

End Class

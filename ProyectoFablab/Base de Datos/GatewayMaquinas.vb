Imports System.Data.SqlClient
''' <summary>
''' Clase que define un gateway para la tabla Maquinas
''' </summary>
Public Class GatewayMaquinas
    ''' <summary>
    ''' Almacena el objeto Connection
    ''' </summary>
    Private conexion As SqlConnection
    ''' <summary>
    ''' Almacena el objeto Command
    ''' </summary>
    Private comando As SqlCommand
    ''' <summary>
    ''' Constructor: crea el objeto de aceso a la base de datos
    ''' </summary>
    Public Sub New(conexion As String)
        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub
    ''' <summary>
    ''' Método para insertar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="modelo">Modelo de la maquina</param>
    ''' <param name="precio_hora">Precio hora de la maquina</param>
    ''' <param name="fecha_compra">Fecha de compra de la maquina</param>
    ''' <param name="telefono_sat">Telefono de servicio tecnico</param>
    ''' <param name="tipo">Tipo de maquina</param>
    ''' <param name="descripcion">Descripcion de la maquina</param>
    ''' <param name="caracteristicas">Caracteristicas de la maquina</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Insertar(modelo As String, precio_hora As Double, fecha_compra As String, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("INSERT INTO Maquinas(modelo,precio_hora,fecha_compra,telefonos_sat,tipo,descripcion,caracteristicas) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)
        'Validamos los datos
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If
        If precio_hora <= 0 Then
            Throw New ArgumentException("El precio debe ser mayor que 0")
        End If
        If fecha_compra = "" Or fecha_compra Is Nothing Then
            Throw New ArgumentException("La fecha no puede estar vacia")
        End If
        If telefono_sat = "" Or telefono_sat Is Nothing Then
        Else
            If (ValidaCadena(telefono_sat, "[0-9]{9}") = False) Then
                Throw New ArgumentException("Si introduces un telefono debe tener 9 numeros")
            End If
        End If
        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas
    End Function
    ''' <summary>
    ''' Método para actualizar un registro en la base de datos
    ''' </summary>
    ''' <param name="id">Identificador del registro</param>
    ''' <param name="modelo">Modelo de la maquina</param>
    ''' <param name="precio_hora">Precio hora de la maquina</param>
    ''' <param name="fecha_compra">Fecha de compra de la maquina</param>
    ''' <param name="telefono_sat">Telefono de servicio tecnico</param>
    ''' <param name="tipo">Tipo de maquina</param>
    ''' <param name="descripcion">Descripcion de la maquina</param>
    ''' <param name="caracteristicas">Caracteristicas de la maquina</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Insertar(id As Integer, modelo As String, precio_hora As Double, fecha_compra As String, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("UPDATE Maquinas SET modelo='{0}',precio_hora='{1}',fecha_compra='{2}',telefonos_sat='{3}',tipo='{4}',descripcion='{5}',caracteristicas='{6}' WHERE id='{7}'", modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas, id)
        'Validamos los datos
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede ser 0")
        End If
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacío")
        End If
        If precio_hora <= 0 Then
            Throw New ArgumentException("El precio debe ser mayor que 0")
        End If
        If fecha_compra = "" Or fecha_compra Is Nothing Then
            Throw New ArgumentException("La fecha no puede estar vacia")
        End If
        If telefono_sat = "" Or telefono_sat Is Nothing Then
        Else
            If (ValidaCadena(telefono_sat, "[0-9]{9}") = False) Then
                Throw New ArgumentException("Si introduces un telefono debe tener 9 numeros")
            End If
        End If
        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas
    End Function
    ''' <summary>
    ''' Método para eliminar un registro de la base de datos
    ''' </summary>
    ''' <param name="id">Identificador del registro</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Eliminar(id As Integer) As Integer

        Dim filas As Integer
        'Creamos la sentencia SQL de eliminación
        Dim consulta As String = String.Format("DELETE FROM Telefonos WHERE id={0})", id)

        'Validamos los datos
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío")
        End If

        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas

    End Function
    ''' <summary>
    ''' Método para seleccionar todos los registros de la tabla
    ''' </summary>
    ''' <returns>Un objeto DataTable con todos los registros</returns>
    Public Function SeleccionarTodos() As DataTable
        'Creamos la sentencia SQL de selección
        Dim consulta As String = String.Format("SELECT * FROM Maquinas")
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()

            'Cargamos el DataTable
            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el resultado
        Return resultado

    End Function
    ''' <summary>
    ''' Método para seleccionar un registro concreto de la tabla por id
    ''' </summary>
    ''' <param name="id">Identificador del registro</param>
    ''' <returns>Un objeto DataTable con el registro seleccionado</returns>
    Public Function SeleccionarId(id As Integer) As DataTable
        'Creamos la sentencia SQL de selección
        Dim consulta As String = String.Format("SELECT * FROM Maquinas WHERE id={0}", id)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        'Validamos los datos
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío")
        End If

        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()

            'Cargamos el DataTable
            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el resultado
        Return resultado

    End Function
    ''' <summary>
    ''' Método para seleccionar registros de la tabla por nombre
    ''' </summary>
    ''' <param name="modelo">Nombre del contacto</param>
    ''' <returns>Un objeto DataTable con los registros seleccionados</returns>
    Public Function SeleccionarModelo(modelo As String) As DataTable
        'Creamos la sentencia SQL de selección
        Dim consulta As String = String.Format("SELECT * FROM Maquinas WHERE nombre='{0}'", modelo)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        'Validamos los datos
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

        'Utilizamos los métodos de la clase de acceso a la BD para ejecutar la consulta
        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()

            'Cargamos el DataTable
            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el resultado
        Return resultado

    End Function
End Class


Imports System.Data.SqlClient
''' <summary>
''' Clase que define un gateway para la tabla TiposMaquina
''' </summary>
Public Class GatewayTipoMaquinas
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
    ''' <param name="tipo">Modelo de la maquina</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Insertar(tipo As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("INSERT INTO Maquinas(modelo) VALUES ('{0}')", tipo)
        'Validamos los datos
        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
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
    ''' Método para actualizar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="id">Identificador del registro</param>
    ''' <param name="tipo">Modelo de la maquina</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Actualizar(id As Integer, tipo As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("UPDATE Maquinas SET tipo='{0}'id='{1}'", tipo, id)

        'Validamos los datos
        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
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
        Dim consulta As String = String.Format("DELETE FROM TiposMaquina WHERE id={0})", id)

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
    ''' Muestra el identificador del tipo de maquina.
    ''' </summary>
    ''' <param name="tipo">Tipo de Maquina.</param>
    ''' <returns>Identificador.</returns>
    Public Function SeleccionarId(tipo As String) As Integer

        Dim consulta As String
        Dim id As Integer
        consulta = String.Format("SELECT id FROM TiposMaquina WHERE tipo='{0}'", tipo)
        Try
            conexion.Open()
            comando.CommandText = consulta
            id = DirectCast(comando.ExecuteScalar(), Integer)

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion Is Nothing) Then
                conexion.Close()
            End If
        End Try

        Return id
    End Function
    ''' <summary>
    ''' Método para seleccionar todos los registros de la tabla
    ''' </summary>
    ''' <returns>Un objeto DataTable con todos los registros</returns>
    Public Function SeleccionarTodos() As DataTable
        'Creamos la sentencia SQL de selección
        Dim consulta As String = String.Format("SELECT * FROM TiposMaquina")
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

End Class

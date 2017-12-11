Imports System.Data.SqlClient
Public Class GatewayTipoUsuario
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(conexion As String)

        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub

    ''' <summary>
    ''' Inserta un nuevo tipo de usuario.
    ''' </summary>
    ''' <param name="tipo">Tipo de usuario.</param>
    ''' <returns>Regresa el número de filas afectadas.</returns>
    Public Function Insertar(tipo As String) As Integer

        Dim consulta As String
        Dim filasAfectadas As Integer

        DatoNoValido(tipo.Trim(), "", "El campo tipo no puede estar vacío.")
        consulta = "INSERT INTO TiposUsuario (tipo) VALUES(@tipo)"
        Try
            conexion.Open()
            comando.Parameters.Add("@tipo", SqlDbType.VarChar)
            comando.Parameters("@tipo").Value = tipo
            comando.CommandText = consulta
            filasAfectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
                comando.Parameters.Clear()
            End If
        End Try

        Return filasAfectadas
    End Function

    ''' <summary>
    ''' Modifica un registro del tipo de usuario a través del identificador.
    ''' </summary>
    ''' <param name="id">Identificador del usuario.</param>
    ''' <param name="tipo">El tipo de usuario para modificar.</param>
    ''' <returns>Regresa el número de filas afectadas.</returns>
    Public Function Actualizar(id As Integer, tipo As String) As Integer
        Dim consulta As String
        Dim filasAfectadas As Integer

        DatoNoValido(id, 0, "El campo id no puede tener valor 0.")
        DatoNoValido(tipo.Trim(), "", "El campo tipo no puede estar vacío.")

        comando.Parameters.Add("@tipo", SqlDbType.VarChar)
        comando.Parameters("@tipo").Value = tipo
        consulta = "UPDATE TiposUsuario SET tipo=@tipo WHERE id=" & id
        Try
            conexion.Open()
            comando.CommandText = consulta
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion Is Nothing) Then
                comando.Parameters.Clear()
                conexion.Close()
            End If
        End Try
        Return filasAfectadas
    End Function

    ''' <summary>
    ''' Elimina un tipo de usuario mediante el identificador.
    ''' </summary>
    ''' <param name="id">Identificador</param>
    ''' <returns>Regresa el número de filas afectadas.</returns>
    Function Eliminar(id As Integer) As Integer

        Dim consulta As String
        Dim filasAfectadas As Integer
        DatoNoValido(id, 0, "El campo id no puede tener valor 0")

        consulta = "DELETE FROM tiposUsuario WHERE id=" & id

        Try
            conexion.Open()
            comando.CommandText = consulta
            filasAfectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return filasAfectadas
    End Function


    ''' <summary>
    ''' Selecciona todos los tipos de usuarios.
    ''' </summary>
    ''' <returns>Regresa un objeto de tipo DataTable con todos los registros.</returns>
    Function SeleccionarTodos() As DataTable

        Dim consulta As String
        Dim lectura As SqlDataReader
        Dim resultado As New DataTable

        consulta = "SELECT * FROM TiposUsuario"

        Try
            conexion.Open()
            comando.CommandText = consulta
            lectura = comando.ExecuteReader()
            resultado.Load(lectura)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            conexion.Close()
        End Try
        Return resultado
    End Function

    ''' <summary>
    ''' Muestra el identificador del tipo de usuario.
    ''' </summary>
    ''' <param name="tipo">Tipo de usuario.</param>
    ''' <returns>Identificador.</returns>
    Public Function SeleccionarId(tipo As String) As Integer

        Dim consulta As String
        Dim id As Integer
        consulta = String.Format("SELECT id FROM TiposUsuario WHERE tipo='{0}'", tipo)
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
End Class

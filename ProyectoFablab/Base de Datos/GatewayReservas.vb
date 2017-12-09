Imports System.Data.SqlClient
Public Class GatewayReservas
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(conexion As String)
        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub

    ''' <summary>
    ''' Registra una reserva.
    ''' </summary>
    ''' <param name="fecha">Fecha de la reserva.</param>
    ''' <param name="hora">Hora de la reserva.</param>
    ''' <param name="usuario">Identificador del usuario.</param>
    ''' <param name="proyecto">Nombre del proyecto.</param>
    ''' <returns>Regresa el número de filas afectadas.</returns>
    Public Function Insertar(fecha As String, hora As String, usuario As Integer, proyecto As String) As Integer

        Dim consulta As String
        Dim filasAfectadas As Integer

        DatoNoValido(fecha.Trim(), "", "El campo fecha no puede estar vacío.")
        DatoNoValido(hora.Trim(), "", "El campo hora no puede estar vacío.")
        DatoNoValido(usuario, 0, "El campo fecha no puede tener valor 0.")

        comando.Parameters.Add("@fecha", SqlDbType.Date)
        comando.Parameters("@fecha").Value = DateTime.Parse(fecha)
        comando.Parameters.Add("@hora", SqlDbType.Time)
        comando.Parameters("@hora").Value = hora
        comando.Parameters.Add("@usuario", SqlDbType.Int)
        comando.Parameters("@usuario").Value = usuario
        comando.Parameters.Add("@proyecto", SqlDbType.VarChar)
        comando.Parameters("@proyecto").Value = IIf(proyecto.Trim().CompareTo("") = 0, DBNull.Value, proyecto)

        consulta = "INSERT INTO Reservas (fecha, hora, usuario, proyecto) VALUES(@fecha,Convert(datetime,@hora), @usuario, @proyecto)"
        Try
            conexion.Open()

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
    ''' Modifica una reserva.
    ''' </summary>
    ''' <param name="id">Identificador.</param>
    ''' <param name="fecha">Fecha de la reserva.</param>
    ''' <param name="hora">Hora de la reserva.</param>
    ''' <param name="usuario">Identificador del usuario.</param>
    ''' <param name="proyecto">Nombre del proyecto.</param>
    ''' <returns>Regresa el número de las filas afectadas.</returns>
    Public Function Actualizar(id As Integer, fecha As String, hora As String, usuario As Integer, proyecto As String) As Integer
        Dim consulta As String
        Dim filasAfectadas As Integer

        DatoNoValido(id, 0, "El campo id no puede tener valor 0.")
        DatoNoValido(fecha.Trim(), "", "El campo fecha no puede estar vacío.")
        DatoNoValido(hora.Trim(), "", "El campo hora no puede estar vacío.")
        DatoNoValido(usuario, 0, "El campo fecha no puede tener valor 0.")


        comando.Parameters.Add("@fecha", SqlDbType.Date)
        comando.Parameters("@fecha").Value = DateTime.Parse(fecha)
        comando.Parameters.Add("@hora", SqlDbType.Time)
        comando.Parameters("@hora").Value = hora
        comando.Parameters.Add("@usuario", SqlDbType.Int)
        comando.Parameters("@usuario").Value = usuario
        comando.Parameters.Add("@proyecto", SqlDbType.VarChar)
        comando.Parameters("@proyecto").Value = IIf(proyecto.Trim().CompareTo("") = 0, DBNull.Value, proyecto)

        consulta = "UPDATE Reservas SET fecha=@fecha, hora=@hora, usuario=@usuario, proyecto=@proyecto WHERE id=" & id
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
    ''' Elimina una reserva.
    ''' </summary>
    ''' <param name="id">Identificador.</param>
    ''' <returns>Regresa el número de las filas afectadas.</returns>
    Function Eliminar(id As Integer) As Integer

        Dim consulta As String
        Dim filasAfectadas As Integer
        DatoNoValido(id, 0, "El campo id no puede tener valor 0")

        consulta = "DELETE FROM Reservas WHERE id=" & id

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
    ''' Selecciona todas las reservas.
    ''' </summary>
    ''' <returns>Regresa un objeto de tipo DataTable con los registros.</returns>
    Function Mostrar() As DataTable

        Dim consulta As String
        Dim lectura As SqlDataReader
        Dim resultado As New DataTable

        consulta = "SELECT * FROM Reservas"

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
    ''' Selecciona las reservas que coincidan con el dato pasado como parámetro.
    ''' </summary>
    ''' <param name="proyecto">Nombre del proyecto.</param>
    ''' <returns>Regresa un objeto de tipo DataTable con los registros. </returns>
    Function MostrarProyecto(proyecto As String) As DataTable

        Dim consulta As String
        Dim lectura As SqlDataReader
        Dim resultado As New DataTable

        consulta = String.Format("SELECT * FROM Reservas WHERE proyecto={0}", proyecto)

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
End Class

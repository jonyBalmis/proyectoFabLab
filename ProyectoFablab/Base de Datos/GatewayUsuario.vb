Imports System.Data.SqlClient

Public Class GatewayUsuario
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(conexion As String)
        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub

    '******************************************************************************
    'INSERTAR, ELIMINAR, ACTUALIZAR Y CONSULTAR
    '******************************************************************************
    ''' <summary>
    ''' Registra un usuario.
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario.</param>
    ''' <param name="apellidos">Apellidos del usuario.</param>
    ''' <param name="fechaNac">Fecha de nacimiento del usuario.</param>
    ''' <param name="telefono">Teléfono del usuario.</param>
    ''' <param name="email">Email del usuario.</param>
    ''' <param name="direccion">Dirección del usuario.</param>
    ''' <param name="organizacion">Organización del usuario.</param>
    ''' <param name="tipo">Tipo de usuario.</param>
    ''' <param name="observaciones">Dato adicional del usuario.</param>
    ''' <returns>Regresa el número de filas afectadas.</returns>
    Public Function Insertar(nombre As String, apellidos As String, fechaNac As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, observaciones As String) As Integer
        Dim filasAfectadas As Integer
        Dim consulta As String
        DatoNoValido(nombre.Trim(), "", "El campo nombre no puede estar vacío.")
        DatoNoValido(apellidos.Trim(), "", "El campo apellidos no puede estar vacío.")
        DatoNoValido(tipo, 0, "El campo tipo no puede tener valor 0.")

        ' If Not Modulos.ValidaCadena(fechaNac, "^([0][1-9]|[1][0-9]|[2][0-9]|[3][0-1])/([0][1-9]|[1][0-2])/\d{4}$") Then
        ' Throw New ArgumentException("El campo fecha no puede estar vacío")
        'End If

        Try
            comando.Parameters.Add("@nombre", SqlDbType.VarChar)
            comando.Parameters("@nombre").Value = nombre
            comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
            comando.Parameters("@apellidos").Value = apellidos
            comando.Parameters.Add("@fechaNac", SqlDbType.Date)
            comando.Parameters("@fechaNac").Value = fechaNac
            comando.Parameters.Add("@telefono", SqlDbType.VarChar)
            comando.Parameters("@telefono").Value = IIf(telefono.Trim().CompareTo("") = 0, DBNull.Value, telefono)
            comando.Parameters.Add("@correo", SqlDbType.VarChar)
            comando.Parameters("@correo").Value = IIf(email.Trim().CompareTo("") = 0, DBNull.Value, email)
            comando.Parameters.Add("@direccion", SqlDbType.VarChar)
            comando.Parameters("@direccion").Value = IIf(direccion.Trim().CompareTo("") = 0, DBNull.Value, direccion)
            comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
            comando.Parameters("@organizacion").Value = IIf(organizacion.Trim().CompareTo("") = 0, DBNull.Value, organizacion)
            comando.Parameters.Add("@tipo", SqlDbType.Int)
            comando.Parameters("@tipo").Value = tipo
            comando.Parameters.Add("@fechaAlta", SqlDbType.Date)
            comando.Parameters("@fechaAlta").Value = DateTime.Today
            comando.Parameters.Add("@observaciones", SqlDbType.Text)
            comando.Parameters("@observaciones").Value = IIf(observaciones.Trim().CompareTo("") = 0, DBNull.Value, observaciones)
            consulta = "INSERT INTO Usuarios ( nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones) VALUES (@nombre,@apellidos,@fechaNac,@telefono,@correo,@direccion,@organizacion,@tipo,@fechaAlta,@observaciones)"

            conexion.Open()
            comando.CommandText = consulta
            filasAfectadas = comando.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)

        Finally
            If conexion IsNot Nothing Then
                comando.Parameters.Clear()
                conexion.Close()
            End If
        End Try
        Return filasAfectadas
    End Function


    ''' <summary>
    ''' Elimina un registro del usuario mediante el identificador.
    ''' </summary>
    ''' <param name="id">Identificador del usuario.</param>
    ''' <returns>Regresa el número de filas afectadas</returns>
    Public Function Eliminar(id As Integer) As Integer
        Dim consulta1 As String
        Dim consulta2 As String
        Dim consultarTabla As String
        Dim filasAfectadas As Integer
        Dim reservas As Integer
        consulta1 = String.Format("DELETE FROM Usuarios WHERE id={0}", id)
        consulta2 = String.Format("DELETE FROM Reservas WHERE usuario={0}", id)

        consultarTabla = String.Format("SELECT COUNT(*) FROM Reservas WHERE id={0}", id)
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío.")
        End If
        Try
            conexion.Open()
            comando.CommandText = consultarTabla
            reservas = DirectCast(comando.ExecuteScalar(), Integer)
            If reservas > 0 Then
                comando.CommandText = consulta2
                comando.ExecuteNonQuery()
                comando.CommandText = consulta1
                filasAfectadas = comando.ExecuteNonQuery()
            Else
                comando.CommandText = consulta1
                filasAfectadas = comando.ExecuteNonQuery()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try
        Return filasAfectadas
    End Function


    ''' <summary>
    ''' Modifica los datos de un usuario mediante el identificador.
    ''' </summary>
    ''' <param name="id">Identificador del usuario.</param>
    ''' <param name="nombre">Nombre del usuario.</param>
    ''' <param name="apellidos">Apellidos del usuario.</param>
    ''' <param name="fechaNac">Fecha de nacimiento del usuario.</param>
    ''' <param name="telefono">Teléfono del usuario.</param>
    ''' <param name="email">Email del usuario.</param>
    ''' <param name="direccion">Dirección del usuario.</param>
    ''' <param name="organizacion">Organización del usuario.</param>
    ''' <param name="tipo">Tipo de usuario.</param>
    ''' ''' <param name="observaciones">Dato adicional del usuario.</param>
    ''' <returns>Devuelve el número de filas afectadas.</returns>
    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fechaNac As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, observaciones As String) As Integer
        Dim consulta As String
        Dim filasAfectadas As Integer
        DatoNoValido(nombre.Trim(), "", "El campo nombre no puede estar vacío.")
        DatoNoValido(apellidos.Trim(), "", "El campo apellidos no puede estar vacío.")
        DatoNoValido(tipo, 0, "El campo tipo no puede no puede tener valor 0.")
        '  If Not Modulo.ValidaCadena(fechaNac, "^([0][1-9]|[1][0-9]|[2][0-9]|[3][0-1])/([0][1-9]|[1][0-2])/\d{4}$") Then
        ' Throw New ArgumentException("El campo fecha no puede estar vacío")
        'End If
        comando.Parameters.Add("@nombre", SqlDbType.VarChar)
        comando.Parameters("@nombre").Value = nombre
        comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
        comando.Parameters("@apellidos").Value = apellidos
        comando.Parameters.Add("@fechaNac", SqlDbType.Date)
        comando.Parameters("@fechaNac").Value = fechaNac
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters("@telefono").Value = IIf(telefono.Trim().CompareTo("") = 0, DBNull.Value, telefono)
        comando.Parameters.Add("@correo", SqlDbType.VarChar)
        comando.Parameters("@correo").Value = IIf(email.Trim().CompareTo("") = 0, DBNull.Value, email)
        comando.Parameters.Add("@direccion", SqlDbType.VarChar)
        comando.Parameters("@direccion").Value = IIf(direccion.Trim().CompareTo("") = 0, DBNull.Value, direccion)
        comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
        comando.Parameters("@organizacion").Value = IIf(organizacion.Trim().CompareTo("") = 0, DBNull.Value, organizacion)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = tipo
        comando.Parameters.Add("@observaciones", SqlDbType.Text)
        comando.Parameters("@observaciones").Value = IIf(observaciones.Trim().CompareTo("") = 0, DBNull.Value, observaciones)
        consulta = "UPDATE Usuarios SET nombre=@nombre, apellidos=@apellidos, fecha_nacimiento=@fechaNac, telefono=@telefono, email=@correo, direccion=@direccion, organizacion=@organizacion, tipo=@tipo,observaciones=@observaciones WHERE id=" & id
        Try
            conexion.Open()
            comando.CommandText = consulta
            filasAfectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            comando.Parameters.Clear()
            conexion.Close()
        End Try
        Return filasAfectadas
    End Function


    ''' <summary>
    ''' Selecciona todos los usuarios y tipos.
    ''' </summary>
    ''' <returns>Regresa todos los registros en un objeto dataTable.</returns>
    Public Function SeleccionarTodos() As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        consulta = "SELECT * FROM Usuarios INNER JOIN TiposUsuario ON Usuarios.tipo= TiposUsuario.id"
        Try
            conexion.Open()
            comando.CommandText = consulta
            lectura = comando.ExecuteReader()
            resultado.Load(lectura)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return resultado
    End Function

    ''' <summary>
    ''' Cuenta el número total de usuarios.
    ''' </summary>
    ''' <returns>Devuelve el número de registros de la base de datos.</returns>
    Public Function Contar() As Integer
        Dim consulta As String
        Dim resultado As Integer
        consulta = "SELECT COUNT(*) FROM Usuarios"
        Try
            conexion.Open()
            comando.CommandText = consulta
            resultado = DirectCast(comando.ExecuteScalar(), Integer)
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return resultado
    End Function

    ''' <summary>
    ''' Selecciona los usuarios con el mismo nombre pasado como parámetro.
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario.</param>
    ''' <returns>Regresa un objeto DataTable con los datos del usuario. </returns>
    Public Function SeleccionarNombre(nombre As String) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        DatoNoValido(nombre.Trim(), "", "El campo nombre no puede estar vacío.")
        consulta = String.Format("SELECT * FROM usuarios WHERE nombre='{0}' AND apellido={}", nombre)
        Try
            conexion.Open()
            comando.CommandText = consulta
            lectura = comando.ExecuteReader()
            resultado.Load(lectura)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return resultado
    End Function


    ''' <summary>
    ''' Selecciona un usuario mediante el identificador.
    ''' </summary>
    ''' <param name="id">Identificador del usuario</param>
    ''' <returns>Retorna un objeto datable con los datos del usuario.</returns>
    Public Function SeleccionarId(id As Integer) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        DatoNoValido(id, 0, "El campo id no puede tener valor 0,")
        consulta = "SELECT * FROM usuarios WHERE id=" & id
        Try
            conexion.Open()
            comando.CommandText = consulta
            lectura = comando.ExecuteReader()
            resultado.Load(lectura)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
        Return resultado
    End Function


End Class
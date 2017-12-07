Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class GatewayUsuario
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(ByRef conexion As String)
        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub

    '******************************************************************************
    'FUNCIONES Y PROCEDIMIENTOS PRIVADOS
    '******************************************************************************
    ''' <summary>
    ''' Comprueba que el dato pasado como parámetro, no este vacío y no sea nulo.
    ''' </summary>
    ''' <param name="dato">Cadena a comprobar.</param>
    ''' <param name="mensaje">Mensaje de error a mostrar cuando el dato está vacío o es nulo.</param>
    Private Sub CampoVacio(ByVal dato As String, ByVal mensaje As String)
        If dato.Trim().CompareTo("") = 0 Or dato Is Nothing Then
            Throw New ArgumentException(mensaje)
        End If
    End Sub


    ''' <summary>
    ''' Comprueba si el dato pasado como parámetro, es un número de teléfono de 9 dígitos.
    ''' </summary>
    ''' <param name="telefono">Número de teléfono.</param>
    Private Sub ComprobarTelefono(ByVal telefono As String)
        Dim telefonoCorrecto As New Regex("[0-9]{9}")
        If Not telefonoCorrecto.IsMatch(telefono) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos.")
        End If
    End Sub


    ''' <summary>
    ''' Comprueba si el dato pasado como parámetro, es un correo electrónico.
    ''' </summary>
    ''' <param name="correo">Correo elétronico.</param>
    Private Sub ComprobarCorreo(ByVal correo As String)
        Dim correoCorrecto As New Regex("^\w+@\w+.[a-z]{3}$")
        If Not correoCorrecto.IsMatch(correo) Then
            Throw New ArgumentException("Introduce un correo válido.")
        End If
    End Sub


    ''' <summary>
    ''' Procedimiento que obliga a introducir un número de teléfono, un correo o una de las dos formas de contacto.
    ''' </summary>
    ''' <param name="telefono">Numero de teléfono.</param>
    ''' <param name="correo">Correo eléctronico.</param>
    Private Sub ContactoObligatorio(ByVal telefono As String, ByVal correo As String)
        If Not telefono.Trim().Equals("") And Not correo.Trim().Equals("") Then
            ComprobarTelefono(telefono)
            ComprobarCorreo(correo)
        ElseIf Not telefono.Trim().Equals("") Then
            ComprobarTelefono(telefono)
        ElseIf Not correo.Trim().Equals("") Then
            ComprobarCorreo(correo)
        Else
            Throw New ArgumentException("No hay ningún dato de contacto.")
        End If
    End Sub


    ''' <summary>
    ''' Función que comprueba si el dato pasado como parámetro, está vacío.
    ''' </summary>
    ''' <param name="cadena">Dato a comprobar.</param>
    ''' <returns>Regresa true o false.</returns>
    Private Function CampoEsNulo(ByVal cadena As String) As Boolean
        If cadena.Trim().CompareTo("") = 0 Then
            Return True
        End If
        Return False
    End Function

    '******************************************************************************
    '******************************************************************************


    '******************************************************************************
    'INSERTAR, ELIMINAR, ACTUALIZAR Y CONSULTAR
    '******************************************************************************
    ''' <summary>
    ''' Inserta un registro en la base de datos.
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
    Public Function InsertarUsuario(nombre As String, apellidos As String, fechaNac As String, telefono As String, email As String, direccion As String, organizacion As String, tipo As String, observaciones As String) As Integer
        Dim filasAfectadas As Integer
        Dim consulta As String
        CampoVacio(nombre, "El campo nombre no puede estar vacío.")
        CampoVacio(apellidos, "El campo apellidos no puede estar vacío.")
        CampoVacio(fechaNac, "El campo fecha no puede estar vacío.")
        CampoVacio(tipo, "El campo tipo no puede estar vacío.")
        ContactoObligatorio(telefono, email)
        comando.Parameters.Add("@nombre", SqlDbType.VarChar)
        comando.Parameters("@nombre").Value = nombre
        comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
        comando.Parameters("@apellidos").Value = apellidos
        comando.Parameters.Add("@fechaNac", SqlDbType.Date)
        comando.Parameters("@fechaNac").Value = DateTime.Parse(fechaNac)
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters("@telefono").Value = IIf(CampoEsNulo(telefono), DBNull.Value, telefono)
        comando.Parameters.Add("@correo", SqlDbType.VarChar)
        comando.Parameters("@correo").Value = IIf(CampoEsNulo(email), DBNull.Value, email)
        comando.Parameters.Add("@direccion", SqlDbType.VarChar)
        comando.Parameters("@direccion").Value = IIf(CampoEsNulo(direccion), DBNull.Value, direccion)
        comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
        comando.Parameters("@organizacion").Value = IIf(CampoEsNulo(organizacion), DBNull.Value, organizacion)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = Integer.Parse(tipo)
        comando.Parameters.Add("@fechaAlta", SqlDbType.Date)
        comando.Parameters("@fechaAlta").Value = DateTime.Today
        comando.Parameters.Add("@observaciones", SqlDbType.Text)
        comando.Parameters("@observaciones").Value = IIf(CampoEsNulo(observaciones), DBNull.Value, observaciones)
        consulta = "INSERT INTO Usuarios ( nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones) VALUES (@nombre,@apellidos,@fechaNac,@telefono,@correo,@direccion,@organizacion,@tipo,@fechaAlta,@observaciones)"
        Try
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
    ''' Elimina un registro de la base de datos.
    ''' </summary>
    ''' <param name="id">Identificador del usuario.</param>
    ''' <returns>Regresa el número de filas afectadas</returns>
    Public Function EliminarUsuario(id As Integer) As Integer
        Dim consulta As String
        Dim filasAfectadas As Integer
        consulta = String.Format("DELETE FROM Usuarios WHERE id={0}", id)
        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío.")
        End If
        Try
            conexion.Open()
            comando.CommandText = consulta
            filasAfectadas = comando.ExecuteNonQuery()
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
    ''' Modifica los datos de un registro.
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
    Public Function ActualizarUsuario(id As Integer, nombre As String, apellidos As String, fechaNac As String, telefono As String, email As String, direccion As String, organizacion As String, tipo As String, observaciones As String) As Integer
        Dim consulta As String
        Dim filasAfectadas As Integer
        CampoVacio(nombre, "El campo nombre no puede estar vacío.")
        CampoVacio(apellidos, "El campo apellidos no puede estar vacío.")
        CampoVacio(fechaNac, "El campo fecha no puede estar vacío.")
        CampoVacio(tipo, "El campo tipo no puede estar vacío.")
        ContactoObligatorio(telefono, email)
        comando.Parameters.Add("@nombre", SqlDbType.VarChar)
        comando.Parameters("@nombre").Value = nombre
        comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
        comando.Parameters("@apellidos").Value = apellidos
        comando.Parameters.Add("@fechaNac", SqlDbType.Date)
        comando.Parameters("@fechaNac").Value = DateTime.Parse(fechaNac)
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters("@telefono").Value = IIf(CampoEsNulo(telefono), DBNull.Value, telefono)
        comando.Parameters.Add("@correo", SqlDbType.VarChar)
        comando.Parameters("@correo").Value = IIf(CampoEsNulo(email), DBNull.Value, email)
        comando.Parameters.Add("@direccion", SqlDbType.VarChar)
        comando.Parameters("@direccion").Value = IIf(CampoEsNulo(direccion), DBNull.Value, direccion)
        comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
        comando.Parameters("@organizacion").Value = IIf(CampoEsNulo(organizacion), DBNull.Value, organizacion)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters("@tipo").Value = Integer.Parse(tipo)
        comando.Parameters.Add("@observaciones", SqlDbType.Text)
        comando.Parameters("@observaciones").Value = IIf(CampoEsNulo(observaciones), DBNull.Value, observaciones)
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
    ''' Selecciona todos los registros de la tabla.
    ''' </summary>
    ''' <returns>Regresa todos los registros en un objeto dataTable.</returns>
    Public Function MostrarRegistros() As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        consulta = "SELECT * FROM usuarios"
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
    ''' Muestra el número total de registros.
    ''' </summary>
    ''' <returns>Devuelve el número de registros de la base de datos.</returns>
    Public Function ContarUsuarios() As Integer
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
    ''' Muestra el registro de un usuario por nombre.
    ''' </summary>
    ''' <param name="nombre">Nombre del usuario.</param>
    ''' <returns>Regresa un objeto DataTable con los datos del usuario. </returns>
    Public Function MostrarRegistroPorNombre(ByVal nombre As String) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        CampoVacio(nombre, "El campo nombre no puede estar vacío.")
        consulta = String.Format("SELECT * FROM usuarios WHERE nombre='{0}'", nombre)
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
    ''' Muestra el registro de un usuario por id.
    ''' </summary>
    ''' <param name="id">Identificador del usuario</param>
    ''' <returns>Retorna un objeto datable con los datos del usuario.</returns>
    Public Function MostrarRegistroPorId(ByVal id As Integer) As DataTable
        Dim consulta As String
        Dim resultado As New DataTable
        Dim lectura As SqlDataReader
        If id = 0 Then
            Throw New ArgumentException("El parámetro id no puede tener valor 0.")
        End If
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

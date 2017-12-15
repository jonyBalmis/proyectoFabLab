Module TipoUsuario

    ''' <summary>
    ''' Obtiene los tipos de usuarios.
    ''' </summary>
    ''' <returns>Un objedto de tipo dataTable.</returns>
    Public Function SeleccionarTipos() As DataTable
        Dim tipos As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)

        Return tipos.SeleccionarTodos()
    End Function

    ''' <summary>
    ''' Registra un tipo en la base de datos.
    ''' </summary>
    ''' <param name="nuevo">Nuevo tipo.</param>
    ''' <returns>Valor booleano</returns>
    Public Function InsertarTipo(nuevo As String) As Boolean

        Dim tipo As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)
        Try
            tipo.Insertar(nuevo)
            Return True
        Catch ex As ArgumentException
            Throw New ArgumentException(ex.Message)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return False

    End Function

    ''' <summary>
    ''' Metodo que devuelve el tipo de usuario.
    ''' </summary>
    ''' <param name="id">Identificador del usuario</param>
    ''' <returns>Tipo de usuario</returns>
    Public Function SeleccionarTipo(id As Integer) As String
        Dim tipo As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)
        Return tipo.SeleccionarTipo(id)
    End Function
End Module

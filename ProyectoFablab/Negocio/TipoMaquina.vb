Module TipoMaquina
    ''' <summary>
    ''' Método para insertar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="tipo">Modelo de la maquina</param>
    Public Function InsertarTipo(tipo As String) As Boolean
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)

        If tipo Is Nothing Or tipo.Equals("") Then
            Throw New ApplicationException("No se puede añadir un tipo vacio")
            Return False
        Else
            gateway.Insertar(tipo)
        End If
        Return True

    End Function
    ''' <summary>
    ''' Método para actualizar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="id">Identificador</param>
    ''' <param name="tipo">Modelo de la maquina</param>
    Public Function ActualizarTipo(id As Integer, tipo As String) As Boolean
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)

        If tipo Is Nothing Or tipo.Equals("") Then
            Throw New ApplicationException("No se puede añadir un tipo vacio")
            Return False
        Else
            gateway.Actualizar(id, tipo)
        End If
        Return True

    End Function
    ''' <summary>
    ''' Obtiene un DataTable con todos los tipos de maquinas de la base de datos
    ''' </summary>
    ''' <returns>DataTable con las maquinas</returns>
    Public Function ObtenerMaquinas() As DataTable
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarTodos()
    End Function
    ''' <summary>
    ''' Obtiene tipo de maquina a partir de su nombre
    ''' </summary>
    ''' <param name="tipo">Tipo de máquina a obtener</param>
    ''' <returns>Devuelve un ID (entero) de la máquina </returns>
    Public Function ObtieneMaquinaPorNombre(tipo As String) As Integer
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarId(tipo)
    End Function
    ''' <summary>
    ''' Borra un tipo de maquina con un ID
    ''' </summary>
    ''' <param name="id">Identificador tipo de maquina a borrar</param>
    Public Sub BorrarMaquina(id As Integer)
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)
        gateway.Eliminar(id)
    End Sub
End Module

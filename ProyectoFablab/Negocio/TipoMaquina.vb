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
    ''' Obtiene un DataTable con todas las maquinas de la base de datos
    ''' </summary>
    ''' <returns>DataTable con las maquinas</returns>
    Public Function ObtenerMaquinas() As DataTable
        Dim gateway As New GatewayTipoMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarTodos()
    End Function
End Module

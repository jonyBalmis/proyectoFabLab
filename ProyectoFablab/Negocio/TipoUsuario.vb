Module TipoUsuario
    Public Function SeleccionarTipos() As DataTable
        Dim tipos As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)

        Return tipos.SeleccionarTodos()
    End Function

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
End Module

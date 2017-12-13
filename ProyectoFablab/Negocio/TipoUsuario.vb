Module TipoUsuario
    Public Function SeleccionarTipos() As DataTable
        Dim tipos As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)

        Return tipos.SeleccionarTodos()
    End Function
End Module

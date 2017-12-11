Module Negocio

    Public Sub InsertarUsuario(nombre As String, apellidos As String, fecha_nacimiento As String, telefono As String, email As String, direccion As String, organizacion As String, tipo As String, observaciones As String)
        Dim filasAfectadas As Integer
        Dim gatewayTipo As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.conexion)
        Dim gatewayUsuario As GatewayUsuario = New GatewayUsuario(My.Settings.conexion)
        Dim tipoId As Integer = gatewayTipo.SeleccionarId(tipo)


        Try
            filasAfectadas = gatewayUsuario.Insertar(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipoId, observaciones)

        Catch ex As ArgumentException
            Throw New ArgumentException(ex.Message, ex)
        End Try

    End Sub


    Public Function TiposUsuarios() As DataTable
        Dim tipos As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.conexion)

        Return tipos.SeleccionarTodos()
    End Function

End Module

﻿Module Usuario

    ''' <summary>
    ''' Procedimiento que obliga a introducir un número de teléfono, un correo o una de las dos formas de contacto.
    ''' </summary>
    ''' <param name="telefono">Numero de teléfono.</param>
    ''' <param name="correo">Correo eléctronico.</param>
    Private Sub ContactoObligatorio(ByVal telefono As String, ByVal correo As String)
        Dim mensajeFono As String = "El teléfono debe contener 9 dígitos."
        Dim mensajeCorreo As String = "Introduce un correo válido."
        Dim patronFono As String = "[0-9]{9}"
        Dim patronCorreo As String = "^\w+@\w+.[a-z]{3}$"
        If Not telefono.Trim().Equals("") And Not correo.Trim().Equals("") Then
            If Not ValidaCadena(telefono, patronFono) Then
                Throw New ArgumentException(mensajeFono)
            End If
            If Not ValidaCadena(correo, patronCorreo) Then
                Throw New ArgumentException(mensajeCorreo)
            End If
        ElseIf Not telefono.Trim().Equals("") Then
            If Not ValidaCadena(telefono, patronFono) Then
                Throw New ArgumentException(mensajeFono)
            End If
        ElseIf Not correo.Trim().Equals("") Then
            If Not ValidaCadena(correo, patronCorreo) Then
                Throw New ArgumentException(mensajeCorreo)
            End If
        Else
            Throw New ArgumentException("No hay ningún dato de contacto.")
        End If
    End Sub

    Public Sub Insertar(nombre As String, apellidos As String, fechaNac As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As String, observaciones As String)
        Dim filasAfectadas As Integer
        Try
            Dim gatewayTipo As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)
            Dim gatewayUsuario As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)
            Dim tipoId As Integer = gatewayTipo.SeleccionarId(tipo)
            ContactoObligatorio(telefono, email)
            filasAfectadas = gatewayUsuario.Insertar(nombre, apellidos, fechaNac, telefono, email, direccion, organizacion, tipoId, observaciones)

        Catch ex As ArgumentException
            Throw New ArgumentException(ex.Message, ex)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

    End Sub

    ''' <summary>
    ''' Obtiene el identificador de la última fila. 
    ''' </summary>
    ''' <returns>Identificador.</returns>
    Public Function ObtenerUltimoId() As Integer
        Dim gatewayUsuario As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)
        Dim total As Integer = gatewayUsuario.SeleccionarTodos().Rows.Count
        Dim ultimaFila As DataRow = gatewayUsuario.SeleccionarTodos().Rows.Item(total - 1)
        Return DirectCast(ultimaFila.Item(0), Integer)
    End Function

    Public Function SeleccionarUsuarios() As DataTable
        Dim usuarios As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)
        Return usuarios.SeleccionarTodos()
    End Function

    Public Function ActualizarUsuario(id As Integer, nombre As String, apellidos As String, fechaNac As DateTime, telefono As String, email As String, direccion As String, organizacion As String, tipo As String, observaciones As String) As Boolean
        Try
            Dim gatewayTipo As GatewayTipoUsuario = New GatewayTipoUsuario(My.Settings.Conexion)
            Dim actualizar As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)
            Dim tipoId As Integer = gatewayTipo.SeleccionarId(tipo)
            ContactoObligatorio(telefono, email)
            actualizar.Actualizar(id, nombre, apellidos, fechaNac, telefono, email, direccion, organizacion, tipoId, observaciones)
        Catch ex As ArgumentException
            Throw New ArgumentException(ex.Message, ex)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
        Return True
    End Function


    Public Function EliminarUsuario(id As Integer) As Boolean
        Dim eliminar As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)

        Try
            If eliminar.Eliminar(id) > 0 Then
                Return True
            End If
        Catch ex As ArgumentException
            Throw New ArgumentException(ex.Message, ex)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try

        Return False
    End Function

    Public Function ContarUsuarios() As Integer
        Dim total As GatewayUsuario = New GatewayUsuario(My.Settings.Conexion)

        Return total.Contar()
    End Function
End Module

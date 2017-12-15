Module Maquinas
    ''' <summary>
    ''' Inserta una nueva maquina en la base de datos
    ''' </summary>
    ''' <param name="modelo">Modelo de la maquina</param>
    ''' <param name="precio_hora">Precio hora de la maquina</param>
    ''' <param name="fecha_compra">Fecha de compra de la maquina</param>
    ''' <param name="telefono_sat">Telefono de servicio tecnico</param>
    ''' <param name="tipo">Tipo de maquina</param>
    ''' <param name="descripcion">Descripcion de la maquina</param>
    ''' <param name="caracteristicas">Caracteristicas de la maquina</param>
    Public Sub Insertar(modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As String, descripcion As String, caracteristicas As String)
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Dim gatewaytipo As New GatewayTipoMaquinas(My.Settings.Conexion)
        Dim tipom As Integer = gatewaytipo.SeleccionarId(tipo)
        If precio_hora <= 0 Then
            Throw New ArgumentException("El precio por hora tiene que ser mayor que 0")
        End If
        If ComprobarRepetidos(modelo, fecha_compra) = False Then
            Throw New ArgumentException("No puede haber dos modelos iguales con la misma fecha de compra")
        End If
        gateway.Insertar(modelo, precio_hora, fecha_compra, telefono_sat, tipom, descripcion, caracteristicas)


    End Sub
    ''' <summary>
    ''' Actualiza una  maquina en la base de datos
    ''' </summary>
    ''' <param name="id">Identificador</param>
    ''' <param name="modelo">Modelo de la maquina</param>
    ''' <param name="precio_hora">Precio hora de la maquina</param>
    ''' <param name="fecha_compra">Fecha de compra de la maquina</param>
    ''' <param name="telefono_sat">Telefono de servicio tecnico</param>
    ''' <param name="tipo">Tipo de maquina</param>
    ''' <param name="descripcion">Descripcion de la maquina</param>
    ''' <param name="caracteristicas">Caracteristicas de la maquina</param>
    Public Sub Actualizar(id As Integer, modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As String, descripcion As String, caracteristicas As String)
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Dim gatewaytipo As New GatewayTipoMaquinas(My.Settings.Conexion)
        Dim tipom As Integer = gatewaytipo.SeleccionarId(tipo)
        If precio_hora <= 0 Then
            Throw New ArgumentException("El precio por hora tiene que ser mayor que 0")
        End If
        If ComprobarRepetidos(modelo, fecha_compra) = False Then
            Throw New ArgumentException("No puede haber dos modelos iguales con la misma fecha de compra")
        End If
        gateway.Actualizar(id, modelo, precio_hora, fecha_compra, telefono_sat, tipom, descripcion, caracteristicas)


    End Sub
    ''' <summary>
    ''' Borra una máquina con el ID
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub Eliminar(id As Integer)
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        gateway.Eliminar(id)
    End Sub
    ''' <summary>
    ''' Comprobar que no hay dos maquinas del mismo modelo con la misma fecha de compra
    ''' </summary>
    ''' <param name="modelo">Modelo de la maquina</param>
    ''' <param name="fecha_compra"> Fecha de compra de la amquina</param>
    Public Function ComprobarRepetidos(modelo As String, fecha_compra As Date) As Boolean
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Dim tabla As DataTable
        tabla = gateway.SeleccionarTodos()
        For Each maquina As DataRow In tabla.Rows
            Dim fecha As Date
            fecha = DirectCast(maquina("fecha_compra"), Date)
            If maquina("modelo") Is modelo AndAlso fecha.CompareTo(fecha_compra) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function
    ''' <summary>
    ''' Obtiene un DataTable con todas las maquinas de la base de datos
    ''' </summary>
    ''' <returns>DataTable con las maquinas</returns>
    Public Function ObtenerMaquinas() As DataTable
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarTodos()
    End Function
    ''' <summary>
    ''' Obtiene el número de máquinas de la base de datos
    ''' </summary>
    ''' <returns>Numero de máquinas</returns>
    Public Function NumeroMaquinas() As Integer
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Return gateway.NumeroMaquinas()
    End Function
    ''' <summary>
    ''' Obtiene un datatable con la maquina del id 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns>DataTable con la máquina seleccionada por ID</returns>
    Public Function ObtenerMaquinaPorId(id As Integer) As DataTable
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarId(id)
    End Function
    ''' <summary>
    ''' Obtenemos el último Id de la tabla de maquinas
    ''' </summary>
    ''' <returns>Id de la ultima maquina</returns>
    Public Function ObtenerUltimoIdMaquina() As Integer
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        Return gateway.SeleccionarUltimoIdMaquina()
    End Function

End Module
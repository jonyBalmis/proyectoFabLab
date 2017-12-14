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
    Public Sub InsertarTelefono(modelo As String, precio_hora As Double, fecha_compra As Date, telefono_sat As String, tipo As Integer, descripcion As String, caracteristicas As String)
        Dim gateway As New GatewayMaquinas(My.Settings.Conexion)
        If precio_hora <= 0 Then
            Throw New ArgumentException("El precio por hora tiene que ser mayor que 0")
        End If
        If ComprobarRepetidos(modelo, fecha_compra) = False Then
            Throw New ArgumentException("No puede haber dos modelos iguales con la misma fecha de compra")
        End If
        gateway.Insertar(modelo, precio_hora, fecha_compra, telefono_sat, tipo, descripcion, caracteristicas)


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
            fecha = DirectCast(maquina("fechaCompra"), Date)
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
End Module
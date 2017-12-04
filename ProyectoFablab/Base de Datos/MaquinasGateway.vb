Imports System.Data.SqlClient
''' <summary>
''' Clase que define un gateway para la tabla Maquinas
''' </summary>
Public Class MaquinasGateway
    ''' <summary>
    ''' Almacena el objeto Connection
    ''' </summary>
    Private conexion As SqlConnection
    ''' <summary>
    ''' Almacena el objeto Command
    ''' </summary>
    Private comando As SqlCommand
    ''' <summary>
    ''' Constructor: crea el objeto de aceso a la base de datos
    ''' </summary>
    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand()
        comando.Connection = conexion
    End Sub
    ''' <summary>
    ''' Método para insertar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="modelo">Nombre del modelo de la maquina</param>
    ''' <param name="precio">Precio Hora</param>
    ''' <param name="fecha">Fecha de compra</param>
    ''' <param name="observaciones">Observaciones</param>
    ''' <returns>Número de filas afectadas por la consulta</returns>
    Public Function Insertar(modelo As String, precio As Integer, fecha As Date, observaciones As String) As Integer

        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("INSERT INTO Maquinas(modelo,precio,telefono,observaciones) VALUES ('{0}','{1}','{2}','{3}')", modelo, precio, fecha.ToString, observaciones)

        'Validamos los datos
        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

        If telefono = "" Or telefono Is Nothing Then
            Throw New ArgumentException("El telefono no puede estar vacío")
        End If

        Dim er As New System.Text.RegularExpressions.Regex("[0-9]{9}")
        If Not er.IsMatch(telefono) Then
            Throw New ArgumentException("El teléfono debe contener 9 dígitos")
        End If

        'Ejecutamos la consulta
        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas

    End Function



End Class

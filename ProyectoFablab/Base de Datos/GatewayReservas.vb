Imports System.Data.SqlClient
Public Class GatewayReservas
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(conexion As String)
        Me.conexion = New SqlConnection(conexion)
        comando = New SqlCommand()
        comando.Connection = Me.conexion
    End Sub

    ''' <summary>
    ''' Cuenta el número de reservas que tiene un usuario
    ''' </summary>
    ''' <param name="id">Identificador del usuario.</param>
    ''' <returns>Total de reservas</returns>
    Public Function ContarReservasId(id As Integer) As Integer
        Dim total As Integer
        Dim consulta As String

        Try
            conexion.Open()
            consulta = "SELECT COUNT(*) FROM Reservas WHERE usuario=" & id
            comando.CommandText = consulta
            total = DirectCast(comando.ExecuteScalar(), Integer)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If conexion IsNot Nothing Then
                conexion.Close()
            End If
        End Try

        Return total
    End Function


End Class

﻿Imports System.Text.RegularExpressions
Module Modulos
    ''' <summary>
    ''' Procedimiento que lanza una excepcion cuando el primer parámetro es igual al segundo.
    ''' </summary>
    ''' <param name="dato">Dato válido.</param>
    ''' <param name="valorNulo">Dato inválido.</param>
    ''' <param name="mensaje">Mensaje de error a mostrar cuando el dato está vacío o es nulo.</param>
    Public Sub DatoNoValido(Of T As IComparable)(ByVal dato As T, ByVal valorNulo As T, ByVal mensaje As String)
        If dato.CompareTo(valorNulo) = 0 Or dato Is Nothing Then
            Throw New ArgumentException(mensaje)
        End If
    End Sub

    ''' <summary>
    ''' Función que comprueba si una cadena es válida según su patrón.
    ''' </summary>
    ''' <param name="cadena">Texto para comprobar.</param>
    '''  <param name="patron">Expresión.</param>
    '''   <returns>Regresa un boolean.</returns>
    Public Function ValidaCadena(cadena As String, patron As String) As Boolean
        Dim cadenaCorrecta As New Regex(patron)
        If cadenaCorrecta.IsMatch(cadena) Then
            Return True
        End If
        Return False
    End Function
End Module

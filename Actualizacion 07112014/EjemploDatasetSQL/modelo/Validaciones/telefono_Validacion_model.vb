Imports System.Text.RegularExpressions

Public Class telefono_Validacion_model

    Dim band As Boolean = False
    Private numero As String
    Private tipo As String
    Private ERtelf As String

    Public Sub New()
        ERtelf = "^([2|5|7|8]{1}[0-9]{7})$"
    End Sub



    Public Property telefono As String
        Get
            Return numero
        End Get
        Set(value As String)
            numero = value
        End Set
    End Property

    Public Property operadora As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property

    Function Validar_telefono() As Boolean
        telefono = telefono.Replace("-", "")
        Return Regex.IsMatch(telefono, ERtelf)
    End Function

    Function Validar_operadora() As Boolean

        If (operadora = "") Then
            band = True
        Else
            band = False
        End If
        Return band
    End Function

End Class

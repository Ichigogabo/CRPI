Imports System.Text.RegularExpressions

Public Class persona_Validacion_model

#Region "Constructores"

#Region "Atributos Constructores"

    Private value As String
    Private ERtelf As String
    Private EREmail As String
    Private ERNomApe As String
    Private ERCedula As String
    Private ERFecha As String

#End Region

    Public Sub New()
        EREmail = "^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$"
        ERNomApe = "^([A-Z][a-z_A-Záéíóúñ\s]*)$"
        ERCedula = "^([0-9]{3}-[0-9]{6}-[0-9]{4}[A-Z]{1})$"
        ERFecha = "^([0-9]{2}/[0-9]{2}/[0-9]{4})$"
    End Sub

#End Region

#Region "Propiedades"

#Region "Atributos Propiedades"

    Private nom As String
    Private ape As String
    Private dir As String
    Private ced As String
    Private loca As String
    Dim band As Boolean = False

#End Region

    Public Property Nombre As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return ape
        End Get
        Set(ByVal value As String)
            ape = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return dir
        End Get
        Set(ByVal value As String)
            dir = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return ced
        End Get
        Set(ByVal value As String)
            ced = value
        End Set
    End Property

    Public Property localidad As String
        Get
            Return loca
        End Get
        Set(ByVal value As String)
            loca = value
        End Set
    End Property

    Function Validar_nombre() As Boolean

        If (Nombre = "" Or Nombre.Length < 3) Then
            band = True
        Else
            band = False
        End If

        Return band
    End Function

    Function Validar_apellido() As Boolean

        If (Apellido = "" Or Apellido.Length < 4) Then
            band = True
        Else
            band = False
        End If

        Return band
    End Function

    Function Validar_Direccion() As Boolean

        If (Direccion = "" Or Direccion.Length < 20) Then
            band = True
        Else
            band = False
        End If

        Return band
    End Function

#End Region

#Region "Metodos y Funciones"

    Public Function ValEmail(ByVal Correo As String) As Boolean
        Return Regex.IsMatch(Correo, EREmail)
    End Function

    Public Function ValCedulaER() As Boolean
        If (Regex.IsMatch(Cedula, ERCedula)) Then 'Verificar Si Formato de Cedula es Valido'
            Try 'Verificar Si Fecha de Cedula es Valida'
                Dim Fecha_Cedula = Convert.ToDateTime(devolver_Fecha())
                If ((Date.Now.Year - Fecha_Cedula.Year) >= 18) Then 'Verificar que la Edad de la persona sea mayor o igula a 18 años'
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Function devolver_Fecha() As String
        Dim Fecha() As String = Split(Cedula, "-")
        Dim cadena As String = Fecha(1).Substring(0, 2) + "/" + Fecha(1).Substring(2, 2) + "/" + Fecha(1).Substring(4, 2)
        Return cadena
    End Function

#End Region

    Function Validar_localidad() As Boolean

        If (localidad = "") Then
            band = True
        Else
            band = False
        End If

        Return band
    End Function


End Class

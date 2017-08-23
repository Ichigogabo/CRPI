Imports MySql
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class db_mysql
#Region "Atributos"
    Private DIR As String
    Private HOST As String
    Private USER As String
    Private PASS As String
    Private DB As String
    Private SQL As String
    Private CONNECTION As MySqlConnection
    Private DT As DataTable
    Private DR As MySqlDataReader
    Private DA As MySqlDataAdapter
    Private CMD As MySqlCommand
    Private QUERY As String
    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "cooci@" 'Clave secreta(puede alterarse)
#End Region
#Region "Constantes"
    Private TABLAS() As String
#End Region
#Region "Propiedades"
    Public Property DATATABLE As DataTable
        Get
            Return Me.DT
        End Get
        Set(value As DataTable)
            Me.DT = value
        End Set
    End Property
    Public Property Servidor As String
        Get
            Return Me.HOST
        End Get
        Set(value As String)
            Me.HOST = value
        End Set
    End Property
    Public Property Usuario As String
        Get
            Return USER
        End Get
        Set(value As String)
            USER = value
        End Set
    End Property

    Public Property Contrasena As String
        Get
            Return PASS

        End Get
        Set(value As String)
            PASS = value
        End Set
    End Property

    Public Property CONSULTA As String
        Get
            Return Me.QUERY
        End Get
        Set(value As String)
            Me.QUERY = value
        End Set
    End Property

    
#End Region
#Region "Metodos y Funciones"
    Public Sub New()
        Try
            CONNECT()
        Catch ex As Exception
            DEFAULTCONNECTION()
        End Try
    End Sub
    Public Sub DEFAULTCONNECTION()
        CONNECTION = New MySqlConnection(" data source= localhost" & _
                                         " ; user id= root" & _
                                         " ; password=''" & _
                                         " ; database=dbo_cooci2"
                                        )
    End Sub

    Public Sub Tablas_fill()
        TABLAS(0) = ""
    End Sub

    Public Sub RECOVERDATACONNECTION()
        Me.DIR = Environment.CurrentDirectory & "\mysqldata.txt"
        Try
            Dim objreader As StreamReader
            Dim sLine As String
            Dim i = 1
            objreader = New StreamReader(Me.DIR)
            Do
                Select Case i
                    Case 1
                        sLine = objreader.ReadLine()
                        If Not sLine Is Nothing Then
                            Servidor = Desencriptar(sLine)
                        End If
                    Case 2
                        sLine = objreader.ReadLine()
                        If Not sLine Is Nothing Then
                            Usuario = Desencriptar(sLine)
                        End If
                    Case 3
                        sLine = objreader.ReadLine()
                        If Not sLine Is Nothing Then
                            Contrasena = Desencriptar(sLine)
                        End If
                    Case Else
                        sLine = objreader.ReadLine()
                End Select
                i += 1
            Loop Until sLine Is Nothing
            objreader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub SAVECONNECT()
        Me.DIR = Environment.CurrentDirectory & "\mysqldata.txt"
        Dim objwriter As StreamWriter
        objwriter = New StreamWriter(DIR)
        objwriter.WriteLine(Encriptar(Servidor))
        objwriter.WriteLine(Encriptar(Usuario))
        objwriter.WriteLine(Encriptar(Contrasena))
        objwriter.Close()
    End Sub

    Private Function Encriptar(ByVal texto As String) As String

        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function

    Private Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function

    Public Sub CONNECT()
        RECOVERDATACONNECTION()
        CONNECTION = New MySqlConnection("data source=" & Servidor _
                                            & "; user id=" & Usuario _
                                            & "; password=" & Contrasena _
                                            & "; database=dbo_cooci2"
                                        )
    End Sub

    Public Sub SELECTION(ByVal tabla As String)


        Try
            CONSULTA = "SELECT * FROM " & tabla
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()
            DATATABLE = New DataTable
            DATATABLE.Load(DR)
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub UPDATETABLE(ByVal TABLA As String, ByVal ATRIBUTO As String, ByVal CONDICION As String)
        Try
            CONSULTA = "UPDATE " & TABLA & " SET " & ATRIBUTO & " " & " WHERE ( " & CONDICION & " )"
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub INSERTTABLE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal VALORES As String)
        Try
            CONSULTA = "INSERT INTO " & TABLA & " ( " & ATRIBUTOS & " ) VALUES ( " & VALORES & " )"
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function SIMPLESEARCH(ByVal TABLA As String, ByVal CONDICION As String) As DataTable
        Try
            CONSULTA = "SELECT * FROM " & TABLA & " WHERE ( " & CONDICION & " )"
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()
            Dim Result As New DataTable
            Result.Load(DR)
            CMD.Connection.Close()
            Return Result
        Catch ex As Exception
            Dim Result As New DataTable
            Return Result
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Function SIMPLESEARCH(ByVal ATRIBUTOS As String, ByVal TABLA As String, ByVal CONDICION As String) As DataTable
        Try
            CONSULTA = "SELECT " & ATRIBUTOS & " FROM " & TABLA & " WHERE ( " & CONDICION & " )"
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()
            Dim Result As New DataTable
            Result.Load(DR)
            CMD.Connection.Close()
            Return Result
        Catch ex As Exception
            Dim Result As New DataTable
            Return Result
            MsgBox(ex.ToString)
        End Try

    End Function

    Public Sub CUSTOMQUERYREADER()
        Try
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()
            DATATABLE = New DataTable
            DATATABLE.Load(DR)
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function EXIST(ByVal TABLA As String, ByVal VALOR As String) As Boolean
        Dim band As Boolean = False
        Try
            CONSULTA = " SELECT * FROM " & TABLA & " WHERE ( " & VALOR & " )"
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()

            If DR.HasRows = True Then
                band = False
            Else
                band = True
            End If
            CMD.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        Return band
    End Function

    'Public Sub LOADCOMBOBOX(ByVal tabla As String)
    '    Try
    '        DA = New MySqlDataAdapter(CONSULTA, CONNECTION)
    '        CONSULTA = "SELECT * FROM " & tabla
    '        DA = New MySqlDataAdapter(CONSULTA, CONNECTION)
    '        DA.Fill(DATATABLE)


    '        CMD = New MySqlCommand(QUERY, CONNECTION)
    '        CMD.Connection.Open()
    '        DR = CMD.ExecuteReader()
    '        DATATABLE = New DataTable
    '        DATATABLE.Load(DR)
    '        CMD.Connection.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    'End Sub
#End Region
#Region "Metodos y Funciones"
    Public Function COUNTTABLE(ByVal tabla As String, ByVal Parametro As String)
        Try
            CONSULTA = "SELECT COUNT(" & Parametro & ")  FROM " & tabla
            CMD = New MySqlCommand(QUERY, CONNECTION)
            CMD.Connection.Open()
            DR = CMD.ExecuteReader()
            DATATABLE = New DataTable
            DATATABLE.Load(DR)
            CMD.Connection.Close()
            Return Convert.ToInt32(DATATABLE.Rows(0).Item(0).ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
#End Region
End Class

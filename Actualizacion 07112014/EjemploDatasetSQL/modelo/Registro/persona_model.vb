Public Class persona_model
#Region "Atributos"
    Private _idPersona As Integer
    Private _nombre As String
    Private _apellido As String
    Private _cedula As String
    Private _sexo As String
    Private _direccion As String
    Private _idregion As Integer
    Private DB As db_mysql
    Private TABLE As String
#End Region

#Region "Propiedades"

    Public Property ID As Integer
        Get
            Return Me._idPersona
        End Get
        Set(value As Integer)
            Me._idPersona = value
        End Set
    End Property

    Public Property NOMBRE As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property APELLIDO As String
        Get
            Return Me._apellido
        End Get
        Set(value As String)
            Me._apellido = value
        End Set
    End Property

    Public Property CEDULA As String
        Get
            Return Me._cedula
        End Get
        Set(value As String)
            Me._cedula = value
        End Set
    End Property

    Public Property ID_REGION As Integer
        Get
            Return Me._idregion
        End Get
        Set(value As Integer)
            Me._idregion = value
        End Set
    End Property

    Public Property SEXO As String
        Get
            Return Me._sexo
        End Get
        Set(value As String)
            Me._sexo = value
        End Set
    End Property

    

#End Region

#Region "Metodos y Funciones"
    Public Sub New()
        Me.TABLE = "tbl_persona"
        DB = New db_mysql
    End Sub

    Property DIRECCION As String
        Get
            Return Me._direccion
        End Get
        Set(value As String)
            Me._direccion = value
        End Set
    End Property
    Public Sub Insertar()
        Try

            DB.INSERTTABLE(TABLE, "nombres, apellidos, cedula, sexo, idRegion", "'" & NOMBRE & "','" & APELLIDO & "','" & CEDULA & "','" & SEXO & "','" & ID_REGION & "'")
            ObtenerID()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Actualizar()
        DB.UPDATETABLE(TABLE, "nombre='" & NOMBRE & "',apellidos='" & APELLIDO & "',cedula='" & CEDULA & "',sexo='" & SEXO & "',idRegion='" & ID_REGION & "'", "idPersona='" & ID & "'")
    End Sub

    Public Sub Listar()
        DB.SELECTION(TABLE)
    End Sub

    Public Sub ObtenerID()
        DB.CONSULTA = "SELECT P.idPersona as ID FROM tbl_persona AS P WHERE (P.cedula = '" & CEDULA & "')"
        DB.CUSTOMQUERYREADER()
        ID = DB.DATATABLE.Rows(0).Item(0)
    End Sub




#End Region
End Class

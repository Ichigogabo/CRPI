Public Class cliente_model
#Region "Atributos"
    Private _persona As persona_model
    Private _direccion As String
    Private _idCliente As Integer
    Private _correo As String
    Private _nomCompania As String
    Private TABLE As String
    Private DB As db_mysql

    Sub New()
        TABLE = "tbl_cliente"
        DB = New db_mysql
        PERSONA = New persona_model
    End Sub

    Public Property ID As Integer
        Get
            Return Me._idCliente
        End Get
        Set(value As Integer)
            Me._idCliente = value
        End Set
    End Property

    Public Property CORREO As String
        Get
            Return Me._correo
        End Get
        Set(value As String)
            Me._correo = value
        End Set
    End Property

    Public Property DIRECCION As String
        Get
            Return Me._direccion
        End Get
        Set(value As String)
            Me._direccion = value
        End Set
    End Property

    Public Property NOMBRE_COMPANIA As String
        Get
            Return Me._nomCompania
        End Get
        Set(value As String)
            Me._nomCompania = value
        End Set
    End Property

    Public Property PERSONA As persona_model
        Get
            Return Me._persona
        End Get
        Set(value As persona_model)
            Me._persona = value
        End Set
    End Property

    Public Sub Insertar()
        Try
            PERSONA.Insertar()
            DB.INSERTTABLE(TABLE, "nomcompania, correo, idPersona", "'" & NOMBRE_COMPANIA & "','" & CORREO & "','" & PERSONA.ID & "'")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub

    Public Sub Actualizar()
        Try
            PERSONA.Actualizar()
            DB.UPDATETABLE(TABLE, "nomcompania='" & NOMBRE_COMPANIA & "',direccion='" & DIRECCION & "',correo='" & CORREO & "'", "idCliente" = ID)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Buscar()

    End Sub

    Public Function Listar() As DataTable
        Try
            DB.CONSULTA = "SELECT P.idPersona as Registro,P.nombres AS Nombres,P.apellidos AS Apellidos,P.cedula AS Cedula,(if(P.sexo='F','Femenino','Masculino'))as Sexo,P.direccion_exacta AS Dirección, C.correo AS Correo,group_concat(T.telefono separator ', ')As Contacto  " & _
                      " FROM tbl_cliente AS C inner join tbl_persona AS P  on P.idpersona = C.idpersona inner join tbl_telefono AS T on T.idpersona = P.idpersona " & _
                      " GROUP BY P.nombres ORDER BY P.apellidos "
            DB.CUSTOMQUERYREADER()
            Return DB.DATATABLE
        Catch ex As Exception
            Dim tabla As New DataTable
            Return tabla
        End Try
    End Function
#End Region

#Region "Propiedades"

#End Region
End Class

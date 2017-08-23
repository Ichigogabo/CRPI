Public Class proyecto_model
#Region "Atributos"
    Private _idProyecto As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _fechainicio As DateTime
    Private _fechatermina As DateTime
    Private _codigo As String
    Private _idpadre As Integer
    Private _Costo As Double
    Private TABLE As String
    Private DB As db_mysql
    Private _nivel As Integer
#End Region

#Region "Propiedades"
    Public Property ID As Integer
        Get
            Return Me._idProyecto
        End Get
        Set(value As Integer)
            Me._idProyecto = value
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

    Public Property DESCRIPCION As String
        Get
            Return Me._descripcion
        End Get
        Set(value As String)
            Me._descripcion = value
        End Set
    End Property

    Public Property INICIO As DateTime
        Get
            Return Me._fechainicio
        End Get
        Set(value As DateTime)
            Me._fechainicio = value
        End Set
    End Property

    Public Property FINALIZA As DateTime
        Get
            Return Me._fechatermina
        End Get
        Set(value As DateTime)
            Me._fechatermina = value
        End Set
    End Property

    Public Property PADRE As Integer
        Get
            Return Me._idpadre
        End Get
        Set(value As Integer)
            Me._idpadre = value
        End Set
    End Property
    Public Property COSTO As Double
        Get
            Return Me._Costo
        End Get
        Set(value As Double)
            Me._Costo = value
        End Set
    End Property

    Public Property NIVEL As Integer
        Get
            Return Me._nivel
        End Get
        Set(value As Integer)
            Me._nivel = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"

    Public Sub New()
        TABLE = "tbl_proyectos"
        DB = New db_mysql
    End Sub

    Public Function Contar_Proyecto()
        Return DB.COUNTTABLE("vw_proyectos", "idProyecto")
    End Function

    Public Function Contar_Fases()
        Return DB.COUNTTABLE("vw_Fases", "idFase")
    End Function

    Public Function Contar_Actividades()
        Return DB.COUNTTABLE("vw_actividades", "idActividad")
    End Function

    Public Function Cargar_Proyectos() As DataTable
        DB.SELECTION("vw_proyectos")
        Return DB.DATATABLE
    End Function

    Public Function Cargar_Fases() As DataTable
        DB.CONSULTA = "SELECT F.IdFase, F.Fase, F.Descripcion, F.Inicio, F.Finaliza, F.IdProyecto, F.Codigo " & _
            " FROM vw_proyectos AS P INNER JOIN vw_fases AS F ON P.IdProyecto = F.IdProyecto " & _
            " WHERE F.IdProyecto=" & ID
        DB.CUSTOMQUERYREADER()
        Return DB.DATATABLE
    End Function

    Public Function Cargar_Activcidades() As DataTable
        DB.CONSULTA = "SELECT A.IdActividad, A.Actividad, A.Descripcion, A.Inicio, A.Finaliza, A.IdFase, A.Codigo " & _
            " FROM vw_fases AS F INNER JOIN vw_actividades AS A ON F.IdFase = A.IdFase " & _
            " WHERE A.IdFase=" & ID
        DB.CUSTOMQUERYREADER()
        Return DB.DATATABLE
    End Function

    Public Sub Insertar_Proyecto()
        Dim cod As String
        cod = Contar_Proyecto() + 1 & "00"
        DB.INSERTTABLE(TABLE, "nombre, descripcion, fechainicio, fechafina, codigo, costo, nivel ", " ' " & NOMBRE & " ',' " & DESCRIPCION & "','" & INICIO.ToString("yy/MM/dd") & "','" & FINALIZA.ToString("yy/MM/dd") & "',' " & cod & "'," & 0 & ",'1' ")
    End Sub

    Public Sub Insertar_Fase()
        Dim cod As String
        cod = Contar_Proyecto() & Contar_Fases() + 1 & "0"
        DB.INSERTTABLE(TABLE, "nombre, descripcion, fechainicio, fechafina, codigo,idpadre, costo, nivel ", " ' " & NOMBRE & " ',' " & DESCRIPCION & "','" & INICIO.ToString("yy/MM/dd") & "','" & FINALIZA.ToString("yy/MM/dd") & "',' " & cod & "'," & 0 & ",'1' ")
    End Sub

    Public Sub Insertar_Actividad()
        Dim cod As String
        cod = "111" & Contar_Actividades() + 1
        DB.INSERTTABLE(TABLE, "nombre, descripcion, fechainicio, fechafina, codigo, costo, nivel", "'" & NOMBRE & "','" & DESCRIPCION & "','" & "','" & INICIO.ToString("yy/MM/dd") & "','" & FINALIZA & "'," & cod & "','" & COSTO & "','3'")
    End Sub

    Public Sub Actualizar_Proyecto()
        DB.UPDATETABLE(TABLE, "", "")
    End Sub

    Public Sub Buscar_Proyecto()
        'DB.SIMPLESEARCH("vw_proyectos", "IdProyecto=" & ID)
        Dim dt As New DataTable
        dt = DB.SIMPLESEARCH("vw_proyectos", "IdProyecto=" & ID)
        Try
            NOMBRE = dt.Rows(0).Item(1)
            DESCRIPCION = dt.Rows(0).Item(2)
            INICIO = dt.Rows(0).Item(3)
            FINALIZA = dt.Rows(0).Item(4)
            COSTO = dt.Rows(0).Item(6)
        Catch ex As Exception

        End Try


    End Sub

    Public Sub Buscar_Fase()
        'DB.SIMPLESEARCH("vw_proyectos", "IdProyecto=" & ID)
        Dim dt As New DataTable
        dt = DB.SIMPLESEARCH("vw_fases", "IdFase=" & ID)
        Try
            NOMBRE = dt.Rows(0).Item(1)
            DESCRIPCION = dt.Rows(0).Item(2)
            INICIO = dt.Rows(0).Item(3)
            FINALIZA = dt.Rows(0).Item(4)

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Buscar_Actividad()
        'DB.SIMPLESEARCH("vw_proyectos", "IdProyecto=" & ID)
        Dim dt As New DataTable
        dt = DB.SIMPLESEARCH("vw_Actividades", "IdActividad=" & ID)
        Try
            NOMBRE = dt.Rows(0).Item(1)
            DESCRIPCION = dt.Rows(0).Item(2)
            INICIO = dt.Rows(0).Item(3)
            FINALIZA = dt.Rows(0).Item(4)

        Catch ex As Exception

        End Try


    End Sub

    Public Sub Listar_Proyecto()
        DB.SELECTION(TABLE)
    End Sub



#End Region
    'INSERT INTO `tbl_proyectos` (`nombre`, `descripcion`, `fechainicio`, `fechafina`, `codigo`, `costo`, `nivel`) VALUES ('CONSTRUCCION DE COLEGIO', 'SE CONSTRUIRA UN COLEGION EN CARRETERA NORTE', '2014-10-28 10:42:32', '2014-10-22 10:42:38', 'I-01-00-00', '0', '1')
End Class

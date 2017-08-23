Public Class material_model

#Region "Atributos"
    Private _idmaterial As Integer
    Private _material As String
    Private _cantidad As Integer
    Private _undmedida As Integer
    Private _nomUnidMedida As String
    Private TABLENAME As String
    Private DB As db_mysql
#End Region

#Region "Propiedades"

    Public Property ID As Integer
        Get
            Return Me._idmaterial
        End Get
        Set(value As Integer)
            Me._idmaterial = value
        End Set
    End Property            ' Llave primaria del cargo

    Public Property Material As String
        Get
            Return Me._material
        End Get
        Set(value As String)
            Me._material = value
        End Set
    End Property          ' Nombre del cargo

    Public Property Cantidad As Integer
        Get
            Return Me._cantidad
        End Get
        Set(value As Integer)
            Me._cantidad = value
        End Set
    End Property    ' Descripcion del cargo
    Public Property UNIDAD_MEDIDA As Integer
        Get
            Return Me._undmedida
        End Get
        Set(value As Integer)
            Me._undmedida = value
        End Set
    End Property

    Public Property NOMBRE_UNIDAD_MEDIDA As String
        Get
            Return Me._nomUnidMedida
        End Get
        Set(value As String)
            Me._nomUnidMedida = value
        End Set
    End Property

#End Region

#Region "Metodos y Funcione"

    Public Sub New()
        DB = New db_mysql
        TABLENAME = "tbl_materiales"
    End Sub

    Public Sub Insertar()
        Try
            'INSERT INTO `tbl_cargo` (`cargo`, `descripcion`) VALUES ('OBRERO', 'SON CONTRATADOS TEMPORALMENTE')
            DB.INSERTTABLE(TABLENAME, "material, cantidad,idUnidMed", " '" & Material & "' , '" & Cantidad & "' , '" & UNIDAD_MEDIDA & "'")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Actualizar()

        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            DB.UPDATETABLE(TABLENAME, "material = '" & Material & "', cantidad = '" & Cantidad & "', " & "idUnidMed = '" & UNIDAD_MEDIDA & "'", "idMaterial = " & ID)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Buscar(ByVal CONDICION As String)
        Try
            '
            DB.CONSULTA = " SELECT M.idMaterial as ID, M.material as Material, M.cantidad as Cantidad, UM.UnidMedida as UnidadMedida " & _
                      " FROM tbl_materiales AS M INNER JOIN tbl_unidmedida AS UM ON M.idUnidMed = UM.idUnidMed WHERE ( M.idMaterial = '" & CONDICION & "')"
            DB.CUSTOMQUERYREADER()
            Dim dt As DataTable = DB.DATATABLE
            ID = Convert.ToInt32(dt.Rows(0).Item(0))
            Material = dt.Rows(0).Item(1).ToString
            Cantidad = dt.Rows(0).Item(2)
            NOMBRE_UNIDAD_MEDIDA = dt.Rows(0).Item(3).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Function BuscarFiltro(ByVal CONDICION As String) As DataTable
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            DB.CONSULTA = " SELECT M.idMaterial as ID, M.material as Material, M.cantidad as Cantidad, UM.UnidMedida as UnidadMedida " & _
                      " FROM tbl_materiales AS M INNER JOIN tbl_unidmedida AS UM ON M.idUnidMed = UM.idUnidMed WHERE ( " & CONDICION & ")"
            DB.CUSTOMQUERYREADER()
            Dim dt As DataTable = DB.DATATABLE
            Return dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Listar() As DataTable
        DB.CONSULTA = " SELECT M.idMaterial as ID, M.material as Material, M.cantidad as Cantidad, UM.UnidMedida as UnidadMedida " & _
                      " FROM tbl_materiales AS M INNER JOIN tbl_unidmedida AS UM ON M.idUnidMed = UM.idUnidMed "
        DB.CUSTOMQUERYREADER()
        Return DB.DATATABLE
    End Function

    Public Function Existe() As Boolean
        Return DB.EXIST(TABLENAME, " material = '" & Material & "'")
    End Function


#End Region

End Class

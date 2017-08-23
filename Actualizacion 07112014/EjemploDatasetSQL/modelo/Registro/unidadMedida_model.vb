Public Class unidadMedida_model
#Region "Atributos"
    Private _idUnidMed As Integer
    Private _UnidMedida As String
    Private _abreviatura As String
    Private TABLENAME As String
    Private DB As db_mysql
#End Region

#Region "Propiedades"

    Public Property ID As Integer
        Get
            Return Me._idUnidMed
        End Get
        Set(value As Integer)
            Me._idUnidMed = value
        End Set
    End Property            ' Llave primaria del cargo

    Public Property UNIDAD_MEDIDA As String
        Get
            Return Me._UnidMedida
        End Get
        Set(value As String)
            Me._UnidMedida = value
        End Set
    End Property          ' Nombre del cargo

    Public Property ABREBIATURA As String
        Get
            Return Me._abreviatura
        End Get
        Set(value As String)
            Me._abreviatura = value
        End Set
    End Property    ' Descripcion del cargo

#End Region

#Region "Metodos y Funcione"

    Public Sub New()
        DB = New db_mysql
        TABLENAME = "tbl_unidmedida"
    End Sub

    Public Sub Insertar()
        Try
            'INSERT INTO `tbl_cargo` (`cargo`, `descripcion`) VALUES ('OBRERO', 'SON CONTRATADOS TEMPORALMENTE')
            DB.INSERTTABLE(TABLENAME, "UnidMedida , abreviatura", " '" & UNIDAD_MEDIDA & "' , '" & ABREBIATURA & "'")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Actualizar()
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            DB.UPDATETABLE(TABLENAME, "UnidMedida = '" & UNIDAD_MEDIDA & "',abreviatura = '" & ABREBIATURA & "'", "idUndMed = " & ID)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Buscar(ByVal CONDICION As String)
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            Dim dt As DataTable = DB.SIMPLESEARCH(TABLENAME, CONDICION)
            ID = Convert.ToInt32(dt.Rows(0).Item(0))
            UNIDAD_MEDIDA = dt.Rows(0).Item(1).ToString
            ABREBIATURA = dt.Rows(0).Item(2).ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Function BuscarFiltro(ByVal CONDICION As String) As DataTable
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            Dim dt As DataTable = DB.SIMPLESEARCH(TABLENAME, CONDICION)
            Return dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Public Function Listar() As DataTable
        DB.SELECTION(TABLENAME)
        Return DB.DATATABLE
    End Function

    Public Function Existe() As Boolean
        Return DB.EXIST(TABLENAME, " UnidMedida = '" & UNIDAD_MEDIDA & "'")
    End Function


#End Region
End Class

Public Class cargo_model

#Region "Atributos"
    Private _idCargo As Integer
    Private _cargo As String
    Private _descripcion As String
    Private TABLENAME As String
    Private DB As db_mysql
#End Region

#Region "Propiedades"

    Public Property ID As Integer
        Get
            Return Me._idCargo
        End Get
        Set(value As Integer)
            Me._idCargo = value
        End Set
    End Property            ' Llave primaria del cargo

    Public Property Cargo As String
        Get
            Return Me._cargo
        End Get
        Set(value As String)
            Me._cargo = value
        End Set
    End Property          ' Nombre del cargo

    Public Property Descripcion As String
        Get
            Return Me._descripcion
        End Get
        Set(value As String)
            Me._descripcion = value
        End Set
    End Property    ' Descripcion del cargo

#End Region

#Region "Metodos y Funcione"

    Public Sub New()
        DB = New db_mysql
        TABLENAME = "tbl_cargo"
    End Sub

    Public Sub Insertar()
        Try
            'INSERT INTO `tbl_cargo` (`cargo`, `descripcion`) VALUES ('OBRERO', 'SON CONTRATADOS TEMPORALMENTE')
            DB.INSERTTABLE(TABLENAME, "cargo, descripcion", " '" & Cargo & "' , '" & Descripcion & "'")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Actualizar()
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            DB.UPDATETABLE(TABLENAME, "cargo = '" & Cargo & "',descripcion = '" & Descripcion & "'", "idCargo = " & ID)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Buscar(ByVal CONDICION As String)
        Try
            'UPDATE `tbl_cargo` SET `cargo`='OBREROS', `descripcion`='SON CONTRATADOS TEMPORALMENTES' WHERE (`idCargo`='1')
            Dim dt As DataTable = DB.SIMPLESEARCH(TABLENAME, CONDICION)
            ID = Convert.ToInt32(dt.Rows(0).Item(0))
            Cargo = dt.Rows(0).Item(1).ToString
            Descripcion = dt.Rows(0).Item(2).ToString
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
        Return DB.EXIST(TABLENAME, " cargo = '" & Cargo & "'")
    End Function


#End Region

End Class

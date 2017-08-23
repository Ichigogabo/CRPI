Public Class region_model
#Region "Atributos"
    Private _idRegion As Integer
    Private _Departamento As Integer
    Private _Municipio As Integer
    Private _Localidad As Integer
    Private db As db_mysql
#End Region


#Region "Propiedades"
    Public Property REGION As Integer
        Get
            Return _idRegion
        End Get
        Set(value As Integer)
            _idRegion = value
        End Set
    End Property
    Public Property DEPARTAMENTO As Integer
        Get
            Return _Departamento
        End Get
        Set(value As Integer)
            _Departamento = value
        End Set
    End Property
    Public Property MUNICIPIO As Integer
        Get
            Return _Municipio
        End Get
        Set(value As Integer)
            _Municipio = value
        End Set
    End Property

    Public Property LOCALIDAD As Integer
        Get
            Return _Localidad
        End Get
        Set(value As Integer)
            _Localidad = value
        End Set
    End Property
#End Region
#Region "Metodos y Funciones"
    Public Sub New()
        db = New db_mysql
    End Sub

    Public Function Listar_Regiones() As DataTable
        db.SELECTION("vw_region")
        Return db.DATATABLE
    End Function

    Public Function Listar_Departamento() As DataTable
        db.CONSULTA = "SELECT D.IdDepartamento as ID, D.Departamento as DEPARTAMENTO FROM vw_region as R INNER JOIN vw_departamento as D on (R.ID=D.IdRegion) WHERE D.IdRegion=" & REGION
        db.CUSTOMQUERYREADER()
        Return db.DATATABLE
    End Function

    Public Function Listar_Municipio() As DataTable
        db.CONSULTA = "SELECT M.IdMunicipio as ID,  m.Municipio FROM vw_departamento as D INNER JOIN vw_municipio  as M on (d.IdDepartamento=m.idDepartamento) WHERE m.idDepartamento=" & DEPARTAMENTO
        db.CUSTOMQUERYREADER()
        Return db.DATATABLE
    End Function
    Public Function Listar_Localidad() As DataTable
        db.CONSULTA = "SELECT  L.IdLocalidad as ID,L.Localidad FROM vw_municipio as M INNER JOIN vw_localidad  as L on (L.IdMunicpio=M.IdMunicipio) WHERE M.IdMunicipio=" & MUNICIPIO
        db.CUSTOMQUERYREADER()
        Return db.DATATABLE
    End Function

#End Region
End Class

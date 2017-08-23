Public Class region_control
#Region "Atributos"
    Private _model As region_model
#End Region

#Region "Propiedades"
    Public Property MODEL As region_model
        Get
            Return Me._model
        End Get
        Set(value As region_model)
            Me._model = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"
    Public Sub New()
        MODEL = New region_model
    End Sub
    Public Function REGIONES() As DataTable
        Dim data = MODEL.Listar_Regiones
        Dim row As DataRow = data.NewRow()
        row.Item("ID") = 0
        row.Item("REGION") = "Seleccione una Opción"
        data.Rows.InsertAt(row, 0)
        Return (data)
    End Function

    Public Function DEPARTAMENTOS(ByVal id As Integer) As DataTable
        MODEL.REGION = id
        Dim data = MODEL.Listar_Departamento
        Dim row As DataRow = data.NewRow()
        row.Item("ID") = 0
        row.Item("Departamento") = "Seleccione una Opción"
        data.Rows.InsertAt(row, 0)
        Return (data)
    End Function

    Public Function MUNICIPIOS(ByVal id As Integer) As DataTable
        MODEL.DEPARTAMENTO = id
        Dim data = MODEL.Listar_Municipio
        Dim row As DataRow = data.NewRow()
        row.Item("ID") = 0
        row.Item("Municipio") = "Seleccione una Opción"
        data.Rows.InsertAt(row, 0)
        Return (data)
    End Function

    Public Function LOCALIDADES(ByVal id As Integer) As DataTable
        MODEL.MUNICIPIO = id
        Dim data = MODEL.Listar_Localidad
        Dim row As DataRow = data.NewRow()
        row.Item("ID") = 0
        row.Item("Localidad") = "Seleccione una Opción"
        data.Rows.InsertAt(row, 0)
        Return (data)
    End Function
#End Region
End Class

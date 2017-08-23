Public Class unidadMedida_control

#Region "Atributos"
    Private _model As unidadMedida_model
#End Region

#Region "Propiedades"

    Public Property MODEL As unidadMedida_model
        Get
            Return Me._model
        End Get
        Set(value As unidadMedida_model)
            Me._model = value
        End Set
    End Property

#End Region

#Region "Metodos y Funciones"

    Public Sub New()
        MODEL = New unidadMedida_model
    End Sub

    Public Function LISTAR() As DataTable
        Return MODEL.Listar()
    End Function
    Public Sub INSERTAR()
        MODEL.Insertar()
    End Sub
    Public Sub ACTUALIZAR()
        MODEL.Actualizar()
    End Sub
    Public Sub BUSCARPORID(ByVal id As Integer)
        MODEL.Buscar("idUnidMed=" & id)
    End Sub

#End Region


End Class

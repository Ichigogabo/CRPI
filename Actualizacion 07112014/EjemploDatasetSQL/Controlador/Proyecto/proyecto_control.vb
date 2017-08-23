Public Class proyecto_control
#Region "Atributos"
    Private _model As proyecto_model
#End Region

#Region "Propiedades"
    Property MODEL As proyecto_model
        Get
            Return Me._model
        End Get
        Set(value As proyecto_model)
            Me._model = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"
    Public Sub New()
        MODEL = New proyecto_model
    End Sub

    Public Function CARGAR_PROYECTOS() As DataTable
        Return MODEL.Cargar_Proyectos()
    End Function

    Public Function CARGAR_FASES(ByVal idProyecto As Integer) As DataTable
        MODEL.ID = idProyecto
        Return MODEL.Cargar_Fases()
    End Function

    Public Function CARGAR_ACTIVIDADES(ByVal idFase As Integer) As DataTable
        MODEL.ID = idFase
        Return MODEL.Cargar_Activcidades()
    End Function

    Public Sub DATOSPROYECTO(ByVal idProyecto As Integer)
        MODEL.ID = idProyecto
        MODEL.Buscar_Proyecto()
    End Sub

    Public Sub DATOSFASE(ByVal idProyecto As Integer)
        MODEL.ID = idProyecto
        MODEL.Buscar_Fase()
    End Sub

    Public Sub DATOSACTIVIDAD(ByVal idProyecto As Integer)
        MODEL.ID = idProyecto
        MODEL.Buscar_Actividad()
    End Sub

    Public Sub INSERTAR_PROYECTO()
        MODEL.Insertar_Proyecto()
    End Sub
#End Region
End Class

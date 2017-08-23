Public Class persona_control
#Region "Atributos"
    Private _model As persona_model
#End Region

#Region "Propiedades"
    Public Property MODEL As persona_model
        Get
            Return Me._model
        End Get
        Set(value As persona_model)
            Me._model = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"
    Public Sub New()
        Me.MODEL = New persona_model
    End Sub

    Public Sub INSERTAR()
        Me.MODEL.Insertar()
    End Sub
    Public Sub ACTUALIZAR()
        Me.MODEL.Actualizar()
    End Sub

#End Region
End Class

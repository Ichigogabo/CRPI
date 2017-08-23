Public Class cliente_control

#Region "Atributos"
    Private _model As cliente_model
#End Region

#Region "Propiedades"

    Public Property MODEL As cliente_model
        Get
            Return Me._model
        End Get
        Set(value As cliente_model)
            Me._model = value
        End Set
    End Property

    Public Property Persona As cliente_model
        Get
            Return MODEL
        End Get
        Set(ByVal value As cliente_model)
            MODEL = value
        End Set
    End Property

#End Region

#Region "Metodos Principales"

    Public Sub insert(ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal Localidad As Integer, ByVal direccion As String, ByVal sexo As String, ByVal compáñia As String, ByVal correo As String)

        MODEL = New cliente_model
        MODEL.PERSONA = New persona_model
        MODEL.PERSONA.NOMBRE = nombre
        MODEL.PERSONA.APELLIDO = apellido
        MODEL.PERSONA.CEDULA = cedula
        MODEL.PERSONA.ID_REGION = Localidad
        MODEL.PERSONA.Direccion = direccion
        MODEL.PERSONA.SEXO = sexo
        MODEL.NOMBRE_COMPANIA = compáñia
        MODEL.CORREO = correo
        MODEL.Insertar()

    End Sub

    Public Sub update(ByVal id As Integer, ByVal nombre As String, ByVal apellido As String, ByVal cedula As String, ByVal Localidad As Integer, ByVal direccion As String, ByVal correo As String)

        model = New cliente_model
        model.Persona = New Persona_model
        MODEL.PERSONA.ID = id
        model.Persona.Nombre = nombre
        model.Persona.Apellido = apellido
        model.Persona.Cedula = cedula
        MODEL.PERSONA.ID_REGION = Localidad
        model.Correo = correo
        model.Persona.Direccion = direccion
        MODEL.Actualizar()
    End Sub

#End Region

    Public Sub New()

        MODEL = New cliente_model

    End Sub

    Public Function Listar() As DataTable
        Return MODEL.Listar()
    End Function
End Class

Public Class material_control

#Region "Atributos"
    Private _model As material_model
#End Region

#Region "Propiedades"

    Public Property MODEL As material_model
        Get
            Return Me._model
        End Get
        Set(value As material_model)
            Me._model = value
        End Set
    End Property

#End Region

#Region "Metodos y Funciones"

    Public Sub New()

        MODEL = New material_model

    End Sub

    Public Sub INSERTAR()
        MODEL.Insertar()
    End Sub
    Public Sub ACTUALIZAR()
        MODEL.Actualizar()
    End Sub
    Public Function LISTAR() As DataTable
        Return MODEL.Listar()
    End Function

    Public Sub BUSCARPORID(ByVal id As Integer)

        MODEL.Buscar(id.ToString)

    End Sub
    Public Function EXISTE(ByVal material As String) As Boolean
        MODEL.Material = material
        If MODEL.Existe() = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function FILTRO(ByVal mifiltro As String) As DataTable
        Return MODEL.BuscarFiltro("material  like '%" & mifiltro & "%'")
    End Function

#End Region

End Class

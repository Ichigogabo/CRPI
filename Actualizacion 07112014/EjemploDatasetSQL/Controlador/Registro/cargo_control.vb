Public Class cargo_control
#Region "Atributos"

    Private _model As cargo_model

#End Region

#Region "Propiedades"
    Public Property MODEL As cargo_model
        Get
            Return Me._model
        End Get
        Set(value As cargo_model)
            Me._model = value
        End Set
    End Property
#End Region

#Region "Metodos y Funciones"
    Public Sub New()
        _model = New cargo_model
    End Sub

    Public Sub INSERTAR()
        MODEL.Insertar()
    End Sub
    Public Sub ACTUALIZAR()
        MODEL.Actualizar()
    End Sub
    Public Function LISTAR() As DataTable
        Return _model.Listar()
    End Function

    Public Function BUSCARPORID(ByVal id As Integer)
        MODEL.ID = id
        MODEL.Buscar("idcargo=" & MODEL.ID)
    End Function

    Public Function EXISTE(ByVal Cargo As String)
        MODEL.Cargo = Cargo
        If MODEL.Existe() = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FILTRO(ByVal mifiltro As String) As DataTable
        Return MODEL.BuscarFiltro("cargo  like '%" & mifiltro & "%'")
    End Function
#End Region
End Class

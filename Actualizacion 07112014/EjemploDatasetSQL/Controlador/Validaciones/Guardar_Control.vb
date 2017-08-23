Public Class Guardar_Control

    Private model_validacion_persona As New persona_Validacion_model
    Private model_validacion_cliente As New cliente_Validacion_model
    Private model_validacion_telefono As New telefono_Validacion_model

#Region "Validacion Persona"

    Public Function val_nombre(ByVal nombre As String) As Boolean
        model_validacion_persona.Nombre = nombre
        Return model_validacion_persona.Validar_nombre
    End Function

    Public Function val_apellido(ByVal apellido As String) As Boolean
        model_validacion_persona.Apellido = apellido
        Return model_validacion_persona.Validar_apellido
    End Function

    Public Function val_direccion(ByVal direccion As String) As Boolean
        model_validacion_persona.Direccion = direccion
        Return model_validacion_persona.Validar_Direccion
    End Function

    Public Function val_Cedula(ByVal Cedula As String) As Boolean
        model_validacion_persona.Cedula = Cedula
        Return Not (model_validacion_persona.ValCedulaER)
    End Function

    Public Function val_localidad(ByVal localidad As String) As Boolean
        model_validacion_persona.localidad = localidad
        Return model_validacion_persona.Validar_localidad
    End Function

#End Region

#Region "Validacion Cliente"

    Public Function val_correo(ByVal correo As String) As Boolean

        model_validacion_cliente.Correo = correo
        Return model_validacion_cliente.Validar_Correo
    End Function

#End Region

#Region "Validacion Telefono"

    Public Function val_operadora(ByVal operadora As String) As Boolean
        model_validacion_telefono.operadora = operadora
        Return model_validacion_telefono.Validar_operadora
    End Function

    Public Function val_telefono(ByVal telefono As String) As Boolean
        model_validacion_telefono.telefono = telefono
        Return Not (model_validacion_telefono.Validar_telefono)
    End Function

#End Region

End Class

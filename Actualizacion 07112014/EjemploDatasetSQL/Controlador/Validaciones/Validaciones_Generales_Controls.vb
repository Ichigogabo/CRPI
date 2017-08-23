Public Class Validaciones_Generales_Controls
    Dim model As New Validaciones_Generales_models

    Public Sub letras(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        model.e = e
        model.letras()
    End Sub

    Public Sub numeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        model.e = e
        model.numeros()
    End Sub

    Public Sub letras_numeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        model.e = e
        model.letras_numeros()
    End Sub

    Public Sub numeros_decimales(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal texto As String)
        model.e = e
        model.numero_decimales(texto)
    End Sub

End Class

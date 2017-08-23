Public Class cliente_Validacion_model

    
    Private email As String
    Dim band As Boolean = False

    Public Property Correo As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Function Validar_Correo() As Boolean
        If Correo.Length <> 0 Then
            Dim emailRegex As New System.Text.RegularExpressions.Regex("^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$")
            Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(Correo)
            If (emailMatch.Success) Then
                band = False
            Else
                band = True
            End If
        Else
            band = True
        End If
       

        Return (band)

    End Function

   

End Class

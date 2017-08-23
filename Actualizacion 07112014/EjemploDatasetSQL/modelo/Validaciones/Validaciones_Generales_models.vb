Public Class Validaciones_Generales_models

#Region "Atributos"

    Private c As System.Windows.Forms.KeyPressEventArgs

#End Region

#Region "Propiedades"

    Public Property e As System.Windows.Forms.KeyPressEventArgs
        Get
            Return c
        End Get
        Set(ByVal value As System.Windows.Forms.KeyPressEventArgs)
            c = value
        End Set
    End Property

#End Region

#Region "Metodos y Funciones"

    Public Sub letras()
        If (Char.IsLetter(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsSeparator(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub numeros()
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub letras_numeros()
        If (Char.IsLetter(e.KeyChar) Or Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub numero_decimales(ByVal texto As String)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not texto.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region

End Class

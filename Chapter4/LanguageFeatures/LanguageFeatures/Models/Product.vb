
Namespace LanguageFeatures.Models
    Public Class Product
        Private _name As String
        Public Property Name() As String
            Get
                Return _name + ProductID

            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property
        Public Property ProductID As Integer

        Public Property Description As String
        Public Property Price As Decimal
        Public Property Category As String
    End Class
End Namespace



Namespace LanguageFeatures.Models
    Public Class ShoppingCart
        Implements IEnumerable(Of Product)

        Public Products As List(Of Product)

        Public Function GetEnumerator() As IEnumerator(Of Product) Implements IEnumerable(Of Product).GetEnumerator
            Return Products.GetEnumerator()
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return GetEnumerator()
        End Function
    End Class
End Namespace


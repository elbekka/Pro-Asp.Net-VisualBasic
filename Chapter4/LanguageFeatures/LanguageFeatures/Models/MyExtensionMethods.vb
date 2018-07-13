

Imports System.Runtime.CompilerServices

Namespace LanguageFeatures.Models
    Module MyExtensionMethods
        <Extension()>
        Public Function TotalPrice(cartParam As ShoppingCart) As Decimal
            Dim total As Decimal = 0
            For Each item As Product In cartParam.Products
                total += item.Price
            Next
            Return total
        End Function

    End Module
End Namespace


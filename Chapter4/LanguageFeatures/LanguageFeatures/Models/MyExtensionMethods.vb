

Imports System.Runtime.CompilerServices

Namespace LanguageFeatures.Models
    Module MyExtensionMethods
        <Extension()>
        Public Function TotalPrice(productEnum As IEnumerable(Of Product)) As Decimal
            Dim total As Decimal = 0
            For Each prod As Product In productEnum
                total += prod.Price
            Next
            Return total
        End Function
        <Extension()>
        Public Iterator Function FilterByCategory(productEnum As IEnumerable(Of Product), categoryParam As String) As IEnumerable(Of Product)
            For Each prod As Product In productEnum
                If (prod.Category = categoryParam) Then
                    Yield prod
                End If
            Next
        End Function


    End Module
End Namespace


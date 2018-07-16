Imports System.Web.Mvc
Imports LanguageFeatures.LanguageFeatures.Models

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As String
            Return "Navigate to a URL to show an example"
        End Function
        Function AutoProperty() As ViewResult
            Dim myProduct As Product = New Product()

            'set property value
            myProduct.Name = "Kayak"
            'Get property value
            Dim productName As String = myProduct.Name
            Return View("Result", CObj(String.Format("Product name: {0}", productName)))
        End Function
        Public Function CreateProduct() As ViewResult
            'Create a new Product object
            Dim myProduct As Product = New Product() With {.ProductID = 100, .Name = "Kayak",
                                                           .Description = "A boat for one person",
                                                           .Price = 285D, .Category = "WaterSports"}
            'Set the property values
            Return View("Result", CObj(String.Format("Category: {0}", myProduct.Category)))
        End Function
        Public Function CreateCollection() As ViewResult
            Dim stringArray = {"apple", "orange", "plum"}
            Dim intList = New List(Of Integer) From {10, 20, 30, 40}
            Dim myDict = New Dictionary(Of String, Integer) From {{"apple", 10}, {"orange", 20}, {"plum", 30}}
            Return View("Result", CObj(stringArray(1)))
        End Function
        Public Function UseExtension() As ViewResult
            Dim cart As ShoppingCart = New ShoppingCart With {.Products = New List(Of Product) From {
                                                                New Product With {.Name = "kayak", .Price = 275D},
                                                                New Product With {.Name = "Lifejacket", .Price = 48.95D},
                                                                New Product With {.Name = "Soccer ball", .Price = 19.5D},
                                                                New Product With {.Name = "Corner flag", .Price = 34.95D}}}
            Dim cartTotal As Decimal = cart.TotalPrice()
            Return View("Result", CObj(String.Format("Total: {0}", cartTotal)))
        End Function
        Public Function UseExtensionEnumerable() As ViewResult
            Dim products As IEnumerable(Of Product) = New ShoppingCart With {.Products = New List(Of Product) From {
                                                                New Product With {.Name = "kayak", .Price = 275D},
                                                                New Product With {.Name = "Lifejacket", .Price = 48.95D},
                                                                New Product With {.Name = "Soccer ball", .Price = 19.5D},
                                                                New Product With {.Name = "Corner flag", .Price = 34.95D}}}
            'Create and populate an array of Product objects
            Dim productArray = {New Product With {.Name = "kayak", .Price = 275D},
                                New Product With {.Name = "Lifejacket", .Price = 48.95D},
                                New Product With {.Name = "Soccer ball", .Price = 19.5D},
                                New Product With {.Name = "Corner flag", .Price = 34.95D}}
            'Get the total value of product in cart
            Dim cartTotal As Decimal = products.TotalPrice()
            Dim arrayTotal As Decimal = productArray.TotalPrice()
            Return View("Result", CObj(String.Format("Cart Total : {0},Array Total : {1}", cartTotal, arrayTotal)))
        End Function
        Public Function UseFilterExtensionMethod() As ViewResult
            Dim products As IEnumerable(Of Product) = New ShoppingCart With {.Products = New List(Of Product) From {
                                                                New Product With {.Name = "kayak", .Price = 275D, .Category = "Soccer"},
                                                                New Product With {.Name = "Lifejacket", .Price = 48.95D, .Category = "Watersports"},
                                                                New Product With {.Name = "Soccer ball", .Price = 19.5D, .Category = "Soccer"},
                                                                New Product With {.Name = "Corner flag", .Price = 34.95D, .Category = "Soccer"}}}
            Dim total As Decimal = 0
            For Each prod As Product In products.FilterByCategory("Soccer")
                total += prod.Price
            Next
            Return View("Result", CObj(String.Format("Total:{0}", total)))
        End Function
    End Class
End Namespace
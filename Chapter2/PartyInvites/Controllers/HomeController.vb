Imports System.Web.Mvc
Imports System
Imports PartyInvites.PartyInvites.Models

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Public Function Index() As ViewResult
            Dim hour As Integer = DateTime.Now.Hour
            ViewBag.Greeting = If(hour < 12, "Good Morning", "Good Afternoon")
            Return View()
        End Function
        <HttpGet()>
        Public Function RsvpForm() As ViewResult
            Return View()
        End Function
        <HttpPost()>
        Public Function RsvpForm(ByVal response As GuestResponse) As ViewResult
            If ModelState.IsValid Then
                Return View("Thanks", response)
            End If
            Return View()
        End Function
    End Class
End Namespace
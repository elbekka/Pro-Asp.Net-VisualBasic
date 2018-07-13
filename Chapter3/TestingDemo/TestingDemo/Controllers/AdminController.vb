Imports System.Web.Mvc
Imports TestingDemo.TestingDemo

Namespace Controllers
    Public Class AdminController
        Inherits Controller

        Private repository As IUserRepository

        Sub New(ByVal repo As IUserRepository)
            Me.repository = repo
        End Sub
        ' GET: Admin
        Public Function ChangeLoginName(oldName As String, newName As String) As ActionResult
            Dim user As User
            user = repository.FetchByLoginName(oldName)
            repository.SubmitChanges()

            Return View()
        End Function
    End Class
End Namespace
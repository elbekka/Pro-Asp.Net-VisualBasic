Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TestingDemo.TestingDemo
Imports TestingDemo.Controllers

Namespace TestingDemo.Tests
    <TestClass()> Public Class AdminControllerTest

        <TestMethod()>
        Public Sub CanChangeLoginName()
            Dim user As New User With {.LoginName = "Joe"}
            Dim repositoryParam As New FakeRepository()
            repositoryParam.Add(user)
            Dim target As New AdminController(repositoryParam)
            Dim oldLoginParam As String = user.LoginName
            Dim newLoginParam As String = "Joe"

            target.ChangeLoginName(oldLoginParam, newLoginParam)

            Assert.AreEqual(newLoginParam, user.LoginName)
            Assert.IsTrue(repositoryParam.DidSubmitChanges)
        End Sub

    End Class

    Class FakeRepository
        Implements IUserRepository

        Public Users As List(Of User) = New List(Of User)
        Public DidSubmitChanges As Boolean = False

        Public Function FetchByLoginName(loginName As String) As User Implements IUserRepository.FetchByLoginName
            Return Users.First(Function(m) m.LoginName = loginName)
        End Function

        Public Sub Add(newUser As User) Implements IUserRepository.Add
            Users.Add(newUser)
        End Sub

        Public Sub SubmitChanges() Implements IUserRepository.SubmitChanges
            DidSubmitChanges = True
        End Sub
    End Class
End Namespace

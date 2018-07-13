
Namespace TestingDemo
    Public Class User
        Public Property LoginName As String
    End Class
    Public Interface IUserRepository
        Sub Add(newUser As User)
        Function FetchByLoginName(loginName As String) As User
        Sub SubmitChanges()
    End Interface
    Public Class DefaultUserRepository
        Implements IUserRepository

        Private Sub Add(newUser As User) Implements IUserRepository.Add
            Throw New NotImplementedException()
        End Sub

        Private Sub SubmitChanges() Implements IUserRepository.SubmitChanges
            Throw New NotImplementedException()
        End Sub

        Public Function FetchByLoginName(loginName As String) As User Implements IUserRepository.FetchByLoginName
            Return New User With {.LoginName = loginName}
        End Function
    End Class
End Namespace


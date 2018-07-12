Imports System.ComponentModel.DataAnnotations

Namespace PartyInvites.Models
    Public Class GuestResponse
        <Required(ErrorMessage:="Please enter name")>
        Public Property Name As String
        <Required(ErrorMessage:="Please enter your email address")>
        Public Property Email As String
        <Required(ErrorMessage:="Please enter your phone")>
        Public Property Phone As String
        <Required(ErrorMessage:="Please specify whether you will attend")>
        Public Property WillAttend As Boolean?

    End Class
End Namespace


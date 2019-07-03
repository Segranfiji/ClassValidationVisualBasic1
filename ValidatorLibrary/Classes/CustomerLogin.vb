Imports System.ComponentModel.DataAnnotations
Imports ValidatorLibrary.Rules

Namespace Classes
    Public Class CustomerLogin

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(20, MinimumLength:=6)>
        Public Property Name() As String

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(20, MinimumLength:=6)>
        <PasswordCheck(ErrorMessage:="Must include a number and symbol in {0}")>
        Public Property Password() As String

        <Compare("Password", ErrorMessage:="Passwords do not match, please try again")>
        <StringLength(20, MinimumLength:=6)>
        Public Property PasswordConfirmation() As String

    End Class
End Namespace
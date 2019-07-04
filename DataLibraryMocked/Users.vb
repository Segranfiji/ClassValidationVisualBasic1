Public Class Users
    Public Property Id() As Integer
    Public Property UserName() As String
    Public Property FirstName() As String
    Public Property LastName() As String
    Public Property EmailAddress() As String

    Public Overrides Function ToString() As String
        Return $"{Id} {UserName}"
    End Function
End Class

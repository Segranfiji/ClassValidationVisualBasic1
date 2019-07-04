Imports System.IO

''' <summary>
''' There is no assertion for checking if the file exist or
''' is in the expected format as in this code sample there
''' is nothing to mess things up unless the reader gets to
''' the point of "what if I screw with this file?"
''' </summary>
Public Class DataOperations
    Public Property Dictionary() As New Dictionary(Of Integer, String)
    Public ReadOnly Property FileName() As String
        Get
            Return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users.txt")
        End Get
    End Property
    Public Sub Save()
        File.WriteAllLines(
            FileName, Dictionary.
                              Select(Function(x) "" & x.Key & "," & x.Value & "").ToArray())
    End Sub
    Public Sub ReadUsers()
        Dictionary = New Dictionary(Of Integer, String)

        Dim lines = File.ReadAllLines(FileName).
                Where(Function(line) Not String.IsNullOrWhiteSpace(line))

        Dim parts As String()

        For Each userLine As String In lines
            parts = userLine.Split(","c)
            Dictionary.Add(CInt(parts(0)), parts(1))
        Next

    End Sub
End Class

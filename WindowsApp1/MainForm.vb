Public Class MainForm
    Private userName As String
    Public Sub New(pUserName As String)
        InitializeComponent()
        userName = pUserName
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullNameLabel.Text = $"Welcome {userName}"
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.OpenForms.Cast(Of Form).FirstOrDefault().Close()
    End Sub
    Private Sub CloseAppButton_Click(sender As Object, e As EventArgs) Handles CloseAppButton.Click
        Close()
    End Sub
End Class
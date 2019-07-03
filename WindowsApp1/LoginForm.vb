Imports ValidatorLibrary.Classes
Imports ValidatorLibrary.LanguageExtensions
Imports ValidatorLibrary.Validators

Public Class LoginForm
    Private _retryCount As Integer = 0
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) _
        Handles LoginButton.Click

        Dim login As New CustomerLogin With
                {
                    .Name = UserNameTextBox.Text,
                    .Password = PasswordTextBox.Text,
                    .PasswordConfirmation = PasswordConfirmTextBox.Text
                }

        Dim validationResult As EntityValidationResult =
                ValidationHelper.ValidateEntity(login)

        If validationResult.HasError Then
            If _retryCount >= 3 Then
                MessageBox.Show("Guards toss them out!")
                Close()
            End If
            MessageBox.Show(validationResult.ErrorMessageList())
            _retryCount += 1
        Else
            Dim f As New MainForm(login.Name)
            f.Show()
            Hide()
        End If
    End Sub
End Class

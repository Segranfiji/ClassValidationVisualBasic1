Imports WindowsFormsLibrary
Imports BusinessLibrary.Entities
Imports DataLibraryMocked
Imports ValidatorLibrary.LanguageExtensions
Imports ValidatorLibrary.Validators

Public Class LoginForm
    Private _retryCount As Integer = 0

    Private dataOperations As New DataOperations

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) _
        Handles LoginButton.Click

        '
        ' Create an instance of CustomerLogin
        '
        Dim login As New CustomerLogin With
                {
                    .UserName = UserNameTextBox.Text,
                    .Password = PasswordTextBox.Text,
                    .PasswordConfirmation = PasswordConfirmTextBox.Text,
                    .EmailAddress = EmailTextBox.Text,
                    .FirstName = FirstNameTextBox.Text,
                    .LastName = LastNameTextBox.Text,
                    .CreditCardNumber = CreditCardTextBox.Text,
                    .CreditCardExpireMonth = ExpireMonthTextBox.AsInteger,
                    .CreditCardExpireYear = ExpireYearTextBox.AsInteger,
                    .CreditCardCode = CreditCardCode.Text
                }

        '
        ' Perform all required validation
        '
        Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(login)

        If validationResult.HasError Then

            '
            ' After three tries deny access, in real life there
            ' may be a method to contact the owner of the app.
            '
            If _retryCount >= 3 Then
                MessageBox.Show("Guards toss them out!")
                Close()
            End If

            '
            ' Show the validation issues
            '
            MessageBox.Show(validationResult.ErrorMessageList())
            _retryCount += 1

        Else
            '
            ' Here current users are read from a plain text file, in a real app this
            ' information would come from a database e.g. SLQ-Server, MS-Access, Oracle etc
            '
            dataOperations.ReadUsers()

            '
            ' Check if user name exists
            '
            Dim testIfUserNameExist = dataOperations.Dictionary.ContainsValue(UserNameTextBox.Text)
            If testIfUserNameExist Then
                MessageBox.Show("User name already exist, please select a different user name")
                Exit Sub
            End If

            '
            ' User name is available, add them to the mocked data in text file
            '
            dataOperations.Dictionary.Add(dataOperations.Dictionary.Keys.Max() + 1, UserNameTextBox.Text)
            dataOperations.Save()

            '
            ' Show what would be the main form of an application
            '
            Dim f As New MainForm(login.FullName)
            f.Show()
            Hide()
        End If

    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.UserName = "Karens" Then
            TextBoxList.ForEach(Sub(tb) tb.PasswordChar = Nothing)
        End If
    End Sub
End Class

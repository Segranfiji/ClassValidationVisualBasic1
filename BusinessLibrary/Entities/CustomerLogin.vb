Imports System.ComponentModel.DataAnnotations
Imports ValidatorLibrary.Rules

Namespace Entities
    Public Class CustomerLogin

        ''' <summary>
        ''' User name
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(20, MinimumLength:=6)>
        Public Property UserName() As String

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        Public Property FirstName() As String

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        Public Property LastName() As String

        Public ReadOnly Property FullName() As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property

        ''' <summary>
        ''' User password
        ''' </summary>
        ''' <returns></returns>
        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(20, MinimumLength:=6)>
        <PasswordCheck(ErrorMessage:="Must include a number and symbol in {0}")>
        Public Property Password() As String

        ''' <summary>
        ''' Confirmation of user password
        ''' </summary>
        ''' <returns></returns>
        <Compare("Password", ErrorMessage:="Passwords do not match, please try again"),
            DataType(DataType.Text)>
        <StringLength(20, MinimumLength:=6)>
        Public Property PasswordConfirmation() As String

        ''' <summary>
        ''' Validate email address
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks>
        ''' We use regular expressions rather than using DataType(DataType.EmailAddress)
        ''' for more control.
        ''' </remarks>
        <Required(ErrorMessage:="The Email address is required")>
        <RegularExpression("[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}",
                           ErrorMessage:="Invalid Email address")>
        Public Property EmailAddress() As String

        <ValidatorLibrary.Rules.CreditCard(
            AcceptedCardTypes:=ValidatorLibrary.Rules.CreditCardAttribute.CardType.Visa Or
                               ValidatorLibrary.Rules.CreditCardAttribute.CardType.MasterCard)>
        Public Property CreditCardNumber() As String

        <Required(ErrorMessage:="Credit card expire month required")>
        <Range(1, 12, ErrorMessage:="{0} is required")>
        Public Property CreditCardExpireMonth() As Integer

        <Required(ErrorMessage:="Credit card expire year required")>
        <Range(2019, 2022, ErrorMessage:="{0} is not valid {1} to {2} are valid")>
        Public Property CreditCardExpireYear() As Integer

        <Required(ErrorMessage:="{0} is required"), DataType(DataType.Text)>
        <StringLength(3, MinimumLength:=3)>
        Public Property CreditCardCode() As String
    End Class
End Namespace
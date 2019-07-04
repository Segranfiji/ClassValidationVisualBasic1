Option Infer On

Imports System.ComponentModel.DataAnnotations
Imports System.Text.RegularExpressions

Namespace Rules

    ''' Taken Ben Cull blog with minor changes by Karen Payne
    ''' https://benjii.me/2010/11/credit-card-validator-attribute-for-asp-net-mvc-3/
    ''' 
    ''' ASP.NET MVC 3 Credit Card Validator Attribute
    ''' by Ben Cull - 4 November 2010
    ''' 
    ''' With special thanks to:
    ''' Thomas @ Orb of Knowledge - http://orb-of-knowledge.blogspot.com/2009/08/extremely-fast-luhn-function-for-c.html 
    ''' For the Extremely fast Luhn algorithm implementation
    ''' 
    ''' And Paul Ingles - http://www.codeproject.com/KB/validation/creditcardvalidator.aspx
    ''' For a timeless blog post on credit card validation

    Public Class CreditCardAttribute
        Inherits ValidationAttribute

        Private _cardTypes As CardType
        Public Property AcceptedCardTypes() As CardType
            Get
                Return _cardTypes
            End Get
            Set(ByVal value As CardType)
                _cardTypes = value
            End Set
        End Property

        Public Sub New()
            _cardTypes = CardType.All
        End Sub

        Public Sub New(pAcceptedCardTypes As CardType)
            _cardTypes = pAcceptedCardTypes
        End Sub

        Public Overrides Function IsValid(ByVal value As Object) As Boolean
            Dim number = Convert.ToString(value)

            If String.IsNullOrEmpty(number) Then
                Return False
            End If

            Return IsValidType(number, _cardTypes) AndAlso IsValidNumber(number)
        End Function

        Public Overrides Function FormatErrorMessage(ByVal name As String) As String
            Return "The " & name & " field contains an invalid credit card number."
        End Function

        Public Enum CardType
            Unknown = 1
            Visa = 2
            MasterCard = 4
            Amex = 8
            Diners = 16

            All = CardType.Visa Or CardType.MasterCard Or CardType.Amex Or CardType.Diners
            AllOrUnknown = CardType.Unknown Or CardType.Visa Or CardType.MasterCard Or CardType.Amex Or CardType.Diners
        End Enum

        Private Function IsValidType(cardNumber As String, cardType As CardType) As Boolean

            If String.IsNullOrWhiteSpace(cardNumber) Then
                Return False
            End If
            ' Visa
            If Regex.IsMatch(cardNumber, "^(4)") AndAlso ((cardType And CreditCardAttribute.CardType.Visa) <> 0) Then
                Return cardNumber.Length = 13 OrElse cardNumber.Length = 16
            End If

            ' MasterCard
            If Regex.IsMatch(cardNumber, "^(51|52|53|54|55)") AndAlso ((cardType And CreditCardAttribute.CardType.MasterCard) <> 0) Then
                Return cardNumber.Length = 16
            End If

            ' Amex
            If Regex.IsMatch(cardNumber, "^(34|37)") AndAlso ((cardType And CreditCardAttribute.CardType.Amex) <> 0) Then
                Return cardNumber.Length = 15
            End If

            ' Diners
            If Regex.IsMatch(cardNumber, "^(300|301|302|303|304|305|36|38)") AndAlso ((cardType And CreditCardAttribute.CardType.Diners) <> 0) Then
                Return cardNumber.Length = 14
            End If

            'Unknown
            If (cardType And CreditCardAttribute.CardType.Unknown) <> 0 Then
                Return False
            End If

            Return False
        End Function

        Private Function IsValidNumber(ByVal number As String) As Boolean
            Dim DELTAS() As Integer = {0, 1, 2, 3, 4, -4, -3, -2, -1, 0}
            Dim checksum As Integer = 0
            Dim chars() As Char = number.ToCharArray()
            For i As Integer = chars.Length - 1 To 0 Step -1
                Dim j As Integer = (AscW(chars(i))) - 48
                checksum += j
                If ((i - chars.Length) Mod 2) = 0 Then
                    checksum += DELTAS(j)
                End If
            Next

            Return ((checksum Mod 10) = 0)
        End Function
    End Class
End Namespace
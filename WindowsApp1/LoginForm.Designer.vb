<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ExpireYearTextBox = New WindowsApp1.Controls.NumericTextbox()
        Me.ExpireMonthTextBox = New WindowsApp1.Controls.NumericTextbox()
        Me.CreditCardCode = New WindowsApp1.Controls.NumericTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CreditCardTextBox = New WindowsApp1.Controls.NumericTextbox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(115, 20)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserNameTextBox.TabIndex = 0
        Me.UserNameTextBox.Text = "painkaren"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(115, 74)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.Text = "@Password2"
        '
        'PasswordConfirmTextBox
        '
        Me.PasswordConfirmTextBox.Location = New System.Drawing.Point(115, 100)
        Me.PasswordConfirmTextBox.Name = "PasswordConfirmTextBox"
        Me.PasswordConfirmTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordConfirmTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordConfirmTextBox.TabIndex = 4
        Me.PasswordConfirmTextBox.Text = "@Password2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm password"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(115, 208)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(193, 23)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.Text = "Register"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email address"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(115, 129)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 5
        Me.EmailTextBox.Text = "karen@gizmo.net"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "First name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(115, 46)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        Me.FirstNameTextBox.Text = "Karen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Last name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(302, 46)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 2
        Me.LastNameTextBox.Text = "Smith"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Credit card number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(223, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Expires month"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "year"
        '
        'ExpireYearTextBox
        '
        Me.ExpireYearTextBox.Location = New System.Drawing.Point(372, 152)
        Me.ExpireYearTextBox.Name = "ExpireYearTextBox"
        Me.ExpireYearTextBox.Size = New System.Drawing.Size(31, 20)
        Me.ExpireYearTextBox.TabIndex = 8
        Me.ExpireYearTextBox.Text = "2021"
        '
        'ExpireMonthTextBox
        '
        Me.ExpireMonthTextBox.Location = New System.Drawing.Point(302, 151)
        Me.ExpireMonthTextBox.Name = "ExpireMonthTextBox"
        Me.ExpireMonthTextBox.Size = New System.Drawing.Size(31, 20)
        Me.ExpireMonthTextBox.TabIndex = 7
        Me.ExpireMonthTextBox.Text = "12"
        '
        'CreditCardCode
        '
        Me.CreditCardCode.Location = New System.Drawing.Point(115, 181)
        Me.CreditCardCode.Name = "CreditCardCode"
        Me.CreditCardCode.Size = New System.Drawing.Size(36, 20)
        Me.CreditCardCode.TabIndex = 18
        Me.CreditCardCode.Text = "089"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Code"
        '
        'CreditCardTextBox
        '
        Me.CreditCardTextBox.Location = New System.Drawing.Point(113, 152)
        Me.CreditCardTextBox.Name = "CreditCardTextBox"
        Me.CreditCardTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditCardTextBox.TabIndex = 20
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 254)
        Me.Controls.Add(Me.CreditCardTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CreditCardCode)
        Me.Controls.Add(Me.ExpireYearTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ExpireMonthTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordConfirmTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordConfirmTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ExpireMonthTextBox As Controls.NumericTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents ExpireYearTextBox As Controls.NumericTextbox
    Friend WithEvents CreditCardCode As Controls.NumericTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents CreditCardTextBox As Controls.NumericTextbox
End Class

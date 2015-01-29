'Function: Quiz: Form that gets users to log in before they can undertake the quiz

'Author: Kyle Hodgetts

'Date: 13/03/2013

'Version: 1.2

Public Class Form1
    'Upon loading, the forms position will be set to screen centre and the label tip visibility set to false
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the form's position to be centre of the screen
        Me.CenterToScreen()

        'Default visibility setting for the hint that closes the program on the log in page
        lblHover.Visible = False
    End Sub

    'Checks "Registered" txt file to validate log in credentials entered into Username and PIN fields
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        FileClose()
        Dim s As Integer = 0 'For reading the information into the Log in text file

        'Checks to make sure the Username and Password fields contain information
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter your username or password", MsgBoxStyle.OkOnly)
            txtUsername.Clear()
            txtPassword.Clear()
        Else
            'Program access the text file where the log in credentials are stored
            FileOpen(1, filePath & "\registered.txt", OpenMode.Input)
            Do While Not (EOF(1))
                login(s).userName = LineInput(1)
                login(s).password = LineInput(1)
                s += 1
            Loop
            'Loop that checks if the log in credentials entered into the text boxes exist in the "registered.txt" file
            For s = 0 To 9
                If txtUsername.Text = login(s).userName And txtPassword.Text = login(s).password Then
                    MsgBox("You are now logged in!")
                    Me.Hide()
                    Form2.Show()
                    Exit For

                ElseIf txtUsername.Text <> login(s).userName And txtPassword.Text <> login(s).password And s = login.Length - 1 Then
                    MsgBox("Log In credentials invalid, Please try again!")
                    txtPassword.Clear()
                    txtUsername.Clear()
                End If
            Next
        FileClose()
        End If
    End Sub

    'Shows the registration form where users can register new credentials
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Shows the register form
        Form16.Show()

        'Hides the current form
        Me.Hide()
    End Sub

    'Will close the program completely
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the program when clicked
        End
    End Sub

    'Allows for a tip to be displayed when the user hovers over the "Close" button
    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        'When the mouse hovers over the close button, the label's visibility evaluates to true
        lblHover.Visible = True
    End Sub

    'Will hide the tip again once the mouse leaves the "Close" button
    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        'Once the mouse leaves the close button, the label's visibility evaluates back to false
        lblHover.Visible = False
    End Sub

    'Enables "PIN" field to only allow numerical input
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        'Only allows numerics between 0 and 9 in the Password text box
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class

Public Class Form16
    'Function: Quiz: Allows users to register new log in credentials. 
    'Data is written to a text file that will be read from when they attempt to log in

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2

    'Sets the forms screen position
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the form's position to be centre of the screen
        Me.CenterToScreen()
    End Sub

    'Returns user to Main menu
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Shows the log in form
        Form1.Show()

        'Hides the registration form
        Me.Hide()
    End Sub

    'Stores new log in credentials to the text file
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        FileClose()
        Dim userName As String = txtUsername.Text 'Stores username

        Dim password As String = txtPassword.Text 'Stores password

        If txtUsername.Text.Length = 0 Or txtPassword.Text.Length = 0 Then
            MsgBox("Please enter a username and a password!", MsgBoxStyle.OkOnly)

        Else
            'Opens the file for the information to be placed there
            FileOpen(1, filePath & "\registered.txt", OpenMode.Append)

            'Inputs the log in information into the text file
            PrintLine(1, userName)
            PrintLine(1, password)
            FileClose(1)

            'Confirms to the user that their credentials are now registered
            MsgBox("You are now registered, Press OK to log in", MsgBoxStyle.OkOnly)

            'Shows the Log In form
            Form1.Show()

            'Hides the Registration form
            Me.Hide()
        End If
    End Sub

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
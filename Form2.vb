'Function: Quiz: Main Menu form that allows user to navigate between the quiz, leaderboard, help menu 
'and gives them the option to log out

'Author: Kyle Hodgetts

'Date: 13/03/2013

'Version: 1.2
Public Class Form2
    'Returns user to Log in form and hide the current form
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        'Will hide the current form and re-show form.1
        'The text boxes on form.1 will be cleared on load
        MsgBox("You have sucessfully logged out!")
        Form1.Show()
        Me.Hide()
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
    End Sub

    'Sets the question number to 0 which displays the first question when the quiz form is loaded
    Private Sub btnStartQuiz_Click(sender As Object, e As EventArgs) Handles btnStartQuiz.Click
        'Shows the quiz form.3 and hides the current form
        Form3.Show()
        Form14.Show()
        Me.Hide()
        qNum = 0 'Sets the question number to 0
        score = 0 'Sets user's score to 0

        'Sets the question labels' text property
        Form3.lblQuestion.Text = qList(qNum).questionNum

        'Sets answer 1's text property
        Form3.radAns1.Text = qList(qNum).ansOne

        'Sets answer 2's text property
        Form3.radAns2.Text = qList(qNum).ansTwo

        'Sets answer 3's text property
        Form3.radAns3.Text = qList(qNum).ansThree

        'Sets answer 4's text property
        Form3.radAns4.Text = qList(qNum).ansFour

        'Starts the quiz timer
        Form3.Timer1.Start()

    End Sub

    'Displays leaderboard form and hides the current form
    Private Sub btnRecs_Click(sender As Object, e As EventArgs) Handles btnRecs.Click
        'Shows the leaderboard form.15 and hides the current form
        Form15.Show()
        Me.Hide()
    End Sub

    'Sets the forms screen position as soon as it loads
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load the current form will be position in the centre of the screen
        Me.CenterToScreen()
    End Sub

    'Displays the Quiz's help menu
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        'Shows the help menu
        frmHelp.Show()
        'Hides the current form
        Me.Hide()
    End Sub
End Class
Public Class frmHelp
    'Function: Quiz: Form that informs user how the quiz works and operates.

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2

    'Sets the form properties on load
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        lblQuizInfo.Visible = False

        btnButtonHelp.Visible = False
    End Sub
    'Returns the user to the main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Shows the Main Menu
        Form2.Show()
        'Hides the current form
        Me.Hide()
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

    'Displays the leaderboard
    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        'Shows the leaderboard form.15 and hides the current form
        Form15.Show()
        Me.Hide()
    End Sub

    'Logs the user out
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.Show()
        Me.Hide()
    End Sub

    'Displays the quiz information and hides the button information
    Private Sub btnQuizInfo_Click(sender As Object, e As EventArgs) Handles btnQuizInfo.Click
        btnButtonHelp.Visible = True
        btnQuizInfo.Visible = False

        btnStartQuiz.Visible = False
        btnLeaderboard.Visible = False
        btnLogOut.Visible = False

        lblHelp1.Visible = False
        lblHelp2.Visible = False
        lblHelp3.Visible = False
        lblQuizInfo.Visible = True
    End Sub

    'Shows the button information and hides the quiz information
    Private Sub btnButtonHelp_Click(sender As Object, e As EventArgs) Handles btnButtonHelp.Click
        btnButtonHelp.Visible = False
        btnQuizInfo.Visible = True

        btnStartQuiz.Visible = True
        btnLeaderboard.Visible = True
        btnLogOut.Visible = True

        lblHelp1.Visible = True
        lblHelp2.Visible = True
        lblHelp3.Visible = True
        lblQuizInfo.Visible = False
    End Sub
End Class
Public Class Form3
    'Function: Quiz: Displays and allows user to answer questions. Scores are submitted upon answering the last question

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2

    'Displays the next question as long as the "qNum" is less than 9
    'Score is added to when the user gets a question right
    'Stats are updated and will be shown at the end of the quiz
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Checks that one of the answers have been selected before continuing
        If radAns1.Checked = False And radAns2.Checked = False And radAns3.Checked = False And radAns4.Checked = False Then
            MsgBox("You must select at least one answer before continuing!", MsgBoxStyle.OkOnly)

            'If an answer has been checked, the program will check if the answer they chose was correct
        Else
            check()

            'Only adds 1 to the question number if the question number is less than 9
            If qNum < 9 Then
                qNum += 1
                lblQuestion.Text = qList(qNum).questionNum
                radAns1.Text = qList(qNum).ansOne
                radAns2.Text = qList(qNum).ansTwo
                radAns3.Text = qList(qNum).ansThree
                radAns4.Text = qList(qNum).ansFour

                'If the question number = 9 then the submit button becomes visible
            Else
                btnSubmit.Visible = True
                btnNext.Visible = False
            End If

        End If


    End Sub

    'Upon loading, sets the form properties
    'Opens the text file that contains the quiz question
    'Resets the stats for the current quiz attempt
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the submit buttons visibility to false on load
        btnSubmit.Visible = False
        FileClose()

        'Starts the quiz timer
        Form2.Timer1.Start()

        'On load, the current form will be positioned in the center of the screen
        Me.CenterToScreen()


        'On start, the stats table will be empty
        'As each question is answered, each stat for each question will be updated
        For i = 0 To 9
            info(i).question = i + 1
            info(i).answer = "Not Completed"
        Next

        'Opens the text file containing the quiz questions and loads then into the qList array
        If System.IO.File.Exists(filePath & "\quizQuestions.txt") Then
            FileOpen(1, filePath & "\quizQuestions.txt", OpenMode.Input)

            Do While Not (EOF(1))
                qList(numQuestions).questionNum = LineInput(1)
                qList(numQuestions).ansOne = LineInput(1)
                qList(numQuestions).ansTwo = LineInput(1)
                qList(numQuestions).ansThree = LineInput(1)
                qList(numQuestions).ansFour = LineInput(1)
                qList(numQuestions).correctAns = LineInput(1)
                numQuestions = numQuestions + 1
            Loop

            'If the file is not in the specified file location, the program will display the messagebox
        Else
            MsgBox("File does not exist")
        End If
    End Sub

    'Sets the increment rate for the timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Increments the time by one as the timer ticks
        time = time + 1

        'Displays the value of the variable "Time" in the mentioned label
        Form14.lblTimer.Text = time
    End Sub

    'Once the last question has been answered, it will write the results to the text file and display the stats
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Hides the timer form
        Form14.Hide()
        FileClose()

        'Stops the quiz timer
        Timer1.Stop()

        'Opens the userScore text file
        FileOpen(3, filePath & "\userScore.txt", OpenMode.Output)

        'Inputs the user's name into the text file
        PrintLine(3, "User: " & Form1.txtUsername.Text)

        'Loop that prints the result for every question asked in the quiz by taking the information from the info array
        For index = 0 To 9
            PrintLine(3, "Question: " & Module1.info(index).question)
            PrintLine(3, "Correct: " & Module1.info(index).answer)
        Next

        'Prints the score at the bottom of the file
        PrintLine(3, "Score:" & score)

        'Closes the file
        FileClose(3)

        'Opens the leaderboard text file
        FileOpen(4, filePath & "\leaderboard.txt", OpenMode.Append)

        'Prints the user's name into the leaderboard text file
        PrintLine(4, Form1.txtUsername.Text)

        'Prints the user's score into the leaderboard text file
        PrintLine(4, score)

        'Prints the time taken to do the quiz
        PrintLine(4, time)

        'Closes the file
        FileClose(4)

        'Notifys the user of their score out of the highest possible score and time to complete
        MsgBox("Quiz completed, You scored " & score & "/100 in " & time & " Seconds!")

        'Shows the main menu form.2
        Form2.Show()

        'Shows the stats form.13
        Form13.Show()

        'Hide the current form
        Me.Hide()
    End Sub
End Class
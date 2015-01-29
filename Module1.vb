Module Module1
    'Function: Quiz: Module storing all the structures and arrays

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2
    Public filePath As String = My.Application.Info.DirectoryPath() 'Declares file path when opening the .txt files

    'Describe Quiz Questions and Answers
    Structure qType
        Dim questionNum As String
        Dim ansOne As String
        Dim ansTwo As String
        Dim ansThree As String
        Dim ansFour As String
        Dim correctAns As String
    End Structure

    'Data that shows what questions the user got right and wrong, they will see at the end of the quiz
    Structure stats
        Public user As String
        Public question As Integer
        Public answer As String
        Public score As Integer
        Public back As Color
    End Structure

    'Structure that stores data for the leaderboard
    Structure leaderboard
        Public user As String
        Public score As Integer
    End Structure
    'Structure that stores the user's username and password.
    Structure users
        Public userName As String
        Public password As Integer
    End Structure

    'Array declared that allows for upto 10 users to be registered
    Public login(0 To 9) As users

    'Array that stores upto 10 leaderboard scores
    Public records(0 To 9) As leaderboard

    'Array that stores the stats of upto 10 users
    Public info(0 To 9) As stats

    'Create a list of 10 for questions
    Public qList(0 To 9) As qType

    'Number of questions currently in system.
    Public numQuestions As Short = 0

    'Starting at zero, stores the user's score
    Public score As Integer

    'Stores the value of the question number
    Public qNum As Short

    'Time increments by one each second and is stored
    Public time As Integer

    Public Sub check()
        Select Case qNum
            Case 0
                If Form3.radAns3.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 1
                If Form3.radAns4.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 2
                If Form3.radAns1.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 3
                If Form3.radAns3.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 4
                If Form3.radAns3.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 5
                If Form3.radAns4.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 6
                If Form3.radAns3.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 7
                If Form3.radAns1.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 8
                If Form3.radAns2.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If

            Case 9
                If Form3.radAns1.Checked = True Then
                    score = score + 10
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "Yes"
                    info(qNum).back = Color.LightGreen

                Else
                    info(qNum).question = qNum + 1
                    info(qNum).answer = "No"
                    info(qNum).back = Color.LightCoral
                End If
        End Select

    End Sub
End Module

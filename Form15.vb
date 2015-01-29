Public Class Form15
    'Function: Quiz: Displays previous user's scores and times by reading them from the text file

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2

    Dim li As ListViewItem 'Local memory allocation for list view items

    'Structure that stores the user and thier score
    Structure record
        Public user As String
        Public score As Integer
    End Structure

    'Array that stores the user name and score of upto 10 users
    Public save(0 To 9) As record

    'Takes user back to the main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Shows the Main Menu form.2
        Form2.Show()

        'Hides the current form
        Me.Hide()
    End Sub

    'On load the form will read from the text file containing the previous score and displays them
    Private Sub Form15_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        FileClose()

        'On load, the form will be positioned in the center of the screen
        Me.CenterToScreen()
        ListView1.Items.Clear()

        'Opens the leaderboard text file to input into the listview
        FileOpen(1, filePath & "\leaderboard.txt", OpenMode.Input)

        'Loop that adds the user and thier respective score into the listview
        Do While Not (EOF(1))
            'For i = 0 To 9
            li = ListView1.Items.Add(LineInput(1))
            li.SubItems.Add(LineInput(1))
            li.SubItems.Add(LineInput(1))
            'Next
        Loop

        'Closes the file
        FileClose(1)
    End Sub
End Class
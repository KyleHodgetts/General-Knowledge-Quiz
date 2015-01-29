Public Class Form13
    'Function: Quiz: Deals with the stats that are displayed to the user at the end of the quiz

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2
    Public li As ListViewItem 'Memory Allocation for list view items

    'Adds the users stats from the quiz and displays what questions they got right/wrong
    Private Sub Form13_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'On load, listResults list view will be clear
        listResults.Items.Clear()

        'Loop that adds the stats from the info array for all 10 questions
        For i = 0 To 9
            'Adds question number to listview
            li = listResults.Items.Add(info(i).question)

            'Shows whether or not the user got the question right
            li.SubItems.Add(info(i).answer)

            'Based on correct or not, the colour of the item will be Green or Red (Right and Wrong)
            li.BackColor = info(i).back
        Next
    End Sub

    'Returns users to the Main Menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Shows Main Menu form.2
        Form2.Show()

        'Hides current form
        Me.Hide()
    End Sub
End Class
Public Class Form14
    'Function: Quiz: Form that times the user when they are taking the quiz.

    'Author: Kyle Hodgetts

    'Date: 13/03/2013

    'Version: 1.2
    Public screen = New Point(Me.Location) 'Screen Position for timer form

    'On load the timers screen position is set
    'Text value is set to the time variable which ticks by one every second
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting the value of the label to the value in the time variable
        lblTimer.Text = time
    End Sub
End Class
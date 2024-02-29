Public Class Form1

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        BtnStart.BackColor = Color.Green
        '
        '
        '
        ' random number to generate
        Dim MyMin As Integer = 1, MyMax As Integer = 5, My1stRandomNumber As Integer
        Dim Generator As System.Random = New System.Random()
        My1stRandomNumber = Generator.Next(MyMin, MyMax + 1)
        Lblgivenumber.Text = My1stRandomNumber


    End Sub


    Private Sub Lblgivenumber_Click(sender As Object, e As EventArgs) Handles Lblgivenumber.Click

    End Sub


End Class

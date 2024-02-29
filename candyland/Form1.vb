Public Class Form1

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        BtnStart.BackColor = Color.Green
        DisplayMove()


    End Sub
  Function DisplayMove() As Integer
      Dim MyMin As Integer = 1, MyMax As Integer = 5, My1stRandomNumber As Integer
      Dim Generator As System.Random = New System.Random()
      My1stRandomNumber = Generator.Next(MyMin, MyMax + 1)
      If My1stRandomNumber = 1 Then
          pnlMain.BackColor = Color.Pink
      End If
      If My1stRandomNumber = 2 Then

          pnlMain.BackColor = Color.Blue
      End If
      If My1stRandomNumber = 3 Then

          pnlMain.BackColor = Color.LightGreen
      End If
      If My1stRandomNumber = 4 Then

          pnlMain.BackColor = Color.Yellow
      End If
      If My1stRandomNumber = 5 Then

          pnlMain.BackColor = Color.Red
      End If
  End Function

    Private Sub Lblgivenumber_Click(sender As Object, e As EventArgs) Handles Lblgivenumber.Click

    End Sub


End Class

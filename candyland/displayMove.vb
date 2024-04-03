Module displayMove
    ' Shows both the random color, as well as the number assigned to it

    Function DisplayColor(pnlArbitrary) As Integer
        Dim randVal As Integer = roll()
        If randVal = 1 Then
            pnlArbitrary.BackColor = Color.Pink
            pnlArbitrary.text = randVal
            Return randVal
        End If
        If randVal = 2 Then
            pnlArbitrary.BackColor = Color.Blue
            pnlArbitrary.text = randVal
            Return randVal

        End If
        If randVal = 3 Then
            pnlArbitrary.BackColor = Color.LightGreen
            pnlArbitrary.text = randVal
            Return randVal

        End If
        If randVal = 4 Then
            pnlArbitrary.BackColor = Color.Yellow
            pnlArbitrary.text = randVal
            Return randVal

        End If
        If randVal = 5 Then
            pnlArbitrary.BackColor = Color.Red
            pnlArbitrary.text = randVal
            Return randVal

        End If
    End Function
    Public Function roll() As Integer 'Randomly returns a integer 1-5
        Return (Int((5 * Rnd()) + 1))
    End Function
End Module

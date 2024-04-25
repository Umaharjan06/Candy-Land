Imports System.Configuration
Imports System.Diagnostics.Eventing.Reader
Imports System.DirectoryServices.ActiveDirectory
Imports System.Globalization
Imports System.IO
Imports System.Numerics
Imports System.Reflection.Metadata
Imports System.Runtime
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles
Imports Accessibility
Imports Windows.Win32.System

Public Class frmCandyLandMain
    Public Board = tblBoardGame
    Public rollCount As Integer = 0
    Private isPlaying As Boolean = False

    ' -- uses even or odd to determine if it's the player or computer's turn
    ' -- player goes first so player is odd
    Private Sub turns()
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
        Dim currCol As Integer = tblBoardGame.GetColumn(btnComputer)
        Dim currRow As Integer = tblBoardGame.GetRow(btnComputer)

        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        lblComputerRoll.Show()
        lblComputerRoll.Text = x.ToString()
        If currRow Mod 2 = 0 Then
            SPMoveReversed(btnComputer, x)
        ElseIf currRow Mod 2 = 1 Then
            SPMove(btnComputer, x)
        End If

    End Sub
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        rollCount += 1
        If isPlaying = False Then
            PlayDiceRoll()
        End If
        lblPlayerOutcome.Hide()
        lblComputerOutcome.Hide()
        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
        lblPlayerRoll.Show()
        lblPlayerRoll.Text = x.ToString()
        If currRow Mod 2 = 0 Then
            SPMoveReversed(btnMain, x)
        ElseIf currRow Mod 2 = 1 Then
            SPMove(btnMain, x)
        End If

        turns()

    End Sub

    Private Sub SPMoveReversed(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(player)
        Dim currRow As Integer = tblBoardGame.GetRow(player)
        Dim maxCol As Integer = 9
        Dim minCol As Integer = 0
        Dim newcol As Integer = 0
        Dim tempSteps As Integer = 0
        newcol = currCol - steps

        ' -- should ideally add if gamemode = single player around this
        loadComputer()

        'condense this code and make it more efficient pls thx
        If currRow <> 0 Then ' while not in the last row
            If newcol >= minCol Then ' if the new column is larger than or equal 0
                tblBoardGame.SetColumn(player, newcol)
                chuteOrLadder(player, newcol, currRow)
            ElseIf newcol < minCol Then ' if the new column is smaller than 0
                If currCol = minCol Then ' if the player is in the last column
                    newcol = 0 + steps - 1
                    tblBoardGame.SetRow(player, currRow - 1)
                    tblBoardGame.SetColumn(player, currCol + steps - 1)
                    currRow = currRow - 1
                    chuteOrLadder(player, newcol, currRow)
                Else ' if the player is not in the last column
                    tempSteps = minCol + currCol
                    Dim remainingSteps As Integer = steps - tempSteps
                    tblBoardGame.SetColumn(player, currCol - tempSteps)
                    tblBoardGame.SetRow(player, currRow - 1)
                    currRow = currRow - 1
                    tblBoardGame.SetColumn(player, minCol + remainingSteps - 1)
                    chuteOrLadder(player, newcol, currRow)
                End If
            End If
        ElseIf currRow = 0 Then
            If newcol > minCol Then ' new column greater than 0
                tblBoardGame.SetColumn(player, newcol)
                chute(player, newcol, currRow)
            ElseIf newcol = minCol Then ' new column is 0
                tblBoardGame.SetColumn(player, newcol)
                whoWin(player)
            ElseIf newcol < minCol Then ' new column less than 
                tempSteps = minCol + currCol ' calculates steps between last column and current
                tblBoardGame.SetColumn(player, currCol - tempSteps)
                whoWin(player)
            End If
        End If

    End Sub

    Sub chuteOrLadder(player As Button, col As Integer, row As Integer)
        ladder(player, col, row)
        chute(player, col, row)
    End Sub

    Sub ladderAlert(player As Button)
        Dim username As String = lblUsername.Text
        If player.Equals(btnMain) Then
            lblPlayerOutcome.Show()
            lblPlayerOutcome.Text = username & " climbed a ladder!"
        Else
            lblComputerOutcome.Show()
            lblComputerOutcome.Text = "The computer climbed a ladder!"
        End If
    End Sub

    Sub chuteAlert(player As Button)
        Dim username As String = lblUsername.Text
        If player.Equals(btnMain) Then
            lblPlayerOutcome.Show()
            lblPlayerOutcome.Text = username & " fell down a chute!"
        Else
            lblComputerOutcome.Show()
            lblComputerOutcome.Text = "The computer fell down a chute!"
        End If
    End Sub

    Sub ladder(player As Button, col As Integer, row As Integer)
        Select Case row
            Case 9
                Select Case col
                    Case 1
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 1)
                    Case 3
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col + 2)
                    Case 7
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 3)
                        tblBoardGame.SetColumn(player, col + 2)
                End Select
            Case 7
                Select Case col
                    Case 0
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 2)
                        tblBoardGame.SetColumn(player, col + 1)
                    Case 7
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 6)
                        tblBoardGame.SetColumn(player, col - 3)
                End Select
            Case 6
                Select Case col
                    Case 4
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col - 1)
                End Select
            Case 4
                Select Case col
                    Case 9
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col - 4)
                End Select
            Case 2
                Select Case col
                    Case 9
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 2)
                    Case 0
                        ladderAlert(player)
                        tblBoardGame.SetRow(player, row - 2)
                        whoWin(player)
                End Select
        End Select
    End Sub

    Sub chute(player As Button, col As Integer, row As Integer)
        Select Case row
            Case 8
                Select Case col
                    Case 3
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 1)
                        tblBoardGame.SetColumn(player, col + 1)
                End Select
            Case 5
                Select Case col
                    Case 6
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 2)
                        tblBoardGame.SetColumn(player, col - 1)
                    Case 7
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 4)
                        tblBoardGame.SetColumn(player, col + 2)
                End Select
            Case 4
                Select Case col
                    Case 3
                        chuteAlert(player)
                        tblBoardGame.SetColumn(player, col + 4)
                End Select
            Case 3
                Select Case col
                    Case 1
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 4)
                        tblBoardGame.SetColumn(player, col + 1)
                    Case 3
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 1)
                        tblBoardGame.SetColumn(player, col - 3)
                End Select
            Case 1
                Select Case col
                    Case 5
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 6)
                        tblBoardGame.SetColumn(player, col - 2)
                End Select
            Case 0
                Select Case col
                    Case 6
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 2)
                    Case 4
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 2)
                    Case 2
                        chuteAlert(player)
                        tblBoardGame.SetRow(player, row + 2)
                End Select
        End Select
    End Sub

    Private Sub whoWin(player As Button)
        If player.Equals(btnMain) Then
            PlayWinning()
            MsgBox("Congratulations!", MsgBoxStyle.Exclamation, "WINNER WINNER CHICKEN DINNER!")
        Else
            PlayLosing()
            MsgBox("You lost to the computer, better luck next time!",
                   MsgBoxStyle.Critical, "YOU LOST TO THE COMPUTER!")
        End If
        btnReplayGame.Show()
        btnRestartGame.Show()
        btnRoll.Enabled = False
    End Sub

    Private Sub SPMove(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(player)
        Dim currRow As Integer = tblBoardGame.GetRow(player)
        Dim maxCol As Integer = 9
        Dim minCol As Integer = 0
        Dim newcol As Integer = 0

        ' -- should ideally add if gamemode = single player around this
        loadComputer()

        newcol = currCol + steps 'doesnt go past this when it goes all the way to the right
        If newcol <= maxCol Then 'if the roll is less than max columns
            tblBoardGame.SetColumn(player, newcol)
            chuteOrLadder(player, newcol, currRow)
        ElseIf newcol > maxCol Then 'if roll is greater than max columns
            If currCol = maxCol Then 'if the player is currently in the last column
                'move up a row, then move columns
                tblBoardGame.SetRow(player, currRow - 1)
                tblBoardGame.SetColumn(player, currCol - steps + 1)
                currRow = currRow - 1
                chuteOrLadder(player, newcol, currRow)
            Else 'if the player is not in the last column
                'the # of steps to get to the last column
                Dim tempSteps As Integer = maxCol - currCol
                Dim remainingSteps As Integer = steps - tempSteps
                'move to the last column
                tblBoardGame.SetColumn(player, currCol + tempSteps)
                'move up the row
                tblBoardGame.SetRow(player, currRow - 1)
                currRow = currRow - 1
                'move the remaining steps
                tblBoardGame.SetColumn(player, maxCol - remainingSteps + 1)
                chuteOrLadder(player, newcol, currRow)
            End If
        End If

    End Sub

    Sub main() 'i believe this sets up the board

        ' Add your TableLayoutPanel to your form or container.
        Dim gridSpaces(99) As gridSpace
        ' Create grid spaces array

        ' Fill the gridSpaces array in a snaking pattern
        Dim index As Integer = 0
        For i As Integer = 0 To 9
            Dim direction As Integer = If(i Mod 2 = 0, 1, -1)   ' If([T or F], if T, if F)
            Dim startColumn As Integer = If(i Mod 2 = 0, 0, 9)
            Dim endColumn As Integer = If(i Mod 2 = 0, 9, 0)

            For j As Integer = startColumn To endColumn Step direction
                gridSpaces(index) = New gridSpace(Board, i, j)
                index += 1
            Next
        Next
        btnRollNumber.Hide()
    End Sub

    Public Sub loadGame() ' resets the board w/ the same players
        frmGameSetUp.Hide()
        btnReplayGame.Hide()
        btnRestartGame.Hide()
        lblPlayerRoll.Hide()
        lblComputerRoll.Hide()
        btnRoll.Enabled = True
        btnRoll.BackColor = Color.Snow
        lblUsername.Text = frmGameSetUp.getUsername()
        lblPlayerOutcome.Hide()
        lblComputerOutcome.Hide()
        ' -- add the icon of the player
        If frmGameSetUp.gmSP = True Then
            tblBoardGame.Controls.Add(gameMode.btnMain, 0, 9)
            tblBoardGame.Controls.Add(gameMode.btnComputer, 0, 9) ' resets the computer piece but moves the player piece
            main()
        End If
        If frmGameSetUp.getMusicStatus = True Then
            cbMusic.Checked = True
            My.Computer.Audio.Play(My.Resources.lofitrack, AudioPlayMode.BackgroundLoop)
        ElseIf frmGameSetUp.getMusicStatus = False Then
            cbMusic.Checked = False
        End If
    End Sub

    Private Sub reloadGame() ' completely restarts game - sends user back to set up
        Me.Close()
        btnRoll.Enabled = True
        btnReplayGame.Hide()
        btnRestartGame.Hide()
        frmGameSetUp.loadSetUp()
        frmGameSetUp.Show()
        If isPlaying = False Then
            frmGameSetUp.isPlaying = False
        End If
    End Sub

    ' -- adds computer piece to board
    Public Sub loadComputer()
        If (rollCount = 1) Then
            tblBoardGame.Controls.Add(gameMode.btnComputer, 0, 9)
        End If
    End Sub

    Public Function getBoard()
        Return Board
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As Integer = MsgBox("Would you like to exit the application?", MsgBoxStyle.Exclamation + vbYesNo, "Exit Game?")
        If response = 6 Then
            End
        Else
            response = 0
        End If
    End Sub

    Private Sub btnReplayGame_Click(sender As Object, e As EventArgs) Handles btnReplayGame.Click
        Dim response As Integer = MsgBox("Are You Sure?", MsgBoxStyle.Exclamation + vbYesNo, "Replay Game")
        If response = 6 Then
            loadGame()
            btnReplayGame.Hide()
        Else
            response = 0
        End If
    End Sub

    Private Sub btnRestartGame_Click(sender As Object, e As EventArgs) Handles btnRestartGame.Click
        Dim response As Integer = MsgBox("Are You Sure?", MsgBoxStyle.Exclamation + vbYesNo, "Restart Game")
        If response = 6 Then
            reloadGame()
        Else
            response = 0
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Syntax Stargazer" & vbNewLine & "Version 1.2" & vbNewLine & vbNewLine & "Developers:" & vbNewLine _
       & "Lynn Cavanagh" & vbNewLine & "Emerson Kyle" & vbNewLine & "Emily Woo" & vbNewLine & "Unnati Maharjan",
       MsgBoxStyle.Information, "About")
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsToolStripMenuItem.Click
        MsgBox("1. Choose Your Mode" & vbNewLine & "2. Choose Name and Character" & vbNewLine & "3. Press 'Roll' To Play!",
        MsgBoxStyle.Information, "Instructions")
    End Sub

    Sub PlayDiceRoll()
        My.Computer.Audio.Play(My.Resources.diceroll, AudioPlayMode.Background)
    End Sub

    Sub PlayLosing()
        My.Computer.Audio.Play(My.Resources.sadtrombone, AudioPlayMode.Background)
    End Sub

    Sub PlayWinning()
        My.Computer.Audio.Play(My.Resources.cheering, AudioPlayMode.Background)
    End Sub

    Private Sub cbMusic_CheckedChanged(sender As Object, e As EventArgs) Handles cbMusic.CheckedChanged
        If cbMusic.Checked Then
            My.Computer.Audio.Play(My.Resources.lofitrack, AudioPlayMode.BackgroundLoop)
            isPlaying = True
        ElseIf cbMusic.Checked = False Then
            My.Computer.Audio.Stop()
            isPlaying = False
        End If
    End Sub
End Class

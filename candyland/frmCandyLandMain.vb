Imports System.Configuration
Imports System.Numerics
Imports System.Reflection.Metadata
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports Windows.Win32.System

Public Class frmCandyLandMain
    Public Board = tblBoardGame
    Public isBackwards As Boolean = False
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        Dim maxCol As Integer = 9
        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
        If isBackwards = False Then
            SPMove(btnMain, x)
        ElseIf isBackwards = True Then
            SPMoveReversed(btnMain, x)
        End If

    End Sub

    Private Sub SPMoveReversed(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(player)
        Dim currRow As Integer = tblBoardGame.GetRow(player)
        Dim maxCol As Integer = 9
        Dim minCol As Integer = 0
        Dim newcol As Integer = 0
        Dim tempSteps As Integer = 0
        newcol = currCol - steps
        'condense this code and make it more efficient pls thx
        If currRow <> 0 Then ' while not in the last row
            If newcol >= minCol Then ' if the new column is larger than or equal 0
                tblBoardGame.SetColumn(player, newcol)
            ElseIf newcol < minCol Then ' if the new column is smaller than 0
                If currCol = minCol Then ' if the player is in the last column
                    tblBoardGame.SetRow(player, currRow - 1)
                    tblBoardGame.SetColumn(player, currCol + steps - 1)
                    isBackwards = False
                Else ' if the player is not in the last column
                    tempSteps = minCol + currCol
                    Dim remainingSteps As Integer = steps - tempSteps
                    tblBoardGame.SetColumn(player, currCol - tempSteps)
                    tblBoardGame.SetRow(player, currRow - 1)
                    tblBoardGame.SetColumn(player, minCol + remainingSteps - 1)
                    isBackwards = False
                End If
            End If
        ElseIf currRow = 0 Then
            If newcol > minCol Then ' new column greater than 0
                tblBoardGame.SetColumn(player, newcol)
            ElseIf newcol = minCol Then ' new column is 0
                tblBoardGame.SetColumn(player, newcol)
                playerWin()
            ElseIf newcol < minCol Then ' new column less than 
                tempSteps = minCol + currCol ' calculates steps between last column and current
                tblBoardGame.SetColumn(player, currCol - tempSteps)
                playerWin()
            End If
        End If

    End Sub

    Private Sub playerWin()
        MsgBox("Congratulations! You Won!")
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
        newcol = currCol + steps 'doesnt go past this when it goes all the way to the right
        If newcol <= maxCol Then 'if the roll is less than max columns
            tblBoardGame.SetColumn(player, newcol)
        ElseIf newcol > maxCol Then 'if roll is greater than max columns
            If currCol = maxCol Then 'if the player is currently in the last column
                'move up a row, then move columns
                tblBoardGame.SetRow(player, currRow - 1)
                tblBoardGame.SetColumn(player, currCol - steps + 1)
                isBackwards = True
            Else 'if the player is not in the last column
                'the # of steps to get to the last column
                Dim tempSteps As Integer = maxCol - currCol
                Dim remainingSteps As Integer = steps - tempSteps
                'move to the last column
                tblBoardGame.SetColumn(player, currCol + tempSteps)
                'move up the row
                tblBoardGame.SetRow(player, currRow - 1)
                'move the remaining steps
                tblBoardGame.SetColumn(player, maxCol - remainingSteps + 1)
                isBackwards = True
            End If
        End If

    End Sub

    Function playerturn() As String
        'display name of player whos turn it is using a for loop 
    End Function

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
    End Sub

    Public Sub loadGame() ' resets the board w/ the same players
        frmGameSetUp.Hide()
        btnReplayGame.Hide()
        btnRestartGame.Hide()
        btnRoll.Enabled = True
        btnRoll.BackColor = Color.Gray
        isBackwards = False
        lblUsername.Text = frmGameSetUp.getUsername()
        If frmGameSetUp.gmSP = True Then
            tblBoardGame.Controls.Add(gameMode.btnMain, 0, 9)
            main()
        End If
    End Sub

    Private Sub reloadGame() ' completely restarts game - sends user back to set up
        Me.Close()
        btnRoll.Enabled = True
        isBackwards = False
        btnReplayGame.Hide()
        btnRestartGame.Hide()
        frmGameSetUp.loadSetUp()
        frmGameSetUp.Show()
    End Sub

    Public Function getBoard()
        Return Board
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnReplayGame_Click(sender As Object, e As EventArgs) Handles btnReplayGame.Click
        loadGame()
        btnReplayGame.Hide()
    End Sub

    Private Sub btnRestartGame_Click(sender As Object, e As EventArgs) Handles btnRestartGame.Click
        reloadGame()
    End Sub
End Class

Imports System.Configuration
Imports System.Diagnostics.Eventing.Reader
Imports System.DirectoryServices.ActiveDirectory
Imports System.Globalization
Imports System.IO
Imports System.Numerics
Imports System.Reflection.Metadata
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates
Imports Windows.Win32.System

Public Class frmCandyLandMain
    Public Board = tblBoardGame

    Public rollCount As Integer = 0


    ' -- uses even or odd to determine if it's the player or computer's turn
    ' -- player goes first so player is odd
    Private Sub turns()
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
        Dim currCol As Integer = tblBoardGame.GetColumn(btnComputer)
        Dim currRow As Integer = tblBoardGame.GetRow(btnComputer)
        Dim maxCol As Integer = 9

        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled

        If currRow Mod 2 = 0 Then
            SPMoveReversed(btnComputer, x)
        ElseIf currRow Mod 2 = 1 Then
            SPMove(btnComputer, x)
        End If


    End Sub
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        Dim maxCol As Integer = 9
        rollCount += 1
        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
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
                chute(player, newcol, currRow)
                ladder(player, newcol, currRow)
            ElseIf newcol < minCol Then ' if the new column is smaller than 0
                If currCol = minCol Then ' if the player is in the last column
                    tblBoardGame.SetRow(player, currRow - 1)
                    tblBoardGame.SetColumn(player, currCol + steps - 1)
                Else ' if the player is not in the last column
                    tempSteps = minCol + currCol
                    Dim remainingSteps As Integer = steps - tempSteps
                    tblBoardGame.SetColumn(player, currCol - tempSteps)
                    tblBoardGame.SetRow(player, currRow - 1)
                    tblBoardGame.SetColumn(player, minCol + remainingSteps - 1)
                End If
            End If
        ElseIf currRow = 0 Then
            If newcol > minCol Then ' new column greater than 0
                tblBoardGame.SetColumn(player, newcol)
                chute(player, newcol, currRow)
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

    Sub ladder(player As Button, col As Integer, row As Integer)
        Select Case row
            Case 9
                Select Case col
                    Case 1
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 1)
                    Case 3
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col + 3)
                    Case 7
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 3)
                        tblBoardGame.SetColumn(player, col + 2)
                End Select
            Case 7
                Select Case col
                    Case 0
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 2)
                        tblBoardGame.SetColumn(player, col + 1)
                    Case 7
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 6)
                        tblBoardGame.SetColumn(player, col - 4)
                End Select
            Case 6
                Select Case col
                    Case 4
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col - 1)
                End Select
            Case 4
                Select Case col
                    Case 9
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 1)
                        tblBoardGame.SetColumn(player, col - 3)
                End Select
            Case 2
                Select Case col
                    Case 9
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 2)
                    Case 0
                        MsgBox("You found a ladder!")
                        tblBoardGame.SetRow(player, row - 2)
                        playerWin()
                End Select
        End Select
    End Sub

    Sub chute(player As Button, col As Integer, row As Integer)
        Select Case row
            Case 8
                Select Case col
                    Case 4
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 1)
                        tblBoardGame.SetColumn(player, col + 1)
                End Select
            Case 5
                Select Case col
                    Case 7
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 2)
                        tblBoardGame.SetColumn(player, col - 1)
                    Case 8
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 4)
                        tblBoardGame.SetColumn(player, col + 1)
                End Select
            Case 4
                Select Case col
                    Case 4
                        MsgBox("You found a chute!")
                        tblBoardGame.SetColumn(player, col + 3)
                End Select
            Case 3
                Select Case col
                    Case 1
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 5)
                        tblBoardGame.SetColumn(player, col + 1)
                    Case 3
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 1)
                        tblBoardGame.SetColumn(player, col - 3)
                End Select
            Case 1
                Select Case col
                    Case 6
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 6)
                        tblBoardGame.SetColumn(player, col - 3)
                End Select
            Case 0
                Select Case col
                    Case 7
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 2)
                    Case 5
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 2)
                    Case 2
                        MsgBox("You found a chute!")
                        tblBoardGame.SetRow(player, row + 2)
                End Select
        End Select
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

        ' -- should ideally add if gamemode = single player around this
        loadComputer()

        newcol = currCol + steps 'doesnt go past this when it goes all the way to the right
        If newcol <= maxCol Then 'if the roll is less than max columns
            tblBoardGame.SetColumn(player, newcol)
            ladder(player, newcol, currRow)
            chute(player, newcol, currRow)
        ElseIf newcol > maxCol Then 'if roll is greater than max columns
            If currCol = maxCol Then 'if the player is currently in the last column
                'move up a row, then move columns
                tblBoardGame.SetRow(player, currRow - 1)
                tblBoardGame.SetColumn(player, currCol - steps + 1)
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
        lblUsername.Text = frmGameSetUp.getUsername()
        ' -- add the icon of the player
        If frmGameSetUp.gmSP = True Then
            tblBoardGame.Controls.Add(gameMode.btnMain, 0, 9)
            main()
        End If
    End Sub

    Private Sub reloadGame() ' completely restarts game - sends user back to set up
        Me.Close()
        btnRoll.Enabled = True
        btnReplayGame.Hide()
        btnRestartGame.Hide()
        frmGameSetUp.loadSetUp()
        frmGameSetUp.Show()
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
        End
    End Sub

    Private Sub btnReplayGame_Click(sender As Object, e As EventArgs) Handles btnReplayGame.Click
        loadGame()
        btnReplayGame.Hide()
    End Sub

    Private Sub btnRestartGame_Click(sender As Object, e As EventArgs) Handles btnRestartGame.Click
        reloadGame()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tblBoardGame_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btnFrog.Click

    End Sub

    Private Sub frmCandyLandMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btnBunny.Click

    End Sub
End Class

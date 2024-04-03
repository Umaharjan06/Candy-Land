Imports System.Configuration
Imports System.Reflection.Metadata
Imports System.Runtime.CompilerServices

Public Class frmCandyLandMain
    Public Board = tblBoardGame
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        btnRoll.BackColor = Color.Green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)
        MsgBox(x) ' test passed, it displays correct
        SPMove(btnMain, x)
    End Sub

    Private Sub SPMoveReversed(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain) 'gets column(0)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain) 'gets row(9)
        Dim newCol As Integer
        Dim minCol As Integer = 0
        newCol = currCol - steps
        If newCol < minCol Then
            'newCol = currCol - steps
            tblBoardGame.SetRow(btnMain, currRow - 1)
            newCol = minCol
            SPMove(btnMain, steps)
        End If
        tblBoardGame.SetColumn(btnMain, newCol)
    End Sub

    Private Sub SPMove(player As Button, steps As Integer)
        'Dim playerMove As Integer = displayMove.DisplayColor(btnRollNumber) 'gets whatever random number is returned by the roll function
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain) 'gets column(0)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain) 'gets row(9)
        Dim maxCol As Integer = 9

        Dim newCol As Integer ' = currCol + steps
        Dim newRow As Integer 'might not use
        newCol = currCol + steps 'doesnt go past this when it goes all the way to the right
        If newCol > maxCol Then
            tblBoardGame.SetRow(btnMain, currRow - 1)
            newCol = maxCol
            currCol = maxCol
            SPMoveReversed(btnMain, steps)
        End If
        tblBoardGame.SetColumn(btnMain, newCol)

        '''Right now the singleplayer goes from left to right, and up op row
        '''instead of throwing null as it goes off the fixed board. need to 
        '''figure out how to reverse the directed and continure it throughout
        '''the program throught some kind of loop?
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
            Dim direction As Integer = If(i Mod 2 = 0, 1, -1)
            Dim startColumn As Integer = If(i Mod 2 = 0, 0, 9)
            Dim endColumn As Integer = If(i Mod 2 = 0, 9, 0)

            For j As Integer = startColumn To endColumn Step direction
                gridSpaces(index) = New gridSpace(Board, i, j)
                index += 1
            Next
        Next
    End Sub

    Private Sub frmCandyLandMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmGameSetUp.Hide()
        lblUsername.Text = frmGameSetUp.getUsername()
        If frmGameSetUp.gmSP = True Then
            tblBoardGame.Controls.Add(gameMode.btnMain, 0, 9)
            main()

        End If

    End Sub

    Public Function getBoard()
        Return Board
    End Function

End Class

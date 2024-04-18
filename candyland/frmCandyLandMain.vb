Imports System.Configuration
Imports System.Reflection.Metadata
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography.X509Certificates

Public Class frmCandyLandMain
    Public Board = tblBoardGame
    Public isBackwards As Boolean = False
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        Dim maxCol As Integer = 9
        btnRoll.BackColor = Color.Green ' changes the icon roll icon back to green
        displayMove.DisplayColor(btnRollNumber) ' shows the number that was rolled
        Dim x As Integer = displayMove.DisplayColor(btnRollNumber)  '** need to fix the random method, it ain't random lmao (displayMove.vb)**
        MsgBox(x) ' test passed, it displays correct
        If isBackwards = False Then
            SPMove(btnMain, x)
        ElseIf isBackwards = True Then
            SPMoveReversed(btnMain, x)
        End If

    End Sub

    Private Sub SPMoveReversed(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        Dim maxCol As Integer = 9
        Dim minCol As Integer = 0
        Dim newcol As Integer
        newcol = currCol - steps
        If newcol >= minCol Then
            tblBoardGame.SetColumn(btnMain, newcol)
        ElseIf newcol < minCol Then
            newcol = minCol
            tblBoardGame.SetRow(btnMain, currRow - 1)
            tblBoardGame.SetColumn(btnMain, newcol + steps)
            isBackwards = False
        End If

    End Sub

    Private Sub SPMove(player As Button, steps As Integer)
        Dim currCol As Integer = tblBoardGame.GetColumn(btnMain)
        Dim currRow As Integer = tblBoardGame.GetRow(btnMain)
        Dim maxCol As Integer = 9
        Dim minCol As Integer = 0
        Dim newcol As Integer
        newcol = currCol + steps 'doesnt go past this when it goes all the way to the right
        If newcol <= maxCol Then
            tblBoardGame.SetColumn(btnMain, newcol)
        ElseIf newcol > maxCol Then
            newcol = maxCol
            tblBoardGame.SetRow(btnMain, currRow - 1)
            tblBoardGame.SetColumn(btnMain, newcol - steps)
            isBackwards = True
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

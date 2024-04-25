Imports System.Security.Cryptography.X509Certificates

Public Class frmGameSetUp
    Public singlePlayerUsername As String
    Public gmSP As Boolean

    ' -- stores all the usernames
    Public usernames(4) As String
    ' -- counts how many players
    Public usernamesIndex As Integer = 0

    ' -- "Enter" Game Mode button
    ' First Button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnChooseMode.Click
        Dim strChoice As String = ""
        If cboGameType.SelectedIndex = -1 Then
            MsgBox("Please Pick A Mode!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
        Else
            strChoice = cboGameType.SelectedItem.ToString()
            lblSetUp.Text = "Name:"
        End If
        ' -- SINGLE PLAYER
        If strChoice = "Single Player" Then
            gmSP = True
            cboGameType.Hide() : txtNames.Show()
            btnChooseMode.Hide() : btnSinglePlayerName.Show()
            cboColorPicker.Show() : btnSPChooseColor.Show()
            ' 2 MULTIPLAYER
        ElseIf strChoice = "Multi-Player (2 players)" Then
            'MsgBox(strChoice & " Not yet implemented", MsgBoxStyle.Information, "Soon to come!")
            gmSP = True
            lblSetUp.Text = "Player 1 Name:"
            btnChooseMode.Hide()
            cboGameType.Hide()
            txtNames.Show()
            btnPlayer1Name.Show()


        ElseIf strChoice = "Multi-Player (3 players)" Then
            MsgBox(strChoice & " Not yet implemented", MsgBoxStyle.Information, "Soon to come!")
        ElseIf strChoice = "Multi-Player (4 players)" Then
            MsgBox(strChoice & " Not yet implemented", MsgBoxStyle.Information, "Soon to come!")
        End If
    End Sub

    Private Sub frmGameSetUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSetUp()
    End Sub

    Public Sub loadSetUp()
        cboGameType.Show()
        btnChooseMode.Show()
        cboColorPicker.Hide()
        btnSPChooseColor.Hide()
        btnSinglePlayerName.Hide()
        txtNames.Hide()
    End Sub

    ' -- "Enter" Name button
    ' -- Second Button
    Private Sub btnName1_Click(sender As Object, e As EventArgs) Handles btnSinglePlayerName.Click
        If txtNames.Text = "" Then
            MsgBox("Please Enter A Name!", MsgBoxStyle.Critical, "Error! You need to pick a name!")
        Else
            singlePlayerUsername = txtNames.Text
            ' -- add username to array
            usernames(0) = txtNames.Text
            usernamesIndex += 1
            ' -- change label text
            lblSetUp.Text = "Select Character:"
            'lblGameMode.Hide()
            txtNames.Hide() : btnSinglePlayerName.Hide()
        End If
    End Sub

    ' -- Multiplayer Player 1 Enter Name button
    Private Sub btnPlayer1Name_Click(sender As Object, e As EventArgs) Handles btnPlayer1Name.Click
        If txtNames.Text = "" Then
            MsgBox("Please Enter A Name!", MsgBoxStyle.Critical, "Error! You need to pick a name!")
        Else
            singlePlayerUsername = txtNames.Text
            ' -- add username to array
            storeUsername(txtNames.Text)

            ' -- hide old
            txtNames.Hide() : btnPlayer1Name.Hide()
            ' -- show new
            lblSetUp.Text = "Select Character:"
            btnP1ChooseColor.Show()
            cboColorPicker.Show()
        End If
    End Sub

    ' -- "Start!" Button
    ' -- Third / Final button
    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnSPChooseColor.Click
        Dim strColorChoice = ""
        If cboColorPicker.SelectedIndex = -1 Then
            MsgBox("Please Pick A Character!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
            Exit Sub
        Else
            strColorChoice = cboColorPicker.SelectedItem.ToString
            setCharacter(strColorChoice)
        End If
        frmCandyLandMain.loadGame()

    End Sub

    ' -- Multiplayer Player 1 Choose character button
    Private Sub btnP1ChooseColor_Click(sender As Object, e As EventArgs) Handles btnP1ChooseColor.Click
        Dim strColorChoice As String = ""
        If cboColorPicker.SelectedIndex = -1 Then
            MsgBox("Please Pick A Color!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
            Exit Sub
        Else
            strColorChoice = cboColorPicker.SelectedItem.ToString()

            ' -- this
            'Player1_ColorPicker(strColorChoice)

        End If
        ' frmCandyLandMain.loadGame()
    End Sub

    ' -- stores username and adds 1 to the index
    Public Sub storeUsername(UN)
        usernames(usernamesIndex) = UN
        usernamesIndex += 1
    End Sub


    Public Function getUsername()
        Return singlePlayerUsername
    End Function

End Class
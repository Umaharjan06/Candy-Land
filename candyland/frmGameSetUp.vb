Imports System.Security.Cryptography.X509Certificates

Public Class frmGameSetUp
    Public singlePlayerUsername As String
    Public gmSP As Boolean
    Public isPlaying As Boolean = True

    ' -- "Enter" Game Mode button
    ' First Button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnChooseMode.Click
        Dim strChoice As String = ""
        If cboGameType.SelectedIndex = -1 Then
            MsgBox("Please Pick A Mode!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
        Else
            strChoice = cboGameType.SelectedItem.ToString()
            lblGameMode.Hide()
            lblEnterName.Show()
        End If

        If strChoice = "Single Player" Then
            gmSP = True
            cboGameType.Hide() : txtNames.Show()
            btnChooseMode.Hide() : btnName1.Show()
            cboColorPicker.Show() : btnChooseColor.Show()
        ElseIf strChoice = "Multi-Player (2 players)" Then
            MsgBox(strChoice & " Not yet implemented", MsgBoxStyle.Information, "Soon to come!")
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
        btnChooseColor.Hide()
        btnName1.Hide()
        txtNames.Hide()
        cbMusic.Checked = True
        My.Computer.Audio.Play(My.Resources.lofitrack, AudioPlayMode.BackgroundLoop)
    End Sub

    ' -- "Start!" Button
    ' -- Third / Final button
    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        Dim strColorChoice As String = ""
        If cboColorPicker.SelectedIndex = -1 Then
            MsgBox("Please Pick A Color!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
            Exit Sub
        Else
            strColorChoice = cboColorPicker.SelectedItem.ToString()
            Singleplayer_ColorPicker(strColorChoice)
        End If
        frmCandyLandMain.loadGame()

    End Sub

    ' -- "Enter" Name button
    ' -- Second Button
    Private Sub btnName1_Click(sender As Object, e As EventArgs) Handles btnName1.Click
        If txtNames.Text = "" Then
            MsgBox("Please Enter A Name!", MsgBoxStyle.Critical, "Error! You need to pick a name!")
        Else
            singlePlayerUsername = txtNames.Text
            lblGameMode.Hide()
            lblEnterName.Hide()
            lblPlayerColor.Show()
            txtNames.Hide() : btnName1.Hide()
        End If
    End Sub

    Public Function getUsername()
        Return singlePlayerUsername
    End Function
    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        MsgBox("Getting started:
 1. Select a game mode (This version currently does not support mulitplayer)
2. Choose an in game username (must be at least 1 character)
3. Select an avatar! The options are displayed in the background.

You are set to play! Hit the 'Start!' Button to enter the game.
Single player mode supports gameplay against a computer opponent. First to the top left wins. Have fun!
",
               MsgBoxStyle.Information, "How to Play")
    End Sub

    Public Function getMusicStatus()
        Return isPlaying
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbMusic.CheckedChanged
        If cbMusic.Checked Then
            My.Computer.Audio.Play(My.Resources.lofitrack, AudioPlayMode.BackgroundLoop)
            isPlaying = True
        ElseIf cbMusic.Checked = False Then
            My.Computer.Audio.Stop()
            isPlaying = False
        End If

    End Sub
End Class
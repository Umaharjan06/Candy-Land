Imports System.Linq.Expressions
Imports System.Security.Cryptography.X509Certificates

Public Class frmGameSetUp
    Public singlePlayerUsername As String
    Public gmSP As Boolean

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
    End Sub

    ' -- "Start!" Button
    ' -- Third / Final button
    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        Dim strColorChoice As String = ""
        If cboColorPicker.SelectedIndex = -1 Then
            MsgBox("Please Pick A Character!", MsgBoxStyle.Critical, "Error! You need to pick a character!")
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

    Private Sub txtNames_TextChanged(sender As Object, e As EventArgs) Handles txtNames.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEnterName.Click

    End Sub

    Private Sub btnStart_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
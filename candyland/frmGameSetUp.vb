Imports System.Security.Cryptography.X509Certificates

Public Class frmGameSetUp
    Public singlePlayerUsername As String
    Public gmSP As Boolean
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim strChoice As String = ""
        If cboGameType.SelectedIndex = -1 Then
            MsgBox("Please Pick A Mode!")
        Else
            strChoice = cboGameType.SelectedItem.ToString()
        End If

        If strChoice = "Single Player" Then
            gmSP = True
            cboGameType.Hide() : txtNames.Show()
            btnStart.Hide() : btnName1.Show()
            cboColorPicker.Show() : btnChooseColor.Show()
        ElseIf strChoice = "Multi-Player (2 players)" Then
            MsgBox(strChoice & " Not yet implemented")
        ElseIf strChoice = "Multi-Player (3 players)" Then
            MsgBox(strChoice & " Not yet implemented")
        ElseIf strChoice = "Multi-Player (4 players)" Then
            MsgBox(strChoice & " Not yet implemented")
        End If
    End Sub

    Private Sub frmGameSetUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSetUp()
    End Sub

    Public Sub loadSetUp()
        cboGameType.Show()
        btnStart.Show()
        cboColorPicker.Hide()
        btnChooseColor.Hide()
        btnName1.Hide()
        txtNames.Hide()
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        Dim strColorChoice As String = ""
        If cboColorPicker.SelectedIndex = -1 Then
            MsgBox("Please Pick A Color!")
        Else
            strColorChoice = cboColorPicker.SelectedItem.ToString()
            Singleplayer_ColorPicker(strColorChoice)
        End If
        frmCandyLandMain.loadGame()

    End Sub

    Private Sub btnName1_Click(sender As Object, e As EventArgs) Handles btnName1.Click
        If txtNames.Text = "" Then
            MsgBox("Please Enter A Name!")
        Else
            singlePlayerUsername = txtNames.Text
            txtNames.Hide() : btnName1.Hide()
        End If
    End Sub

    Public Function getUsername()
        Return singlePlayerUsername
    End Function
End Class
Imports System.Security.Cryptography.X509Certificates

Public Class frmGameSetUp
    Public singlePlayerUsername As String
    Public gmSP As Boolean
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim strChoice As String = cboGameType.SelectedItem.ToString()

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
        cboColorPicker.Hide()
        btnChooseColor.Hide()
        btnName1.Hide()
        txtNames.Hide()
    End Sub

    Private Sub btnChooseColor_Click(sender As Object, e As EventArgs) Handles btnChooseColor.Click
        Dim strColorChoice As String = cboColorPicker.SelectedItem.ToString()
        Singleplayer_ColorPicker(strColorChoice)

    End Sub

    Private Sub btnName1_Click(sender As Object, e As EventArgs) Handles btnName1.Click
        singlePlayerUsername = txtNames.Text
        txtNames.Hide() : btnName1.Hide()
        'cboColorPicker.Show() : btnChooseColor.Show()
    End Sub

    Public Function getUsername()
        Return singlePlayerUsername
    End Function
    'Public Function isSinglePlayer()
    'Return gmSP
    'End Function
End Class
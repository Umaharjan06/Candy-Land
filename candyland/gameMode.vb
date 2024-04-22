Imports System.Drawing.Text
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography.X509Certificates

Module gameMode
    'Public Username As frmGameSetUp
    Public btnMain As Button
    Public Sub Singleplayer_ColorPicker(colorChoice)
        If colorChoice = "Red" Then
            btnMain = frmCandyLandMain.btn5
            frmCandyLandMain.Show()
            frmCandyLandMain.btn1.Hide() : frmCandyLandMain.btn4.Hide()
            frmCandyLandMain.btn3.Hide() : frmCandyLandMain.btn2.Hide()
            frmCandyLandMain.btn5.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Yellow" Then
            btnMain = frmCandyLandMain.btn4
            frmCandyLandMain.Show()
            frmCandyLandMain.btn1.Hide() : frmCandyLandMain.btn2.Hide()
            frmCandyLandMain.btn3.Hide() : frmCandyLandMain.btn5.Hide()
            frmCandyLandMain.btn4.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Green" Then
            btnMain = frmCandyLandMain.btn3
            frmCandyLandMain.Show()
            frmCandyLandMain.btn1.Hide() : frmCandyLandMain.btn2.Hide()
            frmCandyLandMain.btn4.Hide() : frmCandyLandMain.btn5.Hide()
            frmCandyLandMain.btn3.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Blue" Then
            btnMain = frmCandyLandMain.btn2
            frmCandyLandMain.Show()
            frmCandyLandMain.btn1.Hide() : frmCandyLandMain.btn3.Hide()
            frmCandyLandMain.btn4.Hide() : frmCandyLandMain.btn5.Hide()
            frmCandyLandMain.btn2.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Pink" Then
            btnMain = frmCandyLandMain.btn1
            frmCandyLandMain.Show()
            frmCandyLandMain.btn2.Hide() : frmCandyLandMain.btn3.Hide()
            frmCandyLandMain.btn4.Hide() : frmCandyLandMain.btn5.Hide()
            frmCandyLandMain.btn1.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)
        End If
    End Sub


End Module

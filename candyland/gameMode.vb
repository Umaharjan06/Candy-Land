Imports System.Drawing.Text
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography.X509Certificates

Module gameMode
    'Public Username As frmGameSetUp
    Public btnMain As Button
    Public Sub Singleplayer_ColorPicker(colorChoice)
        If colorChoice = "Fox" Then
            btnMain = frmCandyLandMain.btnFox
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() : frmCandyLandMain.btnBunny.Hide()
            frmCandyLandMain.btnFrog.Hide() : frmCandyLandMain.btnDog.Hide()
            frmCandyLandMain.btnFoxIcon.Show()
            ' -- frmCandyLandMain.btnFox.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Bunny" Then
            btnMain = frmCandyLandMain.btnBunny
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() : frmCandyLandMain.btnDog.Hide()
            frmCandyLandMain.btnFrog.Hide() : frmCandyLandMain.btnFox.Hide()
            frmCandyLandMain.btnBunnyIcon.Show()
            ' -- frmCandyLandMain.btnBunny.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Frog" Then
            btnMain = frmCandyLandMain.btnFrog
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() : frmCandyLandMain.btnDog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            frmCandyLandMain.btnFrogIcon.Show()
            ' -- frmCandyLandMain.btnFrog.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Dog" Then
            btnMain = frmCandyLandMain.btnDog
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() : frmCandyLandMain.btnFrog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            frmCandyLandMain.btnDogIcon.Show()
            ' -- frmCandyLandMain.btnDog.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

        ElseIf colorChoice = "Cat" Then
            btnMain = frmCandyLandMain.btnCat
            frmCandyLandMain.Show()
            frmCandyLandMain.btnDog.Hide() : frmCandyLandMain.btnFrog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            frmCandyLandMain.btnCatIcon.Show()
            ' -- frmCandyLandMain.btnCat.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)
        End If
    End Sub


End Module

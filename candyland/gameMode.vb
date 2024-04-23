Imports System.Drawing.Text
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.Devices

Module gameMode
    'Public Username As frmGameSetUp
    Public btnMain As Button
    Public btnComputer As Button

    Public Sub Singleplayer_ColorPicker(colorChoice)

        If colorChoice = "Fox" Then
            ' -- set computer to dog
            btnComputer = frmCandyLandMain.btnDog
            frmCandyLandMain.btnP2dog.Show()
            frmCandyLandMain.lblPlayer2Name.Text = "Computer"

            btnMain = frmCandyLandMain.btnFox
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() : frmCandyLandMain.btnBunny.Hide()
            frmCandyLandMain.btnFrog.Hide() ' : frmCandyLandMain.btnDog.Hide() -- unhiding to test for "computer" player
            ' frmCandyLandMain.btnFox.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

            ' -- set icon to select animal
            frmCandyLandMain.btnFoxIcon.BackColor = Color.Transparent
            frmCandyLandMain.btnFoxIcon.Show()

        ElseIf colorChoice = "Bunny" Then
            ' -- set computer to dog
            btnComputer = frmCandyLandMain.btnDog
            frmCandyLandMain.btnP2dog.Show()
            frmCandyLandMain.lblPlayer2Name.Text = "Computer"

            btnMain = frmCandyLandMain.btnBunny
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() ': frmCandyLandMain.btnDog.Hide()
            frmCandyLandMain.btnFrog.Hide() : frmCandyLandMain.btnFox.Hide()
            ' frmCandyLandMain.btnBunny.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

            ' -- set icon to select animal
            frmCandyLandMain.btnBunnyIcon.BackColor = Color.Transparent
            frmCandyLandMain.btnBunnyIcon.Show()

        ElseIf colorChoice = "Frog" Then
            ' -- set computer to dog
            btnComputer = frmCandyLandMain.btnDog
            frmCandyLandMain.btnP2dog.Show()
            frmCandyLandMain.lblPlayer2Name.Text = "Computer"

            btnMain = frmCandyLandMain.btnFrog
            frmCandyLandMain.btnFrog.BackColor = Color.Transparent

            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() ': frmCandyLandMain.btnDog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            ' frmCandyLandMain.btnFrog.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

            ' -- set icon to select animal
            frmCandyLandMain.btnFrogIcon.BackColor = Color.Transparent
            frmCandyLandMain.btnFrogIcon.Show()

        ElseIf colorChoice = "Dog" Then
            ' -- set computer to frog
            btnComputer = frmCandyLandMain.btnFrog
            frmCandyLandMain.btnFrog.BackColor = Color.Transparent
            frmCandyLandMain.btnP2frog.BackColor = Color.Transparent
            frmCandyLandMain.btnP2frog.Show()
            frmCandyLandMain.lblPlayer2Name.Text = "Computer"

            btnMain = frmCandyLandMain.btnDog
            frmCandyLandMain.Show()
            frmCandyLandMain.btnCat.Hide() ': frmCandyLandMain.btnFrog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            ' frmCandyLandMain.btnDog.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

            ' -- set icon to select animal
            frmCandyLandMain.btnDogIcon.BackColor = Color.Transparent
            frmCandyLandMain.btnDogIcon.Show()

        ElseIf colorChoice = "Cat" Then
            ' -- set computer to frog
            btnComputer = frmCandyLandMain.btnFrog
            frmCandyLandMain.btnP2frog.BackColor = Color.Transparent
            frmCandyLandMain.btnP2frog.Show()
            frmCandyLandMain.lblPlayer2Name.Text = "Computer"

            btnMain = frmCandyLandMain.btnCat
            frmCandyLandMain.Show()
            frmCandyLandMain.btnDog.Hide() ': frmCandyLandMain.btnFrog.Hide()
            frmCandyLandMain.btnBunny.Hide() : frmCandyLandMain.btnFox.Hide()
            ' frmCandyLandMain.btnCat.Text = frmGameSetUp.getUsername.ToString.Substring(0, 1)

            ' -- set icon to select animal
            frmCandyLandMain.btnCatIcon.BackColor = Color.Transparent
            frmCandyLandMain.btnCatIcon.Show()
        End If
    End Sub


End Module

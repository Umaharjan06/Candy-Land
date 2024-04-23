<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCandyLandMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCandyLandMain))
        btnCat = New Button()
        btnDog = New Button()
        btnFrog = New Button()
        btnBunny = New Button()
        btnRoll = New Button()
        btnRollNumber = New Button()
        tblBoardGame = New TableLayoutPanel()
        btnFox = New Button()
        lblUsername = New Label()
        btnExit = New Button()
        btnReplayGame = New Button()
        btnRestartGame = New Button()
        btnFrogIcon = New Button()
        btnDogIcon = New Button()
        btnFoxIcon = New Button()
        btnBunnyIcon = New Button()
        btnCatIcon = New Button()
        btnP2frog = New Button()
        btnP2dog = New Button()
        lblPlayer2Name = New Label()
        lblPlayerRoll = New Label()
        lblComputerRoll = New Label()
        SuspendLayout()
        ' 
        ' btnCat
        ' 
        btnCat.BackColor = Color.Transparent
        btnCat.BackgroundImage = CType(resources.GetObject("btnCat.BackgroundImage"), Image)
        btnCat.BackgroundImageLayout = ImageLayout.Stretch
        btnCat.FlatAppearance.BorderSize = 0
        btnCat.FlatStyle = FlatStyle.Flat
        btnCat.Location = New Point(1661, 726)
        btnCat.Margin = New Padding(6, 4, 6, 4)
        btnCat.Name = "btnCat"
        btnCat.Size = New Size(82, 94)
        btnCat.TabIndex = 0
        btnCat.UseVisualStyleBackColor = False
        ' 
        ' btnDog
        ' 
        btnDog.BackColor = Color.Transparent
        btnDog.BackgroundImage = CType(resources.GetObject("btnDog.BackgroundImage"), Image)
        btnDog.BackgroundImageLayout = ImageLayout.Stretch
        btnDog.FlatAppearance.BorderSize = 0
        btnDog.FlatStyle = FlatStyle.Flat
        btnDog.Location = New Point(141, 1190)
        btnDog.Margin = New Padding(6, 4, 6, 4)
        btnDog.Name = "btnDog"
        btnDog.Size = New Size(82, 94)
        btnDog.TabIndex = 1
        btnDog.UseVisualStyleBackColor = False
        ' 
        ' btnFrog
        ' 
        btnFrog.BackColor = SystemColors.Control
        btnFrog.BackgroundImage = CType(resources.GetObject("btnFrog.BackgroundImage"), Image)
        btnFrog.BackgroundImageLayout = ImageLayout.Stretch
        btnFrog.FlatAppearance.BorderSize = 0
        btnFrog.FlatStyle = FlatStyle.Flat
        btnFrog.Location = New Point(141, 1190)
        btnFrog.Margin = New Padding(6, 4, 6, 4)
        btnFrog.Name = "btnFrog"
        btnFrog.Size = New Size(82, 94)
        btnFrog.TabIndex = 2
        btnFrog.UseVisualStyleBackColor = False
        ' 
        ' btnBunny
        ' 
        btnBunny.BackColor = Color.Transparent
        btnBunny.BackgroundImage = CType(resources.GetObject("btnBunny.BackgroundImage"), Image)
        btnBunny.BackgroundImageLayout = ImageLayout.Stretch
        btnBunny.FlatAppearance.BorderSize = 0
        btnBunny.FlatStyle = FlatStyle.Flat
        btnBunny.Location = New Point(1568, 726)
        btnBunny.Margin = New Padding(6, 4, 6, 4)
        btnBunny.Name = "btnBunny"
        btnBunny.Size = New Size(82, 94)
        btnBunny.TabIndex = 3
        btnBunny.UseVisualStyleBackColor = False
        ' 
        ' btnRoll
        ' 
        btnRoll.BackColor = Color.Snow
        btnRoll.Location = New Point(1455, 204)
        btnRoll.Margin = New Padding(6, 4, 6, 4)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(269, 126)
        btnRoll.TabIndex = 162
        btnRoll.Text = "Roll!"
        btnRoll.UseVisualStyleBackColor = False
        ' 
        ' btnRollNumber
        ' 
        btnRollNumber.BackColor = Color.Snow
        btnRollNumber.Location = New Point(1455, 336)
        btnRollNumber.Margin = New Padding(2)
        btnRollNumber.Name = "btnRollNumber"
        btnRollNumber.Size = New Size(269, 279)
        btnRollNumber.TabIndex = 165
        btnRollNumber.Text = "n/a"
        btnRollNumber.UseVisualStyleBackColor = False
        ' 
        ' tblBoardGame
        ' 
        tblBoardGame.BackColor = Color.OldLace
        tblBoardGame.BackgroundImage = My.Resources.Resources.snakesandladder1
        tblBoardGame.BackgroundImageLayout = ImageLayout.Stretch
        tblBoardGame.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        tblBoardGame.ColumnCount = 10
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        tblBoardGame.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        tblBoardGame.Location = New Point(31, 65)
        tblBoardGame.Margin = New Padding(2)
        tblBoardGame.Name = "tblBoardGame"
        tblBoardGame.RowCount = 10
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        tblBoardGame.Size = New Size(1395, 1112)
        tblBoardGame.TabIndex = 164
        ' 
        ' btnFox
        ' 
        btnFox.BackColor = Color.Transparent
        btnFox.BackgroundImage = CType(resources.GetObject("btnFox.BackgroundImage"), Image)
        btnFox.BackgroundImageLayout = ImageLayout.Stretch
        btnFox.FlatAppearance.BorderSize = 0
        btnFox.FlatStyle = FlatStyle.Flat
        btnFox.ForeColor = Color.Transparent
        btnFox.Location = New Point(1456, 726)
        btnFox.Margin = New Padding(6, 4, 6, 4)
        btnFox.Name = "btnFox"
        btnFox.Size = New Size(82, 94)
        btnFox.TabIndex = 3
        btnFox.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(1540, 33)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(0, 32)
        lblUsername.TabIndex = 165
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Snow
        btnExit.Location = New Point(1456, 1072)
        btnExit.Margin = New Padding(6, 4, 6, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(269, 105)
        btnExit.TabIndex = 166
        btnExit.Text = "Exit Game"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnReplayGame
        ' 
        btnReplayGame.BackColor = Color.Snow
        btnReplayGame.Location = New Point(1456, 955)
        btnReplayGame.Margin = New Padding(4, 2, 4, 2)
        btnReplayGame.Name = "btnReplayGame"
        btnReplayGame.Size = New Size(269, 111)
        btnReplayGame.TabIndex = 167
        btnReplayGame.Text = "Replay Game"
        btnReplayGame.UseVisualStyleBackColor = False
        btnReplayGame.Visible = False
        ' 
        ' btnRestartGame
        ' 
        btnRestartGame.BackColor = Color.Snow
        btnRestartGame.Location = New Point(1456, 840)
        btnRestartGame.Margin = New Padding(4, 2, 4, 2)
        btnRestartGame.Name = "btnRestartGame"
        btnRestartGame.Size = New Size(269, 111)
        btnRestartGame.TabIndex = 168
        btnRestartGame.Text = "Restart Game"
        btnRestartGame.UseVisualStyleBackColor = False
        btnRestartGame.Visible = False
        ' 
        ' btnFrogIcon
        ' 
        btnFrogIcon.BackColor = Color.Transparent
        btnFrogIcon.BackgroundImage = CType(resources.GetObject("btnFrogIcon.BackgroundImage"), Image)
        btnFrogIcon.BackgroundImageLayout = ImageLayout.Stretch
        btnFrogIcon.FlatAppearance.BorderSize = 0
        btnFrogIcon.FlatStyle = FlatStyle.Flat
        btnFrogIcon.Location = New Point(1458, 12)
        btnFrogIcon.Margin = New Padding(6, 4, 6, 4)
        btnFrogIcon.Name = "btnFrogIcon"
        btnFrogIcon.Size = New Size(65, 75)
        btnFrogIcon.TabIndex = 170
        btnFrogIcon.UseVisualStyleBackColor = False
        btnFrogIcon.Visible = False
        ' 
        ' btnDogIcon
        ' 
        btnDogIcon.BackColor = SystemColors.Control
        btnDogIcon.BackgroundImage = CType(resources.GetObject("btnDogIcon.BackgroundImage"), Image)
        btnDogIcon.BackgroundImageLayout = ImageLayout.Stretch
        btnDogIcon.FlatAppearance.BorderSize = 0
        btnDogIcon.FlatStyle = FlatStyle.Flat
        btnDogIcon.Location = New Point(1458, 12)
        btnDogIcon.Margin = New Padding(6, 4, 6, 4)
        btnDogIcon.Name = "btnDogIcon"
        btnDogIcon.Size = New Size(65, 75)
        btnDogIcon.TabIndex = 171
        btnDogIcon.UseVisualStyleBackColor = False
        btnDogIcon.Visible = False
        ' 
        ' btnFoxIcon
        ' 
        btnFoxIcon.BackColor = SystemColors.Control
        btnFoxIcon.BackgroundImage = CType(resources.GetObject("btnFoxIcon.BackgroundImage"), Image)
        btnFoxIcon.BackgroundImageLayout = ImageLayout.Stretch
        btnFoxIcon.FlatAppearance.BorderSize = 0
        btnFoxIcon.FlatStyle = FlatStyle.Flat
        btnFoxIcon.ForeColor = Color.Transparent
        btnFoxIcon.Location = New Point(1458, 12)
        btnFoxIcon.Margin = New Padding(6, 4, 6, 4)
        btnFoxIcon.Name = "btnFoxIcon"
        btnFoxIcon.Size = New Size(65, 75)
        btnFoxIcon.TabIndex = 171
        btnFoxIcon.UseVisualStyleBackColor = False
        btnFoxIcon.Visible = False
        ' 
        ' btnBunnyIcon
        ' 
        btnBunnyIcon.BackColor = SystemColors.Control
        btnBunnyIcon.BackgroundImage = CType(resources.GetObject("btnBunnyIcon.BackgroundImage"), Image)
        btnBunnyIcon.BackgroundImageLayout = ImageLayout.Stretch
        btnBunnyIcon.FlatAppearance.BorderSize = 0
        btnBunnyIcon.FlatStyle = FlatStyle.Flat
        btnBunnyIcon.Location = New Point(1458, 12)
        btnBunnyIcon.Margin = New Padding(6, 4, 6, 4)
        btnBunnyIcon.Name = "btnBunnyIcon"
        btnBunnyIcon.Size = New Size(65, 75)
        btnBunnyIcon.TabIndex = 172
        btnBunnyIcon.UseVisualStyleBackColor = False
        btnBunnyIcon.Visible = False
        ' 
        ' btnCatIcon
        ' 
        btnCatIcon.BackColor = SystemColors.Control
        btnCatIcon.BackgroundImage = CType(resources.GetObject("btnCatIcon.BackgroundImage"), Image)
        btnCatIcon.BackgroundImageLayout = ImageLayout.Stretch
        btnCatIcon.FlatAppearance.BorderSize = 0
        btnCatIcon.FlatStyle = FlatStyle.Flat
        btnCatIcon.Location = New Point(1458, 12)
        btnCatIcon.Margin = New Padding(6, 4, 6, 4)
        btnCatIcon.Name = "btnCatIcon"
        btnCatIcon.Size = New Size(65, 75)
        btnCatIcon.TabIndex = 173
        btnCatIcon.UseVisualStyleBackColor = False
        btnCatIcon.Visible = False
        ' 
        ' btnP2frog
        ' 
        btnP2frog.BackColor = SystemColors.Control
        btnP2frog.BackgroundImage = CType(resources.GetObject("btnP2frog.BackgroundImage"), Image)
        btnP2frog.BackgroundImageLayout = ImageLayout.Stretch
        btnP2frog.FlatAppearance.BorderSize = 0
        btnP2frog.FlatStyle = FlatStyle.Flat
        btnP2frog.Location = New Point(1458, 108)
        btnP2frog.Margin = New Padding(6, 4, 6, 4)
        btnP2frog.Name = "btnP2frog"
        btnP2frog.Size = New Size(65, 75)
        btnP2frog.TabIndex = 174
        btnP2frog.UseVisualStyleBackColor = False
        btnP2frog.Visible = False
        ' 
        ' btnP2dog
        ' 
        btnP2dog.BackColor = Color.Transparent
        btnP2dog.BackgroundImage = CType(resources.GetObject("btnP2dog.BackgroundImage"), Image)
        btnP2dog.BackgroundImageLayout = ImageLayout.Stretch
        btnP2dog.FlatAppearance.BorderSize = 0
        btnP2dog.FlatStyle = FlatStyle.Flat
        btnP2dog.Location = New Point(1458, 108)
        btnP2dog.Margin = New Padding(6, 4, 6, 4)
        btnP2dog.Name = "btnP2dog"
        btnP2dog.Size = New Size(65, 75)
        btnP2dog.TabIndex = 175
        btnP2dog.UseVisualStyleBackColor = False
        btnP2dog.Visible = False
        ' 
        ' lblPlayer2Name
        ' 
        lblPlayer2Name.AutoSize = True
        lblPlayer2Name.Location = New Point(1540, 129)
        lblPlayer2Name.Margin = New Padding(2, 0, 2, 0)
        lblPlayer2Name.Name = "lblPlayer2Name"
        lblPlayer2Name.Size = New Size(0, 32)
        lblPlayer2Name.TabIndex = 176
        ' 
        ' lblPlayerRoll
        ' 
        lblPlayerRoll.AutoSize = True
        lblPlayerRoll.Location = New Point(1660, 44)
        lblPlayerRoll.Name = "lblPlayerRoll"
        lblPlayerRoll.Size = New Size(83, 32)
        lblPlayerRoll.TabIndex = 177
        lblPlayerRoll.Text = "Label1"
        ' 
        ' lblComputerRoll
        ' 
        lblComputerRoll.AutoSize = True
        lblComputerRoll.Location = New Point(1660, 129)
        lblComputerRoll.Name = "lblComputerRoll"
        lblComputerRoll.Size = New Size(24, 32)
        lblComputerRoll.TabIndex = 178
        lblComputerRoll.Text = "s"
        ' 
        ' frmCandyLandMain
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Bisque
        ClientSize = New Size(1761, 1209)
        Controls.Add(lblComputerRoll)
        Controls.Add(lblPlayerRoll)
        Controls.Add(lblPlayer2Name)
        Controls.Add(btnP2dog)
        Controls.Add(btnP2frog)
        Controls.Add(btnFrogIcon)
        Controls.Add(btnDogIcon)
        Controls.Add(btnBunnyIcon)
        Controls.Add(btnCatIcon)
        Controls.Add(btnDog)
        Controls.Add(btnFoxIcon)
        Controls.Add(btnRestartGame)
        Controls.Add(btnReplayGame)
        Controls.Add(btnExit)
        Controls.Add(btnRollNumber)
        Controls.Add(lblUsername)
        Controls.Add(btnFrog)
        Controls.Add(btnFox)
        Controls.Add(btnBunny)
        Controls.Add(btnCat)
        Controls.Add(btnRoll)
        Controls.Add(tblBoardGame)
        Margin = New Padding(6, 4, 6, 4)
        Name = "frmCandyLandMain"
        Text = "Candy Land"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCat As Button
    Friend WithEvents btnDog As Button
    Friend WithEvents btnFrog As Button
    Friend WithEvents btnBunny As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents tblBoardGame As TableLayoutPanel
    Friend WithEvents btnFox As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnRollNumber As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReplayGame As Button
    Friend WithEvents btnRestartGame As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFrogIcon As Button
    Friend WithEvents btnCatIcon As Button
    Friend WithEvents btnFoxIcon As Button
    Friend WithEvents btnBunnyIcon As Button
    Friend WithEvents btnDogIcon As Button
    Friend WithEvents btnP2frog As Button
    Friend WithEvents btnP2dog As Button
    Friend WithEvents lblPlayer2Name As Label
    Friend WithEvents lblPlayerRoll As Label
    Friend WithEvents lblComputerRoll As Label

End Class

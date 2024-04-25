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
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        Panel2 = New Panel()
        HowToPlayToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCat
        ' 
        btnCat.BackColor = Color.Transparent
        btnCat.BackgroundImage = CType(resources.GetObject("btnCat.BackgroundImage"), Image)
        btnCat.BackgroundImageLayout = ImageLayout.Stretch
        btnCat.FlatAppearance.BorderSize = 0
        btnCat.FlatStyle = FlatStyle.Flat
        btnCat.Location = New Point(127, 318)
        btnCat.Margin = New Padding(3, 2, 3, 2)
        btnCat.Name = "btnCat"
        btnCat.Size = New Size(44, 44)
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
        btnDog.Location = New Point(46, 270)
        btnDog.Margin = New Padding(3, 2, 3, 2)
        btnDog.Name = "btnDog"
        btnDog.Size = New Size(44, 44)
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
        btnFrog.Location = New Point(46, 270)
        btnFrog.Margin = New Padding(3, 2, 3, 2)
        btnFrog.Name = "btnFrog"
        btnFrog.Size = New Size(44, 44)
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
        btnBunny.Location = New Point(77, 318)
        btnBunny.Margin = New Padding(3, 2, 3, 2)
        btnBunny.Name = "btnBunny"
        btnBunny.Size = New Size(44, 44)
        btnBunny.TabIndex = 3
        btnBunny.UseVisualStyleBackColor = False
        ' 
        ' btnRoll
        ' 
        btnRoll.BackColor = Color.Snow
        btnRoll.Font = New Font("Verdana", 9F)
        btnRoll.Location = New Point(16, 101)
        btnRoll.Margin = New Padding(3, 2, 3, 2)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(145, 59)
        btnRoll.TabIndex = 162
        btnRoll.Text = "Roll!"
        btnRoll.UseVisualStyleBackColor = False
        ' 
        ' btnRollNumber
        ' 
        btnRollNumber.BackColor = Color.Snow
        btnRollNumber.Font = New Font("Verdana", 9F)
        btnRollNumber.Location = New Point(16, 163)
        btnRollNumber.Margin = New Padding(1)
        btnRollNumber.Name = "btnRollNumber"
        btnRollNumber.Size = New Size(145, 131)
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
        tblBoardGame.Location = New Point(29, 129)
        tblBoardGame.Margin = New Padding(1)
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
        tblBoardGame.Size = New Size(751, 521)
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
        btnFox.Location = New Point(17, 318)
        btnFox.Margin = New Padding(3, 2, 3, 2)
        btnFox.Name = "btnFox"
        btnFox.Size = New Size(44, 44)
        btnFox.TabIndex = 3
        btnFox.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(65, 22)
        lblUsername.Margin = New Padding(1, 0, 1, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(0, 14)
        lblUsername.TabIndex = 165
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Snow
        btnExit.Font = New Font("Verdana", 9F)
        btnExit.Location = New Point(17, 541)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 49)
        btnExit.TabIndex = 166
        btnExit.Text = "Exit Game"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnReplayGame
        ' 
        btnReplayGame.BackColor = Color.Snow
        btnReplayGame.Font = New Font("Verdana", 9F)
        btnReplayGame.Location = New Point(17, 487)
        btnReplayGame.Margin = New Padding(2, 1, 2, 1)
        btnReplayGame.Name = "btnReplayGame"
        btnReplayGame.Size = New Size(145, 52)
        btnReplayGame.TabIndex = 167
        btnReplayGame.Text = "Replay Game"
        btnReplayGame.UseVisualStyleBackColor = False
        btnReplayGame.Visible = False
        ' 
        ' btnRestartGame
        ' 
        btnRestartGame.BackColor = Color.Snow
        btnRestartGame.Font = New Font("Verdana", 9F)
        btnRestartGame.Location = New Point(17, 433)
        btnRestartGame.Margin = New Padding(2, 1, 2, 1)
        btnRestartGame.Name = "btnRestartGame"
        btnRestartGame.Size = New Size(145, 52)
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
        btnFrogIcon.Location = New Point(18, 11)
        btnFrogIcon.Margin = New Padding(3, 2, 3, 2)
        btnFrogIcon.Name = "btnFrogIcon"
        btnFrogIcon.Size = New Size(35, 35)
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
        btnDogIcon.Location = New Point(18, 11)
        btnDogIcon.Margin = New Padding(3, 2, 3, 2)
        btnDogIcon.Name = "btnDogIcon"
        btnDogIcon.Size = New Size(35, 35)
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
        btnFoxIcon.Location = New Point(18, 11)
        btnFoxIcon.Margin = New Padding(3, 2, 3, 2)
        btnFoxIcon.Name = "btnFoxIcon"
        btnFoxIcon.Size = New Size(35, 35)
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
        btnBunnyIcon.Location = New Point(18, 11)
        btnBunnyIcon.Margin = New Padding(3, 2, 3, 2)
        btnBunnyIcon.Name = "btnBunnyIcon"
        btnBunnyIcon.Size = New Size(35, 35)
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
        btnCatIcon.Location = New Point(18, 11)
        btnCatIcon.Margin = New Padding(3, 2, 3, 2)
        btnCatIcon.Name = "btnCatIcon"
        btnCatIcon.Size = New Size(35, 35)
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
        btnP2frog.Location = New Point(18, 56)
        btnP2frog.Margin = New Padding(3, 2, 3, 2)
        btnP2frog.Name = "btnP2frog"
        btnP2frog.Size = New Size(35, 35)
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
        btnP2dog.Location = New Point(18, 56)
        btnP2dog.Margin = New Padding(3, 2, 3, 2)
        btnP2dog.Name = "btnP2dog"
        btnP2dog.Size = New Size(35, 35)
        btnP2dog.TabIndex = 175
        btnP2dog.UseVisualStyleBackColor = False
        btnP2dog.Visible = False
        ' 
        ' lblPlayer2Name
        ' 
        lblPlayer2Name.AutoSize = True
        lblPlayer2Name.Font = New Font("Verdana", 9F)
        lblPlayer2Name.Location = New Point(62, 65)
        lblPlayer2Name.Margin = New Padding(1, 0, 1, 0)
        lblPlayer2Name.Name = "lblPlayer2Name"
        lblPlayer2Name.Size = New Size(0, 14)
        lblPlayer2Name.TabIndex = 176
        ' 
        ' lblPlayerRoll
        ' 
        lblPlayerRoll.AutoSize = True
        lblPlayerRoll.Font = New Font("Verdana", 9F)
        lblPlayerRoll.Location = New Point(127, 26)
        lblPlayerRoll.Margin = New Padding(2, 0, 2, 0)
        lblPlayerRoll.Name = "lblPlayerRoll"
        lblPlayerRoll.Size = New Size(49, 14)
        lblPlayerRoll.TabIndex = 177
        lblPlayerRoll.Text = "Label1"
        ' 
        ' lblComputerRoll
        ' 
        lblComputerRoll.AutoSize = True
        lblComputerRoll.Font = New Font("Verdana", 9F)
        lblComputerRoll.Location = New Point(127, 65)
        lblComputerRoll.Margin = New Padding(2, 0, 2, 0)
        lblComputerRoll.Name = "lblComputerRoll"
        lblComputerRoll.Size = New Size(14, 14)
        lblComputerRoll.TabIndex = 178
        lblComputerRoll.Text = "s"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(201, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(437, 79)
        PictureBox1.TabIndex = 179
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {HowToPlayToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(991, 24)
        MenuStrip1.TabIndex = 180
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btnFrogIcon)
        Panel2.Controls.Add(btnRoll)
        Panel2.Controls.Add(lblComputerRoll)
        Panel2.Controls.Add(btnCat)
        Panel2.Controls.Add(lblPlayerRoll)
        Panel2.Controls.Add(btnBunny)
        Panel2.Controls.Add(lblPlayer2Name)
        Panel2.Controls.Add(btnFox)
        Panel2.Controls.Add(btnP2dog)
        Panel2.Controls.Add(btnFrog)
        Panel2.Controls.Add(btnP2frog)
        Panel2.Controls.Add(lblUsername)
        Panel2.Controls.Add(btnRollNumber)
        Panel2.Controls.Add(btnDogIcon)
        Panel2.Controls.Add(btnExit)
        Panel2.Controls.Add(btnBunnyIcon)
        Panel2.Controls.Add(btnReplayGame)
        Panel2.Controls.Add(btnCatIcon)
        Panel2.Controls.Add(btnRestartGame)
        Panel2.Controls.Add(btnDog)
        Panel2.Controls.Add(btnFoxIcon)
        Panel2.Location = New Point(794, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(183, 606)
        Panel2.TabIndex = 181
        ' 
        ' HowToPlayToolStripMenuItem
        ' 
        HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        HowToPlayToolStripMenuItem.Size = New Size(83, 20)
        HowToPlayToolStripMenuItem.Text = "How to Play"
        ' 
        ' frmCandyLandMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.AliceBlue
        ClientSize = New Size(991, 676)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Controls.Add(tblBoardGame)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmCandyLandMain"
        Text = "Candy Land"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HowToPlayToolStripMenuItem As ToolStripMenuItem

End Class

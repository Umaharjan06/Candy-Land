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
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCat
        ' 
        btnCat.BackColor = SystemColors.Control
        btnCat.BackgroundImage = CType(resources.GetObject("btnCat.BackgroundImage"), Image)
        btnCat.BackgroundImageLayout = ImageLayout.Stretch
        btnCat.FlatAppearance.BorderSize = 0
        btnCat.FlatStyle = FlatStyle.Flat
        btnCat.Location = New Point(1129, 363)
        btnCat.Margin = New Padding(3, 2, 3, 2)
        btnCat.Name = "btnCat"
        btnCat.Size = New Size(44, 44)
        btnCat.TabIndex = 0
        btnCat.UseVisualStyleBackColor = False
        ' 
        ' btnDog
        ' 
        btnDog.BackColor = SystemColors.Control
        btnDog.BackgroundImage = CType(resources.GetObject("btnDog.BackgroundImage"), Image)
        btnDog.BackgroundImageLayout = ImageLayout.Stretch
        btnDog.FlatAppearance.BorderSize = 0
        btnDog.FlatStyle = FlatStyle.Flat
        btnDog.Location = New Point(76, 558)
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
        btnFrog.Location = New Point(1019, 363)
        btnFrog.Margin = New Padding(3, 2, 3, 2)
        btnFrog.Name = "btnFrog"
        btnFrog.Size = New Size(44, 44)
        btnFrog.TabIndex = 2
        btnFrog.UseVisualStyleBackColor = False
        ' 
        ' btnBunny
        ' 
        btnBunny.BackColor = SystemColors.Control
        btnBunny.BackgroundImage = CType(resources.GetObject("btnBunny.BackgroundImage"), Image)
        btnBunny.BackgroundImageLayout = ImageLayout.Stretch
        btnBunny.FlatAppearance.BorderSize = 0
        btnBunny.FlatStyle = FlatStyle.Flat
        btnBunny.Location = New Point(1079, 304)
        btnBunny.Margin = New Padding(3, 2, 3, 2)
        btnBunny.Name = "btnBunny"
        btnBunny.Size = New Size(44, 44)
        btnBunny.TabIndex = 3
        btnBunny.UseVisualStyleBackColor = False
        ' 
        ' btnRoll
        ' 
        btnRoll.Location = New Point(1019, 96)
        btnRoll.Margin = New Padding(3, 2, 3, 2)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(145, 59)
        btnRoll.TabIndex = 162
        btnRoll.Text = "Roll!"
        btnRoll.UseVisualStyleBackColor = True
        ' 
        ' btnRollNumber
        ' 
        btnRollNumber.Location = New Point(1019, 158)
        btnRollNumber.Margin = New Padding(1)
        btnRollNumber.Name = "btnRollNumber"
        btnRollNumber.Size = New Size(145, 131)
        btnRollNumber.TabIndex = 165
        btnRollNumber.Text = "n/a"
        btnRollNumber.UseVisualStyleBackColor = True
        ' 
        ' tblBoardGame
        ' 
        tblBoardGame.BackColor = Color.Snow
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
        tblBoardGame.Location = New Point(25, 28)
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
        tblBoardGame.Size = New Size(972, 546)
        tblBoardGame.TabIndex = 164
        ' 
        ' btnFox
        ' 
        btnFox.BackColor = SystemColors.Control
        btnFox.BackgroundImage = CType(resources.GetObject("btnFox.BackgroundImage"), Image)
        btnFox.BackgroundImageLayout = ImageLayout.Stretch
        btnFox.FlatAppearance.BorderSize = 0
        btnFox.FlatStyle = FlatStyle.Flat
        btnFox.ForeColor = Color.Transparent
        btnFox.Location = New Point(1019, 304)
        btnFox.Margin = New Padding(3, 2, 3, 2)
        btnFox.Name = "btnFox"
        btnFox.Size = New Size(44, 44)
        btnFox.TabIndex = 3
        btnFox.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(1048, 28)
        lblUsername.Margin = New Padding(1, 0, 1, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(0, 15)
        lblUsername.TabIndex = 165
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(1019, 525)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 49)
        btnExit.TabIndex = 166
        btnExit.Text = "Exit Game"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnReplayGame
        ' 
        btnReplayGame.Location = New Point(1019, 470)
        btnReplayGame.Margin = New Padding(2, 1, 2, 1)
        btnReplayGame.Name = "btnReplayGame"
        btnReplayGame.Size = New Size(145, 52)
        btnReplayGame.TabIndex = 167
        btnReplayGame.Text = "Replay Game"
        btnReplayGame.UseVisualStyleBackColor = True
        btnReplayGame.Visible = False
        ' 
        ' btnRestartGame
        ' 
        btnRestartGame.Location = New Point(1019, 415)
        btnRestartGame.Margin = New Padding(2, 1, 2, 1)
        btnRestartGame.Name = "btnRestartGame"
        btnRestartGame.Size = New Size(145, 52)
        btnRestartGame.TabIndex = 168
        btnRestartGame.Text = "Restart Game"
        btnRestartGame.UseVisualStyleBackColor = True
        btnRestartGame.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1132, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 169
        Label1.Text = "Label1"
        ' 
        ' frmCandyLandMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1187, 613)
        Controls.Add(btnDog)
        Controls.Add(Label1)
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
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents Label1 As Label

End Class

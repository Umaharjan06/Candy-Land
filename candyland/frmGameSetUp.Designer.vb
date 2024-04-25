<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameSetUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameSetUp))
        cboGameType = New ComboBox()
        btnChooseMode = New Button()
        cboColorPicker = New ComboBox()
        btnChooseColor = New Button()
        txtNames = New TextBox()
        btnName1 = New Button()
        lblGameMode = New Label()
        lblEnterName = New Label()
        lblPlayerColor = New Label()
        btnHowToPlay = New Button()
        cbMusic = New CheckBox()
        lblVersion = New Label()
        SuspendLayout()
        ' 
        ' cboGameType
        ' 
        cboGameType.DropDownStyle = ComboBoxStyle.DropDownList
        cboGameType.FormattingEnabled = True
        cboGameType.Items.AddRange(New Object() {"Single Player", "Multi-Player (2 players)", "Multi-Player (3 players)", "Multi-Player (4 players)"})
        cboGameType.Location = New Point(522, 286)
        cboGameType.Margin = New Padding(2)
        cboGameType.Name = "cboGameType"
        cboGameType.Size = New Size(232, 40)
        cboGameType.TabIndex = 0
        ' 
        ' btnChooseMode
        ' 
        btnChooseMode.BackColor = Color.LavenderBlush
        btnChooseMode.Font = New Font("Verdana", 9.75F)
        btnChooseMode.ForeColor = SystemColors.ControlDarkDark
        btnChooseMode.Location = New Point(440, 367)
        btnChooseMode.Margin = New Padding(2)
        btnChooseMode.Name = "btnChooseMode"
        btnChooseMode.Size = New Size(217, 100)
        btnChooseMode.TabIndex = 1
        btnChooseMode.Text = "Enter"
        btnChooseMode.UseVisualStyleBackColor = False
        ' 
        ' cboColorPicker
        ' 
        cboColorPicker.DropDownStyle = ComboBoxStyle.DropDownList
        cboColorPicker.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboColorPicker.ForeColor = SystemColors.ControlDarkDark
        cboColorPicker.FormattingEnabled = True
        cboColorPicker.Items.AddRange(New Object() {"Fox", "Bunny", "Frog", "Dog", "Cat"})
        cboColorPicker.Location = New Point(522, 286)
        cboColorPicker.Margin = New Padding(2)
        cboColorPicker.Name = "cboColorPicker"
        cboColorPicker.Size = New Size(232, 37)
        cboColorPicker.TabIndex = 2
        ' 
        ' btnChooseColor
        ' 
        btnChooseColor.BackColor = Color.LavenderBlush
        btnChooseColor.Font = New Font("Verdana", 9.75F)
        btnChooseColor.ForeColor = SystemColors.ControlDarkDark
        btnChooseColor.Location = New Point(440, 367)
        btnChooseColor.Margin = New Padding(2)
        btnChooseColor.Name = "btnChooseColor"
        btnChooseColor.Size = New Size(217, 100)
        btnChooseColor.TabIndex = 3
        btnChooseColor.Text = "Start!"
        btnChooseColor.UseVisualStyleBackColor = False
        ' 
        ' txtNames
        ' 
        txtNames.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNames.Location = New Point(522, 286)
        txtNames.Margin = New Padding(2)
        txtNames.Name = "txtNames"
        txtNames.Size = New Size(232, 37)
        txtNames.TabIndex = 4
        ' 
        ' btnName1
        ' 
        btnName1.BackColor = Color.LavenderBlush
        btnName1.FlatAppearance.BorderSize = 0
        btnName1.Font = New Font("Verdana", 9.75F)
        btnName1.ForeColor = SystemColors.ControlDarkDark
        btnName1.Location = New Point(440, 369)
        btnName1.Margin = New Padding(2)
        btnName1.Name = "btnName1"
        btnName1.Size = New Size(217, 98)
        btnName1.TabIndex = 5
        btnName1.Text = "Enter"
        btnName1.UseVisualStyleBackColor = False
        ' 
        ' lblGameMode
        ' 
        lblGameMode.AutoSize = True
        lblGameMode.BackColor = Color.Transparent
        lblGameMode.Font = New Font("Verdana", 9.75F)
        lblGameMode.ForeColor = SystemColors.ControlDarkDark
        lblGameMode.Location = New Point(245, 290)
        lblGameMode.Margin = New Padding(6, 0, 6, 0)
        lblGameMode.Name = "lblGameMode"
        lblGameMode.Size = New Size(267, 32)
        lblGameMode.TabIndex = 6
        lblGameMode.Text = "Select game mode:"
        ' 
        ' lblEnterName
        ' 
        lblEnterName.AutoSize = True
        lblEnterName.BackColor = Color.Transparent
        lblEnterName.Font = New Font("Verdana", 9.75F)
        lblEnterName.ForeColor = SystemColors.ControlDarkDark
        lblEnterName.Location = New Point(331, 290)
        lblEnterName.Margin = New Padding(6, 0, 6, 0)
        lblEnterName.Name = "lblEnterName"
        lblEnterName.Size = New Size(178, 32)
        lblEnterName.TabIndex = 7
        lblEnterName.Text = "Enter Name:"
        lblEnterName.Visible = False
        ' 
        ' lblPlayerColor
        ' 
        lblPlayerColor.AutoSize = True
        lblPlayerColor.BackColor = Color.Transparent
        lblPlayerColor.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlayerColor.ForeColor = SystemColors.ControlDarkDark
        lblPlayerColor.Location = New Point(264, 290)
        lblPlayerColor.Margin = New Padding(6, 0, 6, 0)
        lblPlayerColor.Name = "lblPlayerColor"
        lblPlayerColor.Size = New Size(241, 32)
        lblPlayerColor.TabIndex = 8
        lblPlayerColor.Text = "Select Character:"
        lblPlayerColor.Visible = False
        ' 
        ' btnHowToPlay
        ' 
        btnHowToPlay.BackColor = Color.LavenderBlush
        btnHowToPlay.FlatAppearance.BorderSize = 0
        btnHowToPlay.Font = New Font("Verdana", 9.75F)
        btnHowToPlay.ForeColor = SystemColors.ControlDarkDark
        btnHowToPlay.Location = New Point(830, 571)
        btnHowToPlay.Margin = New Padding(2)
        btnHowToPlay.Name = "btnHowToPlay"
        btnHowToPlay.Size = New Size(214, 45)
        btnHowToPlay.TabIndex = 9
        btnHowToPlay.Text = "How To Play"
        btnHowToPlay.UseVisualStyleBackColor = False
        ' 
        ' cbMusic
        ' 
        cbMusic.AutoSize = True
        cbMusic.BackColor = Color.Transparent
        cbMusic.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMusic.Location = New Point(12, 569)
        cbMusic.Name = "cbMusic"
        cbMusic.Size = New Size(112, 33)
        cbMusic.TabIndex = 10
        cbMusic.Text = "Music"
        cbMusic.UseVisualStyleBackColor = False
        ' 
        ' lblVersion
        ' 
        lblVersion.AutoSize = True
        lblVersion.BackColor = Color.Transparent
        lblVersion.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVersion.Location = New Point(12, 605)
        lblVersion.Name = "lblVersion"
        lblVersion.Size = New Size(90, 29)
        lblVersion.TabIndex = 11
        lblVersion.Text = "v1.2.1"
        ' 
        ' frmGameSetUp
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1085, 642)
        Controls.Add(lblVersion)
        Controls.Add(cbMusic)
        Controls.Add(btnHowToPlay)
        Controls.Add(lblPlayerColor)
        Controls.Add(lblEnterName)
        Controls.Add(lblGameMode)
        Controls.Add(btnName1)
        Controls.Add(txtNames)
        Controls.Add(btnChooseColor)
        Controls.Add(cboColorPicker)
        Controls.Add(btnChooseMode)
        Controls.Add(cboGameType)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Margin = New Padding(2)
        Name = "frmGameSetUp"
        Text = "Game Set Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboGameType As ComboBox
    Friend WithEvents btnChooseMode As Button
    Friend WithEvents cboColorPicker As ComboBox
    Friend WithEvents btnChooseColor As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents btnName1 As Button
    Friend WithEvents lblGameMode As Label
    Friend WithEvents lblEnterName As Label
    Friend WithEvents lblPlayerColor As Label
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents cbMusic As CheckBox
    Friend WithEvents lblVersion As Label
End Class

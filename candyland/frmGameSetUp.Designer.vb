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
        btnSPChooseColor = New Button()
        txtNames = New TextBox()
        btnSinglePlayerName = New Button()
        lblSetUp = New Label()
        btnPlayer1Name = New Button()
        btnP1ChooseColor = New Button()
        SuspendLayout()
        ' 
        ' cboGameType
        ' 
        cboGameType.DropDownStyle = ComboBoxStyle.DropDownList
        cboGameType.FormattingEnabled = True
        cboGameType.Items.AddRange(New Object() {"Single Player", "Multi-Player (2 players)", "Multi-Player (3 players)", "Multi-Player (4 players)"})
        cboGameType.Location = New Point(281, 134)
        cboGameType.Margin = New Padding(1)
        cboGameType.Name = "cboGameType"
        cboGameType.Size = New Size(127, 23)
        cboGameType.TabIndex = 0
        ' 
        ' btnChooseMode
        ' 
        btnChooseMode.BackColor = Color.LavenderBlush
        btnChooseMode.Font = New Font("Verdana", 9.75F)
        btnChooseMode.ForeColor = SystemColors.ControlDarkDark
        btnChooseMode.Location = New Point(237, 172)
        btnChooseMode.Margin = New Padding(1)
        btnChooseMode.Name = "btnChooseMode"
        btnChooseMode.Size = New Size(117, 47)
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
        cboColorPicker.Location = New Point(281, 134)
        cboColorPicker.Margin = New Padding(1)
        cboColorPicker.Name = "cboColorPicker"
        cboColorPicker.Size = New Size(127, 22)
        cboColorPicker.TabIndex = 2
        ' 
        ' btnSPChooseColor
        ' 
        btnSPChooseColor.BackColor = Color.LavenderBlush
        btnSPChooseColor.Font = New Font("Verdana", 9.75F)
        btnSPChooseColor.ForeColor = SystemColors.ControlDarkDark
        btnSPChooseColor.Location = New Point(237, 173)
        btnSPChooseColor.Margin = New Padding(1)
        btnSPChooseColor.Name = "btnSPChooseColor"
        btnSPChooseColor.Size = New Size(117, 47)
        btnSPChooseColor.TabIndex = 3
        btnSPChooseColor.Text = "Start!"
        btnSPChooseColor.UseVisualStyleBackColor = False
        btnSPChooseColor.Visible = False
        ' 
        ' txtNames
        ' 
        txtNames.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNames.Location = New Point(281, 134)
        txtNames.Margin = New Padding(1)
        txtNames.Name = "txtNames"
        txtNames.Size = New Size(127, 22)
        txtNames.TabIndex = 4
        ' 
        ' btnSinglePlayerName
        ' 
        btnSinglePlayerName.BackColor = Color.LavenderBlush
        btnSinglePlayerName.FlatAppearance.BorderSize = 0
        btnSinglePlayerName.Font = New Font("Verdana", 9.75F)
        btnSinglePlayerName.ForeColor = SystemColors.ControlDarkDark
        btnSinglePlayerName.Location = New Point(237, 174)
        btnSinglePlayerName.Margin = New Padding(1)
        btnSinglePlayerName.Name = "btnSinglePlayerName"
        btnSinglePlayerName.Size = New Size(117, 46)
        btnSinglePlayerName.TabIndex = 5
        btnSinglePlayerName.Text = "Enter"
        btnSinglePlayerName.UseVisualStyleBackColor = False
        btnSinglePlayerName.Visible = False
        ' 
        ' lblSetUp
        ' 
        lblSetUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblSetUp.BackColor = Color.Transparent
        lblSetUp.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSetUp.ForeColor = SystemColors.ControlDarkDark
        lblSetUp.Location = New Point(137, 136)
        lblSetUp.Name = "lblSetUp"
        lblSetUp.Size = New Size(140, 18)
        lblSetUp.TabIndex = 9
        lblSetUp.Text = "Select Game Mode:"
        lblSetUp.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnPlayer1Name
        ' 
        btnPlayer1Name.BackColor = Color.LavenderBlush
        btnPlayer1Name.FlatAppearance.BorderSize = 0
        btnPlayer1Name.Font = New Font("Verdana", 9.75F)
        btnPlayer1Name.ForeColor = SystemColors.ControlDarkDark
        btnPlayer1Name.Location = New Point(237, 174)
        btnPlayer1Name.Margin = New Padding(1)
        btnPlayer1Name.Name = "btnPlayer1Name"
        btnPlayer1Name.Size = New Size(117, 46)
        btnPlayer1Name.TabIndex = 10
        btnPlayer1Name.Text = "Enter"
        btnPlayer1Name.UseVisualStyleBackColor = False
        btnPlayer1Name.Visible = False
        ' 
        ' btnP1ChooseColor
        ' 
        btnP1ChooseColor.BackColor = Color.LavenderBlush
        btnP1ChooseColor.FlatAppearance.BorderSize = 0
        btnP1ChooseColor.Font = New Font("Verdana", 9.75F)
        btnP1ChooseColor.ForeColor = SystemColors.ControlDarkDark
        btnP1ChooseColor.Location = New Point(237, 174)
        btnP1ChooseColor.Margin = New Padding(1)
        btnP1ChooseColor.Name = "btnP1ChooseColor"
        btnP1ChooseColor.Size = New Size(117, 46)
        btnP1ChooseColor.TabIndex = 11
        btnP1ChooseColor.Text = "Enter"
        btnP1ChooseColor.UseVisualStyleBackColor = False
        btnP1ChooseColor.Visible = False
        ' 
        ' frmGameSetUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(584, 301)
        Controls.Add(btnP1ChooseColor)
        Controls.Add(btnPlayer1Name)
        Controls.Add(lblSetUp)
        Controls.Add(btnSinglePlayerName)
        Controls.Add(txtNames)
        Controls.Add(btnSPChooseColor)
        Controls.Add(cboColorPicker)
        Controls.Add(btnChooseMode)
        Controls.Add(cboGameType)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Margin = New Padding(1)
        Name = "frmGameSetUp"
        Text = "Game Set Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboGameType As ComboBox
    Friend WithEvents btnChooseMode As Button
    Friend WithEvents cboColorPicker As ComboBox
    Friend WithEvents btnSPChooseColor As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents btnSinglePlayerName As Button
    Friend WithEvents lblSetUp As Label
    Friend WithEvents btnPlayer1Name As Button
    Friend WithEvents btnP1ChooseColor As Button
End Class

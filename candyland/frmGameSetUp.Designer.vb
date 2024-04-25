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
        ' btnChooseColor
        ' 
        btnChooseColor.BackColor = Color.LavenderBlush
        btnChooseColor.Font = New Font("Verdana", 9.75F)
        btnChooseColor.ForeColor = SystemColors.ControlDarkDark
        btnChooseColor.Location = New Point(237, 172)
        btnChooseColor.Margin = New Padding(1)
        btnChooseColor.Name = "btnChooseColor"
        btnChooseColor.Size = New Size(117, 47)
        btnChooseColor.TabIndex = 3
        btnChooseColor.Text = "Start!"
        btnChooseColor.UseVisualStyleBackColor = False
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
        ' btnName1
        ' 
        btnName1.BackColor = Color.LavenderBlush
        btnName1.FlatAppearance.BorderSize = 0
        btnName1.Font = New Font("Verdana", 9.75F)
        btnName1.ForeColor = SystemColors.ControlDarkDark
        btnName1.Location = New Point(237, 173)
        btnName1.Margin = New Padding(1)
        btnName1.Name = "btnName1"
        btnName1.Size = New Size(117, 46)
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
        lblGameMode.Location = New Point(132, 136)
        lblGameMode.Name = "lblGameMode"
        lblGameMode.Size = New Size(135, 16)
        lblGameMode.TabIndex = 6
        lblGameMode.Text = "Select game mode:"
        ' 
        ' lblEnterName
        ' 
        lblEnterName.AutoSize = True
        lblEnterName.BackColor = Color.Transparent
        lblEnterName.Font = New Font("Verdana", 9.75F)
        lblEnterName.ForeColor = SystemColors.ControlDarkDark
        lblEnterName.Location = New Point(217, 136)
        lblEnterName.Name = "lblEnterName"
        lblEnterName.Size = New Size(49, 16)
        lblEnterName.TabIndex = 7
        lblEnterName.Text = "Name:"
        lblEnterName.Visible = False
        ' 
        ' lblPlayerColor
        ' 
        lblPlayerColor.AutoSize = True
        lblPlayerColor.BackColor = Color.Transparent
        lblPlayerColor.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlayerColor.ForeColor = SystemColors.ControlDarkDark
        lblPlayerColor.Location = New Point(141, 136)
        lblPlayerColor.Name = "lblPlayerColor"
        lblPlayerColor.Size = New Size(125, 16)
        lblPlayerColor.TabIndex = 8
        lblPlayerColor.Text = "Select Character:"
        lblPlayerColor.Visible = False
        ' 
        ' frmGameSetUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(584, 301)
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
        Margin = New Padding(1)
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
End Class

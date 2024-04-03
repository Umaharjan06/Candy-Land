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
        cboGameType = New ComboBox()
        btnStart = New Button()
        cboColorPicker = New ComboBox()
        btnChooseColor = New Button()
        txtNames = New TextBox()
        btnName1 = New Button()
        SuspendLayout()
        ' 
        ' cboGameType
        ' 
        cboGameType.DropDownStyle = ComboBoxStyle.DropDownList
        cboGameType.FormattingEnabled = True
        cboGameType.Items.AddRange(New Object() {"Single Player", "Multi-Player (2 players)", "Multi-Player (3 players)", "Multi-Player (4 players)"})
        cboGameType.Location = New Point(496, 220)
        cboGameType.Name = "cboGameType"
        cboGameType.Size = New Size(302, 49)
        cboGameType.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(868, 220)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(284, 129)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' cboColorPicker
        ' 
        cboColorPicker.DropDownStyle = ComboBoxStyle.DropDownList
        cboColorPicker.FormattingEnabled = True
        cboColorPicker.Items.AddRange(New Object() {"Red", "Yellow", "Green", "Blue", "Pink"})
        cboColorPicker.Location = New Point(496, 220)
        cboColorPicker.Name = "cboColorPicker"
        cboColorPicker.Size = New Size(302, 49)
        cboColorPicker.TabIndex = 2
        ' 
        ' btnChooseColor
        ' 
        btnChooseColor.Location = New Point(868, 220)
        btnChooseColor.Name = "btnChooseColor"
        btnChooseColor.Size = New Size(284, 129)
        btnChooseColor.TabIndex = 3
        btnChooseColor.Text = "Choose Color"
        btnChooseColor.UseVisualStyleBackColor = True
        ' 
        ' txtNames
        ' 
        txtNames.Location = New Point(496, 222)
        txtNames.Name = "txtNames"
        txtNames.Size = New Size(302, 47)
        txtNames.TabIndex = 4
        ' 
        ' btnName1
        ' 
        btnName1.Location = New Point(868, 222)
        btnName1.Name = "btnName1"
        btnName1.Size = New Size(284, 127)
        btnName1.TabIndex = 5
        btnName1.Text = "Name"
        btnName1.UseVisualStyleBackColor = True
        ' 
        ' frmGameSetUp
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 823)
        Controls.Add(btnName1)
        Controls.Add(txtNames)
        Controls.Add(btnChooseColor)
        Controls.Add(cboColorPicker)
        Controls.Add(btnStart)
        Controls.Add(cboGameType)
        Name = "frmGameSetUp"
        Text = "frmGameSetUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboGameType As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents cboColorPicker As ComboBox
    Friend WithEvents btnChooseColor As Button
    Friend WithEvents txtNames As TextBox
    Friend WithEvents btnName1 As Button
End Class

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
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btnRoll = New Button()
        btnRollNumber = New Button()
        tblBoardGame = New TableLayoutPanel()
        btn5 = New Button()
        lblUsername = New Label()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btn1.Location = New Point(2127, 991)
        btn1.Margin = New Padding(5)
        btn1.Name = "btn1"
        btn1.Size = New Size(81, 80)
        btn1.TabIndex = 0
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btn2.Location = New Point(2127, 884)
        btn2.Margin = New Padding(5)
        btn2.Name = "btn2"
        btn2.Size = New Size(81, 80)
        btn2.TabIndex = 1
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btn3.Location = New Point(2127, 785)
        btn3.Margin = New Padding(5)
        btn3.Name = "btn3"
        btn3.Size = New Size(81, 80)
        btn3.TabIndex = 2
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btn4.Location = New Point(2127, 679)
        btn4.Margin = New Padding(5)
        btn4.Name = "btn4"
        btn4.Size = New Size(81, 80)
        btn4.TabIndex = 3
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btnRoll
        ' 
        btnRoll.Location = New Point(1929, 208)
        btnRoll.Margin = New Padding(5)
        btnRoll.Name = "btnRoll"
        btnRoll.Size = New Size(270, 117)
        btnRoll.TabIndex = 162
        btnRoll.Text = "Roll!"
        btnRoll.UseVisualStyleBackColor = True
        ' 
        ' btnRollNumber
        ' 
        btnRollNumber.Location = New Point(1946, 332)
        btnRollNumber.Margin = New Padding(2)
        btnRollNumber.Name = "btnRollNumber"
        btnRollNumber.Size = New Size(244, 240)
        btnRollNumber.TabIndex = 165
        btnRollNumber.Text = "n/a"
        btnRollNumber.UseVisualStyleBackColor = True
        ' 
        ' tblBoardGame
        ' 
        tblBoardGame.BackColor = Color.White
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
        tblBoardGame.Location = New Point(0, 0)
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
        tblBoardGame.Size = New Size(1835, 1483)
        tblBoardGame.TabIndex = 164
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.Firebrick
        btn5.Location = New Point(2127, 590)
        btn5.Margin = New Padding(5)
        btn5.Name = "btn5"
        btn5.Size = New Size(81, 80)
        btn5.TabIndex = 3
        btn5.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(1946, 59)
        lblUsername.Margin = New Padding(2, 0, 2, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(0, 32)
        lblUsername.TabIndex = 165
        ' 
        ' frmCandyLandMain
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(2270, 1467)
        Controls.Add(btnRollNumber)
        Controls.Add(lblUsername)
        Controls.Add(btn2)
        Controls.Add(btn3)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn1)
        Controls.Add(btnRoll)
        Controls.Add(tblBoardGame)
        Margin = New Padding(5)
        Name = "frmCandyLandMain"
        Text = "Candy Land"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents tblBoardGame As TableLayoutPanel
    Friend WithEvents btn5 As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnRollNumber As Button

End Class

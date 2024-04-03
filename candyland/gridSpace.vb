Public Class gridSpace
    Public boardGame As TableLayoutPanel
    Public iRow As Integer
    Public iColumn As Integer
    Public Sub New(Board As TableLayoutPanel, row As Integer, column As Integer)
        Me.boardGame = Board
        Me.iRow = row
        Me.iColumn = column
    End Sub
End Class

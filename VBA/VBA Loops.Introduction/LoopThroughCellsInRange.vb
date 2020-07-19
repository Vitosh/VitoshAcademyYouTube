'Loop through Cells in Range

Sub LoopThroughCells()
    
    Dim myRange As Range
    
    Set myRange = Selection
    
    Dim myCell As Range
    
    For Each myCell In myRange
        myCell.Value = myCell.Address
    Next
    
End Sub


Sub LoopThroughCells()
    
    Dim myRange As Range
    
    Set myRange = Worksheets("Tabelle1").Range("A1:F17")
    
    Dim myCell As Range
    
    For Each myCell In myRange
        myCell.Value = myCell.Row + myCell.Column
    Next
    
End Sub
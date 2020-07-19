'Loop with offset

'In the immediate window:
Selection = 100
Selection.offset(5, 5)=21

Sub LoopThroughCells()
    
    Dim myRange As Range
    
    Set myRange = Worksheets("Tabelle1").Range("A1:A5")
    
    Dim myCell As Range
    
    For Each myCell In myRange
        myCell.Value = 2
        myCell.Offset(myCell.Row, myCell.Column) = 1
    Next
    
End Sub
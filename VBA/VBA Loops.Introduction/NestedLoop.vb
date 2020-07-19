'Nested Loop

Sub NestedLoops()
        
    Dim myRow As Long
    Dim myCol As Long
    
    For myRow = 1 To 20
        For myCol = 1 To 10
            With Worksheets("Tabelle1")
                .Cells(myRow, myCol) = myRow * myCol
            End With
        Next myCol
    Next myRow
    
End Sub

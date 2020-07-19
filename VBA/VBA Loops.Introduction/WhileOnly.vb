'WhileOnly

Sub WhileOnly()
    
    Dim i As Long
    i = 1

    While True
        Worksheets("Tabelle1").Cells(i, 1) = i + 5
        i = i + 5
    Wend

End Sub

Sub WhileOnly()
    
    Dim i As Long
    i = 1

    While i <= Rows.Count
        Worksheets("Tabelle1").Cells(i, 1) = i + 5
        i = i + 5
    Wend

End Sub



'DoUntil

Sub DoUntil()
    
    Dim i As Long
    Do
        Worksheets("Tabelle1").Cells(1, 1) = i + 5
    Loop Until True

End Sub

Sub DoUntil()
    
    Dim i As Long
    i = 1

    Do
        Worksheets("Tabelle1").Cells(i, 1) = i + 5
        i = i + 5
    Loop Until i > 100

End Sub

Sub DoWhile()
    
    Dim i As Long
    i = 1

    Do While True
        Worksheets("Tabelle1").Cells(i, 1) = i + 5
        i = i + 5
        Exit Do
    Loop

End Sub
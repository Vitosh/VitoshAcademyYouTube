'Reversed For Loop

Sub ForLoop()

    Dim i As Long
    
    For i = 100 To 1 Step 3
        Worksheets("Tabelle1").Cells(i, 1) = i * i
    Next i

End Sub

Sub ForLoop()

    Dim i As Long
    
    For i = 100 To 1 Step -3
        Worksheets("Tabelle1").Cells(i, 1) = i * i
    Next i

End Sub

Sub ForLoop()

    Dim i As Long
    
    For i = 10 To 1 Step -1
        Worksheets("Tabelle1").Cells(i, 1) = i
    Next i

End Sub
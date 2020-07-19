'Step 2 (or more)

Sub ForLoopStep()

    Dim i As Long
    For i = 1 To 100 Step 3
        Worksheets("Tabelle1").Cells(i, 1) = i * i
    Next i

End Sub

Sub ForLoopStep()

    Dim i As Long
    Dim result As String
    
    For i = 5 To 100 Step 5
        
        If i Mod 3 = 0 Then
            result = "FizzBuzz"
        Else
            result = "Buzz"
        End If
        
        tblMain.Cells(i, "A").Value = result
    Next

End Sub
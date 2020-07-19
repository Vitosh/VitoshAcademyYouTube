'For Loop

Sub ForLoop()

    Dim i As Long
    For i = 1 To 100 Step 1
        Worksheets("Tabelle1").Cells(i, 1) = i * i
        
    Next i

End Sub


Sub ForLoop()

    Dim i As Long
    Dim result As String
    
    For i = 1 To 100 Step 1
    
        If i Mod 3 = 0 And i Mod 5 = 0 Then
            result = "FizzBuzz"
        ElseIf i Mod 3 = 0 Then
            result = "Fizz"
        ElseIf i Mod 5 = 0 Then
            result = "Buzz"
        Else
            result = i
        End If
        Worksheets("Tabelle1").Cells(i, 1) = result
    Next i

End Sub
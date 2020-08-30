Attribute VB_Name = "MainMod"
Option Explicit

Sub LoopingTwiceFrom0to100()

    Dim i As Long
    Dim j As Long
    
    For j = 0 To 1
        For i = 0 To 100
            tblSomething.Cells(i + 1, j + 1) = i + j
        Next i
    Next j
    
    
End Sub

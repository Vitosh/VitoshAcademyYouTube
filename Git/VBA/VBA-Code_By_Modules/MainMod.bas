Attribute VB_Name = "MainMod"
Option Explicit

Sub LoopingFrom0to100()

    Dim i As Long
    For i = 0 To 100
        tblSomething.Cells(i + 1, 1) = i + i
    Next i
End Sub

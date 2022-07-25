Imports System

Module Program
    Sub Main(args As String())
        Dim myself As bmi = New bmi
        myself.Height = 1.88
        myself.Weight = 63.5
        Console.WriteLine(myself.BMI_Value)
    End Sub
End Module

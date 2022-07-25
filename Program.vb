Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim myself As bmi = New bmi
        myself.Height = 1
        myself.Weight = 1
        Dim you As bmi = New bmi
        you.Height = 1
        you.Weight = 1
        Console.WriteLine(myself.Equals(you))
    End Sub
End Module

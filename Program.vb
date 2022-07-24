Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a number: ")
        Dim sum As Integer
        For i As Integer = 1 To Console.ReadLine()
            sum += i
        Next
        Console.WriteLine(sum)
    End Sub
End Module

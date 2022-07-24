Imports System

Module Program
    Sub Main(args As String())
        Dim sum As Integer
        Dim input As Integer
        Do
            Console.Write("Enter a number: ")
            input = Console.ReadLine()
            If input = -1 Then
                Exit Do
            End If
            sum += input
        Loop
        Console.WriteLine(sum)
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        Dim grades As New Queue(Of Integer)
        Dim sum As Integer
        Do
            Console.Write("Enter a number: ")
            Dim input As Integer = Console.ReadLine()
            If input = -1 Then
                Exit Do
            End If
            grades.Enqueue(input)
            sum += input
        Loop

        Console.WriteLine(sum / grades.Count)

        For i = 0 To grades.Count - 1
            Console.WriteLine(grades.Dequeue)
        Next
    End Sub
End Module

Imports System

Module Program
    Sub Main(args As String())
        Dim sum As Integer
        Do
            Console.Write("Enter a number: ")
            Dim input As Integer = Console.ReadLine()
            If input = -1 Then
                Exit Do
            End If
            sum += input
        Loop
        Console.WriteLine(String.Format("{0:#,#.00}", sum))
    End Sub
End Module

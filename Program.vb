Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a number: ")
        Console.WriteLine(String.Format("{0:D}", DateTime.Now.AddDays(CDbl(Console.ReadLine()))))
    End Sub
End Module

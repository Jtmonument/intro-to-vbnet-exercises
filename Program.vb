Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter your salary: ")
        Console.WriteLine(FormatCurrency(Console.ReadLine(), 2))
    End Sub
End Module

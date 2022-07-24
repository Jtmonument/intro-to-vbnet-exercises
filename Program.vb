Imports System

Module Program
    Sub Main(args As String())
        Console.Write("Enter a number: ")
        Dim input As Integer = CInt(Console.ReadLine())
        If input < 100 Then
            Console.WriteLine("Small")
        ElseIf input > 200 Then
            Console.WriteLine("Large")
        Else
            Console.WriteLine("Medium")
        End If
    End Sub
End Module

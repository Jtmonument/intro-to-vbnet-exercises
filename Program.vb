Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim indata As FileStream = New FileStream("indata.txt", FileMode.Create, FileAccess.Write)
        Dim number As Random = New Random
        Dim writer As StreamWriter = New StreamWriter(indata)
        For i = 0 To 10
            If i = 10 Then
                writer.Write(number.Next(50))
            Else
                writer.Write(number.Next(50) & ", ")
            End If
        Next
        writer.Close()

        indata = New FileStream("indata.txt", FileMode.Open, FileAccess.Read)

        Dim sum As Integer
        Dim reader As StreamReader = New StreamReader(indata)
        For Each num As Integer In reader.ReadLine().Split(", ")
            sum += num
        Next
        reader.Close()
        Console.WriteLine(sum)
    End Sub
End Module

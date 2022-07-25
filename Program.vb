Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim cow1 As New Cow
        Dim cow2 As New Cow
        cow1.height = 50
        cow2.height = 50
        cow1.weight = 50
        cow2.weight = 50
        Dim cows As New List(Of Cow)
        cows.Add(cow1)
        cows.Add(cow2)
        looping(cows)
        cows.Sort()
        looping(cows)

        cow2.weight = 25
        cows.Sort()
        looping(cows)
    End Sub

    Sub looping(cows As IEnumerable)
        For Each cow In cows
            Console.WriteLine(cow.GetHashCode)
        Next
    End Sub
End Module

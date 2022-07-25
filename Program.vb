Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim triangle As Triangle = New Triangle()
        triangle.Height = 3
        triangle.Base = 4
        Console.WriteLine(area(triangle))
    End Sub

    Function area(shape As Shape) As Double
        Return shape.area()
    End Function
End Module

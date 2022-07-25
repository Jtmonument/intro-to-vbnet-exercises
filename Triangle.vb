Public Class Triangle : Inherits Shape

    Public Property Height As Double
        Get
            Return side1
        End Get
        Set(value As Double)
            side1 = value
        End Set
    End Property

    Public Property Base As Double
        Get
            Return side2
        End Get
        Set(value As Double)
            side2 = value
        End Set
    End Property

    Public Overrides Function area() As Double
        Return side1 * side2
    End Function
End Class

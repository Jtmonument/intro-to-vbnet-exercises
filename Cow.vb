Public Class Cow : Implements Animal, IComparable
    Private heightValue As Double
    Private weightValue As Double

    Public Property height As Double Implements Animal.height
        Get
            Return heightValue
        End Get
        Set(value As Double)
            heightValue = value
        End Set
    End Property

    Public Property weight As Double Implements Animal.weight
        Get
            Return weightValue
        End Get
        Set(value As Double)
            weightValue = value
        End Set
    End Property

    Public Function speed() As Double Implements Animal.speed
        ' Just return w x h
        Return weightValue * heightValue
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim animal As Animal = CType(obj, Animal)
        Dim weightBool As Integer = weightValue.CompareTo(animal.weight)
        Dim heightBool As Integer = heightValue.CompareTo(animal.height)
        Dim speedBool As Integer = speed().CompareTo(animal.speed)
        Return weightBool + heightBool + speedBool
    End Function
End Class

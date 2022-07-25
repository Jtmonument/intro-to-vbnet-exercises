Public Class bmi
    Private bmiHeight As Decimal
    Private bmiWeight As Decimal

    Public Property Height As Decimal
        Get
            Return bmiHeight
        End Get
        Set(value As Decimal)
            bmiHeight = value
        End Set
    End Property

    Public Property Weight As Decimal
        Get
            Return bmiWeight
        End Get
        Set(value As Decimal)
            bmiWeight = value
        End Set
    End Property

    Public Function BMI_Value() As Decimal
        Return bmiWeight / (bmiHeight ^ 2)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim bmiObject As bmi = obj
        Return bmiHeight = bmiObject.bmiHeight AndAlso bmiWeight = bmiObject.bmiWeight
    End Function
End Class

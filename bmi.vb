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

    Function BMI_Value() As Decimal
        Return bmiWeight / (bmiHeight ^ 2)
    End Function
End Class

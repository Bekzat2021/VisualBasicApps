Module Module1

    Sub Main()

        Dim pointOne As New Point()
        pointOne.X = 5
        pointOne.Y = 7

        Dim pointTwo As New Point()
        pointTwo.X = 3
        pointTwo.Y = 2

        Dim pointThree = pointOne + pointTwo

        Console.WriteLine($"{pointThree.X}, {pointThree.Y}")

    End Sub

    Public Class Point
        Public Property X() As Integer
        Public Property Y() As Integer

        Public Shared Operator +(firstPoint As Point, secondPoint As Point) As Point
            Dim newPoint As New Point()
            newPoint.X = firstPoint.X + secondPoint.X
            newPoint.Y = firstPoint.Y + secondPoint.Y
            Return newPoint
        End Operator


    End Class

End Module


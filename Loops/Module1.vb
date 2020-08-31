Module Module1

    Enum MathOperations
        Add = 1
        Subtract
        Multiply
        Devide
    End Enum

    Sub Main()
        Console.Write("Enter first value: ")
        Dim value1 As Double = CDbl(Console.ReadLine())

        Console.Write("Enter second value: ")
        Dim value2 As Double = CDbl(Console.ReadLine())

        Console.Write("Enter operation code: ")
        Dim operation As MathOperations = CInt(Console.ReadLine())

        Calculate(value1, value2, operation)

    End Sub

    Sub Calculate(ByVal input1 As Double, ByVal input2 As Double,
                  opertaion As MathOperations)
        Dim result As Double = 0
        Select Case opertaion
            Case MathOperations.Add
                result = input1 + input2
            Case MathOperations.Subtract
                result = input1 - input2
            Case MathOperations.Multiply
                result = input1 * input2
            Case MathOperations.Devide
                result = input1 / input2
        End Select
        Console.WriteLine("Result of opertion {0} {1} {2} = {3}", input1, opertaion, input2, result)
    End Sub

End Module

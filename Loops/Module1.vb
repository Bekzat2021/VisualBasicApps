Module Module1

    Sub Main()

        Dim random As New Random()
        Dim numbers(10) As Integer

        For i As Integer = 0 To numbers.Length - 1
            numbers(i) = random.Next(10)
            Console.Write(numbers(i) & " ")
        Next
        Console.WriteLine()

        Dim temp As Integer
        For i As Integer = 0 To numbers.Length - 1
            For j As Integer = i + 1 To numbers.Length - 1
                If numbers(i) > numbers(j) Then
                    temp = numbers(i)
                    numbers(i) = numbers(j)
                    numbers(j) = temp
                End If
            Next
        Next

        For i As Integer = 0 To numbers.Length - 1
            Console.Write(numbers(i) & " ")
        Next
        Console.WriteLine()

    End Sub

End Module

Module Module1

    Sub Main()
        Dim rnd As New Random()
        Dim value As Integer

        For i As Integer = 1 To 200
            value = rnd.Next(100)
            If value = 55 Then
                Console.Write("Value 55 finded in loop ")
                Console.WriteLine($"at {i} iteration")
                Exit For
            ElseIf i = 200 Then
                Console.WriteLine("Value 55 not found in loop")
            End If
        Next
    End Sub

End Module

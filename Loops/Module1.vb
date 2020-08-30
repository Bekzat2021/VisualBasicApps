Module Module1

    Sub Main()

        Console.WriteLine("Введите путь к файлу: ")
        Dim path As String = Console.ReadLine()
        Dim number As Integer = Modules.Module2.Read(path)
        Console.WriteLine("Факториал числа {0} равен {1}", number,
        Factorial(number))

    End Sub

    Function Factorial(x As Integer) As Integer
        If x = 1 Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function

End Module

Module Module1

    Sub Main()

        Dim s1 As State = New State("US")

        Dim s2 As State = New State("UK")

    End Sub

    Public Class State
        Public Name As String
        Shared Sub New()
            Console.WriteLine("Made first state")
        End Sub

        Sub New(ByVal name As String)
            Me.Name = name
            Console.WriteLine("State name {0}", name)
        End Sub

    End Class

End Module


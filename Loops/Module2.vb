Imports System.IO
Namespace Modules

    Module Module2

        Function Read(path As String) As Integer
            Dim number As Integer
            Try
                Dim sr As New StreamReader(path)
                number = Int32.Parse(sr.ReadLine())
                sr.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Return number
        End Function

    End Module

End Namespace

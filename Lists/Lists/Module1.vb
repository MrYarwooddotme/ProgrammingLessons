﻿Module Module1
    Sub Main()
        Dim names As New List(Of String)

        names.Add("Matthew")

        names.Add("Mark")

        names.Add("Luke")

        names.Add("John")

        names.RemoveAt(1)

        Console.WriteLine(names(1))
    End Sub
End Module

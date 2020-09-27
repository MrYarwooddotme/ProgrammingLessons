Module Module1
    Sub Main()
        Dim name, colour As String

        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        Console.WriteLine("What is your favourite colour?")
        colour = Console.ReadLine()
        Console.WriteLine("Hello {0} your favourite colour is {1}", name, colour)

        Console.ReadKey()
    End Sub
End Module

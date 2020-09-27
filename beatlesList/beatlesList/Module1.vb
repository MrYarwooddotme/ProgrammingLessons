Module Module1
    Sub Main()
        dim beatles as new list(of String)
        dim beatle As String
        beatles.Add("Paul")
        beatles.Add("John")
        beatles.Add("Ringo")
        beatles.Add("George")
        beatles.Add("Pete")
        beatles.Add("Stuart")
        for i = 0 to beatles.count - 1
            Console.WriteLine(beatles(i))
        Next
        Console.WriteLine("Who would you like to remove?")
        beatle = console.ReadLine()
        if Char.isDigit(beatle) Then
            beatles.RemoveAt(beatle)
        Else
            for b = 0 to beatles.count - 1
            beatles.Remove(beatle)    
            Next
        End If
        
        for c = 0 to beatles.count - 1
            Console.WriteLine(beatles(c))
        Next  
    End Sub
End Module

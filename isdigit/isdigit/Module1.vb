Module Module1
    Sub Main()
        dim happiness as String
        Console.WriteLine("How happy are you? Clap hands or stamp feet?")
        happiness = console.ReadLine(happiness)
        if Char.isdigit(happiness) Then
            if happiness > 1 And happiness < 10 Then
                clap()
            else 
                stamp()
            End If
        Else    
            if happiness = "clap" Then
                clap()
            Else
                stamp()
            End If
        End If
    End Sub
    Sub clap()
        console.WriteLine("Clap hands")
        Main()
    End Sub
    sub stamp()
        Console.WriteLine("Stamp Feet")
        Main()
    End sub
    
End Module

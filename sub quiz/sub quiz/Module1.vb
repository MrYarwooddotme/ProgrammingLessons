Module Module1
    Sub Main()
        dim age as Integer
        console.writeline("what is your age?")
        age = console.ReadLine()
        if age > 14 Then
            Accept()
        Else 
            Deny()
        End If
        
    End Sub
    sub Accept()
        Console.WriteLine("You can watch the film")
        Main()
    End sub
    
    sub Deny()
        Console.WriteLine("You have tried to access non-age appropriate material, 
your parent/ gaurdian has been notified via SMS")
        Main()
    End sub
End Module

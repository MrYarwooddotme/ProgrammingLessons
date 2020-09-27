Module Module1
    Sub Main()
        '1A Hello
        Console.WriteLine("Hello World")
        
        '1B Hello lines
        Console.WriteLine("Hello!")
        Console.WriteLine("World!")
        
        '1C Happy birthday
        Console.WriteLine("Happy birthday to you")
        Console.WriteLine("Happy birthday to you")
        Console.WriteLine("Happy birthday dear Marcus Rashford!")
        Console.WriteLine("Happy birthday to you!")
        
        '1D Multiply
        Console.WriteLine(1920*1080)
        
        '1E Percentage
        Console.WriteLine("{0:p2}", 0.763)
        Console.ReadKey()
        
        dim name as String
        Console.writeline("What is your name?")
        name = console.ReadLine()
        Console.writeLine("Hello " & name)
    End Sub
End Module

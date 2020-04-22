Imports MijnLibrary


Module Module1

    Sub Main(args As String())

        Dim c As New Calculator

        Dim invoer = args(0)

        Dim getal = c.Square(invoer)

        Console.WriteLine("Het antwoord is " & getal)

        Console.ReadLine()
    End Sub

End Module

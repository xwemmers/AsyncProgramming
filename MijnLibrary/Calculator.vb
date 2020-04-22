Imports System.Threading

Public Class Calculator

    Public Function Add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Public Function Subtract(a As Integer, b As Integer) As Integer
        Return a - b
    End Function

    Public Function Multiply(a As Integer, b As Integer) As Integer
        Return a * b
    End Function

    Public Function Square(a As Integer) As Integer
        'Vertraag de berekening om een kunstmatig trage functie te simuleren
        Thread.Sleep(a * 1000)
        Return a * a
    End Function

    ' Asynchroon programmeren gebeurt in .NET met Tasks

    Public Function SquareAsync(a As Integer) As Task(Of Integer)
        'Als parameter aan de nieuwe Task wordt een lambda expressie meegegeven

        Dim t = New Task(Of Integer)(Function() Square(a))

        t.Start()

        Return t
    End Function

End Class

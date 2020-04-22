Imports MijnLibrary

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getal As Integer = txtGetal.Text

        Dim c As New Calculator

        Dim antwoord = c.Square(getal)

        lbx.Items.Add($"Het kwadraat van {getal} is {antwoord}.")
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim getal As Integer = txtGetal.Text

        Dim c As New Calculator

        'Button2.Enabled = False

        lbx.Items.Add($"Ik begin met getal {getal}...")


        Dim antwoord = Await c.SquareAsync(getal)

        lbx.Items.Add($"Het kwadraat van {getal} is {antwoord}.")

        'Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim a1 As Action = AddressOf ShowHello

        Parallel.Invoke(a1, AddressOf ShowWorld)
    End Sub


    Sub ShowHello()
        MessageBox.Show("Hello")
    End Sub

    Sub ShowWorld()
        MessageBox.Show("World")
    End Sub

    Sub ShowString(str As String)
        MessageBox.Show(str)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim namen As New List(Of String)
        namen.Add("Azz-Eddine")
        namen.Add("Thijs")
        namen.Add("Ferdi")
        namen.Add("Jeroen")
        namen.Add("Xander")

        'Deze zal 5 Tasks opstarten en de vijf namen meegeven aan de ShowString functie
        Parallel.ForEach(namen, AddressOf ShowString)

    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c As New Calculator

        Dim taak1 = c.SquareAsync(10)
        Dim taak2 = c.SquareAsync(2)
        Dim taak3 = c.SquareAsync(5)

        Dim antwoord1 = Await taak1
        Dim antwoord2 = Await taak2
        Dim antwoord3 = Await taak3

        lbx.Items.Add($"Antwoord 1 is {antwoord1}")
        lbx.Items.Add($"Antwoord 2 is {antwoord2}")
        lbx.Items.Add($"Antwoord 3 is {antwoord3}")

    End Sub
End Class
